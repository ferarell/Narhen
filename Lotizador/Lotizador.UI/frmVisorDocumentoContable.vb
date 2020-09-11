Imports Lotizador.UI.LotizadorService
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmVisorDocumentoContable
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _IdLetra As String
    Public Property IdLetra() As String
        Get
            Return _IdLetra
        End Get
        Set(ByVal value As String)
            _IdLetra = value
        End Set
    End Property


    Private Sub frmVisorDocumentoContable_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated ', crvDocumentoContable.RegionChanged
        
    End Sub

    Private Sub crvDocumentoContable_Load(sender As System.Object, e As System.EventArgs) Handles crvDocumentoContable.Load
        Dim dtDataCnx As DataTable = General.RetrieveCReportConn
        Dim myPaperSize As PaperSize = GetPapersizeID("EPSON LX-300+ /II en pc02", "FACTURACION")
        Try
            'Asignación de Datos del Reporte
            'Conexión
            DocumentoContable1.DataSourceConnections.Item(0).SetConnection(dtDataCnx.Rows(0).Item(1), dtDataCnx.Rows(1).Item(1), False)
            DocumentoContable1.DataSourceConnections.Item(0).SetLogon(dtDataCnx.Rows(2).Item(1), dtDataCnx.Rows(3).Item(1))
            'Opciones de Impresión
            'DocumentoContable1.PrintOptions.PaperSize = myPaperSize
            'Reporte Asociado
            crvDocumentoContable.ReportSource = DocumentoContable1
            'Parámetros
            Dim ParamArrayList As ArrayList = New ArrayList()
            Dim myParameterFields As ParameterFields = crvDocumentoContable.ParameterFieldInfo
            crvDocumentoContable.LogOnInfo.Item(0).ConnectionInfo.AllowCustomConnection = True
            ParamArrayList.Add(IdLetra)
            SetCurrentValuesForParameterField(myParameterFields, ParamArrayList)
            crvDocumentoContable.Show()
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message)
        End Try
    End Sub

End Class