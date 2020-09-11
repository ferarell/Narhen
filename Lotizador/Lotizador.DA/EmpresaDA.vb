Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class EmpresaDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function ListarEmpresas() As List(Of EmpresaBE)
        Dim lstEmpresa As New List(Of EmpresaBE)
        Dim oEmpresaBE As EmpresaBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_empresas", cnx)
                    cnx.Open()
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oEmpresaBE = New EmpresaBE()
                            With oEmpresaBE
                                .emp_id = dr("emp_id").ToString
                                .emp_razsoc = dr("emp_razsoc").ToString
                                .emp_tipodoc = dr("emp_tipodoc").ToString
                                .emp_nrodoc = dr("emp_nrodoc").ToString
                                .emp_direccion = dr("emp_direccion").ToString
                                .emp_distrito = dr("emp_distrito").ToString
                            End With
                            lstEmpresa.Add(oEmpresaBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            oEmpresaBE = New EmpresaBE()
            With oEmpresaBE
                .ErrorCodigo = "EX"
                .ErrorMensaje = ex.Message
            End With
            lstEmpresa.Add(oEmpresaBE)
        Finally
            cnx.Close()
        End Try
        Return lstEmpresa
    End Function

    Public Function Registrar(oEmpresa As EmpresaBE) As EmpresaBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_registrar_empresa", cnx)
                    cnx.Open()

                    cmd.Parameters.Add(New SqlParameter("@emp_razsoc", oEmpresa.emp_razsoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_tipodoc", oEmpresa.emp_tipodoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_nrodoc", oEmpresa.emp_nrodoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_direccion", oEmpresa.emp_direccion))
                    cmd.Parameters.Add(New SqlParameter("@emp_distrito", oEmpresa.emp_distrito))

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oEmpresa
    End Function

    Public Function ObtenerEmpresaPorId(id As Integer) As EmpresaBE
        Dim oEmpresa As New EmpresaBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_empresa_x_id", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_id", id))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            With oEmpresa
                                .emp_id = dr("emp_id").ToString
                                .emp_razsoc = dr("emp_razsoc").ToString
                                .emp_tipodoc = dr("emp_tipodoc").ToString
                                .emp_nrodoc = dr("emp_nrodoc").ToString
                                .emp_direccion = dr("emp_direccion").ToString
                                .emp_distrito = dr("emp_distrito").ToString
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            With oEmpresa
                .ErrorCodigo = "EX"
                .ErrorMensaje = ex.Message
            End With
        Finally
            cnx.Close()
        End Try
        Return oEmpresa
    End Function

    Public Function ObtenerEmpresaPorRuc(ruc As String) As EmpresaBE
        Dim oEmpresa As New EmpresaBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_empresa_x_ruc", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@emp_nrodoc", ruc))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            With oEmpresa
                                .emp_id = dr("emp_id").ToString
                                .emp_razsoc = dr("emp_razsoc").ToString
                                .emp_tipodoc = dr("emp_tipodoc").ToString
                                .emp_nrodoc = dr("emp_nrodoc").ToString
                                .emp_direccion = dr("emp_direccion").ToString
                                .emp_distrito = dr("emp_distrito").ToString
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            With oEmpresa
                .ErrorCodigo = "EX"
                .ErrorMensaje = ex.Message
            End With
        Finally
            cnx.Close()
        End Try
        Return oEmpresa
    End Function

    Public Function Actualizar(oEmpresa As EmpresaBE) As EmpresaBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_actualizar_empresa", cnx)
                    cnx.Open()

                    cmd.Parameters.Add(New SqlParameter("@emp_id", oEmpresa.emp_id))
                    cmd.Parameters.Add(New SqlParameter("@emp_razsoc", oEmpresa.emp_razsoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_tipodoc", oEmpresa.emp_tipodoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_nrodoc", oEmpresa.emp_nrodoc))
                    cmd.Parameters.Add(New SqlParameter("@emp_direccion", oEmpresa.emp_direccion))
                    cmd.Parameters.Add(New SqlParameter("@emp_distrito", oEmpresa.emp_distrito))

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oEmpresa
    End Function

End Class
