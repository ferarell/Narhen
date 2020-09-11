Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class ResumenCorrelativoDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function ObtenerFechaCorrelativoMax() As Integer
        Dim correlativo As Integer = 0
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_resumendiario_fecha_correlativo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@fecha", Today().ToString("yyyy-MM-dd")))
                    cmd.CommandType = CommandType.StoredProcedure
                    If IsDBNull(cmd.ExecuteScalar()) Then
                        correlativo = 0
                    Else
                        correlativo = cmd.ExecuteScalar()
                    End If
                    cnx.Close()
                End Using
            End Using
            Return correlativo
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function RegistrarFechaCorrelativo(correlativo) As Boolean
        Dim SeRegistro As Boolean = False
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_registrar_resumendiario_fecha_correlativo", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@fecha", Today().ToString("yyyy-MM-dd")))
                    cmd.Parameters.Add(New SqlParameter("@correlativo", correlativo))
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
