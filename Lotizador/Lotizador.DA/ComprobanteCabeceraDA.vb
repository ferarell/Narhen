Imports Lotizador.BE
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ComprobanteCabeceraDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Sub Registra(oCCabecera As ComprobanteCabeceraBE)
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_registra_comprobante_cabecera", cnx)
                    Dim parSequencia As SqlParameter = New SqlParameter("@n_cc_id", SqlDbType.Decimal)
                    parSequencia.Value = oCCabecera.n_cc_id
                    parSequencia.Precision = 10
                    parSequencia.Direction = ParameterDirection.InputOutput
                    oCmd.Parameters.Add(parSequencia)

                    oCmd.Parameters.Add(New SqlParameter("@c_cc_tipo", oCCabecera.c_cc_tipo))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_serie", oCCabecera.v_cc_serie))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_numero", oCCabecera.v_cc_numero))
                    oCmd.Parameters.Add(New SqlParameter("@d_cc_fecha", oCCabecera.d_cc_fecha))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_moneda", oCCabecera.c_cc_moneda))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_razonsocial", oCCabecera.v_cc_emisor_razonsocial))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_emisor_tipodoc", oCCabecera.c_cc_emisor_tipodoc))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_ruc", oCCabecera.v_cc_emisor_ruc))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_direccion", oCCabecera.v_cc_emisor_direccion))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_adquiriente_razonsocial", oCCabecera.v_cc_adquiriente_razonsocial))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_adquiriente_tipodoc", oCCabecera.c_cc_adquiriente_tipodoc))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_adquiriente_ruc", oCCabecera.v_cc_adquiriente_ruc))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_adquiriente_direccion", oCCabecera.v_cc_adquiriente_direccion))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_docmodif_tipo", oCCabecera.c_cc_docmodif_tipo))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_docmodif_numero", oCCabecera.v_cc_docmodif_numero))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_docmodif_motivo", oCCabecera.v_cc_docmodif_motivo))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_gravado", oCCabecera.n_cc_gravado))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_exonerado", oCCabecera.n_cc_exonerado))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_inafecto", oCCabecera.n_cc_inafecto))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_igv", oCCabecera.n_cc_igv))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_descuento", oCCabecera.n_cc_descuento))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_total", oCCabecera.n_cc_total))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_montoletras", oCCabecera.v_cc_montoletras))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_guiaremision", oCCabecera.v_cc_guiaremision))
                    oCmd.Parameters.Add(New SqlParameter("@v_sunat_rpta_codigo", oCCabecera.v_sunat_rpta_codigo))
                    oCmd.Parameters.Add(New SqlParameter("@v_sunat_rpta_msje", oCCabecera.v_sunat_rpta_msje))
                    oCmd.Parameters.Add(New SqlParameter("@v_archivo_xml", oCCabecera.v_archivo_xml))
                    oCmd.Parameters.Add(New SqlParameter("@v_xml_valor_resumen", oCCabecera.v_xml_valor_resumen))
                    oCmd.Parameters.Add(New SqlParameter("@v_xml_valor_firma", oCCabecera.v_xml_valor_firma))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_telefono", oCCabecera.v_cc_emisor_telefono))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_departamento", oCCabecera.v_cc_emisor_departamento))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_observaciones1", oCCabecera.v_cc_emisor_observaciones1))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_emisor_observaciones2", oCCabecera.v_cc_emisor_observaciones2))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_anticipos", oCCabecera.n_cc_anticipos))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_isc", oCCabecera.n_cc_isc))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_otros_tributos", oCCabecera.n_cc_otros_tributos))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_otros_cargos", oCCabecera.n_cc_otros_cargos))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_percepcion", oCCabecera.n_cc_percepcion))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_dsctos_globales", oCCabecera.n_cc_dsctos_globales))
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_venta_gratuita", oCCabecera.n_cc_venta_gratuita))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_log_fecha", oCCabecera.c_cc_log_fecha))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_log_hora", oCCabecera.c_cc_log_hora))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_log_usuario", oCCabecera.v_cc_log_usuario))

                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()
                    oCmd.ExecuteNonQuery()

                    oCCabecera.n_cc_id = Convert.ToDecimal(parSequencia.Value)
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Sub

    Public Function Buscar(TipoComprobante As String, NumeroSerie As String, NumeroCorrelativo As String) As DataTable
        Try
            Dim dt As New DataTable
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_buscar_comprobante_cabecera", cnx)
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_tipo", TipoComprobante))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_serie", NumeroSerie))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_numero", NumeroCorrelativo))

                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()

                    Using dr As SqlDataAdapter = New SqlDataAdapter(oCmd)
                        dr.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Buscar(n_cc_id As Integer) As DataTable
        Try
            Dim dt As New DataTable
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_buscar_comprobante_cabecera", cnx)
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_id", n_cc_id))

                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()

                    Using dr As SqlDataAdapter = New SqlDataAdapter(oCmd)
                        dr.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Sub ActualizaEstadoComprobantes(TipoComprobante As String, NroSerie As String, NroCorrelativo As String, logFecha As String, logHora As String, logUsuario As String)
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_actualiza_estado_comprobante", cnx)
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_tipo", TipoComprobante))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_serie", NroSerie))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_numero", NroCorrelativo))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_log_fecha", logFecha))
                    oCmd.Parameters.Add(New SqlParameter("@c_cc_log_hora", logHora))
                    oCmd.Parameters.Add(New SqlParameter("@v_cc_log_usuario", logUsuario))

                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()
                    oCmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try

    End Sub

End Class
