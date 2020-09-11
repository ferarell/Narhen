Imports CrystalDecisions.Shared
Imports Lotizador.UI.LotizadorService

Public Class frmEstadoCuentaOld
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oGeneralBE As New GeneralBE
    Dim IdSocio, IdContrato As String

    Private Sub frmEstadoCuenta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Clientes
        oGeneralBE.SqlTxt = "EXEC upObtenerClientes"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        lueCliente.Properties.DataSource = oGeneralBE.dtResult
        lueCliente.Properties.DisplayMember = "Cliente"
        lueCliente.Properties.ValueMember = "IdSocio"

    End Sub


    Private Sub sbVerReporte_Click(sender As System.Object, e As System.EventArgs) Handles sbVerReporte.Click
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
            ParamArrayList.Add(0)
            SetCurrentValuesForParameterField(myParameterFields, ParamArrayList)
            crvEstadoCuenta.Show()
        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lueCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles lueCliente.EditValueChanged
        'Lotes
        oGeneralBE.SqlTxt = "EXEC upObtenerLotesPorCliente '" & Me.lueCliente.Properties.GetDataSourceValue("IdSocio", lueCliente.ItemIndex).ToString() & "'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        lueLote.Properties.DataSource = oGeneralBE.dtResult
        lueLote.Properties.DisplayMember = "ManzanaLote"
        lueLote.Properties.ValueMember = "IdContrato"

    End Sub
End Class