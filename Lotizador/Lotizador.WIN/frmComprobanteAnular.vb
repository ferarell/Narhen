Imports Lotizador.BE
Imports Lotizador.BL
Imports System.Configuration
Imports System.IO

Public Class frmComprobanteAnular
    Public dtComprobantes As New DataTable

    Public Sub New(dt As DataTable)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtComprobantes = dt
    End Sub

    Private Sub frmComprobanteAnular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvComprobantes.DataSource = dtComprobantes
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim nroEmpresaConfig As Integer = 1
            Dim emisorRazonSocial As String = ""
            Dim emisorNrodocumento As String = ""
            Dim fechaResumenDiario As String = Me.dtpFecha.Value.ToString("yyyy-MM-dd")
            Dim ccBL As New ComprobanteCabeceraBL()
            Dim oComprobanteCabecera As New ComprobanteCabeceraBE()
            Dim oLetraBL As New LetraBL()
            Dim eliminaLetraComprobante As Boolean = False
            For i As Integer = 0 To Me.dgvComprobantes.Rows.Count() - 1
                ' CABECERA
                oComprobanteCabecera.c_cc_tipo = Me.dgvComprobantes.Rows(i).Cells("c_cc_tipo").Value
                oComprobanteCabecera.v_cc_serie = Me.dgvComprobantes.Rows(i).Cells("v_cc_serie").Value
                oComprobanteCabecera.v_cc_numero = Me.dgvComprobantes.Rows(i).Cells("v_cc_numero").Value
                oComprobanteCabecera.d_cc_fecha = Me.dgvComprobantes.Rows(i).Cells("d_cc_fecha").Value
                oComprobanteCabecera.v_cc_emisor_razonsocial = Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_razonsocial").Value
                oComprobanteCabecera.v_cc_emisor_direccion = ""
                'oComprobanteCabecera.Ubigeo = "150140"
                oComprobanteCabecera.v_cc_emisor_departamento = ""
                'oComprobanteCabecera.Provincia = "LIMA"
                'oComprobanteCabecera.Distrito = oEmpresa.emp_distrito.ToUpper
                'oComprobanteCabecera.Urbanizacion = ""
                oComprobanteCabecera.c_cc_emisor_tipodoc = "6"
                oComprobanteCabecera.v_cc_emisor_ruc = Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_ruc").Value
                'oComprobanteCabecera.EmisorTelefono = "555-1111"

                oComprobanteCabecera.v_cc_adquiriente_razonsocial = Me.dgvComprobantes.Rows(i).Cells("v_cc_adquiriente_razonsocial").Value
                oComprobanteCabecera.c_cc_adquiriente_tipodoc = Me.dgvComprobantes.Rows(i).Cells("c_cc_adquiriente_tipodoc").Value
                oComprobanteCabecera.v_cc_adquiriente_ruc = Me.dgvComprobantes.Rows(i).Cells("v_cc_adquiriente_ruc").Value
                oComprobanteCabecera.v_cc_adquiriente_direccion = ""

                oComprobanteCabecera.n_cc_gravado = Convert.ToDecimal("0") 'Convert.ToDecimal("10651.19")
                oComprobanteCabecera.n_cc_inafecto = Convert.ToDecimal(Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value)
                oComprobanteCabecera.n_cc_exonerado = Convert.ToDecimal("0")
                'oComprobanteCabecera.TotalValorVentaGratuita = Convert.ToDecimal("0")
                oComprobanteCabecera.n_cc_descuento = Convert.ToDecimal("0")
                oComprobanteCabecera.n_cc_igv = Convert.ToDecimal("0")
                'oComprobanteCabecera.SumatoriaIsc = Convert.ToDecimal("0")
                oComprobanteCabecera.n_cc_total = Convert.ToDecimal(Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value)

                oComprobanteCabecera.c_cc_moneda = Me.dgvComprobantes.Rows(i).Cells("c_cc_moneda").Value
                oComprobanteCabecera.v_cc_montoletras = Numalet.ToCardinal(Convert.ToDecimal(Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value).ToString()).ToUpper() & IIf(Me.dgvComprobantes.Rows(i).Cells("c_cc_moneda").Value = "PEN", " SOLES", " DOLARES")
                'oComprobanteCabecera.PaisID = "PE"
                'objBoleta.DescuentosGlobales = "0"

                oComprobanteCabecera.c_cc_log_fecha = Today.ToString("yyyy-MM-dd")
                oComprobanteCabecera.c_cc_log_hora = Now.ToString("HH:mm:ss")
                oComprobanteCabecera.v_cc_log_usuario = Funciones.USUARIO

                GenerarTxt(oComprobanteCabecera)

                ccBL.ActualizaEstadoComprobantes(oComprobanteCabecera.c_cc_tipo, oComprobanteCabecera.v_cc_serie, oComprobanteCabecera.v_cc_numero, oComprobanteCabecera.c_cc_log_fecha, oComprobanteCabecera.c_cc_log_hora, oComprobanteCabecera.v_cc_log_usuario)

                eliminaLetraComprobante = oLetraBL.EliminarLetraComprobante(Me.dgvComprobantes.Rows(i).Cells("n_cc_id").Value)

                If eliminaLetraComprobante Then

                Else
                    Throw New Exception("Hubo un problema y no se eliminó en Comprobante-Letra")
                End If
            Next

            MessageBox.Show("Se registraron y generaron los Comprobantes Anulados", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Default
    End Sub

    'Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
    '    Cursor = Cursors.WaitCursor
    '    Try
    '        Dim nroEmpresaConfig As Integer = 1
    '        Dim emisorRazonSocial As String = ""
    '        Dim emisorNrodocumento As String = ""
    '        Dim fechaResumenDiario As String = Me.dtpFecha.Value.ToString("yyyy-MM-dd")

    '        Dim oResumenBL As New ResumenCorrelativoBL()
    '        Dim correlativoResumenDiario As Integer = oResumenBL.ObtenerFechaCorrelativoMax() + 1

    '        Dim ws As SFEService.GeneracionEnvioComprobantesSoapClient = New SFEService.GeneracionEnvioComprobantesSoapClient
    '        Dim lstResumenDiarioItem As New List(Of SFEService.ResumenDiarioItem)
    '        For i As Integer = 0 To Me.dgvComprobantes.Rows.Count() - 1
    '            '------------ <RESUMEN_DIARIO> '------------'
    '            ' Guardamos el detalle para el Resumen Diario 
    '            If emisorRazonSocial = "" Then emisorRazonSocial = Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_razonsocial").Value
    '            If emisorNrodocumento = "" Then emisorNrodocumento = Me.dgvComprobantes.Rows(i).Cells("v_cc_emisor_ruc").Value
    '            Dim objResumenDiarioItem As New SFEService.ResumenDiarioItem()
    '            With objResumenDiarioItem
    '                .NumeroFila = i + 1
    '                .NumeroSerie = Me.dgvComprobantes.Rows(i).Cells("v_cc_serie").Value
    '                .NumeroCorrelativo = Me.dgvComprobantes.Rows(i).Cells("v_cc_numero").Value
    '                .TipoComprobante = Me.dgvComprobantes.Rows(i).Cells("c_cc_tipo").Value
    '                .NroDocumentoAdquiriente = Me.dgvComprobantes.Rows(i).Cells("v_cc_adquiriente_ruc").Value
    '                .TipoDocumentoAdquiriente = Me.dgvComprobantes.Rows(i).Cells("c_cc_adquiriente_tipodoc").Value
    '                .Estado = "3"
    '                .TipoMoneda = Me.dgvComprobantes.Rows(i).Cells("c_cc_moneda").Value
    '                .ImporteTotalVenta = Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value
    '                .TotalValorVentaGravada = "0"
    '                .TotalValorVentaExonerada = "0"
    '                .TotalValorVentaInafecta = Me.dgvComprobantes.Rows(i).Cells("n_cc_total").Value
    '                .SumatoriaOtrosCargos = "0"
    '                .TotalIgv = "0"
    '                .TotalIsc = "0"
    '                .TotalOtrosTributos = "0"
    '            End With
    '            lstResumenDiarioItem.Add(objResumenDiarioItem)
    '            '------------ </RESUMEN_DIARIO> '------------
    '        Next
    '        Dim objResumenDiario As New SFEService.ResumenDiario
    '        objResumenDiario.Identificador = "RC-" & fechaResumenDiario.Replace("-", "") & "-" & correlativoResumenDiario
    '        objResumenDiario.RazonSocial = emisorRazonSocial
    '        objResumenDiario.TipoDocumentoIdentidad = "6"
    '        objResumenDiario.NumeroRuc = emisorNrodocumento
    '        objResumenDiario.FechaGeneracion = fechaResumenDiario
    '        objResumenDiario.FechaEmisionDocumentos = fechaResumenDiario

    '        Dim ticket As String = ws.ConstruirXmlResumenDiario(nroEmpresaConfig, objResumenDiario, lstResumenDiarioItem.ToArray(), emisorNrodocumento & "-RC-" & fechaResumenDiario.Replace("-", "") & "-" & correlativoResumenDiario & ".xml")

    '        oResumenBL.RegistrarFechaCorrelativo(correlativoResumenDiario)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Lotizador")
    '    End Try
    '    Cursor = Cursors.Default
    'End Sub

    Private Sub GenerarTxt(oCCabecera As ComprobanteCabeceraBE)
        Try
            Dim textoTxt As String = ""
            Dim rutaTxt As String = ""
            Dim nombreTxt As String = oCCabecera.v_cc_emisor_ruc & "-" & oCCabecera.c_cc_tipo & "-" & oCCabecera.v_cc_serie & "-" & oCCabecera.v_cc_numero.PadLeft(7, "0") & ".txt"
            If oCCabecera.c_cc_tipo = "01" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_FACTURA")
            ElseIf oCCabecera.c_cc_tipo = "03" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_BOLETA")
            End If
            'rutaTxt = rutaTxt & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "-Anulados\"
            rutaTxt = rutaTxt & Today.ToString("yyyy-MM-dd") & "-Anulados\"
            If Not Directory.Exists(rutaTxt) Then
                Directory.CreateDirectory(rutaTxt)
            End If

            Dim oSW As New StreamWriter(rutaTxt & nombreTxt)
            ' CABECERA
            textoTxt = "C" & "|" & oCCabecera.c_cc_emisor_tipodoc & "|" & oCCabecera.v_cc_emisor_ruc & "|" & oCCabecera.v_cc_emisor_razonsocial & "|" & oCCabecera.v_cc_emisor_razonsocial & "|" & _
                       oCCabecera.v_cc_emisor_direccion.Trim & "|" & "|" & oCCabecera.v_cc_emisor_departamento & "|" & "|" & "|" & "PE" & "|" & oCCabecera.c_cc_adquiriente_tipodoc & "|" & _
                       oCCabecera.v_cc_adquiriente_ruc & "|" & oCCabecera.v_cc_adquiriente_razonsocial & "|" & oCCabecera.v_cc_adquiriente_direccion.Trim & "|" & "|" & oCCabecera.c_cc_tipo & "|" & _
                       oCCabecera.v_cc_serie & "|" & oCCabecera.v_cc_numero & "|" & oCCabecera.d_cc_fecha.ToString("yyyy-MM-dd") & "|" & oCCabecera.c_cc_moneda & "|" & "|" & _
                       String.Format("{0:0.00}", oCCabecera.n_cc_gravado) & "|" & _
                       String.Format("{0:0.00}", oCCabecera.n_cc_exonerado) & "|" & _
                       String.Format("{0:0.00}", oCCabecera.n_cc_inafecto) & "|" & _
                       String.Format("{0:0.00}", "0") & "|" & _
                       "|" & "|" & "|" & _
                       String.Format("{0:0.00}", oCCabecera.n_cc_igv) & "|" & _
                       String.Format("{0:0.00}", "0") & "|" & _
                       String.Format("{0:0.00}", oCCabecera.n_cc_total) & "|" & _
                       String.Format("{0:0.00}", "0") & "|" & _
                       String.Format("{0:0.00}", "0") & "|" & _
                       String.Format("{0:0.00}", "0") & "|" & _
                       "0|0|" & oCCabecera.v_cc_montoletras
            oSW.Write(textoTxt)
            oSW.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class