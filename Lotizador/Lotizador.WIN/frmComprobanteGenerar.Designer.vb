<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteGenerar
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
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.cboSerie = New System.Windows.Forms.ComboBox()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.dgvPendientes = New System.Windows.Forms.DataGridView()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDocumento = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(288, 83)
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.ReadOnly = True
        Me.txtCorrelativo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorrelativo.TabIndex = 20
        '
        'cboSerie
        '
        Me.cboSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSerie.FormattingEnabled = True
        Me.cboSerie.Location = New System.Drawing.Point(69, 83)
        Me.cboSerie.Name = "cboSerie"
        Me.cboSerie.Size = New System.Drawing.Size(102, 21)
        Me.cboSerie.TabIndex = 19
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(69, 46)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(319, 21)
        Me.cboEmpresa.TabIndex = 18
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(449, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(403, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Correlativo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Serie:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Empresa:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProcesar.Location = New System.Drawing.Point(850, 460)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(170, 30)
        Me.btnProcesar.TabIndex = 22
        Me.btnProcesar.Text = "GENERAR COMPROBANTE"
        Me.btnProcesar.UseVisualStyleBackColor = False
        '
        'dgvPendientes
        '
        Me.dgvPendientes.AllowUserToAddRows = False
        Me.dgvPendientes.AllowUserToDeleteRows = False
        Me.dgvPendientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bol_id, Me.bol_serie, Me.bol_correlativo, Me.bol_proyecto_id, Me.bol_proyecto_nombre, Me.bol_cliente_id, Me.bol_cliente_nombre, Me.bol_lote_id, Me.bol_lote_nombre, Me.bol_nro_cuota, Me.bol_fec_venc, Me.bol_moneda, Me.bol_importe, Me.bol_letra_id})
        Me.dgvPendientes.Location = New System.Drawing.Point(10, 119)
        Me.dgvPendientes.Name = "dgvPendientes"
        Me.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPendientes.Size = New System.Drawing.Size(1009, 322)
        Me.dgvPendientes.TabIndex = 23
        '
        'bol_id
        '
        Me.bol_id.DataPropertyName = "bol_id"
        Me.bol_id.HeaderText = "bol_id"
        Me.bol_id.Name = "bol_id"
        Me.bol_id.Visible = False
        '
        'bol_serie
        '
        Me.bol_serie.DataPropertyName = "bol_serie"
        Me.bol_serie.HeaderText = "bol_serie"
        Me.bol_serie.Name = "bol_serie"
        Me.bol_serie.Visible = False
        '
        'bol_correlativo
        '
        Me.bol_correlativo.DataPropertyName = "bol_correlativo"
        Me.bol_correlativo.HeaderText = "bol_correlativo"
        Me.bol_correlativo.Name = "bol_correlativo"
        Me.bol_correlativo.Visible = False
        '
        'bol_proyecto_id
        '
        Me.bol_proyecto_id.DataPropertyName = "bol_proyecto_id"
        Me.bol_proyecto_id.HeaderText = "bol_proyecto_id"
        Me.bol_proyecto_id.Name = "bol_proyecto_id"
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
        Me.bol_letra_id.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Tipo:"
        '
        'cboDocumento
        '
        Me.cboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocumento.FormattingEnabled = True
        Me.cboDocumento.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cboDocumento.Location = New System.Drawing.Point(69, 9)
        Me.cboDocumento.Name = "cboDocumento"
        Me.cboDocumento.Size = New System.Drawing.Size(186, 21)
        Me.cboDocumento.TabIndex = 25
        '
        'frmComprobanteGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 502)
        Me.Controls.Add(Me.cboDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvPendientes)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.cboSerie)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmComprobanteGenerar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPROBANTES - GENERAR"
        CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents cboSerie As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents dgvPendientes As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboDocumento As System.Windows.Forms.ComboBox
End Class
