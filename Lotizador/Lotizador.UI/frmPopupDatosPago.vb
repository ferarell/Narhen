Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupDatosPago
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Friend myGridView2 As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend myGridView3 As New DevExpress.XtraGrid.Views.Grid.GridView
    Friend sAction As String
    Dim iChecked As Integer
    Dim ImportePago As Double

    Private Sub InicializarValoresEdicion()
        Dim dgrItem As DataRowView = myGridView3.GetRow(myGridView3.FocusedRowHandle)
        deFechaPago.EditValue = dgrItem("FechaPago")
        Dim rTipoPago As Integer = Me.lueTipoPago.Properties.GetDataSourceRowIndex("Codigo", dgrItem("TipoPago"))
        lueTipoPago.EditValue = Me.lueTipoPago.Properties.GetDataSourceValue(lueTipoPago.Properties.ValueMember, rTipoPago)
        txtNumeroDocumento.EditValue = dgrItem("NumeroPago")
        txtImportePago.EditValue = dgrItem("ImportePago")
        txtObservaciones.EditValue = dgrItem("Observaciones")
    End Sub

    Function ContarSeleccionados() As Integer
        Dim dr As DataRow = Nothing
        iChecked = 0
        For index = 0 To myGridView2.RowCount - 1
            dr = myGridView2.GetDataRow(index)
            If Not IsDBNull(myGridView2.GetRowCellValue(index, "checked")) Then
                If myGridView2.GetRowCellValue(index, "checked") = True Then
                    iChecked = iChecked + 1
                    ImportePago = ImportePago + myGridView2.GetRowCellValue(index, "Saldo")
                End If
            End If
        Next
        txtImportePago.Text = ImportePago
        If iChecked > 1 Then
            txtImportePago.Enabled = False
        End If
        Return iChecked
    End Function

    Private Sub bbiGrabar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        deFechaPago.Focus()
        If vpDatosPago.Validate Then
            If sAction = "Registrar" Then
                Dim dr As DataRow = Nothing
                For index = 0 To myGridView2.RowCount - 1
                    dr = myGridView2.GetDataRow(index)
                    If Not IsDBNull(myGridView2.GetRowCellValue(index, "checked")) Then
                        If myGridView2.GetRowCellValue(index, "checked") Then
                            RegistrarPago(dr.Item("IdLetra").ToString)
                        End If
                    End If
                Next
            Else
                EditarPago()
            End If
        End If
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub RegistrarPago(ByVal IdLetra As String)
        If rgTipoPago.SelectedIndex = 0 Then 'Registra Cuota
            If iChecked = 1 Then
                oGeneralBE.SqlTxt = "EXEC upRegistrarPagoPorLetra " & IdLetra & ", '" & Format(deFechaPago.DateTime, "yyyyMMdd") & "', '" & lueTipoPago.Text & "', '" & txtNumeroDocumento.Text & "', " & txtImportePago.EditValue & ", '" & txtObservaciones.Text & "', " & IdUsuario
            Else
                oGeneralBE.SqlTxt = "EXEC upRegistrarPagoPorLetra " & IdLetra & ", '" & Format(deFechaPago.DateTime, "yyyyMMdd") & "', '" & lueTipoPago.Text & "', '" & txtNumeroDocumento.Text & "', " & myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "ImporteCuota") & ", '" & txtObservaciones.Text & "', " & IdUsuario
            End If
        Else 'Registra Mora
            If lueTipoPago.EditValue = "MR" Then
                oGeneralBE.SqlTxt = "EXEC upRegistrarPagoPorLetra " & IdLetra & ", '" & Format(deFechaPago.DateTime, "yyyyMMdd") & "', '" & lueTipoPago.Text & "', '" & txtNumeroDocumento.Text & "', " & myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "ImporteMora") & ", '" & txtObservaciones.Text & "', " & IdUsuario
            Else
                oGeneralBE.SqlTxt = "UPDATE Letra SET ImporteMora = " & txtImportePago.Text & " WHERE IdLetra = " & IdLetra
            End If

        End If
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
    End Sub

    Private Sub EditarPago()
        If rgTipoPago.SelectedIndex = 0 Then
            oGeneralBE.SqlTxt = "EXEC upEditarPagoPorLetra " & myGridView3.GetRowCellValue(myGridView3.FocusedRowHandle, "IdLetra") & ", " & myGridView3.GetRowCellValue(myGridView3.FocusedRowHandle, "IdPago") & ", '" & Format(deFechaPago.DateTime, "yyyyMMdd") & "', '" & lueTipoPago.Text & "', '" & txtNumeroDocumento.Text & "', " & txtImportePago.EditValue & ", '" & txtObservaciones.Text & "', " & IdUsuario
        Else
            oGeneralBE.SqlTxt = "UPDATE Letra SET ImporteMora = " & txtImportePago.Text & " WHERE IdLetra = " & myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "IdLetra")
        End If
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Close()
    End Sub

    Private Sub frmPopupDatosPago_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = sAction & " Pago"
        If iChecked > 1 Then
            txtImportePago.Enabled = False
        End If
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Ingrese un valor"
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical

        vpDatosPago.SetValidationRule(Me.deFechaPago, customValidationRule)
        vpDatosPago.SetValidationRule(Me.lueTipoPago, customValidationRule)
        vpDatosPago.SetValidationRule(Me.txtNumeroDocumento, customValidationRule)
        vpDatosPago.SetValidationRule(Me.txtImportePago, customValidationRule)

        PoblarTipoPago()

        lueTipoPago.EditValue = "DB"
        rgTipoPago.SelectedIndex = 0
        rgTipoPago.Enabled = True

        If sAction = "Registrar" Then
            If myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "ImportePago") > 0 Then
                deFechaPago.EditValue = Now
                lueTipoPago.EditValue = "MR"
                rgTipoPago.SelectedIndex = 1
                rgTipoPago.Enabled = False
                txtNumeroDocumento.EditValue = 0
            End If
        ElseIf sAction = "Editar" Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub PoblarTipoPago()
        oGeneralBE.SqlTxt = "select valor as Codigo, Descripcion from Variable where Nombre = 'TipoPago'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Me.lueTipoPago.Properties.DataSource = oGeneralBE.dtResult
        Me.lueTipoPago.Properties.DisplayMember = "Codigo"
        Me.lueTipoPago.Properties.ValueMember = "Codigo"
    End Sub

    Private Sub rgTipoPago_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles rgTipoPago.SelectedIndexChanged
        If sAction = "Registrar" Then
            txtImportePago.Text = SumarImporte(rgTipoPago.SelectedIndex)
        End If
        If sAction = "Editar" Then
            If rgTipoPago.SelectedIndex = 0 Then
                txtImportePago.Text = ObtenerSaldo(myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "IdLetra"))
            Else
                txtImportePago.Text = myGridView2.GetRowCellValue(myGridView2.FocusedRowHandle, "ImporteMora")
            End If
        End If
    End Sub

    Function ObtenerSaldo(ByVal IdLetra As Integer) As Double
        oGeneralBE.SqlTxt = "EXEC upObtenerSaldoPorLetra " & IdLetra
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Return oGeneralBE.dtResult(0).Item("Saldo")
    End Function

    Function SumarImporte(ByVal sTipoPago As Integer) As Double
        Dim dr As DataRow = Nothing
        Dim dImportePago As Double = 0
        For index = 0 To myGridView2.RowCount - 1
            dr = myGridView2.GetDataRow(index)
            If Not IsDBNull(myGridView2.GetRowCellValue(index, "checked")) Then
                If myGridView2.GetRowCellValue(index, "checked") = True Then
                    If sTipoPago = 0 Then
                        dImportePago = dImportePago + myGridView2.GetRowCellValue(index, "ImporteSaldo")
                    Else
                        dImportePago = dImportePago + myGridView2.GetRowCellValue(index, "ImporteMora")
                    End If

                End If
            End If
        Next
        Return dImportePago
    End Function

End Class