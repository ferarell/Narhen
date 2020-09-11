Imports Lotizador.UI.LotizadorService

Public Class frmMonedas
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaMonedas()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupMonedas = New frmPopupMonedas()
        Dim oMonedaEdit As MonedaBE = New MonedaBE()
        oMonedaEdit.IdMoneda = -1
        oFormDialog.MonedaBEEdit = oMonedaEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaMonedas()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oMonedaBE As MonedaBE = CardView1.GetFocusedRow()
        Dim oFormDialog As frmPopupMonedas = New frmPopupMonedas()
        oFormDialog.MonedaBEEdit = oMonedaBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaMonedas()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oMonedaBE As MonedaBE = CardView1.GetFocusedRow()
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarMoneda(oMonedaBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaMonedas()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcMonedas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcMonedas.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Public Sub PoblarGrillaMonedas()
        Dim oMonedaBE As MonedaBE = New MonedaBE()
        Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)(oNarhemService.ObtenerMonedaPorCriterio(oMonedaBE))
        Me.gcMonedas.DataSource = listMonedas

    End Sub

    Private Sub CardView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles CardView1.FocusedRowChanged
        Dim dgrItem As MonedaBE = CType(CardView1.GetRow(e.FocusedRowHandle), MonedaBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub
End Class