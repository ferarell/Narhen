Imports Lotizador.UI.LotizadorService
Imports System.IO
Imports Microsoft.Office.Interop


Public Class frmUnidadesCatastrales
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmUnidadesCatastrales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaUnidadesCatastrales()
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Public Sub PoblarGrillaUnidadesCatastrales()
        Dim oUnidadCatastralBE As UnidadCatastralBE = New UnidadCatastralBE()
        Dim listUnidadesCatastrales As List(Of UnidadCatastralBE) = New List(Of UnidadCatastralBE)(oNarhemService.ObtenerUnidadCatastralPorCriterio(oUnidadCatastralBE))
        Me.gcUnidadesCatastrales.DataSource = listUnidadesCatastrales
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupUnidadesCatastrales = New frmPopupUnidadesCatastrales()
        Dim oUnidadCatastralEdit As UnidadCatastralBE = New UnidadCatastralBE()
        oUnidadCatastralEdit.IdUnidadCatastral = -1
        oFormDialog.UnidadCatastralBEEdit = oUnidadCatastralEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaUnidadesCatastrales()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oUnidadCatastralBE As UnidadCatastralBE
        If gcUnidadesCatastrales.MainView.Name = "GridView1" Then
            oUnidadCatastralBE = GridView1.GetFocusedRow
        Else
            oUnidadCatastralBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupUnidadesCatastrales = New frmPopupUnidadesCatastrales()
        oFormDialog.UnidadCatastralBEEdit = oUnidadCatastralBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaUnidadesCatastrales()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oUnidadCatastralBE As UnidadCatastralBE
        If gcUnidadesCatastrales.MainView.Name = "GridView1" Then
            oUnidadCatastralBE = GridView1.GetFocusedRow
        Else
            oUnidadCatastralBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarUnidadCatastral(oUnidadCatastralBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaUnidadesCatastrales()
            End If
        End If
    End Sub

    Private Sub gcUnidadesCatastrales_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcUnidadesCatastrales.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiVistaGrilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaGrilla.ItemClick
        gcUnidadesCatastrales.MainView = GridView1
    End Sub

    Private Sub bbiTarjeta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarjeta.ItemClick
        gcUnidadesCatastrales.MainView = CardView1
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As UnidadCatastralBE = CType(GridView1.GetRow(e.FocusedRowHandle), UnidadCatastralBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub gcUnidadesCatastrales_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcUnidadesCatastrales.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcUnidadesCatastrales)
        End If
    End Sub

    Private Sub bbiDeshacer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDeshacer.ItemClick

    End Sub
End Class