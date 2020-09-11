Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmLetras
    Dim oLetraBL As New LetraBL

    Private Sub frmBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListarLetrasPendientes()
        ListarProyectos()
        InicializarControles()
        LimpiarComboCliente()
        LimpiarComboLote()
    End Sub

    Private Sub InicializarControles()
        Me.cboProyecto.SelectedIndex = 0
        'Me.cboCliente.Items.Add("Seleccionar")
        'Me.cboCliente.SelectedIndex = 0
        'Me.cboLote.Items.Add("Seleccionar")
        'Me.cboLote.SelectedIndex = 0
    End Sub

    Private Sub ListarLetrasPendientes()
        Dim lstLetras As List(Of LetraBE)
        lstLetras = oLetraBL.ListarLetrasPendientes()
        Me.dgvPendientes.DataSource = lstLetras
    End Sub

    Private Sub ListarProyectos()
        Dim oProyectoBL As New ProyectoBL
        Dim lstProyectos As List(Of ProyectoBE)
        lstProyectos = oProyectoBL.ListarProyectos()
        lstProyectos.Insert(0, New ProyectoBE() With {.IdProyecto = 0, .Descripcion = "Seleccionar"})
        Me.cboProyecto.DataSource = lstProyectos
        Me.cboProyecto.ValueMember = "IdProyecto"
        Me.cboProyecto.DisplayMember = "Descripcion"
    End Sub

    Private Sub cboProyecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProyecto.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If Me.cboProyecto.SelectedIndex > 0 Then
            'If IsNumeric(Me.cboProyecto.SelectedValue) Then
            Dim idProyecto As Integer = Me.cboProyecto.SelectedValue
            ListarSociosPorProyecto(idProyecto)
            LimpiarComboLote()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub ListarSociosPorProyecto(idProyecto As Integer)
        If Me.cboProyecto.SelectedIndex > 0 Then
            'If Me.cboProyecto.SelectedValue <> 0 Then
            Dim oSocioBL As New SocioBL
            Dim lstSocios As List(Of SocioBE)
            lstSocios = oSocioBL.ListarSociosPorProyecto(idProyecto)
            lstSocios.Insert(0, New SocioBE() With {.IdSocio = 0, .Nombre = "Seleccionar"})
            Me.cboCliente.DataSource = lstSocios
            Me.cboCliente.ValueMember = "IdSocio"
            Me.cboCliente.DisplayMember = "Nombre"
        Else
            LimpiarComboLote()
            LimpiarComboCliente()
        End If
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If Me.cboCliente.SelectedIndex > 0 Then
            'If IsNumeric(Me.cboCliente.SelectedValue) Then
            Dim idSocio As Integer = Me.cboCliente.SelectedValue
            ListarLotesPorSocio(idSocio)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub ListarLotesPorSocio(idSocio As Integer)
        If Me.cboCliente.SelectedIndex > 0 Then
            'If Me.cboCliente.SelectedValue <> 0 Then
            Dim oLoteBL As New LoteBL
            Dim lstLotes As List(Of LoteBE)
            lstLotes = oLoteBL.ListarLotesPorSocio(idSocio)
            lstLotes.Insert(0, New LoteBE() With {.IdLote = 0, .Lote = "Seleccionar"})
            Me.cboLote.DataSource = lstLotes
            Me.cboLote.ValueMember = "IdLote"
            Me.cboLote.DisplayMember = "Lote"
        Else
            LimpiarComboLote()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Cursor = Cursors.WaitCursor
        'Me.dgvPendientes.DataSource = Nothing
        Dim lstLetras As List(Of LetraBE) = Nothing
        If Me.cboProyecto.SelectedValue <> 0 And Me.cboCliente.SelectedValue <> 0 And Me.cboLote.SelectedValue <> 0 Then
            lstLetras = oLetraBL.ListarLetrasPendientesPorProyectoSocioLote(Me.cboProyecto.SelectedValue, Me.cboCliente.SelectedValue, Me.cboLote.SelectedValue)
            Me.dgvPendientes.DataSource = lstLetras
            dgvPendientes_CellClick(Me.dgvPendientes, Nothing)
            Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.cboProyecto.SelectedValue <> 0 And Me.cboCliente.SelectedValue Then
            lstLetras = oLetraBL.ListarLetrasPendientesPorProyectoSocio(Me.cboProyecto.SelectedValue, Me.cboCliente.SelectedValue)
            Me.dgvPendientes.DataSource = lstLetras
            dgvPendientes_CellClick(Me.dgvPendientes, Nothing)
            Cursor = Cursors.Default
            Exit Sub
        End If
        If Me.cboProyecto.SelectedValue <> 0 Then
            lstLetras = oLetraBL.ListarLetrasPendientesPorProyecto(Me.cboProyecto.SelectedValue)
            Me.dgvPendientes.DataSource = lstLetras
            dgvPendientes_CellClick(Me.dgvPendientes, Nothing)
            Cursor = Cursors.Default
            Exit Sub
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub btnBoletear_Click(sender As Object, e As EventArgs) Handles btnBoletear.Click
        Cursor = Cursors.WaitCursor
        Dim dt As DataTable = CrearTablaPendientes()
        For i As Integer = 0 To Me.dgvPendientes.Rows.Count() - 1
            Dim c As Boolean
            c = Me.dgvPendientes.Rows(i).Cells(0).Value
            ' if the checkbox cell is checked
            If c = True Then
                'MessageBox.Show(i & " Checked")
                dt.Rows.Add(Me.dgvPendientes.Rows(i).Cells("bol_proyecto_id").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_proyecto_nombre").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_cliente_id").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_cliente_nombre").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_lote_id").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_lote_nombre").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_nro_cuota").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_fec_venc").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_importe").Value,
                            Me.dgvPendientes.Rows(i).Cells("bol_letra_id").Value)
                'Else
                'MessageBox.Show(i & "Not Checked")
            End If
        Next
        If dt.Rows.Count > 0 Then
            Dim f As New frmComprobanteGenerar(dt)
            f.IdProyecto = Me.cboProyecto.SelectedValue
            f.ShowDialog(Me)
            'For Each dr As DataGridViewRow In Me.dgvCanceladas.Rows
            '    Me.dgvCanceladas.Rows.RemoveAt(dr.Index)
            'Next
            'Me.dgvCanceladas.Rows.Clear()
            'Dim lstLetras As List(Of LetraBE) = Nothing
            'Me.dgvCanceladas.DataSource = lstLetras
            btnBuscar_Click(sender, e)
            dgvPendientes_CellClick(Me.dgvPendientes, Nothing)
        Else
            MessageBox.Show("Debe seleccionar al menos una letra para poder boletear", "Lotizador")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Function CrearTablaPendientes() As DataTable
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("bol_proyecto_id", GetType(Integer))
        table.Columns.Add("bol_proyecto_nombre", GetType(String))
        table.Columns.Add("bol_cliente_id", GetType(Integer))
        table.Columns.Add("bol_cliente_nombre", GetType(String))
        table.Columns.Add("bol_lote_id", GetType(Integer))
        table.Columns.Add("bol_lote_nombre", GetType(String))
        table.Columns.Add("bol_nro_cuota", GetType(Integer))
        table.Columns.Add("bol_fec_venc", GetType(String))
        table.Columns.Add("bol_moneda", GetType(String))
        table.Columns.Add("bol_importe", GetType(Decimal))
        table.Columns.Add("bol_letra_id", GetType(Decimal))

        Return table
    End Function

    Private Sub LimpiarComboLote()
        Me.cboLote.DataSource = Nothing
        Me.cboLote.Items.Clear()
        Me.cboLote.Items.Add("Seleccionar")
        Me.cboLote.SelectedIndex = 0
    End Sub

    Private Sub LimpiarComboCliente()
        Me.cboCliente.DataSource = Nothing
        Me.cboCliente.Items.Clear()
        Me.cboCliente.Items.Add("Seleccionar")
        Me.cboCliente.SelectedIndex = 0
    End Sub

    Private Sub dgvPendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPendientes.CellClick
        Dim oLetraBL As New LetraBL()
        Dim lstLetras As List(Of LetraBE) = Nothing
        Dim idProyecto As Integer
        Dim idSocio As Integer
        Dim idLote As Integer
        Dim dgv As DataGridView = sender
        If dgv Is Nothing Then Exit Sub
        If Not dgv.CurrentRow Is Nothing Then
            If dgv.CurrentRow.Selected Then
                idProyecto = dgv.CurrentRow.Cells("bol_proyecto_id").Value
                idSocio = dgv.CurrentRow.Cells("bol_cliente_id").Value
                idLote = dgv.CurrentRow.Cells("bol_lote_id").Value
                lstLetras = oLetraBL.ListarLetrasPagadasPorProyectoSocioLote(idProyecto, idSocio, idLote)
                Me.dgvCanceladas.DataSource = lstLetras
            End If
        Else
            idProyecto = 0
            idSocio = 0
            idLote = 0
            lstLetras = oLetraBL.ListarLetrasPagadasPorProyectoSocioLote(idProyecto, idSocio, idLote)
            Me.dgvCanceladas.DataSource = lstLetras
        End If
    End Sub
End Class