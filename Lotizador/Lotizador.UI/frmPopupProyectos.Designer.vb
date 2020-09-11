<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupProyectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupProyectos))
        Me.vpProyectos = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.teDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.teCantidadLotes = New DevExpress.XtraEditors.TextEdit()
        Me.lueBanco = New DevExpress.XtraEditors.LookUpEdit()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.teCodigoInterbancario = New DevExpress.XtraEditors.TextEdit()
        Me.teCuentaCorriente = New DevExpress.XtraEditors.TextEdit()
        Me.teImporteMora = New DevExpress.XtraEditors.TextEdit()
        Me.teArchivoPlantilla = New DevExpress.XtraEditors.TextEdit()
        Me.lueMoneda = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lueDistrito = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueProvincia = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueDepartamento = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.vpProyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCantidadLotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teCodigoInterbancario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuentaCorriente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teImporteMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teArchivoPlantilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.lueDistrito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vpProyectos
        '
        Me.vpProyectos.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'teDescripcion
        '
        Me.teDescripcion.Location = New System.Drawing.Point(139, 35)
        Me.teDescripcion.Name = "teDescripcion"
        Me.teDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teDescripcion.Size = New System.Drawing.Size(210, 20)
        Me.teDescripcion.TabIndex = 0
        '
        'teCantidadLotes
        '
        Me.teCantidadLotes.Location = New System.Drawing.Point(139, 63)
        Me.teCantidadLotes.Name = "teCantidadLotes"
        Me.teCantidadLotes.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCantidadLotes.Properties.Mask.EditMask = "n0"
        Me.teCantidadLotes.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCantidadLotes.Size = New System.Drawing.Size(82, 20)
        Me.teCantidadLotes.TabIndex = 1
        '
        'lueBanco
        '
        Me.lueBanco.Location = New System.Drawing.Point(139, 91)
        Me.lueBanco.Name = "lueBanco"
        Me.lueBanco.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueBanco.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoBanco", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdBanco", "IdBanco", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueBanco.Properties.NullText = "Seleccione"
        Me.lueBanco.Size = New System.Drawing.Size(210, 20)
        Me.lueBanco.TabIndex = 2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(380, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 439)
        Me.barDockControlBottom.Manager = Me.bmPopupAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(380, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmPopupAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 392)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(380, 47)
        Me.barDockControl1.Manager = Me.bmPopupAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 392)
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.teCodigoInterbancario)
        Me.GroupControl1.Controls.Add(Me.teCuentaCorriente)
        Me.GroupControl1.Controls.Add(Me.teImporteMora)
        Me.GroupControl1.Controls.Add(Me.teCantidadLotes)
        Me.GroupControl1.Controls.Add(Me.teArchivoPlantilla)
        Me.GroupControl1.Controls.Add(Me.teDescripcion)
        Me.GroupControl1.Controls.Add(Me.lueBanco)
        Me.GroupControl1.Controls.Add(Me.lueMoneda)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(380, 266)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "General"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(28, 94)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Banco"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 206)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Moneda"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(28, 66)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Cantidad de Lotes"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(28, 150)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Código Interbancario"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(28, 122)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Cuenta Corriente"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(28, 234)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Importe Mora"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(28, 178)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Archivo Plantilla"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(28, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Nombre Proyecto"
        '
        'teCodigoInterbancario
        '
        Me.teCodigoInterbancario.Location = New System.Drawing.Point(139, 147)
        Me.teCodigoInterbancario.Name = "teCodigoInterbancario"
        Me.teCodigoInterbancario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCodigoInterbancario.Properties.Mask.EditMask = "!!!"
        Me.teCodigoInterbancario.Size = New System.Drawing.Size(210, 20)
        Me.teCodigoInterbancario.TabIndex = 4
        '
        'teCuentaCorriente
        '
        Me.teCuentaCorriente.Location = New System.Drawing.Point(139, 119)
        Me.teCuentaCorriente.Name = "teCuentaCorriente"
        Me.teCuentaCorriente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teCuentaCorriente.Properties.Mask.EditMask = "!!!"
        Me.teCuentaCorriente.Size = New System.Drawing.Size(210, 20)
        Me.teCuentaCorriente.TabIndex = 3
        '
        'teImporteMora
        '
        Me.teImporteMora.EditValue = "0.00"
        Me.teImporteMora.Location = New System.Drawing.Point(139, 231)
        Me.teImporteMora.Name = "teImporteMora"
        Me.teImporteMora.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teImporteMora.Properties.Mask.EditMask = "n"
        Me.teImporteMora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teImporteMora.Size = New System.Drawing.Size(82, 20)
        Me.teImporteMora.TabIndex = 7
        '
        'teArchivoPlantilla
        '
        Me.teArchivoPlantilla.Location = New System.Drawing.Point(139, 175)
        Me.teArchivoPlantilla.Name = "teArchivoPlantilla"
        Me.teArchivoPlantilla.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teArchivoPlantilla.Size = New System.Drawing.Size(210, 20)
        Me.teArchivoPlantilla.TabIndex = 5
        '
        'lueMoneda
        '
        Me.lueMoneda.Location = New System.Drawing.Point(139, 203)
        Me.lueMoneda.Name = "lueMoneda"
        Me.lueMoneda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueMoneda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoMoneda", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdMoneda", "IdMoneda", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueMoneda.Properties.NullText = "Seleccione"
        Me.lueMoneda.Size = New System.Drawing.Size(210, 20)
        Me.lueMoneda.TabIndex = 6
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lueDistrito)
        Me.GroupControl3.Controls.Add(Me.lueProvincia)
        Me.GroupControl3.Controls.Add(Me.lueDepartamento)
        Me.GroupControl3.Controls.Add(Me.LabelControl18)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.LabelControl15)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 316)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(380, 123)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Ubicación"
        '
        'lueDistrito
        '
        Me.lueDistrito.Location = New System.Drawing.Point(139, 87)
        Me.lueDistrito.Name = "lueDistrito"
        Me.lueDistrito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDistrito.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdDistrito", "IdDistrito", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreDistrito", "Distrito"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdUbigeo", "IdUbigeo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueDistrito.Properties.NullText = "Seleccione"
        Me.lueDistrito.Size = New System.Drawing.Size(210, 20)
        Me.lueDistrito.TabIndex = 2
        '
        'lueProvincia
        '
        Me.lueProvincia.Location = New System.Drawing.Point(139, 61)
        Me.lueProvincia.Name = "lueProvincia"
        Me.lueProvincia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProvincia.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdProvincia", "IdProvincia", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreProvincia", "Provincia")})
        Me.lueProvincia.Properties.NullText = "Seleccione"
        Me.lueProvincia.Size = New System.Drawing.Size(210, 20)
        Me.lueProvincia.TabIndex = 1
        '
        'lueDepartamento
        '
        Me.lueDepartamento.Location = New System.Drawing.Point(139, 35)
        Me.lueDepartamento.Name = "lueDepartamento"
        Me.lueDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueDepartamento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdDepartamento", "IdDepartamento", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreDepartamento", "Departamento")})
        Me.lueDepartamento.Properties.NullText = "Seleccione"
        Me.lueDepartamento.Size = New System.Drawing.Size(210, 20)
        Me.lueDepartamento.TabIndex = 0
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(29, 89)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl18.TabIndex = 76
        Me.LabelControl18.Text = "Distrito"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(29, 64)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl17.TabIndex = 74
        Me.LabelControl17.Text = "Provincia"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(28, 38)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl15.TabIndex = 44
        Me.LabelControl15.Text = "Departamento"
        '
        'frmPopupProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 468)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPopupProyectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.vpProyectos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCantidadLotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueBanco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teCodigoInterbancario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuentaCorriente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teImporteMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teArchivoPlantilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueMoneda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.lueDistrito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vpProyectos As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiGrabar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCantidadLotes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueBanco As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueMoneda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lueDistrito As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueProvincia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCuentaCorriente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teImporteMora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCodigoInterbancario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teArchivoPlantilla As DevExpress.XtraEditors.TextEdit
End Class
