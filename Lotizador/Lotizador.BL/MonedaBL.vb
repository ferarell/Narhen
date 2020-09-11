Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class MonedaBL
    Dim oMonedaDAO As New MonedaDAO

	Public Function Insert(ByVal BE As MonedaBE) As Boolean
        Return oMonedaDAO.Insert(BE)
	End Function
	Public Function Update(ByVal BE As MonedaBE) As Boolean
        Return oMonedaDAO.Update(BE)
	End Function
    Public Function Delete(ByVal oMonedaBE As MonedaBE) As Boolean
        Return oMonedaDAO.Delete(oMonedaBE)
    End Function
	Public Function GetMoneda(ByVal strCodMoneda As String) As MonedaBE
        Return oMonedaDAO.GetMoneda(strCodMoneda)
    End Function
    Public Function GetMonedas(ByVal oMonedaBE As MonedaBE) As List(Of MonedaBE)
        Return oMonedaDAO.GetMonedas(oMonedaBE)
    End Function

End Class