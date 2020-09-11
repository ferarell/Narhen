Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic
Public Class UbigeoBL
    Dim oUbigeoDAO As New UbigeoDAO

    Public Function GetDepartamentos() As List(Of UbigeoBE)
        Return oUbigeoDAO.GetDepartamentos()
    End Function

    Public Function GetProvincias(ByVal oUbigeoBE As UbigeoBE) As List(Of UbigeoBE)
        Return oUbigeoDAO.GetProvincias(oUbigeoBE)
    End Function

    Public Function GetDistritos(ByVal oUbigeoBE As UbigeoBE) As List(Of UbigeoBE)
        Return oUbigeoDAO.GetDistritos(oUbigeoBE)
    End Function

    Public Function GetUbigeo(ByVal oUbigeoBE As UbigeoBE) As UbigeoBE
        Return oUbigeoDAO.GetUbigeo(oUbigeoBE)
    End Function

    Public Function GetUbigeoPorCriterio(ByVal oUbigeoBE As UbigeoBE) As UbigeoBE
        Return oUbigeoDAO.GetUbigeoCriterio(oUbigeoBE)
    End Function

End Class
