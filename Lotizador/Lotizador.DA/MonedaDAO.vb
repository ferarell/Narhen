Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class MonedaDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

	Public Function Insert(ByVal BE As MonedaBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "MONEDA_INS01"

			With .Parameters
				.Clear
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
				.Add("@CODIGOMONEDA", SqlDbType.char, 3).Value=BE.CodigoMoneda
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.Descripcion
                .Add("@TEXTOIMPRESION", SqlDbType.VarChar, 50).Value = BE.TextoImpresion
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

	Public Function Update(ByVal BE As MonedaBE) As Boolean

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "MONEDA_UPD01"

			With .Parameters
				.Clear
                .Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
				.Add("@CODIGOMONEDA", SqlDbType.char, 3).Value=BE.CodigoMoneda
                .Add("@DESCRIPCION", SqlDbType.VarChar, 50).Value = BE.Descripcion
                .Add("@TEXTOIMPRESION", SqlDbType.VarChar, 50).Value = BE.TextoImpresion
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

    Public Function Delete(ByVal oMonedaBE As MonedaBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Moneda_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IdMoneda", SqlDbType.Int).Value = oMonedaBE.IdMoneda


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

	Public Function GetMoneda(ByVal strIdMoneda As  String) As MonedaBE
		Dim dr As SqlDataReader
		Dim MonedaBE As New MonedaBE

		With cmd
			.Connection = cnx
			.CommandType = CommandType.StoredProcedure
			.CommandText = "MONEDA_GET01"

			With .Parameters
				.Clear
                .Add("@IdMoneda", SqlDbType.SmallInt).Value = strIdMoneda
			End With 
		End With 

		Try
			cnx.open
			dr = cmd.ExecuteReader

			If dr.HasRows Then
				While dr.Read()
					With MonedaBE
						If dr("IdMoneda") Is DBNull.Value Then
							.IdMoneda= Nothing
						Else
							.IdMoneda= dr("IdMoneda")
						End If

						If dr("CodigoMoneda") Is DBNull.Value Then
							.CodigoMoneda= Nothing
						Else
							.CodigoMoneda= dr("CodigoMoneda")
						End If

						If dr("Descripcion") Is DBNull.Value Then
							.Descripcion= Nothing
						Else
							.Descripcion= dr("Descripcion")
                        End If

                        If dr("TextoImpresion") Is DBNull.Value Then
                            .TextoImpresion = Nothing
                        Else
                            .TextoImpresion = dr("TextoImpresion")
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
		Return MonedaBE
    End Function

    Public Function GetMonedas(ByVal oMonedaBECrit As MonedaBE) As List(Of MonedaBE)
        Dim dr As SqlDataReader

        Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "MONEDA_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oMonedaBE As New MonedaBE

                    If dr("IdMoneda") Is DBNull.Value Then
                        oMonedaBE.IdMoneda = Nothing
                    Else
                        oMonedaBE.IdMoneda = dr("IdMoneda")
                    End If

                    If dr("CodigoMoneda") Is DBNull.Value Then
                        oMonedaBE.CodigoMoneda = Nothing
                    Else
                        oMonedaBE.CodigoMoneda = dr("CodigoMoneda")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oMonedaBE.Descripcion = Nothing
                    Else
                        oMonedaBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("TextoImpresion") Is DBNull.Value Then
                        oMonedaBE.TextoImpresion = Nothing
                    Else
                        oMonedaBE.TextoImpresion = dr("TextoImpresion")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oMonedaBE.UsuarioCreacion = Nothing
                    Else
                        oMonedaBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oMonedaBE.FechaCreacion = Nothing
                    Else
                        oMonedaBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oMonedaBE.UsuarioModificacion = Nothing
                    Else
                        oMonedaBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oMonedaBE.FechaModificacion = Nothing
                    Else
                        oMonedaBE.FechaModificacion = dr("FechaModificacion")
                    End If

                    listMonedas.Add(oMonedaBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listMonedas
    End Function
End class
