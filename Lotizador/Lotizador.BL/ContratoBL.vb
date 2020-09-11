Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic

Public Class ContratoBL
    Dim oContratoDAO As New ContratoDAO
    Dim oContratoSocioDAO As New ContratoSocioDAO

    Public Function Insert(ByVal oContratoBE As ContratoBE) As Boolean
        Try
            Dim idContrato As Integer = oContratoDAO.Insert(oContratoBE)
            For Each item As ContratoSocioBE In oContratoBE.listContratoSocioBE
                item.IdContrato = idContrato
                oContratoSocioDAO.Insert(item)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
       

    End Function
    Public Function Update(ByVal oContratoBE As ContratoBE) As Boolean
        Try
            oContratoDAO.Update(oContratoBE)
            Dim oContratoSocioBe As ContratoSocioBE = New ContratoSocioBE()
            oContratoSocioBe.IdContrato = oContratoBE.IdContrato
            oContratoSocioDAO.Delete(oContratoSocioBe)
            For Each item As ContratoSocioBE In oContratoBE.listContratoSocioBE
                item.IdContrato = oContratoBE.IdContrato
                oContratoSocioDAO.Insert(item)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Delete(ByVal oContratoBE As ContratoBE) As Boolean
        Try
            If oContratoDAO.Delete(oContratoBE) Then
                Dim oContratoSocioBe As ContratoSocioBE = New ContratoSocioBE()
                oContratoSocioBe.IdContrato = oContratoBE.IdContrato
                oContratoSocioDAO.Delete(oContratoSocioBe)
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function GetContrato(ByVal strIdContrato As Int32) As ContratoBE
        Return oContratoDAO.GetSociosContratosDataTable(oContratoDAO.GetContrato(strIdContrato))
    End Function

    Public Function GetContratos(ByVal oContratoBE As ContratoBE) As List(Of ContratoBE)

        Dim listContratos As List(Of ContratoBE) = New List(Of ContratoBE)(oContratoDAO.GetContratos(oContratoBE))
        Dim listContratosReturn As List(Of ContratoBE) = New List(Of ContratoBE)()

        For Each item As ContratoBE In listContratos
            item = oContratoDAO.GetSociosContratosDataTable(item)
            listContratosReturn.Add(item)
        Next
        Return listContratosReturn
    End Function

End Class
