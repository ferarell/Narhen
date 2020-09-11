Imports System.Runtime.Serialization
<DataContract()>
Public Class ContratoBE
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

    Private _IdLote As Int16
    <DataMember()>
    Public Property IdLote() As Int16
        Get
            Return _IdLote
        End Get

        Set(ByVal value As Int16)
            _IdLote = value
        End Set
    End Property

    Private _IdProyecto As Int16
    <DataMember()>
    Public Property IdProyecto() As Int16
        Get
            Return _IdProyecto
        End Get

        Set(ByVal value As Int16)
            _IdProyecto = value
        End Set
    End Property

    Private _FechaEmision As DateTime
    <DataMember()>
    Public Property FechaEmision() As DateTime
        Get
            Return _FechaEmision
        End Get

        Set(ByVal value As DateTime)
            _FechaEmision = value
        End Set
    End Property


    Private _NumeroCuotas As Int16
    <DataMember()>
    Public Property NumeroCuotas() As Int16
        Get
            Return _NumeroCuotas
        End Get

        Set(ByVal value As Int16)
            _NumeroCuotas = value
        End Set
    End Property



    Private _ValorCuotas As Decimal
    <DataMember()>
    Public Property ValorCuotas() As Decimal
        Get
            Return _ValorCuotas
        End Get

        Set(ByVal value As Decimal)
            _ValorCuotas = value
        End Set
    End Property


    Private _FechaInicio As DateTime
    <DataMember()>
    Public Property FechaInicio() As DateTime
        Get
            Return _FechaInicio
        End Get

        Set(ByVal value As DateTime)
            _FechaInicio = value
        End Set
    End Property


    Private _DiaPago As Int16
    <DataMember()>
    Public Property DiaPago() As Int16
        Get
            Return _DiaPago
        End Get

        Set(ByVal value As Int16)
            _DiaPago = value
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

    Private _DescripcionLote As String
    <DataMember()>
    Public Property DescripcionLote() As String
        Get
            Return _DescripcionLote
        End Get

        Set(ByVal value As String)
            _DescripcionLote = value
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


    Private _ImporteInicial As Decimal
    <DataMember()>
    Public Property ImporteInicial() As Decimal
        Get
            Return _ImporteInicial
        End Get

        Set(ByVal value As Decimal)
            _ImporteInicial = value
        End Set
    End Property

    Private _PrimeraCuota As Decimal
    <DataMember()>
    Public Property PrimeraCuota() As Decimal
        Get
            Return _PrimeraCuota
        End Get

        Set(ByVal value As Decimal)
            _PrimeraCuota = value
        End Set
    End Property

    Private _ImporteTotal As Decimal
    <DataMember()>
    Public Property ImporteTotal() As Decimal
        Get
            Return _ImporteTotal
        End Get

        Set(ByVal value As Decimal)
            _ImporteTotal = value
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



    Private _listContratoSocioBE As List(Of ContratoSocioBE)
    <DataMember()>
    Public Property listContratoSocioBE() As List(Of ContratoSocioBE)
        Get
            Return _listContratoSocioBE
        End Get

        Set(ByVal value As List(Of ContratoSocioBE))
            _listContratoSocioBE = value
        End Set
    End Property



    Private _dtSocios As DataTable
    <DataMember()>
    Public Property dtSocios() As DataTable
        Get
            Return _dtSocios
        End Get

        Set(ByVal value As DataTable)
            _dtSocios = value
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

    Private _NombreSocio As String
    <DataMember()>
    Public Property NombreSocio() As String
        Get
            Return _NombreSocio
        End Get

        Set(ByVal value As String)
            _NombreSocio = value
        End Set
    End Property

    Private _ManzanaLote As String
    <DataMember()>
    Public Property ManzanaLote() As String
        Get
            Return _ManzanaLote
        End Get

        Set(ByVal value As String)
            _ManzanaLote = value
        End Set
    End Property


End Class
