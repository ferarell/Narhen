Imports Lotizador.UI.LotizadorService
Imports CrystalDecisions.Shared
Imports Microsoft.Office.Interop
Imports System.IO

Module General
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Friend oGeneralBE As New GeneralBE
    Friend SkinName As String
    'Friend skinMask As String = "Skin: "
    'Friend SkinNavMask As String = "SkinNav: "
    Friend IdUsuario As Integer
    Friend NombreUsuario, CuentaUsaurio As String

    Friend Function SaveErrorException(ByVal ex As Exception, ByVal objeto As String) As Boolean
        Try
            Dim oListaErrorBE As New ListaErrorBE
            oListaErrorBE.Atendido = "N"
            oListaErrorBE.DescripcionError = Left(ex.Message.ToString, 300) 'Utility.TruncateString.fnTruncateString(ex.Message.ToString(), 300, Utility.TruncateString.TruncateOptions.None);
            oListaErrorBE.Ubicacion = Left(ex.TargetSite.ToString, 50) 'Utility.TruncateString.fnTruncateString(ex.TargetSite.ToString(), 50, Utility.TruncateString.TruncateOptions.None);
            oListaErrorBE.NombreError = IIf(ex.InnerException.Message = Nothing, "", Left(ex.InnerException.Message.ToString, 50)) 'ex.InnerException == null ? "" : Utility.TruncateString.fnTruncateString(ex.InnerException.Message.ToString(), 50, Utility.TruncateString.TruncateOptions.None);
            oListaErrorBE.NombreObjeto = Left(objeto.ToString, 30) 'Utility.TruncateString.fnTruncateString(objeto.ToString(), 30, Utility.TruncateString.TruncateOptions.None);
            oListaErrorBE.Usuario = IdUsuario
            oListaErrorBE.FechaHora = DateTime.Now
            oListaErrorBE.FechaCreacion = DateTime.Now
            oListaErrorBE.FechaModificacion = DateTime.Now
            oListaErrorBE.UsuarioCreacion = IdUsuario
            oListaErrorBE.UsuarioModificacion = IdUsuario
            oNarhemService.InsertarListaError(oListaErrorBE)
            Return True
        Catch e As Exception
            Return False
        End Try
    End Function

    Function ObtenerUsuario(ByVal CodigoUsuario As Int32) As UsuarioBE
        Return oNarhemService.ObtenerUsuarioPorId(CodigoUsuario)
    End Function

    Friend Sub SetCurrentValuesForParameterField(ByVal myParameterFields As ParameterFields, ByVal myArrayList As ArrayList)
        Dim nIndex As Integer = 0
        For Each submittedValue As Object In myArrayList
            Dim currentParameterValues As ParameterValues = New ParameterValues()
            Dim myParameterDiscreteValue As ParameterDiscreteValue = New ParameterDiscreteValue()
            myParameterDiscreteValue.Value = submittedValue
            currentParameterValues.Add(myParameterDiscreteValue)
            ' Asigna nuevos valores al parámetro
            Dim myParameterField As ParameterField = myParameterFields(nIndex)
            myParameterField.CurrentValues = currentParameterValues
            nIndex = nIndex + 1
        Next
    End Sub

    Friend Function EvaluaCelda(ByVal valorcelda As Object) As Object
        If (valorcelda Is Nothing) Then
            Return " "
        Else
            Return valorcelda
        End If
    End Function

    Friend Sub ReplaceBookmarkText(ByVal objdoc As Microsoft.Office.Interop.Word.Document, ByVal BookmarkName As String, ByVal NewText As Object)
        Try
            If (objdoc.Bookmarks.Exists(BookmarkName)) Then
                Dim name As Object = BookmarkName
                Dim rng As Microsoft.Office.Interop.Word.Range = objdoc.Bookmarks.Item(name).Range
                rng.Text = NewText.ToString().Trim()
                Dim range As Object = rng
                objdoc.Bookmarks.Add(BookmarkName, range)
            End If

        Catch ex As Exception
            Throw New Exception("Error" + ex.Message, ex)
        End Try
    End Sub

    Friend Function RetrieveCReportConn() As DataTable
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "select Codigo, valor from variable where Nombre = 'CReportCnx'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Return oGeneralBE.dtResult
    End Function

    Friend Function RetrieveUrlReportServer() As DataTable
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "select valor from variable where Nombre = 'ReportServer'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Return oGeneralBE.dtResult
    End Function

    Friend Sub ObtenerEstilo()
        oGeneralBE.SqlTxt = "SELECT LookAndFeel FROM dbo.Usuario WHERE IdUsuario = '" & IdUsuario & "'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        If oGeneralBE.dtResult.Rows.Count > 0 Then
            SkinName = oGeneralBE.dtResult.Rows(0).Item("LookAndFeel")
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("")
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinName)
            mdiPrincipal.nbcMenuPrincipal.PaintStyleName = SkinName
        End If
    End Sub

    Friend Sub GuardarEstilo()
        oGeneralBE.SqlTxt = "UPDATE dbo.Usuario SET LookAndFeel = '" & DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel.ActiveSkinName & "' WHERE IdUsuario = '" & IdUsuario & "'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
    End Sub

    Public Function GetPapersizeID(ByVal PrinterName As String, ByVal PaperSizeName As String) As Integer
        Dim doctoprint As New System.Drawing.Printing.PrintDocument()
        Dim PaperSizeID As Integer = 0
        Dim ppname As String = ""
        Dim s As String = ""
        doctoprint.PrinterSettings.PrinterName = PrinterName
        For i As Integer = 0 To doctoprint.PrinterSettings.PaperSizes.Count - 1
            Dim rawKind As Integer
            ppname = PaperSizeName
            If doctoprint.PrinterSettings.PaperSizes(i).PaperName = ppname Then
                rawKind = CInt(doctoprint.PrinterSettings.PaperSizes(i).GetType().GetField("kind", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic).GetValue(doctoprint.PrinterSettings.PaperSizes(i)))
                PaperSizeID = rawKind
                Exit For
            End If
        Next
        Return PaperSizeID
    End Function

    Friend Sub ExportarExcel(sender As System.Object)
        Dim sPath As String = Path.GetTempPath
        Dim sFileName = FileIO.FileSystem.GetTempFileName + ".xls"
        sender.MainView.ExportToExcelOld(sFileName)
        Dim oXls As New Excel.Application 'Crea el objeto excel 
        oXls.Workbooks.Open(sFileName, , True) 'El true es para abrir el archivo en modo Solo lectura (False si lo quieres de otro modo)
        oXls.Visible = True
        oXls.WindowState = Excel.XlWindowState.xlMaximized 'Para que la ventana aparezca maximizada.
    End Sub

    Friend Sub TextToSpeak(sText As String)
        If My.Settings.SpeechEnabled Then
            Dim t As New System.Threading.Thread(AddressOf SpeechThread)
            t.Start(sText)
        End If
    End Sub

    Private Sub SpeechThread(sText As String)
        Try
            Dim sapi
            sapi = CreateObject("sapi.spvoice")
            sapi.speak(sText)
        Catch ex As Exception
            My.Settings.SpeechEnabled = False
            My.Settings.Save()
        End Try
    End Sub

End Module
