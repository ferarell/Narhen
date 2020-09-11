Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class UnidadCatastralBL

    Dim oUnidadCatastralDAO As New UnidadCatastralDAO

    Public Function Insert(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
        Return oUnidadCatastralDAO.Insert(oUnidadCatastralBE)
    End Function
    Public Function Update(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
        Return oUnidadCatastralDAO.Update(oUnidadCatastralBE)
    End Function
    Public Function Delete(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
        Return oUnidadCatastralDAO.Delete(oUnidadCatastralBE)
    End Function
    Public Function GetUnidadCatastral(ByVal strCodUnidadCatastral As String) As UnidadCatastralBE
        Return oUnidadCatastralDAO.GetUnidadCatastral(strCodUnidadCatastral)
    End Function
    Public Function GetUnidadesCatastrales(ByVal oUnidadCatastralBE As UnidadCatastralBE) As List(Of UnidadCatastralBE)
        Return oUnidadCatastralDAO.GetUnidadesCatastrales(oUnidadCatastralBE)
    End Function
End Class
