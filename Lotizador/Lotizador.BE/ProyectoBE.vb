Imports System.Runtime.Serialization

<DataContract()>
Public Class ProyectoBE

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

    Private _CantidadLotes As Int16
    <DataMember()>
    Public Property CantidadLotes() As Int16
        Get
            Return _CantidadLotes
        End Get

        Set(ByVal value As Int16)
            _CantidadLotes = value
        End Set
    End Property

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

    Private _CuentaCorriente As String
    <DataMember()>
    Public Property CuentaCorriente() As String
        Get
            Return _CuentaCorriente
        End Get

        Set(ByVal value As String)
            _CuentaCorriente = value
        End Set
    End Property

    Private _ImporteMora As Decimal
    <DataMember()>
    Public Property ImporteMora() As Decimal
        Get
            Return _ImporteMora
        End Get

        Set(ByVal value As Decimal)
            _ImporteMora = value
        End Set
    End Property

    Private _ArchivoPlantilla As String
    <DataMember()>
    Public Property ArchivoPlantilla() As String
        Get
            Return _ArchivoPlantilla
        End Get

        Set(ByVal value As String)
            _ArchivoPlantilla = value
        End Set
    End Property

    Private _CodigoInterbancario As String
    <DataMember()>
    Public Property CodigoInterbancario() As String
        Get
            Return _CodigoInterbancario
        End Get

        Set(ByVal value As String)
            _CodigoInterbancario = value
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

    Private _Banco As String
    <DataMember()>
    Public Property Banco() As String
        Get
            Return _Banco
        End Get

        Set(ByVal value As String)
            _Banco = value
        End Set
    End Property
End Class
