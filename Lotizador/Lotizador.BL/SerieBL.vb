Imports Lotizador.BE
Imports Lotizador.DAO

Public Class SerieBL

    Private oSerieDA As New SerieDA

    Public Function ListarSeries() As List(Of SerieBE)
        Return oSerieDA.ListarSeries()
    End Function

    Public Function Registrar(oSerie As SerieBE) As SerieBE
        Return oSerieDA.Registrar(oSerie)
    End Function

    Public Function Actualizar(oSerie As SerieBE) As SerieBE
        Return oSerieDA.Actualizar(oSerie)
    End Function

    Public Function ListarSeriesPorEmpresa(idEmpresa As Integer) As List(Of SerieBE)
        Return oSerieDA.ListarSeriesPorEmpresa(idEmpresa)
    End Function

    Public Function ListarSeriesPorEmpresaTipo(idEmpresa As Integer, tipoComprobante As String) As List(Of SerieBE)
        Return oSerieDA.ListarSeriesPorEmpresaTipo(idEmpresa, tipoComprobante)
    End Function

    Public Function ListarSeriesPorEmpresaRucTipo(rucEmpresa As String, tipoComprobante As String) As List(Of SerieBE)
        Return oSerieDA.ListarSeriesPorEmpresaRucTipo(rucEmpresa, tipoComprobante)
    End Function

    Public Function ObtenerCorrelativoPorEmpresaSerie(idEmpresa As Integer, serie As String) As String
        Return oSerieDA.ObtenerCorrelativoPorEmpresaSerie(idEmpresa, serie)
    End Function

    Public Function ObtenerCorrelativoPorRucEmpresaSerieTipo(rucEmpresa As String, serie As String, tipoComprobante As String) As String
        Return oSerieDA.ObtenerCorrelativoPorRucEmpresaSerieTipo(rucEmpresa, serie, tipoComprobante)
    End Function

    Public Function ActualizarCorrelativoPorEmpresaSerie(idEmpresa As Integer, tipoComprobante As String, serie As String, correlativo As Integer) As Boolean
        Return oSerieDA.ActualizarCorrelativoPorEmpresaSerie(idEmpresa, tipoComprobante, serie, correlativo)
    End Function

End Class
