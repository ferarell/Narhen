Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class SecuenciaBL

    Dim oSecuenciaDAO As New SecuenciaDAO

	Public Function Insert(ByVal BE As SecuenciaBE) As Boolean
        Return oSecuenciaDAO.Insert(BE)
	End Function
	Public Function Update(ByVal BE As SecuenciaBE) As Boolean
        Return oSecuenciaDAO.Update(BE)
	End Function
    Public Function Delete(ByVal oSecuenciaBE As SecuenciaBE) As Boolean
        Return oSecuenciaDAO.Delete(oSecuenciaBE)
    End Function
	Public Function GetSecuencia(ByVal strCodSecuencia As String) As SecuenciaBE
        Return oSecuenciaDAO.GetSecuencia(strCodSecuencia)
	End Function
    Public Function GetSecuencias(ByVal oSecuenciaBE As SecuenciaBE) As List(Of SecuenciaBE)
        Return oSecuenciaDAO.GetSecuencias(oSecuenciaBE)
    End Function
End Class
