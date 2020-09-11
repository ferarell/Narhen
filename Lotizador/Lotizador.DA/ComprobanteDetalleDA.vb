Imports Lotizador.BE
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ComprobanteDetalleDA
    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Sub New()

    End Sub

    Public Sub Registra(oCDetalle As ComprobanteDetalleBE)
        Try
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_registra_comprobante_detalle", cnx)
                    Dim parSequencia As SqlParameter = New SqlParameter("@n_cd_id", SqlDbType.Decimal)
                    parSequencia.Value = oCDetalle.n_cc_id
                    parSequencia.Precision = 10
                    parSequencia.Direction = ParameterDirection.InputOutput
                    oCmd.Parameters.Add(parSequencia)

                    oCmd.Parameters.Add(New SqlParameter("@n_cc_id", oCDetalle.n_cc_id))
                    oCmd.Parameters.Add(New SqlParameter("@v_cd_codigo", oCDetalle.v_cd_codigo))
                    oCmd.Parameters.Add(New SqlParameter("@n_cd_cantidad", oCDetalle.n_cd_cantidad))
                    oCmd.Parameters.Add(New SqlParameter("@c_cd_unidad", oCDetalle.c_cd_unidad))
                    oCmd.Parameters.Add(New SqlParameter("@v_cd_descripcion", oCDetalle.v_cd_descripcion))
                    oCmd.Parameters.Add(New SqlParameter("@n_cd_valorventa", oCDetalle.n_cd_valorventa))
                    oCmd.Parameters.Add(New SqlParameter("@n_cd_descuento", oCDetalle.n_cd_descuento))
                    oCmd.Parameters.Add(New SqlParameter("@n_cd_importe", oCDetalle.n_cd_importe))
                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()
                    oCmd.ExecuteNonQuery()

                    oCDetalle.n_cd_id = Convert.ToDecimal(parSequencia.Value)
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Sub

    Public Function Buscar(ComprobanteCabeceraID As Integer) As DataTable
        Try
            Dim dt As New DataTable
            Using cnx As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("_NARHEN").ToString())
                Using oCmd As SqlCommand = New SqlCommand("sp_buscar_comprobante_detalle", cnx)
                    oCmd.Parameters.Add(New SqlParameter("@n_cc_id", ComprobanteCabeceraID))

                    oCmd.CommandType = CommandType.StoredProcedure
                    'oCmd.CommandTimeout = intTimeOut

                    cnx.Open()

                    Using dr As SqlDataAdapter = New SqlDataAdapter(oCmd)
                        dr.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            cnx.Close()
        End Try
    End Function

End Class
