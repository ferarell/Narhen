Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class ContratoSocioDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As ContratoSocioBE) As Boolean



        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATOSOCIO_INS01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.Int).Value = BE.IdContrato
        cmd.Parameters.Add("@IDSOCIO", SqlDbType.Int).Value = BE.IdSocio
        cmd.Parameters.Add("@PRINCIPAL", SqlDbType.VarChar, 1).Value = BE.Principal
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion


        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Update(ByVal BE As ContratoSocioBE) As Boolean





        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATOSOCIO_INS01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.Int).Value = BE.IdContrato
        cmd.Parameters.Add("@IDSOCIO", SqlDbType.Int).Value = BE.IdSocio
        cmd.Parameters.Add("@PRINCIPAL", SqlDbType.VarChar, 1).Value = BE.Principal
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Delete(ByVal oContratoSocioBE As ContratoSocioBE) As Boolean


        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATOSOCIO_DEL01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdContrato", SqlDbType.Int).Value = oContratoSocioBE.IdContrato
        cmd.Parameters.Add("@IdSocio", SqlDbType.Int).Value = oContratoSocioBE.IdSocio


        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function GetContratoSocio(ByVal strIdContrato As Int32, ByVal strIdSocio As Int32) As ContratoSocioBE
        Dim dr As SqlDataReader
        Dim oContratoSocioBE As New ContratoSocioBE


        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATOSOCIO_GET01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdContrato", SqlDbType.Int).Value = strIdContrato
        cmd.Parameters.Add("@IdSocio", SqlDbType.Int).Value = strIdSocio


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()

                    If dr("IdContrato") Is DBNull.Value Then
                        oContratoSocioBE.IdContrato = Nothing
                    Else
                        oContratoSocioBE.IdContrato = dr("IdContrato")
                    End If

                    If dr("IdSocio") Is DBNull.Value Then
                        oContratoSocioBE.IdSocio = Nothing
                    Else
                        oContratoSocioBE.IdSocio = dr("IdSocio")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oContratoSocioBE.UsuarioCreacion = Nothing
                    Else
                        oContratoSocioBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oContratoSocioBE.FechaCreacion = Nothing
                    Else
                        oContratoSocioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("Principal") Is DBNull.Value Then
                        oContratoSocioBE.Principal = Nothing
                    Else
                        oContratoSocioBE.Principal = dr("Principal")
                    End If


                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oContratoSocioBE.UsuarioModificacion = Nothing
                    Else
                        oContratoSocioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oContratoSocioBE.FechaModificacion = Nothing
                    Else
                        oContratoSocioBE.FechaModificacion = dr("FechaModificacion")
                    End If



                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oContratoSocioBE
    End Function

    Public Function GetContratoSocios(ByVal oContratoSocioBECrit As ContratoSocioBE) As List(Of ContratoSocioBE)
        Dim dr As SqlDataReader

        Dim listContratoSocio As List(Of ContratoSocioBE) = New List(Of ContratoSocioBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATOUSUARIO_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oContratoSocioBE As ContratoSocioBE = New ContratoSocioBE()
                    If dr("IdContrato") Is DBNull.Value Then
                        oContratoSocioBE.IdContrato = Nothing
                    Else
                        oContratoSocioBE.IdContrato = dr("IdContrato")
                    End If

                    If dr("IdSocio") Is DBNull.Value Then
                        oContratoSocioBE.IdSocio = Nothing
                    Else
                        oContratoSocioBE.IdSocio = dr("IdSocio")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oContratoSocioBE.UsuarioCreacion = Nothing
                    Else
                        oContratoSocioBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oContratoSocioBE.FechaCreacion = Nothing
                    Else
                        oContratoSocioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oContratoSocioBE.UsuarioModificacion = Nothing
                    Else
                        oContratoSocioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oContratoSocioBE.FechaModificacion = Nothing
                    Else
                        oContratoSocioBE.FechaModificacion = dr("FechaModificacion")
                    End If
                    If dr("Principal") Is DBNull.Value Then
                        oContratoSocioBE.Principal = Nothing
                    Else
                        oContratoSocioBE.Principal = dr("Principal")
                    End If


                    listContratoSocio.Add(oContratoSocioBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listContratoSocio
    End Function
End Class
