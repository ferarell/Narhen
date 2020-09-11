Imports System.Runtime.Serialization

<DataContract()>
Public Class SecuenciaBE

    Private _IdSecuencia As Int16
    <DataMember()>
    Public Property IdSecuencia() As Int16
        Get
            Return _IdSecuencia
        End Get

        Set(ByVal value As Int16)
            _IdSecuencia = value
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

    Private _IdTipoDocumento As Int16
    <DataMember()>
    Public Property IdTipoDocumento() As Int16
        Get
            Return _IdTipoDocumento
        End Get

        Set(ByVal value As Int16)
            _IdTipoDocumento = value
        End Set
    End Property

    Private _SerieDocumento As String
    <DataMember()>
    Public Property SerieDocumento() As String
        Get
            Return _SerieDocumento
        End Get

        Set(ByVal value As String)
            _SerieDocumento = value
        End Set
    End Property

    Private _NumeroDocumentoInicial As Int32
    <DataMember()>
    Public Property NumeroDocumentoInicial() As Int32
        Get
            Return _NumeroDocumentoInicial
        End Get

        Set(ByVal value As Int32)
            _NumeroDocumentoInicial = value
        End Set
    End Property

    Private _NumeroDocumentoFinal As Int32
    <DataMember()>
    Public Property NumeroDocumentoFinal() As Int32
        Get
            Return _NumeroDocumentoFinal
        End Get

        Set(ByVal value As Int32)
            _NumeroDocumentoFinal = value
        End Set
    End Property

    Private _NumeroDocumentoCorriente As Int32
    <DataMember()>
    Public Property NumeroDocumentoCorriente() As Int32
        Get
            Return _NumeroDocumentoCorriente
        End Get

        Set(ByVal value As Int32)
            _NumeroDocumentoCorriente = value
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

    Private _Proyecto As String
    <DataMember()>
    Public Property Proyecto() As String
        Get
            Return _Proyecto
        End Get

        Set(ByVal value As String)
            _Proyecto = value
        End Set
    End Property

    Private _TipoDocumento As String
    <DataMember()>
    Public Property TipoDocumento() As String
        Get
            Return _TipoDocumento
        End Get

        Set(ByVal value As String)
            _TipoDocumento = value
        End Set
    End Property

End Class
