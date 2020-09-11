Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class UsuarioDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function Insert(ByVal BE As UsuarioBE) As Boolean


        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "USUARIO_INS01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDUSUARIO", SqlDbType.SmallInt).Value = BE.IdUsuario
        cmd.Parameters.Add("@CUENTA", SqlDbType.VarChar, 100).Value = BE.Cuenta
        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = BE.Nombre
        cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 100).Value = BE.Descripcion
        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 255).Value = BE.Password
        cmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 200).Value = BE.Correo
        cmd.Parameters.Add("@LOOKANDFEEL", SqlDbType.VarChar, 50).Value = BE.LookAndFeel
        cmd.Parameters.Add("@IMAGEN", SqlDbType.Image).Value = BE.Image
        cmd.Parameters.Add("@ACTIVO", SqlDbType.Bit).Value = BE.Activo
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
        cmd.Parameters.Add("@FlgCambioPwd", SqlDbType.Bit).Value = BE.FlgCambioPwd


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

    Public Function Update(ByVal BE As UsuarioBE) As Boolean





        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "USUARIO_UPD01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDUSUARIO", SqlDbType.SmallInt).Value = BE.IdUsuario
        cmd.Parameters.Add("@CUENTA", SqlDbType.VarChar, 100).Value = BE.Cuenta
        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = BE.Nombre
        cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar, 100).Value = BE.Descripcion
        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 255).Value = BE.Password
        cmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 200).Value = BE.Correo
        cmd.Parameters.Add("@LOOKANDFEEL", SqlDbType.VarChar, 50).Value = BE.LookAndFeel
        cmd.Parameters.Add("@IMAGEN", SqlDbType.Image).Value = BE.Image
        cmd.Parameters.Add("@ACTIVO", SqlDbType.Bit).Value = BE.Activo
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
        cmd.Parameters.Add("@FlgCambioPwd", SqlDbType.Bit).Value = BE.FlgCambioPwd

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

    Public Function ActualizaPassword(ByVal BE As UsuarioBE) As Boolean
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "USUARIO_UPD02"
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDUSUARIO", SqlDbType.SmallInt).Value = BE.IdUsuario
        cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar, 255).Value = BE.Password
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



    Public Function Delete(ByVal oMonedaBE As UsuarioBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Usuario_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = oMonedaBE.IdUsuario


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

    Public Function GetUsuario(ByVal strIdUsuario As Int32) As UsuarioBE
        Dim dr As SqlDataReader
        Dim oUsuarioBE As New UsuarioBE


        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Usuario_GET01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdUsuario", SqlDbType.SmallInt).Value = strIdUsuario


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()

                    If dr("IdUsuario") Is DBNull.Value Then
                        oUsuarioBE.IdUsuario = Nothing
                    Else
                        oUsuarioBE.IdUsuario = dr("IdUsuario")
                    End If

                    If dr("Cuenta") Is DBNull.Value Then
                        oUsuarioBE.Cuenta = Nothing
                    Else
                        oUsuarioBE.Cuenta = dr("Cuenta")
                    End If

                    If dr("Nombre") Is DBNull.Value Then
                        oUsuarioBE.Nombre = Nothing
                    Else
                        oUsuarioBE.Nombre = dr("Nombre")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oUsuarioBE.Descripcion = Nothing
                    Else
                        oUsuarioBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("Password") Is DBNull.Value Then
                        oUsuarioBE.Password = Nothing
                    Else
                        oUsuarioBE.Password = dr("Password")
                    End If

                    If dr("Correo") Is DBNull.Value Then
                        oUsuarioBE.Correo = Nothing
                    Else
                        oUsuarioBE.Correo = dr("Correo")
                    End If



                    If dr("LookAndFeel") Is DBNull.Value Then
                        oUsuarioBE.LookAndFeel = Nothing
                    Else
                        oUsuarioBE.LookAndFeel = dr("LookAndFeel")
                    End If


                    If dr("Imagen") Is DBNull.Value Then
                        oUsuarioBE.Image = Nothing
                    Else
                        oUsuarioBE.Image = dr("Image")
                    End If

                    If dr("Activo") Is DBNull.Value Then
                        oUsuarioBE.Activo = Nothing
                    Else
                        oUsuarioBE.Activo = dr("Activo")
                    End If


                    If dr("FlgCambioPwd") Is DBNull.Value Then
                        oUsuarioBE.FlgCambioPwd = Nothing
                    Else
                        oUsuarioBE.FlgCambioPwd = dr("FlgCambioPwd")
                    End If




                    If dr("FechaCreacion") Is DBNull.Value Then
                        oUsuarioBE.FechaCreacion = Nothing
                    Else
                        oUsuarioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oUsuarioBE.UsuarioModificacion = Nothing
                    Else
                        oUsuarioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oUsuarioBE.FechaModificacion = Nothing
                    Else
                        oUsuarioBE.FechaModificacion = dr("FechaModificacion")
                    End If



                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oUsuarioBE
    End Function

    Public Function GetUsuarios(ByVal oUsuarioBECrit As UsuarioBE) As List(Of UsuarioBE)
        Dim dr As SqlDataReader

        Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "USUARIO_GET02"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@Cuenta", SqlDbType.VarChar, 100).Value = oUsuarioBECrit.Cuenta


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()



                    Dim oUsuarioBE As UsuarioBE = New UsuarioBE()

                    If dr("IdUsuario") Is DBNull.Value Then
                        oUsuarioBE.IdUsuario = Nothing
                    Else
                        oUsuarioBE.IdUsuario = dr("IdUsuario")
                    End If

                    If dr("Cuenta") Is DBNull.Value Then
                        oUsuarioBE.Cuenta = Nothing
                    Else
                        oUsuarioBE.Cuenta = dr("Cuenta")
                    End If

                    If dr("Nombre") Is DBNull.Value Then
                        oUsuarioBE.Nombre = Nothing
                    Else
                        oUsuarioBE.Nombre = dr("Nombre")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oUsuarioBE.Descripcion = Nothing
                    Else
                        oUsuarioBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("Password") Is DBNull.Value Then
                        oUsuarioBE.Password = Nothing
                    Else
                        oUsuarioBE.Password = dr("Password")
                    End If

                    If dr("Correo") Is DBNull.Value Then
                        oUsuarioBE.Correo = Nothing
                    Else
                        oUsuarioBE.Correo = dr("Correo")
                    End If



                    If dr("LookAndFeel") Is DBNull.Value Then
                        oUsuarioBE.LookAndFeel = Nothing
                    Else
                        oUsuarioBE.LookAndFeel = dr("LookAndFeel")
                    End If


                    If dr("Imagen") Is DBNull.Value Then
                        oUsuarioBE.Image = Nothing
                    Else
                        oUsuarioBE.Image = dr("Image")
                    End If

                    If dr("Activo") Is DBNull.Value Then
                        oUsuarioBE.Activo = Nothing
                    Else
                        oUsuarioBE.Activo = dr("Activo")
                    End If


                    If dr("FlgCambioPwd") Is DBNull.Value Then
                        oUsuarioBE.FlgCambioPwd = Nothing
                    Else
                        oUsuarioBE.FlgCambioPwd = dr("FlgCambioPwd")
                    End If



                    If dr("FechaCreacion") Is DBNull.Value Then
                        oUsuarioBE.FechaCreacion = Nothing
                    Else
                        oUsuarioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oUsuarioBE.UsuarioModificacion = Nothing
                    Else
                        oUsuarioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If


                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oUsuarioBE.UsuarioCreacion = Nothing
                    Else
                        oUsuarioBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If



                    If dr("FechaModificacion") Is DBNull.Value Then
                        oUsuarioBE.FechaModificacion = Nothing
                    Else
                        oUsuarioBE.FechaModificacion = dr("FechaModificacion")
                    End If

                    listUsuarios.Add(oUsuarioBE)





                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listUsuarios
    End Function

    Public Function ObtenerUsuario(cuenta As String) As UsuarioBE
        Dim oUsuarioBE As New UsuarioBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_usuario", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@Cuenta", cuenta))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            With oUsuarioBE
                                .id = dr("IdUsuario").ToString
                                .Cuenta = dr("Cuenta").ToString
                                .Nombre = dr("Nombre").ToString
                                .Descripcion = dr("Descripcion").ToString
                                .Password = dr("Password").ToString
                                .Correo = dr("Correo").ToString
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'With oUsuarioBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
        End Try
        Return oUsuarioBE
    End Function

End Class
