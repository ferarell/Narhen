Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class BancoDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As BancoBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Banco_INS01"

            With .Parameters
                .Clear()
                .Add("@IDBanco", SqlDbType.SmallInt).Value = BE.IdBanco
                .Add("@CODIGOBanco", SqlDbType.char, 3).Value = BE.CodigoBanco
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.Descripcion
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.datetime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.datetime).Value = BE.FechaModificacion
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return (True)
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Update(ByVal BE As BancoBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Banco_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDBanco", SqlDbType.SmallInt).Value = BE.IdBanco
                .Add("@CODIGOBanco", SqlDbType.char, 3).Value = BE.CodigoBanco
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.Descripcion
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

    Public Function Delete(ByVal oBancoBE As BancoBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Banco_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdBanco", SqlDbType.Int).Value = oBancoBE.IdBanco


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

    Public Function GetBanco(ByVal strIdBanco As String) As BancoBE
        Dim dr As SqlDataReader
        Dim BancoBE As New BancoBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Banco_GET01"

            With .Parameters
                .Clear()
                .Add("@IdBanco", SqlDbType.SmallInt).Value = strIdBanco
            End With
        End With

        Try
            cnx.open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With BancoBE
                        If dr("IdBanco") Is DBNull.Value Then
                            .IdBanco = Nothing
                        Else
                            .IdBanco = dr("IdBanco")
                        End If

                        If dr("CodigoBanco") Is DBNull.Value Then
                            .CodigoBanco = Nothing
                        Else
                            .CodigoBanco = dr("CodigoBanco")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
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
        Return BancoBE
    End Function

    Public Function GetBancos(ByVal oBancoBECrit As BancoBE) As List(Of BancoBE)
        Dim dr As SqlDataReader

        Dim listBancos As List(Of BancoBE) = New List(Of BancoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Banco_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oBancoBE As New BancoBE

                    If dr("IdBanco") Is DBNull.Value Then
                        oBancoBE.IdBanco = Nothing
                    Else
                        oBancoBE.IdBanco = dr("IdBanco")
                    End If

                    If dr("CodigoBanco") Is DBNull.Value Then
                        oBancoBE.CodigoBanco = Nothing
                    Else
                        oBancoBE.CodigoBanco = dr("CodigoBanco")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oBancoBE.Descripcion = Nothing
                    Else
                        oBancoBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oBancoBE.UsuarioCreacion = Nothing
                    Else
                        oBancoBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oBancoBE.FechaCreacion = Nothing
                    Else
                        oBancoBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oBancoBE.UsuarioModificacion = Nothing
                    Else
                        oBancoBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oBancoBE.FechaModificacion = Nothing
                    Else
                        oBancoBE.FechaModificacion = dr("FechaModificacion")
                    End If

                    listBancos.Add(oBancoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listBancos
    End Function
End Class
