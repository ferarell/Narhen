﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPopupFacturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPopupFacturacion))
        Me.brBarraAcciones = New DevExpress.XtraBars.Bar()
        Me.bbiImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtNumeroDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.lueTipoPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.bmPopupAcciones = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.rpiProceso = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.rgSUNAT = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.deFechaEmision = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNumeroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueTipoPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.rgSUNAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.deFechaEmision.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaEmision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'brBarraAcciones
        '
        Me.brBarraAcciones.BarName = "Custom 5"
        Me.brBarraAcciones.DockCol = 0
        Me.brBarraAcciones.DockRow = 0
        Me.brBarraAcciones.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.brBarraAcciones.FloatLocation = New System.Drawing.Point(279, 188)
        Me.brBarraAcciones.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiImprimir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bbiCerrar, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.brBarraAcciones.OptionsBar.AllowQuickCustomization = False
        Me.brBarraAcciones.OptionsBar.UseWholeRow = True
        Me.brBarraAcciones.Text = "Custom 5"
        '
        'bbiImprimir
        '
        Me.bbiImprimir.Caption = "Imprimir"
        Me.bbiImprimir.Id = 35
        Me.bbiImprimir.ImageOptions.Image = CType(resources.GetObject("bbiImprimir.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiImprimir.ImageOptions.ImageIndex = 12
        Me.bbiImprimir.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G))
        Me.bbiImprimir.Name = "bbiImprimir"
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
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.txtNumeroDocumento)
        Me.GroupControl1.Controls.Add(Me.lueTipoPago)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 124)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(330, 93)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Emisión Individual"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(155, 58)
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Properties.Mask.BeepOnError = True
        Me.txtNumeroDocumento.Properties.Mask.EditMask = "\d{0,25}"
        Me.txtNumeroDocumento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(128, 20)
        Me.txtNumeroDocumento.TabIndex = 2
        '
        'lueTipoPago
        '
        Me.lueTipoPago.Location = New System.Drawing.Point(155, 32)
        Me.lueTipoPago.Name = "lueTipoPago"
        Me.lueTipoPago.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lueTipoPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoPago.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.lueTipoPago.Properties.NullText = ""
        Me.lueTipoPago.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueTipoPago.Size = New System.Drawing.Size(61, 20)
        Me.lueTipoPago.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(45, 61)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Número Operación"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(45, 35)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Tipo de Pago"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Por favor tenga mucho cuidado al asignar las condiciones."
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
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
        Me.bmPopupAcciones.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiImprimir, Me.bbiCerrar, Me.BarStaticItem1})
        Me.bmPopupAcciones.MaxItemId = 6
        Me.bmPopupAcciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpiProceso})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.bmPopupAcciones
        Me.barDockControlTop.Size = New System.Drawing.Size(354, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 295)
        Me.barDockControlBottom.Manager = Me.bmPopupAcciones
        Me.barDockControlBottom.Size = New System.Drawing.Size(354, 58)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Manager = Me.bmPopupAcciones
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 248)
        '
        'barDockControl1
        '
        Me.barDockControl1.CausesValidation = False
        Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControl1.Location = New System.Drawing.Point(354, 47)
        Me.barDockControl1.Manager = Me.bmPopupAcciones
        Me.barDockControl1.Size = New System.Drawing.Size(0, 248)
        '
        'rpiProceso
        '
        Me.rpiProceso.Name = "rpiProceso"
        Me.rpiProceso.ShowTitle = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.Transparent
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.rgSUNAT)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 223)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(330, 64)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Secuencia"
        '
        'rgSUNAT
        '
        Me.rgSUNAT.EditValue = False
        Me.rgSUNAT.Location = New System.Drawing.Point(191, 25)
        Me.rgSUNAT.MenuManager = Me.bmPopupAcciones
        Me.rgSUNAT.Name = "rgSUNAT"
        Me.rgSUNAT.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgSUNAT.Properties.Appearance.Options.UseBackColor = True
        Me.rgSUNAT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgSUNAT.Properties.Columns = 2
        Me.rgSUNAT.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Si"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "No")})
        Me.rgSUNAT.Size = New System.Drawing.Size(134, 34)
        Me.rgSUNAT.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(32, 34)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(129, 13)
        Me.LabelControl12.TabIndex = 14
        Me.LabelControl12.Text = "Asignar Documento SUNAT"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.Controls.Add(Me.deFechaEmision)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 53)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(330, 65)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Emisión Grupal"
        '
        'deFechaEmision
        '
        Me.deFechaEmision.EditValue = Nothing
        Me.deFechaEmision.Location = New System.Drawing.Point(155, 33)
        Me.deFechaEmision.Name = "deFechaEmision"
        Me.deFechaEmision.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.deFechaEmision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaEmision.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFechaEmision.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.deFechaEmision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.deFechaEmision.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.deFechaEmision.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.deFechaEmision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.deFechaEmision.Size = New System.Drawing.Size(107, 20)
        Me.deFechaEmision.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(45, 36)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Fecha de Emisión"
        '
        'frmPopupFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 353)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControl1)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPopupFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtNumeroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueTipoPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bmPopupAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpiProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.rgSUNAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.deFechaEmision.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaEmision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents brBarraAcciones As DevExpress.XtraBars.Bar
    Private WithEvents bbiImprimir As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiCerrar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents Bar1 As DevExpress.XtraBars.Bar
    Private WithEvents bmPopupAcciones As DevExpress.XtraBars.BarManager
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControl1 As DevExpress.XtraBars.BarDockControl
    Private WithEvents rpiProceso As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rgSUNAT As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueTipoPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtNumeroDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deFechaEmision As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
