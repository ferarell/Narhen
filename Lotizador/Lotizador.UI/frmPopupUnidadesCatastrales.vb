Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupUnidadesCatastrales
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _UnidadCatastralBE As UnidadCatastralBE

    Public Property UnidadCatastralBEEdit() As UnidadCatastralBE
        Get
            Return _UnidadCatastralBE
        End Get
        Set(ByVal value As UnidadCatastralBE)
            _UnidadCatastralBE = value
        End Set
    End Property

    Private Sub frmPopupUnidadesCatastrales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical
        vpUnidadesCatastrales.SetValidationRule(Me.teDescripcion, customValidationRule)
        vpUnidadesCatastrales.SetValidationRule(Me.lueProyecto, customValidationRule)
        vpUnidadesCatastrales.SetValidationRule(Me.teSuperficie, customValidationRule)
        vpUnidadesCatastrales.SetValidationRule(Me.tePartidaRegistral, customValidationRule)
        vpUnidadesCatastrales.SetValidationRule(Me.meRegistroPredial, customValidationRule)
        vpUnidadesCatastrales.SetValidationRule(Me.meDenominacion, customValidationRule)
        If UnidadCatastralBEEdit.IdUnidadCatastral > 0 Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub InicializarValoresEdicion()
        Me.teDescripcion.Text = UnidadCatastralBEEdit.Descripcion
        Me.lueProyecto.ItemIndex = lueProyecto.Properties.GetDataSourceRowIndex("IdProyecto", UnidadCatastralBEEdit.IdProyecto)
        Me.teSuperficie.Text = UnidadCatastralBEEdit.Superficie
        Me.tePartidaRegistral.Text = UnidadCatastralBEEdit.PartidaRegistral
        Me.meRegistroPredial.Text = UnidadCatastralBEEdit.RegistroPredial
        Me.meDenominacion.Text = UnidadCatastralBEEdit.Denominacion
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        teDescripcion.Focus()
        If vpUnidadesCatastrales.Validate() Then
            Dim oUnidadCatastralBE As UnidadCatastralBE = New UnidadCatastralBE()
            If UnidadCatastralBEEdit.IdUnidadCatastral > 0 Then
                oUnidadCatastralBE = UnidadCatastralBEEdit
            End If
            oUnidadCatastralBE.IdProyecto = Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString()
            oUnidadCatastralBE.Descripcion = Me.teDescripcion.Text
            oUnidadCatastralBE.Superficie = Me.teSuperficie.Text
            oUnidadCatastralBE.PartidaRegistral = Me.tePartidaRegistral.Text
            oUnidadCatastralBE.RegistroPredial = Me.meRegistroPredial.Text
            oUnidadCatastralBE.Denominacion = Me.meDenominacion.Text
            If UnidadCatastralBEEdit.IdUnidadCatastral > 0 Then
                oUnidadCatastralBE.UsuarioModificacion = IdUsuario
                oUnidadCatastralBE.FechaModificacion = DateTime.Now
                If oNarhemService.ActualizarUnidadCatastral(oUnidadCatastralBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                oUnidadCatastralBE.UsuarioCreacion = IdUsuario
                oUnidadCatastralBE.UsuarioModificacion = IdUsuario
                oUnidadCatastralBE.FechaCreacion = DateTime.Now
                oUnidadCatastralBE.FechaModificacion = DateTime.Now
                If oNarhemService.InsertarUnidadCatastral(oUnidadCatastralBE) Then
                    Me.DialogResult = DialogResult.OK
                End If
            End If
            Me.Close()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub teDescripcion_Leave(sender As System.Object, e As System.EventArgs) Handles teDescripcion.Leave, lueProyecto.Leave, teSuperficie.Leave, tePartidaRegistral.Leave, meRegistroPredial.Leave, meDenominacion.Leave
        vpUnidadesCatastrales.Validate()
    End Sub
End Class