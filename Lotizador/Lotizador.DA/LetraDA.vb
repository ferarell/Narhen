Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class LetraDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function ListarLetrasPendientes() As List(Of LetraBE)
        Dim lstBoleta As New List(Of LetraBE)
        Dim oBoletaBE As LetraBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_letras_pendientes", cnx)
                    cnx.Open()
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oBoletaBE = New LetraBE()
                            With oBoletaBE
                                '.bol_id = dr("").ToString
                                .bol_proyecto_id = dr("IdProyecto").ToString
                                .bol_proyecto_nombre = dr("Descripcion").ToString
                                .bol_cliente_id = dr("IdSocio").ToString
                                .bol_cliente_nombre = dr("Nombre").ToString
                                .bol_lote_id = dr("IdLote").ToString
                                .bol_lote_nombre = dr("Lote").ToString
                                .bol_nro_cuota = dr("NumeroCuota").ToString
                                .bol_fec_venc = dr("FechaCuota").ToString.Substring(0, 10)
                                .bol_moneda = dr("CodigoMoneda").ToString
                                .bol_importe = dr("ImporteCuota").ToString
                            End With
                            lstBoleta.Add(oBoletaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oBoletaBE = New BoletaBE()
            'With oBoletaBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstBoleta.Add(oBoletaBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstBoleta
    End Function

    Public Function ListarLetrasPendientesPorProyecto(idProyecto As Integer) As List(Of LetraBE)
        Dim lstBoleta As New List(Of LetraBE)
        Dim oBoletaBE As LetraBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_letras_pendientes_x_proyecto", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdProyecto", idProyecto))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oBoletaBE = New LetraBE()
                            With oBoletaBE
                                '.bol_id = dr("").ToString
                                .bol_proyecto_id = dr("IdProyecto").ToString
                                .bol_proyecto_nombre = dr("Descripcion").ToString
                                .bol_cliente_id = dr("IdSocio").ToString
                                .bol_cliente_nombre = dr("Nombre").ToString
                                .bol_lote_id = dr("IdLote").ToString
                                .bol_lote_nombre = dr("Lote").ToString
                                .bol_nro_cuota = dr("NumeroCuota").ToString
                                .bol_fec_venc = dr("FechaCuota").ToString.Substring(0, 10)
                                .bol_moneda = dr("CodigoMoneda").ToString
                                .bol_importe = dr("ImporteCuota").ToString
                                .bol_letra_id = dr("IdLetra").ToString
                            End With
                            lstBoleta.Add(oBoletaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oBoletaBE = New BoletaBE()
            'With oBoletaBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstBoleta.Add(oBoletaBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstBoleta
    End Function

    Public Function ListarLetrasPendientesPorProyectoSocio(idProyecto As Integer, idSocio As Integer) As List(Of LetraBE)
        Dim lstBoleta As New List(Of LetraBE)
        Dim oBoletaBE As LetraBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_letras_pendientes_x_proyecto_socio", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdProyecto", idProyecto))
                    cmd.Parameters.Add(New SqlParameter("@IdSocio", idSocio))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oBoletaBE = New LetraBE()
                            With oBoletaBE
                                '.bol_id = dr("").ToString
                                .bol_proyecto_id = dr("IdProyecto").ToString
                                .bol_proyecto_nombre = dr("Descripcion").ToString
                                .bol_cliente_id = dr("IdSocio").ToString
                                .bol_cliente_nombre = dr("Nombre").ToString
                                .bol_lote_id = dr("IdLote").ToString
                                .bol_lote_nombre = dr("Lote").ToString
                                .bol_nro_cuota = dr("NumeroCuota").ToString
                                .bol_fec_venc = dr("FechaCuota").ToString.Substring(0, 10)
                                .bol_moneda = dr("CodigoMoneda").ToString
                                .bol_importe = dr("ImporteCuota").ToString
                                .bol_letra_id = dr("IdLetra").ToString
                            End With
                            lstBoleta.Add(oBoletaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oBoletaBE = New BoletaBE()
            'With oBoletaBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstBoleta.Add(oBoletaBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstBoleta
    End Function

    Public Function ListarLetrasPendientesPorProyectoSocioLote(idProyecto As Integer, idSocio As Integer, idLote As Integer) As List(Of LetraBE)
        Dim lstBoleta As New List(Of LetraBE)
        Dim oBoletaBE As LetraBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_letras_pendientes_x_proyecto_socio_lote", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdProyecto", idProyecto))
                    cmd.Parameters.Add(New SqlParameter("@IdSocio", idSocio))
                    cmd.Parameters.Add(New SqlParameter("@IdLote", idLote))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oBoletaBE = New LetraBE()
                            With oBoletaBE
                                '.bol_id = dr("").ToString
                                .bol_proyecto_id = dr("IdProyecto").ToString
                                .bol_proyecto_nombre = dr("Descripcion").ToString
                                .bol_cliente_id = dr("IdSocio").ToString
                                .bol_cliente_nombre = dr("Nombre").ToString
                                .bol_lote_id = dr("IdLote").ToString
                                .bol_lote_nombre = dr("Lote").ToString
                                .bol_nro_cuota = dr("NumeroCuota").ToString
                                .bol_fec_venc = dr("FechaCuota").ToString.Substring(0, 10)
                                .bol_moneda = dr("CodigoMoneda").ToString
                                .bol_importe = dr("ImporteCuota").ToString
                                .bol_letra_id = dr("IdLetra").ToString
                            End With
                            lstBoleta.Add(oBoletaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oBoletaBE = New BoletaBE()
            'With oBoletaBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstBoleta.Add(oBoletaBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstBoleta
    End Function

    Public Function RegistrarLetraComprobante(idLetra As Integer) As Boolean
        Dim SeRegistro As Boolean = False
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Dim idComprobante As String
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_comprobante_ultimo_id", cnx)
                    cnx.Open()
                    cmd.CommandType = CommandType.StoredProcedure
                    idComprobante = cmd.ExecuteScalar()
                    cnx.Close()
                End Using
                Using cmd As SqlCommand = New SqlCommand("sp_registrar_comprobante_letra", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@n_cc_id", idComprobante))
                    cmd.Parameters.Add(New SqlParameter("@IdLetra", idLetra))
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                    cnx.Close()
                    SeRegistro = True
                End Using
            End Using
            Return SeRegistro
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function ListarLetrasPagadasPorProyectoSocioLote(idProyecto As Integer, idSocio As Integer, idLote As Integer) As List(Of LetraBE)
        Dim lstBoleta As New List(Of LetraBE)
        Dim oBoletaBE As LetraBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_letras_pagadas_x_proyecto_socio_lote", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdProyecto", idProyecto))
                    cmd.Parameters.Add(New SqlParameter("@IdSocio", idSocio))
                    cmd.Parameters.Add(New SqlParameter("@IdLote", idLote))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oBoletaBE = New LetraBE()
                            With oBoletaBE
                                '.bol_id = dr("").ToString
                                .bol_proyecto_id = dr("IdProyecto").ToString
                                .bol_proyecto_nombre = dr("Descripcion").ToString
                                .bol_cliente_id = dr("IdSocio").ToString
                                .bol_cliente_nombre = dr("Nombre").ToString
                                .bol_lote_id = dr("IdLote").ToString
                                .bol_lote_nombre = dr("Lote").ToString
                                .bol_nro_cuota = dr("NumeroCuota").ToString
                                .bol_fec_venc = dr("FechaCuota").ToString.Substring(0, 10)
                                .bol_moneda = dr("CodigoMoneda").ToString
                                .bol_importe = dr("ImporteCuota").ToString
                                .bol_letra_id = dr("IdLetra").ToString
                                .bol_tipo_pago = dr("bol_tipo_pago").ToString
                                .bol_nro_operacion = dr("bol_nro_operacion").ToString
                                .bol_fecha_pago = dr("bol_fecha_pago").ToString
                                .bol_tipo_documento = dr("bol_tipo_documento").ToString
                                .bol_nro_documento = dr("bol_nro_documento").ToString
                            End With
                            lstBoleta.Add(oBoletaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oBoletaBE = New BoletaBE()
            'With oBoletaBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstBoleta.Add(oBoletaBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstBoleta
    End Function

    Public Function EliminarLetraComprobante(idComprobante As Integer) As Boolean
        Dim SeRegistro As Boolean = False
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_eliminar_comprobante_letra", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@n_cc_id", idComprobante))
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                    cnx.Close()
                    SeRegistro = True
                End Using
            End Using
            Return SeRegistro
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function
End Class
