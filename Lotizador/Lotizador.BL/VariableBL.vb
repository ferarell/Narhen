Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic
Public Class VariableBL
    Dim oVariableDAO As New VariableDAO

    Public Function GetVariables(ByVal oVariableBE As VariableBE) As List(Of VariableBE)
        Return oVariableDAO.GetVariables(oVariableBE)
    End Function

End Class
