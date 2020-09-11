Imports Lotizador.BE
Imports Lotizador.DAO

Public Class LetraBL

    Private oLetraDA As New LetraDA

    Public Function ListarLetrasPendientes() As List(Of LetraBE)
        Return oLetraDA.ListarLetrasPendientes()
    End Function

    Public Function ListarLetrasPendientesPorProyecto(idProyecto As Integer) As List(Of LetraBE)
        Return oLetraDA.ListarLetrasPendientesPorProyecto(idProyecto)
    End Function

    Public Function ListarLetrasPendientesPorProyectoSocio(idProyecto As Integer, idSocio As Integer) As List(Of LetraBE)
        Return oLetraDA.ListarLetrasPendientesPorProyectoSocio(idProyecto, idSocio)
    End Function

    Public Function ListarLetrasPendientesPorProyectoSocioLote(idProyecto As Integer, idSocio As Integer, idLote As Integer) As List(Of LetraBE)
        Return oLetraDA.ListarLetrasPendientesPorProyectoSocioLote(idProyecto, idSocio, idLote)
    End Function

    Public Function RegistrarLetraComprobante(idLetra As Integer) As Boolean
        Return oLetraDA.RegistrarLetraComprobante(idLetra)
    End Function

    Public Function ListarLetrasPagadasPorProyectoSocioLote(idProyecto As Integer, idSocio As Integer, idLote As Integer) As List(Of LetraBE)
        Return oLetraDA.ListarLetrasPagadasPorProyectoSocioLote(idProyecto, idSocio, idLote)
    End Function

    Public Function EliminarLetraComprobante(idComprobante As Integer) As Boolean
        Return oLetraDA.EliminarLetraComprobante(idComprobante)
    End Function

End Class
