Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class ContratoDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As ContratoBE) As Integer



        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATO_INS01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.Int).Value = BE.IdContrato
        cmd.Parameters.Add("@IDLOTE", SqlDbType.Int).Value = BE.IdLote
        cmd.Parameters.Add("@FECHAEMISION", SqlDbType.Date).Value = BE.FechaEmision
        cmd.Parameters.Add("@NUMEROCUOTAS", SqlDbType.SmallInt).Value = BE.NumeroCuotas
        cmd.Parameters.Add("@VALORCUOTAS", SqlDbType.Money).Value = BE.ValorCuotas
        cmd.Parameters.Add("@FECHAINICIO", SqlDbType.Date).Value = BE.FechaInicio
        cmd.Parameters.Add("@DIAPAGO", SqlDbType.SmallInt).Value = BE.DiaPago
        cmd.Parameters.Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
        cmd.Parameters.Add("@IMPORTETOTAL", SqlDbType.Money).Value = BE.ImporteTotal
        cmd.Parameters.Add("@IMPORTEINICIAL", SqlDbType.Money).Value = BE.ImporteInicial
        cmd.Parameters.Add("@PRIMERACUOTA", SqlDbType.Money).Value = BE.PrimeraCuota
        cmd.Parameters.Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
        cmd.Parameters.Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
        cmd.Parameters.Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
        cmd.Parameters.Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion


        Try
            cnx.Open()
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Update(ByVal BE As ContratoBE) As Boolean




        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATO_UPD01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.Int).Value = BE.IdContrato
        cmd.Parameters.Add("@IDLOTE", SqlDbType.Int).Value = BE.IdLote
        cmd.Parameters.Add("@FECHAEMISION", SqlDbType.Date).Value = BE.FechaEmision
        cmd.Parameters.Add("@NUMEROCUOTAS", SqlDbType.SmallInt).Value = BE.NumeroCuotas
        cmd.Parameters.Add("@VALORCUOTAS", SqlDbType.Money).Value = BE.ValorCuotas
        cmd.Parameters.Add("@FECHAINICIO", SqlDbType.Date).Value = BE.FechaInicio
        cmd.Parameters.Add("@DIAPAGO", SqlDbType.SmallInt).Value = BE.DiaPago
        cmd.Parameters.Add("@IDMONEDA", SqlDbType.SmallInt).Value = BE.IdMoneda
        cmd.Parameters.Add("@IMPORTETOTAL", SqlDbType.Money).Value = BE.ImporteTotal
        cmd.Parameters.Add("@IMPORTEINICIAL", SqlDbType.Money).Value = BE.ImporteInicial
        cmd.Parameters.Add("@PRIMERACUOTA", SqlDbType.Money).Value = BE.PrimeraCuota
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

    Public Function Delete(ByVal oContratoBE As ContratoBE) As Boolean

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATO_DEL01"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.Int).Value = oContratoBE.IdContrato


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

    Public Function GetContrato(ByVal strIdContrato As Int32) As ContratoBE
        Dim dr As SqlDataReader
        Dim oContratoBE As New ContratoBE


        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Contrato_GET01"


        cmd.Parameters.Clear()
        cmd.Parameters.Add("@IDCONTRATO", SqlDbType.SmallInt).Value = strIdContrato


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()

                    If dr("IdContrato") Is DBNull.Value Then
                        oContratoBE.IdContrato = Nothing
                    Else
                        oContratoBE.IdContrato = dr("IdContrato")
                    End If

                    If dr("IdLote") Is DBNull.Value Then
                        oContratoBE.IdLote = Nothing
                    Else
                        oContratoBE.IdLote = dr("IdLote")
                    End If

                    If dr("IdProyecto") Is DBNull.Value Then
                        oContratoBE.IdProyecto = Nothing
                    Else
                        oContratoBE.IdProyecto = dr("IdProyecto")
                    End If

                    If dr("FechaEmision") Is DBNull.Value Then
                        oContratoBE.FechaEmision = Nothing
                    Else
                        oContratoBE.FechaEmision = dr("FechaEmision")
                    End If

                    If dr("NumeroCuotas") Is DBNull.Value Then
                        oContratoBE.NumeroCuotas = Nothing
                    Else
                        oContratoBE.NumeroCuotas = dr("NumeroCuotas")
                    End If

                    If dr("ValorCuotas") Is DBNull.Value Then
                        oContratoBE.ValorCuotas = Nothing
                    Else
                        oContratoBE.ValorCuotas = dr("ValorCuotas")
                    End If

                    If dr("FechaInicio") Is DBNull.Value Then
                        oContratoBE.FechaInicio = Nothing
                    Else
                        oContratoBE.FechaInicio = dr("FechaInicio")
                    End If

                    If dr("DiaPago") Is DBNull.Value Then
                        oContratoBE.DiaPago = Nothing
                    Else
                        oContratoBE.DiaPago = dr("DiaPago")
                    End If

                    If dr("IdMoneda") Is DBNull.Value Then
                        oContratoBE.IdMoneda = Nothing
                    Else

                        oContratoBE.IdMoneda = dr("IdMoneda")
                    End If


                    If dr("CodigoMoneda") Is DBNull.Value Then
                        oContratoBE.CodigoMoneda = Nothing
                    Else

                        oContratoBE.CodigoMoneda = dr("CodigoMoneda")
                    End If

                    If dr("DescripcionLote") Is DBNull.Value Then
                        oContratoBE.DescripcionLote = Nothing
                    Else

                        oContratoBE.DescripcionLote = dr("DescripcionLote")
                    End If



                    If dr("ImporteTotal") Is DBNull.Value Then
                        oContratoBE.ImporteTotal = Nothing
                    Else
                        oContratoBE.ImporteTotal = dr("ImporteTotal")
                    End If

                    If dr("ImporteInicial") Is DBNull.Value Then
                        oContratoBE.ImporteInicial = Nothing
                    Else
                        oContratoBE.ImporteInicial = dr("ImporteInicial")
                    End If

                    If dr("PrimeraCuota") Is DBNull.Value Then
                        oContratoBE.PrimeraCuota = Nothing
                    Else
                        oContratoBE.PrimeraCuota = dr("PrimeraCuota")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oContratoBE.UsuarioCreacion = Nothing
                    Else
                        oContratoBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oContratoBE.FechaCreacion = Nothing
                    Else
                        oContratoBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oContratoBE.UsuarioModificacion = Nothing
                    Else
                        oContratoBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oContratoBE.FechaModificacion = Nothing
                    Else
                        oContratoBE.FechaModificacion = dr("FechaModificacion")
                    End If




                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oContratoBE
    End Function

    Public Function GetContratos(ByVal oContratoBECrit As ContratoBE) As List(Of ContratoBE)
        Dim dr As SqlDataReader

        Dim listContratos As List(Of ContratoBE) = New List(Of ContratoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "CONTRATO_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oContratoBE As ContratoBE = New ContratoBE()

                    If dr("IdContrato") Is DBNull.Value Then
                        oContratoBE.IdContrato = Nothing
                    Else
                        oContratoBE.IdContrato = dr("IdContrato")
                    End If

                    If dr("IdLote") Is DBNull.Value Then
                        oContratoBE.IdLote = Nothing
                    Else
                        oContratoBE.IdLote = dr("IdLote")
                    End If

                    If dr("IdProyecto") Is DBNull.Value Then
                        oContratoBE.IdProyecto = Nothing
                    Else
                        oContratoBE.IdProyecto = dr("IdProyecto")
                    End If

                    If dr("FechaEmision") Is DBNull.Value Then
                        oContratoBE.FechaEmision = Nothing
                    Else
                        oContratoBE.FechaEmision = dr("FechaEmision")
                    End If

                    If dr("NumeroCuotas") Is DBNull.Value Then
                        oContratoBE.NumeroCuotas = Nothing
                    Else
                        oContratoBE.NumeroCuotas = dr("NumeroCuotas")
                    End If

                    If dr("ValorCuotas") Is DBNull.Value Then
                        oContratoBE.ValorCuotas = Nothing
                    Else
                        oContratoBE.ValorCuotas = dr("ValorCuotas")
                    End If

                    If dr("FechaInicio") Is DBNull.Value Then
                        oContratoBE.FechaInicio = Nothing
                    Else
                        oContratoBE.FechaInicio = dr("FechaInicio")
                    End If

                    If dr("DiaPago") Is DBNull.Value Then
                        oContratoBE.DiaPago = Nothing
                    Else
                        oContratoBE.DiaPago = dr("DiaPago")
                    End If

                    If dr("IdMoneda") Is DBNull.Value Then
                        oContratoBE.IdMoneda = Nothing
                    Else
                        oContratoBE.IdMoneda = dr("IdMoneda")
                    End If

                    If dr("DescripcionLote") Is DBNull.Value Then
                        oContratoBE.DescripcionLote = Nothing
                    Else
                        oContratoBE.DescripcionLote = dr("DescripcionLote")
                    End If

                    If dr("ImporteInicial") Is DBNull.Value Then
                        oContratoBE.ImporteInicial = Nothing
                    Else
                        oContratoBE.ImporteInicial = dr("ImporteInicial")
                    End If

                    If dr("PrimeraCuota") Is DBNull.Value Then
                        oContratoBE.PrimeraCuota = Nothing
                    Else
                        oContratoBE.PrimeraCuota = dr("PrimeraCuota")
                    End If

                    If dr("CodigoMoneda") Is DBNull.Value Then
                        oContratoBE.CodigoMoneda = Nothing
                    Else
                        oContratoBE.CodigoMoneda = dr("CodigoMoneda")
                    End If

                    If dr("ImporteTotal") Is DBNull.Value Then
                        oContratoBE.ImporteTotal = Nothing
                    Else
                        oContratoBE.ImporteTotal = dr("ImporteTotal")
                    End If

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oContratoBE.UsuarioCreacion = Nothing
                    Else
                        oContratoBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oContratoBE.FechaCreacion = Nothing
                    Else
                        oContratoBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oContratoBE.UsuarioModificacion = Nothing
                    Else
                        oContratoBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oContratoBE.FechaModificacion = Nothing
                    Else
                        oContratoBE.FechaModificacion = dr("FechaModificacion")
                    End If

                    If dr("NombreProyecto") Is DBNull.Value Then
                        oContratoBE.NombreProyecto = Nothing
                    Else
                        oContratoBE.NombreProyecto = dr("NombreProyecto")
                    End If

                    If dr("NombreSocio") Is DBNull.Value Then
                        oContratoBE.NombreSocio = Nothing
                    Else
                        oContratoBE.NombreSocio = dr("NombreSocio")
                    End If

                    If dr("ManzanaLote") Is DBNull.Value Then
                        oContratoBE.ManzanaLote = Nothing
                    Else
                        oContratoBE.ManzanaLote = dr("ManzanaLote")
                    End If

                    listContratos.Add(oContratoBE)

                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listContratos
    End Function


    Public Function GetSociosContratosDataTable(ByVal oContratoBE As ContratoBE) As ContratoBE
        Dim dtReturn As New DataTable
        Try
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = cnx
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "CONTRATO_GET03"
            cmd.Parameters.Add("@IDCONTRATO", SqlDbType.SmallInt).Value = oContratoBE.IdContrato
            cnx.Open()
            oContratoBE.dtSocios = New DataTable
            oContratoBE.dtSocios.TableName = "Contrato"
            oContratoBE.dtSocios.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return oContratoBE
    End Function


End Class
