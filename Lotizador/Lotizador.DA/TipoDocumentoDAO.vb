Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration
Imports System.Collections.Generic
Public Class TipoDocumentoDAO

    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function GetTipoDocumentos(ByVal oTipoDocumentoBECrit As TipoDocumentoBE) As List(Of TipoDocumentoBE)

        Dim dr As SqlDataReader

        Dim listTipoDocumento As List(Of TipoDocumentoBE) = New List(Of TipoDocumentoBE)()
        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = cnx
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "TIPODOCUMENTO_GET02"

        cmd.Parameters.Clear()
        cmd.Parameters.Add("@Valorado", SqlDbType.VarChar, 1).Value = oTipoDocumentoBECrit.Valorado


        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    Dim oTipoDocumentoBE As New TipoDocumentoBE

                    If dr("IdTipoDocumento") Is DBNull.Value Then
                        oTipoDocumentoBE.IdTipoDocumento = Nothing
                    Else
                        oTipoDocumentoBE.IdTipoDocumento = dr("IdTipoDocumento")
                    End If

                    If dr("CodigoTipoDocumento") Is DBNull.Value Then
                        oTipoDocumentoBE.CodigoTipoDocumento = Nothing
                    Else
                        oTipoDocumentoBE.CodigoTipoDocumento = dr("CodigoTipoDocumento")
                    End If

                    If dr("Descripcion") Is DBNull.Value Then
                        oTipoDocumentoBE.Descripcion = Nothing
                    Else
                        oTipoDocumentoBE.Descripcion = dr("Descripcion")
                    End If

                    If dr("Valorado") Is DBNull.Value Then
                        oTipoDocumentoBE.Valorado = Nothing
                    Else
                        oTipoDocumentoBE.Valorado = dr("Valorado")
                    End If



                    

                    If dr("UsuarioCreacion") Is DBNull.Value Then
                        oTipoDocumentoBE.UsuarioCreacion = Nothing
                    Else
                        oTipoDocumentoBE.UsuarioCreacion = dr("UsuarioCreacion")
                    End If

                    If dr("FechaCreacion") Is DBNull.Value Then
                        oTipoDocumentoBE.FechaCreacion = Nothing
                    Else
                        oTipoDocumentoBE.FechaCreacion = dr("FechaCreacion")
                    End If

                    If dr("UsuarioModificacion") Is DBNull.Value Then
                        oTipoDocumentoBE.UsuarioModificacion = Nothing
                    Else
                        oTipoDocumentoBE.UsuarioModificacion = dr("UsuarioModificacion")
                    End If

                    If dr("FechaModificacion") Is DBNull.Value Then
                        oTipoDocumentoBE.FechaModificacion = Nothing
                    Else
                        oTipoDocumentoBE.FechaModificacion = dr("FechaModificacion")
                    End If



                    

                    listTipoDocumento.Add(oTipoDocumentoBE)


                End While
                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return listTipoDocumento
    End Function
End Class
