Imports Lotizador.BE
Imports System.Configuration
Imports System.Data.SqlClient

Public Class LogDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function Registrar(oLog As LogBE) As LogBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_registrar_log", cnx)
                    cnx.Open()

                    cmd.Parameters.Add(New SqlParameter("@log_fecha", oLog.log_fecha))
                    cmd.Parameters.Add(New SqlParameter("@log_hora", oLog.log_hora))
                    cmd.Parameters.Add(New SqlParameter("@log_archivo", oLog.log_archivo))
                    cmd.Parameters.Add(New SqlParameter("@log_usuario", oLog.log_usuario))

                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oLog
    End Function
End Class
