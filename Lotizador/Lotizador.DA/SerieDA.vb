Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class SerieDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function ListarSeries() As List(Of SerieBE)
        Dim lstSerie As New List(Of SerieBE)
        Dim oSerieBE As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_series", cnx)
                    cnx.Open()
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSerieBE = New SerieBE()
                            With oSerieBE
                                .sre_id = dr("sre_id").ToString
                                .sre_tipdoc = dr("sre_tipdoc").ToString
                                .sre_serie = dr("sre_serie").ToString
                                .sre_correlativo = dr("sre_correlativo").ToString
                                .emp_id = dr("emp_id").ToString
                                .emp_razsoc = dr("emp_razsoc").ToString
                            End With
                            lstSerie.Add(oSerieBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oSerieBE = New SerieBE()
            'With oSerieBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstSerie.Add(oSerieBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSerie
    End Function

    Public Function Registrar(oSerie As SerieBE) As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_registrar_serie", cnx)
                    cnx.Open()

                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", oSerie.sre_tipdoc))
                    cmd.Parameters.Add(New SqlParameter("@sre_serie", oSerie.sre_serie))
                    cmd.Parameters.Add(New SqlParameter("@sre_correlativo", oSerie.sre_correlativo))
                    cmd.Parameters.Add(New SqlParameter("@sre_estado", "A"))
                    cmd.Parameters.Add(New SqlParameter("@emp_id", oSerie.emp_id))


                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oSerie
    End Function

    Public Function Actualizar(oSerie As SerieBE) As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_actualizar_serie", cnx)
                    cnx.Open()

                    cmd.Parameters.Add(New SqlParameter("@sre_id", oSerie.sre_id))
                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", oSerie.sre_tipdoc))
                    cmd.Parameters.Add(New SqlParameter("@sre_serie", oSerie.sre_serie))
                    cmd.Parameters.Add(New SqlParameter("@sre_correlativo", oSerie.sre_correlativo))
                    cmd.Parameters.Add(New SqlParameter("@sre_estado", "A"))
                    cmd.Parameters.Add(New SqlParameter("@emp_id", oSerie.emp_id))

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oSerie
    End Function

    Public Function ListarSeriesPorEmpresa(idEmpresa As Integer) As List(Of SerieBE)
        Dim lstSeries As New List(Of SerieBE)
        Dim oSerie As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_series_x_empresa", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_id", idEmpresa))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSerie = New SerieBE()
                            With oSerie
                                .sre_id = dr("sre_id").ToString
                                .sre_serie = dr("sre_serie").ToString
                            End With
                            lstSeries.Add(oSerie)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSeries
    End Function

    Public Function ListarSeriesPorEmpresaTipo(idEmpresa As Integer, tipoComprobante As String) As List(Of SerieBE)
        Dim lstSeries As New List(Of SerieBE)
        Dim oSerie As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_series_x_empresa_tipo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_id", idEmpresa))
                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", tipoComprobante))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSerie = New SerieBE()
                            With oSerie
                                .sre_id = dr("sre_id").ToString
                                .sre_serie = dr("sre_serie").ToString
                            End With
                            lstSeries.Add(oSerie)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSeries
    End Function

    Public Function ListarSeriesPorEmpresaRucTipo(rucEmpresa As String, tipoComprobante As String) As List(Of SerieBE)
        Dim lstSeries As New List(Of SerieBE)
        Dim oSerie As SerieBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_series_x_empresa_ruc_tipo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_nrodoc", rucEmpresa))
                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", tipoComprobante))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSerie = New SerieBE()
                            With oSerie
                                .sre_id = dr("sre_id").ToString
                                .sre_serie = dr("sre_serie").ToString
                            End With
                            lstSeries.Add(oSerie)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSeries
    End Function

    Public Function ObtenerCorrelativoPorEmpresaSerie(idEmpresa As Integer, serie As String) As String
        Dim correlativo As String = ""
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_correlativo_x_empresa_serie", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_id", idEmpresa))
                    cmd.Parameters.Add(New SqlParameter("@sre_serie", serie))
                    cmd.CommandType = CommandType.StoredProcedure
                    correlativo = cmd.ExecuteScalar()
                    Return correlativo
                End Using
            End Using
        Catch ex As Exception
            'With oEmpresa
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function ObtenerCorrelativoPorRucEmpresaSerieTipo(rucEmpresa As String, serie As String, tipoComprobante As String) As String
        Dim correlativo As String = ""
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_correlativo_x_ruc_empresa_serie_tipo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_nrodoc", rucEmpresa))
                    cmd.Parameters.Add(New SqlParameter("@sre_serie", serie))
                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", tipoComprobante))
                    cmd.CommandType = CommandType.StoredProcedure
                    correlativo = cmd.ExecuteScalar()
                    Return correlativo
                End Using
            End Using
        Catch ex As Exception
            'With oEmpresa
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function ActualizarCorrelativoPorEmpresaSerie(idEmpresa As Integer, tipoComprobante As String, serie As String, correlativo As Integer) As Boolean
        Dim SeActualizo As Boolean = False
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_actualizar_correlativo_x_empresa_serie_tipo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_id", idEmpresa))
                    cmd.Parameters.Add(New SqlParameter("@sre_tipdoc", tipoComprobante))
                    cmd.Parameters.Add(New SqlParameter("@sre_serie", serie))
                    cmd.Parameters.Add(New SqlParameter("@sre_correlativo", correlativo))
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                    SeActualizo = True
                End Using
            End Using
            Return SeActualizo
        Catch ex As Exception
            'With oEmpresa
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function
End Class
