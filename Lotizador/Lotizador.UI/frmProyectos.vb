Imports Lotizador.UI.LotizadorService
Imports System.IO
Imports Microsoft.Office.Interop


Public Class frmProyectos
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private Sub frmProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaProyectos()
    End Sub

    Public Sub PoblarGrillaProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.gcProyectos.DataSource = listProyectos
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupProyectos = New frmPopupProyectos()
        Dim oProyectoEdit As ProyectoBE = New ProyectoBE()
        oProyectoEdit.IdProyecto = -1
        oFormDialog.ProyectoBEEdit = oProyectoEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaProyectos()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oProyectoBE As ProyectoBE
        If gcProyectos.MainView.Name = "GridView1" Then
            oProyectoBE = GridView1.GetFocusedRow
        Else
            oProyectoBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupProyectos = New frmPopupProyectos()
        oFormDialog.ProyectoBEEdit = oProyectoBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaProyectos()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oProyectoBE As ProyectoBE
        If gcProyectos.MainView.Name = "GridView1" Then
            oProyectoBE = GridView1.GetFocusedRow
        Else
            oProyectoBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarProyecto(oProyectoBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaProyectos()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcProyectos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiVistaGrilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaGrilla.ItemClick
        gcProyectos.MainView = GridView1
    End Sub

    Private Sub bbiTarjeta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarjeta.ItemClick
        gcProyectos.MainView = CardView1
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As ProyectoBE = CType(GridView1.GetRow(e.FocusedRowHandle), ProyectoBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub gcProyectos_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcProyectos.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcProyectos)
        End If
    End Sub
End Class