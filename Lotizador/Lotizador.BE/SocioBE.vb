Imports System.Runtime.Serialization

<DataContract()>
Public Class SocioBE

    Private _IdSocio As Int32
    <DataMember()>
    Public Property IdSocio() As Int32
        Get
            Return _IdSocio
        End Get

        Set(ByVal value As Int32)
            _IdSocio = value
        End Set
    End Property



    Private _TipoSocio As String
    <DataMember()>
    Public Property TipoSocio() As String
        Get
            Return _TipoSocio
        End Get

        Set(ByVal value As String)
            _TipoSocio = value
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

    Private _ApellidoPaterno As String
    <DataMember()>
    Public Property ApellidoPaterno() As String
        Get
            Return _ApellidoPaterno
        End Get

        Set(ByVal value As String)
            _ApellidoPaterno = value
        End Set
    End Property


    Private _ApellidoMaterno As String
    <DataMember()>
    Public Property ApellidoMaterno() As String
        Get
            Return _ApellidoMaterno
        End Get

        Set(ByVal value As String)
            _ApellidoMaterno = value
        End Set
    End Property



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


    Private _NumeroDocumento As String
    <DataMember()>
    Public Property NumeroDocumento() As String
        Get
            Return _NumeroDocumento
        End Get

        Set(ByVal value As String)
            _NumeroDocumento = value
        End Set
    End Property




    Private _TelefonoDomicilio As String
    <DataMember()>
    Public Property TelefonoDomicilio() As String
        Get
            Return _TelefonoDomicilio
        End Get

        Set(ByVal value As String)
            _TelefonoDomicilio = value
        End Set
    End Property



    Private _TelefonoMovil As String
    <DataMember()>
    Public Property TelefonoMovil() As String
        Get
            Return _TelefonoMovil
        End Get

        Set(ByVal value As String)
            _TelefonoMovil = value
        End Set
    End Property



    Private _TelefonoOficina As String
    <DataMember()>
    Public Property TelefonoOficina() As String
        Get
            Return _TelefonoOficina
        End Get

        Set(ByVal value As String)
            _TelefonoOficina = value
        End Set
    End Property



    Private _Fax As String
    <DataMember()>
    Public Property Fax() As String
        Get
            Return _Fax
        End Get

        Set(ByVal value As String)
            _Fax = value
        End Set
    End Property


    Private _Direccion As String
    <DataMember()>
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get

        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property



    Private _IdUbigeo As Int32
    <DataMember()>
    Public Property IdUbigeo() As Int32
        Get
            Return _IdUbigeo
        End Get

        Set(ByVal value As Int32)
            _IdUbigeo = value
        End Set
    End Property


    Private _ReferenciaDireccion As String
    <DataMember()>
    Public Property ReferenciaDireccion() As String
        Get
            Return _ReferenciaDireccion
        End Get

        Set(ByVal value As String)
            _ReferenciaDireccion = value
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


    Private _Estado As String
    <DataMember()>
    Public Property Estado() As String
        Get
            Return _Estado
        End Get

        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property




    Private _Mensajeria As String
    <DataMember()>
    Public Property Mensajeria() As String
        Get
            Return _Mensajeria
        End Get

        Set(ByVal value As String)
            _Mensajeria = value
        End Set
    End Property



    Private _FechaNacimiento As DateTime
    <DataMember()>
    Public Property FechaNacimiento() As DateTime
        Get
            Return _FechaNacimiento
        End Get

        Set(ByVal value As DateTime)
            _FechaNacimiento = value
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



    Private _Departamento As String
    <DataMember()>
    Public Property Departamento() As String
        Get
            Return _Departamento
        End Get

        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property

    Private _Provincia As String
    <DataMember()>
    Public Property Provincia() As String
        Get
            Return _Provincia
        End Get

        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property


    Private _Distrito As String
    <DataMember()>
    Public Property Distrito() As String
        Get
            Return _Distrito
        End Get

        Set(ByVal value As String)
            _Distrito = value
        End Set
    End Property


    Private _TipoSocioDesc As String
    <DataMember()>
    Public Property TipoSocioDesc() As String
        Get
            Return _TipoSocioDesc
        End Get

        Set(ByVal value As String)
            _TipoSocioDesc = value
        End Set
    End Property


    Private _TipoDocumentoDesc As String
    <DataMember()>
    Public Property TipoDocumentoDesc() As String
        Get
            Return _TipoDocumentoDesc
        End Get

        Set(ByVal value As String)
            _TipoDocumentoDesc = value
        End Set
    End Property

    Private _Sexo As String
    <DataMember()>
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get

        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Private _Ocupacion As String
    <DataMember()>
    Public Property Ocupacion() As String
        Get
            Return _Ocupacion
        End Get

        Set(ByVal value As String)
            _Ocupacion = value
        End Set
    End Property

    Private _IdDepartamento As Int32
    <DataMember()>
    Public Property IdDepartamento() As Int32
        Get
            Return _IdDepartamento
        End Get

        Set(ByVal value As Int32)
            _IdDepartamento = value
        End Set
    End Property

    Private _IdProvincia As Int32
    <DataMember()>
    Public Property IdProvincia() As Int32
        Get
            Return _IdProvincia
        End Get

        Set(ByVal value As Int32)
            _IdProvincia = value
        End Set
    End Property


    Private _IdDistrito As Int32
    <DataMember()>
    Public Property IdDistrito() As Int32
        Get
            Return _IdDistrito
        End Get

        Set(ByVal value As Int32)
            _IdDistrito = value
        End Set
    End Property


End Class
