Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class SocioDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Function Insert(ByVal oSocioBE As SocioBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SOCIO_INS01"
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDSOCIO", SqlDbType.Int).Value = oSocioBE.IdSocio
        cmd.Parameters.Add("@TIPOSOCIO", SqlDbType.Char, 1).Value = oSocioBE.TipoSocio
        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = oSocioBE.Nombre
        cmd.Parameters.Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = oSocioBE.ApellidoPaterno
        cmd.Parameters.Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = oSocioBE.ApellidoMaterno
        cmd.Parameters.Add("@IDTIPODOCUMENTO", SqlDbType.SmallInt).Value = oSocioBE.IdTipoDocumento
        cmd.Parameters.Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 25).Value = oSocioBE.NumeroDocumento
        cmd.Parameters.Add("@TELEFONODOMICILIO", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoDomicilio
        cmd.Parameters.Add("@TELEFONOMOVIL", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoMovil
        cmd.Parameters.Add("@TELEFONOOFICINA", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoOficina
        cmd.Parameters.Add("@FAX", SqlDbType.VarChar, 20).Value = oSocioBE.Fax
        cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 120).Value = oSocioBE.Direccion
        cmd.Parameters.Add("@IDUBIGEO", SqlDbType.Int).Value = oSocioBE.IdUbigeo
        cmd.Parameters.Add("@REFERENCIADIRECCION", SqlDbType.VarChar, 100).Value = oSocioBE.ReferenciaDireccion
        cmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 60).Value = oSocioBE.Correo
        cmd.Parameters.Add("@MENSAJERIA", SqlDbType.VarChar, 100).Value = oSocioBE.Mensajeria
        cmd.Parameters.Add("@ESTADO", SqlDbType.Char, 1).Value = oSocioBE.Estado
        cmd.Parameters.Add("@SEXO", SqlDbType.Char, 1).Value = oSocioBE.Sexo
        cmd.Parameters.Add("@OCUPACION", SqlDbType.VarChar, 150).Value = oSocioBE.Ocupacion
        If oSocioBE.FechaNacimiento = Nothing Then
            cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = System.Data.SqlTypes.SqlDateTime.Null
        Else
            cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = oSocioBE.FechaNacimiento
        End If
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = oSocioBE.FechaCreacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oSocioBE.FechaModificacion
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = oSocioBE.UsuarioCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = oSocioBE.UsuarioModificacion


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



    Public Function Update(ByVal oSocioBE As SocioBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SOCIO_UPD01"
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDSOCIO", SqlDbType.Int).Value = oSocioBE.IdSocio
        cmd.Parameters.Add("@TIPOSOCIO", SqlDbType.Char, 1).Value = oSocioBE.TipoSocio
        cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = oSocioBE.Nombre
        cmd.Parameters.Add("@APELLIDOPATERNO", SqlDbType.VarChar, 100).Value = oSocioBE.ApellidoPaterno
        cmd.Parameters.Add("@APELLIDOMATERNO", SqlDbType.VarChar, 100).Value = oSocioBE.ApellidoMaterno
        cmd.Parameters.Add("@IDTIPODOCUMENTO", SqlDbType.SmallInt).Value = oSocioBE.IdTipoDocumento
        cmd.Parameters.Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 25).Value = oSocioBE.NumeroDocumento
        cmd.Parameters.Add("@TELEFONODOMICILIO", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoDomicilio
        cmd.Parameters.Add("@TELEFONOMOVIL", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoMovil
        cmd.Parameters.Add("@TELEFONOOFICINA", SqlDbType.VarChar, 20).Value = oSocioBE.TelefonoOficina
        cmd.Parameters.Add("@FAX", SqlDbType.VarChar, 20).Value = oSocioBE.Fax
        cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar, 120).Value = oSocioBE.Direccion
        cmd.Parameters.Add("@IDUBIGEO", SqlDbType.Int).Value = oSocioBE.IdUbigeo
        cmd.Parameters.Add("@REFERENCIADIRECCION", SqlDbType.VarChar, 100).Value = oSocioBE.ReferenciaDireccion
        cmd.Parameters.Add("@CORREO", SqlDbType.VarChar, 60).Value = oSocioBE.Correo
        cmd.Parameters.Add("@MENSAJERIA", SqlDbType.VarChar, 100).Value = oSocioBE.Mensajeria
        cmd.Parameters.Add("@ESTADO", SqlDbType.Char, 1).Value = oSocioBE.Estado
        cmd.Parameters.Add("@SEXO", SqlDbType.Char, 1).Value = oSocioBE.Sexo
        cmd.Parameters.Add("@OCUPACION", SqlDbType.VarChar, 150).Value = oSocioBE.Ocupacion
        If oSocioBE.FechaNacimiento = Nothing Then
            cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = System.Data.SqlTypes.SqlDateTime.Null
        Else
            cmd.Parameters.Add("@FECHANACIMIENTO", SqlDbType.DateTime).Value = oSocioBE.FechaNacimiento
        End If
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = oSocioBE.FechaCreacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = oSocioBE.FechaModificacion
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = oSocioBE.UsuarioCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = oSocioBE.UsuarioModificacion
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

    Public Function Delete(ByVal oSocioBE As SocioBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SOCIO_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdSocio", SqlDbType.Int).Value = oSocioBE.IdSocio


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

    Public Function GetSocio(ByVal strIdSocio As String) As SocioBE
        Dim dr As SqlDataReader
        Dim oSocioBE As New SocioBE

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SOCIO_GET01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdSocio", SqlDbType.Int).Value = strIdSocio


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()

                    If dr("IdSocio") Is DBNull.Value Then
                        oSocioBE.IdSocio = Nothing
                    Else
                        oSocioBE.IdSocio = dr("IdSocio")
                    End If

                    If dr("TipoSocio") Is DBNull.Value Then
                        oSocioBE.TipoSocio = Nothing
                    Else
                        oSocioBE.TipoSocio = dr("TipoSocio")
                    End If

                    If dr("Nombre") Is DBNull.Value Then
                        oSocioBE.Nombre = Nothing
                    Else
                        oSocioBE.Nombre = dr("Nombre")
                    End If

                    If dr("ApellidoPaterno") Is DBNull.Value Then
                        oSocioBE.ApellidoPaterno = Nothing
                    Else
                        oSocioBE.ApellidoPaterno = dr("Apellido")
                    End If



                    If dr("ApellidoMaterno") Is DBNull.Value Then
                        oSocioBE.ApellidoMaterno = Nothing
                    Else
                        oSocioBE.ApellidoMaterno = dr("Apellido")
                    End If
                    If dr("IdTipoDocumento") Is DBNull.Value Then
                        oSocioBE.IdTipoDocumento = Nothing
                    Else
                        oSocioBE.IdTipoDocumento = dr("IdTipoDocumento")
                    End If

                    If dr("NumeroDocumento") Is DBNull.Value Then
                        oSocioBE.NumeroDocumento = Nothing
                    Else
                        oSocioBE.NumeroDocumento = dr("NumeroDocumento")
                    End If

                    If dr("TelefonoDomicilio") Is DBNull.Value Then
                        oSocioBE.TelefonoDomicilio = Nothing
                    Else
                        oSocioBE.TelefonoDomicilio = dr("TelefonoDomicilio")
                    End If

                    If dr("TelefonoMovil") Is DBNull.Value Then
                        oSocioBE.TelefonoMovil = Nothing
                    Else
                        oSocioBE.TelefonoMovil = dr("TelefonoMovil")
                    End If

                    If dr("TelefonoOficina") Is DBNull.Value Then
                        oSocioBE.TelefonoOficina = Nothing
                    Else
                        oSocioBE.TelefonoOficina = dr("TelefonoOficina")
                    End If

                    If dr("Fax") Is DBNull.Value Then
                        oSocioBE.Fax = Nothing
                    Else
                        oSocioBE.Fax = dr("Fax")
                    End If

                    If dr("Direccion") Is DBNull.Value Then
                        oSocioBE.Direccion = Nothing
                    Else
                        oSocioBE.Direccion = dr("Direccion")
                    End If

                    If dr("IdUbigeo") Is DBNull.Value Then
                        oSocioBE.IdUbigeo = Nothing
                    Else
                        oSocioBE.IdUbigeo = dr("IdUbigeo")
                    End If

                    If dr("ReferenciaDireccion") Is DBNull.Value Then
                        oSocioBE.ReferenciaDireccion = Nothing
                    Else
                        oSocioBE.ReferenciaDireccion = dr("ReferenciaDireccion")
                    End If

                    If dr("Correo") Is DBNull.Value Then
                        oSocioBE.Correo = Nothing
                    Else
                        oSocioBE.Correo = dr("Correo")
                    End If


                    If dr("Estado") Is DBNull.Value Then
                        oSocioBE.Estado = Nothing
                    Else
                        oSocioBE.Estado = dr("Estado")
                    End If


                    If dr("Sexo") Is DBNull.Value Then
                        oSocioBE.Sexo = Nothing
                    Else
                        oSocioBE.Sexo = dr("Sexo")
                    End If

                    If dr("Ocupacion") Is DBNull.Value Then
                        oSocioBE.Ocupacion = Nothing
                    Else
                        oSocioBE.Ocupacion = dr("Ocupacion")
                    End If

                    If dr("Mensajeria") Is DBNull.Value Then
                        oSocioBE.Mensajeria = Nothing
                    Else
                        oSocioBE.Mensajeria = dr("Mensajeria")
                    End If

                    If dr("FechaNacimiento") Is DBNull.Value Then
                        oSocioBE.FechaNacimiento = Nothing
                    Else
                        oSocioBE.FechaNacimiento = dr("FechaNacimiento")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oSocioBE.UsuarioCreacion = Nothing
                    Else
                        oSocioBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oSocioBE.FechaCreacion = Nothing
                    Else
                        oSocioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oSocioBE.UsuarioModificacion = Nothing
                    Else
                        oSocioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oSocioBE.FechaModificacion = Nothing
                    Else
                        oSocioBE.FechaModificacion = dr("FechaModificacion")
                    End If



                    If dr("Departamento") Is DBNull.Value Then
                        oSocioBE.Departamento = Nothing
                    Else
                        oSocioBE.Departamento = dr("Departamento")
                    End If

                    If dr("Provincia") Is DBNull.Value Then
                        oSocioBE.Provincia = Nothing
                    Else
                        oSocioBE.Provincia = dr("Provincia")
                    End If


                    If dr("Distrito") Is DBNull.Value Then
                        oSocioBE.Distrito = Nothing
                    Else
                        oSocioBE.Distrito = dr("Distrito")
                    End If



                    'If dr("IdDepartamento") Is DBNull.Value Then
                    '    oSocioBE.IdDepartamento = Nothing
                    'Else
                    '    oSocioBE.IdDepartamento = dr("IdDepartamento")
                    'End If

                    'If dr("IdProvincia") Is DBNull.Value Then
                    '    oSocioBE.IdProvincia = Nothing
                    'Else
                    '    oSocioBE.IdProvincia = dr("IdProvincia")
                    'End If


                    'If dr("IdDistrito") Is DBNull.Value Then
                    '    oSocioBE.IdDistrito = Nothing
                    'Else
                    '    oSocioBE.IdDistrito = dr("IdDistrito")
                    'End If




                    If dr("CodigoTipoDocumento") Is DBNull.Value Then
                        oSocioBE.TipoDocumentoDesc = Nothing
                    Else
                        oSocioBE.TipoDocumentoDesc = dr("CodigoTipoDocumento")
                    End If




                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oSocioBE
    End Function

    Public Function GetSocios(ByVal oSocioBECrit As SocioBE) As List(Of SocioBE)

        Dim dr As SqlDataReader

        Dim listSocios As List(Of SocioBE) = New List(Of SocioBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SOCIO_GET02"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 500).Value = oSocioBECrit.Nombre
        cmd.Parameters.Add("@IdTipoDocumento", SqlDbType.Int).Value = oSocioBECrit.IdTipoDocumento
        cmd.Parameters.Add("@NumeroDocumento", SqlDbType.VarChar, 500).Value = oSocioBECrit.NumeroDocumento


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oSocioBE As New SocioBE

                    If dr("IdSocio") Is DBNull.Value Then
                        oSocioBE.IdSocio = Nothing
                    Else
                        oSocioBE.IdSocio = dr("IdSocio")
                    End If

                    If dr("TipoSocio") Is DBNull.Value Then
                        oSocioBE.TipoSocio = Nothing
                    Else
                        oSocioBE.TipoSocio = dr("TipoSocio")
                    End If

                    If dr("Nombre") Is DBNull.Value Then
                        oSocioBE.Nombre = Nothing
                    Else
                        oSocioBE.Nombre = dr("Nombre")
                    End If

                    If dr("ApellidoPaterno") Is DBNull.Value Then
                        oSocioBE.ApellidoPaterno = Nothing
                    Else
                        oSocioBE.ApellidoPaterno = dr("ApellidoPaterno")
                    End If



                    If dr("ApellidoMaterno") Is DBNull.Value Then
                        oSocioBE.ApellidoMaterno = Nothing
                    Else
                        oSocioBE.ApellidoMaterno = dr("ApellidoMaterno")
                    End If
                    If dr("IdTipoDocumento") Is DBNull.Value Then
                        oSocioBE.IdTipoDocumento = Nothing
                    Else
                        oSocioBE.IdTipoDocumento = dr("IdTipoDocumento")
                    End If

                    If dr("NumeroDocumento") Is DBNull.Value Then
                        oSocioBE.NumeroDocumento = Nothing
                    Else
                        oSocioBE.NumeroDocumento = dr("NumeroDocumento")
                    End If

                    If dr("TelefonoDomicilio") Is DBNull.Value Then
                        oSocioBE.TelefonoDomicilio = Nothing
                    Else
                        oSocioBE.TelefonoDomicilio = dr("TelefonoDomicilio")
                    End If

                    If dr("TelefonoMovil") Is DBNull.Value Then
                        oSocioBE.TelefonoMovil = Nothing
                    Else
                        oSocioBE.TelefonoMovil = dr("TelefonoMovil")
                    End If

                    If dr("TelefonoOficina") Is DBNull.Value Then
                        oSocioBE.TelefonoOficina = Nothing
                    Else
                        oSocioBE.TelefonoOficina = dr("TelefonoOficina")
                    End If

                    If dr("Fax") Is DBNull.Value Then
                        oSocioBE.Fax = Nothing
                    Else
                        oSocioBE.Fax = dr("Fax")
                    End If

                    If dr("Direccion") Is DBNull.Value Then
                        oSocioBE.Direccion = Nothing
                    Else
                        oSocioBE.Direccion = dr("Direccion")
                    End If

                    If dr("IdUbigeo") Is DBNull.Value Then
                        oSocioBE.IdUbigeo = Nothing
                    Else
                        oSocioBE.IdUbigeo = dr("IdUbigeo")
                    End If

                    If dr("ReferenciaDireccion") Is DBNull.Value Then
                        oSocioBE.ReferenciaDireccion = Nothing
                    Else
                        oSocioBE.ReferenciaDireccion = dr("ReferenciaDireccion")
                    End If

                    If dr("Correo") Is DBNull.Value Then
                        oSocioBE.Correo = Nothing
                    Else
                        oSocioBE.Correo = dr("Correo")
                    End If


                    If dr("Estado") Is DBNull.Value Then
                        oSocioBE.Estado = Nothing
                    Else
                        oSocioBE.Estado = dr("Estado")
                    End If


                    If dr("Sexo") Is DBNull.Value Then
                        oSocioBE.Sexo = Nothing
                    Else
                        oSocioBE.Sexo = dr("Sexo")
                    End If

                    If dr("Ocupacion") Is DBNull.Value Then
                        oSocioBE.Ocupacion = Nothing
                    Else
                        oSocioBE.Ocupacion = dr("Ocupacion")
                    End If

                    If dr("Mensajeria") Is DBNull.Value Then
                        oSocioBE.Mensajeria = Nothing
                    Else
                        oSocioBE.Mensajeria = dr("Mensajeria")
                    End If

                    If dr("FechaNacimiento") Is DBNull.Value Then
                        oSocioBE.FechaNacimiento = Nothing
                    Else
                        oSocioBE.FechaNacimiento = dr("FechaNacimiento")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oSocioBE.UsuarioCreacion = Nothing
                    Else
                        oSocioBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oSocioBE.FechaCreacion = Nothing
                    Else
                        oSocioBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oSocioBE.UsuarioModificacion = Nothing
                    Else
                        oSocioBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oSocioBE.FechaModificacion = Nothing
                    Else
                        oSocioBE.FechaModificacion = dr("FechaModificacion")
                    End If



                    If dr("Departamento") Is DBNull.Value Then
                        oSocioBE.Departamento = Nothing
                    Else
                        oSocioBE.Departamento = dr("Departamento")
                    End If

                    If dr("Provincia") Is DBNull.Value Then
                        oSocioBE.Provincia = Nothing
                    Else
                        oSocioBE.Provincia = dr("Provincia")
                    End If


                    If dr("Distrito") Is DBNull.Value Then
                        oSocioBE.Distrito = Nothing
                    Else
                        oSocioBE.Distrito = dr("Distrito")
                    End If


                    If dr("TipoSocioDesc") Is DBNull.Value Then
                        oSocioBE.TipoSocioDesc = Nothing
                    Else
                        oSocioBE.TipoSocioDesc = dr("TipoSocioDesc")
                    End If


                    If dr("CodigoTipoDocumento") Is DBNull.Value Then
                        oSocioBE.TipoDocumentoDesc = Nothing
                    Else
                        oSocioBE.TipoDocumentoDesc = dr("CodigoTipoDocumento")
                    End If


                    If dr("IdDepartamento") Is DBNull.Value Then
                        oSocioBE.IdDepartamento = Nothing
                    Else
                        oSocioBE.IdDepartamento = dr("IdDepartamento")
                    End If

                    If dr("IdProvincia") Is DBNull.Value Then
                        oSocioBE.IdProvincia = Nothing
                    Else
                        oSocioBE.IdProvincia = dr("IdProvincia")
                    End If


                    If dr("IdDistrito") Is DBNull.Value Then
                        oSocioBE.IdDistrito = Nothing
                    Else
                        oSocioBE.IdDistrito = dr("IdDistrito")
                    End If

                    listSocios.Add(oSocioBE)


                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listSocios
    End Function

    Public Function ListarSocios() As List(Of SocioBE)
        Dim lstSocios As New List(Of SocioBE)
        Dim oSocio As SocioBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_socios", cnx)
                    cnx.Open()
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSocio = New SocioBE()
                            With oSocio
                                .IdSocio = dr("IdSocio").ToString
                                .Nombre = dr("Nombre").ToString
                                .ApellidoPaterno = dr("ApellidoPaterno").ToString
                                .ApellidoMaterno = dr("ApellidoMaterno").ToString
                            End With
                            lstSocios.Add(oSocio)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSocios
    End Function

    Public Function ListarSociosPorProyecto(idProyecto As Integer) As List(Of SocioBE)
        Dim lstSocios As New List(Of SocioBE)
        Dim oSocio As SocioBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_socios_x_proyecto", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdProyecto", idProyecto))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oSocio = New SocioBE()
                            With oSocio
                                .IdSocio = dr("IdSocio").ToString
                                .Nombre = dr("NombreCompleto").ToString
                            End With
                            lstSocios.Add(oSocio)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstSocios
    End Function

    Public Function ObtenerSocioPorId(id As Integer) As SocioBE
        Dim oSocio As New SocioBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_socio_x_id", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdSocio", id))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            With oSocio
                                .IdSocio = dr("IdSocio").ToString
                                .Nombre = dr("Nombre").ToString
                                .ApellidoPaterno = dr("ApellidoPaterno").ToString
                                .ApellidoMaterno = dr("ApellidoMaterno").ToString
                                .Direccion = dr("Direccion").ToString
                                .IdTipoDocumento = dr("IdTipoDocumento").ToString
                                .NumeroDocumento = dr("NumeroDocumento").ToString
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'With oSocio
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oSocio
    End Function

    Public Function ObtenerSocioPorNroDoc(nroDoc As String) As SocioBE
        Dim oSocio As New SocioBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_obtener_socio_x_nrodoc", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@NumeroDocumento", nroDoc))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            With oSocio
                                .IdSocio = dr("IdSocio").ToString
                                .Nombre = dr("Nombre").ToString
                                .ApellidoPaterno = dr("ApellidoPaterno").ToString
                                .ApellidoMaterno = dr("ApellidoMaterno").ToString
                                .Direccion = dr("Direccion").ToString
                                .IdTipoDocumento = dr("IdTipoDocumento").ToString
                                .NumeroDocumento = dr("NumeroDocumento").ToString
                            End With
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'With oSocio
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return oSocio
    End Function

End Class
