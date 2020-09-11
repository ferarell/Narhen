<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaGenerar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvComprobantes = New System.Windows.Forms.DataGridView()
        Me.n_cc_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.d_cc_fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cc_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_emisor_ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_emisor_razonsocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cc_adquiriente_tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_adquiriente_ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.v_cc_adquiriente_razonsocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_cc_moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.n_cc_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMotivo = New System.Windows.Forms.ComboBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.cboSeries = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cboTipo.Location = New System.Drawing.Point(62, 12)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(186, 21)
        Me.cboTipo.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tipo:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(326, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Fecha:"
        '
        'dgvComprobantes
        '
        Me.dgvComprobantes.AllowUserToAddRows = False
        Me.dgvComprobantes.AllowUserToDeleteRows = False
        Me.dgvComprobantes.AllowUserToOrderColumns = True
        Me.dgvComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.n_cc_id, Me.d_cc_fecha, Me.c_cc_tipo, Me.v_cc_serie, Me.v_cc_numero, Me.v_cc_emisor_ruc, Me.v_cc_emisor_razonsocial, Me.c_cc_adquiriente_tipodoc, Me.v_cc_adquiriente_ruc, Me.v_cc_adquiriente_razonsocial, Me.c_cc_moneda, Me.n_cc_total})
        Me.dgvComprobantes.Location = New System.Drawing.Point(12, 168)
        Me.dgvComprobantes.Name = "dgvComprobantes"
        Me.dgvComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobantes.Size = New System.Drawing.Size(1005, 246)
        Me.dgvComprobantes.TabIndex = 36
        '
        'n_cc_id
        '
        Me.n_cc_id.DataPropertyName = "n_cc_id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.n_cc_id.DefaultCellStyle = DataGridViewCellStyle1
        Me.n_cc_id.HeaderText = "ID"
        Me.n_cc_id.Name = "n_cc_id"
        Me.n_cc_id.ReadOnly = True
        Me.n_cc_id.Width = 50
        '
        'd_cc_fecha
        '
        Me.d_cc_fecha.DataPropertyName = "d_cc_fecha"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.d_cc_fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.d_cc_fecha.HeaderText = "FECHA"
        Me.d_cc_fecha.Name = "d_cc_fecha"
        Me.d_cc_fecha.ReadOnly = True
        Me.d_cc_fecha.Width = 80
        '
        'c_cc_tipo
        '
        Me.c_cc_tipo.DataPropertyName = "c_cc_tipo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.c_cc_tipo.DefaultCellStyle = DataGridViewCellStyle3
        Me.c_cc_tipo.HeaderText = "TIPO"
        Me.c_cc_tipo.Name = "c_cc_tipo"
        Me.c_cc_tipo.ReadOnly = True
        Me.c_cc_tipo.Width = 45
        '
        'v_cc_serie
        '
        Me.v_cc_serie.DataPropertyName = "v_cc_serie"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.v_cc_serie.DefaultCellStyle = DataGridViewCellStyle4
        Me.v_cc_serie.HeaderText = "SERIE"
        Me.v_cc_serie.Name = "v_cc_serie"
        Me.v_cc_serie.ReadOnly = True
        Me.v_cc_serie.Width = 50
        '
        'v_cc_numero
        '
        Me.v_cc_numero.DataPropertyName = "v_cc_numero"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.v_cc_numero.DefaultCellStyle = DataGridViewCellStyle5
        Me.v_cc_numero.HeaderText = "NRO"
        Me.v_cc_numero.Name = "v_cc_numero"
        Me.v_cc_numero.ReadOnly = True
        Me.v_cc_numero.Width = 50
        '
        'v_cc_emisor_ruc
        '
        Me.v_cc_emisor_ruc.DataPropertyName = "v_cc_emisor_ruc"
        Me.v_cc_emisor_ruc.HeaderText = "v_cc_emisor_ruc"
        Me.v_cc_emisor_ruc.Name = "v_cc_emisor_ruc"
        Me.v_cc_emisor_ruc.ReadOnly = True
        Me.v_cc_emisor_ruc.Visible = False
        '
        'v_cc_emisor_razonsocial
        '
        Me.v_cc_emisor_razonsocial.DataPropertyName = "v_cc_emisor_razonsocial"
        Me.v_cc_emisor_razonsocial.HeaderText = "EMISOR"
        Me.v_cc_emisor_razonsocial.Name = "v_cc_emisor_razonsocial"
        Me.v_cc_emisor_razonsocial.ReadOnly = True
        Me.v_cc_emisor_razonsocial.Width = 200
        '
        'c_cc_adquiriente_tipodoc
        '
        Me.c_cc_adquiriente_tipodoc.DataPropertyName = "c_cc_adquiriente_tipodoc"
        Me.c_cc_adquiriente_tipodoc.HeaderText = "c_cc_adquiriente_tipodoc"
        Me.c_cc_adquiriente_tipodoc.Name = "c_cc_adquiriente_tipodoc"
        Me.c_cc_adquiriente_tipodoc.ReadOnly = True
        Me.c_cc_adquiriente_tipodoc.Visible = False
        '
        'v_cc_adquiriente_ruc
        '
        Me.v_cc_adquiriente_ruc.DataPropertyName = "v_cc_adquiriente_ruc"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.v_cc_adquiriente_ruc.DefaultCellStyle = DataGridViewCellStyle6
        Me.v_cc_adquiriente_ruc.HeaderText = "CLIENTE RUC"
        Me.v_cc_adquiriente_ruc.Name = "v_cc_adquiriente_ruc"
        Me.v_cc_adquiriente_ruc.ReadOnly = True
        Me.v_cc_adquiriente_ruc.Width = 110
        '
        'v_cc_adquiriente_razonsocial
        '
        Me.v_cc_adquiriente_razonsocial.DataPropertyName = "v_cc_adquiriente_razonsocial"
        Me.v_cc_adquiriente_razonsocial.HeaderText = "CLIENTE R. SOCIAL"
        Me.v_cc_adquiriente_razonsocial.Name = "v_cc_adquiriente_razonsocial"
        Me.v_cc_adquiriente_razonsocial.ReadOnly = True
        Me.v_cc_adquiriente_razonsocial.Width = 200
        '
        'c_cc_moneda
        '
        Me.c_cc_moneda.DataPropertyName = "c_cc_moneda"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.c_cc_moneda.DefaultCellStyle = DataGridViewCellStyle7
        Me.c_cc_moneda.HeaderText = "MONEDA"
        Me.c_cc_moneda.Name = "c_cc_moneda"
        Me.c_cc_moneda.ReadOnly = True
        Me.c_cc_moneda.Width = 80
        '
        'n_cc_total
        '
        Me.n_cc_total.DataPropertyName = "n_cc_total"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.n_cc_total.DefaultCellStyle = DataGridViewCellStyle8
        Me.n_cc_total.HeaderText = "TOTAL"
        Me.n_cc_total.Name = "n_cc_total"
        Me.n_cc_total.ReadOnly = True
        Me.n_cc_total.Width = 90
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGenerar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGenerar.Location = New System.Drawing.Point(867, 424)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(150, 30)
        Me.btnGenerar.TabIndex = 37
        Me.btnGenerar.Text = "GENERAR NOTA"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Motivo:"
        '
        'cboMotivo
        '
        Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cboMotivo.Location = New System.Drawing.Point(62, 89)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(364, 21)
        Me.cboMotivo.TabIndex = 39
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(62, 127)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(186, 20)
        Me.txtImporte.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Importe:"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(326, 50)
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.ReadOnly = True
        Me.txtCorrelativo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrelativo.TabIndex = 45
        '
        'cboSeries
        '
        Me.cboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeries.FormattingEnabled = True
        Me.cboSeries.Location = New System.Drawing.Point(62, 50)
        Me.cboSeries.Name = "cboSeries"
        Me.cboSeries.Size = New System.Drawing.Size(186, 21)
        Me.cboSeries.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Correlativo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Serie:"
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(550, 12)
        Me.txtDetalle.Multiline = True
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(467, 135)
        Me.txtDetalle.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Detalle:"
        '
        'frmNotaGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 466)
        Me.Controls.Add(Me.dgvComprobantes)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.cboSeries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboMotivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboTipo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmNotaGenerar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTA - GENERAR"
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvComprobantes As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents cboSeries As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents n_cc_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents d_cc_fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_cc_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_emisor_ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_emisor_razonsocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_cc_adquiriente_tipodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_adquiriente_ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents v_cc_adquiriente_razonsocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_cc_moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents n_cc_total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
