<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLetras
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlBusqueda = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProyecto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.dgvPendientes = New System.Windows.Forms.DataGridView()
        Me.chkBoleta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.bol_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_proyecto_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_proyecto_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_cliente_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_cliente_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_lote_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_lote_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_fec_venc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_letra_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_tipo_pago_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_operacion_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_fecha_pago_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_tipo_documento_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_documento_pd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBoletear = New System.Windows.Forms.Button()
        Me.dgvCanceladas = New System.Windows.Forms.DataGridView()
        Me.bol_id_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_serie_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_correlativo_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_proyecto_id_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_proyecto_nombre_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_cliente_id_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_cliente_nombre_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_lote_id_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_lote_nombre_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_cuota_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_fec_venc_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_moneda_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_importe_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_letra_id_pg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_tipo_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_operacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_fecha_pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_nro_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlBusqueda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvCanceladas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBusqueda
        '
        Me.pnlBusqueda.Controls.Add(Me.GroupBox1)
        Me.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.pnlBusqueda.Name = "pnlBusqueda"
        Me.pnlBusqueda.Size = New System.Drawing.Size(1365, 79)
        Me.pnlBusqueda.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cboLote)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboProyecto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1365, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(942, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 25)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboLote
        '
        Me.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(757, 22)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(121, 21)
        Me.cboLote.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(720, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lote:"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(368, 22)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(324, 21)
        Me.cboCliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'cboProyecto
        '
        Me.cboProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProyecto.FormattingEnabled = True
        Me.cboProyecto.Location = New System.Drawing.Point(70, 22)
        Me.cboProyecto.Name = "cboProyecto"
        Me.cboProyecto.Size = New System.Drawing.Size(233, 21)
        Me.cboProyecto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proyecto:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1365, 37)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LETRAS PENDIENTES"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 438)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(1365, 5)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'dgvPendientes
        '
        Me.dgvPendientes.AllowUserToAddRows = False
        Me.dgvPendientes.AllowUserToDeleteRows = False
        Me.dgvPendientes.AllowUserToOrderColumns = True
        Me.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkBoleta, Me.bol_id, Me.bol_serie, Me.bol_correlativo, Me.bol_proyecto_id, Me.bol_proyecto_nombre, Me.bol_cliente_id, Me.bol_cliente_nombre, Me.bol_lote_id, Me.bol_lote_nombre, Me.bol_nro_cuota, Me.bol_fec_venc, Me.bol_moneda, Me.bol_importe, Me.bol_letra_id, Me.bol_tipo_pago_pd, Me.bol_nro_operacion_pd, Me.bol_fecha_pago_pd, Me.bol_tipo_documento_pd, Me.bol_nro_documento_pd})
        Me.dgvPendientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvPendientes.Location = New System.Drawing.Point(0, 116)
        Me.dgvPendientes.MultiSelect = False
        Me.dgvPendientes.Name = "dgvPendientes"
        Me.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendientes.Size = New System.Drawing.Size(1365, 322)
        Me.dgvPendientes.TabIndex = 3
        '
        'chkBoleta
        '
        Me.chkBoleta.HeaderText = ""
        Me.chkBoleta.Name = "chkBoleta"
        Me.chkBoleta.Width = 50
        '
        'bol_id
        '
        Me.bol_id.DataPropertyName = "bol_id"
        Me.bol_id.HeaderText = "bol_id"
        Me.bol_id.Name = "bol_id"
        Me.bol_id.ReadOnly = True
        Me.bol_id.Visible = False
        '
        'bol_serie
        '
        Me.bol_serie.DataPropertyName = "bol_serie"
        Me.bol_serie.HeaderText = "bol_serie"
        Me.bol_serie.Name = "bol_serie"
        Me.bol_serie.ReadOnly = True
        Me.bol_serie.Visible = False
        '
        'bol_correlativo
        '
        Me.bol_correlativo.DataPropertyName = "bol_correlativo"
        Me.bol_correlativo.HeaderText = "bol_correlativo"
        Me.bol_correlativo.Name = "bol_correlativo"
        Me.bol_correlativo.ReadOnly = True
        Me.bol_correlativo.Visible = False
        '
        'bol_proyecto_id
        '
        Me.bol_proyecto_id.DataPropertyName = "bol_proyecto_id"
        Me.bol_proyecto_id.HeaderText = "bol_proyecto_id"
        Me.bol_proyecto_id.Name = "bol_proyecto_id"
        Me.bol_proyecto_id.ReadOnly = True
        Me.bol_proyecto_id.Visible = False
        '
        'bol_proyecto_nombre
        '
        Me.bol_proyecto_nombre.DataPropertyName = "bol_proyecto_nombre"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.bol_proyecto_nombre.DefaultCellStyle = DataGridViewCellStyle1
        Me.bol_proyecto_nombre.HeaderText = "PROYECTO"
        Me.bol_proyecto_nombre.Name = "bol_proyecto_nombre"
        Me.bol_proyecto_nombre.ReadOnly = True
        Me.bol_proyecto_nombre.Width = 220
        '
        'bol_cliente_id
        '
        Me.bol_cliente_id.DataPropertyName = "bol_cliente_id"
        Me.bol_cliente_id.HeaderText = "bol_cliente_id"
        Me.bol_cliente_id.Name = "bol_cliente_id"
        Me.bol_cliente_id.ReadOnly = True
        Me.bol_cliente_id.Visible = False
        '
        'bol_cliente_nombre
        '
        Me.bol_cliente_nombre.DataPropertyName = "bol_cliente_nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.bol_cliente_nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.bol_cliente_nombre.HeaderText = "CLIENTE"
        Me.bol_cliente_nombre.Name = "bol_cliente_nombre"
        Me.bol_cliente_nombre.ReadOnly = True
        Me.bol_cliente_nombre.Width = 270
        '
        'bol_lote_id
        '
        Me.bol_lote_id.DataPropertyName = "bol_lote_id"
        Me.bol_lote_id.HeaderText = "bol_lote_id"
        Me.bol_lote_id.Name = "bol_lote_id"
        Me.bol_lote_id.ReadOnly = True
        Me.bol_lote_id.Visible = False
        '
        'bol_lote_nombre
        '
        Me.bol_lote_nombre.DataPropertyName = "bol_lote_nombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bol_lote_nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.bol_lote_nombre.HeaderText = "MZA-LOTE"
        Me.bol_lote_nombre.Name = "bol_lote_nombre"
        Me.bol_lote_nombre.ReadOnly = True
        Me.bol_lote_nombre.Width = 90
        '
        'bol_nro_cuota
        '
        Me.bol_nro_cuota.DataPropertyName = "bol_nro_cuota"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.bol_nro_cuota.DefaultCellStyle = DataGridViewCellStyle4
        Me.bol_nro_cuota.HeaderText = "Nro. CUOTA"
        Me.bol_nro_cuota.Name = "bol_nro_cuota"
        Me.bol_nro_cuota.ReadOnly = True
        Me.bol_nro_cuota.Width = 90
        '
        'bol_fec_venc
        '
        Me.bol_fec_venc.DataPropertyName = "bol_fec_venc"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd'/'MM'/'yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.bol_fec_venc.DefaultCellStyle = DataGridViewCellStyle5
        Me.bol_fec_venc.HeaderText = "FEC. VENC."
        Me.bol_fec_venc.Name = "bol_fec_venc"
        Me.bol_fec_venc.ReadOnly = True
        '
        'bol_moneda
        '
        Me.bol_moneda.DataPropertyName = "bol_moneda"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bol_moneda.DefaultCellStyle = DataGridViewCellStyle6
        Me.bol_moneda.HeaderText = "MONEDA"
        Me.bol_moneda.Name = "bol_moneda"
        Me.bol_moneda.ReadOnly = True
        Me.bol_moneda.Width = 75
        '
        'bol_importe
        '
        Me.bol_importe.DataPropertyName = "bol_importe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.bol_importe.DefaultCellStyle = DataGridViewCellStyle7
        Me.bol_importe.HeaderText = "IMPORTE"
        Me.bol_importe.Name = "bol_importe"
        Me.bol_importe.ReadOnly = True
        Me.bol_importe.Width = 110
        '
        'bol_letra_id
        '
        Me.bol_letra_id.DataPropertyName = "bol_letra_id"
        Me.bol_letra_id.HeaderText = "bol_letra_id"
        Me.bol_letra_id.Name = "bol_letra_id"
        Me.bol_letra_id.ReadOnly = True
        Me.bol_letra_id.Visible = False
        '
        'bol_tipo_pago_pd
        '
        Me.bol_tipo_pago_pd.DataPropertyName = "bol_tipo_pago"
        Me.bol_tipo_pago_pd.HeaderText = "bol_tipo_pago"
        Me.bol_tipo_pago_pd.Name = "bol_tipo_pago_pd"
        Me.bol_tipo_pago_pd.ReadOnly = True
        Me.bol_tipo_pago_pd.Visible = False
        '
        'bol_nro_operacion_pd
        '
        Me.bol_nro_operacion_pd.DataPropertyName = "bol_nro_operacion"
        Me.bol_nro_operacion_pd.HeaderText = "bol_nro_operacion"
        Me.bol_nro_operacion_pd.Name = "bol_nro_operacion_pd"
        Me.bol_nro_operacion_pd.ReadOnly = True
        Me.bol_nro_operacion_pd.Visible = False
        '
        'bol_fecha_pago_pd
        '
        Me.bol_fecha_pago_pd.DataPropertyName = "bol_fecha_pago"
        Me.bol_fecha_pago_pd.HeaderText = "bol_fecha_pago"
        Me.bol_fecha_pago_pd.Name = "bol_fecha_pago_pd"
        Me.bol_fecha_pago_pd.Visible = False
        '
        'bol_tipo_documento_pd
        '
        Me.bol_tipo_documento_pd.DataPropertyName = "bol_tipo_documento"
        Me.bol_tipo_documento_pd.HeaderText = "bol_tipo_documento"
        Me.bol_tipo_documento_pd.Name = "bol_tipo_documento_pd"
        Me.bol_tipo_documento_pd.ReadOnly = True
        Me.bol_tipo_documento_pd.Visible = False
        '
        'bol_nro_documento_pd
        '
        Me.bol_nro_documento_pd.DataPropertyName = "bol_nro_documento"
        Me.bol_nro_documento_pd.HeaderText = "bol_nro_documento"
        Me.bol_nro_documento_pd.Name = "bol_nro_documento_pd"
        Me.bol_nro_documento_pd.ReadOnly = True
        Me.bol_nro_documento_pd.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 443)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1365, 37)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "LETRAS CANCELADAS"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBoletear)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 654)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1365, 55)
        Me.Panel3.TabIndex = 8
        '
        'btnBoletear
        '
        Me.btnBoletear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBoletear.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnBoletear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBoletear.Location = New System.Drawing.Point(1203, 13)
        Me.btnBoletear.Name = "btnBoletear"
        Me.btnBoletear.Size = New System.Drawing.Size(150, 30)
        Me.btnBoletear.TabIndex = 0
        Me.btnBoletear.Text = "PROCESAR"
        Me.btnBoletear.UseVisualStyleBackColor = False
        '
        'dgvCanceladas
        '
        Me.dgvCanceladas.AllowUserToAddRows = False
        Me.dgvCanceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCanceladas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bol_id_pg, Me.bol_serie_pg, Me.bol_correlativo_pg, Me.bol_proyecto_id_pg, Me.bol_proyecto_nombre_pg, Me.bol_cliente_id_pg, Me.bol_cliente_nombre_pg, Me.bol_lote_id_pg, Me.bol_lote_nombre_pg, Me.bol_nro_cuota_pg, Me.bol_fec_venc_pg, Me.bol_moneda_pg, Me.bol_importe_pg, Me.bol_letra_id_pg, Me.bol_tipo_pago, Me.bol_nro_operacion, Me.bol_fecha_pago, Me.bol_tipo_documento, Me.bol_nro_documento})
        Me.dgvCanceladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCanceladas.Location = New System.Drawing.Point(0, 480)
        Me.dgvCanceladas.MultiSelect = False
        Me.dgvCanceladas.Name = "dgvCanceladas"
        Me.dgvCanceladas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCanceladas.Size = New System.Drawing.Size(1365, 174)
        Me.dgvCanceladas.TabIndex = 9
        '
        'bol_id_pg
        '
        Me.bol_id_pg.DataPropertyName = "bol_id"
        Me.bol_id_pg.HeaderText = "bol_id"
        Me.bol_id_pg.Name = "bol_id_pg"
        Me.bol_id_pg.ReadOnly = True
        Me.bol_id_pg.Visible = False
        '
        'bol_serie_pg
        '
        Me.bol_serie_pg.DataPropertyName = "bol_serie"
        Me.bol_serie_pg.HeaderText = "bol_serie"
        Me.bol_serie_pg.Name = "bol_serie_pg"
        Me.bol_serie_pg.ReadOnly = True
        Me.bol_serie_pg.Visible = False
        '
        'bol_correlativo_pg
        '
        Me.bol_correlativo_pg.DataPropertyName = "bol_correlativo"
        Me.bol_correlativo_pg.HeaderText = "bol_correlativo"
        Me.bol_correlativo_pg.Name = "bol_correlativo_pg"
        Me.bol_correlativo_pg.ReadOnly = True
        Me.bol_correlativo_pg.Visible = False
        '
        'bol_proyecto_id_pg
        '
        Me.bol_proyecto_id_pg.DataPropertyName = "bol_proyecto_id"
        Me.bol_proyecto_id_pg.HeaderText = "bol_proyecto_id"
        Me.bol_proyecto_id_pg.Name = "bol_proyecto_id_pg"
        Me.bol_proyecto_id_pg.ReadOnly = True
        Me.bol_proyecto_id_pg.Visible = False
        '
        'bol_proyecto_nombre_pg
        '
        Me.bol_proyecto_nombre_pg.DataPropertyName = "bol_proyecto_nombre"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.bol_proyecto_nombre_pg.DefaultCellStyle = DataGridViewCellStyle8
        Me.bol_proyecto_nombre_pg.HeaderText = "PROYECTO"
        Me.bol_proyecto_nombre_pg.Name = "bol_proyecto_nombre_pg"
        Me.bol_proyecto_nombre_pg.ReadOnly = True
        Me.bol_proyecto_nombre_pg.Width = 250
        '
        'bol_cliente_id_pg
        '
        Me.bol_cliente_id_pg.DataPropertyName = "bol_cliente_id"
        Me.bol_cliente_id_pg.HeaderText = "bol_cliente_id"
        Me.bol_cliente_id_pg.Name = "bol_cliente_id_pg"
        Me.bol_cliente_id_pg.ReadOnly = True
        Me.bol_cliente_id_pg.Visible = False
        '
        'bol_cliente_nombre_pg
        '
        Me.bol_cliente_nombre_pg.DataPropertyName = "bol_cliente_nombre"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.bol_cliente_nombre_pg.DefaultCellStyle = DataGridViewCellStyle9
        Me.bol_cliente_nombre_pg.HeaderText = "CLIENTE"
        Me.bol_cliente_nombre_pg.Name = "bol_cliente_nombre_pg"
        Me.bol_cliente_nombre_pg.ReadOnly = True
        Me.bol_cliente_nombre_pg.Width = 250
        '
        'bol_lote_id_pg
        '
        Me.bol_lote_id_pg.DataPropertyName = "bol_lote_id"
        Me.bol_lote_id_pg.HeaderText = "bol_lote_id"
        Me.bol_lote_id_pg.Name = "bol_lote_id_pg"
        Me.bol_lote_id_pg.ReadOnly = True
        Me.bol_lote_id_pg.Visible = False
        '
        'bol_lote_nombre_pg
        '
        Me.bol_lote_nombre_pg.DataPropertyName = "bol_lote_nombre"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bol_lote_nombre_pg.DefaultCellStyle = DataGridViewCellStyle10
        Me.bol_lote_nombre_pg.HeaderText = "MZA-LOTE"
        Me.bol_lote_nombre_pg.Name = "bol_lote_nombre_pg"
        Me.bol_lote_nombre_pg.ReadOnly = True
        Me.bol_lote_nombre_pg.Width = 90
        '
        'bol_nro_cuota_pg
        '
        Me.bol_nro_cuota_pg.DataPropertyName = "bol_nro_cuota"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.bol_nro_cuota_pg.DefaultCellStyle = DataGridViewCellStyle11
        Me.bol_nro_cuota_pg.HeaderText = "Nro. CUOTA"
        Me.bol_nro_cuota_pg.Name = "bol_nro_cuota_pg"
        Me.bol_nro_cuota_pg.ReadOnly = True
        '
        'bol_fec_venc_pg
        '
        Me.bol_fec_venc_pg.DataPropertyName = "bol_fec_venc"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.bol_fec_venc_pg.DefaultCellStyle = DataGridViewCellStyle12
        Me.bol_fec_venc_pg.HeaderText = "FEC. VENC."
        Me.bol_fec_venc_pg.Name = "bol_fec_venc_pg"
        Me.bol_fec_venc_pg.ReadOnly = True
        Me.bol_fec_venc_pg.Width = 90
        '
        'bol_moneda_pg
        '
        Me.bol_moneda_pg.DataPropertyName = "bol_moneda"
        Me.bol_moneda_pg.HeaderText = "MONEDA"
        Me.bol_moneda_pg.Name = "bol_moneda_pg"
        Me.bol_moneda_pg.ReadOnly = True
        '
        'bol_importe_pg
        '
        Me.bol_importe_pg.DataPropertyName = "bol_importe"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.bol_importe_pg.DefaultCellStyle = DataGridViewCellStyle13
        Me.bol_importe_pg.HeaderText = "IMPORTE"
        Me.bol_importe_pg.Name = "bol_importe_pg"
        Me.bol_importe_pg.ReadOnly = True
        '
        'bol_letra_id_pg
        '
        Me.bol_letra_id_pg.DataPropertyName = "bol_letra_id"
        Me.bol_letra_id_pg.HeaderText = "bol_letra_id"
        Me.bol_letra_id_pg.Name = "bol_letra_id_pg"
        Me.bol_letra_id_pg.ReadOnly = True
        Me.bol_letra_id_pg.Visible = False
        '
        'bol_tipo_pago
        '
        Me.bol_tipo_pago.DataPropertyName = "bol_tipo_pago"
        Me.bol_tipo_pago.HeaderText = "TIPO PAGO"
        Me.bol_tipo_pago.Name = "bol_tipo_pago"
        Me.bol_tipo_pago.ReadOnly = True
        '
        'bol_nro_operacion
        '
        Me.bol_nro_operacion.DataPropertyName = "bol_nro_operacion"
        Me.bol_nro_operacion.HeaderText = "Nro. OPERACIÓN"
        Me.bol_nro_operacion.Name = "bol_nro_operacion"
        Me.bol_nro_operacion.ReadOnly = True
        Me.bol_nro_operacion.Width = 120
        '
        'bol_fecha_pago
        '
        Me.bol_fecha_pago.DataPropertyName = "bol_fecha_pago"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Format = "dd'/'MM'/'yyyy"
        Me.bol_fecha_pago.DefaultCellStyle = DataGridViewCellStyle14
        Me.bol_fecha_pago.HeaderText = "FECHA PAGO"
        Me.bol_fecha_pago.Name = "bol_fecha_pago"
        Me.bol_fecha_pago.ReadOnly = True
        '
        'bol_tipo_documento
        '
        Me.bol_tipo_documento.DataPropertyName = "bol_tipo_documento"
        Me.bol_tipo_documento.HeaderText = "TIPO DOCUMENTO"
        Me.bol_tipo_documento.Name = "bol_tipo_documento"
        Me.bol_tipo_documento.ReadOnly = True
        Me.bol_tipo_documento.Width = 130
        '
        'bol_nro_documento
        '
        Me.bol_nro_documento.DataPropertyName = "bol_nro_documento"
        Me.bol_nro_documento.HeaderText = "Nro. DOCUMENTO"
        Me.bol_nro_documento.Name = "bol_nro_documento"
        Me.bol_nro_documento.ReadOnly = True
        Me.bol_nro_documento.Width = 130
        '
        'frmLetras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 709)
        Me.Controls.Add(Me.dgvCanceladas)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.dgvPendientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBusqueda)
        Me.Name = "frmLetras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BOLETA / FACTURA"
        Me.pnlBusqueda.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvCanceladas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBusqueda As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cboLote As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboProyecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents dgvPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBoletear As System.Windows.Forms.Button
    Friend WithEvents dgvCanceladas As System.Windows.Forms.DataGridView
    Friend WithEvents chkBoleta As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents bol_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_proyecto_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_proyecto_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_cliente_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_cliente_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_lote_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_lote_nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_fec_venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_letra_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_tipo_pago_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_operacion_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_fecha_pago_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_tipo_documento_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_documento_pd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_id_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_serie_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_correlativo_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_proyecto_id_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_proyecto_nombre_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_cliente_id_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_cliente_nombre_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_lote_id_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_lote_nombre_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_cuota_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_fec_venc_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_moneda_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_importe_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_letra_id_pg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_tipo_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_operacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_fecha_pago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_nro_documento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
