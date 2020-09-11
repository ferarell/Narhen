Imports Lotizador.BE
Imports Lotizador.DAO

Public Class ComprobanteBL

    Private oComprobanteDA As New ComprobanteDA

    Public Function ListarComprobantes() As List(Of ComprobanteBE)
        Return oComprobanteDA.ListarComprobantes()
    End Function

    Public Function ListarComprobantesPorTipo(tipoComprobante As String) As List(Of ComprobanteBE)
        Return oComprobanteDA.ListarComprobantesPorTipo(tipoComprobante)
    End Function

    Public Function ListarComprobantesPorTipoPorCliente(tipoComprobante As String, cliente As String) As List(Of ComprobanteBE)
        Return oComprobanteDA.ListarComprobantesPorTipoPorCliente(tipoComprobante, cliente)
    End Function

End Class
