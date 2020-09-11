' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
'Imports System.Data.SqlClient
Imports System.Data.SqlClient
Imports Lotizador.BE
Imports Lotizador.BL

Public Class NarhenService
    Implements INarhen

    Public Sub New()
    End Sub

    Public Function GetData(ByVal value As Integer) As String Implements INarhen.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements INarhen.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function InsertarSocio(ByVal oSocioBE As SocioBE) As Boolean Implements INarhen.InsertarSocio
        Try
            Dim oSocioBL As SocioBL = New SocioBL()
            oSocioBL.Insert(oSocioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarSocio(ByVal oSocioBE As BE.SocioBE) As Boolean Implements INarhen.ActualizarSocio
        Try
            Dim oSocioBL As SocioBL = New SocioBL()
            oSocioBL.Update(oSocioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerSocioPorCriterio(ByVal oSocioBE As BE.SocioBE) As List(Of SocioBE) Implements INarhen.ObtenerSocioPorCriterio
        Try
            Dim oSocioBL As SocioBL = New SocioBL()
            Dim listSocios As List(Of SocioBE) = New List(Of SocioBE)(oSocioBL.GetSocios(oSocioBE))
            Return listSocios
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ObtenerTipoDocumentoPorCriterio(ByVal oTipoDocumentoBE As BE.TipoDocumentoBE) As System.Collections.Generic.List(Of BE.TipoDocumentoBE) Implements INarhen.ObtenerTipoDocumentoPorCriterio
        Try
            Dim oTipoDocumentoBL As TipoDocumentoBL = New TipoDocumentoBL()
            Dim listTiposDocumento As List(Of TipoDocumentoBE) = New List(Of TipoDocumentoBE)(oTipoDocumentoBL.GetTiposDocumentos(oTipoDocumentoBE))
            Return listTiposDocumento
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ObtenerVariablePorCriterio(ByVal oVariableBE As BE.VariableBE) As System.Collections.Generic.List(Of BE.VariableBE) Implements INarhen.ObtenerVariablePorCriterio
        Try
            Dim oVariableBL As VariableBL = New VariableBL()
            Dim listVariables As List(Of VariableBE) = New List(Of VariableBE)(oVariableBL.GetVariables(oVariableBE))
            Return listVariables
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function GetDepartamentos() As System.Collections.Generic.List(Of BE.UbigeoBE) Implements INarhen.GetDepartamentos
        Try
            Dim oUbigeoBL As UbigeoBL = New UbigeoBL()
            Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)(oUbigeoBL.GetDepartamentos())
            Return listUbigeo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetProvincias(ByVal oUbigeoBE As BE.UbigeoBE) As System.Collections.Generic.List(Of BE.UbigeoBE) Implements INarhen.GetProvincias
        Try
            Dim oUbigeoBL As UbigeoBL = New UbigeoBL()
            Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)(oUbigeoBL.GetProvincias(oUbigeoBE))
            Return listUbigeo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetDistritos(ByVal oUbigeoBE As BE.UbigeoBE) As System.Collections.Generic.List(Of BE.UbigeoBE) Implements INarhen.GetDistritos
        Try
            Dim oUbigeoBL As UbigeoBL = New UbigeoBL()
            Dim listUbigeo As List(Of UbigeoBE) = New List(Of UbigeoBE)(oUbigeoBL.GetDistritos(oUbigeoBE))
            Return listUbigeo
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetUbigeo(ByVal oUbigeoBE As BE.UbigeoBE) As BE.UbigeoBE Implements INarhen.GetUbigeo
        Try
            Dim oUbigeoBER As UbigeoBE = New UbigeoBE()
            Dim oUbigeoBL As UbigeoBL = New UbigeoBL()
            Return oUbigeoBER
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetUbigeoPorCriterio(ByVal oUbigeoBE As BE.UbigeoBE) As BE.UbigeoBE Implements INarhen.GetUbigeoPorCriterio
        Try
            Dim oUbigeoBER As UbigeoBE = New UbigeoBE()
            Dim oUbigeoBL As UbigeoBL = New UbigeoBL()
            Return oUbigeoBER
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function EliminarSocio(ByVal oSocioBE As BE.SocioBE) As Boolean Implements INarhen.EliminarSocio
        Try
            Dim oSocioBL As SocioBL = New SocioBL()
            oSocioBL.Delete(oSocioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function InsertarMoneda(ByVal oMonedaBE As MonedaBE) As Boolean Implements INarhen.InsertarMoneda
        Try
            Dim oMonedaBL As MonedaBL = New MonedaBL()
            oMonedaBL.Insert(oMonedaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarMoneda(ByVal oMonedaBE As BE.MonedaBE) As Boolean Implements INarhen.ActualizarMoneda
        Try
            Dim oMonedaBL As MonedaBL = New MonedaBL()
            oMonedaBL.Update(oMonedaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarMoneda(ByVal oMonedaBE As BE.MonedaBE) As Boolean Implements INarhen.EliminarMoneda
        Try
            Dim oMonedaBL As MonedaBL = New MonedaBL()
            oMonedaBL.Delete(oMonedaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerMonedaPorCriterio(ByVal oMonedaBE As BE.MonedaBE) As System.Collections.Generic.List(Of MonedaBE) Implements INarhen.ObtenerMonedaPorCriterio
        Try
            Dim oMonedaBL As MonedaBL = New MonedaBL()
            Dim listMonedas As List(Of MonedaBE) = New List(Of MonedaBE)(oMonedaBL.GetMonedas(oMonedaBE))
            Return listMonedas
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarProyecto(ByVal oProyectoBE As ProyectoBE) As Boolean Implements INarhen.InsertarProyecto
        Try
            Dim oProyectoBL As ProyectoBL = New ProyectoBL()
            oProyectoBL.Insert(oProyectoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarProyecto(ByVal oProyectoBE As BE.ProyectoBE) As Boolean Implements INarhen.ActualizarProyecto
        Try
            Dim oProyectoBL As ProyectoBL = New ProyectoBL()
            oProyectoBL.Update(oProyectoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarProyecto(ByVal oProyectoBE As BE.ProyectoBE) As Boolean Implements INarhen.EliminarProyecto
        Try
            Dim oProyectoBL As ProyectoBL = New ProyectoBL()
            oProyectoBL.Delete(oProyectoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerProyectoPorCriterio(ByVal oProyectoBE As BE.ProyectoBE) As System.Collections.Generic.List(Of ProyectoBE) Implements INarhen.ObtenerProyectoPorCriterio
        Try
            Dim oProyectoBL As ProyectoBL = New ProyectoBL()
            Dim listProyectos As List(Of ProyectoBE) = New List(Of ProyectoBE)(oProyectoBL.GetProyectos(oProyectoBE))
            Return listProyectos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarUnidadCatastral(ByVal oUnidadCatastralBE As UnidadCatastralBE) As Boolean Implements INarhen.InsertarUnidadCatastral
        Try
            Dim oUnidadCatastralBL As UnidadCatastralBL = New UnidadCatastralBL()
            oUnidadCatastralBL.Insert(oUnidadCatastralBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarUnidadCatastral(ByVal oUnidadCatastralBE As BE.UnidadCatastralBE) As Boolean Implements INarhen.ActualizarUnidadCatastral
        Try
            Dim oUnidadCatastralBL As UnidadCatastralBL = New UnidadCatastralBL()
            oUnidadCatastralBL.Update(oUnidadCatastralBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarUnidadCatastral(ByVal oUnidadCatastralBE As BE.UnidadCatastralBE) As Boolean Implements INarhen.EliminarUnidadCatastral
        Try
            Dim oUnidadCatastralBL As UnidadCatastralBL = New UnidadCatastralBL()
            oUnidadCatastralBL.Delete(oUnidadCatastralBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerUnidadCatastralPorCriterio(ByVal oUnidadCatastralBE As BE.UnidadCatastralBE) As System.Collections.Generic.List(Of UnidadCatastralBE) Implements INarhen.ObtenerUnidadCatastralPorCriterio
        Try
            Dim oUnidadCatastralBL As UnidadCatastralBL = New UnidadCatastralBL()
            Dim listUnidadCatastral As List(Of UnidadCatastralBE) = New List(Of UnidadCatastralBE)(oUnidadCatastralBL.GetUnidadesCatastrales(oUnidadCatastralBE))
            Return listUnidadCatastral
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarLote(ByVal oLoteBE As LoteBE) As Boolean Implements INarhen.InsertarLote
        Try
            Dim oLoteBL As LoteBL = New LoteBL()
            oLoteBL.Insert(oLoteBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarLote(ByVal oLoteBE As BE.LoteBE) As Boolean Implements INarhen.ActualizarLote
        Try
            Dim oLoteBL As LoteBL = New LoteBL()
            oLoteBL.Update(oLoteBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarLote(ByVal oLoteBE As BE.LoteBE) As Boolean Implements INarhen.EliminarLote
        Try
            Dim oLoteBL As LoteBL = New LoteBL()
            oLoteBL.Delete(oLoteBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerLotePorCriterio(ByVal oLoteBE As BE.LoteBE) As System.Collections.Generic.List(Of LoteBE) Implements INarhen.ObtenerLotePorCriterio
        Try
            Dim oLoteBL As LoteBL = New LoteBL()
            Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)(oLoteBL.GetLotes(oLoteBE))
            Return listLotes
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ObtenerLotesDisponibles(ByVal IdProyecto As String, ByVal IdLote As String) As System.Collections.Generic.List(Of LoteBE) Implements INarhen.ObtenerLotesDisponibles
        Try
            Dim oLoteBL As LoteBL = New LoteBL()
            Dim listLotes As List(Of LoteBE) = New List(Of LoteBE)(oLoteBL.GetLotesDisponibles(IdProyecto, IdLote))
            Return listLotes
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarSecuencia(ByVal oSecuenciaBE As SecuenciaBE) As Boolean Implements INarhen.InsertarSecuencia
        Try
            Dim oSecuenciaBL As SecuenciaBL = New SecuenciaBL()
            oSecuenciaBL.Insert(oSecuenciaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarSecuencia(ByVal oSecuenciaBE As BE.SecuenciaBE) As Boolean Implements INarhen.ActualizarSecuencia
        Try
            Dim oSecuenciaBL As SecuenciaBL = New SecuenciaBL()
            oSecuenciaBL.Update(oSecuenciaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarSecuencia(ByVal oSecuenciaBE As BE.SecuenciaBE) As Boolean Implements INarhen.EliminarSecuencia
        Try
            Dim oSecuenciaBL As SecuenciaBL = New SecuenciaBL()
            oSecuenciaBL.Delete(oSecuenciaBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerSecuenciaPorCriterio(ByVal oSecuenciaBE As BE.SecuenciaBE) As System.Collections.Generic.List(Of SecuenciaBE) Implements INarhen.ObtenerSecuenciaPorCriterio
        Try
            Dim oSecuenciaBL As SecuenciaBL = New SecuenciaBL()
            Dim listSecuencias As List(Of SecuenciaBE) = New List(Of SecuenciaBE)(oSecuenciaBL.GetSecuencias(oSecuenciaBE))
            Return listSecuencias
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ActualizarUsuario(ByVal oUsuarioBE As BE.UsuarioBE) As Boolean Implements INarhen.ActualizarUsuario
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            oUsuarioBL.Update(oUsuarioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function




    Public Function EliminarUsuario(ByVal oUsuarioBE As BE.UsuarioBE) As Boolean Implements INarhen.EliminarUsuario
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            oUsuarioBL.Delete(oUsuarioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function InsertarUsuario(ByVal oUsuarioBE As BE.UsuarioBE) As Boolean Implements INarhen.InsertarUsuario
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            oUsuarioBL.Insert(oUsuarioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerUsuarioPorCriterio(ByVal oUsuarioBE As BE.UsuarioBE) As System.Collections.Generic.List(Of BE.UsuarioBE) Implements INarhen.ObtenerUsuarioPorCriterio
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            Dim listUsuarios As List(Of UsuarioBE) = New List(Of UsuarioBE)(oUsuarioBL.GetUsuarios(oUsuarioBE))
            Return listUsuarios
        Catch ex As Exception
            Return Nothing
        End Try
    End Function





    Public Function ObtenerUsuarioPorId(ByVal IdUsuario As Int32) As UsuarioBE Implements INarhen.ObtenerUsuarioPorId
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            Dim oUsuarioBE As UsuarioBE = oUsuarioBL.GetUsuario(IdUsuario)
            Return oUsuarioBE
        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Public Function InsertarBanco(ByVal oBancoBE As BancoBE) As Boolean Implements INarhen.InsertarBanco
        Try
            Dim oBancoBL As BancoBL = New BancoBL()
            oBancoBL.Insert(oBancoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarBanco(ByVal oBancoBE As BE.BancoBE) As Boolean Implements INarhen.ActualizarBanco
        Try
            Dim oBancoBL As BancoBL = New BancoBL()
            oBancoBL.Update(oBancoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarBanco(ByVal oBancoBE As BE.BancoBE) As Boolean Implements INarhen.EliminarBanco
        Try
            Dim oBancoBL As BancoBL = New BancoBL()
            oBancoBL.Delete(oBancoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerBancoPorCriterio(ByVal oBancoBE As BE.BancoBE) As System.Collections.Generic.List(Of BancoBE) Implements INarhen.ObtenerBancoPorCriterio
        Try
            Dim oBancoBL As BancoBL = New BancoBL()
            Dim listBancos As List(Of BancoBE) = New List(Of BancoBE)(oBancoBL.GetBancos(oBancoBE))
            Return listBancos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ActualizarContrato(ByVal oContratoBE As BE.ContratoBE) As Boolean Implements INarhen.ActualizarContrato
        Try
            Dim oContratoBL As ContratoBL = New ContratoBL()
            oContratoBL.Update(oContratoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarContrato(ByVal oContratoBE As BE.ContratoBE) As Boolean Implements INarhen.EliminarContrato
        Try
            Dim oContratoBL As ContratoBL = New ContratoBL()
            oContratoBL.Delete(oContratoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function InsertarContrato(ByVal oContratoBE As BE.ContratoBE) As Boolean Implements INarhen.InsertarContrato
        Try
            Dim oContratoBL As ContratoBL = New ContratoBL()
            oContratoBL.Insert(oContratoBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerContratoPorCriterio(ByVal oContratoBE As BE.ContratoBE) As System.Collections.Generic.List(Of BE.ContratoBE) Implements INarhen.ObtenerContratoPorCriterio
        Try
            Dim oContratoBL As ContratoBL = New ContratoBL()
            Dim listContratos As List(Of ContratoBE) = New List(Of ContratoBE)(oContratoBL.GetContratos(oContratoBE))
            Return listContratos
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function ObtenerContrato(ByVal oContratoBE As BE.ContratoBE) As ContratoBE Implements INarhen.ObtenerContrato
        Try
            Dim oContratoBL As ContratoBL = New ContratoBL()
            Return oContratoBL.GetContrato(oContratoBE.IdContrato)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Public Function ActualizarPassword(ByVal oUsuarioBE As BE.UsuarioBE) As Boolean Implements INarhen.ActualizarPassword
        Try
            Dim oUsuarioBL As UsuarioBL = New UsuarioBL()
            oUsuarioBL.ActualizarPassword(oUsuarioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CommandText(ByVal oGeneralBE As GeneralBE) As GeneralBE Implements INarhen.CommandText
        Try
            Dim oGeneralBL As GeneralBL = New GeneralBL()
            Return oGeneralBL.CommandText(oGeneralBE)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ExecuteSQL(ByVal QueryString As String) As DataSet Implements INarhen.ExecuteSQL
        Dim dsResult As New DataSet
        Try
            Using connection As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
                Dim Command As New SqlCommand(QueryString, connection)
                Dim Adapter As New SqlDataAdapter
                Try
                    Command.CommandText = QueryString
                    Command.CommandTimeout = 60000
                    Adapter.SelectCommand = Command
                    Command.Connection.Open()
                    Adapter.Fill(dsResult)
                Catch ex As Exception
                    Return Nothing
                Finally
                    Command.Connection.Close()
                End Try
                Return dsResult
            End Using
            'Return oDataAccess.ExecuteSQL(QueryString)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarListaError(ByVal oListaErrorBE As ListaErrorBE) As Boolean Implements INarhen.InsertarListaError
        Try
            Dim oListaErrorBL As ListaErrorBL = New ListaErrorBL()
            oListaErrorBL.Insert(oListaErrorBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarListaError(ByVal oListaErrorBE As BE.ListaErrorBE) As Boolean Implements INarhen.ActualizarListaError
        Try
            Dim oListaErrorBL As ListaErrorBL = New ListaErrorBL()
            oListaErrorBL.Update(oListaErrorBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function InsertarMonedaTipoCambio(ByVal oMonedaTipoCambioBE As MonedaTipoCambioBE) As Boolean Implements INarhen.InsertarMonedaTipoCambio
        Try
            Dim oMonedaTipoCambioBL As MonedaTipoCambioBL = New MonedaTipoCambioBL()
            oMonedaTipoCambioBL.Insert(oMonedaTipoCambioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ActualizarMonedaTipoCambio(ByVal oMonedaTipoCambioBE As BE.MonedaTipoCambioBE) As Boolean Implements INarhen.ActualizarMonedaTipoCambio
        Try
            Dim oMonedaTipoCambioBL As MonedaTipoCambioBL = New MonedaTipoCambioBL()
            oMonedaTipoCambioBL.Update(oMonedaTipoCambioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function EliminarMonedaTipoCambio(ByVal oMonedaTipoCambioBE As BE.MonedaTipoCambioBE) As Boolean Implements INarhen.EliminarMonedaTipoCambio
        Try
            Dim oMonedaTipoCambioBL As MonedaTipoCambioBL = New MonedaTipoCambioBL()
            oMonedaTipoCambioBL.Delete(oMonedaTipoCambioBE)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ObtenerMonedaTipoCambio(ByVal oMonedaTipoCambioBE As BE.MonedaTipoCambioBE) As System.Collections.Generic.List(Of MonedaTipoCambioBE) Implements INarhen.ObtenerMonedaTipoCambio
        Try
            Dim oMonedaTipoCambioBL As MonedaTipoCambioBL = New MonedaTipoCambioBL()
            Dim listMonedaTiposCambio As List(Of MonedaTipoCambioBE) = New List(Of MonedaTipoCambioBE)(oMonedaTipoCambioBL.GetMonedasTipoCambio(oMonedaTipoCambioBE))
            Return listMonedaTiposCambio
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
