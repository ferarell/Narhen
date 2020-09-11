Imports Lotizador.BE
Imports Lotizador.DAO

Public Class ComprobanteDetalleBL

    Public Sub Registra(oCDetalle As ComprobanteDetalleBE)
        Dim oCDetalleDA As New ComprobanteDetalleDA()
        Try
            oCDetalleDA.Registra(oCDetalle)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Buscar(ComprobanteCabeceraID As Integer) As DataTable
        Dim oCDetalleDA As New ComprobanteDetalleDA()
        Try
            Return oCDetalleDA.Buscar(ComprobanteCabeceraID)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
