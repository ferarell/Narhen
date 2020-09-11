Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmSerie
    Dim oSerieBL As New SerieBL
    Dim accion As String = ""

    Private Sub frmSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTipoComprobante()
        ListarEmpresas()
        ListarSeries()
        HabilitarFormulario(False)
    End Sub

    Private Sub ListarTipoComprobante()
        Dim tb As New DataTable
        tb.Columns.Add("Value", GetType(String))
        tb.Columns.Add("Text", GetType(String))
        tb.Rows.Add("01", "FACTURA")
        tb.Rows.Add("03", "BOLETA")
        tb.Rows.Add("07", "NOTA CREDITO")
        tb.Rows.Add("08", "NOTA DEBITO")
        Me.cboTipoComprobante.DataSource = tb
        Me.cboTipoComprobante.DisplayMember = "Text"
        Me.cboTipoComprobante.ValueMember = "Value"
    End Sub

    Private Sub ListarSeries()
        Dim lstSeries As List(Of SerieBE)
        lstSeries = oSerieBL.ListarSeries()
        Me.dgvSerie.DataSource = lstSeries
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = "nuevo"
        LimpiarFormulario()
        HabilitarFormulario(True)
        Me.cboEmpresa.Focus()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim oSerie As New SerieBE
        With oSerie
            If Me.txtID.Text.Trim <> "" Then
                .sre_id = Convert.ToInt32(Me.txtID.Text.Trim)
            End If
            .emp_id = Me.cboEmpresa.SelectedValue
            .sre_tipdoc = Me.cboTipoComprobante.SelectedValue
            .sre_serie = Me.txtSerie.Text.Trim
            .sre_correlativo = Convert.ToInt32(Me.txtNroCorrelativo.Text.Trim)
        End With
        If accion = "nuevo" Then
            oSerie = oSerieBL.Registrar(oSerie)
            MessageBox.Show("El registro se agregó satisfactoriamente", "Lotizador")
        ElseIf accion = "editar" Then
            oSerie = oSerieBL.Actualizar(oSerie)
            MessageBox.Show("El registro se actualizó satisfactoriamente", "Lotizador")
        End If
        ListarSeries()
        HabilitarFormulario(False)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub LimpiarFormulario()
        Me.txtID.Text = ""
        Me.txtSerie.Text = ""
        Me.txtNroCorrelativo.Text = ""
        Me.cboTipoComprobante.SelectedIndex = 1
        Me.cboEmpresa.SelectedIndex = 0
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = "editar"
        HabilitarFormulario(True)
        Me.cboEmpresa.Focus()
    End Sub

    Private Sub HabilitarFormulario(habilita As Boolean)
        Try
            Me.cboEmpresa.Enabled = habilita
            Me.cboTipoComprobante.Enabled = habilita
            Me.txtSerie.Enabled = habilita
            Me.txtNroCorrelativo.Enabled = habilita
        Catch ex As InvalidOperationException
            Me.txtNroCorrelativo.Enabled = habilita
        End Try
    End Sub

    Private Sub ListarEmpresas()
        Dim oEmpresaBL As New EmpresaBL
        Dim lstEmpresas As List(Of EmpresaBE)
        lstEmpresas = oEmpresaBL.ListarEmpresas()
        Me.cboEmpresa.DataSource = lstEmpresas
        Me.cboEmpresa.ValueMember = "emp_id"
        Me.cboEmpresa.DisplayMember = "emp_razsoc"
    End Sub

    Private Sub dgvSerie_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSerie.RowEnter
        If e.RowIndex >= 0 Then
            Dim i As Integer = e.RowIndex
            Me.txtID.Text = Me.dgvSerie.Rows(i).Cells(0).Value
            Me.cboEmpresa.SelectedValue = Me.dgvSerie.Rows(i).Cells(1).Value
            Me.cboTipoComprobante.SelectedValue = Me.dgvSerie.Rows(i).Cells(3).Value
            Me.txtSerie.Text = Me.dgvSerie.Rows(i).Cells(4).Value
            Me.txtNroCorrelativo.Text = Me.dgvSerie.Rows(i).Cells(5).Value
        End If
    End Sub

    Private Sub dgvSerie_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSerie.SelectionChanged
        HabilitarFormulario(False)
    End Sub
End Class