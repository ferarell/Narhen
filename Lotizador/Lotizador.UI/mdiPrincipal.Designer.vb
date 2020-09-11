<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.nbcMenuPrincipal = New DevExpress.XtraNavBar.NavBarControl()
        Me.nvgHerramientas = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiEventos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgVentas = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiContratos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiCobranzas = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiFacturacion = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiFacturacionElectronica = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgSistema = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiSocios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiProyectos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiCatastro = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiLotes = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgConfiguraciones = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nviOpciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiEstilos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiMonedas = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiTiposCambio = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiSecuencias = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiVariables = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgSeguridad = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiUsuarios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgReportesGestion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiCentroInformes = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiEstadoCuenta = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiConsultaIntegral = New DevExpress.XtraNavBar.NavBarItem()
        Me.nviPerfiles = New DevExpress.XtraNavBar.NavBarItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbcMenuPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.UseFormIconAsPageImage = DevExpress.Utils.DefaultBoolean.[False]
        '
        'nbcMenuPrincipal
        '
        Me.nbcMenuPrincipal.ActiveGroup = Me.nvgHerramientas
        Me.nbcMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.nbcMenuPrincipal.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nvgVentas, Me.nvgSistema, Me.nvgConfiguraciones, Me.nvgSeguridad, Me.nvgReportesGestion, Me.nvgHerramientas})
        Me.nbcMenuPrincipal.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbiUsuarios, Me.nviPerfiles, Me.nbiEventos, Me.nbiSecuencias, Me.nbiVariables, Me.nbiSocios, Me.nbiProyectos, Me.nbiCatastro, Me.nviOpciones, Me.nbiLotes, Me.nbiEstadoCuenta, Me.nbiContratos, Me.nbiFacturacion, Me.nbiEstilos, Me.nbiMonedas, Me.nbiCentroInformes, Me.nbiCobranzas, Me.nbiTiposCambio, Me.nbiFacturacionElectronica, Me.nbiConsultaIntegral})
        Me.nbcMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.nbcMenuPrincipal.Name = "nbcMenuPrincipal"
        Me.nbcMenuPrincipal.OptionsNavPane.ExpandedWidth = 227
        Me.nbcMenuPrincipal.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.nbcMenuPrincipal.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.nbcMenuPrincipal.Size = New System.Drawing.Size(227, 404)
        Me.nbcMenuPrincipal.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
        Me.nbcMenuPrincipal.TabIndex = 15
        Me.nbcMenuPrincipal.Text = "navBarControl1"
        Me.nbcMenuPrincipal.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Black")
        '
        'nvgHerramientas
        '
        Me.nvgHerramientas.Caption = "Herramientas"
        Me.nvgHerramientas.Expanded = True
        Me.nvgHerramientas.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Tools48x48
        Me.nvgHerramientas.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEventos)})
        Me.nvgHerramientas.Name = "nvgHerramientas"
        '
        'nbiEventos
        '
        Me.nbiEventos.Caption = "Eventos"
        Me.nbiEventos.ImageOptions.LargeImage = CType(resources.GetObject("nbiEventos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiEventos.ImageOptions.SmallImage = CType(resources.GetObject("nbiEventos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiEventos.Name = "nbiEventos"
        '
        'nvgVentas
        '
        Me.nvgVentas.Caption = "Ventas"
        Me.nvgVentas.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Sales48x48
        Me.nvgVentas.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiContratos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCobranzas), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFacturacion), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFacturacionElectronica)})
        Me.nvgVentas.Name = "nvgVentas"
        '
        'nbiContratos
        '
        Me.nbiContratos.Caption = "Contratos"
        Me.nbiContratos.ImageOptions.LargeImage = CType(resources.GetObject("nbiContratos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiContratos.ImageOptions.SmallImage = CType(resources.GetObject("nbiContratos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiContratos.Name = "nbiContratos"
        '
        'nbiCobranzas
        '
        Me.nbiCobranzas.Caption = "Cobranzas"
        Me.nbiCobranzas.ImageOptions.LargeImage = CType(resources.GetObject("nbiCobranzas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiCobranzas.ImageOptions.SmallImage = CType(resources.GetObject("nbiCobranzas.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiCobranzas.Name = "nbiCobranzas"
        '
        'nbiFacturacion
        '
        Me.nbiFacturacion.Caption = "Facturación"
        Me.nbiFacturacion.ImageOptions.LargeImage = CType(resources.GetObject("nbiFacturacion.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiFacturacion.ImageOptions.SmallImage = CType(resources.GetObject("nbiFacturacion.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiFacturacion.Name = "nbiFacturacion"
        '
        'nbiFacturacionElectronica
        '
        Me.nbiFacturacionElectronica.Caption = "FE SUNAT"
        Me.nbiFacturacionElectronica.ImageOptions.LargeImage = CType(resources.GetObject("nbiFacturacionElectronica.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiFacturacionElectronica.ImageOptions.SmallImage = CType(resources.GetObject("nbiFacturacionElectronica.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiFacturacionElectronica.Name = "nbiFacturacionElectronica"
        '
        'nvgSistema
        '
        Me.nvgSistema.Caption = "Sistema"
        Me.nvgSistema.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.System48x48
        Me.nvgSistema.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSocios), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiProyectos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCatastro), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiLotes)})
        Me.nvgSistema.Name = "nvgSistema"
        '
        'nbiSocios
        '
        Me.nbiSocios.Caption = "Socios"
        Me.nbiSocios.ImageOptions.LargeImage = CType(resources.GetObject("nbiSocios.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiSocios.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
        Me.nbiSocios.ImageOptions.SmallImage = CType(resources.GetObject("nbiSocios.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiSocios.ImageOptions.SmallImageSize = New System.Drawing.Size(32, 32)
        Me.nbiSocios.Name = "nbiSocios"
        '
        'nbiProyectos
        '
        Me.nbiProyectos.Caption = "Proyectos"
        Me.nbiProyectos.ImageOptions.LargeImage = CType(resources.GetObject("nbiProyectos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiProyectos.ImageOptions.SmallImage = CType(resources.GetObject("nbiProyectos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiProyectos.Name = "nbiProyectos"
        '
        'nbiCatastro
        '
        Me.nbiCatastro.Caption = "Unidades Catastrales"
        Me.nbiCatastro.ImageOptions.LargeImage = CType(resources.GetObject("nbiCatastro.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiCatastro.ImageOptions.SmallImage = CType(resources.GetObject("nbiCatastro.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiCatastro.Name = "nbiCatastro"
        '
        'nbiLotes
        '
        Me.nbiLotes.Caption = "Lotes"
        Me.nbiLotes.ImageOptions.LargeImage = CType(resources.GetObject("nbiLotes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiLotes.ImageOptions.SmallImage = CType(resources.GetObject("nbiLotes.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiLotes.Name = "nbiLotes"
        '
        'nvgConfiguraciones
        '
        Me.nvgConfiguraciones.Caption = "Configuraciones"
        Me.nvgConfiguraciones.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Configurations48x48
        Me.nvgConfiguraciones.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nviOpciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEstilos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiMonedas), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiTiposCambio), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSecuencias), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiVariables)})
        Me.nvgConfiguraciones.Name = "nvgConfiguraciones"
        '
        'nviOpciones
        '
        Me.nviOpciones.Caption = "Opciones"
        Me.nviOpciones.Name = "nviOpciones"
        Me.nviOpciones.Visible = False
        '
        'nbiEstilos
        '
        Me.nbiEstilos.Caption = "Estilos"
        Me.nbiEstilos.ImageOptions.LargeImage = CType(resources.GetObject("nbiEstilos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiEstilos.ImageOptions.SmallImage = CType(resources.GetObject("nbiEstilos.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiEstilos.Name = "nbiEstilos"
        '
        'nbiMonedas
        '
        Me.nbiMonedas.Caption = "Monedas"
        Me.nbiMonedas.ImageOptions.LargeImage = CType(resources.GetObject("nbiMonedas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiMonedas.ImageOptions.SmallImage = CType(resources.GetObject("nbiMonedas.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiMonedas.Name = "nbiMonedas"
        '
        'nbiTiposCambio
        '
        Me.nbiTiposCambio.Caption = "Tipos de Cambio"
        Me.nbiTiposCambio.ImageOptions.LargeImage = CType(resources.GetObject("nbiTiposCambio.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiTiposCambio.ImageOptions.SmallImage = CType(resources.GetObject("nbiTiposCambio.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiTiposCambio.Name = "nbiTiposCambio"
        '
        'nbiSecuencias
        '
        Me.nbiSecuencias.Caption = "Secuencias"
        Me.nbiSecuencias.Hint = "Secuencias por proyecto, serie y tipo de documento contable."
        Me.nbiSecuencias.ImageOptions.LargeImage = CType(resources.GetObject("nbiSecuencias.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiSecuencias.ImageOptions.SmallImage = CType(resources.GetObject("nbiSecuencias.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiSecuencias.Name = "nbiSecuencias"
        '
        'nbiVariables
        '
        Me.nbiVariables.Caption = "Variables"
        Me.nbiVariables.ImageOptions.LargeImage = CType(resources.GetObject("nbiVariables.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiVariables.ImageOptions.SmallImage = CType(resources.GetObject("nbiVariables.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiVariables.Name = "nbiVariables"
        '
        'nvgSeguridad
        '
        Me.nvgSeguridad.Caption = "Seguridad"
        Me.nvgSeguridad.ImageOptions.LargeImageIndex = 0
        Me.nvgSeguridad.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Security48x48
        Me.nvgSeguridad.ImageOptions.SmallImageIndex = 3
        Me.nvgSeguridad.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiUsuarios)})
        Me.nvgSeguridad.Name = "nvgSeguridad"
        '
        'nbiUsuarios
        '
        Me.nbiUsuarios.Caption = "Usuarios"
        Me.nbiUsuarios.Hint = "Usuarios"
        Me.nbiUsuarios.ImageOptions.LargeImage = CType(resources.GetObject("nbiUsuarios.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiUsuarios.ImageOptions.SmallImage = CType(resources.GetObject("nbiUsuarios.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiUsuarios.Name = "nbiUsuarios"
        '
        'nvgReportesGestion
        '
        Me.nvgReportesGestion.Caption = "Reportes de Gestión"
        Me.nvgReportesGestion.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Reports48x48
        Me.nvgReportesGestion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCentroInformes), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEstadoCuenta), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiConsultaIntegral)})
        Me.nvgReportesGestion.Name = "nvgReportesGestion"
        '
        'nbiCentroInformes
        '
        Me.nbiCentroInformes.Caption = "Centro de Informes"
        Me.nbiCentroInformes.ImageOptions.LargeImage = CType(resources.GetObject("nbiCentroInformes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiCentroInformes.ImageOptions.SmallImage = CType(resources.GetObject("nbiCentroInformes.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiCentroInformes.Name = "nbiCentroInformes"
        '
        'nbiEstadoCuenta
        '
        Me.nbiEstadoCuenta.Caption = "Estado de Cuenta"
        Me.nbiEstadoCuenta.ImageOptions.LargeImage = CType(resources.GetObject("nbiEstadoCuenta.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiEstadoCuenta.ImageOptions.SmallImage = CType(resources.GetObject("nbiEstadoCuenta.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiEstadoCuenta.Name = "nbiEstadoCuenta"
        '
        'nbiConsultaIntegral
        '
        Me.nbiConsultaIntegral.Caption = "Consulta Integral"
        Me.nbiConsultaIntegral.ImageOptions.LargeImage = CType(resources.GetObject("nbiConsultaIntegral.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.nbiConsultaIntegral.ImageOptions.SmallImage = CType(resources.GetObject("nbiConsultaIntegral.ImageOptions.SmallImage"), System.Drawing.Image)
        Me.nbiConsultaIntegral.Name = "nbiConsultaIntegral"
        '
        'nviPerfiles
        '
        Me.nviPerfiles.Caption = "Perfiles"
        Me.nviPerfiles.Enabled = False
        Me.nviPerfiles.ImageOptions.SmallImage = Global.Lotizador.UI.My.Resources.Resources.profiles
        Me.nviPerfiles.Name = "nviPerfiles"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(534, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 404)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(534, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 404)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(534, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 404)
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 427)
        Me.Controls.Add(Me.nbcMenuPrincipal)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "mdiPrincipal"
        Me.Text = "Sistema de Venta de Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbcMenuPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents nbcMenuPrincipal As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nvgVentas As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiContratos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiCobranzas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFacturacion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgSistema As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiSocios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiProyectos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiCatastro As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiLotes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgConfiguraciones As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nviOpciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiEstilos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiMonedas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTiposCambio As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiSecuencias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiVariables As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents nvgSeguridad As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiUsuarios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgReportesGestion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiCentroInformes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiEstadoCuenta As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgHerramientas As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiEventos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nviPerfiles As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFacturacionElectronica As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiConsultaIntegral As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
