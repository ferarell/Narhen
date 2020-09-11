Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class UsuarioBL
    Dim oUsuarioDAO As New UsuarioDAO

    Public Function Insert(ByVal oUsuarioBE As UsuarioBE) As Boolean
        Return oUsuarioDAO.Insert(oUsuarioBE)
    End Function
    Public Function Update(ByVal oUsuarioBE As UsuarioBE) As Boolean
        Return oUsuarioDAO.Update(oUsuarioBE)
    End Function
    Public Function ActualizarPassword(ByVal oUsuarioBE As UsuarioBE) As Boolean
        Return oUsuarioDAO.ActualizaPassword(oUsuarioBE)
    End Function
    Public Function Delete(ByVal oUsuarioBE As UsuarioBE) As Boolean
        Return oUsuarioDAO.Delete(oUsuarioBE)
    End Function
    Public Function GetUsuario(ByVal strIdUsuario As Int32) As UsuarioBE
        Return oUsuarioDAO.GetUsuario(strIdUsuario)
    End Function
    Public Function GetUsuarios(ByVal oUsuarioBE As UsuarioBE) As List(Of UsuarioBE)
        Return oUsuarioDAO.GetUsuarios(oUsuarioBE)
    End Function

    Public Function ObtenerUsuario(cuenta As String) As UsuarioBE
        Return oUsuarioDAO.ObtenerUsuario(cuenta)
    End Function
End Class
