Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupTiposCambio
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _MonedaTipoCambioBE As MonedaTipoCambioBE
    Public Property oMonedaTipoCambioBEEdit() As MonedaTipoCambioBE
        Get
            Return _MonedaTipoCambioBE
        End Get
        Set(ByVal value As MonedaTipoCambioBE)
            _MonedaTipoCambioBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmPopupTiposCambio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PoblarMonedas()
        deFechaReferencia.DateTime = Date.Now

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRuleEmail As New CustomValidationRuleEmail()
        customValidationRuleEmail.ErrorText = "Ingrese un email Valido"
        customValidationRuleEmail.ErrorType = ErrorType.Critical

        vpTiposCambio.SetValidationRule(Me.lueMoneda, customValidationRule)
        vpTiposCambio.SetValidationRule(Me.deFechaReferencia, customValidationRule)
        vpTiposCambio.SetValidationRule(Me.txtTcLocal, customValidationRule)
        vpTiposCambio.SetValidationRule(Me.txtTcDolar, customValidationRule)

        If oMonedaTipoCambioBEEdit.IdMoneda > 0 Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub PoblarMonedas()
        Dim oMonedaBE As MonedaBE = New MonedaBE()
        Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)(oNarhemService.ObtenerMonedaPorCriterio(oMonedaBE))
        Me.lueMoneda.Properties.DataSource = listMonedas
        Me.lueMoneda.Properties.DisplayMember = "Descripcion"
        Me.lueMoneda.Properties.ValueMember = "IdMoneda"
    End Sub

    Private Sub bbiGrabar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        Try
            lueMoneda.Focus()
            If vpTiposCambio.Validate() Then
                Dim oMonedaTipoCambioBE As MonedaTipoCambioBE = New MonedaTipoCambioBE()
                If oMonedaTipoCambioBEEdit.IdMoneda > 0 Then
                    oMonedaTipoCambioBE = oMonedaTipoCambioBEEdit
                End If
                oMonedaTipoCambioBE.IdMoneda = Me.lueMoneda.Properties.GetDataSourceValue("IdMoneda", lueMoneda.ItemIndex).ToString()
                oMonedaTipoCambioBE.FechaReferencia = Me.deFechaReferencia.EditValue
                oMonedaTipoCambioBE.TcLocalV = Convert.ToDecimal(Me.txtTcLocal.Text)
                oMonedaTipoCambioBE.TcDolarV = Convert.ToDecimal(Me.txtTcDolar.Text)
                oMonedaTipoCambioBE.TcLocalC = Convert.ToDecimal(Me.txtTcLocal.Text)
                oMonedaTipoCambioBE.TcDolarC = Convert.ToDecimal(Me.txtTcDolar.Text)
                
                If oMonedaTipoCambioBEEdit.IdMoneda > 0 Then
                    oMonedaTipoCambioBE.UsuarioModificacion = IdUsuario
                    oMonedaTipoCambioBE.FechaModificacion = DateTime.Now
                    If oNarhemService.ActualizarMonedaTipoCambio(oMonedaTipoCambioBE) Then
                        Me.DialogResult = DialogResult.OK
                    End If
                Else
                    oMonedaTipoCambioBE.UsuarioCreacion = IdUsuario
                    oMonedaTipoCambioBE.UsuarioModificacion = IdUsuario
                    oMonedaTipoCambioBE.FechaCreacion = DateTime.Now
                    oMonedaTipoCambioBE.FechaModificacion = DateTime.Now
                    If oNarhemService.InsertarMonedaTipoCambio(oMonedaTipoCambioBE) Then

                        Me.DialogResult = DialogResult.OK
                    End If
                End If
                Me.Close()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InicializarValoresEdicion()
        Dim rMoneda As Integer = Me.lueMoneda.Properties.GetDataSourceRowIndex("IdMoneda", oMonedaTipoCambioBEEdit.IdMoneda)
        lueMoneda.EditValue = Me.lueMoneda.Properties.GetDataSourceValue(lueMoneda.Properties.ValueMember, rMoneda)
        Me.deFechaReferencia.EditValue = oMonedaTipoCambioBEEdit.FechaReferencia
        Me.txtTcLocal.Text = oMonedaTipoCambioBEEdit.TcLocalV
        Me.txtTcDolar.Text = oMonedaTipoCambioBEEdit.TcDolarV
    End Sub


    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub
End Class