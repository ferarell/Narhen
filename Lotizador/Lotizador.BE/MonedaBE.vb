Imports System.Runtime.Serialization

<DataContract()>
Public Class MonedaBE

    Private _IdMoneda As Int16
    <DataMember()>
    Public Property IdMoneda() As Int16
        Get
            Return _IdMoneda
        End Get

        Set(ByVal value As Int16)
            _IdMoneda = value
        End Set
    End Property

    Private _CodigoMoneda As String
    <DataMember()>
    Public Property CodigoMoneda() As String
        Get
            Return _CodigoMoneda
        End Get

        Set(ByVal value As String)
            _CodigoMoneda = value
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

    Private _TextoImpresion As String
    <DataMember()>
    Public Property TextoImpresion() As String
        Get
            Return _TextoImpresion
        End Get

        Set(ByVal value As String)
            _TextoImpresion = value
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
