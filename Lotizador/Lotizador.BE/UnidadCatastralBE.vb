Imports System.Runtime.Serialization

<DataContract()>
Public Class UnidadCatastralBE

    Private _IdUnidadCatastral As Int32
    <DataMember()>
    Public Property IdUnidadCatastral() As Int32
        Get
            Return _IdUnidadCatastral
        End Get

        Set(ByVal value As Int32)
            _IdUnidadCatastral = value
        End Set
    End Property

    Private _IdProyecto As Int32
    <DataMember()>
    Public Property IdProyecto() As Int32
        Get
            Return _IdProyecto
        End Get

        Set(ByVal value As Int32)
            _IdProyecto = value
        End Set
    End Property

    Private _NombreProyecto As String
    <DataMember()>
    Public Property NombreProyecto() As String
        Get
            Return _NombreProyecto
        End Get

        Set(ByVal value As String)
            _NombreProyecto = value
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

    Private _Superficie As Decimal
    <DataMember()>
    Public Property Superficie() As Decimal
        Get
            Return _Superficie
        End Get

        Set(ByVal value As Decimal)
            _Superficie = value
        End Set
    End Property

    Private _PartidaRegistral As String
    <DataMember()>
    Public Property PartidaRegistral() As String
        Get
            Return _PartidaRegistral
        End Get

        Set(ByVal value As String)
            _PartidaRegistral = value
        End Set
    End Property

    Private _RegistroPredial As String
    <DataMember()>
    Public Property RegistroPredial() As String
        Get
            Return _RegistroPredial
        End Get

        Set(ByVal value As String)
            _RegistroPredial = value
        End Set
    End Property

    Private _Denominacion As String
    <DataMember()>
    Public Property Denominacion() As String
        Get
            Return _Denominacion
        End Get

        Set(ByVal value As String)
            _Denominacion = value
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
