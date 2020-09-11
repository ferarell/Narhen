Imports Lotizador.BE
Imports Lotizador.DAO

Public Class GeneralBL
    Dim oGeneralDAO As New GeneralDAO

    Public Function CommandText(ByVal oGeneralBE As GeneralBE) As GeneralBE
        Return oGeneralDAO.Execute(oGeneralBE)
    End Function
End Class
