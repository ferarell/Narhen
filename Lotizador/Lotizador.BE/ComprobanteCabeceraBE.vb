Public Class ComprobanteCabeceraBE

    Private _n_cc_id As Integer
    Public Property n_cc_id() As Integer
        Get
            Return _n_cc_id
        End Get
        Set(ByVal value As Integer)
            _n_cc_id = value
        End Set
    End Property

    Private _c_cc_tipo As String
    Public Property c_cc_tipo() As String
        Get
            Return _c_cc_tipo
        End Get
        Set(ByVal value As String)
            _c_cc_tipo = value
        End Set
    End Property

    Private _v_cc_serie As String
    Public Property v_cc_serie() As String
        Get
            Return _v_cc_serie
        End Get
        Set(ByVal value As String)
            _v_cc_serie = value
        End Set
    End Property

    Private _v_cc_numero As String
    Public Property v_cc_numero() As String
        Get
            Return _v_cc_numero
        End Get
        Set(ByVal value As String)
            _v_cc_numero = value
        End Set
    End Property

    Private _d_cc_fecha As Date
    Public Property d_cc_fecha As Date
        Get
            Return _d_cc_fecha
        End Get
        Set(ByVal value As Date)
            _d_cc_fecha = value
        End Set
    End Property

    Private _c_cc_moneda As String
    Public Property c_cc_moneda() As String
        Get
            Return _c_cc_moneda
        End Get
        Set(ByVal value As String)
            _c_cc_moneda = value
        End Set
    End Property

    Private _v_cc_emisor_razonsocial As String
    Public Property v_cc_emisor_razonsocial() As String
        Get
            Return _v_cc_emisor_razonsocial
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_razonsocial = value
        End Set
    End Property

    Private _c_cc_emisor_tipodoc As String
    Public Property c_cc_emisor_tipodoc() As String
        Get
            Return _c_cc_emisor_tipodoc
        End Get
        Set(ByVal value As String)
            _c_cc_emisor_tipodoc = value
        End Set
    End Property

    Private _v_cc_emisor_ruc As String
    Public Property v_cc_emisor_ruc() As String
        Get
            Return _v_cc_emisor_ruc
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_ruc = value
        End Set
    End Property

    Private _v_cc_emisor_direccion As String
    Public Property v_cc_emisor_direccion() As String
        Get
            Return _v_cc_emisor_direccion
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_direccion = value
        End Set
    End Property

    Private _v_cc_adquiriente_razonsocial As String
    Public Property v_cc_adquiriente_razonsocial() As String
        Get
            Return _v_cc_adquiriente_razonsocial
        End Get
        Set(ByVal value As String)
            _v_cc_adquiriente_razonsocial = value
        End Set
    End Property

    Private _c_cc_adquiriente_tipodoc As String
    Public Property c_cc_adquiriente_tipodoc() As String
        Get
            Return _c_cc_adquiriente_tipodoc
        End Get
        Set(ByVal value As String)
            _c_cc_adquiriente_tipodoc = value
        End Set
    End Property

    Private _v_cc_adquiriente_ruc As String
    Public Property v_cc_adquiriente_ruc() As String
        Get
            Return _v_cc_adquiriente_ruc
        End Get
        Set(ByVal value As String)
            _v_cc_adquiriente_ruc = value
        End Set
    End Property

    Private _v_cc_adquiriente_direccion As String
    Public Property v_cc_adquiriente_direccion() As String
        Get
            Return _v_cc_adquiriente_direccion
        End Get
        Set(ByVal value As String)
            _v_cc_adquiriente_direccion = value
        End Set
    End Property

    Private _c_cc_docmodif_tipo As String = ""
    Public Property c_cc_docmodif_tipo() As String
        Get
            Return _c_cc_docmodif_tipo
        End Get
        Set(ByVal value As String)
            _c_cc_docmodif_tipo = value
        End Set
    End Property

    Private _v_cc_docmodif_numero As String = ""
    Public Property v_cc_docmodif_numero() As String
        Get
            Return _v_cc_docmodif_numero
        End Get
        Set(ByVal value As String)
            _v_cc_docmodif_numero = value
        End Set
    End Property

    Private _v_cc_docmodif_motivo As String = ""
    Public Property v_cc_docmodif_motivo() As String
        Get
            Return _v_cc_docmodif_motivo
        End Get
        Set(ByVal value As String)
            _v_cc_docmodif_motivo = value
        End Set
    End Property

    Private _n_cc_gravado As Decimal
    Public Property n_cc_gravado() As Decimal
        Get
            Return _n_cc_gravado
        End Get
        Set(ByVal value As Decimal)
            _n_cc_gravado = value
        End Set
    End Property

    Private _n_cc_exonerado As Decimal
    Public Property n_cc_exonerado() As Decimal
        Get
            Return _n_cc_exonerado
        End Get
        Set(ByVal value As Decimal)
            _n_cc_exonerado = value
        End Set
    End Property

    Private _n_cc_inafecto As Decimal
    Public Property n_cc_inafecto() As Decimal
        Get
            Return _n_cc_inafecto
        End Get
        Set(ByVal value As Decimal)
            _n_cc_inafecto = value
        End Set
    End Property

    Private _n_cc_igv As Decimal
    Public Property n_cc_igv() As Decimal
        Get
            Return _n_cc_igv
        End Get
        Set(ByVal value As Decimal)
            _n_cc_igv = value
        End Set
    End Property

    Private _n_cc_descuento As Decimal
    Public Property n_cc_descuento() As Decimal
        Get
            Return _n_cc_descuento
        End Get
        Set(ByVal value As Decimal)
            _n_cc_descuento = value
        End Set
    End Property

    Private _n_cc_total As Decimal
    Public Property n_cc_total() As Decimal
        Get
            Return _n_cc_total
        End Get
        Set(ByVal value As Decimal)
            _n_cc_total = value
        End Set
    End Property

    Private _v_cc_montoletras As String
    Public Property v_cc_montoletras() As String
        Get
            Return _v_cc_montoletras
        End Get
        Set(ByVal value As String)
            _v_cc_montoletras = value
        End Set
    End Property

    Private _v_cc_guiaremision As String = ""
    Public Property v_cc_guiaremision() As String
        Get
            Return _v_cc_guiaremision
        End Get
        Set(ByVal value As String)
            _v_cc_guiaremision = value
        End Set
    End Property

    Private _v_sunat_rpta_codigo As String = ""
    Public Property v_sunat_rpta_codigo() As String
        Get
            Return _v_sunat_rpta_codigo
        End Get
        Set(ByVal value As String)
            _v_sunat_rpta_codigo = value
        End Set
    End Property

    Private _v_sunat_rpta_msje As String = ""
    Public Property v_sunat_rpta_msje() As String
        Get
            Return _v_sunat_rpta_msje
        End Get
        Set(ByVal value As String)
            _v_sunat_rpta_msje = value
        End Set
    End Property

    Private _v_archivo_xml As String = ""
    Public Property v_archivo_xml() As String
        Get
            Return _v_archivo_xml
        End Get
        Set(ByVal value As String)
            _v_archivo_xml = value
        End Set
    End Property

    Private _v_xml_valor_resumen As String = ""
    Public Property v_xml_valor_resumen() As String
        Get
            Return _v_xml_valor_resumen
        End Get
        Set(ByVal value As String)
            _v_xml_valor_resumen = value
        End Set
    End Property

    Private _v_xml_valor_firma As String = ""
    Public Property v_xml_valor_firma() As String
        Get
            Return _v_xml_valor_firma
        End Get
        Set(ByVal value As String)
            _v_xml_valor_firma = value
        End Set
    End Property

    Private _v_cc_emisor_telefono As String = ""
    Public Property v_cc_emisor_telefono() As String
        Get
            Return _v_cc_emisor_telefono
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_telefono = value
        End Set
    End Property

    Private _v_cc_emisor_departamento As String
    Public Property v_cc_emisor_departamento() As String
        Get
            Return _v_cc_emisor_departamento
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_departamento = value
        End Set
    End Property

    Private _v_cc_emisor_distrito As String
    Public Property v_cc_emisor_distrito() As String
        Get
            Return _v_cc_emisor_distrito
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_distrito = value
        End Set
    End Property

    Private _v_cc_emisor_observaciones1 As String = ""
    Public Property v_cc_emisor_observaciones1() As String
        Get
            Return _v_cc_emisor_observaciones1
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_observaciones1 = value
        End Set
    End Property

    Private _v_cc_emisor_observaciones2 As String = ""
    Public Property v_cc_emisor_observaciones2() As String
        Get
            Return _v_cc_emisor_observaciones2
        End Get
        Set(ByVal value As String)
            _v_cc_emisor_observaciones2 = value
        End Set
    End Property

    Private _n_cc_anticipos As Decimal = 0
    Public Property n_cc_anticipos() As Decimal
        Get
            Return _n_cc_anticipos
        End Get
        Set(ByVal value As Decimal)
            _n_cc_anticipos = value
        End Set
    End Property

    Private _n_cc_isc As Decimal = 0
    Public Property n_cc_isc() As Decimal
        Get
            Return _n_cc_isc
        End Get
        Set(ByVal value As Decimal)
            _n_cc_isc = value
        End Set
    End Property

    Private _n_cc_otros_tributos As Decimal = 0
    Public Property n_cc_otros_tributos() As Decimal
        Get
            Return _n_cc_otros_tributos
        End Get
        Set(ByVal value As Decimal)
            _n_cc_otros_tributos = value
        End Set
    End Property

    Private _n_cc_otros_cargos As Decimal = 0
    Public Property n_cc_otros_cargos() As Decimal
        Get
            Return _n_cc_otros_cargos
        End Get
        Set(ByVal value As Decimal)
            _n_cc_otros_cargos = value
        End Set
    End Property

    Private _n_cc_percepcion As Decimal = 0
    Public Property n_cc_percepcion() As Decimal
        Get
            Return _n_cc_percepcion
        End Get
        Set(ByVal value As Decimal)
            _n_cc_percepcion = value
        End Set
    End Property

    Private _n_cc_dsctos_globales As Decimal = 0
    Public Property n_cc_dsctos_globales() As Decimal
        Get
            Return _n_cc_dsctos_globales
        End Get
        Set(ByVal value As Decimal)
            _n_cc_dsctos_globales = value
        End Set
    End Property

    Private _n_cc_venta_gratuita As Decimal = 0
    Public Property n_cc_venta_gratuita() As Decimal
        Get
            Return _n_cc_venta_gratuita
        End Get
        Set(ByVal value As Decimal)
            _n_cc_venta_gratuita = value
        End Set
    End Property

    Public Property c_cc_log_fecha As String
    Public Property c_cc_log_hora As String
    Public Property v_cc_log_usuario As String

End Class
