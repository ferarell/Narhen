<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteBuscar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dgvComprobantes = New System.Windows.Forms.DataGridView()
        Me.chkBoleta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 37)
        Me.Panel1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "COMPROBANTES ELECTRONICOS  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(49, 22)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(149, 21)
        Me.cboTipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(972, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 25)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(276, 22)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(299, 20)
        Me.txtCliente.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1084, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnProcesar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 532)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 58)
        Me.Panel2.TabIndex = 8
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProcesar.Location = New System.Drawing.Point(922, 16)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(150, 30)
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = False
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
        Me.dgvComprobantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBoleta, Me.n_cc_id, Me.d_cc_fecha, Me.c_cc_tipo, Me.v_cc_serie, Me.v_cc_numero, Me.v_cc_emisor_ruc, Me.v_cc_emisor_razonsocial, Me.c_cc_adquiriente_tipodoc, Me.v_cc_adquiriente_ruc, Me.v_cc_adquiriente_razonsocial, Me.c_cc_moneda, Me.n_cc_total})
        Me.dgvComprobantes.Location = New System.Drawing.Point(0, 107)
        Me.dgvComprobantes.Name = "dgvComprobantes"
        Me.dgvComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvComprobantes.Size = New System.Drawing.Size(1084, 425)
        Me.dgvComprobantes.TabIndex = 9
        '
        'chkBoleta
        '
        Me.chkBoleta.HeaderText = ""
        Me.chkBoleta.Name = "chkBoleta"
        Me.chkBoleta.Width = 50
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
        Me.c_cc_tipo.Width = 40
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
        'frmComprobanteBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 590)
        Me.Controls.Add(Me.dgvComprobantes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmComprobanteBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPROBANTES - BUSCAR "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents dgvComprobantes As System.Windows.Forms.DataGridView
    Friend WithEvents chkBoleta As System.Windows.Forms.DataGridViewCheckBoxColumn
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
