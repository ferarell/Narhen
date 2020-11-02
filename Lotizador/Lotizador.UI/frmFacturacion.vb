Imports DevExpress.XtraSplashScreen
Imports Lotizador.UI.LotizadorService

Public Class frmFacturacion
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub PoblarGrillaLetrasPendientes()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
            Dim oGeneralBE As New GeneralBE
            oGeneralBE.SqlTxt = "EXEC upObtenerLetrasPorContrato Null, 1, " & lueProyecto.EditValue.ToString
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            oGeneralBE.dtResult.Columns.Add("checked", Type.GetType("System.Boolean"))
            Me.gcLetrasPendientes.DataSource = oGeneralBE.dtResult
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub frmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()
        'PoblarGrillaLetrasPendientes()
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        PoblarGrillaLetrasPagadas()
        Dim dgrItem As DataRowView = GridView1.GetRow(e.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub bbiImprimir_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim myPopup As New frmPopupFacturacion
        myPopup.myGridView1 = GridView1
        If myPopup.ContarSeleccionados = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar al menos 1 letra pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myPopup.Close()
            Return
        End If
        If myPopup.ShowDialog() <> DialogResult.Cancel Then
            PoblarGrillaLetrasPendientes()
        End If
    End Sub

    Public Sub PoblarGrillaLetrasPagadas()
        Try
            SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
            SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
            Dim oGeneralBE As New GeneralBE
            If GridView1.GetFocusedRowCellValue("IdContrato") >= 1 Then
                oGeneralBE.SqlTxt = "EXEC upObtenerLetrasPorContrato " & GridView1.GetFocusedRowCellValue("IdContrato") & ", 2, " & lueProyecto.EditValue.ToString
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
                oGeneralBE.dtResult.Columns.Add("checked", Type.GetType("System.Boolean"))
                Me.gcLetrasPagadas.DataSource = oGeneralBE.dtResult
            End If
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemCheckEdit1.CheckStateChanged
        GridView1.CloseEditor()
    End Sub

    Private Sub GridView1_SelectionChanged(sender As System.Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged

    End Sub

    Private Sub bbiEditarPago_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditarPago.ItemClick
        Dim myPopup As New frmPopupDatosPago
        myPopup.myGridView2 = GridView2
        If myPopup.ContarSeleccionados = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar al menos 1 letra cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Debe seleccionar al menos 1 letra cancelada.", MsgBoxStyle.Critical)
            myPopup.Close()
            Return
        End If
        If myPopup.ShowDialog() <> DialogResult.Cancel Then
            PoblarGrillaLetrasPagadas()
        End If
    End Sub


    Private Sub gcLetrasPendientes_Enter(sender As System.Object, e As System.EventArgs) Handles gcLetrasPendientes.Enter
        bbiAnularComprobante.Enabled = False
        bbiEditarPago.Enabled = False
    End Sub

    Private Sub gcLetrasPagadas_Enter(sender As System.Object, e As System.EventArgs) Handles gcLetrasPagadas.Enter
        bbiAnularComprobante.Enabled = True
        bbiEditarPago.Enabled = True
    End Sub

    Private Sub bbiAnularFacturacion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAnularComprobante.ItemClick
        Dim msg As String = "Esta seguro de anular el documento " & GridView2.GetRowCellValue(GridView2.GetFocusedDataSourceRowIndex, "NumeroSunat") & "?"
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, msg, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'If MsgBox(msg, MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            AnulaFacturaPorLetra()
        End If
    End Sub

    Private Sub AnulaFacturaPorLetra()
        Try
            Dim oGeneralBE As New GeneralBE
            oGeneralBE.SqlTxt = "EXEC upAnulaFacturacionPorLetra " & GridView2.GetRowCellValue(GridView2.GetFocusedDataSourceRowIndex, "IdLetra") & ", " & IdUsuario.ToString
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
        PoblarGrillaLetrasPendientes()
    End Sub

    Private Sub bbiRefrescar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRefrescar.ItemClick
        PoblarGrillaLetrasPendientes()
    End Sub

    Private Sub RepositoryItemCheckEdit3_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemCheckEdit3.CheckStateChanged
        GridView2.CloseEditor()
    End Sub


    Private Sub GridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.Caption = "Seleccionar" Then
            Dim MzLt As String = GridView1.GetRowCellValue(GridView1.GetVisibleIndex(e.RowHandle), "ManzanaLote")
            If Not GridView1.IsFirstRow Then
                If IsDBNull(GridView1.GetRowCellValue(GridView1.GetVisibleIndex(e.RowHandle) - 1, "checked")) And GridView1.GetRowCellValue(GridView1.GetVisibleIndex(e.RowHandle), "ManzanaLote") = GridView1.GetRowCellValue(GridView1.GetVisibleIndex(e.RowHandle) - 1, "ManzanaLote") Then
                    GridView1.CancelUpdateCurrentRow()
                End If
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Dim dgrItem As DataRowView = GridView2.GetRow(e.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub gcLetrasPendientes_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcLetrasPendientes.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcLetrasPendientes)
        End If
    End Sub

    Private Sub gcLetrasPagadas_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcLetrasPagadas.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcLetrasPagadas)
        End If
    End Sub

    Private Sub GridView1_RowCountChanged(sender As System.Object, e As System.EventArgs) Handles GridView1.RowCountChanged
        PoblarGrillaLetrasPagadas()
    End Sub

    Private Sub frmFacturacion_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub lueProyecto_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles lueProyecto.Properties.EditValueChanged
        If lueProyecto.ItemIndex >= 0 Then
            PoblarGrillaLetrasPendientes()
        End If
    End Sub

    Private Sub bbiEmitirNotaCredito_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEmitirNotaCredito.ItemClick

    End Sub

    Private Sub bbiEmitirFactura_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEmitirFactura.ItemClick

    End Sub

    Private Sub bsiEmisiones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bsiEmisiones.ItemClick
        Dim myPopup As New frmPopupFacturacion
        myPopup.myGridView1 = GridView1
        If myPopup.ContarSeleccionados = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar al menos 1 letra pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("Debe seleccionar al menos 1 letra pendiente.", MsgBoxStyle.Critical)
            myPopup.Close()
            Return
        End If
        If myPopup.ShowDialog() <> DialogResult.Cancel Then
            PoblarGrillaLetrasPendientes()
        End If
    End Sub
End Class