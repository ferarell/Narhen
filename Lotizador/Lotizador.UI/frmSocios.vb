Imports Lotizador.UI.LotizadorService
Imports System.IO
Imports Microsoft.Office.Interop

Public Class frmSocios
    Dim oNarhemService As NarhenClient = New NarhenClient()
    'Dim oView As New Object

    Public Sub PoblarGrillaSocios()
        Dim oSocioBE As SocioBE = New SocioBE()
        Dim listSocios As List(Of SocioBE) = New List(Of SocioBE)(oNarhemService.ObtenerSocioPorCriterio(oSocioBE))
        Me.gcSocios.DataSource = listSocios
        'oView = gcSocios.MainView.SourceRow
    End Sub

    Private Sub DFSocios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'oView = gcSocios.MainView.SourceRow
        PoblarGrillaSocios()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupSocios = New frmPopupSocios()
        Dim oSocioEdit As SocioBE = New SocioBE()
        oSocioEdit.IdSocio = -1
        oFormDialog.SocioBEEdit = oSocioEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaSocios()
        End If
    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oSocioBE As SocioBE
        If gcSocios.MainView.Name = "GridView1" Then
            oSocioBE = GridView1.GetFocusedRow
        Else
            oSocioBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupSocios = New frmPopupSocios()
        oFormDialog.SocioBEEdit = oSocioBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaSocios()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oSocioBE As SocioBE
        If gcSocios.MainView.Name = "GridView1" Then
            oSocioBE = GridView1.GetFocusedRow
        Else
            oSocioBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarSocio(oSocioBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaSocios()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub gcSocios_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gcSocios.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiTarjeta_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiTarjeta.ItemClick
        gcSocios.MainView = CardView1
    End Sub

    Private Sub bbiVistaGrilla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVistaGrilla.ItemClick
        gcSocios.MainView = GridView1
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As SocioBE = CType(GridView1.GetRow(e.FocusedRowHandle), SocioBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub gcSocios_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcSocios.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcSocios)
        End If
    End Sub
End Class