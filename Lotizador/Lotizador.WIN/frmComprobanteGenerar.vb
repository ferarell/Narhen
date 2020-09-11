Imports Lotizador.BE
Imports Lotizador.BL
Imports System.Configuration
Imports System.IO

Public Class frmComprobanteGenerar
    Public dtPendientes As New DataTable
    'Public tipoComprobante As String
    Friend IdProyecto As Integer
    Dim oNarhenService As New LotizadorService.NarhenClient

    Public Sub New(dt As DataTable)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtPendientes = dt
    End Sub

    Private Sub frmBoletaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dgvPendientes.DataSource = dtPendientes
        GenerarComboTipoComprobante()
        ListarEmpresas()
        Me.cboDocumento.SelectedIndex = 1
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Validate()
        Cursor = Cursors.WaitCursor
        If Me.cboSerie.SelectedIndex > -1 Then
            Try
                Dim nroEmpresaConfig As Integer = 1
                Dim oLetraBL As New LetraBL()
                Dim oSerieBL As New SerieBL()
                Dim oSocioBL As New SocioBL()
                Dim oEmpresaBL As New EmpresaBL()
                Dim oEmpresa As EmpresaBE = oEmpresaBL.ObtenerEmpresaPorId(Me.cboEmpresa.SelectedValue)

                Dim fechaResumenDiario As String = ""
                Dim correlativoResumenDiario As Integer = 1 'OBTENER CORRELATIVO POR FECHA
                Dim lstResumenDiarioItem As New List(Of SFEService.ResumenDiarioItem)

                Dim actualizaCorrelativo As Boolean = False
                Dim registraLetraComprobante As Boolean = False

                For i As Integer = 0 To Me.dgvPendientes.Rows.Count() - 1
                    actualizaCorrelativo = False
                    registraLetraComprobante = False

                    ' CABECERA
                    Dim oComprobanteCabecera As New ComprobanteCabeceraBE()
                    oComprobanteCabecera.c_cc_tipo = Me.cboDocumento.SelectedValue.ToString()
                    oComprobanteCabecera.v_cc_serie = Me.cboSerie.Text
                    oComprobanteCabecera.v_cc_numero = (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString()
                    oComprobanteCabecera.d_cc_fecha = Me.dtpFecha.Value.ToString("yyyy-MM-dd") '"2018-07-06"
                    oComprobanteCabecera.v_cc_emisor_razonsocial = oEmpresa.emp_razsoc.ToUpper
                    oComprobanteCabecera.v_cc_emisor_direccion = oEmpresa.emp_direccion.ToUpper
                    'oComprobanteCabecera.Ubigeo = "150140"
                    oComprobanteCabecera.v_cc_emisor_departamento = "LIMA"
                    'oComprobanteCabecera.Provincia = "LIMA"
                    oComprobanteCabecera.v_cc_emisor_distrito = oEmpresa.emp_distrito.ToUpper
                    'oComprobanteCabecera.Urbanizacion = ""
                    oComprobanteCabecera.c_cc_emisor_tipodoc = "6"
                    oComprobanteCabecera.v_cc_emisor_ruc = oEmpresa.emp_nrodoc
                    'oComprobanteCabecera.EmisorTelefono = "555-1111"

                    Dim oSocio As SocioBE = oSocioBL.ObtenerSocioPorId(Me.dgvPendientes.Rows(i).Cells("bol_cliente_id").Value)
                    oComprobanteCabecera.v_cc_adquiriente_razonsocial = Me.dgvPendientes.Rows(i).Cells("bol_cliente_nombre").Value
                    If oSocio.IdTipoDocumento = "1" Then
                        oComprobanteCabecera.c_cc_adquiriente_tipodoc = "1"
                    ElseIf oSocio.IdTipoDocumento = "2" Then
                        oComprobanteCabecera.c_cc_adquiriente_tipodoc = "6"
                    End If
                    oComprobanteCabecera.v_cc_adquiriente_ruc = oSocio.NumeroDocumento
                    oComprobanteCabecera.v_cc_adquiriente_direccion = oSocio.Direccion.ToUpper

                    oComprobanteCabecera.n_cc_gravado = Convert.ToDecimal("0") 'Convert.ToDecimal("10651.19")
                    oComprobanteCabecera.n_cc_inafecto = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    oComprobanteCabecera.n_cc_exonerado = Convert.ToDecimal("0")
                    'oComprobanteCabecera.TotalValorVentaGratuita = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_descuento = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_igv = Convert.ToDecimal("0")
                    'oComprobanteCabecera.SumatoriaIsc = Convert.ToDecimal("0")
                    oComprobanteCabecera.n_cc_total = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value) 'Convert.ToDecimal("12568.4")

                    oComprobanteCabecera.c_cc_moneda = Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value
                    oComprobanteCabecera.v_cc_montoletras = Numalet.ToCardinal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value.ToString()).ToUpper() & IIf(Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value = "PEN", " SOLES", " DOLARES")
                    'oComprobanteCabecera.PaisID = "PE"
                    'objBoleta.DescuentosGlobales = "0"

                    oComprobanteCabecera.c_cc_log_fecha = Today.ToString("yyyy-MM-dd")
                    oComprobanteCabecera.c_cc_log_hora = Now.ToString("HH:mm:ss")
                    oComprobanteCabecera.v_cc_log_usuario = Funciones.USUARIO

                    ' DETALLE
                    Dim lstComprobanteDetalle As New List(Of ComprobanteDetalleBE)
                    Dim oComprobanteDetalle As New ComprobanteDetalleBE()
                    oComprobanteDetalle.n_cd_id = i + 1
                    oComprobanteDetalle.c_cd_unidad = "NIU"
                    oComprobanteDetalle.n_cd_cantidad = Convert.ToDecimal("1")
                    oComprobanteDetalle.v_cd_codigo = ""
                    Dim loteNombre As String = Me.dgvPendientes.Rows(i).Cells("bol_lote_nombre").Value.ToString()
                    oComprobanteDetalle.v_cd_descripcion = "Letra " & Me.dgvPendientes.Rows(i).Cells("bol_nro_cuota").Value & " - Venta de Lote de Terreno Rustico" & " " &
                                                            "Programa de Vivienda " & Me.dgvPendientes.Rows(i).Cells("bol_proyecto_nombre").Value & " " &
                                                            "Mz " & loteNombre.Substring(0, loteNombre.LastIndexOf("-")) &
                                                            " Lote " & loteNombre.Substring(loteNombre.LastIndexOf("-") + 1, loteNombre.Length() - (loteNombre.LastIndexOf("-") + 1))
                    'oComprobanteDetalle.PrecioVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    'oComprobanteDetalle.AfectacionIgv = "10"
                    oComprobanteDetalle.n_cd_igv = Convert.ToDecimal("0")
                    'objBoletaItem.SistemaIsc = ""
                    'objBoletaItem.IscItem = Convert.ToDecimal("0")
                    oComprobanteDetalle.n_cd_valorunitario = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    'oComprobanteDetalle.ValorReferencialUnitario = Convert.ToDecimal("0")
                    oComprobanteDetalle.n_cd_valorventa = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    oComprobanteDetalle.n_cd_importe = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
                    oComprobanteDetalle.n_cd_descuento = Convert.ToDecimal("0")
                    lstComprobanteDetalle.Add(oComprobanteDetalle)

                    Dim ccBL As New ComprobanteCabeceraBL()
                    ccBL.Registra(oComprobanteCabecera, lstComprobanteDetalle)
                    GenerarTxt(oComprobanteCabecera, lstComprobanteDetalle)

                    Dim dtCabecera As DataTable = Funciones.CrearTablaComprobanteCabecera(oComprobanteCabecera)
                    Dim dtDetalle As DataTable = Funciones.CrearTablaComprobanteDetalle(lstComprobanteDetalle)
                    Dim rutaXML As String = ""
                    Dim nombreXML As String = oComprobanteCabecera.v_cc_emisor_ruc & "-" & oComprobanteCabecera.c_cc_tipo & "-" & oComprobanteCabecera.v_cc_serie & "-" & oComprobanteCabecera.v_cc_numero.PadLeft(7, "0") & ".xml"
                    If oComprobanteCabecera.c_cc_tipo = "01" Then
                        rutaXML = ConfigurationManager.AppSettings("_RUTA_FACTURA")
                    ElseIf oComprobanteCabecera.c_cc_tipo = "03" Then
                        rutaXML = ConfigurationManager.AppSettings("_RUTA_BOLETA")
                    End If
                    'rutaXML = rutaXML & Me.dtpFecha.Value.ToString("yyyy-MM-dd") & "\"
                    rutaXML = rutaXML & Today.ToString("yyyy-MM-dd") & "\"
                    Dim sce As New SistemaComprobantesElectronicos.GeneracionComprobantesElectronicos()
                    sce.GenerarXmlBoleta(dtCabecera, dtDetalle, rutaXML, nombreXML)
                    sce.GenerarPdf(dtCabecera, dtDetalle, "#CCCCCC", rutaXML, nombreXML)

                    actualizaCorrelativo = oSerieBL.ActualizarCorrelativoPorEmpresaSerie(Convert.ToInt32(Me.cboEmpresa.SelectedValue), Me.cboDocumento.SelectedValue.ToString(), Me.cboSerie.Text, (Convert.ToInt32(Me.txtCorrelativo.Text) + i + 1))

                    If actualizaCorrelativo Then

                        registraLetraComprobante = oLetraBL.RegistrarLetraComprobante(Me.dgvPendientes.Rows(i).Cells("bol_letra_id").Value)

                        If registraLetraComprobante Then

                        Else
                            Throw New Exception("Hubo un problema y no se registró en Comprobante-Letra")
                        End If
                    Else
                        Throw New Exception("Hubo un problema y no se actualizoó el correlativo de Boleta")
                    End If

                Next

                MessageBox.Show("Se registraron y generaron los Comprobantes", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Debe selecccionar una Serie", "Lotizador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Cursor = Cursors.Default
    End Sub

    'Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
    '    Cursor = Cursors.WaitCursor
    '    If Me.cboSerie.SelectedIndex > 0 Then
    '        Try
    '            Dim nroEmpresaConfig As Integer = 1
    '            Dim oLetraBL As New LetraBL()
    '            Dim oSerieBL As New SerieBL()
    '            Dim oSocioBL As New SocioBL()
    '            Dim oEmpresaBL As New EmpresaBL()
    '            Dim oEmpresa As EmpresaBE = oEmpresaBL.ObtenerEmpresaPorId(Me.cboEmpresa.SelectedValue)

    '            Dim sce As New SistemaComprobantesElectronicos.GeneracionComprobantesElectronicos()

    '            Dim ws As SFEService.GeneracionEnvioComprobantesSoapClient = New SFEService.GeneracionEnvioComprobantesSoapClient

    '            Dim fechaResumenDiario As String = ""
    '            Dim correlativoResumenDiario As Integer = 1 'OBTENER CORRELATIVO POR FECHA
    '            Dim lstResumenDiarioItem As New List(Of SFEService.ResumenDiarioItem)

    '            Dim actualizaCorrelativo As Boolean = False
    '            Dim registraLetraComprobante As Boolean = False

    '            For i As Integer = 0 To Me.dgvPendientes.Rows.Count() - 1
    '                actualizaCorrelativo = False
    '                registraLetraComprobante = False
    '                Dim objBoleta As New SFEService.Boleta
    '                'Dim objBoleta As New LibrosElectronicos.Boleta
    '                ' CABECERA
    '                objBoleta.TipoComprobante = tipoComprobante
    '                objBoleta.NumeroCorrelativo = Me.cboSerie.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString()
    '                objBoleta.FechaEmision = Me.dtpFecha.Value.ToString("yyyy-MM-dd") '"2018-07-06"
    '                objBoleta.RazonSocial = oEmpresa.emp_razsoc.ToUpper
    '                objBoleta.NombreComercial = oEmpresa.emp_razsoc.ToUpper
    '                objBoleta.DomicilioFiscal = oEmpresa.emp_direccion
    '                'objBoleta.Ubigeo = "150140"
    '                objBoleta.CalleNumero = oEmpresa.emp_direccion.ToUpper
    '                objBoleta.Departamento = "LIMA"
    '                objBoleta.Provincia = "LIMA"
    '                objBoleta.Distrito = oEmpresa.emp_distrito.ToUpper
    '                objBoleta.Urbanizacion = ""
    '                objBoleta.TipoDocumentoIdentidad = "6"
    '                objBoleta.NumeroRuc = oEmpresa.emp_nrodoc
    '                'objBoleta.EmisorTelefono = "555-1111"

    '                Dim oSocio As SocioBE = oSocioBL.ObtenerSocioPorId(Me.dgvPendientes.Rows(i).Cells("bol_cliente_id").Value)
    '                objBoleta.RazonSocialAdquiriente = Me.dgvPendientes.Rows(i).Cells("bol_cliente_nombre").Value
    '                If oSocio.IdTipoDocumento = "1" Then
    '                    objBoleta.TipoDocumentoAdquiriente = "1"
    '                ElseIf oSocio.IdTipoDocumento = "2" Then
    '                    objBoleta.TipoDocumentoAdquiriente = "6"
    '                End If
    '                objBoleta.NumeroDocumentoAdquiriente = oSocio.NumeroDocumento
    '                objBoleta.DireccionAdquiriente = oSocio.Direccion.ToUpper

    '                objBoleta.TotalValorVentaGravada = Convert.ToDecimal("0") 'Convert.ToDecimal("10651.19")
    '                objBoleta.TotalValorVentaInafecta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                objBoleta.TotalValorVentaExonerada = Convert.ToDecimal("0")
    '                objBoleta.TotalValorVentaGratuita = Convert.ToDecimal("0")
    '                objBoleta.TotalDescuentos = Convert.ToDecimal("0")
    '                objBoleta.SumatoriaIgv = Convert.ToDecimal("0")
    '                objBoleta.SumatoriaIsc = Convert.ToDecimal("0")
    '                objBoleta.ImporteTotalVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value) 'Convert.ToDecimal("12568.4")

    '                objBoleta.TipoMoneda = Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value
    '                objBoleta.LeyendaImporteTotalVentaLetras = Numalet.ToCardinal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value.ToString()).ToUpper() & IIf(Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value = "PEN", " SOLES", " DOLARES")
    '                objBoleta.PaisID = "PE"
    '                'objBoleta.DescuentosGlobales = "0"

    '                ' DETALLE
    '                Dim objBoletaItem As New SFEService.BoletaItem
    '                Dim lstBoletaItem As New List(Of SFEService.BoletaItem)
    '                'Dim objBoletaItem As New LibrosElectronicos.BoletaItem
    '                'Dim lstBoletaItem As New List(Of LibrosElectronicos.BoletaItem)
    '                objBoletaItem.NumeroOrden = i + 1
    '                objBoletaItem.UnidadMedida = "NIU"
    '                objBoletaItem.CantidadUnidades = Convert.ToDecimal("1")
    '                objBoletaItem.CodigoProducto = ""
    '                Dim loteNombre As String = Me.dgvPendientes.Rows(i).Cells("bol_lote_nombre").Value.ToString()
    '                objBoletaItem.DescripcionProducto = "Letra " & Me.dgvPendientes.Rows(i).Cells("bol_nro_cuota").Value & " - Venta de Lote de Terreno Rústico" & vbNewLine & _
    '                                                    "Programa de Vivienda " & Me.dgvPendientes.Rows(i).Cells("bol_proyecto_nombre").Value & vbNewLine & _
    '                                                    "Mz " & loteNombre.Substring(0, loteNombre.LastIndexOf("-")) & " Lote " & loteNombre.Substring(loteNombre.LastIndexOf("-") + 1, loteNombre.Length() - (loteNombre.LastIndexOf("-") + 1))
    '                objBoletaItem.PrecioVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                objBoletaItem.AfectacionIgv = "10"
    '                objBoletaItem.IgvItem = Convert.ToDecimal("0")
    '                'objBoletaItem.SistemaIsc = ""
    '                'objBoletaItem.IscItem = Convert.ToDecimal("0")
    '                objBoletaItem.ValorUnitario = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                objBoletaItem.ValorReferencialUnitario = Convert.ToDecimal("0")
    '                objBoletaItem.ValorVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                objBoletaItem.DescuentoItem = Convert.ToDecimal("0")
    '                lstBoletaItem.Add(objBoletaItem)

    '                Dim Respuesta As String = ""
    '                If tipoComprobante = "03" Then
    '                    Respuesta = ws.ConstruirXmlBoleta(nroEmpresaConfig, objBoleta, lstBoletaItem.ToArray(), Nothing, oEmpresa.emp_nrodoc & "-" & tipoComprobante & "-" & Me.cboSerie.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString() & ".xml", False, "", "", "#CCCCCC", False, False, False)

    '                    'sce.GenerarXmlBoleta(objBoleta, lstBoletaItem, Nothing, "C:\Facturacion_Electronica\", oEmpresa.emp_nrodoc & "-" & tipoComprobante & "-" & Me.cboSerie.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString() & ".xml")


    '                ElseIf tipoComprobante = "01" Then

    '                    'Dim objFactura As New LibrosElectronicos.Factura()
    '                    'Dim lstFacturaItem As New List(Of LibrosElectronicos.FacturaItem)
    '                    'Dim sce As New SistemaComprobantesElectronicos.GeneracionComprobantesElectronicos
    '                    'sce.GenerarXmlFactura(objFactura, lstFacturaItem, Nothing, "", "")
    '                    ' Respuesta = ws.ConstruirXmlFactura(nroEmpresaConfig, objBoleta, lstBoletaItem.ToArray(), Nothing, oEmpresa.emp_nrodoc & "-" & tipoComprobante & "-" & Me.cboSerie.Text & "-" & (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString() & ".xml", False, "", "", "#CCCCCC", False, False, False)
    '                End If

    '                actualizaCorrelativo = oSerieBL.ActualizarCorrelativoPorEmpresaSerie(Convert.ToInt32(Me.cboEmpresa.SelectedValue), Me.cboSerie.Text, (Convert.ToInt32(Me.txtCorrelativo.Text) + i + 1))

    '                If actualizaCorrelativo Then

    '                    registraLetraComprobante = oLetraBL.RegistrarLetraComprobante(Me.dgvPendientes.Rows(i).Cells("bol_letra_id").Value)

    '                    If registraLetraComprobante Then

    '                        If tipoComprobante = "03" Then
    '                            ' Resumen Diario solo si son Boletas

    '                            '------------ <RESUMEN_DIARIO> '------------'
    '                            ' Guardamos el detalle para el Resumen Diario 
    '                            If fechaResumenDiario = "" Then fechaResumenDiario = objBoleta.FechaEmision
    '                            Dim objResumenDiarioItem As New SFEService.ResumenDiarioItem()
    '                            With objResumenDiarioItem
    '                                .NumeroFila = i + 1
    '                                .NumeroSerie = Me.cboSerie.Text
    '                                .NumeroCorrelativo = (Convert.ToInt32(Me.txtCorrelativo.Text) + i).ToString()
    '                                .TipoComprobante = tipoComprobante
    '                                .NroDocumentoAdquiriente = oSocio.NumeroDocumento
    '                                If oSocio.IdTipoDocumento = "1" Then
    '                                    .TipoDocumentoAdquiriente = "1"
    '                                ElseIf oSocio.IdTipoDocumento = "2" Then
    '                                    .TipoDocumentoAdquiriente = "6"
    '                                End If
    '                                .Estado = "1"
    '                                .TipoMoneda = Me.dgvPendientes.Rows(i).Cells("bol_moneda").Value
    '                                .ImporteTotalVenta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                                .TotalValorVentaGravada = "0"
    '                                .TotalValorVentaExonerada = "0"
    '                                .TotalValorVentaInafecta = Convert.ToDecimal(Me.dgvPendientes.Rows(i).Cells("bol_importe").Value)
    '                                .SumatoriaOtrosCargos = "0"
    '                                .TotalIgv = "0"
    '                                .TotalIsc = "0"
    '                                .TotalOtrosTributos = "0"
    '                            End With
    '                            lstResumenDiarioItem.Add(objResumenDiarioItem)
    '                            '------------ </RESUMEN_DIARIO> '------------'

    '                        End If

    '                    Else
    '                        Throw New Exception("Hubo un problema y no se registró en Comprobante-Letra")
    '                    End If
    '                Else
    '                    Throw New Exception("Hubo un problema y no se actualizoó el correlativo de Boleta")
    '                End If

    '            Next

    '            If tipoComprobante = "03" Then
    '                Dim objResumenDiario As New SFEService.ResumenDiario
    '                objResumenDiario.Identificador = "RC-" & fechaResumenDiario.Replace("-", "") & "-" & correlativoResumenDiario
    '                objResumenDiario.RazonSocial = oEmpresa.emp_razsoc
    '                objResumenDiario.TipoDocumentoIdentidad = "6"
    '                objResumenDiario.NumeroRuc = oEmpresa.emp_nrodoc
    '                objResumenDiario.FechaGeneracion = fechaResumenDiario
    '                objResumenDiario.FechaEmisionDocumentos = fechaResumenDiario

    '                Dim ticket As String = ws.ConstruirXmlResumenDiario(nroEmpresaConfig, objResumenDiario, lstResumenDiarioItem.ToArray(), oEmpresa.emp_nrodoc & "-RC-" & fechaResumenDiario & "-" & correlativoResumenDiario & ".xml")

    '            End If

    '            MessageBox.Show("Se registraron y generaron los Comprobantes", "Lotizador")
    '            Me.Close()
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, "Lotizador")
    '        End Try
    '    Else
    '        MessageBox.Show("Debe selecccionar una Serie", "Lotizador")
    '    End If
    '    Cursor = Cursors.Default
    'End Sub

    Private Sub ListarEmpresas()
        Dim oEmpresaBL As New EmpresaBL
        Dim lstEmpresas As List(Of EmpresaBE)
        lstEmpresas = oEmpresaBL.ListarEmpresas()
        Me.cboEmpresa.DataSource = lstEmpresas
        Me.cboEmpresa.ValueMember = "emp_id"
        Me.cboEmpresa.DisplayMember = "emp_razsoc"
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        Me.txtCorrelativo.Text = ""
        If IsNumeric(Me.cboEmpresa.SelectedValue) Then
            Dim idEmpresa As Integer = Me.cboEmpresa.SelectedValue
            'ListarSeriesPorEmpresa(idEmpresa)
            CargarSeries()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub ListarSeriesPorEmpresa(idEmpresa As Integer)
        If Me.cboEmpresa.SelectedValue <> 0 Then
            Dim oSerieBL As New SerieBL
            Dim lstSeries As List(Of SerieBE)
            lstSeries = oSerieBL.ListarSeriesPorEmpresa(idEmpresa)
            lstSeries.Insert(0, New SerieBE() With {.sre_id = 0, .sre_serie = "Seleccionar"})
            Me.cboSerie.DataSource = lstSeries
            Me.cboSerie.ValueMember = "sre_id"
            Me.cboSerie.DisplayMember = "sre_serie"
        Else
            ' Limpiamos Lote
            Me.cboSerie.DataSource = Nothing
            Me.cboSerie.Items.Add("Seleccionar")
            Me.cboSerie.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboSerie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSerie.SelectedIndexChanged
        Cursor = Cursors.WaitCursor
        If IsNumeric(Me.cboSerie.SelectedValue) Then
            If Convert.ToInt32(Me.cboSerie.SelectedValue > 0) Then
                Dim idEmpresa As Integer = Me.cboEmpresa.SelectedValue
                Dim serie As String = Me.cboSerie.Text
                Dim oSerieBL As New SerieBL()
                Me.txtCorrelativo.Text = oSerieBL.ObtenerCorrelativoPorEmpresaSerie(idEmpresa, serie)
            Else
                Me.txtCorrelativo.Text = ""
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub cboDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumento.SelectedIndexChanged
        'If Me.cboDocumento.SelectedIndex = 0 Then
        '    tipoComprobante = "03" ' Boleta
        'ElseIf Me.cboDocumento.SelectedIndex = 1 Then
        '    tipoComprobante = "01" ' Factura
        'End If
        CargarSeries()
    End Sub

    Private Sub GenerarTxt(oCCabecera As ComprobanteCabeceraBE, lstCDetalle As List(Of ComprobanteDetalleBE))
        Try
            Dim textoTxt As String = ""
            Dim rutaTxt As String = ""
            Dim nombreTxt As String = oCCabecera.v_cc_emisor_ruc & "-" & oCCabecera.c_cc_tipo & "-" & oCCabecera.v_cc_serie & "-" & oCCabecera.v_cc_numero.PadLeft(7, "0") & ".txt"
            If oCCabecera.c_cc_tipo = "01" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_FACTURA")
            ElseIf oCCabecera.c_cc_tipo = "03" Then
                rutaTxt = ConfigurationManager.AppSettings("_RUTA_BOLETA")
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
                       "0|0|" & oCCabecera.v_cc_montoletras

            ' DETALLE
            Dim i As Integer = 1
            For Each oDetalleItem As ComprobanteDetalleBE In lstCDetalle
                textoTxt &= "|" & "D" & "|" & _
                            i.ToString & "|" & _
                            oDetalleItem.v_cd_codigo & "|" & _
                            oDetalleItem.c_cd_unidad & "|" & _
                            oDetalleItem.v_cd_descripcion & "|" & _
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

    Private Sub GenerarComboTipoComprobante()
        Dim dt As DataTable = CrearTablaTipoComprobante()
        'Dim dt As DataTable = oNarhenService.ExecuteSQL("EXEC upObtenerSecuenciaPorProyectoTipoDocumentoSCE " & IdProyecto.ToString).Tables(0)
        Me.cboDocumento.DataSource = dt
        Me.cboDocumento.ValueMember = "codigo"
        Me.cboDocumento.DisplayMember = "descripcion"
        Me.cboDocumento.SelectedIndex = 0
    End Sub

    Private Function CrearTablaTipoComprobante() As DataTable
        Dim table As New DataTable
        table.Columns.Add("codigo", GetType(String))
        table.Columns.Add("descripcion", GetType(String))

        table.Rows.Add("01", "FACTURA")
        table.Rows.Add("03", "BOLETA")

        Return table
    End Function

    Private Sub CargarSeries()
        'If Not Me.cboEmpresa.SelectedValue Is Nothing Then
        '    If Not Me.cboDocumento.SelectedValue Is Nothing Then
        '        Dim empresaID As String = Me.cboEmpresa.SelectedValue.ToString
        '        Dim tipoComprobante As String = Me.cboDocumento.SelectedValue.ToString
        '        Dim oSerieBL As New SerieBL
        '        Dim lstSeries As List(Of SerieBE)
        '        lstSeries = oSerieBL.ListarSeriesPorEmpresaTipo(empresaID, tipoComprobante)
        '        lstSeries.Insert(0, New SerieBE() With {.sre_id = 0, .sre_serie = "Seleccionar"})
        '        Me.cboSerie.DataSource = lstSeries
        '        Me.cboSerie.ValueMember = "sre_id"
        '        Me.cboSerie.DisplayMember = "sre_serie"
        '    End If
        'End If
        Dim dt As DataTable = oNarhenService.ExecuteSQL("EXEC upObtenerSecuenciaPorProyectoTipoDocumentoSCE " & IdProyecto.ToString).Tables(0)
        Me.cboSerie.DataSource = dt
        Me.cboSerie.ValueMember = "sre_id"
        Me.cboSerie.DisplayMember = "sre_serie"
        If dt.Rows.Count > 0 Then
            Me.cboSerie.SelectedIndex = 0
        End If

    End Sub

End Class