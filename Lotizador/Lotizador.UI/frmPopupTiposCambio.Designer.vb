<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupTiposCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupTiposCambio))
        Me.vpTiposCambio = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTcDolar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTcLocal = New DevExpress.XtraEditors.TextEdit()
        Me.deFechaReferencia = New DevExpress.XtraEditors.DateEdit()
        Me.Inicial = New DevExpress.XtraEditors.LabelControl()
        Me.lueMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.bmPopupAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.vpTiposCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTcDolar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTcLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaReferencia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpTiposCambio
        '
        Me.vpTiposCambio.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtTcDolar)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txtTcLocal)
        Me.GroupControl1.Controls.Add(Me.deFechaReferencia)
        Me.GroupControl1.Controls.Add(Me.Inicial)
        Me.GroupControl1.Controls.Add(Me.lueMoneda)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(305, 154)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(33, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl11.TabIndex = 57
        Me.LabelControl11.Text = "Fecha Referencia"
        '
        'txtTcDolar
        '
        Me.txtTcDolar.EditValue = "1.000"
        Me.txtTcDolar.Enabled = False
        Me.txtTcDolar.Location = New System.Drawing.Point(143, 116)
        Me.txtTcDolar.Name = "txtTcDolar"
        Me.txtTcDolar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTcDolar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTcDolar.Properties.DisplayFormat.FormatString = "0.000"
        Me.txtTcDolar.Properties.Mask.EditMask = "n2"
        Me.txtTcDolar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTcDolar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTcDolar.Size = New System.Drawing.Size(92, 20)
        Me.txtTcDolar.TabIndex = 3
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(33, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl9.TabIndex = 60
        Me.LabelControl9.Text = "TC Dolar (USD)"
        '
        'txtTcLocal
        '
        Me.txtTcLocal.EditValue = "0.000"
        Me.txtTcLocal.Location = New System.Drawing.Point(143, 90)
        Me.txtTcLocal.Name = "txtTcLocal"
        Me.txtTcLocal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.txtTcLocal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTcLocal.Properties.DisplayFormat.FormatString = "0.000"
        Me.txtTcLocal.Properties.Mask.EditMask = "n2"
        Me.txtTcLocal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTcLocal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTcLocal.Size = New System.Drawing.Size(92, 20)
        Me.txtTcLocal.TabIndex = 2
        '
        'deFechaReferencia
        '
        Me.deFechaReferencia.EditValue = Nothing
        Me.deFechaReferencia.Location = New System.Drawing.Point(143, 64)
        Me.deFechaReferencia.Name = "deFechaReferencia"
        Me.deFechaReferencia.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.deFechaReferencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaReferencia.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFechaReferencia.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deFechaReferencia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.deFechaReferencia.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.deFechaReferencia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.deFechaReferencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deFechaReferencia.Size = New System.Drawing.Size(119, 20)
        Me.deFechaReferencia.TabIndex = 1
        '
        'Inicial
        '
        Me.Inicial.Location = New System.Drawing.Point(33, 93)
        Me.Inicial.Name = "Inicial"
        Me.Inicial.Size = New System.Drawing.Size(70, 13)
        Me.Inicial.TabIndex = 59
        Me.Inicial.Text = "TC Local (PEN)"
        '
        'lueMoneda
        '
        Me.lueMoneda.Location = New System.Drawing.Point(142, 38)
        Me.lueMoneda.Name = "lueMoneda"
        Me.lueMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMoneda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdMoneda", "IdMoneda", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoMoneda", "CodigoMoneda"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.lueMoneda.Properties.NullText = "Seleccione"
        Me.lueMoneda.Size = New System.Drawing.Size(129, 20)
        Me.lueMoneda.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(33, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 58
        Me.LabelControl7.Text = "Moneda"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 30
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmPopupAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 154)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(305, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 201)
        Me.barDockControlBottom.Manager = Me.bmPopupAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(305, 29)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(305, 47)
        Me.barDockControl1.Manager = Me.bmPopupAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 154)
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
        'BarStaticItem2
        '
        Me.BarStaticItem2.Id = 30
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'frmPopupTiposCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 230)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPopupTiposCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.vpTiposCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTcDolar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTcLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaReferencia.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vpTiposCambio As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGrabar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTcDolar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTcLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deFechaReferencia As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Inicial As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
