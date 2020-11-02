Imports CrystalDecisions.Shared
Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmEstadoCuenta
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oGeneralBE As New GeneralBE
    Dim IdSocio, IdContrato As String

    Private Sub frmEstadoCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PoblarProyectos()
        Dim containsValidationRule As New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank
        containsValidationRule.ErrorText = "Ingrese un valor"
        containsValidationRule.ErrorType = ErrorType.Critical

        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Valor Obligatorio"
        customValidationRule.ErrorType = ErrorType.Critical

        vpReportInputs.SetValidationRule(Me.lueProyecto, customValidationRule)
        vpReportInputs.SetValidationRule(Me.lueCliente, customValidationRule)
        vpReportInputs.SetValidationRule(Me.lueLote, customValidationRule)
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

    Private Sub sbVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles sbVerReporte.Click
        Validate()
        If Not vpReportInputs.Validate() Then
            sender.Focus()
            Return
        End If

        Dim dtDataCnx As DataTable = General.RetrieveCReportConn
        Try
            'Asignación de Datos del Servidor
            EstadoCuentaContrato1.DataSourceConnections.Item(0).SetConnection(dtDataCnx.Rows(0).Item(1), dtDataCnx.Rows(1).Item(1), False)
            EstadoCuentaContrato1.DataSourceConnections.Item(0).SetLogon(dtDataCnx.Rows(2).Item(1), dtDataCnx.Rows(3).Item(1))
            crvEstadoCuenta.ReportSource = EstadoCuentaContrato1
            Dim ParamArrayList As ArrayList = New ArrayList()
            Dim myParameterFields As ParameterFields = crvEstadoCuenta.ParameterFieldInfo
            crvEstadoCuenta.LogOnInfo.Item(0).ConnectionInfo.AllowCustomConnection = True
            'Asignación de Parámetro
            ParamArrayList.Add(Me.lueLote.Properties.GetDataSourceValue("IdContrato", lueLote.ItemIndex).ToString())
            ParamArrayList.Add(ToggleSwitch1.EditValue)
            SetCurrentValuesForParameterField(myParameterFields, ParamArrayList)
            crvEstadoCuenta.Show()
        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lueCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueCliente.EditValueChanged
        Poblarlotes()
    End Sub

    Private Sub lueProyecto_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueProyecto.EditValueChanged
        PoblarClientes()
    End Sub
End Class