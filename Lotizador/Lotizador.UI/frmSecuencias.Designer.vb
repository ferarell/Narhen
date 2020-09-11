<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecuencias
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSecuencias))
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.gcSecuencias = New DevExpress.XtraGrid.GridControl()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
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
        Me.bsiVistas = New DevExpress.XtraBars.BarSubItem()
        Me.bbiVistaGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTarjeta = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrimero = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ucpUsuario = New Lotizador.UI.ucPanelAuditoria()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardView1
        '
        Me.CardView1.GridControl = Me.gcSecuencias
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsBehavior.Editable = False
        Me.CardView1.OptionsFind.AlwaysVisible = True
        Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'gcSecuencias
        '
        Me.gcSecuencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSecuencias.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcSecuencias.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcSecuencias.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcSecuencias.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcSecuencias.EmbeddedNavigator.Buttons.ImageList = Me.imBarraAcciones16x16
        Me.gcSecuencias.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcSecuencias.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(0, 19, "Exportar a Excel")})
        GridLevelNode2.LevelTemplate = Me.CardView1
        GridLevelNode2.RelationName = "Level1"
        Me.gcSecuencias.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gcSecuencias.Location = New System.Drawing.Point(0, 47)
        Me.gcSecuencias.MainView = Me.GridView1
        Me.gcSecuencias.Name = "gcSecuencias"
        Me.gcSecuencias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.gcSecuencias.Size = New System.Drawing.Size(900, 262)
        Me.gcSecuencias.TabIndex = 165
        Me.gcSecuencias.UseEmbeddedNavigator = True
        Me.gcSecuencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.CardView1})
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
        Me.imBarraAcciones16x16.Images.SetKeyName(19, "ic_excel16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(20, "ci_views16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(21, "ic_cardview16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(22, "ic_carouselview16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(23, "ic_gridview16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(24, "Excel.ico")
        Me.imBarraAcciones16x16.Images.SetKeyName(25, "previmg.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(26, "Run.ico")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.gcSecuencias
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Proyecto"
        Me.GridColumn1.FieldName = "Proyecto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo de Documento"
        Me.GridColumn2.FieldName = "TipoDocumento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Serie"
        Me.GridColumn3.FieldName = "SerieDocumento"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Número Inicial"
        Me.GridColumn4.FieldName = "NumeroDocumentoInicial"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Número Final"
        Me.GridColumn5.FieldName = "NumeroDocumentoFinal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Último Número"
        Me.GridColumn6.FieldName = "NumeroDocumentoCorriente"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Activo"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn7.FieldName = "Estado"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "A"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "C"
        '
        'bmAcciones
        '
        Me.bmAcciones.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar5, Me.brBarraAcciones})
        Me.bmAcciones.DockControls.Add(Me.BarDockControl1)
        Me.bmAcciones.DockControls.Add(Me.BarDockControl2)
        Me.bmAcciones.DockControls.Add(Me.BarDockControl3)
        Me.bmAcciones.DockControls.Add(Me.BarDockControl4)
        Me.bmAcciones.Form = Me
        Me.bmAcciones.Images = Me.imBarraAcciones16x16
        Me.bmAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.barStaticItem3, Me.barStaticItem4, Me.brsEstado, Me.bbiNuevo, Me.bbiGrabar, Me.bbiCopiar, Me.bbiEliminar, Me.bbiImprimir, Me.bbiCerrar, Me.bbiPrimero, Me.bbiAnterior, Me.bbiSiguiente, Me.bbiUltimo, Me.beiProceso, Me.bbiEditar, Me.bbiDeshacer, Me.BarButtonItem1, Me.bsiVistas, Me.bbiVistaGrilla, Me.bbiTarjeta})
        Me.bmAcciones.MaxItemId = 10
        Me.bmAcciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemImageComboBox1})
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
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiEditar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiEliminar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiDeshacer, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiGrabar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCopiar, "", True, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiImprimir, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bsiVistas, "", False, True, False, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiPrimero, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiAnterior), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiSiguiente), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiUltimo)})
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
        'bsiVistas
        '
        Me.bsiVistas.Caption = "Vistas"
        Me.bsiVistas.Id = 6
        Me.bsiVistas.ImageOptions.ImageIndex = 20
        Me.bsiVistas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiVistaGrilla), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiTarjeta)})
        Me.bsiVistas.Name = "bsiVistas"
        Me.bsiVistas.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bbiVistaGrilla
        '
        Me.bbiVistaGrilla.Caption = "Grilla"
        Me.bbiVistaGrilla.Id = 7
        Me.bbiVistaGrilla.ImageOptions.ImageIndex = 23
        Me.bbiVistaGrilla.Name = "bbiVistaGrilla"
        '
        'bbiTarjeta
        '
        Me.bbiTarjeta.Caption = "Tarjeta"
        Me.bbiTarjeta.Id = 8
        Me.bbiTarjeta.ImageOptions.ImageIndex = 21
        Me.bbiTarjeta.Name = "bbiTarjeta"
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
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.bmAcciones
        Me.BarDockControl1.Size = New System.Drawing.Size(900, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 346)
        Me.BarDockControl2.Manager = Me.bmAcciones
        Me.BarDockControl2.Size = New System.Drawing.Size(900, 29)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.bmAcciones
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 299)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(900, 47)
        Me.BarDockControl4.Manager = Me.bmAcciones
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 299)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Vista"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'ucpUsuario
        '
        Me.ucpUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpUsuario.FechaCreacion = New Date(CType(0, Long))
        Me.ucpUsuario.FechaModificacion = New Date(CType(0, Long))
        Me.ucpUsuario.Location = New System.Drawing.Point(0, 309)
        Me.ucpUsuario.Name = "ucpUsuario"
        Me.ucpUsuario.Size = New System.Drawing.Size(900, 37)
        Me.ucpUsuario.TabIndex = 180
        Me.ucpUsuario.UsuarioCreacion = Nothing
        Me.ucpUsuario.UsuarioModificacion = Nothing
        '
        'frmSecuencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 375)
        Me.Controls.Add(Me.gcSecuencias)
        Me.Controls.Add(Me.ucpUsuario)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSecuencias"
        Me.Text = "Secuencias"
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bsiVistas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bbiVistaGrilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiTarjeta As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiPrimero As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiAnterior As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiSiguiente As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiUltimo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents gcSecuencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ucpUsuario As Lotizador.UI.ucPanelAuditoria
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
End Class
