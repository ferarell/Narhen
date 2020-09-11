Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class ListaErrorBL

    Dim ListaErrorDAO As New ListaErrorDAO

    Public Function Insert(ByVal BE As ListaErrorBE) As Boolean
        Return ListaErrorDAO.Insert(BE)
    End Function
    Public Function Update(ByVal BE As ListaErrorBE) As Boolean
        Return ListaErrorDAO.Update(BE)
    End Function

End Class