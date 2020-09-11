Imports Lotizador.UI.LotizadorService

Public Class mdiPrincipalOld
    Inherits DevExpress.XtraEditors.XtraForm
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

    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nbcMenuPrincipal.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        nbcMenuPrincipal.PaintStyleName = SkinName
    End Sub

    Private Sub bviEstilos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEstilos.LinkClicked
        Dim myForm As New frmEstilos
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviMonedas_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiMonedas.LinkClicked
        Dim myForm As New frmMonedas
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub


    Private Sub nviUsuario_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiUsuarios.LinkClicked
        Dim myForm As New frmUsuario
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviProyectos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiProyectos.LinkClicked
        Dim myForm As New frmProyectos
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviCatastro_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCatastro.LinkClicked
        Dim myForm As New frmUnidadesCatastrales
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviLotes_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLotes.LinkClicked
        Try
            Dim myForm As New frmLotes
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub nviVariables_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiVariables.LinkClicked
        Dim myForm As New frmVariables
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviSecuencias_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSecuencias.LinkClicked
        Dim myForm As New frmSecuencias
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviEventos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEventos.LinkClicked
        Dim myForm As New frmListaErrores
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviContratos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiContratos.LinkClicked
        Dim myForm As New frmContratos
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Friend Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Private Sub nviPagos_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiFacturacion.LinkClicked
        Dim myForm As New frmFacturacion
        If Me.Controls.Find(myForm.Name, True).Count = 0 Then
            myForm.MdiParent = Me
            myForm.Show()
        Else
            SelectPage(myForm.Name)
        End If
    End Sub

    Private Sub nviSocios_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSocios.LinkClicked
        Try
            Dim myForm As New frmSocios
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mdiPrincipal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub nviEstadoCuenta_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEstadoCuenta.LinkClicked
        Try
            Dim myForm As New frmEstadoCuenta
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mdiPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Esta seguro de cerrar la aplicación?", "Salir", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub nviCentroInformes_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCentroInformes.LinkClicked
        Try
            Dim myForm As New frmCentroInformes
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub nbiControlMoras_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiCobranzas.LinkClicked
        Try
            Dim myForm As New frmCobranzas
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub nbiTiposCambio_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTiposCambio.LinkClicked
        Try
            Dim myForm As New frmTiposCambio
            If Me.Controls.Find(myForm.Name, True).Count = 0 Then
                myForm.MdiParent = Me
                myForm.Show()
            Else
                SelectPage(myForm.Name)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mdiPrincipal_TextChanged(sender As System.Object, e As System.EventArgs) Handles MyBase.TextChanged
        Me.Text = My.Application.Info.ProductName + " [" + My.Application.Info.Version.ToString + "]"
    End Sub


End Class