<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaIntegral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaIntegral))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.cbeTipoConsulta = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.bmPopupAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiConsultar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiExportar = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lueProyecto = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lueLote = New DevExpress.XtraEditors.LookUpEdit()
        Me.gcConsultaGeneral = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.vpInputs = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cbeTipoConsulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcConsultaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.gcConsultaGeneral)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1001, 316)
        Me.SplitContainerControl1.SplitterPosition = 42
        Me.SplitContainerControl1.TabIndex = 0
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.cbeTipoConsulta)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.lueProyecto)
        Me.PanelControl2.Controls.Add(Me.lueCliente)
        Me.PanelControl2.Controls.Add(Me.lblCliente)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lueLote)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1001, 42)
        Me.PanelControl2.TabIndex = 11
        '
        'cbeTipoConsulta
        '
        Me.cbeTipoConsulta.EditValue = "PENDIENTE"
        Me.cbeTipoConsulta.Location = New System.Drawing.Point(845, 10)
        Me.cbeTipoConsulta.MenuManager = Me.bmPopupAcciones
        Me.cbeTipoConsulta.Name = "cbeTipoConsulta"
        Me.cbeTipoConsulta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbeTipoConsulta.Properties.Items.AddRange(New Object() {"TODO", "PENDIENTE", "CANCELADO"})
        Me.cbeTipoConsulta.Size = New System.Drawing.Size(88, 20)
        Me.cbeTipoConsulta.TabIndex = 3
        '
        'bmPopupAcciones
        '
        Me.bmPopupAcciones.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.brBarraAcciones})
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlTop)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlBottom)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControlLeft)
        Me.bmPopupAcciones.DockControls.Add(Me.barDockControl1)
        Me.bmPopupAcciones.Form = Me
        Me.bmPopupAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiConsultar, Me.bbiCerrar, Me.BarStaticItem1, Me.bbiExportar})
        Me.bmPopupAcciones.MaxItemId = 7
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
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiConsultar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiExportar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiConsultar
        '
        Me.bbiConsultar.Caption = "&Consultar"
        Me.bbiConsultar.Id = 35
        Me.bbiConsultar.ImageOptions.Image = CType(resources.GetObject("bbiConsultar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiConsultar.ImageOptions.ImageIndex = 12
        Me.bbiConsultar.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.bbiConsultar.Name = "bbiConsultar"
        '
        'bbiExportar
        '
        Me.bbiExportar.Caption = "&Exportar"
        Me.bbiExportar.Id = 6
        Me.bbiExportar.ImageOptions.Image = CType(resources.GetObject("bbiExportar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiExportar.Name = "bbiExportar"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1001, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 363)
        Me.barDockControlBottom.Manager = Me.bmPopupAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(1001, 29)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmPopupAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 316)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(1001, 47)
        Me.barDockControl1.Manager = Me.bmPopupAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 316)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Por favor tenga mucho cuidado al asignar las condiciones."
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
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
        Me.lueProyecto.TabIndex = 0
        '
        'lueCliente
        '
        Me.lueCliente.Location = New System.Drawing.Point(335, 10)
        Me.lueCliente.Name = "lueCliente"
        Me.lueCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Cliente"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdSocio", "IdSocio", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueCliente.Properties.NullText = "Seleccione"
        Me.lueCliente.Size = New System.Drawing.Size(326, 20)
        Me.lueCliente.TabIndex = 1
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(296, 13)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(33, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(819, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Tipo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(687, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Lote"
        '
        'lueLote
        '
        Me.lueLote.Location = New System.Drawing.Point(714, 10)
        Me.lueLote.Name = "lueLote"
        Me.lueLote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLote.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManzanaLote", "Lote"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdContrato", "IdContrato", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lueLote.Properties.NullText = "Seleccione"
        Me.lueLote.Size = New System.Drawing.Size(73, 20)
        Me.lueLote.TabIndex = 2
        '
        'gcConsultaGeneral
        '
        Me.gcConsultaGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcConsultaGeneral.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.gcConsultaGeneral.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.gcConsultaGeneral.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.gcConsultaGeneral.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.gcConsultaGeneral.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.gcConsultaGeneral.Location = New System.Drawing.Point(0, 0)
        Me.gcConsultaGeneral.MainView = Me.GridView1
        Me.gcConsultaGeneral.Name = "gcConsultaGeneral"
        Me.gcConsultaGeneral.Size = New System.Drawing.Size(1001, 269)
        Me.gcConsultaGeneral.TabIndex = 0
        Me.gcConsultaGeneral.UseEmbeddedNavigator = True
        Me.gcConsultaGeneral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29})
        Me.GridView1.GridControl = Me.gcConsultaGeneral
        Me.GridView1.GroupCount = 2
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCuota", Me.GridColumn13, "{0:###,###,###.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePago", Me.GridColumn17, "{0:###,###,###.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Saldo", Me.GridColumn26, "{0:###,###,###.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.BestFitMaxRowCount = 20
        Me.GridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn7, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'vpInputs
        '
        Me.vpInputs.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Id Proyecto"
        Me.GridColumn1.FieldName = "IdProyecto"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id Contrato"
        Me.GridColumn2.FieldName = "IdContrato"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Id Socio"
        Me.GridColumn3.FieldName = "IdSocio"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Id Lote"
        Me.GridColumn4.FieldName = "IdLote"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Id Letra"
        Me.GridColumn5.FieldName = "IdLetra"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Nombre Proyecto"
        Me.GridColumn7.FieldName = "NombreProyecto"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Documento Identidad"
        Me.GridColumn8.FieldName = "DocumentoIdentidad"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Socio"
        Me.GridColumn9.FieldName = "Socio"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "ManzanaLote"
        Me.GridColumn10.FieldName = "ManzanaLote"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Numero Cuota"
        Me.GridColumn11.FieldName = "NumeroCuota"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Fecha Cuota"
        Me.GridColumn12.FieldName = "FechaCuota"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Importe Cuota"
        Me.GridColumn13.FieldName = "ImporteCuota"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 4
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Fecha Pago"
        Me.GridColumn14.FieldName = "FechaPago"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Tipo Pago"
        Me.GridColumn15.FieldName = "TipoPago"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 6
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Número Pago"
        Me.GridColumn16.FieldName = "NumeroPago"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 7
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Importe Pago"
        Me.GridColumn17.FieldName = "ImportePago"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 8
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Tipo Comprobante"
        Me.GridColumn18.FieldName = "CodigoTipoDocumento"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 9
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Número Comprobante"
        Me.GridColumn19.FieldName = "NumeroSunat"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 10
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Fecha Emisión"
        Me.GridColumn20.FieldName = "FechaEmision"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 11
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Importe Mora"
        Me.GridColumn21.FieldName = "ImporteMora"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 12
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Pago Mora"
        Me.GridColumn22.FieldName = "PagoMora"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 13
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Estado Mora"
        Me.GridColumn23.FieldName = "EstadoMora"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 14
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Moneda"
        Me.GridColumn24.FieldName = "SimboloMoneda"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 15
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Observaciones"
        Me.GridColumn25.FieldName = "Observaciones"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 16
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Saldo Cuota"
        Me.GridColumn26.FieldName = "Saldo"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 17
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Total Deuda"
        Me.GridColumn27.FieldName = "TotalDeuda"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 18
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Total Pago"
        Me.GridColumn28.FieldName = "TotalPago"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 19
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Total Saldo"
        Me.GridColumn29.FieldName = "TotalSaldo"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 20
        '
        'frmConsultaIntegral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 392)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmConsultaIntegral"
        Me.Text = "Consulta Integral"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cbeTipoConsulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProyecto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcConsultaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vpInputs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueProyecto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLote As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gcConsultaGeneral As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiConsultar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents bbiExportar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents vpInputs As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents cbeTipoConsulta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
End Class
