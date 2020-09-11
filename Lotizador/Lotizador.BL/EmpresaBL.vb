Imports Lotizador.BE
Imports Lotizador.DAO

Public Class EmpresaBL

    Private oEmpresaDA As New EmpresaDA

    Public Function ListarEmpresas() As List(Of EmpresaBE)
        Return oEmpresaDA.ListarEmpresas()
    End Function

    Public Function Registrar(oEmpresa As EmpresaBE) As EmpresaBE
        Return oEmpresaDA.Registrar(oEmpresa)
    End Function

    Public Function ObtenerEmpresaPorId(id As Integer) As EmpresaBE
        Return oEmpresaDA.ObtenerEmpresaPorId(id)
    End Function

    Public Function ObtenerEmpresaPorRuc(ruc As String) As EmpresaBE
        Return oEmpresaDA.ObtenerEmpresaPorRuc(ruc)
    End Function

    Public Function Actualizar(oEmpresa As EmpresaBE) As EmpresaBE
        Return oEmpresaDA.Actualizar(oEmpresa)
    End Function

End Class
