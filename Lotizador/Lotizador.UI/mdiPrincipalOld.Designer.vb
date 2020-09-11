<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipalOld
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipalOld))
        Me.nvgSeguridad = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiUsuarios = New DevExpress.XtraNavBar.NavBarItem()
        Me.nviPerfiles = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiEventos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiSecuencias = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiVariables = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbcMenuPrincipal = New DevExpress.XtraNavBar.NavBarControl()
        Me.nvgVentas = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiContratos = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiCobranzas = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiFacturacion = New DevExpress.XtraNavBar.NavBarItem()
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
        Me.nvgReportesGestion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbiCentroInformes = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbiEstadoCuenta = New DevExpress.XtraNavBar.NavBarItem()
        Me.nvgHerramientas = New DevExpress.XtraNavBar.NavBarGroup()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.mnuEstilos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.ExpressApp.Win.Templates.Controls.XafTabbedMdiManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        CType(Me.nbcMenuPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nvgSeguridad
        '
        Me.nvgSeguridad.Caption = "Seguridad"
        Me.nvgSeguridad.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiUsuarios)})
        Me.nvgSeguridad.LargeImageIndex = 0
        Me.nvgSeguridad.Name = "nvgSeguridad"
        Me.nvgSeguridad.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Security48x48
        Me.nvgSeguridad.SmallImageIndex = 3
        '
        'nbiUsuarios
        '
        Me.nbiUsuarios.Caption = "Usuarios"
        Me.nbiUsuarios.Hint = "Usuarios"
        Me.nbiUsuarios.Name = "nbiUsuarios"
        Me.nbiUsuarios.SmallImage = Global.Lotizador.UI.My.Resources.Resources.users
        '
        'nviPerfiles
        '
        Me.nviPerfiles.Caption = "Perfiles"
        Me.nviPerfiles.Enabled = False
        Me.nviPerfiles.Name = "nviPerfiles"
        Me.nviPerfiles.SmallImage = Global.Lotizador.UI.My.Resources.Resources.profiles
        '
        'nbiEventos
        '
        Me.nbiEventos.Caption = "Eventos"
        Me.nbiEventos.Name = "nbiEventos"
        Me.nbiEventos.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Events
        '
        'nbiSecuencias
        '
        Me.nbiSecuencias.Caption = "Secuencias"
        Me.nbiSecuencias.Hint = "Secuencias por proyecto, serie y tipo de documento contable."
        Me.nbiSecuencias.Name = "nbiSecuencias"
        Me.nbiSecuencias.SmallImage = CType(resources.GetObject("nbiSecuencias.SmallImage"), System.Drawing.Image)
        '
        'nbiVariables
        '
        Me.nbiVariables.Caption = "Variables"
        Me.nbiVariables.Name = "nbiVariables"
        Me.nbiVariables.SmallImage = Global.Lotizador.UI.My.Resources.Resources.variables
        '
        'nbcMenuPrincipal
        '
        Me.nbcMenuPrincipal.ActiveGroup = Me.nvgVentas
        Me.nbcMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.nbcMenuPrincipal.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nvgVentas, Me.nvgSistema, Me.nvgConfiguraciones, Me.nvgSeguridad, Me.nvgReportesGestion, Me.nvgHerramientas})
        Me.nbcMenuPrincipal.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbiUsuarios, Me.nviPerfiles, Me.nbiEventos, Me.nbiSecuencias, Me.nbiVariables, Me.nbiSocios, Me.nbiProyectos, Me.nbiCatastro, Me.nviOpciones, Me.nbiLotes, Me.nbiEstadoCuenta, Me.nbiContratos, Me.nbiFacturacion, Me.nbiEstilos, Me.nbiMonedas, Me.nbiCentroInformes, Me.nbiCobranzas, Me.nbiTiposCambio})
        Me.nbcMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.nbcMenuPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.nbcMenuPrincipal.Name = "nbcMenuPrincipal"
        Me.nbcMenuPrincipal.OptionsNavPane.ExpandedWidth = 340
        Me.nbcMenuPrincipal.Padding = New System.Windows.Forms.Padding(0, 29, 0, 0)
        Me.nbcMenuPrincipal.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.nbcMenuPrincipal.Size = New System.Drawing.Size(340, 902)
        Me.nbcMenuPrincipal.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
        Me.nbcMenuPrincipal.TabIndex = 14
        Me.nbcMenuPrincipal.Text = "Sistema de Venta de Lotes"
        Me.nbcMenuPrincipal.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Black")
        '
        'nvgVentas
        '
        Me.nvgVentas.Caption = "Ventas"
        Me.nvgVentas.Expanded = True
        Me.nvgVentas.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiContratos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCobranzas), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiFacturacion)})
        Me.nvgVentas.Name = "nvgVentas"
        Me.nvgVentas.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Sales48x48
        '
        'nbiContratos
        '
        Me.nbiContratos.Caption = "Contratos"
        Me.nbiContratos.Name = "nbiContratos"
        Me.nbiContratos.SmallImage = CType(resources.GetObject("nbiContratos.SmallImage"), System.Drawing.Image)
        '
        'nbiCobranzas
        '
        Me.nbiCobranzas.Caption = "Cobranzas"
        Me.nbiCobranzas.Name = "nbiCobranzas"
        Me.nbiCobranzas.SmallImage = CType(resources.GetObject("nbiCobranzas.SmallImage"), System.Drawing.Image)
        '
        'nbiFacturacion
        '
        Me.nbiFacturacion.Caption = "Facturación"
        Me.nbiFacturacion.Name = "nbiFacturacion"
        Me.nbiFacturacion.SmallImage = CType(resources.GetObject("nbiFacturacion.SmallImage"), System.Drawing.Image)
        '
        'nvgSistema
        '
        Me.nvgSistema.Caption = "Sistema"
        Me.nvgSistema.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSocios), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiProyectos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCatastro), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiLotes)})
        Me.nvgSistema.Name = "nvgSistema"
        Me.nvgSistema.SmallImage = Global.Lotizador.UI.My.Resources.Resources.System48x48
        '
        'nbiSocios
        '
        Me.nbiSocios.Caption = "Socios"
        Me.nbiSocios.Name = "nbiSocios"
        Me.nbiSocios.SmallImage = Global.Lotizador.UI.My.Resources.Resources.partners
        '
        'nbiProyectos
        '
        Me.nbiProyectos.Caption = "Proyectos"
        Me.nbiProyectos.Name = "nbiProyectos"
        Me.nbiProyectos.SmallImage = Global.Lotizador.UI.My.Resources.Resources.projects
        '
        'nbiCatastro
        '
        Me.nbiCatastro.Caption = "Unidades Catastrales"
        Me.nbiCatastro.Name = "nbiCatastro"
        Me.nbiCatastro.SmallImage = Global.Lotizador.UI.My.Resources.Resources.c_units
        '
        'nbiLotes
        '
        Me.nbiLotes.Caption = "Lotes"
        Me.nbiLotes.Name = "nbiLotes"
        Me.nbiLotes.SmallImage = Global.Lotizador.UI.My.Resources.Resources.lotes
        '
        'nvgConfiguraciones
        '
        Me.nvgConfiguraciones.Caption = "Configuraciones"
        Me.nvgConfiguraciones.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nviOpciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEstilos), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiMonedas), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiTiposCambio), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSecuencias), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiVariables)})
        Me.nvgConfiguraciones.Name = "nvgConfiguraciones"
        Me.nvgConfiguraciones.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Configurations48x48
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
        Me.nbiEstilos.Name = "nbiEstilos"
        Me.nbiEstilos.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Estilos
        '
        'nbiMonedas
        '
        Me.nbiMonedas.Caption = "Monedas"
        Me.nbiMonedas.Name = "nbiMonedas"
        Me.nbiMonedas.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Coins
        '
        'nbiTiposCambio
        '
        Me.nbiTiposCambio.Caption = "Tipos de Cambio"
        Me.nbiTiposCambio.Name = "nbiTiposCambio"
        Me.nbiTiposCambio.SmallImage = CType(resources.GetObject("nbiTiposCambio.SmallImage"), System.Drawing.Image)
        '
        'nvgReportesGestion
        '
        Me.nvgReportesGestion.Caption = "Reportes de Gestión"
        Me.nvgReportesGestion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCentroInformes), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEstadoCuenta)})
        Me.nvgReportesGestion.Name = "nvgReportesGestion"
        Me.nvgReportesGestion.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Reports48x48
        '
        'nbiCentroInformes
        '
        Me.nbiCentroInformes.Caption = "Centro de Informes"
        Me.nbiCentroInformes.Name = "nbiCentroInformes"
        Me.nbiCentroInformes.SmallImage = CType(resources.GetObject("nbiCentroInformes.SmallImage"), System.Drawing.Image)
        '
        'nbiEstadoCuenta
        '
        Me.nbiEstadoCuenta.Caption = "Estado de Cuenta"
        Me.nbiEstadoCuenta.Name = "nbiEstadoCuenta"
        Me.nbiEstadoCuenta.SmallImage = Global.Lotizador.UI.My.Resources.Resources.statement
        '
        'nvgHerramientas
        '
        Me.nvgHerramientas.Caption = "Herramientas"
        Me.nvgHerramientas.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiEventos)})
        Me.nvgHerramientas.Name = "nvgHerramientas"
        Me.nvgHerramientas.SmallImage = Global.Lotizador.UI.My.Resources.Resources.Tools48x48
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(340, 0)
        Me.SplitterControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 902)
        Me.SplitterControl1.TabIndex = 19
        Me.SplitterControl1.TabStop = False
        '
        'mnuEstilos
        '
        Me.mnuEstilos.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuEstilos.Name = "mnuContenedorRetroceder"
        Me.mnuEstilos.ShowImageMargin = False
        Me.mnuEstilos.Size = New System.Drawing.Size(36, 4)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.View = Me.TabbedView1
        Me.XtraTabbedMdiManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'mdiPrincipalOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 902)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.nbcMenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mdiPrincipalOld"
        Me.Text = "Sistema de Venta de Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nbcMenuPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents nvgSeguridad As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiUsuarios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nviPerfiles As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiEventos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiSecuencias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiVariables As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgSistema As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiSocios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiProyectos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiCatastro As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgConfiguraciones As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nvgVentas As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nvgReportesGestion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents nviOpciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nvgHerramientas As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nbiLotes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiContratos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiFacturacion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiEstadoCuenta As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiEstilos As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents mnuEstilos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents nbiMonedas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.ExpressApp.Win.Templates.Controls.XafTabbedMdiManager
    Friend WithEvents nbcMenuPrincipal As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nbiCentroInformes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiTiposCambio As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents nbiCobranzas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
End Class
