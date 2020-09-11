Imports System.Runtime.Serialization

<DataContract()>
Public Class BancoBE

    Private _IdBanco As Int16
    <DataMember()>
    Public Property IdBanco() As Int16
        Get
            Return _IdBanco
        End Get

        Set(ByVal value As Int16)
            _IdBanco = value
        End Set
    End Property

    Private _CodigoBanco As String
    <DataMember()>
    Public Property CodigoBanco() As String
        Get
            Return _CodigoBanco
        End Get

        Set(ByVal value As String)
            _CodigoBanco = value
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

    Private _UsuarioCreacion As Int16
    <DataMember()>
    Public Property UsuarioCreacion() As Int16
        Get
            Return _UsuarioCreacion
        End Get

        Set(ByVal value As Int16)
            _UsuarioCreacion = value
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

    Private _UsuarioModificacion As Int16
    <DataMember()>
    Public Property UsuarioModificacion() As Int16
        Get
            Return _UsuarioModificacion
        End Get

        Set(ByVal value As Int16)
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

End Class
