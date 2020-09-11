Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Collections.Generic
Imports Lotizador.BE

Public Class GeneralDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Execute(ByVal oGeneralBE As GeneralBE) As GeneralBE
        Dim dtReturn As New DataTable
        Try
            cmd.Connection = cnx
            cmd.CommandType = CommandType.Text
            cmd.CommandText = oGeneralBE.SqlTxt
            cnx.Open()
            oGeneralBE.dtResult = New DataTable
            oGeneralBE.dtResult.TableName = "Contrato"
            oGeneralBE.dtResult.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oGeneralBE
    End Function

End Class
