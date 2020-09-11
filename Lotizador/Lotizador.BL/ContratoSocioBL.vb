Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class ContratoSocioBL
    Dim oContratoSocioDAO As New ContratoSocioDAO

    Public Function Insert(ByVal oContratoSocioBE As ContratoSocioBE) As Boolean
        Return oContratoSocioDAO.Insert(oContratoSocioBE)
    End Function
    Public Function Update(ByVal oContratoSocioBE As ContratoSocioBE) As Boolean
        Return oContratoSocioDAO.Update(oContratoSocioBE)
    End Function
    Public Function Delete(ByVal oContratoSocioBE As ContratoSocioBE) As Boolean
        Return oContratoSocioDAO.Delete(oContratoSocioBE)
    End Function
    Public Function GetContratoSocio(ByVal strIdContrato As Int32, ByVal strIdSocio As Int32) As ContratoSocioBE
        Return oContratoSocioDAO.GetContratoSocio(strIdContrato, strIdSocio)
    End Function
    Public Function GetContratoSocios(ByVal oContratoSocioBE As ContratoSocioBE) As List(Of ContratoSocioBE)
        Return oContratoSocioDAO.GetContratoSocios(oContratoSocioBE)
    End Function

End Class
