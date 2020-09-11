Imports Lotizador.UI.LotizadorService

Public Class frmTiposCambio
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmTiposCambio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaTiposCambio()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupTiposCambio = New frmPopupTiposCambio()
        Dim oMonedaTipoCambioEdit As MonedaTipoCambioBE = New MonedaTipoCambioBE()
        oMonedaTipoCambioEdit.IdMoneda = -1
        oFormDialog.oMonedaTipoCambioBEEdit = oMonedaTipoCambioEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaTiposCambio()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oMonedaTipoCambioBE As MonedaTipoCambioBE = CardView1.GetFocusedRow()
        Dim oFormDialog As frmPopupTiposCambio = New frmPopupTiposCambio()
        oFormDialog.oMonedaTipoCambioBEEdit = oMonedaTipoCambioBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaTiposCambio()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oMonedaTipoCambioBE As MonedaTipoCambioBE = CardView1.GetFocusedRow()
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarMonedaTipoCambio(oMonedaTipoCambioBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaTiposCambio()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcTiposCambio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcTiposCambio.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Public Sub PoblarGrillaTiposCambio()
        Dim oMonedaTipoCambioBE As MonedaTipoCambioBE = New MonedaTipoCambioBE()
        Dim listTiposCambio As List(Of MonedaTipoCambioBE) = New List(Of MonedaTipoCambioBE)(oNarhemService.ObtenerMonedaTipoCambio(oMonedaTipoCambioBE))
        Me.gcTiposCambio.DataSource = listTiposCambio

    End Sub

    Private Sub CardView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles CardView1.FocusedRowChanged
        Dim dgrItem As MonedaTipoCambioBE = CType(CardView1.GetRow(e.FocusedRowHandle), MonedaTipoCambioBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub


End Class