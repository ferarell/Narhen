Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class MonedaTipoCambioDAO

    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

	Public Function Insert(ByVal BE As MonedaTipoCambioBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "MONEDATIPOCAMBIO_INS01"

			With .Parameters
				.Clear
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
                .Add("@FECHAREFERENCIA", SqlDbType.Date).Value = BE.FechaReferencia
                .Add("@TCDOLARV", SqlDbType.Float).Value = BE.TcDolarV
                .Add("@TCLOCALV", SqlDbType.Float).Value = BE.TcLocalV
                .Add("@TCDOLARC", SqlDbType.Float).Value = BE.TcDolarC
                .Add("@TCLOCALC", SqlDbType.Float).Value = BE.TcLocalC
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
	Public Function Update(ByVal BE As MonedaTipoCambioBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "MONEDATIPOCAMBIO_UPD01"

			With .Parameters
				.Clear
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
                .Add("@FECHAREFERENCIA", SqlDbType.Date).Value = BE.FechaReferencia
                .Add("@TCDOLARV", SqlDbType.Float).Value = BE.TcDolarV
                .Add("@TCLOCALV", SqlDbType.Float).Value = BE.TcLocalV
                .Add("@TCDOLARC", SqlDbType.Float).Value = BE.TcDolarC
                .Add("@TCLOCALC", SqlDbType.Float).Value = BE.TcLocalC
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

    Public Function Delete(ByVal oMonedaTipoCambioBE As MonedaTipoCambioBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MONEDATIPOCAMBIO_DEL01"

            With .Parameters
                .Clear()
                .Add("@IdMoneda", SqlDbType.SmallInt).Value = oMonedaTipoCambioBE.IdMoneda
                .Add("@FechaReferencia", SqlDbType.Date).Value = oMonedaTipoCambioBE.FechaReferencia
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

    Public Function GetMonedaTipoCambio(ByVal strIdMoneda As String, ByVal dFechaReferencia As Date) As MonedaTipoCambioBE
        Dim dr As SqlDataReader
        Dim MonedaTipoCambioBE As New MonedaTipoCambioBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MONEDATIPOCAMBIO_GET01"

            With .Parameters
                .Clear()
                .Add("@IdMoneda", SqlDbType.SmallInt).Value = strIdMoneda
                .Add("@FechaReferencia", SqlDbType.Date).Value = dFechaReferencia
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With MonedaTipoCambioBE
                        If dr("IdMoneda") Is DBNull.Value Then
                            .IdMoneda = Nothing
                        Else
                            .IdMoneda = dr("IdMoneda")
                        End If

                        If dr("FechaReferencia") Is DBNull.Value Then
                            .FechaReferencia = Nothing
                        Else
                            .FechaReferencia = dr("FechaReferencia")
                        End If

                        If dr("TcDolarV") Is DBNull.Value Then
                            .TcDolarV = Nothing
                        Else
                            .TcDolarV = dr("TcDolarV")
                        End If

                        If dr("TcLocalV") Is DBNull.Value Then
                            .TcLocalV = Nothing
                        Else
                            .TcLocalV = dr("TcLocalV")
                        End If

                        If dr("TcDolarC") Is DBNull.Value Then
                            .TcDolarC = Nothing
                        Else
                            .TcDolarC = dr("TcDolarC")
                        End If

                        If dr("TcLocalC") Is DBNull.Value Then
                            .TcLocalC = Nothing
                        Else
                            .TcLocalC = dr("TcLocalC")
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
        Return MonedaTipoCambioBE
    End Function

    Public Function GetMonedasTipoCambio(ByVal oMonedaTipoCambioBECrit As MonedaTipoCambioBE) As List(Of MonedaTipoCambioBE)
        Dim dr As SqlDataReader

        Dim listMonedaTiposCambio As List(Of MonedaTipoCambioBE) = New List(Of MonedaTipoCambioBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "MONEDATIPOCAMBIO_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oMonedaTipoCambioBE As New MonedaTipoCambioBE

                    With oMonedaTipoCambioBE
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

                        If dr("FechaReferencia") Is DBNull.Value Then
                            .FechaReferencia = Nothing
                        Else
                            .FechaReferencia = dr("FechaReferencia")
                        End If

                        If dr("TcDolarV") Is DBNull.Value Then
                            .TcDolarV = Nothing
                        Else
                            .TcDolarV = dr("TcDolarV")
                        End If

                        If dr("TcLocalV") Is DBNull.Value Then
                            .TcLocalV = Nothing
                        Else
                            .TcLocalV = dr("TcLocalV")
                        End If

                        If dr("TcDolarC") Is DBNull.Value Then
                            .TcDolarC = Nothing
                        Else
                            .TcDolarC = dr("TcDolarC")
                        End If

                        If dr("TcLocalC") Is DBNull.Value Then
                            .TcLocalC = Nothing
                        Else
                            .TcLocalC = dr("TcLocalC")
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
                    listMonedaTiposCambio.Add(oMonedaTipoCambioBE)
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listMonedaTiposCambio

    End Function
End class
