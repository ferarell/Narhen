Imports System.Data.SqlClient
Imports Lotizador.BE
Imports System.Configuration

Public Class ListaErrorDAO

    Dim cnx As New SqlConnection(ConfigurationManager.AppSettings("dbNarhen"))
    Dim cmd As New SqlCommand

    Public Function Insert(ByVal BE As ListaErrorBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LISTAERROR_INS01"

            With .Parameters
                .Clear()
                .Add("@IDERROR", SqlDbType.int).Value = BE.IdError
                .Add("@NOMBREERROR", SqlDbType.varchar, 50).Value = BE.NombreError
                .Add("@DESCRIPCIONERROR", SqlDbType.varchar, 300).Value = BE.DescripcionError
                .Add("@UBICACION", SqlDbType.varchar, 50).Value = BE.Ubicacion
                .Add("@USUARIO", SqlDbType.varchar, 20).Value = BE.Usuario
                .Add("@NOMBREOBJETO", SqlDbType.varchar, 30).Value = BE.NombreObjeto
                .Add("@FECHAHORA", SqlDbType.datetime).Value = BE.FechaHora
                .Add("@ATENDIDO", SqlDbType.char, 1).Value = BE.Atendido
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.datetime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

    Public Function Update(ByVal BE As ListaErrorBE) As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "LISTAERROR_UPD01"

            With .Parameters
                .Clear()
                .Add("@IDERROR", SqlDbType.Int).Value = BE.IdError
                .Add("@NOMBREERROR", SqlDbType.VarChar, 50).Value = BE.NombreError
                .Add("@DESCRIPCIONERROR", SqlDbType.VarChar, 300).Value = BE.DescripcionError
                .Add("@UBICACION", SqlDbType.VarChar, 50).Value = BE.Ubicacion
                .Add("@USUARIO", SqlDbType.VarChar, 20).Value = BE.Usuario
                .Add("@NOMBREOBJETO", SqlDbType.VarChar, 30).Value = BE.NombreObjeto
                .Add("@FECHAHORA", SqlDbType.DateTime).Value = BE.FechaHora
                .Add("@ATENDIDO", SqlDbType.Char, 1).Value = BE.Atendido
                .Add("@USUARIOCREACION", SqlDbType.SmallInt).Value = BE.UsuarioCreacion
                .Add("@FECHACREACION", SqlDbType.DateTime).Value = BE.FechaCreacion
                .Add("@USUARIOMODIFICACION", SqlDbType.SmallInt).Value = BE.UsuarioModificacion
                .Add("@FECHAMODIFICACION", SqlDbType.DateTime).Value = BE.FechaModificacion
            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
    End Function

End Class
