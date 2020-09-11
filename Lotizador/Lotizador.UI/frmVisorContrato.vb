Imports System.IO
Imports Lotizador.UI.LotizadorService
Imports Microsoft.Office

Public Class frmVisorContrato
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _ContratoBE As ContratoBE
    Public Property ContratoBEEdit() As ContratoBE
        Get
            Return _ContratoBE
        End Get
        Set(ByVal value As ContratoBE)
            _ContratoBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmVisorContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenFile()
    End Sub

    Protected Friend Sub OpenFile()
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "exec upObtenerInformacionPorContrato " & ContratoBEEdit.IdContrato
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)

        Dim appw As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()

        Dim fileName As Object = Directory.GetCurrentDirectory + "\Contrato.dotx"
        appw.Visible = True
        appw.Application.Activate()
        'appw.ActiveWindow.ShowSourceDocuments

        Dim objdoc As Microsoft.Office.Interop.Word.Document = appw.Application.Documents.Open(fileName)

        ReplaceBookmarkText(objdoc, "NombreVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("NombreVendedor")))
        ReplaceBookmarkText(objdoc, "DireccionVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("DireccionVendedor")))
        'DistritoContrato
        ReplaceBookmarkText(objdoc, "ImporteMora", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ImporteMora")))
        ReplaceBookmarkText(objdoc, "ImporteTotal", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ImporteTotal")))
        ReplaceBookmarkText(objdoc, "ImporteTotalLetras", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ImporteTotalLetras")))
        'ImporteTotalLetras
        'LinderoDerecha
        'LinderoFondo
        'LinderoFrente
        'LinderoIzquierda
        'LoteContrato
        'ManzanaLote
        'NombreContrato
        'NombreVendedor
        'NumeroDocumentoVendedor
        'PartidaRegistral
        ReplaceBookmarkText(objdoc, "SimboloMoneda", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("SimboloMoneda")))
        'SuperficieLote
        'TipoDocumentoVendedor

    End Sub

    Public Function EvaluaCelda(ByVal valorcelda As Object) As Object
        If (valorcelda Is Nothing) Then
            Return " "
        Else
            Return valorcelda
        End If
    End Function

    Public Sub ReplaceBookmarkText(ByVal objdoc As Microsoft.Office.Interop.Word.Document, ByVal BookmarkName As String, ByVal NewText As Object)
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


End Class