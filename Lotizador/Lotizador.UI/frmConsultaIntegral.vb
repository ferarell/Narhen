Imports CrystalDecisions.Shared
Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraSplashScreen

Public Class frmConsultaIntegral
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oGeneralBE As New GeneralBE
    'Dim IdSocio, IdContrato As String

    Private Sub frmConsultaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PoblarProyectos()
    End Sub

    Private Sub PoblarClientes()
        oGeneralBE.SqlTxt = "EXEC upObtenerClientesPorProyecto " & Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString()
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        lueCliente.Properties.DataSource = oGeneralBE.dtResult
        lueCliente.Properties.DisplayMember = "Cliente"
        lueCliente.Properties.ValueMember = "IdSocio"
    End Sub

    Private Sub PoblarProyectos()
        Dim oProyectoBE As ProyectoBE = New ProyectoBE()
        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oNarhemService.ObtenerProyectoPorCriterio(oProyectoBE))
        Me.lueProyecto.Properties.DataSource = listProyectos
        Me.lueProyecto.Properties.DisplayMember = "Descripcion"
        Me.lueProyecto.Properties.ValueMember = "IdProyecto"
    End Sub

    Private Sub Poblarlotes()
        Dim sIdProyecto As String = Me.lueProyecto.Properties.GetDataSourceValue("IdProyecto", lueProyecto.ItemIndex).ToString()
        oGeneralBE.SqlTxt = "EXEC upObtenerLotesPorProyectoCliente '" & sIdProyecto & "', '" & Me.lueCliente.Properties.GetDataSourceValue("IdSocio", lueCliente.ItemIndex).ToString() & "'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        lueLote.Properties.DataSource = oGeneralBE.dtResult
        lueLote.Properties.DisplayMember = "ManzanaLote"
        lueLote.Properties.ValueMember = "IdContrato"
    End Sub


    Private Sub lueCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueCliente.EditValueChanged
        Poblarlotes()
    End Sub

    Private Sub lueProyecto_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueProyecto.EditValueChanged
        PoblarClientes()
    End Sub

    Private Sub bbiConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiConsultar.ItemClick
        Validate()
        Dim _IdProyecto As String = "NULL"
        Dim _IdCliente As String = "NULL"
        Dim _IdLote As String = "NULL"
        If Not lueProyecto.EditValue Is Nothing Then
            _IdProyecto = lueProyecto.EditValue.ToString
        End If
        If Not lueCliente.EditValue Is Nothing Then
            _IdCliente = lueCliente.EditValue.ToString
        End If
        If Not lueLote.EditValue Is Nothing Then
            _IdLote = lueLote.EditValue.ToString
        End If
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
        Try
            Dim dtQuery As New DataTable
            gcConsultaGeneral.DataSource = Nothing
            dtQuery = oNarhemService.ExecuteSQL("EXEC upConsultaIntegral " & _IdProyecto & "," & _IdCliente & "," & _IdLote & ",'" & Mid(cbeTipoConsulta.Text, 1, 1) & "'").Tables(0)
            gcConsultaGeneral.DataSource = dtQuery
            GridView1.ExpandAllGroups()
            GridView1.BestFitColumns()
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub bbiExportar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiExportar.ItemClick
        ExportarExcel(gcConsultaGeneral)
    End Sub

    Private Sub bbiCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Close()
    End Sub

    'Private Sub LoadInputValidations()
    '    Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()

    '    containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
    '    containsValidationRule.ErrorText = "Assign value."
    '    containsValidationRule.ErrorType = ErrorType.Critical

    '    Dim customValidationRule As New CustomValidationRule()
    '    customValidationRule.ErrorText = "Required value."
    '    customValidationRule.ErrorType = ErrorType.Critical

    '    vpInputs.SetValidationRule(Me.lueProyecto, customValidationRule)
    '    vpInputs.SetValidationRule(Me.lueCliente, customValidationRule)
    '    vpInputs.SetValidationRule(Me.lueLote, customValidationRule)

    'End Sub

End Class