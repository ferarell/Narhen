Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupSecuencias
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _SecuenciaBE As SecuenciaBE
    Public Property SecuenciaBEEdit() As SecuenciaBE
        Get
            Return _SecuenciaBE
        End Get
        Set(ByVal value As SecuenciaBE)
            _SecuenciaBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PoblarTipoDocumento()
        Dim oTipoDocumentoBE As TipoDocumentoBE = New TipoDocumentoBE()
        oTipoDocumentoBE.Valorado = "S"
        Dim listTiposDocumento As List(Of TipoDocumentoBE) = New List(Of TipoDocumentoBE)(oNarhemService.ObtenerTipoDocumentoPorCriterio(oTipoDocumentoBE))
        Me.lueTipoDocumento.Properties.DataSource = listTiposDocumento
        Me.lueTipoDocumento.Properties.DisplayMember = "Descripcion"
        Me.lueTipoDocumento.Properties.ValueMember = "IdTipoDocumento"
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub frmPopupSecuencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()
        PoblarTipoDocumento()

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

        vpSecuencias.SetValidationRule(Me.lueProyecto, customValidationRule)
        vpSecuencias.SetValidationRule(Me.lueTipoDocumento, customValidationRule)
        vpSecuencias.SetValidationRule(Me.teSerie, customValidationRule)
        vpSecuencias.SetValidationRule(Me.teNumeroInicial, customValidationRule)
        vpSecuencias.SetValidationRule(Me.teNumeroFinal, customValidationRule)
        vpSecuencias.SetValidationRule(Me.teUltimoNumero, customValidationRule)

        If SecuenciaBEEdit.IdProyecto > 0 Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub InicializarValoresEdicion()
        Me.lueProyecto.ItemIndex = lueProyecto.Properties.GetDataSourceRowIndex("IdProyecto", SecuenciaBEEdit.IdProyecto)
        Me.lueTipoDocumento.ItemIndex = lueTipoDocumento.Properties.GetDataSourceRowIndex("IdTipoDocumento", SecuenciaBEEdit.IdTipoDocumento)
        Me.teSerie.Text = SecuenciaBEEdit.SerieDocumento
        Me.teNumeroInicial.Text = SecuenciaBEEdit.NumeroDocumentoInicial
        Me.teNumeroFinal.Text = SecuenciaBEEdit.NumeroDocumentoFinal
        Me.teUltimoNumero.Text = SecuenciaBEEdit.NumeroDocumentoCorriente
        Me.ToggleSwitch1.EditValue = SecuenciaBEEdit.Estado
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        lueProyecto.Focus()
        If vpSecuencias.Validate() Then
            Dim oSecuenciaBE As SecuenciaBE = New SecuenciaBE()
            If SecuenciaBEEdit.IdSecuencia > 0 Then
                oSecuenciaBE = SecuenciaBEEdit
            End If
            oSecuenciaBE.IdProyecto = lueProyecto.EditValue
            oSecuenciaBE.IdTipoDocumento = lueTipoDocumento.EditValue
            oSecuenciaBE.SerieDocumento = Me.teSerie.Text
            oSecuenciaBE.NumeroDocumentoInicial = teNumeroInicial.Text
            oSecuenciaBE.NumeroDocumentoFinal = teNumeroFinal.Text
            oSecuenciaBE.NumeroDocumentoCorriente = teUltimoNumero.Text
            oSecuenciaBE.Estado = ToggleSwitch1.EditValue
            If SecuenciaBEEdit.IdSecuencia > 0 Then
                oSecuenciaBE.UsuarioModificacion = IdUsuario
                oSecuenciaBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarSecuencia(oSecuenciaBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oSecuenciaBE.UsuarioCreacion = IdUsuario
                oSecuenciaBE.UsuarioModificacion = IdUsuario
                oSecuenciaBE.FechaCreacion = DateTime.Now
                oSecuenciaBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarSecuencia(oSecuenciaBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub lueProyecto_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueProyecto.Leave, lueTipoDocumento.Leave, teSerie.Leave, teNumeroInicial.Leave, teNumeroFinal.Leave, teUltimoNumero.Leave
        vpSecuencias.Validate()
        If sender.name = teUltimoNumero.Name Then
            oGeneralBE.SqlTxt = "upObtenerUltimoNumeroDocumento " & Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString() & ", " & Me.lueTipoDocumento.Properties.GetDataSourceValue("IdTipoDocumento", lueTipoDocumento.ItemIndex).ToString()
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            If oGeneralBE.dtResult.Rows.Count > 0 Then
                If teUltimoNumero.Text < oGeneralBE.dtResult.Rows(0).Item("UltimoNumeroDocumento") Then
                    Dim msg As String = "No puede asignar un número menor a " & oGeneralBE.dtResult.Rows(0).Item("UltimoNumeroDocumento").ToString
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'MsgBox(msg, MsgBoxStyle.Critical)
                    sender.focus()
                End If
            End If
        End If
    End Sub
End Class