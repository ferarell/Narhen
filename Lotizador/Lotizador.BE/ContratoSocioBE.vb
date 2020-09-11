Imports System.Runtime.Serialization
<DataContract()>
Public Class ContratoSocioBE
    Private _IdContrato As Int16
    <DataMember()>
    Public Property IdContrato() As Int16
        Get
            Return _IdContrato
        End Get

        Set(ByVal value As Int16)
            _IdContrato = value
        End Set
    End Property

    Private _IdSocio As Int16
    <DataMember()>
    Public Property IdSocio() As Int16
        Get
            Return _IdSocio
        End Get

        Set(ByVal value As Int16)
            _IdSocio = value
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

    Private _Principal As String
    <DataMember()>
    Public Property Principal() As String
        Get
            Return _Principal
        End Get

        Set(ByVal value As String)
            _Principal = value
        End Set
    End Property





End Class
