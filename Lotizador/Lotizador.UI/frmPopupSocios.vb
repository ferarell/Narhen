Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupSocios
    Inherits DevExpress.XtraEditors.XtraForm


    Private _SocioBE As SocioBE
    Public Property SocioBEEdit() As SocioBE
        Get
            Return _SocioBE
        End Get
        Set(ByVal value As SocioBE)
            _SocioBE = value
        End Set
    End Property

    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PoblarTipoDocumento()
        Dim oTipoDocumentoBE As TipoDocumentoBE = New TipoDocumentoBE()
        oTipoDocumentoBE.Valorado = "N"
        Dim listTiposDocumento As List(Of TipoDocumentoBE) = New List(Of TipoDocumentoBE)(oNarhemService.ObtenerTipoDocumentoPorCriterio(oTipoDocumentoBE))
        Me.lueTipoDocumento.Properties.DataSource = listTiposDocumento
        Me.lueTipoDocumento.Properties.DisplayMember = "CodigoTipoDocumento"
        Me.lueTipoDocumento.Properties.ValueMember = "IdTipoDocumento"
    End Sub

    Private Sub PoblarTipoSocio()
        Dim oVariableBE As VariableBE = New VariableBE()
        oVariableBE.Nombre = "TipoSocio"
        Dim listTiposDocumento As List(Of VariableBE) = New List(Of VariableBE)(oNarhemService.ObtenerVariablePorCriterio(oVariableBE))
        Me.lueTipoSocio.Properties.DataSource = listTiposDocumento
        Me.lueTipoSocio.Properties.DisplayMember = "Descripcion"
        Me.lueTipoSocio.Properties.ValueMember = "Valor"
    End Sub


    Private Sub PoblarSexo()
        Dim oVariableBE As VariableBE = New VariableBE()
        oVariableBE.Nombre = "Sexo"
        Dim listTiposDocumento As List(Of VariableBE) = New List(Of VariableBE)(oNarhemService.ObtenerVariablePorCriterio(oVariableBE))
        Me.lueSexo.Properties.DataSource = listTiposDocumento
        Me.lueSexo.Properties.DisplayMember = "Descripcion"
        Me.lueSexo.Properties.ValueMember = "Valor"
    End Sub



    Private Sub PoblarDepartamento()
        Me.lueDepartamento.Properties.DataSource = Nothing
        Dim listDepartamentos As List(Of UbigeoBE) = New List(Of UbigeoBE)(oNarhemService.GetDepartamentos())
        Me.lueDepartamento.Properties.DataSource = listDepartamentos
        Me.lueDepartamento.Properties.DisplayMember = "NombreDepartamento"
        Me.lueDepartamento.Properties.ValueMember = "IdDepartamento"
    End Sub

    Private Sub PoblarProvincias()
        Me.lueProvincia.Properties.DataSource = Nothing
        Dim oUbigeoBE As UbigeoBE = New UbigeoBE()
        oUbigeoBE.IdDepartamento = Me.lueDepartamento.Properties.GetDataSourceValue("IdDepartamento", lueDepartamento.ItemIndex)
        Dim listProvincias As List(Of UbigeoBE) = New List(Of UbigeoBE)(oNarhemService.GetProvincias(oUbigeoBE))
        Me.lueProvincia.Properties.DataSource = listProvincias
        Me.lueProvincia.Properties.DisplayMember = "NombreProvincia"
        Me.lueProvincia.Properties.ValueMember = "IdProvincia"
    End Sub

    Private Sub PoblarDistritos()
        Me.lueDistrito.Properties.DataSource = Nothing
        Dim oUbigeoBE As UbigeoBE = New UbigeoBE()
        oUbigeoBE.IdDepartamento = Me.lueDepartamento.Properties.GetDataSourceValue("IdDepartamento", lueDepartamento.ItemIndex)
        oUbigeoBE.IdProvincia = Me.lueProvincia.Properties.GetDataSourceValue("IdProvincia", lueProvincia.ItemIndex)
        Dim listDistritos As List(Of UbigeoBE) = New List(Of UbigeoBE)(oNarhemService.GetDistritos(oUbigeoBE))
        Me.lueDistrito.Properties.DataSource = listDistritos
        Me.lueDistrito.Properties.DisplayMember = "NombreDistrito"
        Me.lueDistrito.Properties.ValueMember = "IdDistrito"
    End Sub

    Private Sub DFDetalleSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarTipoDocumento()
        PoblarTipoSocio()
        PoblarDepartamento()
        PoblarSexo()

        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Ingrese un valor"
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRuleEmail As New CustomValidationRuleEmail()
        customValidationRuleEmail.ErrorText = "Ingrese un email Valido"
        customValidationRuleEmail.ErrorType = ErrorType.Critical

        vpDetalleSocio.SetValidationRule(Me.txtNombre, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.txtApellidoPaterno, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.txtApellidoMaterno, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.txtNumeroDocumento, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.txtDireccion, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.txtCorreo, customValidationRuleEmail)
        vpDetalleSocio.SetValidationRule(Me.lueTipoSocio, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.lueSexo, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.lueTipoDocumento, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.lueDepartamento, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.lueProvincia, customValidationRule)
        vpDetalleSocio.SetValidationRule(Me.lueDistrito, customValidationRule)

        If SocioBEEdit.IdSocio > 0 Then
            InicializarValoresEdicion()
        End If

    End Sub

    Private Sub txtCorreo_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorreo.Leave, txtNombre.Leave, txtApellidoMaterno.Leave, txtApellidoPaterno.Leave, txtDireccion.Leave, txtNumeroDocumento.Leave
        vpDetalleSocio.Validate()
        If sender.name = txtNumeroDocumento.Name Then
            oGeneralBE.SqlTxt = "select NumeroDocumento from Socio where idTipoDocumento = " & Me.lueTipoDocumento.Properties.GetDataSourceValue("IdTipoDocumento", lueTipoDocumento.ItemIndex).ToString() & " and NumeroDocumento = '" & txtNumeroDocumento.Text & "' and Estado = 'A'"
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            If oGeneralBE.dtResult.Rows.Count > 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ya existe el número de documento ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox("Ya existe el número de documento ingresado.", MsgBoxStyle.Critical)
                txtNumeroDocumento.Focus()
            End If
        End If
    End Sub

    Private Sub lueDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepartamento.EditValueChanged
        PoblarProvincias()
    End Sub

    Private Sub lueProvincia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueProvincia.EditValueChanged
        PoblarDistritos()
    End Sub

    Public Sub InicializarValoresEdicion()
        txtNombre.Text = SocioBEEdit.Nombre
        Me.txtApellidoPaterno.Text = SocioBEEdit.ApellidoPaterno
        Me.txtApellidoMaterno.Text = SocioBEEdit.ApellidoMaterno
        Dim rTipoDocumento As Integer = Me.lueTipoDocumento.Properties.GetDataSourceRowIndex("IdTipoDocumento", SocioBEEdit.IdTipoDocumento)
        lueTipoDocumento.EditValue = Me.lueTipoDocumento.Properties.GetDataSourceValue(lueTipoDocumento.Properties.ValueMember, rTipoDocumento)
        Dim rTipoSocio As Integer = Me.lueTipoSocio.Properties.GetDataSourceRowIndex("Valor", SocioBEEdit.TipoSocio)
        lueTipoSocio.EditValue = Me.lueTipoSocio.Properties.GetDataSourceValue(lueTipoSocio.Properties.ValueMember, rTipoSocio)
        Dim rSexo As Integer = Me.lueSexo.Properties.GetDataSourceRowIndex("Valor", SocioBEEdit.Sexo)
        lueSexo.EditValue = Me.lueSexo.Properties.GetDataSourceValue(lueSexo.Properties.ValueMember, rSexo)
        Dim rDepartamento As Integer = Me.lueDepartamento.Properties.GetDataSourceRowIndex("IdDepartamento", SocioBEEdit.IdDepartamento)
        lueDepartamento.EditValue = Me.lueDepartamento.Properties.GetDataSourceValue(lueDepartamento.Properties.ValueMember, rDepartamento)
        Dim rProvincia As Integer = Me.lueProvincia.Properties.GetDataSourceRowIndex("IdProvincia", SocioBEEdit.IdProvincia)
        lueProvincia.EditValue = Me.lueProvincia.Properties.GetDataSourceValue(lueProvincia.Properties.ValueMember, rProvincia)
        Dim rDistrito As Integer = Me.lueDistrito.Properties.GetDataSourceRowIndex("IdDistrito", SocioBEEdit.IdDistrito)
        lueDistrito.EditValue = Me.lueDistrito.Properties.GetDataSourceValue(lueDistrito.Properties.ValueMember, rDistrito)
        Me.txtNumeroDocumento.Text = SocioBEEdit.NumeroDocumento
        Me.deFechaNacimiento.DateTime = SocioBEEdit.FechaNacimiento
        Me.txtCorreo.Text = SocioBEEdit.Correo
        Me.txtOcupacion.Text = SocioBEEdit.Ocupacion
        Me.txtMensajeria.Text = SocioBEEdit.Mensajeria
        Me.txtTelefonoMovil.Text = SocioBEEdit.TelefonoMovil
        Me.txtTelefonoOficina.Text = SocioBEEdit.TelefonoOficina
        Me.txtTelefonoDomicilio.Text = SocioBEEdit.TelefonoDomicilio
        Me.txtFax.Text = SocioBEEdit.Fax
        Me.txtDireccion.Text = SocioBEEdit.Direccion
        Me.txtReferencia.Text = SocioBEEdit.ReferenciaDireccion
    End Sub


    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        lueTipoSocio.Focus()
        If vpDetalleSocio.Validate() Then
            Dim oSocioBE As SocioBE = New SocioBE()
            If SocioBEEdit.IdSocio > 0 Then
                oSocioBE = SocioBEEdit
            End If
            oSocioBE.TipoSocio = Me.lueTipoSocio.Properties.GetDataSourceValue("Valor", lueTipoSocio.ItemIndex).ToString()
            oSocioBE.Sexo = Me.lueSexo.Properties.GetDataSourceValue("Valor", Me.lueSexo.ItemIndex).ToString()
            oSocioBE.Nombre = txtNombre.Text
            oSocioBE.ApellidoPaterno = Me.txtApellidoPaterno.Text
            oSocioBE.ApellidoMaterno = Me.txtApellidoMaterno.Text
            oSocioBE.IdTipoDocumento = Me.lueTipoDocumento.Properties.GetDataSourceValue("IdTipoDocumento", lueTipoDocumento.ItemIndex).ToString()
            oSocioBE.NumeroDocumento = Me.txtNumeroDocumento.Text
            oSocioBE.FechaNacimiento = IIf(deFechaNacimiento.Text <> "", Me.deFechaNacimiento.Text, Nothing)
            oSocioBE.Correo = Me.txtCorreo.Text
            oSocioBE.Ocupacion = Me.txtOcupacion.Text
            oSocioBE.Estado = "A"
            oSocioBE.Mensajeria = Me.txtMensajeria.Text
            oSocioBE.TelefonoMovil = Me.txtTelefonoMovil.Text
            oSocioBE.TelefonoOficina = Me.txtTelefonoOficina.Text
            oSocioBE.TelefonoDomicilio = Me.txtTelefonoDomicilio.Text
            oSocioBE.Fax = Me.txtFax.Text
            oSocioBE.IdUbigeo = Me.lueDistrito.Properties.GetDataSourceValue("IdUbigeo", lueDistrito.ItemIndex).ToString()
            oSocioBE.Direccion = Me.txtDireccion.Text
            oSocioBE.ReferenciaDireccion = Me.txtReferencia.Text
            If SocioBEEdit.IdSocio > 0 Then
                oSocioBE.UsuarioModificacion = IdUsuario
                oSocioBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarSocio(oSocioBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oSocioBE.UsuarioCreacion = IdUsuario
                oSocioBE.UsuarioModificacion = IdUsuario
                oSocioBE.FechaCreacion = DateTime.Now
                oSocioBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarSocio(oSocioBE) Then
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