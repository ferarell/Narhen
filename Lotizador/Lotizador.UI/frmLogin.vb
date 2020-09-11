Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmLogin
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oFunciones As New Lotizador.WIN.Funciones

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim oUsuario As UsuarioBE = New UsuarioBE()
            oUsuario.Cuenta = Me.txtUsuario.Text.Trim()
            Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)(oNarhemService.ObtenerUsuarioPorCriterio(oUsuario))
            Dim oCriptologia As Criptologia = New Criptologia()
            If listUsuarios.Count > 0 Then
                oUsuario = listUsuarios(0)
            End If

            Dim strPswdesencriptado As String = oCriptologia.DesencriptarTexto(oUsuario.Password)
            If txtPassword.Text <> "" And strPswdesencriptado = Me.txtPassword.Text Then
                If oUsuario.FlgCambioPwd Then
                    Dim oFormDialog As frmCambiarPassword = New frmCambiarPassword()

                    oFormDialog.oUsuarioBE = oUsuario
                    If oFormDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Cambiado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim myForm As New mdiPrincipal
                    myForm.Show()
                    IdUsuario = oUsuario.IdUsuario
                    oFunciones.USUARIO = oUsuario.Cuenta
                    CuentaUsaurio = oUsuario.Cuenta
                    NombreUsuario = oUsuario.Nombre
                    Me.Close()
                    TextToSpeak("Bienvenido, " & NombreUsuario)
                    ObtenerEstilo()
                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Usuario o Password Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Forms.mdiPrincipal.Icon
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

End Class