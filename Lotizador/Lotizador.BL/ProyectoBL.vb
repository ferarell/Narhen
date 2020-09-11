Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class ProyectoBL
    Dim oProyectoDAO As New ProyectoDAO

    Public Function Insert(ByVal BE As ProyectoBE) As Boolean
        Return oProyectoDAO.Insert(BE)
    End Function
    Public Function Update(ByVal BE As ProyectoBE) As Boolean
        Return oProyectoDAO.Update(BE)
    End Function
    Public Function Delete(ByVal oProyectoBE As ProyectoBE) As Boolean
        Return oProyectoDAO.Delete(oProyectoBE)
    End Function
    Public Function GetProyecto(ByVal strCodProyecto As String) As ProyectoBE
        Return oProyectoDAO.GetProyecto(strCodProyecto)
    End Function
    Public Function GetProyectos(ByVal oProyectoBE As ProyectoBE) As List(Of ProyectoBE)
        Return oProyectoDAO.GetProyectos(oProyectoBE)
    End Function
    Public Function ListarProyectos() As List(Of ProyectoBE)
        Return oProyectoDAO.ListarProyectos()
    End Function
End Class
