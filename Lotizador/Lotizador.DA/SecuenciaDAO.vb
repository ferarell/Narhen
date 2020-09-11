Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class SecuenciaDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

	Public Function Insert(ByVal BE As SecuenciaBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "SECUENCIA_INS01"

			With .Parameters
				.Clear
                .Add("@IDSECUENCIA", SqlDbType.SmallInt).Value = BE.IdSecuencia
				.Add("@IDPROYECTO", SqlDbType.int).Value=BE.IdProyecto
                .Add("@IDTIPODOCUMENTO", SqlDbType.SmallInt).Value = BE.IdTipoDocumento
                .Add("@SERIEDOCUMENTO", SqlDbType.VarChar, 8).Value = BE.SerieDocumento
                .Add("@NUMERODOCUMENTOINICIAL", SqlDbType.int).Value=BE.NumeroDocumentoInicial
				.Add("@NUMERODOCUMENTOFINAL", SqlDbType.int).Value=BE.NumeroDocumentoFinal
                .Add("@NUMERODOCUMENTOCORRIENTE", SqlDbType.Int).Value = BE.NumeroDocumentoCorriente
                .Add("@ESTADO", SqlDbType.Char, 1).Value = BE.Estado
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
				.Add("@FECHACREACION", SqlDbType.datetime).Value=BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
				.Add("@FECHAMODIFICACION", SqlDbType.datetime).Value=BE.FechaModificacion
			End With 
		End With 

		Try
			cnx.Open()
			IF cmd.ExecuteNonQuery() >0 Then
				Return True
			Else
				Return False
			End IF
		Catch ex As Exception
			Throw
		Finally
			cnx.Close()
		End Try
    End Function

	Public Function Update(ByVal BE As SecuenciaBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "SECUENCIA_UPD01"

			With .Parameters
				.Clear
                .Add("@IDSECUENCIA", SqlDbType.SmallInt).Value = BE.IdSecuencia
				.Add("@IDPROYECTO", SqlDbType.int).Value=BE.IdProyecto
                .Add("@IDTIPODOCUMENTO", SqlDbType.SmallInt).Value = BE.IdTipoDocumento
                .Add("@SERIEDOCUMENTO", SqlDbType.VarChar, 8).Value = BE.SerieDocumento
                .Add("@NUMERODOCUMENTOINICIAL", SqlDbType.int).Value=BE.NumeroDocumentoInicial
				.Add("@NUMERODOCUMENTOFINAL", SqlDbType.int).Value=BE.NumeroDocumentoFinal
                .Add("@NUMERODOCUMENTOCORRIENTE", SqlDbType.Int).Value = BE.NumeroDocumentoCorriente
                .Add("@ESTADO", SqlDbType.Char, 1).Value = BE.Estado
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
				.Add("@FECHACREACION", SqlDbType.datetime).Value=BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
				.Add("@FECHAMODIFICACION", SqlDbType.datetime).Value=BE.FechaModificacion
			End With 
		End With 

		Try
			cnx.Open()
			IF cmd.ExecuteNonQuery() >0 Then
				Return True
			Else
				Return False
			End IF
		Catch ex As Exception
			Throw 
		Finally
			cnx.Close()
		End Try
    End Function

    Public Function Delete(ByVal oSecuenciaBE As SecuenciaBE) As Boolean
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SECUENCIA_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdSecuencia", SqlDbType.Int).Value = oSecuenciaBE.IdSecuencia

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

	Public Function GetSecuencia(ByVal strIdSecuencia As  String) As SecuenciaBE
		Dim dr As SqlDataReader
		Dim SecuenciaBE As New SecuenciaBE

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "SECUENCIA_GET01"

			With .Parameters
				.Clear
                .Add("@IdSecuencia", SqlDbType.SmallInt).Value = strIdSecuencia
			End With 
		End With 

		Try
			cnx.open
			dr = cmd.ExecuteReader

			If dr.HasRows Then
				While dr.Read()
					With SecuenciaBE
						If dr("IdSecuencia") Is DBNull.Value Then
							.IdSecuencia= Nothing
						Else
							.IdSecuencia= dr("IdSecuencia")
						End If

						If dr("IdProyecto") Is DBNull.Value Then
							.IdProyecto= Nothing
						Else
							.IdProyecto= dr("IdProyecto")
						End If

						If dr("IdTipoDocumento") Is DBNull.Value Then
							.IdTipoDocumento= Nothing
						Else
							.IdTipoDocumento= dr("IdTipoDocumento")
						End If

						If dr("SerieDocumento") Is DBNull.Value Then
							.SerieDocumento= Nothing
						Else
							.SerieDocumento= dr("SerieDocumento")
						End If

						If dr("NumeroDocumentoInicial") Is DBNull.Value Then
							.NumeroDocumentoInicial= Nothing
						Else
							.NumeroDocumentoInicial= dr("NumeroDocumentoInicial")
						End If

						If dr("NumeroDocumentoFinal") Is DBNull.Value Then
							.NumeroDocumentoFinal= Nothing
						Else
							.NumeroDocumentoFinal= dr("NumeroDocumentoFinal")
						End If

						If dr("NumeroDocumentoCorriente") Is DBNull.Value Then
							.NumeroDocumentoCorriente= Nothing
						Else
							.NumeroDocumentoCorriente= dr("NumeroDocumentoCorriente")
						End If

						If dr("UsuarioCreacion") Is DBNull.Value Then
							.UsuarioCreacion= Nothing
						Else
							.UsuarioCreacion= dr("UsuarioCreacion")
						End If

						If dr("FechaCreacion") Is DBNull.Value Then
							.FechaCreacion= Nothing
						Else
							.FechaCreacion= dr("FechaCreacion")
						End If

						If dr("UsuarioModificacion") Is DBNull.Value Then
							.UsuarioModificacion= Nothing
						Else
							.UsuarioModificacion= dr("UsuarioModificacion")
						End If

						If dr("FechaModificacion") Is DBNull.Value Then
							.FechaModificacion= Nothing
						Else
							.FechaModificacion= dr("FechaModificacion")
						End If

			End With 

			End While
			dr.Close()
			End If
		Catch ex As Exception
			Throw 
		Finally
			cnx.close
		End Try
		Return SecuenciaBE
    End Function

    Public Function GetSecuencias(ByVal oSecuenciaBECrit As SecuenciaBE) As List(Of SecuenciaBE)
        Dim dr As SqlDataReader

        Dim listSecuencias As List(Of SecuenciaBE) = New List(Of SecuenciaBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "SECUENCIA_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oSecuenciaBE As New SecuenciaBE
                    With oSecuenciaBE
                        If dr("IdSecuencia") Is DBNull.Value Then
                            .IdSecuencia = Nothing
                        Else
                            .IdSecuencia = dr("IdSecuencia")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("IdTipoDocumento") Is DBNull.Value Then
                            .IdTipoDocumento = Nothing
                        Else
                            .IdTipoDocumento = dr("IdTipoDocumento")
                        End If

                        If dr("SerieDocumento") Is DBNull.Value Then
                            .SerieDocumento = Nothing
                        Else
                            .SerieDocumento = dr("SerieDocumento")
                        End If

                        If dr("NumeroDocumentoInicial") Is DBNull.Value Then
                            .NumeroDocumentoInicial = Nothing
                        Else
                            .NumeroDocumentoInicial = dr("NumeroDocumentoInicial")
                        End If

                        If dr("NumeroDocumentoFinal") Is DBNull.Value Then
                            .NumeroDocumentoFinal = Nothing
                        Else
                            .NumeroDocumentoFinal = dr("NumeroDocumentoFinal")
                        End If

                        If dr("NumeroDocumentoCorriente") Is DBNull.Value Then
                            .NumeroDocumentoCorriente = Nothing
                        Else
                            .NumeroDocumentoCorriente = dr("NumeroDocumentoCorriente")
                        End If

                        If dr("Estado") Is DBNull.Value Then
                            .Estado = Nothing
                        Else
                            .Estado = dr("Estado")
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

                        If dr("Proyecto") Is DBNull.Value Then
                            .Proyecto = Nothing
                        Else
                            .Proyecto = dr("Proyecto")
                        End If

                        If dr("TipoDocumento") Is DBNull.Value Then
                            .TipoDocumento = Nothing
                        Else
                            .TipoDocumento = dr("TipoDocumento")
                        End If

                    End With

                    listSecuencias.Add(oSecuenciaBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listSecuencias
    End Function
End class
