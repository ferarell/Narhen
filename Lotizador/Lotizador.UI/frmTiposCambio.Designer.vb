<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTiposCambio))
        Me.bmAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar5 = New DevExpress.XtraBars.Bar()
        Me.brsDescripcion = New DevExpress.XtraBars.BarStaticItem()
        Me.barStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.barStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.brsEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.beiProceso = New DevExpress.XtraBars.BarEditItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDeshacer = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCopiar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrimero = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.gcTiposCambio = New DevExpress.XtraGrid.GridControl()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ucpUsuario = New Lotizador.UI.ucPanelAuditoria()
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTiposCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bmAcciones
        '
        Me.bmAcciones.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmAcciones.DockControls.Add(Me.barDockControlTop)
        Me.bmAcciones.DockControls.Add(Me.barDockControlBottom)
        Me.bmAcciones.DockControls.Add(Me.barDockControlLeft)
        Me.bmAcciones.DockControls.Add(Me.barDockControl1)
        Me.bmAcciones.Form = Me
        Me.bmAcciones.Images = Me.imBarraAcciones16x16
        Me.bmAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.barStaticItem3, Me.barStaticItem4, Me.brsEstado, Me.bbiNuevo, Me.bbiGrabar, Me.bbiCopiar, Me.bbiEliminar, Me.bbiImprimir, Me.bbiCerrar, Me.bbiPrimero, Me.bbiAnterior, Me.bbiSiguiente, Me.bbiUltimo, Me.beiProceso, Me.bbiEditar, Me.bbiDeshacer})
        Me.bmAcciones.MaxItemId = 3
        Me.bmAcciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso})
        '
        'bar5
        '
        Me.bar5.BarName = "Custom 3"
        Me.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar5.DockCol = 0
        Me.bar5.DockRow = 0
        Me.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.brsDescripcion), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.brsEstado), New DevExpress.XtraBars.LinkPersistInfo(Me.beiProceso)})
        Me.bar5.OptionsBar.AllowQuickCustomization = False
        Me.bar5.OptionsBar.DrawDragBorder = False
        Me.bar5.OptionsBar.MultiLine = True
        Me.bar5.OptionsBar.UseWholeRow = True
        Me.bar5.Text = "Custom 3"
        '
        'brsDescripcion
        '
        Me.brsDescripcion.Id = 30
        Me.brsDescripcion.Name = "brsDescripcion"
        '
        'barStaticItem3
        '
        Me.barStaticItem3.Caption = "0 / 0"
        Me.barStaticItem3.Id = 31
        Me.barStaticItem3.Name = "barStaticItem3"
        '
        'barStaticItem4
        '
        Me.barStaticItem4.Caption = "Estado"
        Me.barStaticItem4.Id = 46
        Me.barStaticItem4.Name = "barStaticItem4"
        '
        'brsEstado
        '
        Me.brsEstado.Caption = "Lectura"
        Me.brsEstado.Id = 47
        Me.brsEstado.Name = "brsEstado"
        '
        'beiProceso
        '
        Me.beiProceso.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.beiProceso.Edit = Me.rpiProceso
        Me.beiProceso.EditWidth = 150
        Me.beiProceso.Id = 0
        Me.beiProceso.Name = "beiProceso"
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiEditar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiEliminar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiDeshacer, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiGrabar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCopiar, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiImprimir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrimero, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnterior), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSiguiente), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUltimo)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiNuevo
        '
        Me.bbiNuevo.Caption = "Nuevo"
        Me.bbiNuevo.Id = 33
        Me.bbiNuevo.ImageOptions.Image = CType(resources.GetObject("bbiNuevo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiNuevo.ImageOptions.ImageIndex = 2
        Me.bbiNuevo.ImageOptions.LargeImageIndex = 7
        Me.bbiNuevo.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.bbiNuevo.Name = "bbiNuevo"
        '
        'bbiDeshacer
        '
        Me.bbiDeshacer.Caption = "Deshacer"
        Me.bbiDeshacer.Id = 2
        Me.bbiDeshacer.ImageOptions.Image = CType(resources.GetObject("bbiDeshacer.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiDeshacer.ImageOptions.ImageIndex = 8
        Me.bbiDeshacer.ImageOptions.LargeImageIndex = 2
        Me.bbiDeshacer.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.bbiDeshacer.Name = "bbiDeshacer"
        Me.bbiDeshacer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiEditar
        '
        Me.bbiEditar.Caption = "Editar"
        Me.bbiEditar.Id = 1
        Me.bbiEditar.ImageOptions.Image = CType(resources.GetObject("bbiEditar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEditar.ImageOptions.ImageIndex = 1
        Me.bbiEditar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.bbiEditar.Name = "bbiEditar"
        '
        'bbiGrabar
        '
        Me.bbiGrabar.Caption = "Grabar"
        Me.bbiGrabar.Id = 35
        Me.bbiGrabar.ImageOptions.Image = CType(resources.GetObject("bbiGrabar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiGrabar.ImageOptions.ImageIndex = 0
        Me.bbiGrabar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.bbiGrabar.Name = "bbiGrabar"
        Me.bbiGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiCopiar
        '
        Me.bbiCopiar.Caption = "Copiar"
        Me.bbiCopiar.Id = 36
        Me.bbiCopiar.ImageOptions.Image = CType(resources.GetObject("bbiCopiar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiCopiar.ImageOptions.ImageIndex = 3
        Me.bbiCopiar.ImageOptions.LargeImageIndex = 4
        Me.bbiCopiar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C))
        Me.bbiCopiar.Name = "bbiCopiar"
        Me.bbiCopiar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiEliminar
        '
        Me.bbiEliminar.Caption = "Eliminar"
        Me.bbiEliminar.Id = 37
        Me.bbiEliminar.ImageOptions.Image = CType(resources.GetObject("bbiEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEliminar.ImageOptions.ImageIndex = 4
        Me.bbiEliminar.ImageOptions.LargeImageIndex = 5
        Me.bbiEliminar.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete)
        Me.bbiEliminar.Name = "bbiEliminar"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 38
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.ImageOptions.ImageIndex = 5
        Me.bbiImprimir.ImageOptions.LargeImageIndex = 8
        Me.bbiImprimir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.bbiImprimir.Name = "bbiImprimir"
        Me.bbiImprimir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'bbiPrimero
        '
        Me.bbiPrimero.Caption = "<<"
        Me.bbiPrimero.Id = 42
        Me.bbiPrimero.ImageOptions.ImageIndex = 15
        Me.bbiPrimero.ImageOptions.LargeImageIndex = 10
        Me.bbiPrimero.Name = "bbiPrimero"
        '
        'bbiAnterior
        '
        Me.bbiAnterior.Caption = "<"
        Me.bbiAnterior.Id = 43
        Me.bbiAnterior.ImageOptions.ImageIndex = 16
        Me.bbiAnterior.ImageOptions.LargeImageIndex = 12
        Me.bbiAnterior.Name = "bbiAnterior"
        '
        'bbiSiguiente
        '
        Me.bbiSiguiente.Caption = ">"
        Me.bbiSiguiente.Id = 45
        Me.bbiSiguiente.ImageOptions.ImageIndex = 17
        Me.bbiSiguiente.ImageOptions.LargeImageIndex = 13
        Me.bbiSiguiente.Name = "bbiSiguiente"
        '
        'bbiUltimo
        '
        Me.bbiUltimo.Caption = ">>"
        Me.bbiUltimo.Id = 44
        Me.bbiUltimo.ImageOptions.ImageIndex = 18
        Me.bbiUltimo.ImageOptions.LargeImageIndex = 11
        Me.bbiUltimo.Name = "bbiUltimo"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.bmAcciones
        Me.barDockControlTop.Size = New System.Drawing.Size(868, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 235)
        Me.barDockControlBottom.Manager = Me.bmAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(868, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 188)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(868, 47)
        Me.barDockControl1.Manager = Me.bmAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 188)
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
        'gcTiposCambio
        '
        Me.gcTiposCambio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcTiposCambio.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcTiposCambio.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcTiposCambio.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcTiposCambio.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcTiposCambio.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcTiposCambio.Location = New System.Drawing.Point(0, 47)
        Me.gcTiposCambio.MainView = Me.CardView1
        Me.gcTiposCambio.Name = "gcTiposCambio"
        Me.gcTiposCambio.Size = New System.Drawing.Size(868, 151)
        Me.gcTiposCambio.TabIndex = 170
        Me.gcTiposCambio.UseEmbeddedNavigator = True
        Me.gcTiposCambio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1, Me.GridView1})
        '
        'CardView1
        '
        Me.CardView1.CardInterval = 32
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn3, Me.GridColumn4, Me.GridColumn6, Me.GridColumn7})
        Me.CardView1.GridControl = Me.gcTiposCambio
        Me.CardView1.MaximumCardRows = 4
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsFind.AlwaysVisible = True
        Me.CardView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "ID Moneda"
        Me.GridColumn8.FieldName = "IdMoneda"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Moneda"
        Me.GridColumn3.FieldName = "CodigoMoneda"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha Referencia"
        Me.GridColumn4.FieldName = "FechaReferencia"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn6.Caption = "TC Local"
        Me.GridColumn6.DisplayFormat.FormatString = "###,##0.00"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn6.FieldName = "TcLocalV"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn7.Caption = "TC Dólar"
        Me.GridColumn7.DisplayFormat.FormatString = "###,##0.00"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn7.FieldName = "TcDolarV"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn5})
        Me.GridView1.GridControl = Me.gcTiposCambio
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "CodigoMoneda"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Texto Impresión"
        Me.GridColumn5.FieldName = "TextoImpresion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        '
        'ucpUsuario
        '
        Me.ucpUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpUsuario.FechaCreacion = New Date(CType(0, Long))
        Me.ucpUsuario.FechaModificacion = New Date(CType(0, Long))
        Me.ucpUsuario.Location = New System.Drawing.Point(0, 198)
        Me.ucpUsuario.Name = "ucpUsuario"
        Me.ucpUsuario.Size = New System.Drawing.Size(868, 37)
        Me.ucpUsuario.TabIndex = 180
        Me.ucpUsuario.UsuarioCreacion = Nothing
        Me.ucpUsuario.UsuarioModificacion = Nothing
        '
        'frmTiposCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 264)
        Me.Controls.Add(Me.gcTiposCambio)
        Me.Controls.Add(Me.ucpUsuario)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTiposCambio"
        Me.Text = "Tipos de Cambio"
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTiposCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bmAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents bar5 As DevExpress.XtraBars.Bar
    Private WithEvents brsDescripcion As DevExpress.XtraBars.BarStaticItem
    Private WithEvents barStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents barStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents brsEstado As DevExpress.XtraBars.BarStaticItem
    Private WithEvents beiProceso As DevExpress.XtraBars.BarEditItem
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiNuevo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiDeshacer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiEditar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiGrabar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCopiar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiEliminar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiPrimero As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiAnterior As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSiguiente As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiUltimo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Friend WithEvents gcTiposCambio As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ucpUsuario As Lotizador.UI.ucPanelAuditoria
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
End Class
