Imports Lotizador.BE
Imports Lotizador.BL
Imports System.Configuration
Imports System.IO

Public Class frmNotaGenerar
    Public dtComprobantes As New DataTable

    Public Sub New(dt As DataTable)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtComprobantes = dt
    End Sub

    Private Sub frmNotaGenerar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvComprobantes.DataSource = dtComprobantes
        GenerarComboTipoComprobante()
        CargarSeries()
    End Sub

    Private Sub GenerarComboTipoComprobante()
        Dim dt As DataTable = CrearTablaTipoComprobante()
        Me.cboTipo.DataSource = dt
        Me.cboTipo.ValueMember = "codigo"
        Me.cboTipo.DisplayMember = "descripcion"
        Me.cboTipo.SelectedIndex = 0
    End Sub

    Private Function CrearTablaTipoComprobante() As DataTable
        Dim table As New DataTable
        table.Columns.Add("codigo", GetType(String))
        table.Columns.Add("descripcion", GetType(String))

        table.Rows.Add("07", "NOTA CREDITO")
        table.Rows.Add("08", "NOTA DEBITO")

        Return table
    End Function

    Private Function CrearTablaTipoNotaCredito() As DataTable
        Dim table As New DataTable
        table.Columns.Add("codigo", GetType(String))
        table.Columns.Add("descripcion", GetType(String))

        table.Rows.Add("01", "ANULACIÓN DE LA OPERACIÓN")
        table.Rows.Add("02", "ANULACIÓN POR ERROR EN EL RUC")
        table.Rows.Add("03", "CORRECCIÓN POR ERROR EN LA DESCRIPCIÓN")
        table.Rows.Add("04", "DESCUENTO GLOBAL")
        table.Rows.Add("05", "DESCUENTO POR ÍTEM")
        table.Rows.Add("06", "DEVOLUCIÓN TOTAL")
        table.Rows.Add("07", "DEVOLUCIÓN POR ÍTEM")
        table.Rows.Add("08", "BONIFICACIÓN")
        table.Rows.Add("09", "DISMINUCIÓN EN EL VALOR")
        table.Rows.Add("10", "OTROS CONCEPTOS")

        Return table
    End Function

    Private Function CrearTablaTipoNotaDebito() As DataTable
        Dim table As New DataTable
        table.Columns.Add("codigo", GetType(String))
        table.Columns.Add("descripcion", GetType(String))

        table.Rows.Add("01", "INTERESES POR MORA")
        table.Rows.Add("02", "AUMENTO EN EL VALOR")
        table.Rows.Add("03", "PENALIDADES/ OTROS CONCEPTOS")

        Return table
    End Function

    Private Sub cboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipo.SelectedIndexChanged
        If Me.cboTipo.SelectedIndex = 0 Then
            Dim dt As DataTable = CrearTablaTipoNotaCredito()
            Me.cboMotivo.DataSource = dt
            Me.cboMotivo.ValueMember = "codigo"
            Me.cboMotivo.DisplayMember = "descripcion"
            Me.cboMotivo.SelectedIndex = 0
            CargarSeries()
        ElseIf Me.cboTipo.SelectedIndex = 1 Then
            Dim dt As DataTable = CrearTablaTipoNotaDebito()
            Me.cboMotivo.DataSource = dt
            Me.cboMotivo.ValueMember = "codigo"
            Me.cboMotivo.DisplayMember = "descripcion"
            Me.cboMotivo.SelectedIndex = 0
            CargarSeries()
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Cursor = Cursors.WaitCursor
        If Me.cboSeries.SelectedIndex > 0 Then
            If Me.txtImporte.Text.Trim <> String.Empty Then
                If Me.txtDetalle.Text.Trim <> String.Empty Then

                    Dim nroEmpresaConfig As Integer = 1
                    Dim oSocioBL As New SocioBL()
                    Dim oSocio As New SocioBE
                    Dim emisorRUC As String = Me.dgvComprobantes.Rows(0).Cells("v_cc_emisor_ruc").Value
                    Dim oEmpresaBL As New EmpresaBL()
                    Dim oEmpresa As EmpresaBE = oEmpresaBL.ObtenerEmpresaPorRuc(emisorRUC)
                    'Dim ws As SFEService.GeneracionEnvioComprobantesSoapClient = New SFEService.GeneracionEnvioComprobantesSoapClient

                    Dim oComprobanteCabecera As New ComprobanteCabeceraBE()
                    If Me.cboTipo.SelectedIndex = 0 Then
                        oComprobanteCabecera.c_cc_tipo = "07"
                    ElseIf Me.cboTipo.SelectedIndex = 1 Then
                        oComprobanteCabecera.c_cc_tipo = "08"
                    End If
                    oComprobanteCabecera.v_cc_serie = Me.cboSeries.Text
                    oComprobanteCabecera.v_cc_numero = Convert.ToInt32(Me.txtCorrelativo.Text).ToString()
                    oComprobanteCabecera.d_cc_fecha = Me.dtpFecha.Value.ToString("yyyy-MM-dd")
                    oComprobanteCabecera.v_cc_emisor_razonsocial = oEmpresa.emp_razsoc.ToUpper
                    'objNotaCredito.Ubigeo = "150130"
                    oComprobanteCabecera.v_cc_emisor_direccion = oEmpresa.emp_direccion.ToUpper
                    'oComprobanteCabecera.Urbanizacion = ""
                    oComprobanteCabecera.v_cc_emisor_departamento = "LIMA"
                    'oComprobanteCabecera.Provincia = "LIMA"
                    oComprobanteCabecera.v_cc_emisor_distrito = oEmpresa.emp_distrito.ToUpper
                    'oComprobanteCabecera.Urbanizacion = ""
                    oComprobanteCabecera.c_cc_emisor_tipodoc = "6"
                    oComprobanteCabecera.v_cc_emisor_ruc = oEmpresa.emp_nrodoc
                    'oComprobanteCabecera.EmisorTelefono = "555-1111"

                    oSocio = oSocioBL.ObtenerSocioPorNroDoc(Me.dgvComprobantes.Rows(0).Cells("v_cc_adquiriente_ruc").Value)
                    If oSocio.IdTipoDocumento = "1" Then
                        oComprobanteCabecera.c_cc_adquiriente_tipodoc = "1"
                    ElseIf oSocio.IdTipoDocumento = "2" Then
                        oComprobanteCabecera.c_cc_adquiriente_tipodoc = "6"
                    End If
                    oComprobanteCabecera.v_cc_adquiriente_ruc = oSocio.NumeroDocumento
                    oComprobanteCabecera.v_cc_adquiriente_razonsocial = oSocio.Nombre.ToUpper & " " & oSocio.ApellidoPaterno.ToUpper & " " & oSocio.ApellidoMaterno.ToUpper
                    oComprobanteCabecera.v_cc_adquiriente_direccion = oSocio.Direccion.ToUpper

                    oComprobanteCabecera.v_cc_docmodif_numero = Me.dgvComprobantes.Rows(0).Cells("v_cc_serie").Value & "-" & Me.dgvComprobantes.Rows(0).Cells("v_cc_numero").Value
                    oComprobanteCabecera.c_cc_docmodif_tipo = Me.dgvComprobantes.Rows(0).Cells("c_cc_tipo").Value
                    oComprobanteCabecera.v_cc_docmodif_motivo = Me.cboMotivo.SelectedValue & " - " & Me.cboMotivo.Text
                    'oComprobanteCabecera.CodigoTipoNotaCredito = Me.cboMotivo.SelectedValue

                    oComprobanteCabecera.n_cc_gravado = Convert.ToDecimal("0") 'Convert.ToDecimal("10651.19")
                    oComprobanteCabecera.n_cc_inafecto = Convert.ToDecimal(Me.txtImporte.Text.Trim) 'Convert.ToDecimal(Me.dgvComprobantes.Rows(0).Cells("n_cc_total").Value)
                    oComprobanteCabecera.n_cc_exonerado = Convert.ToDecimal("0")
                    'oComprobanteCabecera.TotalValorVentaGratuita = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_descuento = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_igv = Convert.ToDecimal("0")
                    'oComprobanteCabecera.SumatoriaIsc = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_total = Convert.ToDecimal(Me.txtImporte.Text.Trim) 'Convert.ToDecimal(Me.dgvComprobantes.Rows(0).Cells("n_cc_total").Value) 'Convert.ToDecimal("12568.4")

                    oComprobanteCabecera.c_cc_moneda = Me.dgvComprobantes.Rows(0).Cells("c_cc_moneda").Value
                    oComprobanteCabecera.v_cc_montoletras = Numalet.ToCardinal(Me.txtImporte.Text.Trim).ToUpper() & IIf(Me.dgvComprobantes.Rows(0).Cells("c_cc_moneda").Value = "PEN", " SOLES", " DOLARES")
                    'Numalet.ToCardinal(Me.dgvComprobantes.Rows(0).Cells("n_cc_total").Value.ToString()).ToUpper() & IIf(Me.dgvComprobantes.Rows(0).Cells("c_cc_moneda").Value = "PEN", " SOLES", " DOLARES")

                    oComprobanteCabecera.c_cc_log_fecha = Today.ToString("yyyy-MM-dd")
                    oComprobanteCabecera.c_cc_log_hora = Now.ToString("HH:mm:ss")
                    oComprobanteCabecera.v_cc_log_usuario = Funciones.USUARIO

                    ' DETALLE
                    Dim lstComprobanteDetalle As New List(Of ComprobanteDetalleBE)
                    Dim oComprobanteDetalle As New ComprobanteDetalleBE()
                    oComprobanteDetalle.n_cd_id = 1
                    oComprobanteDetalle.c_cd_unidad = "NIU"
                    oComprobanteDetalle.n_cd_cantidad = 1
                    oComprobanteDetalle.v_cd_codigo = ""
                    oComprobanteDetalle.v_cd_descripcion = Me.txtDetalle.Text.Trim
                    'oComprobanteDetalle.PrecioVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    'oComprobanteDetalle.AfectacionIgv = "10"
                    oComprobanteDetalle.n_cd_igv = Convert.ToDecimal("0")
                    'objBoletaItem.SistemaIsc = ""
                    'objBoletaItem.IscItem = Convert.ToDecimal("0")
                    oComprobanteDetalle.n_cd_valorunitario = Convert.ToDecimal(Me.txtImporte.Text.Trim)
                    'oComprobanteDetalle.ValorReferencialUnitario = Convert.ToDecimal("0")
                    oComprobanteDetalle.n_cd_valorventa = Convert.ToDecimal(Me.txtImporte.Text.Trim)
                    oComprobanteDetalle.n_cd_importe = Convert.ToDecimal(Me.txtImporte.Text.Trim)
                    oComprobanteDetalle.n_cd_descuento = Convert.ToDecimal("0")
                    lstComprobanteDetalle.Add(oComprobanteDetalle)

                    Dim ccBL As New ComprobanteCabeceraBL()
                    ccBL.Registra(oComprobanteCabecera, lstComprobanteDetalle)
                    GenerarTxt(oComprobanteCabecera, lstComprobanteDetalle)

                    Dim dtCabecera As DataTable = Funciones.CrearTablaComprobanteCabecera(oComprobanteCabecera)
                    Dim dtDetalle As DataTable = Funciones.CrearTablaComprobanteDetalle(lstComprobanteDetalle)
                    Dim rutaXML As String = ""
                    Dim nombreXML As String = oComprobanteCabecera.v_cc_emisor_ruc & "-" & oComprobanteCabecera.c_cc_tipo & "-" & oComprobanteCabecera.v_cc_serie & "-" & oComprobanteCabecera.v_cc_numero.PadLeft(7, "0") & ".xml"
                    If oComprobanteCabecera.c_cc_tipo = "07" Then
                        rutaXML = ConfigurationManager.AppSettings("_RUTA_NOTA_CREDITO")
                    ElseIf oComprobanteCabecera.c_cc_tipo = "08" Then
                        rutaXML = ConfigurationManager.AppSettings("_RUTA_NOTA_DEBITO")
                    End If
                    'rutaXML = rutaXML & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "\"
                    rutaXML = rutaXML & Today.ToString("yyyy-MM-dd") & "\"
                    Dim sce As New SistemaComprobantesElectronicos.GeneracionComprobantesElectronicos()
                    sce.GenerarXmlNotaCredito(dtCabecera, dtDetalle, rutaXML, nombreXML)
                    sce.GenerarPdf(dtCabecera, dtDetalle, "#CCCCCC", rutaXML, nombreXML)

                    Dim oSerieBL As New SerieBL()
                    Dim actualizaCorrelativo As Boolean = False
                    actualizaCorrelativo = oSerieBL.ActualizarCorrelativoPorEmpresaSerie(Convert.ToInt32(oEmpresa.emp_id), Me.cboTipo.SelectedValue.ToString(), Me.cboSeries.Text, (Convert.ToInt32(Me.txtCorrelativo.Text) + 1))

                    If actualizaCorrelativo Then

                       
                    Else
                        Throw New Exception("Hubo un problema y no se actualizoó el correlativo de Boleta")
                    End If

                    MessageBox.Show("Se registró y generó la Nota", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Else
                    MessageBox.Show("Debe ingresar el detalle", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Debe ingresar un monto de importe", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar serie y correlativo", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Cursor = Cursors.Default
    End Sub

    'Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
    '    Cursor = Cursors.WaitCursor
    '    If Me.cboSeries.SelectedIndex > 0 Then
    '        If Me.txtImporte.Text.Trim <> String.Empty Then
    '            If Me.txtDetalle.Text.Trim <> String.Empty Then

    '                Dim nroEmpresaConfig As Integer = 1
    '                Dim oSocioBL As New SocioBL()
    '                Dim oSocio As New SocioBE
    '                Dim emisorRUC As String = Me.dgvComprobantes.Rows(0).Cells("v_cc_emisor_ruc").Value
    '                Dim oEmpresaBL As New EmpresaBL()
    '                Dim oEmpresa As EmpresaBE = oEmpresaBL.ObtenerEmpresaPorRuc(emisorRUC)
    '                Dim ws As SFEService.GeneracionEnvioComprobantesSoapClient = New SFEService.GeneracionEnvioComprobantesSoapClient

    '                Select Case Me.cboTipo.SelectedIndex
    '                    Case 0
    '                        Dim objNotaCredito As New SFEService.NotaCredito
    '                        objNotaCredito.TipoComprobante = "07"
    '                        objNotaCredito.NumeroCorrelativo = Me.cboSeries.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text)).ToString()
    '                        objNotaCredito.FechaEmision = Me.dtpFecha.Value.ToString("yyyy-MM-dd")
    '                        objNotaCredito.RazonSocial = oEmpresa.emp_razsoc.ToUpper
    '                        objNotaCredito.NombreComercial = oEmpresa.emp_razsoc.ToUpper
    '                        objNotaCredito.DomicilioFiscal = oEmpresa.emp_direccion
    '                        'objNotaCredito.Ubigeo = "150130"
    '                        objNotaCredito.CalleNumero = oEmpresa.emp_direccion.ToUpper
    '                        objNotaCredito.Urbanizacion = ""
    '                        objNotaCredito.Departamento = "LIMA"
    '                        objNotaCredito.Provincia = "LIMA"
    '                        objNotaCredito.Distrito = oEmpresa.emp_distrito.ToUpper
    '                        objNotaCredito.NumeroRuc = oEmpresa.emp_nrodoc
    '                        objNotaCredito.TipoDocumentoIdentidad = "6"

    '                        oSocio = oSocioBL.ObtenerSocioPorNroDoc(Me.dgvComprobantes.Rows(0).Cells("v_cc_adquiriente_ruc").Value)
    '                        If oSocio.IdTipoDocumento = "1" Then
    '                            objNotaCredito.TipoDocumentoAdquiriente = "1"
    '                        ElseIf oSocio.IdTipoDocumento = "2" Then
    '                            objNotaCredito.TipoDocumentoAdquiriente = "6"
    '                        End If
    '                        objNotaCredito.NumeroDocumentoAdquiriente = oSocio.NumeroDocumento
    '                        objNotaCredito.DireccionAdquiriente = oSocio.Direccion.ToUpper
    '                        objNotaCredito.DireccionAdquiriente = oSocio.Direccion.ToUpper

    '                        objNotaCredito.SerieNumeroDocumentoModificado = Me.dgvComprobantes.Rows(0).Cells("v_cc_serie").Value & "-" & Me.dgvComprobantes.Rows(0).Cells("v_cc_numero").Value
    '                        objNotaCredito.TipoDocumentoModificado = Me.dgvComprobantes.Rows(0).Cells("c_cc_tipo").Value
    '                        objNotaCredito.MotivoSustento = Me.cboMotivo.Text
    '                        objNotaCredito.CodigoTipoNotaCredito = Me.cboMotivo.SelectedValue

    '                        objNotaCredito.TotalValorVentaGravada = Convert.ToDecimal("0")
    '                        objNotaCredito.TotalValorVentaInafecta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                        objNotaCredito.TotalValorVentaExonerada = Convert.ToDecimal("0")
    '                        'objNotaCredito.TotalValorVentaGratuita = Convert.ToDecimal("0")
    '                        objNotaCredito.TotalDescuentos = Convert.ToDecimal("0")
    '                        objNotaCredito.SumatoriaIgv = Convert.ToDecimal("0")
    '                        objNotaCredito.SumatoriaIsc = Convert.ToDecimal("0")
    '                        objNotaCredito.SumatoriaOtrosTributos = Convert.ToDecimal("0")
    '                        objNotaCredito.SumatoriaOtrosCargos = Convert.ToDecimal("0")
    '                        objNotaCredito.ImporteTotalVenta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                        'objNotaCredito.ImportePercepcion = Convert.ToDecimal("0")

    '                        objNotaCredito.TipoMoneda = Me.dgvComprobantes.Rows(0).Cells("c_cc_moneda").Value

    '                        Dim lstNotaCreditoItem As New List(Of SFEService.NotaCreditoItem)
    '                        Dim objNotaCreditoItem As New SFEService.NotaCreditoItem
    '                        objNotaCreditoItem.NumeroOrden = "1"
    '                        objNotaCreditoItem.UnidadMedida = "NIU"
    '                        objNotaCreditoItem.CantidadUnidades = "1"
    '                        objNotaCreditoItem.CodigoProducto = "LT RURAL"
    '                        objNotaCreditoItem.DescripcionProducto = Me.txtDetalle.Text.Trim
    '                        objNotaCreditoItem.PrecioVenta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                        objNotaCreditoItem.AfectacionIgv = "10"
    '                        objNotaCreditoItem.IgvItem = Convert.ToDecimal("0")
    '                        'objNotaCreditoItem.SistemaIsc = ""
    '                        objNotaCreditoItem.IscItem = Convert.ToDecimal("0")
    '                        objNotaCreditoItem.ValorUnitario = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                        'objNotaCreditoItem.ValorReferencialUnitario = Convert.ToDecimal("")
    '                        objNotaCreditoItem.ValorVenta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                        lstNotaCreditoItem.Add(objNotaCreditoItem)

    '                        Dim Respuesta As String = ws.ConstruirXmlNotaCredito(nroEmpresaConfig, objNotaCredito, lstNotaCreditoItem.ToArray(), oEmpresa.emp_nrodoc & "-" & "07" & "-" & Me.cboSeries.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text)).ToString() & ".xml", False, "", "", "#CCCCCC", False, False, False)


    '                    Case 1

    '                End Select

    '                ' RESUMEN DIARIO
    '                Dim correlativoResumenDiario As Integer = 1
    '                Dim objResumenDiario As New SFEService.ResumenDiario
    '                objResumenDiario.Identificador = "RC-" & Me.dtpFecha.Value.ToString("yyyy-MM-dd").Replace("-", "") & "-" & correlativoResumenDiario
    '                objResumenDiario.RazonSocial = oEmpresa.emp_razsoc
    '                objResumenDiario.TipoDocumentoIdentidad = "6"
    '                objResumenDiario.NumeroRuc = oEmpresa.emp_nrodoc
    '                objResumenDiario.FechaGeneracion = Me.dtpFecha.Value.ToString("yyyy-MM-dd")
    '                objResumenDiario.FechaEmisionDocumentos = Me.dtpFecha.Value.ToString("yyyy-MM-dd")

    '                Dim objResumenDiarioItem As New SFEService.ResumenDiarioItem()
    '                Dim lstResumenDiarioItem As New List(Of SFEService.ResumenDiarioItem)
    '                With objResumenDiarioItem
    '                    .NumeroFila = "1"
    '                    .NumeroSerie = Me.cboSeries.Text
    '                    .NumeroCorrelativo = (Convert.ToInt32(Me.txtCorrelativo.Text)).ToString()
    '                    .TipoComprobante = Me.dgvComprobantes.Rows(0).Cells("c_cc_tipo").Value
    '                    .NroDocumentoAdquiriente = oSocio.NumeroDocumento
    '                    If oSocio.IdTipoDocumento = "1" Then
    '                        .TipoDocumentoAdquiriente = "1"
    '                    ElseIf oSocio.IdTipoDocumento = "2" Then
    '                        .TipoDocumentoAdquiriente = "6"
    '                    End If
    '                    .Estado = "1"
    '                    .TipoMoneda = Me.dgvComprobantes.Rows(0).Cells("c_cc_moneda").Value
    '                    .ImporteTotalVenta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                    .TotalValorVentaGravada = "0"
    '                    .TotalValorVentaExonerada = "0"
    '                    .TotalValorVentaInafecta = Convert.ToDecimal(Me.txtImporte.Text.Trim)
    '                    .SumatoriaOtrosCargos = "0"
    '                    .TotalIgv = "0"
    '                    .TotalIsc = "0"
    '                    .TotalOtrosTributos = "0"
    '                End With
    '                lstResumenDiarioItem.Add(objResumenDiarioItem)

    '            Else
    '                MessageBox.Show("Debe ingresar el detalle", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
    '        Else
    '            MessageBox.Show("Debe ingresar un monto de importe", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        MessageBox.Show("Debe seleccionar serie y correlativo", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    '    Cursor = Cursors.Default
    'End Sub

    Private Sub CargarSeries()
        Dim emisorRUC As String = Me.dgvComprobantes.Rows(0).Cells("v_cc_emisor_ruc").Value
        Dim tipoComprobante As String = Me.cboTipo.SelectedValue.ToString
        Dim oSerieBL As New SerieBL
        Dim lstSeries As List(Of SerieBE)
        lstSeries = oSerieBL.ListarSeriesPorEmpresaRucTipo(emisorRUC, tipoComprobante)
        lstSeries.Insert(0, New SerieBE() With {.sre_id = 0, .sre_serie = "Seleccionar"})
        Me.cboSeries.DataSource = lstSeries
        Me.cboSeries.ValueMember = "sre_id"
        Me.cboSeries.DisplayMember = "sre_serie"
    End Sub

    Private Sub cboSerie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeries.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If IsNumeric(Me.cboSeries.SelectedValue) Then
            If Convert.ToInt32(Me.cboSeries.SelectedValue > 0) Then
                Dim emisorRUC As String = Me.dgvComprobantes.Rows(0).Cells("v_cc_emisor_ruc").Value
                Dim tipoComprobante As String = Me.cboTipo.SelectedValue.ToString
                Dim serie As String = Me.cboSeries.Text
                Dim oSerieBL As New SerieBL()
                Me.txtCorrelativo.Text = oSerieBL.ObtenerCorrelativoPorRucEmpresaSerieTipo(emisorRUC, serie, tipoComprobante)
            Else
                Me.txtCorrelativo.Text = ""
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub GenerarTxt(oCCabecera As ComprobanteCabeceraBE, lstCDetalle As List(Of ComprobanteDetalleBE))
        Try
            Dim textoTxt As String = ""
            Dim rutaTxt As String = ""
            Dim nombreTxt As String = oCCabecera.v_cc_emisor_ruc & "-" & oCCabecera.c_cc_tipo & "-" & oCCabecera.v_cc_serie & "-" & oCCabecera.v_cc_numero.PadLeft(7, "0") & ".txt"
            If oCCabecera.c_cc_tipo = "07" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_NOTA_CREDITO")
            ElseIf oCCabecera.c_cc_tipo = "08" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_NOTA_DEBITO")
            End If
            'rutaTxt = rutaTxt & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "\"
            rutaTxt = rutaTxt & Today.ToString("yyyy-MM-dd") & "\"
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
                       "0|0|" & oCCabecera.v_cc_montoletras & "|" & _
                        oCCabecera.c_cc_docmodif_tipo & "|" & _
                        oCCabecera.v_cc_docmodif_numero & "|" & _
                        oCCabecera.v_cc_docmodif_motivo.Substring(0, 2) & "|" & _
                        oCCabecera.v_cc_docmodif_motivo.Substring(5)

            ' DETALLE
            Dim i As Integer = 1
            For Each oDetalleItem As ComprobanteDetalleBE In lstCDetalle
                textoTxt &= "|" & "D" & "|" & _
                            i.ToString & "|" & _
                            oDetalleItem.v_cd_codigo & "|" & _
                            oDetalleItem.c_cd_unidad & "|" & _
                            oDetalleItem.v_cd_descripcion.Replace(System.Environment.NewLine, " ") & "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_cantidad) & "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_valorunitario) & "|" & _
                            "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_descuento) & "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_valorventa) & "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_igv) & "|" & _
                            "0.00|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_valorventa) & "|" & _
                            String.Format("{0:0.00}", oDetalleItem.n_cd_importe) & "|" & _
                            "1" & "|" & "0" & "|" & "0" & "|" & "0"
                i = i + 1
            Next
            oSW.Write(textoTxt)
            oSW.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class