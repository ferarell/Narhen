Imports System.Runtime.Serialization

<DataContract()>
Public Class UbigeoBE
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



    Private _NombreDepartamento As String
    <DataMember()>
    Public Property NombreDepartamento() As String
        Get
            Return _NombreDepartamento
        End Get

        Set(ByVal value As String)
            _NombreDepartamento = value
        End Set
    End Property

    Private _NombreProvincia As String
    <DataMember()>
    Public Property NombreProvincia() As String
        Get
            Return _NombreProvincia
        End Get

        Set(ByVal value As String)
            _NombreProvincia = value
        End Set
    End Property


    Private _NombreDistrito As String
    <DataMember()>
    Public Property NombreDistrito() As String
        Get
            Return _NombreDistrito
        End Get

        Set(ByVal value As String)
            _NombreDistrito = value
        End Set
    End Property



End Class
