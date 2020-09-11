Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmComprobanteBuscar
    Public formularioPadre As String

    Public Sub New(formularioInvoca As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        formularioPadre = formularioInvoca
    End Sub

    Private Sub frmComprobanteBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarComboTipoComprobante()
        'ListarComprobantes()
        Me.cboTipo.Focus()
    End Sub

    Private Sub ListarComprobantesPorTipo()
        Cursor = Cursors.WaitCursor
        Dim oComprobanteBL As New ComprobanteBL()
        Dim lstComprobantes As New List(Of ComprobanteBE)
        Try
            lstComprobantes = oComprobanteBL.ListarComprobantesPorTipo(Me.cboTipo.SelectedValue.ToString())
            Me.dgvComprobantes.DataSource = lstComprobantes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lotizador")
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Cursor = Cursors.WaitCursor
        Dim dt As DataTable = CrearTablaComprobantes()
        For i As Integer = 0 To Me.dgvComprobantes.Rows.Count() - 1
            Dim c As Boolean
            c = Me.dgvComprobantes.Rows(i).Cells(0).Value
            If c = True Then
                dt.Rows.Add(Me.dgvComprobantes.Rows(i).Cells("n_cc_id").Value,
                            Me.dgvComprobantes.Rows(i).Cells("d_cc_fecha").Value,
                            Me.dgvComprobantes.Rows(i).Cells("c_cc_tipo").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_serie").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_numero").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_ruc").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_razonsocial").Value,
                            Me.dgvComprobantes.Rows(i).Cells("c_cc_adquiriente_tipodoc").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_adquiriente_ruc").Value,
                            Me.dgvComprobantes.Rows(i).Cells("v_cc_adquiriente_razonsocial").Value,
                            Me.dgvComprobantes.Rows(i).Cells("c_cc_moneda").Value,
                            Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value)
            End If
        Next
        If dt.Rows.Count > 0 Then
            If formularioPadre = "ComprobanteAnular" Then
                Dim f As New frmComprobanteAnular(dt)
                f.ShowDialog(Me)
                frmComprobanteBuscar_Load(sender, e)
            ElseIf formularioPadre = "NotaGenerar" Then
                If dt.Rows.Count = 1 Then
                    Dim f As New frmNotaGenerar(dt)
                    f.ShowDialog(Me)
                    frmComprobanteBuscar_Load(sender, e)
                Else
                    MessageBox.Show("Solo puede seleccionar un comprobante para generar una Nota", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            MessageBox.Show("Debe seleccionar al menos un comprobante para poder procesar", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Function CrearTablaComprobantes() As DataTable
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("n_cc_id", GetType(Integer))
        table.Columns.Add("d_cc_fecha", GetType(String))
        table.Columns.Add("c_cc_tipo", GetType(String))
        table.Columns.Add("v_cc_serie", GetType(String))
        table.Columns.Add("v_cc_numero", GetType(String))
        table.Columns.Add("v_cc_emisor_ruc", GetType(String))
        table.Columns.Add("v_cc_emisor_razonsocial", GetType(String))
        table.Columns.Add("c_cc_adquiriente_tipodoc", GetType(String))
        table.Columns.Add("v_cc_adquiriente_ruc", GetType(String))
        table.Columns.Add("v_cc_adquiriente_razonsocial", GetType(String))
        table.Columns.Add("c_cc_moneda", GetType(String))
        table.Columns.Add("n_cc_total", GetType(Decimal))

        Return table
    End Function

    Private Sub GenerarComboTipoComprobante()
        Dim dt As DataTable = CrearTablaTipoComprobante()
        Me.cboTipo.DataSource = dt
        Me.cboTipo.ValueMember = "codigo"
        Me.cboTipo.DisplayMember = "descripcion"
        Me.cboTipo.SelectedIndex = 0
        ListarComprobantesPorTipo()
    End Sub

    Private Function CrearTablaTipoComprobante() As DataTable
        Dim table As New DataTable
        table.Columns.Add("codigo", GetType(String))
        table.Columns.Add("descripcion", GetType(String))

        table.Rows.Add("03", "BOLETA")
        table.Rows.Add("01", "FACTURA")

        Return table
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Cursor = Cursors.WaitCursor
        If Me.txtCliente.Text.Trim = String.Empty Then
            ListarComprobantesPorTipo()
        Else
            Dim oComprobanteBL As New ComprobanteBL()
            Dim lstComprobantes As New List(Of ComprobanteBE)
            Try
                lstComprobantes = oComprobanteBL.ListarComprobantesPorTipoPorCliente(Me.cboTipo.SelectedValue.ToString(), Me.txtCliente.Text.Trim)
                Me.dgvComprobantes.DataSource = lstComprobantes
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Lotizador")
            End Try
        End If
        Cursor = Cursors.Default
    End Sub
End Class