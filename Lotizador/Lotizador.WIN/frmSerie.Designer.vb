<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerie
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGrabar = New System.Windows.Forms.ToolStripButton()
        Me.dgvSerie = New System.Windows.Forms.DataGridView()
        Me.sre_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_razsoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sre_tipdoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sre_serie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sre_correlativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.txtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(143, 243)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(303, 20)
        Me.txtID.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ID:"
        '
        'cboTipoComprobante
        '
        Me.cboTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoComprobante.FormattingEnabled = True
        Me.cboTipoComprobante.Location = New System.Drawing.Point(143, 305)
        Me.cboTipoComprobante.Name = "cboTipoComprobante"
        Me.cboTipoComprobante.Size = New System.Drawing.Size(303, 21)
        Me.cboTipoComprobante.TabIndex = 24
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(143, 337)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(303, 20)
        Me.txtSerie.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Correlativo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Serie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo Comprobante:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Empresa:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEditar, Me.ToolStripSeparator2, Me.btnLimpiar, Me.ToolStripSeparator1, Me.btnGrabar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 191)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(829, 25)
        Me.ToolStrip1.TabIndex = 27
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
        'dgvSerie
        '
        Me.dgvSerie.AllowUserToAddRows = False
        Me.dgvSerie.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSerie.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSerie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sre_id, Me.emp_id, Me.emp_razsoc, Me.sre_tipdoc, Me.sre_serie, Me.sre_correlativo})
        Me.dgvSerie.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvSerie.Location = New System.Drawing.Point(0, 0)
        Me.dgvSerie.MultiSelect = False
        Me.dgvSerie.Name = "dgvSerie"
        Me.dgvSerie.ReadOnly = True
        Me.dgvSerie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSerie.Size = New System.Drawing.Size(829, 191)
        Me.dgvSerie.TabIndex = 0
        '
        'sre_id
        '
        Me.sre_id.DataPropertyName = "sre_id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.sre_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.sre_id.HeaderText = "ID"
        Me.sre_id.Name = "sre_id"
        Me.sre_id.ReadOnly = True
        Me.sre_id.Visible = False
        '
        'emp_id
        '
        Me.emp_id.DataPropertyName = "emp_id"
        Me.emp_id.HeaderText = "emp_id"
        Me.emp_id.Name = "emp_id"
        Me.emp_id.ReadOnly = True
        Me.emp_id.Visible = False
        '
        'emp_razsoc
        '
        Me.emp_razsoc.DataPropertyName = "emp_razsoc"
        Me.emp_razsoc.HeaderText = "EMPRESA"
        Me.emp_razsoc.Name = "emp_razsoc"
        Me.emp_razsoc.ReadOnly = True
        Me.emp_razsoc.Width = 250
        '
        'sre_tipdoc
        '
        Me.sre_tipdoc.DataPropertyName = "sre_tipdoc"
        Me.sre_tipdoc.HeaderText = "COMPROBANTE"
        Me.sre_tipdoc.Name = "sre_tipdoc"
        Me.sre_tipdoc.ReadOnly = True
        '
        'sre_serie
        '
        Me.sre_serie.DataPropertyName = "sre_serie"
        Me.sre_serie.HeaderText = "SERIE"
        Me.sre_serie.Name = "sre_serie"
        Me.sre_serie.ReadOnly = True
        '
        'sre_correlativo
        '
        Me.sre_correlativo.DataPropertyName = "sre_correlativo"
        Me.sre_correlativo.HeaderText = "CORRELATIVO"
        Me.sre_correlativo.Name = "sre_correlativo"
        Me.sre_correlativo.ReadOnly = True
        Me.sre_correlativo.Width = 200
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(143, 273)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(303, 21)
        Me.cboEmpresa.TabIndex = 23
        '
        'txtNroCorrelativo
        '
        Me.txtNroCorrelativo.CausesValidation = False
        Me.txtNroCorrelativo.Location = New System.Drawing.Point(143, 369)
        Me.txtNroCorrelativo.Name = "txtNroCorrelativo"
        Me.txtNroCorrelativo.Size = New System.Drawing.Size(303, 20)
        Me.txtNroCorrelativo.TabIndex = 28
        '
        'frmSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 433)
        Me.Controls.Add(Me.txtNroCorrelativo)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoComprobante)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvSerie)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serie/Correlativo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvSerie As System.Windows.Forms.DataGridView
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents sre_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_razsoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sre_tipdoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sre_serie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sre_correlativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNroCorrelativo As System.Windows.Forms.TextBox
End Class
