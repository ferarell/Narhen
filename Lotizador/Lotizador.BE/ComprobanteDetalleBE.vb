Public Class ComprobanteDetalleBE

    Private _n_cd_id As Integer
    Public Property n_cd_id() As Integer
        Get
            Return _n_cd_id
        End Get
        Set(ByVal value As Integer)
            _n_cd_id = value
        End Set
    End Property

    Private _n_cc_id As Integer
    Public Property n_cc_id() As Integer
        Get
            Return _n_cc_id
        End Get
        Set(ByVal value As Integer)
            _n_cc_id = value
        End Set
    End Property

    Private _v_cd_codigo As String
    Public Property v_cd_codigo() As String
        Get
            Return _v_cd_codigo
        End Get
        Set(ByVal value As String)
            _v_cd_codigo = value
        End Set
    End Property

    Private _n_cd_cantidad As Decimal
    Public Property n_cd_cantidad() As Decimal
        Get
            Return _n_cd_cantidad
        End Get
        Set(ByVal value As Decimal)
            _n_cd_cantidad = value
        End Set
    End Property

    Private _c_cd_unidad As String
    Public Property c_cd_unidad() As String
        Get
            Return _c_cd_unidad
        End Get
        Set(ByVal value As String)
            _c_cd_unidad = value
        End Set
    End Property

    Private _v_cd_descripcion As String
    Public Property v_cd_descripcion() As String
        Get
            Return _v_cd_descripcion
        End Get
        Set(ByVal value As String)
            _v_cd_descripcion = value
        End Set
    End Property

    Private _n_cd_valorventa As Decimal
    Public Property n_cd_valorventa() As Decimal
        Get
            Return _n_cd_valorventa
        End Get
        Set(ByVal value As Decimal)
            _n_cd_valorventa = value
        End Set
    End Property

    Private _n_cd_descuento As Decimal
    Public Property n_cd_descuento() As Decimal
        Get
            Return _n_cd_descuento
        End Get
        Set(ByVal value As Decimal)
            _n_cd_descuento = value
        End Set
    End Property

    Private _n_cd_importe As Decimal
    Public Property n_cd_importe() As Decimal
        Get
            Return _n_cd_importe
        End Get
        Set(ByVal value As Decimal)
            _n_cd_importe = value
        End Set
    End Property

    Private _n_cd_valorunitario As Decimal
    Public Property n_cd_valorunitario() As Decimal
        Get
            Return _n_cd_valorunitario
        End Get
        Set(ByVal value As Decimal)
            _n_cd_valorunitario = value
        End Set
    End Property

    Private _n_cd_igv As Decimal
    Public Property n_cd_igv() As Decimal
        Get
            Return _n_cd_igv
        End Get
        Set(ByVal value As Decimal)
            _n_cd_igv = value
        End Set
    End Property

End Class