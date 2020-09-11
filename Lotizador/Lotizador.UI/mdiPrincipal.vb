Imports Lotizador.UI.LotizadorService

Public Class mdiPrincipal
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub New()
        InitializeComponent()

        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        Dim userLookAndFeel As DevExpress.LookAndFeel.UserLookAndFeel = New DevExpress.LookAndFeel.UserLookAndFeel(Me)
        userLookAndFeel.UseDefaultLookAndFeel = False
        userLookAndFeel.UseWindowsXPTheme = False
        userLookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        userLookAndFeel.SkinName = Me.LookAndFeel.SkinName
    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nbcMenuPrincipal.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        nbcMenuPrincipal.PaintStyleName = SkinName
        nvgVentas.Expanded = True
    End Sub

    Private Sub mdiPrincipal_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
    End Sub

    Private Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Private Sub OpenForm(AppForm As Form)
        Try
            Dim myForm As New Form
            myForm = AppForm
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nbiEstilos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEstilos.LinkClicked
        OpenForm(frmEstilos)
    End Sub

    Private Sub nbiMonedas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiMonedas.LinkClicked
        OpenForm(frmMonedas)
    End Sub

    Private Sub nbiTiposCambio_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTiposCambio.LinkClicked
        OpenForm(frmTiposCambio)
    End Sub

    Private Sub nbiSecuencias_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSecuencias.LinkClicked
        OpenForm(frmSecuencias)
    End Sub

    Private Sub nbiVariables_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiVariables.LinkClicked
        OpenForm(frmVariables)
    End Sub

    Private Sub nbiContratos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiContratos.LinkClicked
        OpenForm(frmContratos)
    End Sub

    Private Sub nbiCobranzas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCobranzas.LinkClicked
        OpenForm(frmCobranzas)
    End Sub

    Private Sub nbiFacturacion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFacturacion.LinkClicked
        OpenForm(frmFacturacion)
    End Sub

    Private Sub nbiSocios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSocios.LinkClicked
        OpenForm(frmSocios)
    End Sub

    Private Sub nbiProyectos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiProyectos.LinkClicked
        OpenForm(frmProyectos)
    End Sub

    Private Sub nbiCatastro_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCatastro.LinkClicked
        OpenForm(frmUnidadesCatastrales)
    End Sub

    Private Sub nbiLotes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLotes.LinkClicked
        OpenForm(frmLotes)
    End Sub

    Private Sub nbiUsuarios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiUsuarios.LinkClicked
        OpenForm(frmUsuario)
    End Sub

    Private Sub nbiCentroInformes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCentroInformes.LinkClicked
        OpenForm(frmCentroInformes)
    End Sub

    Private Sub nbiEstadoCuenta_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEstadoCuenta.LinkClicked
        OpenForm(frmEstadoCuenta)
    End Sub

    Private Sub nbiEventos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEventos.LinkClicked
        OpenForm(frmListaErrores)
    End Sub

    Private Sub mdiPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'End
    End Sub

    Private Sub mdiPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Esta seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                For f = 1 To Application.OpenForms.Count - 1
                    Application.OpenForms.Item(f).Close()
                Next
            Catch ex As Exception
            End Try
            TextToSpeak("Hasta luego, " & NombreUsuario)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub nbiFacturacionElectronica_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFacturacionElectronica.LinkClicked
        Dim oFESunat As New Lotizador.WIN.mdiPrincipal
        OpenForm(oFESunat)
    End Sub

    Private Sub nbiConsultaIntegral_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiConsultaIntegral.LinkClicked
        OpenForm(frmConsultaIntegral)
    End Sub
End Class