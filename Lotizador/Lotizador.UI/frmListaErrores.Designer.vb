<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaErrores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaErrores))
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
        Me.bbiAtender = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiVistaGrilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiTarjeta = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.gcEventos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gcSeleccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcTipoEvento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.gcNombreError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDescripcionError = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuarioRed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNombreObjeto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechaHora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcAtendido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ceAtendido = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gcUsuarioCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcUsuarioActualizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcFechActualizacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ucpUsuario = New Lotizador.UI.ucPanelAuditoria()
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bmAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.brsDescripcion, Me.barStaticItem3, Me.barStaticItem4, Me.brsEstado, Me.bbiCerrar, Me.beiProceso, Me.BarButtonItem1, Me.bbiVistaGrilla, Me.bbiTarjeta, Me.bbiAtender})
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
        Me.brsDescripcion.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barStaticItem3
        '
        Me.barStaticItem3.Caption = "0 / 0"
        Me.barStaticItem3.Id = 31
        Me.barStaticItem3.Name = "barStaticItem3"
        Me.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barStaticItem4
        '
        Me.barStaticItem4.Caption = "Estado"
        Me.barStaticItem4.Id = 46
        Me.barStaticItem4.Name = "barStaticItem4"
        Me.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'brsEstado
        '
        Me.brsEstado.Caption = "Lectura"
        Me.brsEstado.Id = 47
        Me.brsEstado.Name = "brsEstado"
        Me.brsEstado.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'beiProceso
        '
        Me.beiProceso.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.beiProceso.Edit = Me.rpiProceso
        Me.beiProceso.Id = 0
        Me.beiProceso.Name = "beiProceso"
        Me.beiProceso.Width = 150
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
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiAtender, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiAtender
        '
        Me.bbiAtender.Caption = "Atender"
        Me.bbiAtender.Id = 9
        Me.bbiAtender.ImageIndex = 14
        Me.bbiAtender.Name = "bbiAtender"
        '
        'bbiCerrar
        '
        Me.bbiCerrar.Caption = "Cerrar"
        Me.bbiCerrar.Id = 41
        Me.bbiCerrar.ImageIndex = 9
        Me.bbiCerrar.LargeImageIndex = 0
        Me.bbiCerrar.Name = "bbiCerrar"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(851, 31)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 311)
        Me.BarDockControl2.Size = New System.Drawing.Size(851, 30)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 31)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 280)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(851, 31)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 280)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Vista"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'bbiVistaGrilla
        '
        Me.bbiVistaGrilla.Caption = "Grilla"
        Me.bbiVistaGrilla.Id = 7
        Me.bbiVistaGrilla.ImageIndex = 23
        Me.bbiVistaGrilla.Name = "bbiVistaGrilla"
        '
        'bbiTarjeta
        '
        Me.bbiTarjeta.Caption = "Tarjeta"
        Me.bbiTarjeta.Id = 8
        Me.bbiTarjeta.ImageIndex = 21
        Me.bbiTarjeta.Name = "bbiTarjeta"
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
        'gcEventos
        '
        Me.gcEventos.CausesValidation = False
        Me.gcEventos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcEventos.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gcEventos.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcEventos.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gcEventos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcEventos.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gcEventos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcEventos.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gcEventos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcEventos.EmbeddedNavigator.Buttons.ImageList = Me.imBarraAcciones16x16
        Me.gcEventos.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gcEventos.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcEventos.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(0, 19, "Exportar a Excel")})
        Me.gcEventos.Location = New System.Drawing.Point(0, 31)
        Me.gcEventos.MainView = Me.GridView1
        Me.gcEventos.Name = "gcEventos"
        Me.gcEventos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceAtendido, Me.RepositoryItemPictureEdit1})
        Me.gcEventos.Size = New System.Drawing.Size(851, 243)
        Me.gcEventos.TabIndex = 162
        Me.gcEventos.UseEmbeddedNavigator = True
        Me.gcEventos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcSeleccion, Me.gcTipoEvento, Me.gcNombreError, Me.gcDescripcionError, Me.gcUbicacion, Me.gcUsuario, Me.gcUsuarioRed, Me.gcNombreObjeto, Me.gcFechaHora, Me.gcAtendido, Me.gcUsuarioCreacion, Me.gcFechaCreacion, Me.gcUsuarioActualizacion, Me.gcFechActualizacion})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.gcEventos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'gcSeleccion
        '
        Me.gcSeleccion.Caption = "Seleccion"
        Me.gcSeleccion.Name = "gcSeleccion"
        '
        'gcTipoEvento
        '
        Me.gcTipoEvento.Caption = "Tipo"
        Me.gcTipoEvento.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.gcTipoEvento.FieldName = "TipoEvento"
        Me.gcTipoEvento.Name = "gcTipoEvento"
        Me.gcTipoEvento.OptionsColumn.AllowEdit = False
        Me.gcTipoEvento.Visible = True
        Me.gcTipoEvento.VisibleIndex = 0
        Me.gcTipoEvento.Width = 39
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'gcNombreError
        '
        Me.gcNombreError.Caption = "NombreError"
        Me.gcNombreError.FieldName = "NombreError"
        Me.gcNombreError.Name = "gcNombreError"
        Me.gcNombreError.OptionsColumn.AllowEdit = False
        Me.gcNombreError.Visible = True
        Me.gcNombreError.VisibleIndex = 1
        Me.gcNombreError.Width = 98
        '
        'gcDescripcionError
        '
        Me.gcDescripcionError.Caption = "DescripcionError"
        Me.gcDescripcionError.FieldName = "DescripcionError"
        Me.gcDescripcionError.Name = "gcDescripcionError"
        Me.gcDescripcionError.OptionsColumn.AllowEdit = False
        Me.gcDescripcionError.Visible = True
        Me.gcDescripcionError.VisibleIndex = 2
        Me.gcDescripcionError.Width = 98
        '
        'gcUbicacion
        '
        Me.gcUbicacion.Caption = "Ubicacion"
        Me.gcUbicacion.FieldName = "Ubicacion"
        Me.gcUbicacion.Name = "gcUbicacion"
        Me.gcUbicacion.OptionsColumn.AllowEdit = False
        Me.gcUbicacion.Visible = True
        Me.gcUbicacion.VisibleIndex = 3
        Me.gcUbicacion.Width = 98
        '
        'gcUsuario
        '
        Me.gcUsuario.Caption = "Usuario"
        Me.gcUsuario.FieldName = "Usuario"
        Me.gcUsuario.Name = "gcUsuario"
        Me.gcUsuario.OptionsColumn.AllowEdit = False
        Me.gcUsuario.Visible = True
        Me.gcUsuario.VisibleIndex = 5
        Me.gcUsuario.Width = 98
        '
        'gcUsuarioRed
        '
        Me.gcUsuarioRed.Caption = "UsuarioRed"
        Me.gcUsuarioRed.FieldName = "UsuarioRed"
        Me.gcUsuarioRed.Name = "gcUsuarioRed"
        Me.gcUsuarioRed.OptionsColumn.AllowEdit = False
        Me.gcUsuarioRed.Width = 98
        '
        'gcNombreObjeto
        '
        Me.gcNombreObjeto.Caption = "NombreObjeto"
        Me.gcNombreObjeto.FieldName = "NombreObjeto"
        Me.gcNombreObjeto.Name = "gcNombreObjeto"
        Me.gcNombreObjeto.OptionsColumn.AllowEdit = False
        Me.gcNombreObjeto.Visible = True
        Me.gcNombreObjeto.VisibleIndex = 4
        Me.gcNombreObjeto.Width = 98
        '
        'gcFechaHora
        '
        Me.gcFechaHora.Caption = "FechaHora"
        Me.gcFechaHora.FieldName = "FechaHora"
        Me.gcFechaHora.Name = "gcFechaHora"
        Me.gcFechaHora.OptionsColumn.AllowEdit = False
        Me.gcFechaHora.Visible = True
        Me.gcFechaHora.VisibleIndex = 6
        Me.gcFechaHora.Width = 98
        '
        'gcAtendido
        '
        Me.gcAtendido.Caption = "Atendido"
        Me.gcAtendido.ColumnEdit = Me.ceAtendido
        Me.gcAtendido.FieldName = "Atendido"
        Me.gcAtendido.Name = "gcAtendido"
        Me.gcAtendido.OptionsColumn.AllowEdit = False
        Me.gcAtendido.Width = 108
        '
        'ceAtendido
        '
        Me.ceAtendido.AutoHeight = False
        Me.ceAtendido.Name = "ceAtendido"
        Me.ceAtendido.ValueChecked = "1"
        Me.ceAtendido.ValueGrayed = ""
        Me.ceAtendido.ValueUnchecked = "0"
        '
        'gcUsuarioCreacion
        '
        Me.gcUsuarioCreacion.Caption = "Usuario Creacion"
        Me.gcUsuarioCreacion.FieldName = "UsuarioCreacion"
        Me.gcUsuarioCreacion.Name = "gcUsuarioCreacion"
        '
        'gcFechaCreacion
        '
        Me.gcFechaCreacion.Caption = "Fecha Creacion"
        Me.gcFechaCreacion.FieldName = "FechaCreacion"
        Me.gcFechaCreacion.Name = "gcFechaCreacion"
        '
        'gcUsuarioActualizacion
        '
        Me.gcUsuarioActualizacion.Caption = "Usuario Actualizacion"
        Me.gcUsuarioActualizacion.FieldName = "UsuarioActualizacion"
        Me.gcUsuarioActualizacion.Name = "gcUsuarioActualizacion"
        '
        'gcFechActualizacion
        '
        Me.gcFechActualizacion.Caption = "Fecha Actualizacion"
        Me.gcFechActualizacion.FieldName = "FechaActualizacion"
        Me.gcFechActualizacion.Name = "gcFechActualizacion"
        '
        'ucpUsuario
        '
        Me.ucpUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucpUsuario.FechaCreacion = New Date(CType(0, Long))
        Me.ucpUsuario.FechaModificacion = New Date(CType(0, Long))
        Me.ucpUsuario.Location = New System.Drawing.Point(0, 274)
        Me.ucpUsuario.Name = "ucpUsuario"
        Me.ucpUsuario.Size = New System.Drawing.Size(851, 37)
        Me.ucpUsuario.TabIndex = 180
        Me.ucpUsuario.UsuarioCreacion = Nothing
        Me.ucpUsuario.UsuarioModificacion = Nothing
        '
        'frmListaErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 341)
        Me.Controls.Add(Me.gcEventos)
        Me.Controls.Add(Me.ucpUsuario)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaErrores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eventos"
        CType(Me.bmAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEventos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents bbiAtender As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiVistaGrilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiTarjeta As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents gcEventos As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents gcSeleccion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcTipoEvento As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcNombreError As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcDescripcionError As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcUsuarioRed As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcNombreObjeto As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcFechaHora As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcAtendido As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents ceAtendido As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Private WithEvents gcUsuarioCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcUsuarioActualizacion As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents gcFechActualizacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ucpUsuario As Lotizador.UI.ucPanelAuditoria
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
End Class
