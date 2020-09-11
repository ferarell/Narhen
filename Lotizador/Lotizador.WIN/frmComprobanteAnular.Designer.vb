<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteAnular
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
        Me.btnAnular = New System.Windows.Forms.Button()
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
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnular.Location = New System.Drawing.Point(850, 386)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(170, 30)
        Me.btnAnular.TabIndex = 34
        Me.btnAnular.Text = "ANULAR COMPROBANTE"
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(59, 9)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Fecha:"
        '
        'dgvComprobantes
        '
        Me.dgvComprobantes.AllowUserToAddRows = False
        Me.dgvComprobantes.AllowUserToDeleteRows = False
        Me.dgvComprobantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComprobantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.n_cc_id, Me.d_cc_fecha, Me.c_cc_tipo, Me.v_cc_serie, Me.v_cc_numero, Me.v_cc_emisor_ruc, Me.v_cc_emisor_razonsocial, Me.c_cc_adquiriente_tipodoc, Me.v_cc_adquiriente_ruc, Me.v_cc_adquiriente_razonsocial, Me.c_cc_moneda, Me.n_cc_total})
        Me.dgvComprobantes.Location = New System.Drawing.Point(15, 47)
        Me.dgvComprobantes.Name = "dgvComprobantes"
        Me.dgvComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobantes.Size = New System.Drawing.Size(1005, 322)
        Me.dgvComprobantes.TabIndex = 35
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
        'frmComprobanteAnular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 428)
        Me.Controls.Add(Me.dgvComprobantes)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmComprobanteAnular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPROBANTES - ANULAR"
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvComprobantes As System.Windows.Forms.DataGridView
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
