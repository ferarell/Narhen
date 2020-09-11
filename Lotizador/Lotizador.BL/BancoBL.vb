Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class BancoBL
    Dim oBancoDAO As New BancoDAO

    Public Function Insert(ByVal BE As BancoBE) As Boolean
        Return oBancoDAO.Insert(BE)
    End Function
    Public Function Update(ByVal BE As BancoBE) As Boolean
        Return oBancoDAO.Update(BE)
    End Function
    Public Function Delete(ByVal oBancoBE As BancoBE) As Boolean
        Return oBancoDAO.Delete(oBancoBE)
    End Function
    Public Function GetBanco(ByVal strCodBanco As String) As BancoBE
        Return oBancoDAO.GetBanco(strCodBanco)
    End Function
    Public Function GetBancos(ByVal oBancoBE As BancoBE) As List(Of BancoBE)
        Return oBancoDAO.GetBancos(oBancoBE)
    End Function

End Class