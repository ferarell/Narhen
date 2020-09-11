<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpresa
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
        Me.dgvEmpresa = New System.Windows.Forms.DataGridView()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_razsoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_tipodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_nrodoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_distrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RptaMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorMensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmpresa
        '
        Me.dgvEmpresa.AllowUserToAddRows = False
        Me.dgvEmpresa.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpresa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emp_id, Me.emp_razsoc, Me.emp_tipodoc, Me.emp_nrodoc, Me.emp_direccion, Me.emp_distrito, Me.RptaMensaje, Me.ErrorCodigo, Me.ErrorMensaje})
        Me.dgvEmpresa.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmpresa.MultiSelect = False
        Me.dgvEmpresa.Name = "dgvEmpresa"
        Me.dgvEmpresa.ReadOnly = True
        Me.dgvEmpresa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpresa.Size = New System.Drawing.Size(829, 191)
        Me.dgvEmpresa.TabIndex = 0
        '
        'emp_id
        '
        Me.emp_id.DataPropertyName = "emp_id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.emp_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.emp_id.HeaderText = "ID"
        Me.emp_id.Name = "emp_id"
        Me.emp_id.ReadOnly = True
        '
        'emp_razsoc
        '
        Me.emp_razsoc.DataPropertyName = "emp_razsoc"
        Me.emp_razsoc.HeaderText = "RAZON SOCIAL"
        Me.emp_razsoc.Name = "emp_razsoc"
        Me.emp_razsoc.ReadOnly = True
        Me.emp_razsoc.Width = 250
        '
        'emp_tipodoc
        '
        Me.emp_tipodoc.DataPropertyName = "emp_tipodoc"
        Me.emp_tipodoc.HeaderText = "TIPO DOC"
        Me.emp_tipodoc.Name = "emp_tipodoc"
        Me.emp_tipodoc.ReadOnly = True
        Me.emp_tipodoc.Visible = False
        '
        'emp_nrodoc
        '
        Me.emp_nrodoc.DataPropertyName = "emp_nrodoc"
        Me.emp_nrodoc.HeaderText = "NRO DOC."
        Me.emp_nrodoc.Name = "emp_nrodoc"
        Me.emp_nrodoc.ReadOnly = True
        '
        'emp_direccion
        '
        Me.emp_direccion.DataPropertyName = "emp_direccion"
        Me.emp_direccion.HeaderText = "DIRECCION"
        Me.emp_direccion.Name = "emp_direccion"
        Me.emp_direccion.ReadOnly = True
        Me.emp_direccion.Width = 200
        '
        'emp_distrito
        '
        Me.emp_distrito.DataPropertyName = "emp_distrito"
        Me.emp_distrito.HeaderText = "DISTRITO"
        Me.emp_distrito.Name = "emp_distrito"
        Me.emp_distrito.ReadOnly = True
        '
        'RptaMensaje
        '
        Me.RptaMensaje.DataPropertyName = "RptaMensaje"
        Me.RptaMensaje.HeaderText = "RPTA MSJ"
        Me.RptaMensaje.Name = "RptaMensaje"
        Me.RptaMensaje.ReadOnly = True
        Me.RptaMensaje.Visible = False
        '
        'ErrorCodigo
        '
        Me.ErrorCodigo.DataPropertyName = "ErrorCodigo"
        Me.ErrorCodigo.HeaderText = "ERROR COD"
        Me.ErrorCodigo.Name = "ErrorCodigo"
        Me.ErrorCodigo.ReadOnly = True
        Me.ErrorCodigo.Visible = False
        '
        'ErrorMensaje
        '
        Me.ErrorMensaje.DataPropertyName = "ErrorMensaje"
        Me.ErrorMensaje.HeaderText = "ERROR MSJ"
        Me.ErrorMensaje.Name = "ErrorMensaje"
        Me.ErrorMensaje.ReadOnly = True
        Me.ErrorMensaje.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.ToolStripSeparator2, Me.btnLimpiar, Me.ToolStripSeparator1, Me.btnGrabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 191)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(829, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.Lotizador.WIN.My.Resources.Resources.MenuBar_Nuevo
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(23, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnEditar
        '
        Me.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEditar.Image = Global.Lotizador.WIN.My.Resources.Resources.table_edit
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(23, 22)
        Me.btnEditar.Text = "Editar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnLimpiar
        '
        Me.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLimpiar.Image = Global.Lotizador.WIN.My.Resources.Resources.escoba2
        Me.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(23, 22)
        Me.btnLimpiar.Text = "Limpiar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnGrabar
        '
        Me.btnGrabar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGrabar.Image = Global.Lotizador.WIN.My.Resources.Resources.Save
        Me.btnGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(23, 22)
        Me.btnGrabar.Text = "Grabar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nro. Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Distrito:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(143, 262)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(303, 20)
        Me.txtRazonSocial.TabIndex = 7
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(143, 326)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(303, 20)
        Me.txtNroDocumento.TabIndex = 9
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(143, 358)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(303, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtDistrito
        '
        Me.txtDistrito.Location = New System.Drawing.Point(143, 390)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(303, 20)
        Me.txtDistrito.TabIndex = 11
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(143, 294)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(303, 21)
        Me.cboTipoDocumento.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(143, 232)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(303, 20)
        Me.txtID.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ID:"
        '
        'frmEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 433)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.txtDistrito)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNroDocumento)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvEmpresa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        CType(Me.dgvEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEmpresa As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDocumento As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrito As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents emp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_razsoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_tipodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_nrodoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_distrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RptaMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorMensaje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
