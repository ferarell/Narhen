Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Public Class frmPopupContratos
    Inherits DevExpress.XtraEditors.XtraForm

    Private _ContratoBE As ContratoBE
    Public Property oContratoBEEdit() As ContratoBE
        Get
            Return _ContratoBE
        End Get
        Set(ByVal value As ContratoBE)
            _ContratoBE = value
        End Set
    End Property

    Dim oNarhemService As NarhenClient = New NarhenClient()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PoblarLote()
        Dim IdProyecto As String = Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex)
        Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)(oNarhemService.ObtenerLotesDisponibles(IdProyecto, oContratoBEEdit.IdLote))
        Me.lueLote.Properties.DataSource = listLotes
        Me.lueLote.Properties.DisplayMember = "Descripcion"
        Me.lueLote.Properties.ValueMember = "IdLote"
    End Sub

    Private Sub PoblarSocios()
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "EXEC upObtenerSociosPorContrato " & _ContratoBE.IdContrato.ToString
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        oContratoBEEdit.dtSocios = oGeneralBE.dtResult
        oContratoBEEdit.dtSocios.Columns("Nombres").ReadOnly = False
        Me.gcSocios.DataSource = oContratoBEEdit.dtSocios
    End Sub

    Private Sub PoblarPrincipal()
        Dim oVariableBE As VariableBE = New VariableBE()
        oVariableBE.Nombre = "Principal"
        Dim listPrincipal As List(Of VariableBE) = New List(Of VariableBE)(oNarhemService.ObtenerVariablePorCriterio(oVariableBE))
        Me.luePrincipal.DataSource = listPrincipal
        Me.luePrincipal.DisplayMember = "Descripcion"
        Me.luePrincipal.ValueMember = "Valor"
    End Sub

    Private Sub DFDetalleContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()
        PoblarSocios()
        PoblarMonedas()
        PoblarPrincipal()

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

        vpDetalleContrato.SetValidationRule(Me.lueLote, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.txtNumeroCuotas, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.txtValorCuotas, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.lueMoneda, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.deFechaEmision, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.deFechaInicio, customValidationRule)
        vpDetalleContrato.SetValidationRule(Me.txtDiaPago, customValidationRule)

        If oContratoBEEdit.IdContrato > 0 Then
            InicializarValoresEdicion()
            PoblarSocios()
        End If

    End Sub

    Public Sub InicializarValoresEdicion()
        Dim rProyecto As Integer = Me.lueProyecto.Properties.GetDataSourceRowIndex("IdProyecto", oContratoBEEdit.IdProyecto)
        lueProyecto.EditValue = Me.lueProyecto.Properties.GetDataSourceValue(lueProyecto.Properties.ValueMember, rProyecto)
        Dim rLote As Integer = Me.lueLote.Properties.GetDataSourceRowIndex("IdLote", oContratoBEEdit.IdLote)
        lueLote.EditValue = Me.lueLote.Properties.GetDataSourceValue(lueLote.Properties.ValueMember, rLote)
        Dim rMoneda As Integer = Me.lueMoneda.Properties.GetDataSourceRowIndex("IdMoneda", oContratoBEEdit.IdMoneda)
        lueMoneda.EditValue = Me.lueMoneda.Properties.GetDataSourceValue(lueMoneda.Properties.ValueMember, rMoneda)
        Me.deFechaEmision.EditValue = oContratoBEEdit.FechaEmision
        Me.txtNumeroCuotas.Text = oContratoBEEdit.NumeroCuotas
        Me.txtValorCuotas.Text = oContratoBEEdit.ValorCuotas
        Me.txtValorInicial.Text = oContratoBEEdit.ImporteInicial
        Me.txtPrimeraCuota.Text = oContratoBEEdit.PrimeraCuota
        Me.deFechaInicio.EditValue = oContratoBEEdit.FechaInicio
        Me.txtDiaPago.Text = oContratoBEEdit.DiaPago
        Me.txtTotal.Text = Convert.ToString(oContratoBEEdit.ImporteTotal)
    End Sub

    Private Sub bbiGrabar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGrabar.ItemClick
        Try
            lueProyecto.Focus()
            If vpDetalleContrato.Validate() And IsValidTotal() Then
                Dim oContratoBE As ContratoBE = New ContratoBE()
                If oContratoBEEdit.IdContrato > 0 Then
                    oContratoBE = oContratoBEEdit
                End If
                oContratoBE.IdLote = Me.lueLote.Properties.GetDataSourceValue("IdLote", lueLote.ItemIndex).ToString()
                oContratoBE.FechaEmision = Me.deFechaEmision.EditValue
                oContratoBE.NumeroCuotas = Convert.ToInt32(Me.txtNumeroCuotas.Text)
                oContratoBE.ValorCuotas = Convert.ToDecimal(Me.txtValorCuotas.Text)
                oContratoBE.ImporteInicial = Convert.ToDecimal(Me.txtValorInicial.Text)
                oContratoBE.PrimeraCuota = Convert.ToDecimal(Me.txtPrimeraCuota.Text)
                oContratoBE.FechaInicio = Me.deFechaInicio.EditValue
                oContratoBE.DiaPago = Convert.ToInt32(Me.txtDiaPago.Text)
                oContratoBE.ImporteTotal = Convert.ToDecimal(Me.txtTotal.Text)
                oContratoBE.IdMoneda = Me.lueMoneda.Properties.GetDataSourceValue("IdMoneda", lueMoneda.ItemIndex).ToString()


                Dim listSocios As List(Of ContratoSocioBE) = New List(Of ContratoSocioBE)()

                Dim dr As DataRow = Nothing
                For index = 0 To GridView1.RowCount - 1
                    dr = GridView1.GetDataRow(index)
                    Dim oSocioContratoBE As ContratoSocioBE = New ContratoSocioBE()
                    oSocioContratoBE.IdContrato = dr.Item("IdContrato")
                    oSocioContratoBE.IdSocio = dr.Item("IdSocio")
                    oSocioContratoBE.Principal = dr.Item("Principal")
                    oSocioContratoBE.UsuarioCreacion = IdUsuario
                    oSocioContratoBE.UsuarioModificacion = IdUsuario
                    oSocioContratoBE.FechaCreacion = DateTime.Now
                    oSocioContratoBE.FechaModificacion = DateTime.Now
                    listSocios.Add(oSocioContratoBE)
                Next
                oContratoBE.listContratoSocioBE = listSocios.ToArray
                If oContratoBEEdit.IdContrato > 0 Then
                    oContratoBE.UsuarioModificacion = IdUsuario
                    oContratoBE.FechaModificacion = DateTime.Now
                    If oNarhemService.ActualizarContrato(oContratoBE) Then
                        Me.DialogResult = DialogResult.OK
                    End If
                Else
                    oContratoBE.UsuarioCreacion = IdUsuario
                    oContratoBE.UsuarioModificacion = IdUsuario
                    oContratoBE.FechaCreacion = DateTime.Now
                    oContratoBE.FechaModificacion = DateTime.Now
                    If oNarhemService.InsertarContrato(oContratoBE) Then

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

    Function IsValidTotal() As Boolean
        Dim nCuotas As Integer
        nCuotas = CType(txtNumeroCuotas.Text, Integer) - IIf(CType(txtNumeroCuotas.Text, Integer) = 0, 0, 1)
        Dim ValorCalculado As Double = CType(txtValorInicial.Text, Double) + CType(txtPrimeraCuota.Text, Double) + (CType(txtValorCuotas.Text, Double) * nCuotas)
        If CType(ValorCalculado, Double) > CType(txtTotal.Text, Double) Then
            BarStaticItem1.Caption = "El valor calculado (" + Format(ValorCalculado, "###,##0.00") + ") no debe ser mayor al Total."
            Return False
        End If
        Return True
    End Function

    Private Sub txtNumeroCuotas_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtNumeroCuotas.KeyUp

        Dim dImporteInicial As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorInicial.Text.Trim) Then
            dImporteInicial = Convert.ToDecimal(Me.txtValorInicial.Text.Trim)
        End If

        Dim dPrimeraCuota As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtPrimeraCuota.Text.Trim) Then
            dPrimeraCuota = Convert.ToDecimal(Me.txtPrimeraCuota.Text.Trim)
        End If

        Dim dValorCuotas As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorCuotas.Text.Trim) Then
            dValorCuotas = Convert.ToDecimal(Me.txtValorCuotas.Text.Trim)
        End If
        Dim iNumeroCuotas As Integer = 0
        If Not String.IsNullOrEmpty(Me.txtNumeroCuotas.Text.Trim) Then
            iNumeroCuotas = Convert.ToInt32(Me.txtNumeroCuotas.Text)
        End If


        'Me.txtTotal.Text = dImporteInicial + iNumeroCuotas * dValorCuotas


    End Sub

    Private Sub txtValorCuotas_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtValorCuotas.KeyUp


        Dim dImporteInicial As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorInicial.Text.Trim) Then
            dImporteInicial = Convert.ToDecimal(Me.txtValorInicial.Text.Trim)
        End If


        Dim dValorCuotas As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorCuotas.Text.Trim) Then
            dValorCuotas = Convert.ToDecimal(Me.txtValorCuotas.Text.Trim)
        End If
        Dim iNumeroCuotas As Integer = 0
        If Not String.IsNullOrEmpty(Me.txtNumeroCuotas.Text.Trim) Then
            iNumeroCuotas = Convert.ToInt32(Me.txtNumeroCuotas.Text)
        End If


        'Me.txtTotal.Text = dImporteInicial + iNumeroCuotas * dValorCuotas
    End Sub


    Private Sub txtValorInicial_KeyDown(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles txtValorInicial.KeyUp, txtPrimeraCuota.KeyUp


        Dim dImporteInicial As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorInicial.Text.Trim) Then
            dImporteInicial = Convert.ToDecimal(Me.txtValorInicial.Text.Trim)
        End If


        Dim dValorCuotas As Decimal = 0.0
        If Not String.IsNullOrEmpty(Me.txtValorCuotas.Text.Trim) Then
            dValorCuotas = Convert.ToDecimal(Me.txtValorCuotas.Text.Trim)
        End If
        Dim iNumeroCuotas As Integer = 0
        If Not String.IsNullOrEmpty(Me.txtNumeroCuotas.Text.Trim) Then
            iNumeroCuotas = Convert.ToInt32(Me.txtNumeroCuotas.Text)
        End If


        'Me.txtTotal.Text = dImporteInicial + iNumeroCuotas * dValorCuotas
    End Sub


    Private Sub gridView1_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim View As ColumnView = CType(sender, GridView)

        View.SetRowCellValue(e.RowHandle, View.Columns("IdContrato"), oContratoBEEdit.IdContrato)
        View.SetRowCellValue(e.RowHandle, View.Columns("Principal"), "N")
        View.SetRowCellValue(e.RowHandle, View.Columns("UsuarioCreacion"), IdUsuario)
        View.SetRowCellValue(e.RowHandle, View.Columns("UsuarioModificacion"), IdUsuario)
        View.SetRowCellValue(e.RowHandle, View.Columns("FechaCreacion"), DateTime.Now)
        View.SetRowCellValue(e.RowHandle, View.Columns("FechaModificacion"), DateTime.Now)

    End Sub

    Private Sub ibeSocio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ibeSocio.ButtonClick
        Dim oFormDialog As frmBuscarSocio = New frmBuscarSocio()
        Dim oButtonEdit As ButtonEdit = CType(sender, ButtonEdit)

        If oFormDialog.ShowDialog() = DialogResult.OK Then
            Dim oSocio As SocioBE = oFormDialog.oSocioBE
            oButtonEdit.Text = oSocio.IdSocio
            CType(GridView1.GetFocusedRow(), DataRowView).Item("Nombres") = oSocio.Nombre + " " + oSocio.ApellidoPaterno + " " + oSocio.ApellidoMaterno
        End If
    End Sub


    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminar Registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                'If (MessageBox.Show("Eliminar Registro?", "Confirmación", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                Dim view As GridView = CType(sender, GridView)
                view.DeleteRow(view.FocusedRowHandle)
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub PoblarMonedas()
        Dim oMonedaBE As MonedaBE = New MonedaBE()
        Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)(oNarhemService.ObtenerMonedaPorCriterio(oMonedaBE))
        Me.lueMoneda.Properties.DataSource = listMonedas
        Me.lueMoneda.Properties.DisplayMember = "Descripcion"
        Me.lueMoneda.Properties.ValueMember = "IdMoneda"
    End Sub

    Private Sub lueProyecto_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueProyecto.EditValueChanged
        PoblarLote()
    End Sub

    Private Sub lueLote_Leave(sender As System.Object, e As System.EventArgs) Handles lueLote.Leave, deFechaEmision.Leave, deFechaInicio.Leave, txtDiaPago.Leave, lueMoneda.Leave, txtNumeroCuotas.Leave, txtValorCuotas.Leave
        vpDetalleContrato.Validate()
        If CType(txtValorCuotas.Text, Double) = 0 Then
            txtValorCuotas.Text = fnCalculaImporteCuota() 'Math.Round(CType(txtTotal.Text, Double) / CType(txtNumeroCuotas.Text, Double))
        End If
        If sender.Name = deFechaInicio.Name And deFechaInicio.Text <> "" Then
            txtDiaPago.Text = Format(deFechaInicio.DateTime, "dd")
        End If
    End Sub

    Private Sub lueLote_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueLote.EditValueChanged
        ObtenerDatosLote()
    End Sub

    Private Sub ObtenerDatosLote()
        Dim IdLote As String = Me.lueLote.Properties.GetDataSourceValue("IdLote", lueLote.ItemIndex)
        Dim ImporteLote As New Double
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "EXEC dbo.LOTE_GET01 " & IdLote
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        txtTotal.Text = oGeneralBE.dtResult.Rows(0).Item("ImporteLote")
        Dim rMoneda As Integer = Me.lueMoneda.Properties.GetDataSourceRowIndex("IdMoneda", oGeneralBE.dtResult.Rows(0).Item("IdMoneda"))
        lueMoneda.EditValue = Me.lueMoneda.Properties.GetDataSourceValue(lueMoneda.Properties.ValueMember, rMoneda)
    End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        txtValorCuotas.Text = fnCalculaImporteCuota()
        txtValorCuotas.Focus()
    End Sub

    Function fnCalculaImporteCuota() As String
        Return Math.Round(CType(txtTotal.Text - txtValorInicial.Text, Double) / CType(txtNumeroCuotas.Text, Double))
    End Function

End Class