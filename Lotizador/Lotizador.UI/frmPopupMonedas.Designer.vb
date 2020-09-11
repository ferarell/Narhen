<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupMonedas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupMonedas))
        Me.vpMonedas = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.bmPopupAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.teTextoImpresion = New DevExpress.XtraEditors.TextEdit()
        Me.teDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.teCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.vpMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teTextoImpresion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpMonedas
        '
        Me.vpMonedas.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
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
        'bar5
        '
        Me.bar5.BarName = "Custom 3"
        Me.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar5.DockCol = 0
        Me.bar5.DockRow = 0
        Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar5.OptionsBar.AllowQuickCustomization = False
        Me.bar5.OptionsBar.DrawDragBorder = False
        Me.bar5.OptionsBar.MultiLine = True
        Me.bar5.OptionsBar.UseWholeRow = True
        Me.bar5.Text = "Custom 3"
        '
        'bmPopupAcciones
        '
        Me.bmPopupAcciones.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.brBarraAcciones})
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlTop)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlBottom)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlLeft)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControl1)
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.bmPopupAcciones
        Me.barDockControlTop.Size = New System.Drawing.Size(358, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 168)
        Me.barDockControlBottom.Manager = Me.bmPopupAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(358, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmPopupAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 121)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(358, 47)
        Me.barDockControl1.Manager = Me.bmPopupAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 121)
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.teTextoImpresion)
        Me.GroupControl1.Controls.Add(Me.teDescripcion)
        Me.GroupControl1.Controls.Add(Me.teCodigo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(358, 121)
        Me.GroupControl1.TabIndex = 19
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 88)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Texto Impresión"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(27, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Descripción"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Código"
        '
        'teTextoImpresion
        '
        Me.teTextoImpresion.Location = New System.Drawing.Point(124, 85)
        Me.teTextoImpresion.Name = "teTextoImpresion"
        Me.teTextoImpresion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teTextoImpresion.Size = New System.Drawing.Size(204, 20)
        Me.teTextoImpresion.TabIndex = 12
        '
        'teDescripcion
        '
        Me.teDescripcion.Location = New System.Drawing.Point(124, 59)
        Me.teDescripcion.Name = "teDescripcion"
        Me.teDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teDescripcion.Size = New System.Drawing.Size(204, 20)
        Me.teDescripcion.TabIndex = 12
        '
        'teCodigo
        '
        Me.teCodigo.Location = New System.Drawing.Point(124, 32)
        Me.teCodigo.Name = "teCodigo"
        Me.teCodigo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCodigo.Properties.Mask.EditMask = "!!!"
        Me.teCodigo.Size = New System.Drawing.Size(39, 20)
        Me.teCodigo.TabIndex = 11
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 30
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 30
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'frmPopupMonedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 197)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPopupMonedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.vpMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teTextoImpresion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vpMonedas As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGrabar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teCodigo As DevExpress.XtraEditors.TextEdit
    Private WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTextoImpresion As DevExpress.XtraEditors.TextEdit
End Class
