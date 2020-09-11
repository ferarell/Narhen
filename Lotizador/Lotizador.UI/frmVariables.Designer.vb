<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVariables))
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcListaTablas = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcNombreTabla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.gcDetalleTabla = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.riEstado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcUsuarioRedUC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechaCreacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuarioRedUA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechaActualizacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ucpUsuario = New Lotizador.UI.ucPanelAuditoria()
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcListaTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.gcDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarDockControl1.Size = New System.Drawing.Size(963, 47)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 371)
        Me.BarDockControl2.Manager = Me.bmAcciones
        Me.BarDockControl2.Size = New System.Drawing.Size(963, 29)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl3.Manager = Me.bmAcciones
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 324)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(963, 47)
        Me.BarDockControl4.Manager = Me.bmAcciones
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 324)
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
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(963, 287)
        Me.SplitContainerControl1.SplitterPosition = 360
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.gcListaTablas)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(360, 287)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Tablas"
        '
        'gcListaTablas
        '
        Me.gcListaTablas.CausesValidation = False
        Me.gcListaTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gcListaTablas.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcListaTablas.Location = New System.Drawing.Point(2, 20)
        Me.gcListaTablas.MainView = Me.GridView1
        Me.gcListaTablas.Name = "gcListaTablas"
        Me.gcListaTablas.Size = New System.Drawing.Size(356, 265)
        Me.gcListaTablas.TabIndex = 2
        Me.gcListaTablas.UseEmbeddedNavigator = True
        Me.gcListaTablas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNombreTabla})
        Me.GridView1.GridControl = Me.gcListaTablas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gcNombreTabla
        '
        Me.gcNombreTabla.Caption = "Nombre"
        Me.gcNombreTabla.FieldName = "nombre"
        Me.gcNombreTabla.Name = "gcNombreTabla"
        Me.gcNombreTabla.Visible = True
        Me.gcNombreTabla.VisibleIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.gcDetalleTabla)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(598, 287)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Detalle"
        '
        'gcDetalleTabla
        '
        Me.gcDetalleTabla.CausesValidation = False
        Me.gcDetalleTabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gcDetalleTabla.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcDetalleTabla.Location = New System.Drawing.Point(2, 20)
        Me.gcDetalleTabla.MainView = Me.GridView2
        Me.gcDetalleTabla.Name = "gcDetalleTabla"
        Me.gcDetalleTabla.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riEstado})
        Me.gcDetalleTabla.Size = New System.Drawing.Size(594, 265)
        Me.gcDetalleTabla.TabIndex = 3
        Me.gcDetalleTabla.UseEmbeddedNavigator = True
        Me.gcDetalleTabla.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDescripcion, Me.gcCodigo, Me.gcValor, Me.gcActivo, Me.gcUsuarioRedUC1, Me.gcFechaCreacion1, Me.gcUsuarioRedUA1, Me.gcFechaActualizacion1, Me.gcNombre})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.gcDetalleTabla
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'gcDescripcion
        '
        Me.gcDescripcion.Caption = "Descripcion"
        Me.gcDescripcion.FieldName = "Descripcion"
        Me.gcDescripcion.Name = "gcDescripcion"
        Me.gcDescripcion.Visible = True
        Me.gcDescripcion.VisibleIndex = 0
        '
        'gcCodigo
        '
        Me.gcCodigo.Caption = "Codigo"
        Me.gcCodigo.FieldName = "Codigo"
        Me.gcCodigo.Name = "gcCodigo"
        Me.gcCodigo.Visible = True
        Me.gcCodigo.VisibleIndex = 1
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 2
        '
        'gcActivo
        '
        Me.gcActivo.Caption = "Activo"
        Me.gcActivo.ColumnEdit = Me.riEstado
        Me.gcActivo.FieldName = "Estado"
        Me.gcActivo.Name = "gcActivo"
        Me.gcActivo.Visible = True
        Me.gcActivo.VisibleIndex = 3
        '
        'riEstado
        '
        Me.riEstado.AutoHeight = False
        Me.riEstado.Name = "riEstado"
        Me.riEstado.ValueChecked = "A"
        Me.riEstado.ValueGrayed = ""
        Me.riEstado.ValueUnchecked = "V"
        '
        'gcUsuarioRedUC1
        '
        Me.gcUsuarioRedUC1.Caption = "UsuarioCreacion"
        Me.gcUsuarioRedUC1.FieldName = "UsuarioRedUC"
        Me.gcUsuarioRedUC1.Name = "gcUsuarioRedUC1"
        '
        'gcFechaCreacion1
        '
        Me.gcFechaCreacion1.Caption = "FechaCreacion"
        Me.gcFechaCreacion1.FieldName = "FechaCreacion"
        Me.gcFechaCreacion1.Name = "gcFechaCreacion1"
        '
        'gcUsuarioRedUA1
        '
        Me.gcUsuarioRedUA1.Caption = "UsuarioActualizacion"
        Me.gcUsuarioRedUA1.FieldName = "UsuarioRedUA"
        Me.gcUsuarioRedUA1.Name = "gcUsuarioRedUA1"
        '
        'gcFechaActualizacion1
        '
        Me.gcFechaActualizacion1.Caption = "FechaActualizacion"
        Me.gcFechaActualizacion1.FieldName = "FechActualizacion"
        Me.gcFechaActualizacion1.Name = "gcFechaActualizacion1"
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Nombre"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        '
        'ucpUsuario
        '
        Me.ucpUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpUsuario.FechaCreacion = New Date(CType(0, Long))
        Me.ucpUsuario.FechaModificacion = New Date(CType(0, Long))
        Me.ucpUsuario.Location = New System.Drawing.Point(0, 334)
        Me.ucpUsuario.Name = "ucpUsuario"
        Me.ucpUsuario.Size = New System.Drawing.Size(963, 37)
        Me.ucpUsuario.TabIndex = 180
        Me.ucpUsuario.UsuarioCreacion = Nothing
        Me.ucpUsuario.UsuarioModificacion = Nothing
        '
        'frmVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 400)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ucpUsuario)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVariables"
        Me.Text = "Variables"
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcListaTablas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.gcDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
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
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents gcListaTablas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Private WithEvents gcDetalleTabla As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gcDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcActivo As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents riEstado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents gcUsuarioRedUC1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcFechaCreacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcUsuarioRedUA1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcFechaActualizacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcNombreTabla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ucpUsuario As Lotizador.UI.ucPanelAuditoria
End Class
