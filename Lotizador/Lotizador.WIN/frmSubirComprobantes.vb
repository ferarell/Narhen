Imports System.IO
Imports System.Configuration
Imports System.Net
Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmSubirComprobantes

    Private FTP_URL As String = ConfigurationManager.AppSettings("_FTP_URL").ToString()
    Private FTP_USR As String = ConfigurationManager.AppSettings("_FTP_USR").ToString()
    Private FTP_PWD As String = ConfigurationManager.AppSettings("_FTP_PWD").ToString()

    Private Sub btnSeleccionarCarpeta_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCarpeta.Click
        If Me.FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Me.lblCarpeta.Text = Me.FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnSubirArchivos_Click(sender As Object, e As EventArgs) Handles btnSubirArchivos.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim rutaCarpeta As String = Me.lblCarpeta.Text
            Dim nombreCarpeta As String = rutaCarpeta.Substring(rutaCarpeta.LastIndexOf("\") + 1) & "/"
            Dim archivoTxt As String = ""
            Dim contador As Integer = 0
            Dim oLogBE As New LogBE()
            Dim oLogBL As New LogBL()
            If Directory.Exists(rutaCarpeta) Then
                CrearCarpetaFTP(nombreCarpeta)
                For Each rutaTxt As String In My.Computer.FileSystem.GetFiles(rutaCarpeta, FileIO.SearchOption.SearchTopLevelOnly, "*.txt")
                    archivoTxt = rutaTxt.Substring(rutaTxt.LastIndexOf("\") + 1)
                    My.Computer.Network.UploadFile(rutaTxt, FTP_URL & nombreCarpeta & archivoTxt, FTP_USR, FTP_PWD, True, 500, FileIO.UICancelOption.DoNothing)
                    With oLogBE
                        .log_fecha = Today.ToString("yyyy-MM-dd")
                        .log_hora = Now.ToString("HH:mm:ss")
                        .log_archivo = archivoTxt
                        .log_usuario = Funciones.USUARIO
                    End With
                    oLogBL.Registrar(oLogBE)
                    contador = contador + 1
                Next
                If contador > 0 Then
                    MessageBox.Show("Se subieron todos los archivos al servidor satisfactoriamente", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("En la carpeta seleccionada no hay archivos TXT para subir al servidor", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("La carpeta no existe", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub CrearCarpetaFTP(nombreCarpeta As String)
        Try
            Dim filename As String = FTP_URL & nombreCarpeta
            Dim ftpReq As System.Net.FtpWebRequest = System.Net.WebRequest.Create(filename)
            ftpReq.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory
            ftpReq.Credentials = New System.Net.NetworkCredential(FTP_USR, FTP_PWD)
            Dim ftpResp As System.Net.FtpWebResponse = ftpReq.GetResponse
            'MsgBox(ftpResp.StatusDescription)
        Catch ex As WebException
            Dim response As FtpWebResponse = DirectCast(ex.Response, FtpWebResponse)
            If response.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
                ' No hacemos nada porque el directorio ya existe
            Else
                Throw ex
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class