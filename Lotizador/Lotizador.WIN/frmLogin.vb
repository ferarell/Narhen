Imports Lotizador.BE
Imports Lotizador.BL

Public Class frmLogin

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Cursor = Cursors.WaitCursor
        Try
            If Me.txtUsuario.Text.Trim <> "" And Me.txtPassword.Text.Trim <> "" Then
                Try
                    Dim oUsuario As New UsuarioBE()
                    Dim oUsuarioBL As New UsuarioBL()

                    Dim cuenta As String = Me.txtUsuario.Text.Trim
                    Dim password As String = Me.txtPassword.Text.Trim
                    oUsuario = oUsuarioBL.ObtenerUsuario(cuenta)
                    If Not oUsuario Is Nothing Then
                        Dim oCriptologia As Criptologia = New Criptologia()
                        Dim strPswdesencriptado As String = oCriptologia.DesencriptarTexto(oUsuario.password)
                        If txtPassword.Text <> "" And strPswdesencriptado = Me.txtPassword.Text Then
                            Funciones.USUARIO = oUsuario.cuenta
                            Dim myForm As New mdiPrincipal
                            myForm.Show()
                            Me.Hide()
                            'Application.Run(mdiPrincipal)
                        Else
                            MessageBox.Show("Contraseña incorrecta", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("Error al acceder a la Base de Datos", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Debe ingresar Usuario y Password", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Default
    End Sub
End Class