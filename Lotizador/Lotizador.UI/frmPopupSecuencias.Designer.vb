<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupSecuencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupSecuencias))
        Me.vpSecuencias = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.bmPopupAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lueProyecto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueTipoDocumento = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.teSerie = New DevExpress.XtraEditors.TextEdit()
        Me.teNumeroInicial = New DevExpress.XtraEditors.TextEdit()
        Me.teNumeroFinal = New DevExpress.XtraEditors.TextEdit()
        Me.teUltimoNumero = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.ToggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.vpSecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUltimoNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpSecuencias
        '
        Me.vpSecuencias.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'imBarraAcciones16x16
        '
        Me.imBarraAcciones16x16.ImageStream = CType(resources.GetObject("imBarraAcciones16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imBarraAcciones16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.imBarraAcciones16x16.Images.SetKeyName(0, "ic_save.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(1, "ic_edit.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(2, "ic_new.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(3, "ic_copy.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(4, "ic_delete2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(5, "ic_print.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(6, "ic_search2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(7, "ic_search3.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(8, "ic_undo.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(9, "ic_close.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(10, "ic_save.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(11, "ic_search2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(12, "ic_print.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(13, "ic_search3.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(14, "ic_mntTablas16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(15, "ic_first16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(16, "ic_previus16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(17, "ic_next16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(18, "ic_last16x16.png")
        '
        'bmPopupAcciones
        '
        Me.bmPopupAcciones.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.brBarraAcciones})
        Me.bmPopupAcciones.DockControls.Add(Me.BarDockControl1)
        Me.bmPopupAcciones.DockControls.Add(Me.BarDockControl2)
        Me.bmPopupAcciones.DockControls.Add(Me.BarDockControl3)
        Me.bmPopupAcciones.DockControls.Add(Me.BarDockControl4)
        Me.bmPopupAcciones.Form = Me
        Me.bmPopupAcciones.Images = Me.imBarraAcciones16x16
        Me.bmPopupAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiGrabar, Me.bbiCerrar})
        Me.bmPopupAcciones.MaxItemId = 5
        Me.bmPopupAcciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiGrabar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiGrabar
        '
        Me.bbiGrabar.Caption = "Grabar"
        Me.bbiGrabar.Id = 35
        Me.bbiGrabar.ImageOptions.Image = CType(resources.GetObject("bbiGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGrabar.ImageOptions.ImageIndex = 0
        Me.bbiGrabar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.bbiGrabar.Name = "bbiGrabar"
        '
        'bbiCerrar
        '
        Me.bbiCerrar.Caption = "Cerrar"
        Me.bbiCerrar.Id = 41
        Me.bbiCerrar.ImageOptions.Image = CType(resources.GetObject("bbiCerrar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCerrar.ImageOptions.ImageIndex = 9
        Me.bbiCerrar.ImageOptions.LargeImageIndex = 0
        Me.bbiCerrar.Name = "bbiCerrar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmPopupAcciones
        Me.BarDockControl1.Size = New System.Drawing.Size(354, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 262)
        Me.BarDockControl2.Manager = Me.bmPopupAcciones
        Me.BarDockControl2.Size = New System.Drawing.Size(354, 29)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.bmPopupAcciones
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 215)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(354, 47)
        Me.BarDockControl4.Manager = Me.bmPopupAcciones
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 215)
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(21, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Proyecto"
        '
        'lueProyecto
        '
        Me.lueProyecto.Location = New System.Drawing.Point(118, 64)
        Me.lueProyecto.Name = "lueProyecto"
        Me.lueProyecto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProyecto.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdProyecto", "IdProyecto", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueProyecto.Properties.NullText = "Seleccione"
        Me.lueProyecto.Size = New System.Drawing.Size(210, 20)
        Me.lueProyecto.TabIndex = 0
        '
        'lueTipoDocumento
        '
        Me.lueTipoDocumento.Location = New System.Drawing.Point(118, 90)
        Me.lueTipoDocumento.Name = "lueTipoDocumento"
        Me.lueTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoDocumento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTipoDocumento", "Id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoDocumento", "Codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.lueTipoDocumento.Properties.NullText = "Seleccione"
        Me.lueTipoDocumento.Size = New System.Drawing.Size(145, 20)
        Me.lueTipoDocumento.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(21, 93)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Tipo Documento"
        '
        'teSerie
        '
        Me.teSerie.Location = New System.Drawing.Point(118, 117)
        Me.teSerie.MenuManager = Me.bmPopupAcciones
        Me.teSerie.Name = "teSerie"
        Me.teSerie.Size = New System.Drawing.Size(55, 20)
        Me.teSerie.TabIndex = 2
        '
        'teNumeroInicial
        '
        Me.teNumeroInicial.Location = New System.Drawing.Point(118, 143)
        Me.teNumeroInicial.Name = "teNumeroInicial"
        Me.teNumeroInicial.Size = New System.Drawing.Size(93, 20)
        Me.teNumeroInicial.TabIndex = 3
        '
        'teNumeroFinal
        '
        Me.teNumeroFinal.Location = New System.Drawing.Point(118, 169)
        Me.teNumeroFinal.Name = "teNumeroFinal"
        Me.teNumeroFinal.Size = New System.Drawing.Size(93, 20)
        Me.teNumeroFinal.TabIndex = 4
        '
        'teUltimoNumero
        '
        Me.teUltimoNumero.Location = New System.Drawing.Point(118, 195)
        Me.teUltimoNumero.Name = "teUltimoNumero"
        Me.teUltimoNumero.Size = New System.Drawing.Size(93, 20)
        Me.teUltimoNumero.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 120)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 24
        Me.LabelControl1.Text = "Serie"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 146)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Número Inicial"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(21, 172)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Número Final"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(21, 198)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 24
        Me.LabelControl5.Text = "Último Número"
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.EditValue = "A"
        Me.ToggleSwitch1.Location = New System.Drawing.Point(118, 222)
        Me.ToggleSwitch1.MenuManager = Me.bmPopupAcciones
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Properties.OffText = "Inactivo"
        Me.ToggleSwitch1.Properties.OnText = "Activo"
        Me.ToggleSwitch1.Properties.ValueOff = "I"
        Me.ToggleSwitch1.Properties.ValueOn = "A"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(145, 24)
        Me.ToggleSwitch1.TabIndex = 29
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(21, 227)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 24
        Me.LabelControl7.Text = "Estado"
        '
        'frmPopupSecuencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 291)
        Me.Controls.Add(Me.ToggleSwitch1)
        Me.Controls.Add(Me.teUltimoNumero)
        Me.Controls.Add(Me.teNumeroFinal)
        Me.Controls.Add(Me.teNumeroInicial)
        Me.Controls.Add(Me.teSerie)
        Me.Controls.Add(Me.lueTipoDocumento)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lueProyecto)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPopupSecuencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.vpSecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUltimoNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vpSecuencias As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGrabar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueProyecto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueTipoDocumento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teUltimoNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumeroFinal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumeroInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ToggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
