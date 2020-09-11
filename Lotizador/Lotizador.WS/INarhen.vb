' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
Imports Lotizador.BE
Imports Lotizador.BL

<ServiceContract()>
Public Interface INarhen

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    'Socios
    <OperationContract()>
    Function InsertarSocio(ByVal oSocioBE As SocioBE) As Boolean
    <OperationContract()>
    Function ActualizarSocio(ByVal oSocioBE As SocioBE) As Boolean
    <OperationContract()>
    Function EliminarSocio(ByVal oSocioBE As SocioBE) As Boolean
    <OperationContract()>
    Function ObtenerSocioPorCriterio(ByVal oSocioBE As SocioBE) As List(Of SocioBE)

    'Tipos de Documento
    <OperationContract()>
    Function ObtenerTipoDocumentoPorCriterio(ByVal oSocioBE As TipoDocumentoBE) As List(Of TipoDocumentoBE)

    'Variables
    <OperationContract()>
    Function ObtenerVariablePorCriterio(ByVal oVariableBE As VariableBE) As List(Of VariableBE)

    'Ubigeo
    <OperationContract()>
    Function GetDepartamentos() As List(Of UbigeoBE)
    <OperationContract()>
    Function GetProvincias(ByVal oUbigeoBE As UbigeoBE) As List(Of UbigeoBE)
    <OperationContract()>
    Function GetDistritos(ByVal oUbigeoBE As UbigeoBE) As List(Of UbigeoBE)
    <OperationContract()>
    Function GetUbigeo(ByVal oUbigeoBE As UbigeoBE) As UbigeoBE
    <OperationContract()>
    Function GetUbigeoPorCriterio(ByVal oUbigeoBE As UbigeoBE) As UbigeoBE

    'Monedas
    <OperationContract()>
    Function InsertarMoneda(ByVal oMonedaBE As MonedaBE) As Boolean
    <OperationContract()>
    Function ActualizarMoneda(ByVal oMonedaBE As MonedaBE) As Boolean
    <OperationContract()>
    Function EliminarMoneda(ByVal oMonedaBE As MonedaBE) As Boolean
    <OperationContract()>
    Function ObtenerMonedaPorCriterio(ByVal oMonedaBE As MonedaBE) As List(Of MonedaBE)

    'Proyectos
    <OperationContract()>
    Function InsertarProyecto(ByVal oProyectoBE As ProyectoBE) As Boolean
    <OperationContract()>
    Function ActualizarProyecto(ByVal oProyectoBE As ProyectoBE) As Boolean
    <OperationContract()>
    Function EliminarProyecto(ByVal oProyectoBE As ProyectoBE) As Boolean
    <OperationContract()>
    Function ObtenerProyectoPorCriterio(ByVal oProyectoBE As ProyectoBE) As List(Of ProyectoBE)

    'Unidades Catastrales
    <OperationContract()>
    Function InsertarUnidadCatastral(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
    <OperationContract()>
    Function ActualizarUnidadCatastral(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
    <OperationContract()>
    Function EliminarUnidadCatastral(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean
    <OperationContract()>
    Function ObtenerUnidadCatastralPorCriterio(ByVal oUnidadCatastralBE As UnidadCatastralBE) As List(Of UnidadCatastralBE)

    'Lotes
    <OperationContract()>
    Function InsertarLote(ByVal oLoteBE As LoteBE) As Boolean
    <OperationContract()>
    Function ActualizarLote(ByVal oLoteBE As LoteBE) As Boolean
    <OperationContract()>
    Function EliminarLote(ByVal oLoteBE As LoteBE) As Boolean
    <OperationContract()>
    Function ObtenerLotePorCriterio(ByVal oLoteBE As LoteBE) As List(Of LoteBE)
    <OperationContract()>
    Function ObtenerLotesDisponibles(ByVal IdProyecto As String, ByVal IdLote As String) As List(Of LoteBE)

    'Secuencias
    <OperationContract()>
    Function InsertarSecuencia(ByVal oSecuenciaBE As SecuenciaBE) As Boolean
    <OperationContract()>
    Function ActualizarSecuencia(ByVal oSecuenciaBE As SecuenciaBE) As Boolean
    <OperationContract()>
    Function EliminarSecuencia(ByVal oSecuenciaBE As SecuenciaBE) As Boolean
    <OperationContract()>
    Function ObtenerSecuenciaPorCriterio(ByVal oSecuenciaBE As SecuenciaBE) As List(Of SecuenciaBE)

    'Usuarios
    <OperationContract()>
    Function InsertarUsuario(ByVal oUsuarioBE As UsuarioBE) As Boolean
    <OperationContract()>
    Function ActualizarUsuario(ByVal oUsuarioBE As UsuarioBE) As Boolean
    <OperationContract()>
    Function ActualizarPassword(ByVal oUsuarioBE As UsuarioBE) As Boolean

    <OperationContract()>
    Function EliminarUsuario(ByVal oUsuarioBE As UsuarioBE) As Boolean
    <OperationContract()>
    Function ObtenerUsuarioPorCriterio(ByVal oUsuarioBE As UsuarioBE) As List(Of UsuarioBE)


    <OperationContract()>
    Function ObtenerUsuarioPorId(ByVal IdUsuario As Int32) As UsuarioBE

    'Bancos
    <OperationContract()>
    Function InsertarBanco(ByVal oBancoBE As BancoBE) As Boolean
    <OperationContract()>
    Function ActualizarBanco(ByVal oBancoBE As BancoBE) As Boolean
    <OperationContract()>
    Function EliminarBanco(ByVal oBancoBE As BancoBE) As Boolean
    <OperationContract()>
    Function ObtenerBancoPorCriterio(ByVal oBancoBE As BancoBE) As List(Of BancoBE)

    'Contrato
    <OperationContract()>
    Function InsertarContrato(ByVal oContratoBE As ContratoBE) As Boolean
    <OperationContract()>
    Function ActualizarContrato(ByVal oContratoBE As ContratoBE) As Boolean
    <OperationContract()>
    Function EliminarContrato(ByVal oContratoBE As ContratoBE) As Boolean
    <OperationContract()>
    Function ObtenerContratoPorCriterio(ByVal oContratoBE As ContratoBE) As List(Of ContratoBE)
    <OperationContract()>
    Function ObtenerContrato(ByVal oContratoBE As ContratoBE) As ContratoBE

    'MonedaTipoCambio
    <OperationContract()>
    Function InsertarMonedaTipoCambio(ByVal oMonedaTipoCambio As MonedaTipoCambioBE) As Boolean
    <OperationContract()>
    Function ActualizarMonedaTipoCambio(ByVal oMonedaTipoCambio As MonedaTipoCambioBE) As Boolean
    <OperationContract()>
    Function EliminarMonedaTipoCambio(ByVal oMonedaTipoCambio As MonedaTipoCambioBE) As Boolean
    <OperationContract()>
    Function ObtenerMonedaTipoCambio(ByVal oMonedaTipoCambio As MonedaTipoCambioBE) As List(Of MonedaTipoCambioBE)

    'General
    <OperationContract()>
    Function CommandText(ByVal oGeneralBE As GeneralBE) As GeneralBE
    <OperationContract()>
    Function ExecuteSQL(ByVal QueryString As String) As DataSet

    'ListaError
    <OperationContract()>
    Function InsertarListaError(ByVal oListaErrorBE As ListaErrorBE) As Boolean
    <OperationContract()>
    Function ActualizarListaError(ByVal oListaErrorBE As BE.ListaErrorBE) As Boolean

    ' TODO: Add your service operations here

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
