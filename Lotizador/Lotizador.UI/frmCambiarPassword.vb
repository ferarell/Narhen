Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider
Public Class frmCambiarPassword

    Private _oUsuarioBE As UsuarioBE
    Public Property oUsuarioBE() As UsuarioBE
        Get
            Return _oUsuarioBE
        End Get
        Set(ByVal value As UsuarioBE)
            _oUsuarioBE = value
        End Set
    End Property


    Dim oNarhemService As NarhenClient = New NarhenClient()
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oUsuarioEdit As UsuarioBE = New UsuarioBE()
        oUsuarioEdit.Cuenta = Me.txtUsuario.Text.Trim()
        Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)(oNarhemService.ObtenerUsuarioPorCriterio(oUsuarioEdit))
        Dim oCriptologia As Criptologia = New Criptologia()
        If listUsuarios.Count > 0 Then
            oUsuarioEdit = listUsuarios(0)
        End If

        If vpCambiarPassword.Validate() Then

            Dim strPswdesencriptado As String = oCriptologia.DesencriptarTexto(oUsuarioEdit.Password)
            If strPswdesencriptado = Me.txtPassword.Text Then
                oUsuarioEdit.Password = oCriptologia.EncriptarTexto(Me.txtNuevoPassword.Text)
                oUsuarioEdit.UsuarioModificacion = oUsuarioEdit.IdUsuario
                oUsuarioEdit.FechaModificacion = DateTime.Now


                If oNarhemService.ActualizarPassword(oUsuarioEdit) Then
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "No se pudo Actualizar Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

        'Dim oUsuario As UsuarioBE = New UsuarioBE()
        'oUsuario.Cuenta = Me.txtUsuario.Text.Trim()
        'Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)(oNarhemService.ObtenerUsuarioPorCriterio(oUsuario))
        'Dim oCriptologia As Criptologia = New Criptologia()
        'If listUsuarios.Count > 0 Then
        '    oUsuario = listUsuarios(0)
        'End If

        'Dim strPswdesencriptado As String = oCriptologia.DesencriptarTexto(oUsuario.Password)
        'If strPswdesencriptado = Me.txtPassword.Text Then
        '    Dim myForm As New mdiPrincipal
        '    myForm.Show()
        '    Me.Close()
        'Else
        '    DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Usuario o Password Incorrectos")
        'End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Public Sub InicializarValoresCambio()
        Dim oCriptologia As Criptologia = New Criptologia()
        Me.txtUsuario.Text = oUsuarioBE.Cuenta
        Me.txtPassword.Text = oCriptologia.DesencriptarTexto(oUsuarioBE.Password)

    End Sub

    
    Private Sub frmCambiarPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim customValidationRule As New CustomValidationRule()
        CustomValidationRule.ErrorText = "Valor Obligatorio"
        CustomValidationRule.ErrorType = ErrorType.Warning



        Dim compValidationRule As CompareAgainstControlValidationRule = New CompareAgainstControlValidationRule()
        compValidationRule.Control = Me.txtNuevoPassword
        compValidationRule.CompareControlOperator = CompareControlOperator.Equals
        compValidationRule.ErrorText = "Valores Ingresados deben ser iguales"
        compValidationRule.CaseSensitive = True




        vpCambiarPassword.SetValidationRule(Me.txtUsuario, customValidationRule)
        vpCambiarPassword.SetValidationRule(Me.txtPassword, customValidationRule)
        vpCambiarPassword.SetValidationRule(Me.txtNuevoPassword, customValidationRule)
        vpCambiarPassword.SetValidationRule(Me.txtCopiaNuevoPassword, compValidationRule)



        If oUsuarioBE.IdUsuario > 0 Then
            InicializarValoresCambio()
        End If

    End Sub

    Private Sub txtUsuario_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.Leave
        vpCambiarPassword.Validate()
    End Sub
    Private Sub txtPassword_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        vpCambiarPassword.Validate()
    End Sub
    Private Sub txtNuevoPassword_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNuevoPassword.Leave
        vpCambiarPassword.Validate()
    End Sub
    Private Sub txtRepetirNuevoPassword_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopiaNuevoPassword.Leave
        vpCambiarPassword.Validate()
    End Sub

End Class