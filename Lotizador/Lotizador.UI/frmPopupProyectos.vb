Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupProyectos
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _ProyectoBE As ProyectoBE
    Public Property ProyectoBEEdit() As ProyectoBE
        Get
            Return _ProyectoBE
        End Get
        Set(ByVal value As ProyectoBE)
            _ProyectoBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmPopupProyectos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarBancos()
        PoblarMonedas()
        PoblarDepartamento()
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

        vpProyectos.SetValidationRule(Me.teDescripcion, customValidationRule)
        vpProyectos.SetValidationRule(Me.teCantidadLotes, customValidationRule)
        vpProyectos.SetValidationRule(Me.lueBanco, customValidationRule)
        vpProyectos.SetValidationRule(Me.teCuentaCorriente, customValidationRule)
        vpProyectos.SetValidationRule(Me.lueMoneda, customValidationRule)
        vpProyectos.SetValidationRule(Me.lueDepartamento, customValidationRule)
        vpProyectos.SetValidationRule(Me.lueProvincia, customValidationRule)
        vpProyectos.SetValidationRule(Me.lueDistrito, customValidationRule)

        If ProyectoBEEdit.IdProyecto > 0 Then
            InicializarValoresEdicion()
        End If
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
        Me.lueProvincia.Properties.ValueMember = "IdUbigeo"
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

    Private Sub PoblarMonedas()
        Dim oMonedaBE As MonedaBE = New MonedaBE()
        Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)(oNarhemService.ObtenerMonedaPorCriterio(oMonedaBE))
        Me.lueMoneda.Properties.DataSource = listMonedas
        Me.lueMoneda.Properties.DisplayMember = "Descripcion"
        Me.lueMoneda.Properties.ValueMember = "IdMoneda"
    End Sub

    Private Sub PoblarBancos()
        Dim oBancoBE As BancoBE = New BancoBE()
        Dim listBancos As List(Of BancoBE) = New List(Of BancoBE)(oNarhemService.ObtenerBancoPorCriterio(oBancoBE))
        Me.lueBanco.Properties.DataSource = listBancos
        Me.lueBanco.Properties.DisplayMember = "Descripcion"
        Me.lueBanco.Properties.ValueMember = "IdBanco"
    End Sub

    Private Sub InicializarValoresEdicion()
        Me.teDescripcion.Text = ProyectoBEEdit.Descripcion
        Me.teCantidadLotes.Text = ProyectoBEEdit.CantidadLotes
        lueBanco.ItemIndex = lueBanco.Properties.GetDataSourceRowIndex("IdBanco", ProyectoBEEdit.IdBanco)
        Me.teCuentaCorriente.Text = ProyectoBEEdit.CuentaCorriente
        lueMoneda.ItemIndex = lueMoneda.Properties.GetDataSourceRowIndex("IdMoneda", ProyectoBEEdit.IdMoneda)
        teImporteMora.Text = ProyectoBEEdit.ImporteMora
        Me.teCodigoInterbancario.Text = ProyectoBEEdit.CodigoInterbancario
        Me.teArchivoPlantilla.Text = ProyectoBEEdit.ArchivoPlantilla
        lueDepartamento.ItemIndex = lueDepartamento.Properties.GetDataSourceRowIndex("IdDepartamento", ProyectoBEEdit.IdDepartamento)
        lueProvincia.ItemIndex = lueProvincia.Properties.GetDataSourceRowIndex("IdProvincia", ProyectoBEEdit.IdProvincia)
        lueDistrito.ItemIndex = lueDistrito.Properties.GetDataSourceRowIndex("IdUbigeo", ProyectoBEEdit.IdUbigeo)
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub teDescripcion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teDescripcion.Leave, teCantidadLotes.Leave, teCuentaCorriente.Leave, teImporteMora.Leave, lueBanco.Leave, lueMoneda.Leave, lueDepartamento.Leave, lueProvincia.Leave, lueDistrito.Leave, teCodigoInterbancario.Leave, teArchivoPlantilla.Leave
        vpProyectos.Validate()
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        teDescripcion.Focus()
        If vpProyectos.Validate() Then
            Dim oProyectoBE As ProyectoBE = New ProyectoBE()
            If ProyectoBEEdit.IdProyecto > 0 Then
                oProyectoBE = ProyectoBEEdit
            End If
            oProyectoBE.Descripcion = teDescripcion.Text
            oProyectoBE.CantidadLotes = teCantidadLotes.Text
            oProyectoBE.IdBanco = Me.lueBanco.Properties.GetDataSourceValue("IdBanco", lueBanco.ItemIndex).ToString()
            oProyectoBE.CuentaCorriente = teCuentaCorriente.Text
            oProyectoBE.IdMoneda = Me.lueMoneda.Properties.GetDataSourceValue("IdMoneda", lueMoneda.ItemIndex).ToString()
            oProyectoBE.ImporteMora = teImporteMora.Text
            oProyectoBE.CodigoInterbancario = Me.teCodigoInterbancario.Text
            oProyectoBE.ArchivoPlantilla = Me.teArchivoPlantilla.Text
            oProyectoBE.IdUbigeo = Me.lueDistrito.Properties.GetDataSourceValue("IdUbigeo", lueDistrito.ItemIndex).ToString()
            If ProyectoBEEdit.IdProyecto > 0 Then
                oProyectoBE.UsuarioModificacion = IdUsuario
                oProyectoBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarProyecto(oProyectoBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oProyectoBE.UsuarioCreacion = IdUsuario
                oProyectoBE.UsuarioModificacion = IdUsuario
                oProyectoBE.FechaCreacion = DateTime.Now
                oProyectoBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarProyecto(oProyectoBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lueDepartamento_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepartamento.EditValueChanged
        PoblarProvincias()
    End Sub

    Private Sub lueProvincia_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueProvincia.EditValueChanged
        PoblarDistritos()
    End Sub

End Class