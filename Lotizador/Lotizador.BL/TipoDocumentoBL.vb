Imports Lotizador.BE
Imports Lotizador.DAO
Imports System.Collections.Generic
Public Class TipoDocumentoBL
    Dim oTipoDocumentoDAO As New TipoDocumentoDAO

    Public Function GetTiposDocumentos(ByVal oTipoDocumentoBE As TipoDocumentoBE) As List(Of TipoDocumentoBE)
        Return oTipoDocumentoDAO.GetTipoDocumentos(oTipoDocumentoBE)
    End Function

End Class
