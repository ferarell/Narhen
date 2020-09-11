Imports Lotizador.UI.LotizadorService
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmSecuencias
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub PoblarGrillaSecuencias()
        Dim oSecuenciaBE As SecuenciaBE = New SecuenciaBE()
        Dim listSecuencias As List(Of SecuenciaBE) = New List(Of SecuenciaBE)(oNarhemService.ObtenerSecuenciaPorCriterio(oSecuenciaBE))
        Me.gcSecuencias.DataSource = listSecuencias
    End Sub

    Private Sub frmSecuencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaSecuencias()
    End Sub


    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupSecuencias = New frmPopupSecuencias()
        Dim oSecuenciaEdit As SecuenciaBE = New SecuenciaBE()
        oSecuenciaEdit.IdSecuencia = -1
        oFormDialog.SecuenciaBEEdit = oSecuenciaEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaSecuencias()
        End If
    End Sub


    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oSecuenciaBE As SecuenciaBE
        If gcSecuencias.MainView.Name = "GridView1" Then
            oSecuenciaBE = GridView1.GetFocusedRow
        Else
            oSecuenciaBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupSecuencias = New frmPopupSecuencias()
        oFormDialog.SecuenciaBEEdit = oSecuenciaBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaSecuencias()
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcSecuencias_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcSecuencias.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oSecuenciaBE As SecuenciaBE
        If gcSecuencias.MainView.Name = "GridView1" Then
            oSecuenciaBE = GridView1.GetFocusedRow
        Else
            oSecuenciaBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarSecuencia(oSecuenciaBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaSecuencias()
            End If
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As SecuenciaBE = CType(GridView1.GetRow(e.FocusedRowHandle), SecuenciaBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub gcSecuencias_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcSecuencias.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcSecuencias)
        End If
    End Sub
End Class