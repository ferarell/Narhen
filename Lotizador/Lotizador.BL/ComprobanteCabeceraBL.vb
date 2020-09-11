Imports System.Transactions
Imports Lotizador.BE
Imports Lotizador.DAO

Public Class ComprobanteCabeceraBL

    Public Sub Registra(oCCabecera As ComprobanteCabeceraBE, lstCDetalle As List(Of ComprobanteDetalleBE))
        Dim oCCabeceraDA As New ComprobanteCabeceraDA()
        Dim oCDetalleBL As New ComprobanteDetalleBL()
        Try
            Dim trxOpciones As TransactionScopeOption = New TransactionScopeOption
            Using trx As TransactionScope = New TransactionScope(trxOpciones, New TimeSpan(0, 2, 0))
                oCCabeceraDA.Registra(oCCabecera)

                For Each oCDetalle As ComprobanteDetalleBE In lstCDetalle
                    oCDetalle.n_cc_id = oCCabecera.n_cc_id
                    oCDetalleBL.Registra(oCDetalle)
                Next

                trx.Complete()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Buscar(TipoComprobante As String, NumeroSerie As String, NumeroCorrelativo As String) As DataTable
        Dim oCCabeceraDA As New ComprobanteCabeceraDA()
        Try
            Return oCCabeceraDA.Buscar(TipoComprobante, NumeroSerie, NumeroCorrelativo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ActualizaEstadoComprobantes(TipoComprobante As String, NroSerie As String, NroCorrelativo As String, logFecha As String, logHora As String, logUsuario As String)
        Dim oCCabeceraDA As New ComprobanteCabeceraDA()
        Try
            oCCabeceraDA.ActualizaEstadoComprobantes(TipoComprobante, NroSerie, NroCorrelativo, logFecha, logHora, logUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
