Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class UbigeoDAO

    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function GetDepartamentos() As List(Of UbigeoBE)

        Dim dr As SqlDataReader

        Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UBIGEO_GET_DEPARTAMENTOS"

        'cmd.Parameters.Clear()
        'cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 30).Value = oVariableBECrit.Nombre


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oUbigeoBE As New UbigeoBE

                    If dr("IdDepartamento") Is DBNull.Value Then
                        oUbigeoBE.IdDepartamento = Nothing
                    Else
                        oUbigeoBE.IdDepartamento = dr("IdDepartamento")
                    End If

                    If dr("NombreDepartamento") Is DBNull.Value Then
                        oUbigeoBE.NombreDepartamento = Nothing
                    Else
                        oUbigeoBE.NombreDepartamento = dr("NombreDepartamento")
                    End If

                    listUbigeo.Add(oUbigeoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listUbigeo
    End Function


    Public Function GetProvincias(ByVal oUbigeoBECrit As UbigeoBE) As List(Of UbigeoBE)

        Dim dr As SqlDataReader

        Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UBIGEO_GET_PROVINCIAS"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = oUbigeoBECrit.IdDepartamento


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oUbigeoBE As New UbigeoBE
                    
                    If dr("IdProvincia") Is DBNull.Value Then
                        oUbigeoBE.IdProvincia = Nothing
                    Else
                        oUbigeoBE.IdProvincia = dr("IdProvincia")
                    End If

                    If dr("NombreProvincia") Is DBNull.Value Then
                        oUbigeoBE.NombreProvincia = Nothing
                    Else
                        oUbigeoBE.NombreProvincia = dr("NombreProvincia")
                    End If

                    listUbigeo.Add(oUbigeoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listUbigeo
    End Function



    Public Function GetDistritos(ByVal oUbigeoBECrit As UbigeoBE) As List(Of UbigeoBE)

        Dim dr As SqlDataReader

        Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UBIGEO_GET_DISTRITOS"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = oUbigeoBECrit.IdDepartamento
        cmd.Parameters.Add("@IdProvincia", SqlDbType.Int).Value = oUbigeoBECrit.IdProvincia


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oUbigeoBE As New UbigeoBE

                    If dr("IdUbigeo") Is DBNull.Value Then
                        oUbigeoBE.IdUbigeo = Nothing
                    Else
                        oUbigeoBE.IdUbigeo = dr("IdUbigeo")
                    End If

                    If dr("IdDistrito") Is DBNull.Value Then
                        oUbigeoBE.IdDistrito = Nothing
                    Else
                        oUbigeoBE.IdDistrito = dr("IdDistrito")
                    End If

                    If dr("NombreDistrito") Is DBNull.Value Then
                        oUbigeoBE.NombreDistrito = Nothing
                    Else
                        oUbigeoBE.NombreDistrito = dr("NombreDistrito")
                    End If

                    listUbigeo.Add(oUbigeoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listUbigeo
    End Function




    Public Function GetUbigeo(ByVal oUbigeoBECrit As UbigeoBE) As UbigeoBE

        Dim dr As SqlDataReader
        Dim oUbigeoBE As New UbigeoBE

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UBIGEO_GET01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdUbigeo", SqlDbType.Int).Value = oUbigeoBECrit.IdUbigeo



        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()




                    If dr("IdUbigeo") Is DBNull.Value Then
                        oUbigeoBE.IdUbigeo = Nothing
                    Else
                        oUbigeoBE.IdUbigeo = dr("IdUbigeo")
                    End If

                    If dr("IdDepartamento") Is DBNull.Value Then
                        oUbigeoBE.IdDepartamento = Nothing
                    Else
                        oUbigeoBE.IdDepartamento = dr("IdDepartamento")
                    End If

                    If dr("NombreDepartamento") Is DBNull.Value Then
                        oUbigeoBE.NombreDepartamento = Nothing
                    Else
                        oUbigeoBE.NombreDepartamento = dr("NombreDepartamento")
                    End If


                    If dr("IdProvincia") Is DBNull.Value Then
                        oUbigeoBE.IdProvincia = Nothing
                    Else
                        oUbigeoBE.IdProvincia = dr("IdProvincia")
                    End If

                    If dr("NombreProvincia") Is DBNull.Value Then
                        oUbigeoBE.NombreProvincia = Nothing
                    Else
                        oUbigeoBE.NombreProvincia = dr("NombreProvincia")
                    End If


                    If dr("IdDistrito") Is DBNull.Value Then
                        oUbigeoBE.IdDistrito = Nothing
                    Else
                        oUbigeoBE.IdDistrito = dr("IdDistrito")
                    End If

                    If dr("NombreDistrito") Is DBNull.Value Then
                        oUbigeoBE.NombreDistrito = Nothing
                    Else
                        oUbigeoBE.NombreDistrito = dr("NombreDistrito")
                    End If






                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oUbigeoBE
    End Function






    Public Function GetUbigeoCriterio(ByVal oUbigeoBECrit As UbigeoBE) As UbigeoBE

        Dim dr As SqlDataReader
        Dim oUbigeoBE As New UbigeoBE

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UBIGEO_GET02"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = oUbigeoBECrit.IdDepartamento
        cmd.Parameters.Add("@IdProvincia", SqlDbType.Int).Value = oUbigeoBECrit.IdProvincia
        cmd.Parameters.Add("@IdDistrito", SqlDbType.Int).Value = oUbigeoBECrit.IdDistrito



        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()


                    If dr("IdUbigeo") Is DBNull.Value Then
                        oUbigeoBE.IdUbigeo = Nothing
                    Else
                        oUbigeoBE.IdUbigeo = dr("IdUbigeo")
                    End If

                    If dr("IdDepartamento") Is DBNull.Value Then
                        oUbigeoBE.IdDepartamento = Nothing
                    Else
                        oUbigeoBE.IdDepartamento = dr("IdDepartamento")
                    End If

                    If dr("NombreDepartamento") Is DBNull.Value Then
                        oUbigeoBE.NombreDepartamento = Nothing
                    Else
                        oUbigeoBE.NombreDepartamento = dr("NombreDepartamento")
                    End If


                    If dr("IdProvincia") Is DBNull.Value Then
                        oUbigeoBE.IdProvincia = Nothing
                    Else
                        oUbigeoBE.IdProvincia = dr("IdProvincia")
                    End If

                    If dr("NombreProvincia") Is DBNull.Value Then
                        oUbigeoBE.NombreProvincia = Nothing
                    Else
                        oUbigeoBE.NombreProvincia = dr("NombreProvincia")
                    End If


                    If dr("IdDistrito") Is DBNull.Value Then
                        oUbigeoBE.IdDistrito = Nothing
                    Else
                        oUbigeoBE.IdDistrito = dr("IdDistrito")
                    End If

                    If dr("NombreDistrito") Is DBNull.Value Then
                        oUbigeoBE.NombreDistrito = Nothing
                    Else
                        oUbigeoBE.NombreDistrito = dr("NombreDistrito")
                    End If






                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oUbigeoBE
    End Function









End Class
