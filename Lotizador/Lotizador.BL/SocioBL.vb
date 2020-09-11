Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class SocioBL
    Dim oSocioDAO As New SocioDAO

    Public Function Insert(ByVal oSocioBE As SocioBE) As Boolean
        Return oSocioDAO.Insert(oSocioBE)
    End Function
    Public Function Update(ByVal oSocioBE As SocioBE) As Boolean
        Return oSocioDAO.Update(oSocioBE)
    End Function
    Public Function Delete(ByVal oSocioBE As SocioBE) As Boolean
        Return oSocioDAO.Delete(oSocioBE)
    End Function
    Public Function GetSocio(ByVal strCodSocio As Int32) As SocioBE
        Return oSocioDAO.GetSocio(strCodSocio)
    End Function
    Public Function GetSocios(ByVal oSocioBE As SocioBE) As List(Of SocioBE)
        Return oSocioDAO.GetSocios(oSocioBE)
    End Function

    Public Function ListarSocios() As List(Of SocioBE)
        Return oSocioDAO.ListarSocios()
    End Function

    Public Function ListarSociosPorProyecto(idProyecto As Integer) As List(Of SocioBE)
        Return oSocioDAO.ListarSociosPorProyecto(idProyecto)
    End Function

    Public Function ObtenerSocioPorId(id As Integer) As SocioBE
        Return oSocioDAO.ObtenerSocioPorId(id)
    End Function

    Public Function ObtenerSocioPorNroDoc(nroDoc As String) As SocioBE
        Return oSocioDAO.ObtenerSocioPorNroDoc(nroDoc)
    End Function
End Class
