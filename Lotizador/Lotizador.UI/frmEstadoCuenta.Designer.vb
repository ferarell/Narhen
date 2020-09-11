<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuenta
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lueProyecto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lueLote = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.crvEstadoCuenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.EstadoCuentaContrato1 = New Lotizador.UI.EstadoCuentaContrato()
        Me.GalleryControlGallery1 = New DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery()
        Me.vpReportInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.sbVerReporte = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.vpReportInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.crvEstadoCuenta)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(949, 440)
        Me.SplitContainerControl1.SplitterPosition = 61
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.lueProyecto)
        Me.PanelControl2.Controls.Add(Me.lueCliente)
        Me.PanelControl2.Controls.Add(Me.lblCliente)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lueLote)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(836, 61)
        Me.PanelControl2.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(13, 13)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl8.TabIndex = 42
        Me.LabelControl8.Text = "Proyecto"
        '
        'lueProyecto
        '
        Me.lueProyecto.Location = New System.Drawing.Point(62, 10)
        Me.lueProyecto.Name = "lueProyecto"
        Me.lueProyecto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProyecto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanco", "IdBanco", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueProyecto.Properties.NullText = "Seleccione"
        Me.lueProyecto.Size = New System.Drawing.Size(205, 20)
        Me.lueProyecto.TabIndex = 41
        '
        'lueCliente
        '
        Me.lueCliente.Location = New System.Drawing.Point(331, 10)
        Me.lueCliente.Name = "lueCliente"
        Me.lueCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Cliente"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdSocio", "IdSocio", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueCliente.Properties.NullText = "Seleccione"
        Me.lueCliente.Size = New System.Drawing.Size(336, 20)
        Me.lueCliente.TabIndex = 4
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(292, 13)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(33, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(693, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Lote"
        '
        'lueLote
        '
        Me.lueLote.Location = New System.Drawing.Point(720, 10)
        Me.lueLote.Name = "lueLote"
        Me.lueLote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLote.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManzanaLote", "Lote"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdContrato", "IdContrato", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueLote.Properties.NullText = "Seleccione"
        Me.lueLote.Size = New System.Drawing.Size(73, 20)
        Me.lueLote.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.sbVerReporte)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(836, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.PanelControl1.Size = New System.Drawing.Size(109, 61)
        Me.PanelControl1.TabIndex = 8
        '
        'crvEstadoCuenta
        '
        Me.crvEstadoCuenta.ActiveViewIndex = -1
        Me.crvEstadoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEstadoCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEstadoCuenta.Location = New System.Drawing.Point(0, 0)
        Me.crvEstadoCuenta.Name = "crvEstadoCuenta"
        Me.crvEstadoCuenta.ShowGroupTreeButton = False
        Me.crvEstadoCuenta.Size = New System.Drawing.Size(945, 370)
        Me.crvEstadoCuenta.TabIndex = 0
        Me.crvEstadoCuenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'vpReportInputs
        '
        Me.vpReportInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'sbVerReporte
        '
        Me.sbVerReporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.sbVerReporte.Location = New System.Drawing.Point(2, 7)
        Me.sbVerReporte.Name = "sbVerReporte"
        Me.sbVerReporte.Size = New System.Drawing.Size(105, 23)
        Me.sbVerReporte.TabIndex = 0
        Me.sbVerReporte.Text = "Ver Reporte"
        '
        'frmEstadoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 440)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmEstadoCuenta"
        Me.Text = "Estado de Cuenta"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.vpReportInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents crvEstadoCuenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EstadoCuentaContrato1 As Lotizador.UI.EstadoCuentaContrato
    Friend WithEvents GalleryControlGallery1 As DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lueCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLote As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueProyecto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents vpReportInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents sbVerReporte As DevExpress.XtraEditors.SimpleButton
End Class
