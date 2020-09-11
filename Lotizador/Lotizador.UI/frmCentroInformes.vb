Imports Lotizador.UI.LotizadorService

Public Class frmCentroInformes
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmCentroInformes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dtURL As DataTable = General.RetrieveUrlReportServer
        Dim sUrl As New Uri(dtURL.Rows(0).Item(0))
        WebBrowser1.Url = sUrl
        WebBrowser1.Show()
    End Sub
End Class