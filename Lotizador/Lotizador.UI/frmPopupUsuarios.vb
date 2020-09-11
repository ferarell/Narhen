Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupUsuarios
    Inherits DevExpress.XtraEditors.XtraForm


    Private _UsuarioBE As UsuarioBE
    Public Property oUsuarioBEEdit() As UsuarioBE
        Get
            Return _UsuarioBE
        End Get
        Set(ByVal value As UsuarioBE)
            _UsuarioBE = value
        End Set
    End Property

    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub DFDetalleSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        txtPassword.Properties.UseSystemPasswordChar = True
        txtPassword.Properties.PasswordChar = "X"
        Me.txtConfirmarPassword.Properties.UseSystemPasswordChar = True
        txtConfirmarPassword.Properties.PasswordChar = "X"


        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Warning


        Dim customValidationRuleEmail As New CustomValidationRuleEmail()
        customValidationRuleEmail.ErrorText = "Ingrese un email Valido"
        customValidationRuleEmail.ErrorType = ErrorType.Warning


        Dim compValidationRule As CompareAgainstControlValidationRule = New CompareAgainstControlValidationRule()
        compValidationRule.Control = Me.txtPassword
        compValidationRule.CompareControlOperator = CompareControlOperator.Equals
        compValidationRule.ErrorText = "Valores Ingresados deben ser iguales"
        compValidationRule.CaseSensitive = True




        vpUsuarios.SetValidationRule(Me.txtNombre, customValidationRule)
        vpUsuarios.SetValidationRule(Me.txtCuenta, customValidationRule)
        vpUsuarios.SetValidationRule(Me.txtDescripcion, customValidationRule)
        vpUsuarios.SetValidationRule(Me.txtPassword, customValidationRule)
        vpUsuarios.SetValidationRule(Me.txtCorreo, customValidationRuleEmail)
        vpUsuarios.SetValidationRule(Me.txtConfirmarPassword, compValidationRule)



        If oUsuarioBEEdit.IdUsuario > 0 Then
            InicializarValoresEdicion()
        End If

    End Sub

    Private Sub txtCorreo_leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vpUsuarios.Validate()
    End Sub


    Private Sub txtNombre_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.Leave
        vpUsuarios.Validate()
    End Sub

    Private Sub txtConfirmarPassword_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmarPassword.Leave
        vpUsuarios.Validate()
    End Sub



    Private Sub txtNumeroDocumento_leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vpUsuarios.Validate()
    End Sub


    Private Sub txtDireccion_leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vpUsuarios.Validate()
    End Sub

    Private Sub txtReferencia_leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        vpUsuarios.Validate()
    End Sub




    Public Sub InicializarValoresEdicion()
        Dim oCriptologia As Criptologia = New Criptologia()
        txtNombre.Text = oUsuarioBEEdit.Nombre

        Me.txtCorreo.Text = oUsuarioBEEdit.Correo
        txtCuenta.Text = oUsuarioBEEdit.Cuenta

        txtDescripcion.Text = oUsuarioBEEdit.Descripcion



        Me.txtConfirmarPassword.Text = oCriptologia.DesencriptarTexto(oUsuarioBEEdit.Password)



        txtPassword.Text = oCriptologia.DesencriptarTexto(oUsuarioBEEdit.Password)


        Me.ceActivo.EditValue = oUsuarioBEEdit.Activo
        Me.chkPedirCambioPwd.EditValue = oUsuarioBEEdit.FlgCambioPwd




    End Sub


    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        txtCuenta.Focus()
        Dim oCriptologia As Criptologia = New Criptologia()
        If vpUsuarios.Validate() Then
            Dim oUsuarioBE As UsuarioBE = New UsuarioBE()
            If oUsuarioBEEdit.IdUsuario > 0 Then
                oUsuarioBE = oUsuarioBEEdit
            End If


            oUsuarioBE.Cuenta = txtCuenta.Text
            oUsuarioBE.Nombre = txtNombre.Text
            oUsuarioBE.Descripcion = txtDescripcion.Text
            oUsuarioBE.Password = oCriptologia.EncriptarTexto(txtPassword.Text)
            oUsuarioBE.Correo = Me.txtCorreo.Text
            oUsuarioBE.LookAndFeel = "Default"
            oUsuarioBE.Activo = Me.ceActivo.EditValue
            oUsuarioBE.FlgCambioPwd = Me.chkPedirCambioPwd.EditValue

            If oUsuarioBEEdit.IdUsuario > 0 Then
                oUsuarioBE.UsuarioModificacion = IdUsuario
                oUsuarioBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarUsuario(oUsuarioBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oUsuarioBE.UsuarioCreacion = IdUsuario
                oUsuarioBE.UsuarioModificacion = IdUsuario
                oUsuarioBE.FechaCreacion = DateTime.Now
                oUsuarioBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarUsuario(oUsuarioBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub





End Class