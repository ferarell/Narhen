Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmEmpresa
    Dim oEmpresaBL As New EmpresaBL
    Dim accion As String = ""

    Private Sub frmEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTipoDocumento()
        ListarEmpresas()
        HabilitarFormulario(False)
    End Sub

    Private Sub ListarTipoDocumento()
        Me.cboTipoDocumento.DisplayMember = "Text"
        Me.cboTipoDocumento.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Value", GetType(String))
        tb.Columns.Add("Text", GetType(String))
        tb.Rows.Add("01", "DNI")
        tb.Rows.Add("06", "RUC")
        Me.cboTipoDocumento.DataSource = tb
    End Sub

    Private Sub ListarEmpresas()
        Dim lstEmpresas As List(Of EmpresaBE)
        lstEmpresas = oEmpresaBL.ListarEmpresas()
        Me.dgvEmpresa.DataSource = lstEmpresas
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        accion = "nuevo"
        LimpiarFormulario()
        HabilitarFormulario(True)
        Me.txtRazonSocial.Focus()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim oEmpresa As New EmpresaBE
        With oEmpresa
            If Me.txtID.Text.Trim <> "" Then
                .emp_id = Me.txtID.Text.Trim
            End If
            .emp_razsoc = Me.txtRazonSocial.Text.Trim
            .emp_tipodoc = Me.cboTipoDocumento.SelectedValue
            .emp_nrodoc = Me.txtNroDocumento.Text.Trim
            .emp_direccion = Me.txtDireccion.Text.Trim
            .emp_distrito = Me.txtDistrito.Text.Trim
        End With
        If accion = "nuevo" Then
            oEmpresa = oEmpresaBL.Registrar(oEmpresa)
            MessageBox.Show("El registro se agregó satisfactoriamente", "Lotizador")
        ElseIf accion = "editar" Then
            oEmpresa = oEmpresaBL.Actualizar(oEmpresa)
            MessageBox.Show("El registro se actualizó satisfactoriamente", "Lotizador")
        End If
        ListarEmpresas()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub LimpiarFormulario()
        Me.txtID.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtDistrito.Text = ""
        Me.txtNroDocumento.Text = ""
        Me.cboTipoDocumento.SelectedIndex = 0
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        accion = "editar"
        HabilitarFormulario(True)
        Me.txtRazonSocial.Focus()
    End Sub

    Private Sub dgvEmpresa_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresa.RowEnter
        If e.RowIndex >= 0 Then
            HabilitarFormulario(False)
            Dim i As Integer = e.RowIndex
            Me.txtID.Text = Me.dgvEmpresa.Rows(i).Cells(0).Value
            Me.txtRazonSocial.Text = Me.dgvEmpresa.Rows(i).Cells(1).Value
            Me.cboTipoDocumento.SelectedValue = Me.dgvEmpresa.Rows(i).Cells(2).Value
            Me.txtNroDocumento.Text = Me.dgvEmpresa.Rows(i).Cells(3).Value
            Me.txtDireccion.Text = Me.dgvEmpresa.Rows(i).Cells(4).Value
            Me.txtDistrito.Text = Me.dgvEmpresa.Rows(i).Cells(5).Value
        End If
    End Sub

    Private Sub HabilitarFormulario(habilita As Boolean)
        Me.txtRazonSocial.Enabled = habilita
        Me.cboTipoDocumento.Enabled = habilita
        Me.txtNroDocumento.Enabled = habilita
        Me.txtDireccion.Enabled = habilita
        Me.txtDistrito.Enabled = habilita
    End Sub

End Class