Imports Lotizador.UI.LotizadorService
Imports CrystalDecisions.Shared

Public Class frmVisorLetras
    Dim oNarhemService As NarhenClient = New NarhenClient()


    Private _ContratoBE As ContratoBE
    Public Property ContratoBEEdit() As ContratoBE
        Get
            Return _ContratoBE
        End Get
        Set(ByVal value As ContratoBE)
            _ContratoBE = value
        End Set
    End Property

    Private Sub frmVisorLetras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub crvLetras_Load(sender As System.Object, e As System.EventArgs) Handles crvLetras.Load
        Dim IdContrato As Integer = ContratoBEEdit.IdContrato
        Dim dtDataCnx As DataTable = General.RetrieveCReportConn
        Try
            'Asignación de Datos del Servidor
            Letras1.DataSourceConnections.Item(0).SetConnection(dtDataCnx.Rows(0).Item(1), dtDataCnx.Rows(1).Item(1), False)
            Letras1.DataSourceConnections.Item(0).SetLogon(dtDataCnx.Rows(2).Item(1), dtDataCnx.Rows(3).Item(1))
            crvLetras.ReportSource = Letras1
            Dim ParamArrayList As ArrayList = New ArrayList()
            Dim myParameterFields As ParameterFields = crvLetras.ParameterFieldInfo
            crvLetras.LogOnInfo.Item(0).ConnectionInfo.AllowCustomConnection = True
            'Asignación de Parámetro
            ParamArrayList.Add(ContratoBEEdit.IdContrato)
            SetCurrentValuesForParameterField(myParameterFields, ParamArrayList)
            crvLetras.Show()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class