Imports Lotizador.UI.LotizadorService

Public Class frmVisorComprobanteElectronico
    Dim oNarhemService As NarhenClient = New NarhenClient()

    Private _IdLetra As String

    Public Property IdLetra() As String
        Get
            Return _IdLetra
        End Get
        Set(ByVal value As String)
            _IdLetra = value
        End Set
    End Property



End Class