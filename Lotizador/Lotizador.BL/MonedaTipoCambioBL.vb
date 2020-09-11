Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class MonedaTipoCambioBL
    Dim MonedaTipoCambioDAO As New MonedaTipoCambioDAO

    Public Function Insert(ByVal BE As MonedaTipoCambioBE) As Boolean
        Return MonedaTipoCambioDAO.Insert(BE)
    End Function
    Public Function Update(ByVal BE As MonedaTipoCambioBE) As Boolean
        Return MonedaTipoCambioDAO.Update(BE)
    End Function
    Public Function Delete(ByVal MonedaTipoCambioBE As MonedaTipoCambioBE) As Boolean
        Return MonedaTipoCambioDAO.Delete(MonedaTipoCambioBE)
    End Function
    Public Function GetMonedaTipoCambio(ByVal strCodMoneda As String, ByVal dFechaReferencia As Date) As MonedaTipoCambioBE
        Return MonedaTipoCambioDAO.GetMonedaTipoCambio(strCodMoneda, dFechaReferencia)
    End Function
    Public Function GetMonedasTipoCambio(ByVal MonedaTipoCambioBE As MonedaTipoCambioBE) As List(Of MonedaTipoCambioBE)
        Return MonedaTipoCambioDAO.GetMonedasTipoCambio(MonedaTipoCambioBE)
    End Function

End Class
