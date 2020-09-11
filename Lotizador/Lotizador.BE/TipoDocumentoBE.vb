Imports System.Runtime.Serialization

<DataContract()>
Public Class TipoDocumentoBE
    Private _IdTipoDocumento As Int32
    <DataMember()>
    Public Property IdTipoDocumento() As Int32
        Get
            Return _IdTipoDocumento
        End Get

        Set(ByVal value As Int32)
            _IdTipoDocumento = value
        End Set
    End Property



    Private _CodigoTipoDocumento As String
    <DataMember()>
    Public Property CodigoTipoDocumento() As String
        Get
            Return _CodigoTipoDocumento
        End Get

        Set(ByVal value As String)
            _CodigoTipoDocumento = value
        End Set
    End Property



    Private _Descripcion As String
    <DataMember()>
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get

        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property


    Private _Valorado As String
    <DataMember()>
    Public Property Valorado() As String
        Get
            Return _Valorado
        End Get

        Set(ByVal value As String)
            _Valorado = value
        End Set
    End Property



    Private _UsuarioCreacion As Int32
    <DataMember()>
    Public Property UsuarioCreacion() As Int32
        Get
            Return _UsuarioCreacion
        End Get

        Set(ByVal value As Int32)
            _UsuarioCreacion = value
        End Set
    End Property

    Private _UsuarioModificacion As Int32
    <DataMember()>
    Public Property UsuarioModificacion() As Int32
        Get
            Return _UsuarioModificacion
        End Get

        Set(ByVal value As Int32)
            _UsuarioModificacion = value
        End Set
    End Property




    Private _FechaModificacion As DateTime
    <DataMember()>
    Public Property FechaModificacion() As DateTime
        Get
            Return _FechaModificacion
        End Get

        Set(ByVal value As DateTime)
            _FechaModificacion = value
        End Set
    End Property



    Private _FechaCreacion As DateTime
    <DataMember()>
    Public Property FechaCreacion() As DateTime
        Get
            Return _FechaCreacion
        End Get

        Set(ByVal value As DateTime)
            _FechaCreacion = value
        End Set
    End Property

End Class
