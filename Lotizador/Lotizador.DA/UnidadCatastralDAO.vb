Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class UnidadCatastralDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As UnidadCatastralBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "UNIDADCATASTRAL_INS01"

            With .Parameters
                .Clear()
                .Add("@IDUNIDADCATASTRAL", SqlDbType.Int).Value = BE.IdUnidadCatastral
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@DESCRIPCION", SqlDbType.varchar, 10).Value = BE.Descripcion
                .Add("@SUPERFICIE", SqlDbType.decimal).Value = BE.Superficie
                .Add("@PARTIDAREGISTRAL", SqlDbType.varchar, 12).Value = BE.PartidaRegistral
                .Add("@REGISTROPREDIAL", SqlDbType.VarChar, 150).Value = BE.RegistroPredial
                .Add("@DENOMINACION", SqlDbType.VarChar, 150).Value = BE.Denominacion
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.datetime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.datetime).Value = BE.FechaModificacion
            End With
        End With

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

    Public Function Update(ByVal BE As UnidadCatastralBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "UNIDADCATASTRAL_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDUNIDADCATASTRAL", SqlDbType.Int).Value = BE.IdUnidadCatastral
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@DESCRIPCION", SqlDbType.varchar, 10).Value = BE.Descripcion
                .Add("@SUPERFICIE", SqlDbType.decimal).Value = BE.Superficie
                .Add("@PARTIDAREGISTRAL", SqlDbType.varchar, 12).Value = BE.PartidaRegistral
                .Add("@REGISTROPREDIAL", SqlDbType.VarChar, 150).Value = BE.RegistroPredial
                .Add("@DENOMINACION", SqlDbType.VarChar, 150).Value = BE.Denominacion
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.datetime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.datetime).Value = BE.FechaModificacion
            End With
        End With

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

    Public Function Delete(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "UNIDADCATASTRAL_DEL01"

            With .Parameters
                .Clear()
                .Add("@IdUnidadCatastral", SqlDbType.Int).Value = oUnidadCatastralBE.IdUnidadCatastral
            End With
        End With

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

    Public Function GetUnidadCatastral(ByVal strIdUnidadCatastral As String) As UnidadCatastralBE
        Dim dr As SqlDataReader
        Dim UnidadCatastralBE As New UnidadCatastralBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "UNIDADCATASTRAL_GET01"

            With .Parameters
                .Clear()
                .Add("@IdUnidadCatastral", SqlDbType.Int).Value = strIdUnidadCatastral
            End With
        End With

        Try
            cnx.open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With UnidadCatastralBE
                        If dr("IdUnidadCatastral") Is DBNull.Value Then
                            .IdUnidadCatastral = Nothing
                        Else
                            .IdUnidadCatastral = dr("IdUnidadCatastral")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("NombreProyecto") Is DBNull.Value Then
                            .NombreProyecto = Nothing
                        Else
                            .NombreProyecto = dr("NombreProyecto")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("Superficie") Is DBNull.Value Then
                            .Superficie = Nothing
                        Else
                            .Superficie = dr("Superficie")
                        End If

                        If dr("PartidaRegistral") Is DBNull.Value Then
                            .PartidaRegistral = Nothing
                        Else
                            .PartidaRegistral = dr("PartidaRegistral")
                        End If

                        If dr("RegistroPredial") Is DBNull.Value Then
                            .RegistroPredial = Nothing
                        Else
                            .RegistroPredial = dr("RegistroPredial")
                        End If

                        If dr("Denominacion") Is DBNull.Value Then
                            .Denominacion = Nothing
                        Else
                            .Denominacion = dr("Denominacion")
                        End If

                        If dr("UsuarioCreacion") Is DBNull.Value Then
                            .UsuarioCreacion = Nothing
                        Else
                            .UsuarioCreacion = dr("UsuarioCreacion")
                        End If

                        If dr("FechaCreacion") Is DBNull.Value Then
                            .FechaCreacion = Nothing
                        Else
                            .FechaCreacion = dr("FechaCreacion")
                        End If

                        If dr("UsuarioModificacion") Is DBNull.Value Then
                            .UsuarioModificacion = Nothing
                        Else
                            .UsuarioModificacion = dr("UsuarioModificacion")
                        End If

                        If dr("FechaModificacion") Is DBNull.Value Then
                            .FechaModificacion = Nothing
                        Else
                            .FechaModificacion = dr("FechaModificacion")
                        End If

                    End With

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.close()
        End Try
        Return UnidadCatastralBE
    End Function

    Public Function GetUnidadesCatastrales(ByVal oUnidadCatastralBECrit As UnidadCatastralBE) As List(Of UnidadCatastralBE)
        Dim dr As SqlDataReader

        Dim listUnidadesCatastrales As List(Of UnidadCatastralBE) = New List(Of UnidadCatastralBE)()

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "UNIDADCATASTRAL_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oUnidadCatastralBE As New UnidadCatastralBE
                    With oUnidadCatastralBE
                        If dr("IdUnidadCatastral") Is DBNull.Value Then
                            .IdUnidadCatastral = Nothing
                        Else
                            .IdUnidadCatastral = dr("IdUnidadCatastral")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("NombreProyecto") Is DBNull.Value Then
                            .NombreProyecto = Nothing
                        Else
                            .NombreProyecto = dr("NombreProyecto")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("Superficie") Is DBNull.Value Then
                            .Superficie = Nothing
                        Else
                            .Superficie = dr("Superficie")
                        End If

                        If dr("PartidaRegistral") Is DBNull.Value Then
                            .PartidaRegistral = Nothing
                        Else
                            .PartidaRegistral = dr("PartidaRegistral")
                        End If

                        If dr("RegistroPredial") Is DBNull.Value Then
                            .RegistroPredial = Nothing
                        Else
                            .RegistroPredial = dr("RegistroPredial")
                        End If

                        If dr("Denominacion") Is DBNull.Value Then
                            .Denominacion = Nothing
                        Else
                            .Denominacion = dr("Denominacion")
                        End If

                        If dr("UsuarioCreacion") Is DBNull.Value Then
                            .UsuarioCreacion = Nothing
                        Else
                            .UsuarioCreacion = dr("UsuarioCreacion")
                        End If

                        If dr("FechaCreacion") Is DBNull.Value Then
                            .FechaCreacion = Nothing
                        Else
                            .FechaCreacion = dr("FechaCreacion")
                        End If

                        If dr("UsuarioModificacion") Is DBNull.Value Then
                            .UsuarioModificacion = Nothing
                        Else
                            .UsuarioModificacion = dr("UsuarioModificacion")
                        End If

                        If dr("FechaModificacion") Is DBNull.Value Then
                            .FechaModificacion = Nothing
                        Else
                            .FechaModificacion = dr("FechaModificacion")
                        End If

                    End With

                    listUnidadesCatastrales.Add(oUnidadCatastralBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listUnidadesCatastrales
    End Function


End Class
