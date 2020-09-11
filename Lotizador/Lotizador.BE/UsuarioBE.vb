Imports System.Runtime.Serialization

<DataContract()>
Public Class UsuarioBE
    'Inherits Respuesta

    Public Property id As String

    Private _IdUsuario As Int16
    <DataMember()>
    Public Property IdUsuario() As Int16
        Get
            Return _IdUsuario
        End Get

        Set(ByVal value As Int16)
            _IdUsuario = value
        End Set
    End Property

    Private _Cuenta As String
    <DataMember()>
    Public Property Cuenta() As String
        Get
            Return _Cuenta
        End Get

        Set(ByVal value As String)
            _Cuenta = value
        End Set
    End Property


    Private _Nombre As String
    <DataMember()>
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get

        Set(ByVal value As String)
            _Nombre = value
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




    Private _Password As String
    <DataMember()>
    Public Property Password() As String
        Get
            Return _Password
        End Get

        Set(ByVal value As String)
            _Password = value
        End Set
    End Property


    Private _Correo As String
    <DataMember()>
    Public Property Correo() As String
        Get
            Return _Correo
        End Get

        Set(ByVal value As String)
            _Correo = value
        End Set
    End Property


    Private _LookAndFeel As String
    <DataMember()>
    Public Property LookAndFeel() As String
        Get
            Return _LookAndFeel
        End Get

        Set(ByVal value As String)
            _LookAndFeel = value
        End Set
    End Property


    Private _Image As Byte()
    <DataMember()>
    Public Property Image() As Byte()
        Get
            Return _Image
        End Get

        Set(ByVal value As Byte())
            _Image = value
        End Set
    End Property


    Private _Activo As Boolean
    <DataMember()>
    Public Property Activo() As Boolean
        Get
            Return _Activo
        End Get

        Set(ByVal value As Boolean)
            _Activo = value
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


    Private _FlgCambioPwd As Boolean
    <DataMember()>
    Public Property FlgCambioPwd() As Boolean
        Get
            Return _FlgCambioPwd
        End Get

        Set(ByVal value As Boolean)
            _FlgCambioPwd = value
        End Set
    End Property



End Class
