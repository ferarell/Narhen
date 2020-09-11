Imports System.Runtime.Serialization

<DataContract()>
Public Class VariableBE
    Private _IdVariable As Int32
    <DataMember()>
    Public Property IdVariable() As Int32
        Get
            Return _IdVariable
        End Get

        Set(ByVal value As Int32)
            _IdVariable = value
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



    Private _Codigo As String
    <DataMember()>
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get

        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Private _Valor As String
    <DataMember()>
    Public Property Valor() As String
        Get
            Return _Valor
        End Get

        Set(ByVal value As String)
            _Valor = value
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
