Imports System.Runtime.Serialization

<DataContract()>
Public Class MonedaTipoCambioBE

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

    Private _FechaReferencia As DateTime
    <DataMember()>
    Public Property FechaReferencia() As DateTime
        Get
            Return _FechaReferencia
        End Get

        Set(ByVal value As DateTime)
            _FechaReferencia = value
        End Set
    End Property

    Private _TcDolarV As Double
    <DataMember()>
    Public Property TcDolarV() As Double
        Get
            Return _TcDolarV
        End Get

        Set(ByVal value As Double)
            _TcDolarV = value
        End Set
    End Property

    Private _TcLocalV As Double
    <DataMember()>
    Public Property TcLocalV() As Double
        Get
            Return _TcLocalV
        End Get

        Set(ByVal value As Double)
            _TcLocalV = value
        End Set
    End Property

    Private _TcDolarC As Double
    <DataMember()>
    Public Property TcDolarC() As Double
        Get
            Return _TcDolarC
        End Get

        Set(ByVal value As Double)
            _TcDolarC = value
        End Set
    End Property

    Private _TcLocalC As Double
    <DataMember()>
    Public Property TcLocalC() As Double
        Get
            Return _TcLocalC
        End Get

        Set(ByVal value As Double)
            _TcLocalC = value
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
