Imports System.Runtime.Serialization

<DataContract()>
Public Class LoteBE
    Public Property Lote As String

    Private _IdLote As Int32
    <DataMember()>
    Public Property IdLote() As Int32
        Get
            Return _IdLote
        End Get

        Set(ByVal value As Int32)
            _IdLote = value
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

    Private _Superficie As Double
    <DataMember()>
    Public Property Superficie() As Double
        Get
            Return _Superficie
        End Get

        Set(ByVal value As Double)
            _Superficie = value
        End Set
    End Property

    Private _Manzana As String
    <DataMember()>
    Public Property Manzana() As String
        Get
            Return _Manzana
        End Get

        Set(ByVal value As String)
            _Manzana = value
        End Set
    End Property

    Private _LinderoFrente As String
    <DataMember()>
    Public Property LinderoFrente() As String
        Get
            Return _LinderoFrente
        End Get

        Set(ByVal value As String)
            _LinderoFrente = value
        End Set
    End Property

    Private _LongitudLinderoFrente As Double
    <DataMember()>
    Public Property LongitudLinderoFrente() As Double
        Get
            Return _LongitudLinderoFrente
        End Get

        Set(ByVal value As Double)
            _LongitudLinderoFrente = value
        End Set
    End Property

    Private _LinderoDerecha As String
    <DataMember()>
    Public Property LinderoDerecha() As String
        Get
            Return _LinderoDerecha
        End Get

        Set(ByVal value As String)
            _LinderoDerecha = value
        End Set
    End Property

    Private _LongitudLinderoDerecha As Double
    <DataMember()>
    Public Property LongitudLinderoDerecha() As Double
        Get
            Return _LongitudLinderoDerecha
        End Get

        Set(ByVal value As Double)
            _LongitudLinderoDerecha = value
        End Set
    End Property

    Private _LinderoIzquierda As String
    <DataMember()>
    Public Property LinderoIzquierda() As String
        Get
            Return _LinderoIzquierda
        End Get

        Set(ByVal value As String)
            _LinderoIzquierda = value
        End Set
    End Property

    Private _LongitudLinderoIzquierda As Double
    <DataMember()>
    Public Property LongitudLinderoIzquierda() As Double
        Get
            Return _LongitudLinderoIzquierda
        End Get

        Set(ByVal value As Double)
            _LongitudLinderoIzquierda = value
        End Set
    End Property

    Private _LinderoFondo As String
    <DataMember()>
    Public Property LinderoFondo() As String
        Get
            Return _LinderoFondo
        End Get

        Set(ByVal value As String)
            _LinderoFondo = value
        End Set
    End Property

    Private _LongitudLinderoFondo As Double
    <DataMember()>
    Public Property LongitudLinderoFondo() As Double
        Get
            Return _LongitudLinderoFondo
        End Get

        Set(ByVal value As Double)
            _LongitudLinderoFondo = value
        End Set
    End Property

    Private _ImporteM2 As Decimal
    <DataMember()>
    Public Property ImporteM2() As Decimal
        Get
            Return _ImporteM2
        End Get

        Set(ByVal value As Decimal)
            _ImporteM2 = value
        End Set
    End Property

    Private _ImporteDescuento As Decimal
    <DataMember()>
    Public Property ImporteDescuento() As Decimal
        Get
            Return _ImporteDescuento
        End Get

        Set(ByVal value As Decimal)
            _ImporteDescuento = value
        End Set
    End Property

    Private _ImporteLote As Decimal
    <DataMember()>
    Public Property ImporteLote() As Decimal
        Get
            Return _ImporteLote
        End Get

        Set(ByVal value As Decimal)
            _ImporteLote = value
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

    Private _IdMoneda As Int32
    <DataMember()>
    Public Property IdMoneda() As Int32
        Get
            Return _IdMoneda
        End Get

        Set(ByVal value As Int32)
            _IdMoneda = value
        End Set
    End Property

End Class
