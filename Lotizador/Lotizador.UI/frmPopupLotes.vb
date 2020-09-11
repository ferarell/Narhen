Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPopupLotes
    Inherits DevExpress.XtraEditors.XtraForm
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _LoteBE As LoteBE
    Public Property LoteBEEdit() As LoteBE
        Get
            Return _LoteBE
        End Get
        Set(ByVal value As LoteBE)
            _LoteBE = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmPopupLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()

        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()

        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Ingrese un valor"
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical

        vpLotes.SetValidationRule(Me.teDescripcion, customValidationRule)
        vpLotes.SetValidationRule(Me.lueProyecto, customValidationRule)
        vpLotes.SetValidationRule(Me.teSuperficie, customValidationRule)
        vpLotes.SetValidationRule(Me.teManzana, customValidationRule)
        vpLotes.SetValidationRule(Me.teImporteM2, customValidationRule)
        vpLotes.SetValidationRule(Me.teImporteDescuento, customValidationRule)
        vpLotes.SetValidationRule(Me.teImporteLote, customValidationRule)

        If LoteBEEdit.IdProyecto > 0 Then
            InicializarValoresEdicion()
        End If
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub PoblarUnidadesCatastrales()
        oGeneralBE.SqlTxt = "SELECT IdUnidadCatastral, Descripcion FROM UnidadCatastral WHERE IdProyecto = " & Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Me.lueUnidadCatastral.Properties.DataSource = oGeneralBE.dtResult
        Me.lueUnidadCatastral.Properties.DisplayMember = "Descripcion"
        Me.lueUnidadCatastral.Properties.ValueMember = "IdUnidadCatastral"
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub InicializarValoresEdicion()
        Me.teDescripcion.Text = LoteBEEdit.Descripcion
        Me.lueProyecto.ItemIndex = lueProyecto.Properties.GetDataSourceRowIndex("IdProyecto", LoteBEEdit.IdProyecto)
        Me.lueUnidadCatastral.ItemIndex = lueUnidadCatastral.Properties.GetDataSourceRowIndex("IdUnidadCatastral", LoteBEEdit.IdUnidadCatastral)
        Me.teSuperficie.Text = LoteBEEdit.Superficie
        Me.teManzana.Text = LoteBEEdit.Manzana
        Me.teLinderoFrente.Text = LoteBEEdit.LinderoFrente
        Me.teLongitudLinderoFrente.Text = LoteBEEdit.LongitudLinderoFrente
        Me.teLinderoDerecha.Text = LoteBEEdit.LinderoDerecha
        Me.teLongitudLinderoDerecha.Text = LoteBEEdit.LongitudLinderoDerecha
        Me.teLinderoIzquierda.Text = LoteBEEdit.LinderoIzquierda
        Me.teLongitudLinderoIzquierda.Text = LoteBEEdit.LongitudLinderoIzquierda
        Me.teLinderoFondo.Text = LoteBEEdit.LinderoFondo
        Me.teLongitudLinderoFondo.Text = LoteBEEdit.LongitudLinderoFondo
        Me.teImporteM2.Text = LoteBEEdit.ImporteM2
        Me.teImporteDescuento.Text = LoteBEEdit.ImporteDescuento
        Me.teImporteLote.Text = LoteBEEdit.ImporteLote
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        Try
            lueProyecto.Focus()
            If vpLotes.Validate() Then
                Dim oLoteBE As LoteBE = New LoteBE()
                If LoteBEEdit.IdLote > 0 Then
                    oLoteBE = LoteBEEdit
                End If
                oLoteBE.Descripcion = teDescripcion.Text
                oLoteBE.IdProyecto = Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString()
                oLoteBE.IdUnidadCatastral = Me.lueUnidadCatastral.Properties.GetDataSourceValue("IdUnidadCatastral", lueUnidadCatastral.ItemIndex).ToString()
                oLoteBE.Superficie = teSuperficie.Text
                oLoteBE.Manzana = teManzana.Text
                oLoteBE.LinderoFrente = teLinderoFrente.Text
                oLoteBE.LongitudLinderoFrente = teLongitudLinderoFrente.Text
                oLoteBE.LinderoDerecha = teLinderoDerecha.Text
                oLoteBE.LongitudLinderoDerecha = teLongitudLinderoDerecha.Text
                oLoteBE.LinderoIzquierda = teLinderoIzquierda.Text
                oLoteBE.LongitudLinderoIzquierda = teLongitudLinderoIzquierda.Text
                oLoteBE.LinderoFondo = teLinderoFondo.Text
                oLoteBE.LongitudLinderoFondo = teLongitudLinderoFondo.Text
                oLoteBE.ImporteM2 = teImporteM2.Text
                oLoteBE.ImporteDescuento = teImporteDescuento.Text
                oLoteBE.ImporteLote = teImporteLote.Text
                If LoteBEEdit.IdLote > 0 Then
                    oLoteBE.UsuarioModificacion = IdUsuario
                    oLoteBE.FechaModificacion = DateTime.Now
                    If oNarhemService.ActualizarLote(oLoteBE) Then
                        Me.DialogResult = DialogResult.OK
                    End If
                Else
                    oLoteBE.UsuarioCreacion = IdUsuario
                    oLoteBE.UsuarioModificacion = IdUsuario
                    oLoteBE.FechaCreacion = DateTime.Now
                    oLoteBE.FechaModificacion = DateTime.Now
                    If oNarhemService.InsertarLote(oLoteBE) Then
                        Me.DialogResult = DialogResult.OK
                    End If
                End If
                Me.Close()
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Corregir Errores", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            'SaveErrorException(ex, Me.Name)
        End Try
    End Sub

    Private Sub teDescripcion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teDescripcion.Leave, teSuperficie.Leave, teManzana.Leave, teLinderoFrente.Leave, teLinderoDerecha.Leave, teLinderoIzquierda.Leave, teLinderoFondo.Leave, teImporteLote.Leave, teLongitudLinderoDerecha.Leave, teLongitudLinderoFrente.Leave, teImporteM2.Leave, teImporteDescuento.Leave, teLongitudLinderoFondo.Leave, teLongitudLinderoIzquierda.Leave
        'vpLotes.Validate()
        lcCodigoMoneda.Text = LoteBEEdit.CodigoMoneda
        teImporteLote.Text = (CType(teSuperficie.Text, Double) * CType(teImporteM2.Text, Double)) - CType(teImporteDescuento.Text, Double)
        If sender.name = lueProyecto.Name Then
            BarStaticItem1.Caption = ""
            oGeneralBE.SqlTxt = "EXEC upLotesDisponiblesPorProyecto " & Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString()
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            If oGeneralBE.dtResult.Rows.Count > 0 Then
                If oGeneralBE.dtResult.Rows(0).Item("CantidadLotes") - oGeneralBE.dtResult.Rows(0).Item("LotesAsignados") = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ya no hay lotes disponibles para asignar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'MsgBox("Ya no hay lotes disponibles para asignar.", MsgBoxStyle.Critical)
                    lueProyecto.Focus()
                Else
                    BarStaticItem1.Caption = "Quedan " & oGeneralBE.dtResult.Rows(0).Item("CantidadLotes") - oGeneralBE.dtResult.Rows(0).Item("LotesAsignados") & " lotes disponibles para asignar."
                End If
            End If
        End If
        If sender.name = teDescripcion.Name Or sender.name = teManzana.Name Then
            oGeneralBE.SqlTxt = "select IdLote from Lote where IdProyecto = " & Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString() & " and Manzana = '" & teManzana.Text & "' and Descripcion = '" & teDescripcion.Text & "'"
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            If oGeneralBE.dtResult.Rows.Count > 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Ya existe la Manzana y Lote ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'MsgBox("Ya existe la Manzana y Lote ingresados.", MsgBoxStyle.Critical)
                sender.focus()
            End If
        End If
    End Sub

    Private Sub lueProyecto_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueProyecto.EditValueChanged
        PoblarUnidadesCatastrales()
    End Sub
End Class