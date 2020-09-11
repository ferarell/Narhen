Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors

Public Class frmUsuario
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub PoblarGrillaUsuarios()
        Dim oUsuarioBE As UsuarioBE = New UsuarioBE()
        Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)(oNarhemService.ObtenerUsuarioPorCriterio(oUsuarioBE))
        Me.gcUsuario.DataSource = listUsuarios

    End Sub

    Private Sub DFSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaUsuarios()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupUsuarios = New frmPopupUsuarios()
        Dim oUsuarioEdit As UsuarioBE = New UsuarioBE()
        oUsuarioEdit.IdUsuario = -1
        oFormDialog.oUsuarioBEEdit = oUsuarioEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaUsuarios()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oUsuarioBE As UsuarioBE = GridView1.GetFocusedRow()
        Dim oFormDialog As frmPopupUsuarios = New frmPopupUsuarios()
        oFormDialog.oUsuarioBEEdit = oUsuarioBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaUsuarios()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oUsuarioBE As UsuarioBE = GridView1.GetFocusedRow()
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarUsuario(oUsuarioBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaUsuarios()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcSocios_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiTarjeta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarjeta.ItemClick
        Me.gcUsuario.MainView = CardView1
    End Sub

    Private Sub bbiVistaGrilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaGrilla.ItemClick
        gcUsuario.MainView = GridView1
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As UsuarioBE = CType(GridView1.GetRow(e.FocusedRowHandle), UsuarioBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub


    Private Sub gcUsuario_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcUsuario.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcUsuario)
        End If
    End Sub
End Class