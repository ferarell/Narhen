Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic
Public Class VariableDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function GetVariables(ByVal oVariableBECrit As VariableBE) As List(Of VariableBE)

        Dim dr As SqlDataReader

        Dim listVariables As List(Of VariableBE) = New List(Of VariableBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "VARIABLE_GET02"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = IIf(oVariableBECrit.Nombre = Nothing, DBNull.Value, oVariableBECrit.Nombre)

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oVariableBE As New VariableBE

                    If dr("IdVariable") Is DBNull.Value Then
                        oVariableBE.IdVariable = Nothing
                    Else
                        oVariableBE.IdVariable = dr("IdVariable")
                    End If

                    If dr("Nombre") Is DBNull.Value Then
                        oVariableBE.Nombre = Nothing
                    Else
                        oVariableBE.Nombre = dr("Nombre")
                    End If

                    If dr("Codigo") Is DBNull.Value Then
                        oVariableBE.Codigo = Nothing
                    Else
                        oVariableBE.Codigo = dr("Codigo")
                    End If

                    If dr("Valor") Is DBNull.Value Then
                        oVariableBE.Valor = Nothing
                    Else
                        oVariableBE.Valor = dr("Valor")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oVariableBE.Descripcion = Nothing
                    Else
                        oVariableBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("Estado") Is DBNull.Value Then
                        oVariableBE.Estado = Nothing
                    Else
                        oVariableBE.Estado = dr("Estado")
                    End If


                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oVariableBE.UsuarioCreacion = Nothing
                    Else
                        oVariableBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oVariableBE.FechaCreacion = Nothing
                    Else
                        oVariableBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oVariableBE.UsuarioModificacion = Nothing
                    Else
                        oVariableBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oVariableBE.FechaModificacion = Nothing
                    Else
                        oVariableBE.FechaModificacion = dr("FechaModificacion")
                    End If

                    listVariables.Add(oVariableBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listVariables
    End Function
End Class
