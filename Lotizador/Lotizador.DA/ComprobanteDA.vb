Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class ComprobanteDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function ListarComprobantes() As List(Of ComprobanteBE)
        Dim lstComprobantes As New List(Of ComprobanteBE)
        Dim oComprobante As ComprobanteBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_comprobantes", cnx)
                    cnx.Open()
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oComprobante = New ComprobanteBE()
                            With oComprobante
                                .n_cc_id = Convert.ToInt32(dr("n_cc_id").ToString)
                                .d_cc_fecha = dr("d_cc_fecha").ToString.Substring(0, 10)
                                .c_cc_tipo = dr("c_cc_tipo").ToString
                                .v_cc_serie = dr("v_cc_serie").ToString
                                .v_cc_numero = dr("v_cc_numero").ToString
                                .v_cc_emisor_ruc = dr("v_cc_emisor_ruc").ToString
                                .v_cc_emisor_razonsocial = dr("v_cc_emisor_razonsocial").ToString
                                .c_cc_adquiriente_tipodoc = dr("c_cc_adquiriente_tipodoc").ToString
                                .v_cc_adquiriente_ruc = dr("v_cc_adquiriente_ruc").ToString
                                .v_cc_adquiriente_razonsocial = dr("v_cc_adquiriente_razonsocial").ToString
                                .c_cc_moneda = dr("c_cc_moneda").ToString
                                .n_cc_total = Convert.ToDecimal(dr("n_cc_total").ToString)
                            End With
                            lstComprobantes.Add(oComprobante)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return lstComprobantes
    End Function

    Public Function ListarComprobantesPorTipo(tipoComprobante As String) As List(Of ComprobanteBE)
        Dim lstComprobantes As New List(Of ComprobanteBE)
        Dim oComprobante As ComprobanteBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_comprobantes_x_tipo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@c_cc_tipo", tipoComprobante))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oComprobante = New ComprobanteBE()
                            With oComprobante
                                .n_cc_id = Convert.ToInt32(dr("n_cc_id").ToString)
                                .d_cc_fecha = dr("d_cc_fecha").ToString.Substring(0, 10)
                                .c_cc_tipo = dr("c_cc_tipo").ToString
                                .v_cc_serie = dr("v_cc_serie").ToString
                                .v_cc_numero = dr("v_cc_numero").ToString
                                .v_cc_emisor_ruc = dr("v_cc_emisor_ruc").ToString
                                .v_cc_emisor_razonsocial = dr("v_cc_emisor_razonsocial").ToString
                                .c_cc_adquiriente_tipodoc = dr("c_cc_adquiriente_tipodoc").ToString
                                .v_cc_adquiriente_ruc = dr("v_cc_adquiriente_ruc").ToString
                                .v_cc_adquiriente_razonsocial = dr("v_cc_adquiriente_razonsocial").ToString
                                .c_cc_moneda = dr("c_cc_moneda").ToString
                                .n_cc_total = Convert.ToDecimal(dr("n_cc_total").ToString)
                            End With
                            lstComprobantes.Add(oComprobante)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return lstComprobantes
    End Function

    Public Function ListarComprobantesPorTipoPorCliente(tipoComprobante As String, cliente As String) As List(Of ComprobanteBE)
        Dim lstComprobantes As New List(Of ComprobanteBE)
        Dim oComprobante As ComprobanteBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_comprobantes_x_tipo_x_cliente", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@c_cc_tipo", tipoComprobante))
                    cmd.Parameters.Add(New SqlParameter("@v_cc_adquiriente_razonsocial", cliente))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oComprobante = New ComprobanteBE()
                            With oComprobante
                                .n_cc_id = Convert.ToInt32(dr("n_cc_id").ToString)
                                .d_cc_fecha = dr("d_cc_fecha").ToString.Substring(0, 10)
                                .c_cc_tipo = dr("c_cc_tipo").ToString
                                .v_cc_serie = dr("v_cc_serie").ToString
                                .v_cc_numero = dr("v_cc_numero").ToString
                                .v_cc_emisor_ruc = dr("v_cc_emisor_ruc").ToString
                                .v_cc_emisor_razonsocial = dr("v_cc_emisor_razonsocial").ToString
                                .c_cc_adquiriente_tipodoc = dr("c_cc_adquiriente_tipodoc").ToString
                                .v_cc_adquiriente_ruc = dr("v_cc_adquiriente_ruc").ToString
                                .v_cc_adquiriente_razonsocial = dr("v_cc_adquiriente_razonsocial").ToString
                                .c_cc_moneda = dr("c_cc_moneda").ToString
                                .n_cc_total = Convert.ToDecimal(dr("n_cc_total").ToString)
                            End With
                            lstComprobantes.Add(oComprobante)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return lstComprobantes
    End Function

End Class
