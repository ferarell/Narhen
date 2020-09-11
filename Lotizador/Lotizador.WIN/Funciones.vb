Imports Lotizador.BE

Public Class Funciones

    Public Shared USUARIO As String

    Public Shared Function CrearTablaComprobanteCabecera(ByVal objFactura As ComprobanteCabeceraBE) As DataTable
        Dim table As New DataTable
        table.Columns.Add("c_cc_tipo", GetType(String))
        table.Columns.Add("v_cc_serie", GetType(String))
        table.Columns.Add("v_cc_numero", GetType(String))
        table.Columns.Add("d_cc_fecha", GetType(Date))
        table.Columns.Add("c_cc_moneda", GetType(String))
        table.Columns.Add("v_cc_emisor_razonsocial", GetType(String))
        table.Columns.Add("c_cc_emisor_tipodoc", GetType(String))
        table.Columns.Add("v_cc_emisor_ruc", GetType(String))
        table.Columns.Add("v_cc_emisor_direccion", GetType(String))
        table.Columns.Add("v_cc_adquiriente_razonsocial", GetType(String))
        table.Columns.Add("c_cc_adquiriente_tipodoc", GetType(String))
        table.Columns.Add("v_cc_adquiriente_ruc", GetType(String))
        table.Columns.Add("v_cc_adquiriente_direccion", GetType(String))
        table.Columns.Add("c_cc_docmodif_tipo", GetType(String))
        table.Columns.Add("v_cc_docmodif_numero", GetType(String))
        table.Columns.Add("v_cc_docmodif_motivo", GetType(String))
        table.Columns.Add("n_cc_gravado", GetType(Decimal))
        table.Columns.Add("n_cc_exonerado", GetType(Decimal))
        table.Columns.Add("n_cc_inafecto", GetType(Decimal))
        table.Columns.Add("n_cc_igv", GetType(Decimal))
        table.Columns.Add("n_cc_descuento", GetType(Decimal))
        table.Columns.Add("n_cc_total", GetType(Decimal))
        table.Columns.Add("v_cc_montoletras", GetType(String))
        table.Columns.Add("v_cc_guiaremision", GetType(String))
        table.Columns.Add("v_archivo_xml", GetType(String))
        table.Columns.Add("v_xml_valor_resumen", GetType(String))
        table.Columns.Add("v_xml_valor_firma", GetType(String))
        table.Columns.Add("v_cc_emisor_telefono", GetType(String))
        table.Columns.Add("v_cc_emisor_departamento", GetType(String))
        table.Columns.Add("v_cc_emisor_distrito", GetType(String))
        table.Columns.Add("v_cc_emisor_observaciones1", GetType(String))
        table.Columns.Add("v_cc_emisor_observaciones2", GetType(String))
        table.Columns.Add("n_cc_anticipos", GetType(Decimal))
        table.Columns.Add("n_cc_otros_tributos", GetType(Decimal))
        table.Columns.Add("n_cc_otros_cargos", GetType(Decimal))
        table.Columns.Add("n_cc_dsctos_globales", GetType(Decimal))
        table.Columns.Add("n_cc_venta_gratuita", GetType(Decimal))

        table.Rows.Add(objFactura.c_cc_tipo,
                       objFactura.v_cc_serie,
                       objFactura.v_cc_numero,
                       objFactura.d_cc_fecha,
                       objFactura.c_cc_moneda,
                       objFactura.v_cc_emisor_razonsocial,
                       objFactura.c_cc_emisor_tipodoc,
                       objFactura.v_cc_emisor_ruc,
                       objFactura.v_cc_emisor_direccion,
                       objFactura.v_cc_adquiriente_razonsocial,
                       objFactura.c_cc_adquiriente_tipodoc,
                       objFactura.v_cc_adquiriente_ruc,
                       objFactura.v_cc_adquiriente_direccion,
                       objFactura.c_cc_docmodif_tipo,
                       objFactura.v_cc_docmodif_numero,
                       objFactura.v_cc_docmodif_motivo,
                       objFactura.n_cc_gravado,
                       objFactura.n_cc_exonerado,
                       objFactura.n_cc_inafecto,
                       objFactura.n_cc_igv,
                       objFactura.n_cc_descuento,
                       objFactura.n_cc_total,
                       objFactura.v_cc_montoletras,
                       objFactura.v_cc_guiaremision,
                       "",
                       "",
                       "",
                       objFactura.v_cc_emisor_telefono,
                       objFactura.v_cc_emisor_departamento,
                       objFactura.v_cc_emisor_distrito,
                       objFactura.v_cc_emisor_observaciones1,
                       objFactura.v_cc_emisor_observaciones2,
                       objFactura.n_cc_anticipos,
                       objFactura.n_cc_otros_tributos,
                       objFactura.n_cc_otros_cargos,
                       objFactura.n_cc_dsctos_globales,
                       objFactura.n_cc_venta_gratuita)

        Return table
    End Function

    Public Shared Function CrearTablaComprobanteDetalle(ByVal lstFacturaItem As List(Of ComprobanteDetalleBE)) As DataTable
        Dim table As New DataTable
        table.Columns.Add("v_cd_codigo", GetType(String))
        table.Columns.Add("n_cd_cantidad", GetType(Decimal))
        table.Columns.Add("c_cd_unidad", GetType(String))
        table.Columns.Add("v_cd_descripcion", GetType(String))
        table.Columns.Add("n_cd_valorventa", GetType(Decimal))
        table.Columns.Add("n_cd_descuento", GetType(Decimal))
        table.Columns.Add("n_cd_importe", GetType(Decimal))
        table.Columns.Add("n_cd_valorunitario", GetType(Decimal))
        table.Columns.Add("n_cd_igv", GetType(Decimal))

        For Each oFacturaDetalle As ComprobanteDetalleBE In lstFacturaItem
            table.Rows.Add(oFacturaDetalle.v_cd_codigo,
                           oFacturaDetalle.n_cd_cantidad,
                           oFacturaDetalle.c_cd_unidad,
                           oFacturaDetalle.v_cd_descripcion,
                           oFacturaDetalle.n_cd_valorventa,
                           oFacturaDetalle.n_cd_descuento,
                           oFacturaDetalle.n_cd_importe,
                           oFacturaDetalle.n_cd_valorunitario,
                           oFacturaDetalle.n_cd_igv)
        Next

        Return table
    End Function

End Class
