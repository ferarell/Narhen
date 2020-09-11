Imports Lotizador.UI.LotizadorService

Public Class frmPopupFacturacion
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Friend myGridView1 As New DevExpress.XtraGrid.Views.Grid.GridView


    Private Sub bbiImprimir_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiImprimir.ItemClick
        If deFechaEmision.DateTime > Date.Today Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La fecha de emisión no puede ser mayor a la fecha de hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox("La fecha de emisión no puede ser mayor a la fecha de hoy.", MsgBoxStyle.Critical)
            deFechaEmision.Focus()
            Return
        End If
        Dim FechaCuota As Date
        Dim TipoPago, NumeroPago As String
        Dim myForm As New frmVisorDocumentoContable
        Dim dr As DataRow = Nothing
        For index = 0 To myGridView1.RowCount - 1
            dr = myGridView1.GetDataRow(index)
            FechaCuota = IIf(deFechaEmision.Text <> "", deFechaEmision.DateTime, dr.Item("FechaCuota").ToString)
            'FechaCuota = deFechaEmision.DateTime
            If lueTipoPago.Text <> "" Then
                TipoPago = Me.lueTipoPago.Properties.GetDataSourceValue("Codigo", lueTipoPago.ItemIndex).ToString
            End If
            If txtNumeroDocumento.Text <> "" Then
                NumeroPago = txtNumeroDocumento.Text
            End If
            If Not IsDBNull(myGridView1.GetRowCellValue(index, "checked")) Then
                If myGridView1.GetRowCellValue(index, "checked") = True Then
                    myForm.IdLetra = myForm.IdLetra + dr.Item("IdLetra").ToString + ","
                    If Not fnValidaFechaEmision(dr.Item("IdLetra").ToString) Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "La fecha de emisión no puede ser menor a la fecha de la última boleta emitida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'MsgBox("La fecha de emisión no puede ser menor a la fecha de la última boleta emitida.", MsgBoxStyle.Critical)
                        Return
                        Exit For
                    End If
                    If rgSUNAT.EditValue = True Then
                        GeneraFacturaPorLetra(dr.Item("IdLetra").ToString, FechaCuota, dr.Item("IdMoneda").ToString, dr.Item("TipDocProyecto").ToString, TipoPago, NumeroPago)
                    End If
                End If
            End If
        Next
        myForm.ShowDialog()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub frmPopupFacturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        deFechaEmision.DateTime = Date.Now.ToShortDateString
        PoblarTipoPago()
        If ContarSeleccionados() = 1 Then
            GroupControl1.Enabled = True
        Else
            GroupControl1.Enabled = False
        End If
    End Sub

    Function ContarSeleccionados() As Integer
        Dim dr As DataRow = Nothing
        Dim iChecked As Integer = 0
        For index = 0 To myGridView1.RowCount - 1
            dr = myGridView1.GetDataRow(index)
            If Not IsDBNull(myGridView1.GetRowCellValue(index, "checked")) Then
                If myGridView1.GetRowCellValue(index, "checked") = True Then
                    iChecked = iChecked + 1
                End If
            End If
        Next
        Return iChecked
    End Function

    Private Sub PoblarTipoPago()
        oGeneralBE.SqlTxt = "select valor as Codigo, Descripcion from Variable where Nombre = 'TipoPago'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Me.lueTipoPago.Properties.DataSource = oGeneralBE.dtResult
        Me.lueTipoPago.Properties.DisplayMember = "Codigo"
        Me.lueTipoPago.Properties.ValueMember = "Codigo"
    End Sub

    Friend Sub GeneraFacturaPorLetra(ByVal IdLetra As String, ByVal FechaVcto As Date, ByVal IdMoneda As String, ByVal IdTipDoc As String, ByVal TipoPago As String, ByVal NroPago As String)
        Try
            oGeneralBE.SqlTxt = "EXEC upGenerarFacturacionPorLetra " & IdLetra & ", '" & Format(FechaVcto, "yyyyMMdd") & "', " & IdMoneda & ", " & IdTipDoc & ", " & IdUsuario.ToString & ", '" & TipoPago & "', '" & NroPago & "'"
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Close()
    End Sub

    Function fnValidaFechaEmision(ByVal IdLetra As String) As Boolean
        oGeneralBE.SqlTxt = "EXEC upObtenerFechaBoletaAnterior " & IdLetra
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        If oGeneralBE.dtResult.Rows.Count > 0 Then
            If deFechaEmision.Text < oGeneralBE.dtResult.Rows(0).Item("FechaEmision") Then
                deFechaEmision.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    
End Class