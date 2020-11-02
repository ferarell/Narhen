Imports Lotizador.UI.LotizadorService
'Imports Microsoft.Reporting.WinForms
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource

Public Class frmVisorCronograma
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

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmCronogramaPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ShowReport()
        Dim IdContrato As Integer = ContratoBEEdit.IdContrato
        Dim dtDataCnx As DataTable = General.RetrieveCReportConn
        Try
            'Asignación de Datos del Servidor
            Cronograma1.DataSourceConnections.Item(0).SetConnection(dtDataCnx.Rows(0).Item(1), dtDataCnx.Rows(1).Item(1), False)
            Cronograma1.DataSourceConnections.Item(0).SetLogon(dtDataCnx.Rows(2).Item(1), dtDataCnx.Rows(3).Item(1))
            crvCronograma.ReportSource = Cronograma1
            Dim ParamArrayList As ArrayList = New ArrayList()
            Dim myParameterFields As ParameterFields = crvCronograma.ParameterFieldInfo
            crvCronograma.LogOnInfo.Item(0).ConnectionInfo.AllowCustomConnection = True
            'Asignación de Parámetro
            ParamArrayList.Add(ContratoBEEdit.IdContrato)
            ParamArrayList.Add(0)
            SetCurrentValuesForParameterField(myParameterFields, ParamArrayList)
            crvCronograma.Show()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmVisorCronograma_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    'Private Sub ShowReport()
    '    Dim oGeneralBE As New GeneralBE
    '    oGeneralBE.SqlTxt = "select valor from variable where nombre = 'ReportServer' and codigo = 'URL' "
    '    oGeneralBE = oNarhemService.CommandText(oGeneralBE)
    '    Dim ServerUrl As New Uri(oGeneralBE.dtResult.Rows(0).Item("valor"))
    '    Dim IdContrato As Integer = ContratoBEEdit.IdContrato
    '    Try
    '        Me.rvCronograma.ServerReport.ReportServerUrl = ServerUrl
    '        Me.rvCronograma.ServerReport.ReportPath = "/Lotizador/CronogramaPagos"
    '        Me.rvCronograma.Clear()
    '        ' Creo una colección de parámetros de tipo ReportParameter
    '        ' para añadirlos al control ReportViewer.
    '        Dim parametros As New List(Of ReportParameter)
    '        ' Añado los parámetros necesarios.
    '        parametros.Add(New ReportParameter("IdContrato", IdContrato, False))
    '        ' Añado el/los parámetro/s al ReportViewer.
    '        Me.rvCronograma.ServerReport.SetParameters(parametros)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    Me.rvCronograma.RefreshReport()
    'End Sub

  
End Class