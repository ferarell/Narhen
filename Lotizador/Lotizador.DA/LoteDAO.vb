Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic

Public Class LoteDAO
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand


    Public Sub New()

    End Sub

    Public Function Insert(ByVal BE As LoteBE) As Boolean
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LOTE_INS01"

            With .Parameters
                .Clear()
                .Add("@IDLOTE", SqlDbType.Int).Value = BE.IdLote
                .Add("@DESCRIPCION", SqlDbType.VarChar, 30).Value = BE.Descripcion
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@IDUNIDADCATASTRAL", SqlDbType.Int).Value = BE.IdUnidadCatastral
                .Add("@SUPERFICIE", SqlDbType.Float).Value = BE.Superficie
                .Add("@MANZANA", SqlDbType.VarChar, 20).Value = BE.Manzana
                .Add("@LINDEROFRENTE", SqlDbType.VarChar, 50).Value = BE.LinderoFrente
                .Add("@LONGITUDLINDEROFRENTE", SqlDbType.Float).Value = BE.LongitudLinderoFrente
                .Add("@LINDERODERECHA", SqlDbType.VarChar, 50).Value = BE.LinderoDerecha
                .Add("@LONGITUDLINDERODERECHA", SqlDbType.Float).Value = BE.LongitudLinderoDerecha
                .Add("@LINDEROIZQUIERDA", SqlDbType.VarChar, 50).Value = BE.LinderoIzquierda
                .Add("@LONGITUDLINDEROIZQUIERDA", SqlDbType.Float).Value = BE.LongitudLinderoIzquierda
                .Add("@LINDEROFONDO", SqlDbType.VarChar, 50).Value = BE.LinderoFondo
                .Add("@LONGITUDLINDEROFONDO", SqlDbType.Float).Value = BE.LongitudLinderoFondo
                .Add("@IMPORTEM2", SqlDbType.Money).Value = BE.ImporteM2
                .Add("@IMPORTEDESCUENTO", SqlDbType.Money).Value = BE.ImporteDescuento
                .Add("@IMPORTELOTE", SqlDbType.Money).Value = BE.ImporteLote
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

    Public Function Update(ByVal BE As LoteBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LOTE_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDLOTE", SqlDbType.Int).Value = BE.IdLote
                .Add("@DESCRIPCION", SqlDbType.VarChar, 30).Value = BE.Descripcion
                .Add("@IDPROYECTO", SqlDbType.Int).Value = BE.IdProyecto
                .Add("@IDUNIDADCATASTRAL", SqlDbType.Int).Value = BE.IdUnidadCatastral
                .Add("@SUPERFICIE", SqlDbType.Float).Value = BE.Superficie
                .Add("@MANZANA", SqlDbType.VarChar, 20).Value = BE.Manzana
                .Add("@LINDEROFRENTE", SqlDbType.VarChar, 50).Value = BE.LinderoFrente
                .Add("@LONGITUDLINDEROFRENTE", SqlDbType.Float).Value = BE.LongitudLinderoFrente
                .Add("@LINDERODERECHA", SqlDbType.VarChar, 50).Value = BE.LinderoDerecha
                .Add("@LONGITUDLINDERODERECHA", SqlDbType.Float).Value = BE.LongitudLinderoDerecha
                .Add("@LINDEROIZQUIERDA", SqlDbType.VarChar, 50).Value = BE.LinderoIzquierda
                .Add("@LONGITUDLINDEROIZQUIERDA", SqlDbType.Float).Value = BE.LongitudLinderoIzquierda
                .Add("@LINDEROFONDO", SqlDbType.VarChar, 50).Value = BE.LinderoFondo
                .Add("@LONGITUDLINDEROFONDO", SqlDbType.Float).Value = BE.LongitudLinderoFondo
                .Add("@IMPORTEM2", SqlDbType.Money).Value = BE.ImporteM2
                .Add("@IMPORTEDESCUENTO", SqlDbType.Money).Value = BE.ImporteDescuento
                .Add("@IMPORTELOTE", SqlDbType.Money).Value = BE.ImporteLote
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

    Public Function Delete(ByVal oLoteBE As LoteBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LOTE_DEL01"

            With .Parameters
                .Clear()
                .Add("@IdLote", SqlDbType.Int).Value = oLoteBE.IdLote
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


    Public Function GetLotes(ByVal oLoteBECrit As LoteBE) As List(Of LoteBE)
        Dim dr As SqlDataReader

        Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "LOTE_GET02"

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oLoteBE As New LoteBE
                    With oLoteBE
                        If dr("IdLote") Is DBNull.Value Then
                            .IdLote = Nothing
                        Else
                            .IdLote = dr("IdLote")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("IdUnidadCatastral") Is DBNull.Value Then
                            .IdUnidadCatastral = Nothing
                        Else
                            .IdUnidadCatastral = dr("IdUnidadCatastral")
                        End If

                        If dr("NombreProyecto") Is DBNull.Value Then
                            .NombreProyecto = Nothing
                        Else
                            .NombreProyecto = dr("NombreProyecto")
                        End If

                        If dr("CodigoMoneda") Is DBNull.Value Then
                            .CodigoMoneda = Nothing
                        Else
                            .CodigoMoneda = dr("CodigoMoneda")
                        End If

                        If dr("Superficie") Is DBNull.Value Then
                            .Superficie = Nothing
                        Else
                            .Superficie = dr("Superficie")
                        End If

                        If dr("Manzana") Is DBNull.Value Then
                            .Manzana = Nothing
                        Else
                            .Manzana = dr("Manzana")
                        End If

                        If dr("LinderoFrente") Is DBNull.Value Then
                            .LinderoFrente = Nothing
                        Else
                            .LinderoFrente = dr("LinderoFrente")
                        End If

                        If dr("LongitudLinderoFrente") Is DBNull.Value Then
                            .LongitudLinderoFrente = Nothing
                        Else
                            .LongitudLinderoFrente = dr("LongitudLinderoFrente")
                        End If

                        If dr("LinderoDerecha") Is DBNull.Value Then
                            .LinderoDerecha = Nothing
                        Else
                            .LinderoDerecha = dr("LinderoDerecha")
                        End If

                        If dr("LongitudLinderoDerecha") Is DBNull.Value Then
                            .LongitudLinderoDerecha = Nothing
                        Else
                            .LongitudLinderoDerecha = dr("LongitudLinderoDerecha")
                        End If

                        If dr("LinderoIzquierda") Is DBNull.Value Then
                            .LinderoIzquierda = Nothing
                        Else
                            .LinderoIzquierda = dr("LinderoIzquierda")
                        End If

                        If dr("LongitudLinderoIzquierda") Is DBNull.Value Then
                            .LongitudLinderoIzquierda = Nothing
                        Else
                            .LongitudLinderoIzquierda = dr("LongitudLinderoIzquierda")
                        End If

                        If dr("LinderoFondo") Is DBNull.Value Then
                            .LinderoFondo = Nothing
                        Else
                            .LinderoFondo = dr("LinderoFondo")
                        End If

                        If dr("LongitudLinderoFondo") Is DBNull.Value Then
                            .LongitudLinderoFondo = Nothing
                        Else
                            .LongitudLinderoFondo = dr("LongitudLinderoFondo")
                        End If

                        If dr("ImporteM2") Is DBNull.Value Then
                            .ImporteM2 = Nothing
                        Else
                            .ImporteM2 = dr("ImporteM2")
                        End If

                        If dr("ImporteDescuento") Is DBNull.Value Then
                            .ImporteDescuento = Nothing
                        Else
                            .ImporteDescuento = dr("ImporteDescuento")
                        End If

                        If dr("ImporteLote") Is DBNull.Value Then
                            .ImporteLote = Nothing
                        Else
                            .ImporteLote = dr("ImporteLote")
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
                    listLotes.Add(oLoteBE)
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listLotes
    End Function

    Public Function GetLote(ByVal strIdLote As String) As LoteBE
        Dim dr As SqlDataReader
        Dim LoteBE As New LoteBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LOTE_GET01"

            With .Parameters
                .Clear()
                .Add("@IdLote", SqlDbType.Int).Value = strIdLote
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With LoteBE
                        If dr("IdLote") Is DBNull.Value Then
                            .IdLote = Nothing
                        Else
                            .IdLote = dr("IdLote")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("IdUnidadCatastral") Is DBNull.Value Then
                            .IdUnidadCatastral = Nothing
                        Else
                            .IdUnidadCatastral = dr("IdUnidadCatastral")
                        End If

                        If dr("Superficie") Is DBNull.Value Then
                            .Superficie = Nothing
                        Else
                            .Superficie = dr("Superficie")
                        End If

                        If dr("Manzana") Is DBNull.Value Then
                            .Manzana = Nothing
                        Else
                            .Manzana = dr("Manzana")
                        End If

                        If dr("LinderoFrente") Is DBNull.Value Then
                            .LinderoFrente = Nothing
                        Else
                            .LinderoFrente = dr("LinderoFrente")
                        End If

                        If dr("LongitudLinderoFrente") Is DBNull.Value Then
                            .LongitudLinderoFrente = Nothing
                        Else
                            .LongitudLinderoFrente = dr("LongitudLinderoFrente")
                        End If

                        If dr("LinderoDerecha") Is DBNull.Value Then
                            .LinderoDerecha = Nothing
                        Else
                            .LinderoDerecha = dr("LinderoDerecha")
                        End If

                        If dr("LongitudLinderoDerecha") Is DBNull.Value Then
                            .LongitudLinderoDerecha = Nothing
                        Else
                            .LongitudLinderoDerecha = dr("LongitudLinderoDerecha")
                        End If

                        If dr("LinderoIzquierda") Is DBNull.Value Then
                            .LinderoIzquierda = Nothing
                        Else
                            .LinderoIzquierda = dr("LinderoIzquierda")
                        End If

                        If dr("LongitudLinderoIzquierda") Is DBNull.Value Then
                            .LongitudLinderoIzquierda = Nothing
                        Else
                            .LongitudLinderoIzquierda = dr("LongitudLinderoIzquierda")
                        End If

                        If dr("LinderoFondo") Is DBNull.Value Then
                            .LinderoFondo = Nothing
                        Else
                            .LinderoFondo = dr("LinderoFondo")
                        End If

                        If dr("LongitudLinderoFondo") Is DBNull.Value Then
                            .LongitudLinderoFondo = Nothing
                        Else
                            .LongitudLinderoFondo = dr("LongitudLinderoFondo")
                        End If

                        If dr("ImporteM2") Is DBNull.Value Then
                            .ImporteM2 = Nothing
                        Else
                            .ImporteM2 = dr("ImporteM2")
                        End If

                        If dr("ImporteDescuento") Is DBNull.Value Then
                            .ImporteDescuento = Nothing
                        Else
                            .ImporteDescuento = dr("ImporteDescuento")
                        End If

                        If dr("ImporteLote") Is DBNull.Value Then
                            .ImporteLote = Nothing
                        Else
                            .ImporteLote = dr("ImporteLote")
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
        Return LoteBE
    End Function

    Public Function GetLotesDisponibles(ByVal IdProyecto As String, ByVal IdLote As String) As List(Of LoteBE)
        Dim dr As SqlDataReader
        Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)()

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LOTE_GET03"

            With .Parameters
                .Clear()
                .Add("@IDPROYECTO", SqlDbType.Int).Value = IdProyecto
                .Add("@IDLOTE", SqlDbType.Int).Value = IdLote
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oLoteBE As New LoteBE
                    With oLoteBE
                        If dr("IdLote") Is DBNull.Value Then
                            .IdLote = Nothing
                        Else
                            .IdLote = dr("IdLote")
                        End If

                        If dr("Descripcion") Is DBNull.Value Then
                            .Descripcion = Nothing
                        Else
                            .Descripcion = dr("Descripcion")
                        End If

                        If dr("IdProyecto") Is DBNull.Value Then
                            .IdProyecto = Nothing
                        Else
                            .IdProyecto = dr("IdProyecto")
                        End If

                        If dr("IdUnidadCatastral") Is DBNull.Value Then
                            .IdUnidadCatastral = Nothing
                        Else
                            .IdUnidadCatastral = dr("IdUnidadCatastral")
                        End If

                        If dr("NombreProyecto") Is DBNull.Value Then
                            .NombreProyecto = Nothing
                        Else
                            .NombreProyecto = dr("NombreProyecto")
                        End If

                        If dr("IdMoneda") Is DBNull.Value Then
                            .IdMoneda = Nothing
                        Else
                            .IdMoneda = dr("IdMoneda")
                        End If

                        'If dr("CodigoMoneda") Is DBNull.Value Then
                        '    .CodigoMoneda = Nothing
                        'Else
                        '    .CodigoMoneda = dr("CodigoMoneda")
                        'End If

                        'If dr("Superficie") Is DBNull.Value Then
                        '    .Superficie = Nothing
                        'Else
                        '    .Superficie = dr("Superficie")
                        'End If

                        'If dr("Manzana") Is DBNull.Value Then
                        '    .Manzana = Nothing
                        'Else
                        '    .Manzana = dr("Manzana")
                        'End If

                        'If dr("LinderoFrente") Is DBNull.Value Then
                        '    .LinderoFrente = Nothing
                        'Else
                        '    .LinderoFrente = dr("LinderoFrente")
                        'End If

                        'If dr("LongitudLinderoFrente") Is DBNull.Value Then
                        '    .LongitudLinderoFrente = Nothing
                        'Else
                        '    .LongitudLinderoFrente = dr("LongitudLinderoFrente")
                        'End If

                        'If dr("LinderoDerecha") Is DBNull.Value Then
                        '    .LinderoDerecha = Nothing
                        'Else
                        '    .LinderoDerecha = dr("LinderoDerecha")
                        'End If

                        'If dr("LongitudLinderoDerecha") Is DBNull.Value Then
                        '    .LongitudLinderoDerecha = Nothing
                        'Else
                        '    .LongitudLinderoDerecha = dr("LongitudLinderoDerecha")
                        'End If

                        'If dr("LinderoIzquierda") Is DBNull.Value Then
                        '    .LinderoIzquierda = Nothing
                        'Else
                        '    .LinderoIzquierda = dr("LinderoIzquierda")
                        'End If

                        'If dr("LongitudLinderoIzquierda") Is DBNull.Value Then
                        '    .LongitudLinderoIzquierda = Nothing
                        'Else
                        '    .LongitudLinderoIzquierda = dr("LongitudLinderoIzquierda")
                        'End If

                        'If dr("LinderoFondo") Is DBNull.Value Then
                        '    .LinderoFondo = Nothing
                        'Else
                        '    .LinderoFondo = dr("LinderoFondo")
                        'End If

                        'If dr("LongitudLinderoFondo") Is DBNull.Value Then
                        '    .LongitudLinderoFondo = Nothing
                        'Else
                        '    .LongitudLinderoFondo = dr("LongitudLinderoFondo")
                        'End If

                        'If dr("ImporteM2") Is DBNull.Value Then
                        '    .ImporteM2 = Nothing
                        'Else
                        '    .ImporteM2 = dr("ImporteM2")
                        'End If

                        'If dr("ImporteDescuento") Is DBNull.Value Then
                        '    .ImporteDescuento = Nothing
                        'Else
                        '    .ImporteDescuento = dr("ImporteDescuento")
                        'End If

                        'If dr("ImporteLote") Is DBNull.Value Then
                        '    .ImporteLote = Nothing
                        'Else
                        '    .ImporteLote = dr("ImporteLote")
                        'End If

                        'If dr("UsuarioCreacion") Is DBNull.Value Then
                        '    .UsuarioCreacion = Nothing
                        'Else
                        '    .UsuarioCreacion = dr("UsuarioCreacion")
                        'End If

                        'If dr("FechaCreacion") Is DBNull.Value Then
                        '    .FechaCreacion = Nothing
                        'Else
                        '    .FechaCreacion = dr("FechaCreacion")
                        'End If

                        'If dr("UsuarioModificacion") Is DBNull.Value Then
                        '    .UsuarioModificacion = Nothing
                        'Else
                        '    .UsuarioModificacion = dr("UsuarioModificacion")
                        'End If

                        'If dr("FechaModificacion") Is DBNull.Value Then
                        '    .FechaModificacion = Nothing
                        'Else
                        '    .FechaModificacion = dr("FechaModificacion")
                        'End If

                    End With
                    listLotes.Add(oLoteBE)
                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listLotes
    End Function

    Public Function ListarLotesPorSocio(idSocio) As List(Of LoteBE)
        Dim lstLote As New List(Of LoteBE)
        Dim oLoteBE As LoteBE
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using cmd As SqlCommand = New SqlCommand("sp_listar_lotes_x_socio", cnx)
                    cnx.Open()
                    cmd.Parameters.Add(New SqlParameter("@IdSocio", idSocio))
                    cmd.CommandType = CommandType.StoredProcedure
                    Using dr As SqlDataReader = cmd.ExecuteReader
                        While dr.Read
                            oLoteBE = New LoteBE()
                            With oLoteBE
                                .IdLote = dr("IdLote").ToString
                                .Lote = dr("Lote").ToString
                            End With
                            lstLote.Add(oLoteBE)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'oLoteBE = New LoteBE()
            'With oLoteBE
            '    .ErrorCodigo = "EX"
            '    .ErrorMensaje = ex.Message
            'End With
            'lstLote.Add(oLoteBE)
            Throw ex
        Finally
            cnx.Close()
        End Try
        Return lstLote
    End Function

End Class
