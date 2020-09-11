Imports Lotizador.UI.LotizadorService
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmLotes
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaLotes()
    End Sub

    Public Sub PoblarGrillaLotes()
        Dim oLoteBE As LoteBE = New LoteBE()
        Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)(oNarhemService.ObtenerLotePorCriterio(oLoteBE))
        Me.gcLotes.DataSource = listLotes
    End Sub


    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupLotes = New frmPopupLotes()
        Dim oLoteEdit As LoteBE = New LoteBE()
        oLoteEdit.IdLote = -1
        oFormDialog.LoteBEEdit = oLoteEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaLotes()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oLoteBE As LoteBE
        If gcLotes.MainView.Name = "GridView1" Then
            oLoteBE = GridView1.GetFocusedRow
        Else
            oLoteBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupLotes = New frmPopupLotes()
        oFormDialog.LoteBEEdit = oLoteBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaLotes()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oLoteBE As LoteBE
        If gcLotes.MainView.Name = "GridView1" Then
            oLoteBE = GridView1.GetFocusedRow
        Else
            oLoteBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarLote(oLoteBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Eliminacion Satisfactoria")
                PoblarGrillaLotes()
            End If
        End If
    End Sub

    Private Sub gcLotes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcLotes.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiVistaGrilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaGrilla.ItemClick
        gcLotes.MainView = GridView1
    End Sub

    Private Sub bbiTarjeta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarjeta.ItemClick
        gcLotes.MainView = CardView1
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As LoteBE = CType(GridView1.GetRow(e.FocusedRowHandle), LoteBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub


    Private Sub gcLotes_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcLotes.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcLotes)
        End If
    End Sub
End Class