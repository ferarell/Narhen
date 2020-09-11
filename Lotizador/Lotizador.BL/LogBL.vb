Imports Lotizador.BE
Imports Lotizador.DAO

Public Class LogBL

    Private oLogDA As New LogDA

    Public Function Registrar(oLog As LogBE) As LogBE
        Return oLogDA.Registrar(oLog)
    End Function

End Class
