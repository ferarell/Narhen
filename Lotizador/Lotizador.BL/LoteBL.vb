Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class LoteBL
    Dim oLoteDAO As New LoteDAO

    Public Function Insert(ByVal BE As LoteBE) As Boolean
        Return oLoteDAO.Insert(BE)
    End Function
    Public Function Update(ByVal BE As LoteBE) As Boolean
        Return oLoteDAO.Update(BE)
    End Function
    Public Function Delete(ByVal oLoteBE As LoteBE) As Boolean
        Return oLoteDAO.Delete(oLoteBE)
    End Function
    Public Function GetLote(ByVal strCodLote As String) As LoteBE
        Return oLoteDAO.GetLote(strCodLote)
    End Function
    Public Function GetLotes(ByVal oLoteBE As LoteBE) As List(Of LoteBE)
        Return oLoteDAO.GetLotes(oLoteBE)
    End Function
    Public Function GetLotesDisponibles(ByVal IdProyecto As String, ByVal IdLote As String) As List(Of LoteBE)
        Return oLoteDAO.GetLotesDisponibles(IdProyecto, IdLote)
    End Function
    Public Function ListarLotesPorSocio(idSocio) As List(Of LoteBE)
        Return oLoteDAO.ListarLotesPorSocio(idSocio)
    End Function
End Class