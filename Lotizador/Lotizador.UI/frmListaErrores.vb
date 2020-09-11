Imports Lotizador.UI.LotizadorService

Public Class frmListaErrores
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub PoblarGrillaListaErrors()
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "select * from ListaError"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Me.gcEventos.DataSource = oGeneralBE.dtResult
    End Sub

    Private Sub frmListaErrores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaListaErrors()
    End Sub

    Private Sub gvListaErrores_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As DataRowView = GridView1.GetRow(e.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub bbiAtender_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAtender.ItemClick

    End Sub

    Private Sub gcListaErrores_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcEventos.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcEventos)
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcEventos_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gcEventos.DoubleClick

    End Sub
End Class