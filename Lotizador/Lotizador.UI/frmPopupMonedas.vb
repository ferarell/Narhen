Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupMonedas
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _MonedaBE As MonedaBE
    Public Property MonedaBEEdit() As MonedaBE
        Get
            Return _MonedaBE
        End Get
        Set(ByVal value As MonedaBE)
            _MonedaBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmPopupMonedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Warning
        vpMonedas.SetValidationRule(Me.teCodigo, customValidationRule)
        vpMonedas.SetValidationRule(Me.teDescripcion, customValidationRule)
        If MonedaBEEdit.IdMoneda > 0 Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        If vpMonedas.Validate() Then
            Dim oMonedaBE As MonedaBE = New MonedaBE()
            If MonedaBEEdit.IdMoneda > 0 Then
                oMonedaBE = MonedaBEEdit
            End If
            oMonedaBE.CodigoMoneda = teCodigo.Text
            oMonedaBE.Descripcion = teDescripcion.Text
            If MonedaBEEdit.IdMoneda > 0 Then
                oMonedaBE.UsuarioModificacion = IdUsuario
                oMonedaBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarMoneda(oMonedaBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oMonedaBE.UsuarioCreacion = IdUsuario
                oMonedaBE.UsuarioModificacion = IdUsuario
                oMonedaBE.FechaCreacion = DateTime.Now
                oMonedaBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarMoneda(oMonedaBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub InicializarValoresEdicion()
        Me.teCodigo.Text = MonedaBEEdit.CodigoMoneda
        Me.teDescripcion.Text = MonedaBEEdit.Descripcion
        Me.teTextoImpresion.Text = MonedaBEEdit.TextoImpresion
    End Sub

End Class