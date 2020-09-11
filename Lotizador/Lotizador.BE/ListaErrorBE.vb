Imports System.Runtime.Serialization

<DataContract()>
Public Class ListaErrorBE

    Private _IdError As Int32
    <DataMember()>
    Public Property IdError() As Int32
        Get
            Return _IdError
        End Get

        Set(ByVal value As Int32)
            _IdError = value
        End Set
    End Property

    Private _NombreError As String
    <DataMember()>
    Public Property NombreError() As String
        Get
            Return _NombreError
        End Get

        Set(ByVal value As String)
            _NombreError = value
        End Set
    End Property

    Private _DescripcionError As String
    <DataMember()>
    Public Property DescripcionError() As String
        Get
            Return _DescripcionError
        End Get

        Set(ByVal value As String)
            _DescripcionError = value
        End Set
    End Property

    Private _Ubicacion As String
    <DataMember()>
    Public Property Ubicacion() As String
        Get
            Return _Ubicacion
        End Get

        Set(ByVal value As String)
            _Ubicacion = value
        End Set
    End Property

    Private _Usuario As String
    <DataMember()>
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get

        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Private _NombreObjeto As String
    <DataMember()>
    Public Property NombreObjeto() As String
        Get
            Return _NombreObjeto
        End Get

        Set(ByVal value As String)
            _NombreObjeto = value
        End Set
    End Property

    Private _FechaHora As DateTime
    <DataMember()>
    Public Property FechaHora() As DateTime
        Get
            Return _FechaHora
        End Get

        Set(ByVal value As DateTime)
            _FechaHora = value
        End Set
    End Property

    Private _Atendido As String
    <DataMember()>
    Public Property Atendido() As String
        Get
            Return _Atendido
        End Get

        Set(ByVal value As String)
            _Atendido = value
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
