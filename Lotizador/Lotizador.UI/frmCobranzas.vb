Imports DevExpress.XtraSplashScreen
Imports Lotizador.UI.LotizadorService
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmCobranzas
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oView As New Object
    Dim oContratoBE As ContratoBE
    'Dim IdContrato As Integer
    'Dim oGeneralBE As New GeneralBE

    Private Sub frmControlMoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'bbiActualizar.PerformClick()
    End Sub

    Public Sub PoblarGrillaContratos(ByVal iRow As Integer)
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
        Try
            Dim oGeneralBE As New GeneralBE
            oGeneralBE.SqlTxt = "EXEC CONTRATO_GET02"
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Me.gcContratos.DataSource = oGeneralBE.dtResult
            GridView1.MoveBy(iRow)
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Public Sub PoblarGrillaLetras(ByVal iRow As Integer)
        Dim myRow As DataRowView = GridView1.GetRow(GridView1.FocusedRowHandle)
        If Not myRow Is Nothing Then
            Dim oGeneralBE As New GeneralBE
            If GridView1.RowCount > 0 Then
                oGeneralBE.SqlTxt = "EXEC upObtenerLetrasPorContrato " & myRow("IdContrato") & ", 0"
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
                oGeneralBE.dtResult.Columns.Add("checked", Type.GetType("System.Boolean"))
                Me.gcLetras.DataSource = oGeneralBE.dtResult
                GridView2.MoveBy(iRow)
            End If
            PoblarGrillaPagos(0)
        End If
    End Sub

    Public Sub PoblarGrillaPagos(ByVal iRow As Integer)
        Dim myRow As DataRowView = GridView2.GetRow(GridView2.FocusedRowHandle)
        If Not myRow Is Nothing Then
            Dim oGeneralBE As New GeneralBE
            If GridView2.RowCount > 0 Then
                oGeneralBE.SqlTxt = "EXEC upObtenerPagosPorLetra " & myRow("IdLetra")
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
                oGeneralBE.dtResult.Columns.Add("checked", Type.GetType("System.Boolean"))
                Me.gcPagos.DataSource = oGeneralBE.dtResult
            End If
            If GridView3.RowCount > 0 Then
                GridView3.MoveBy(iRow)
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        PoblarGrillaLetras(0)
        PoblarGrillaPagos(0)
        Dim dgrItem As DataRowView = GridView1.GetRow(GridView1.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
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
        PoblarGrillaPagos(0)
        If GridView3.RowCount = 0 Then
            bbiEditarPago.Enabled = False
            bbiEliminarPago.Enabled = False
        Else
            bbiEditarPago.Enabled = True
            bbiEliminarPago.Enabled = True
            'brsDescripcion.Caption = dgrItem("IdLetra").ToString
        End If

    End Sub

    Private Sub RepositoryItemCheckEdit3_CheckStateChanged(sender As System.Object, e As System.EventArgs) Handles RepositoryItemCheckEdit3.CheckStateChanged
        GridView2.CloseEditor()
    End Sub

    Private Sub GridView2_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If e.Column.Caption = "Seleccionar" Then
            Dim dgrItem As DataRowView = GridView2.GetRow(GridView2.FocusedRowHandle)
            If Not IsDBNull(GridView2.GetRowCellValue(GridView2.GetVisibleIndex(e.RowHandle), "FechaPago")) And dgrItem("Saldo") = 0 And dgrItem("ImporteMora") = 0 Then
                GridView2.CancelUpdateCurrentRow()
            Else
                If Not GridView2.IsFirstRow Then
                    If IsDBNull(GridView2.GetRowCellValue(GridView2.GetVisibleIndex(e.RowHandle) - 1, "checked")) And IsDBNull(GridView2.GetRowCellValue(GridView2.GetVisibleIndex(e.RowHandle) - 1, "FechaPago")) Then
                        GridView2.CancelUpdateCurrentRow()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bbiRegistrarPago_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiRegistrarPago.ItemClick
        Dim myPopup As New frmPopupDatosPago
        myPopup.myGridView2 = GridView2
        myPopup.sAction = "Registrar"
        If myPopup.ContarSeleccionados = 0 Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar al menos 1 letra pendiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            myPopup.Close()
            Return
        End If
        If myPopup.ShowDialog() = DialogResult.OK Then
            Dim iRow As Integer = GridView3.FocusedRowHandle
            PoblarGrillaLetras(GridView2.FocusedRowHandle)
            GridView3.MoveBy(iRow)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub GridView2_FocusedRowLoaded(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.RowEventArgs) Handles GridView2.FocusedRowLoaded
        If Not IsDBNull(GridView2.GetRowCellValue(GridView2.GetVisibleIndex(GridView2.FocusedRowHandle), "FechaPago")) Then
            GridView2.Columns("checked").OptionsColumn.AllowEdit = False
        End If
    End Sub

    Private Sub gcContratos_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcContratos.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcContratos)
        End If
    End Sub

    Private Sub gcLetras_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcLetras.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcLetras)
        End If
    End Sub

    Private Sub bbiActualizarMora_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizarMora.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ejecutar el proceso de cálculo de moras?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmPopupProgress.Show()
            Try
                Me.BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Dim iRow As Integer = GridView2.FocusedRowHandle
            PoblarGrillaContratos(GridView1.FocusedRowHandle)
            PoblarGrillaLetras(iRow)
        End If
    End Sub

    Private Sub bbiEditarPago_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditarPago.ItemClick
        If Not IsDBNull(GridView2.GetRowCellValue(GridView2.GetVisibleIndex(GridView2.FocusedRowHandle), "FechaPago")) Then
            Dim myPopup As New frmPopupDatosPago
            myPopup.myGridView2 = GridView2
            myPopup.myGridView3 = GridView3
            myPopup.sAction = "Editar"
            If myPopup.ShowDialog() = DialogResult.OK Then
                Dim iRow As Integer = GridView3.FocusedRowHandle
                PoblarGrillaLetras(GridView2.FocusedRowHandle)
                GridView3.MoveBy(iRow)
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "EXEC upCalcularMoras"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        frmPopupProgress.Close()
    End Sub

    Private Sub GridView3_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        Dim dgrItem As DataRowView = GridView3.GetRow(e.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub


    Private Sub bbiEliminarPago_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminarPago.ItemClick
        If GridView3.IsLastVisibleRow And GridView3.RowCount > 0 Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar el pago seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
            Dim dgrItem As DataRowView = GridView3.GetRow(GridView3.FocusedRowHandle)
            Dim oGeneralBE As New GeneralBE
            oGeneralBE.SqlTxt = "EXEC upEliminarPagoPorLetra " & dgrItem("IdLetra") & ", " & dgrItem("IdPago") & ", " & IdUsuario
            Try
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ocurrió un error al tratar de eliminar el pago. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            PoblarGrillaPagos(GridView3.FocusedRowHandle)
            PoblarGrillaLetras(GridView2.FocusedRowHandle)

            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "El pago fue eliminado satisfactoriamente, verifique el saldo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Debe seleccionar el último pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub gcPagos_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcPagos.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcPagos)
        End If
    End Sub

    Private Sub GridView1_ColumnFilterChanged(sender As System.Object, e As System.EventArgs) Handles GridView1.ColumnFilterChanged
        PoblarGrillaLetras(0)
    End Sub

    Private Sub frmCobranzas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        bbiActualizar.PerformClick()
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        PoblarGrillaContratos(0)
    End Sub
End Class