Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class ProyectoDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function Insert(ByVal BE As ProyectoBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PROYECTO_INS01"

            With .Parameters
                .Clear()
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@DESCRIPCION", SqlDbType.VarChar, 60).Value = BE.Descripcion
                .Add("@CANTIDADLOTES", SqlDbType.SmallInt).Value = BE.CantidadLotes
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
                .Add("@IDBANCO", SqlDbType.SmallInt).Value = BE.IdBanco
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IdUbigeo
                .Add("@CUENTACORRIENTE", SqlDbType.VarChar, 20).Value = BE.CuentaCorriente
                .Add("@IMPORTEMORA", SqlDbType.Money).Value = BE.ImporteMora
                .Add("@CODIGOINTERBANCARIO", SqlDbType.VarChar, 30).Value = BE.CodigoInterbancario
                .Add("@ARCHIVOPLANTILLA", SqlDbType.VarChar, 300).Value = BE.ArchivoPlantilla
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
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

    Public Function Update(ByVal BE As ProyectoBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PROYECTO_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@DESCRIPCION", SqlDbType.VarChar, 60).Value = BE.Descripcion
                .Add("@CANTIDADLOTES", SqlDbType.SmallInt).Value = BE.CantidadLotes
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
                .Add("@IDBANCO", SqlDbType.SmallInt).Value = BE.IdBanco
                .Add("@IDUBIGEO", SqlDbType.Int).Value = BE.IdUbigeo
                .Add("@CUENTACORRIENTE", SqlDbType.VarChar, 20).Value = BE.CuentaCorriente
                .Add("@IMPORTEMORA", SqlDbType.Money).Value = BE.ImporteMora
                .Add("@CODIGOINTERBANCARIO", SqlDbType.VarChar, 30).Value = BE.CodigoInterbancario
                .Add("@ARCHIVOPLANTILLA", SqlDbType.VarChar, 300).Value = BE.ArchivoPlantilla
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
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

    Public Function Delete(ByVal oProyectoBE As ProyectoBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "PROYECTO_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdProyecto", SqlDbType.Int).Value = oProyectoBE.IdProyecto


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

    Public Function GetProyecto(ByVal strIdProyecto As String) As ProyectoBE
        Dim dr As SqlDataReader
        Dim ProyectoBE As New ProyectoBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "PROYECTO_GET01"

            With .Parameters
                .Clear()
                .Add("@IdProyecto", SqlDbType.Int).Value = strIdProyecto
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With ProyectoBE
                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("CantidadLotes") Is DBNull.Value Then
                            .CantidadLotes = Nothing
                        Else
                            .CantidadLotes = dr("CantidadLotes")
                        End If

                        If dr("IdMoneda") Is DBNull.Value Then
                            .IdMoneda = Nothing
                        Else
                            .IdMoneda = dr("IdMoneda")
                        End If

                        If dr("IdBanco") Is DBNull.Value Then
                            .IdBanco = Nothing
                        Else
                            .IdBanco = dr("IdBanco")
                        End If

                        If dr("IdUbigeo") Is DBNull.Value Then
                            .IdUbigeo = Nothing
                        Else
                            .IdUbigeo = dr("IdUbigeo")
                        End If

                        If dr("CuentaCorriente") Is DBNull.Value Then
                            .CuentaCorriente = Nothing
                        Else
                            .CuentaCorriente = dr("CuentaCorriente")
                        End If

                        If dr("ImporteMora") Is DBNull.Value Then
                            .ImporteMora = Nothing
                        Else
                            .ImporteMora = dr("ImporteMora")
                        End If

                        If dr("CodigoInterbancario") Is DBNull.Value Then
                            .CodigoInterbancario = Nothing
                        Else
                            .CodigoInterbancario = dr("CodigoInterbancario")
                        End If

                        If dr("ArchivoPlantilla") Is DBNull.Value Then
                            .ArchivoPlantilla = Nothing
                        Else
                            .ArchivoPlantilla = dr("ArchivoPlantilla")
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
            cnx.Close()
        End Try
        Return ProyectoBE
    End Function

    Public Function GetProyectos(ByVal oProyectoBECrit As ProyectoBE) As List(Of ProyectoBE)
        Dim dr As SqlDataReader

        Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "PROYECTO_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oProyectoBE As New ProyectoBE
                    With oProyectoBE
                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("CantidadLotes") Is DBNull.Value Then
                            .CantidadLotes = Nothing
                        Else
                            .CantidadLotes = dr("CantidadLotes")
                        End If

                        If dr("IdMoneda") Is DBNull.Value Then
                            .IdMoneda = Nothing
                        Else
                            .IdMoneda = dr("IdMoneda")
                        End If

                        If dr("CodigoMoneda") Is DBNull.Value Then
                            .CodigoMoneda = Nothing
                        Else
                            .CodigoMoneda = dr("CodigoMoneda")
                        End If

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

                        If dr("Banco") Is DBNull.Value Then
                            .Banco = Nothing
                        Else
                            .Banco = dr("Banco")
                        End If

                        If dr("IdUbigeo") Is DBNull.Value Then
                            .IdUbigeo = Nothing
                        Else
                            .IdUbigeo = dr("IdUbigeo")
                        End If

                        If dr("CuentaCorriente") Is DBNull.Value Then
                            .CuentaCorriente = Nothing
                        Else
                            .CuentaCorriente = dr("CuentaCorriente")
                        End If

                        If dr("ImporteMora") Is DBNull.Value Then
                            .ImporteMora = Nothing
                        Else
                            .ImporteMora = dr("ImporteMora")
                        End If

                        If dr("CodigoInterbancario") Is DBNull.Value Then
                            .CodigoInterbancario = Nothing
                        Else
                            .CodigoInterbancario = dr("CodigoInterbancario")
                        End If

                        If dr("ArchivoPlantilla") Is DBNull.Value Then
                            .ArchivoPlantilla = Nothing
                        Else
                            .ArchivoPlantilla = dr("ArchivoPlantilla")
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

                        If dr("Departamento") Is DBNull.Value Then
                            .Departamento = Nothing
                        Else
                            .Departamento = dr("Departamento")
                        End If

                        If dr("Provincia") Is DBNull.Value Then
                            .Provincia = Nothing
                        Else
                            .Provincia = dr("Provincia")
                        End If

                        If dr("Distrito") Is DBNull.Value Then
                            .Distrito = Nothing
                        Else
                            .Distrito = dr("Distrito")
                        End If

                        If dr("IdDepartamento") Is DBNull.Value Then
                            .IdDepartamento = Nothing
                        Else
                            .IdDepartamento = dr("IdDepartamento")
                        End If

                        If dr("IdProvincia") Is DBNull.Value Then
                            .IdProvincia = Nothing
                        Else
                            .IdProvincia = dr("IdProvincia")
                        End If

                        If dr("IdDistrito") Is DBNull.Value Then
                            .IdDistrito = Nothing
                        Else
                            .IdDistrito = dr("IdDistrito")
                        End If

                    End With

                    listProyectos.Add(oProyectoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listProyectos
    End Function

    Public Function ListarProyectos() As List(Of ProyectoBE)
        Dim lstProyecto As New List(Of ProyectoBE)
        Dim oProyectoBE As ProyectoBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_proyectos", cnx)
                    cnx.Open()
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oProyectoBE = New ProyectoBE()
                            With oProyectoBE
                                .IdProyecto = dr("IdProyecto").ToString
                                .Descripcion = dr("Descripcion").ToString
                            End With
                            lstProyecto.Add(oProyectoBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oProyectoBE = New ProyectoBE()
            'With oProyectoBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstProyecto.Add(oProyectoBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstProyecto
    End Function

End Class
