Imports DevExpress.XtraSplashScreen
Imports Lotizador.UI.LotizadorService
Imports Microsoft.Office.Interop
Imports System.IO

Public Class frmContratos
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oView As New Object
    Dim oContratoBE As ContratoBE
    Dim oGeneralBE As New GeneralBE

    Private Sub bbiCronograma_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCronograma.ItemClick
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        If Not fnExisteLetras() Then
            Dim Message As String = "No existen Letras asociadas al Contrato, desea crearlas?"
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, Message, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                oGeneralBE.SqlTxt = "EXEC upInsertarLetrasPorContrato " & oContratoBE.IdContrato.ToString & "," & IdUsuario
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Else
                Return
            End If
        End If
        Dim myForm As New frmVisorCronograma
        myForm.ContratoBEEdit = oContratoBE
        myForm.ShowDialog()
    End Sub

    Friend Sub SelectPage(ByVal FormName As String)
        For Each myChildForm In Me.ParentForm.MdiChildren
            If myChildForm.Name = FormName Then
                myChildForm.Focus()
            End If
        Next
    End Sub

    Function fnExisteTipoCambio(ByVal FechaEmision As Date) As Boolean
        Dim bResult As Boolean = True
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        oGeneralBE.SqlTxt = "SELECT * FROM MonedaTipoCambio WHERE FechaReferencia = '" & Format(oContratoBE.FechaEmision, "yyyy-MM-dd") & "'"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        If oGeneralBE.dtResult.Rows.Count = 0 Then
            bResult = False
        End If
        Return bResult
    End Function

    Private Sub bbiContrato_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiContrato.ItemClick
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        If oContratoBE.CodigoMoneda = "USD" Then
            Dim dFechaEmision As Date = oContratoBE.FechaEmision
            If Not fnExisteTipoCambio(dFechaEmision) Then
                Dim sMensaje As String = "No existe tipo de cambio para el día " & dFechaEmision & ", por favor ingréselo."
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, sMensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
                'Dim sMensaje As String = "No existe tipo de cambio para el día " & dFechaEmision.ToString & ", desea ingresarlo? "
                'If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, sMensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Else
                '    Return
                'End If
            End If
        End If
        If Not fnExisteLetras() Then
            Dim Message As String = "No existen Letras asociadas al Contrato, desea crearlas?"
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, Message, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                oGeneralBE.SqlTxt = "EXEC upInsertarLetrasPorContrato " & oContratoBE.IdContrato.ToString & "," & IdUsuario
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Else
                Return
            End If
        End If
        OpenFile()
    End Sub

    Private Sub bbiNuevo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNuevo.ItemClick
        Dim oFormDialog As frmPopupContratos = New frmPopupContratos()
        Dim oContratoEdit As ContratoBE = New ContratoBE()
        oContratoEdit.IdContrato = -1
        oContratoEdit = oNarhemService.ObtenerContrato(oContratoEdit)
        oFormDialog.oContratoBEEdit = oContratoEdit
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaContratos()
        End If
    End Sub

    Public Sub PoblarGrillaContratos()
        SplashScreenManager.ShowForm(Me, GetType(WaitForm), True, True, False)
        SplashScreenManager.Default.SetWaitFormDescription("Consultando datos")
        Try
            Dim oContratoBE As ContratoBE = New ContratoBE()
            Dim listContratos As List(Of ContratoBE) = New List(Of ContratoBE)(oNarhemService.ObtenerContratoPorCriterio(oContratoBE))
            Me.gcContratos.DataSource = listContratos
            oView = gcContratos.MainView.SourceRow
        Catch ex As Exception
            SplashScreenManager.CloseForm(False)
        Finally
            SplashScreenManager.CloseForm(False)
        End Try
    End Sub

    Private Sub frmContratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bbiEditar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEditar.ItemClick
        Dim oContratoBE As ContratoBE
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        Dim oFormDialog As frmPopupContratos = New frmPopupContratos()
        oFormDialog.oContratoBEEdit = oContratoBE
        If oFormDialog.ShowDialog() = DialogResult.OK Then
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Grabado Satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PoblarGrillaContratos()
        End If
    End Sub

    Private Sub bbiEliminar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiEliminar.ItemClick
        Dim oContratoBE As ContratoBE
        If Me.gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If oNarhemService.EliminarContrato(oContratoBE) Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Eliminacion Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PoblarGrillaContratos()
            End If
        End If
    End Sub

    Private Sub bbiCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiCerrar.ItemClick
        Me.Close()
    End Sub


    Private Sub bbiLetras_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLetras.ItemClick
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        If Not fnExisteLetras() Then
            Dim Message As String = "No existen Letras asociadas al Contrato, desea crearlas?"
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, Message, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                oGeneralBE.SqlTxt = "EXEC upInsertarLetrasPorContrato " & oContratoBE.IdContrato.ToString & "," & IdUsuario
                oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Else
                Return
            End If
        End If
        Dim myForm As New frmVisorLetras
        myForm.ContratoBEEdit = oContratoBE
        myForm.ShowDialog()
    End Sub

    Private Sub OpenFile()
        Try
            Dim oGeneralBE As New GeneralBE
            oGeneralBE.SqlTxt = "exec upObtenerInformacionPorContrato " & oContratoBE.IdContrato
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)

            Dim appw As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()

            Dim fileName As Object = oGeneralBE.dtResult.Rows(0).Item("ArchivoPlantilla") + ".DOTX"
            Dim newfileName As Object = oGeneralBE.dtResult.Rows(0).Item("ArchivoContrato")
            appw.Visible = True
            appw.Application.Activate()

            Dim objdoc As Microsoft.Office.Interop.Word.Document = appw.Application.Documents.Open(fileName)
            'Moneda del Documento
            Dim sMoneda As String = oGeneralBE.dtResult.Rows(0).Item("SimboloMoneda")
            'Vendedor
            ReplaceBookmarkText(objdoc, "NombreVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("NombreVendedor")))
            ReplaceBookmarkText(objdoc, "DocumentoVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("TipoDocumentoVendedor") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumentoVendedor")))
            ReplaceBookmarkText(objdoc, "DireccionVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("DireccionVendedor")))
            ReplaceBookmarkText(objdoc, "UbigeoVendedor", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("UbigeoVendedor")))
            'Comprador
            'ReplaceBookmarkText(objdoc, "NombreComprador1", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SP")))
            'ReplaceBookmarkText(objdoc, "DocumentoComprador1", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SP") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SP")))
            'ReplaceBookmarkText(objdoc, "NombreComprador2", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SS")))
            'ReplaceBookmarkText(objdoc, "DocumentoComprador2", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SS") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SS")))
            'ReplaceBookmarkText(objdoc, "DireccionComprador", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Direccion_SP")))
            'Ubigeo
            Dim UbigeoComprador1 As String = ""
            Dim UbigeoComprador2 As String = ""
            If oGeneralBE.dtResult.Rows(0).Item("Provincia_SP") = oGeneralBE.dtResult.Rows(0).Item("Departamento_SP") Then
                UbigeoComprador1 = EvaluaCelda(", en el Distrito de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Distrito_SP")) + ", Provincia y Departamento de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Departamento_SP")))
            Else
                UbigeoComprador1 = EvaluaCelda(", en el Distrito de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Distrito_SP")) + ", Provincia de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Provincia_SP")) + " Departamento de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Departamento_SP")))
            End If
            If IsDBNull(oGeneralBE.dtResult.Rows(0).Item("Nombre_SS")) = False Then
                If oGeneralBE.dtResult.Rows(0).Item("Provincia_SS") = oGeneralBE.dtResult.Rows(0).Item("Departamento_SS") Then
                    UbigeoComprador2 = EvaluaCelda(", en el Distrito de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Distrito_SS")) + ", Provincia y Departamento de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Departamento_SS")))
                Else
                    UbigeoComprador2 = EvaluaCelda(", en el Distrito de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Distrito_SS")) + ", Provincia de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Provincia_SS")) + " Departamento de " + Trim(oGeneralBE.dtResult.Rows(0).Item("Departamento_SS")))
                End If
            End If
            'Comprador (Estandar)
            Dim sComprador As String = ""
            sComprador = EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SP")) & ", identificado(a) con " & EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SP") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SP")) & ", domiciliado(a) en " & EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Direccion_SP")) & UbigeoComprador1
            If IsDBNull(oGeneralBE.dtResult.Rows(0).Item("Nombre_SS")) = False Then
                sComprador = sComprador & " y " & EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SS")) & ", identificado(a) con " & EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SS") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SS")) & ", domiciliado(a) en " & EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Direccion_SS")) & UbigeoComprador2
            End If
            sComprador = sComprador & "; a quien(es) para efectos del presente se le(s) denominará(n) "

            ReplaceBookmarkText(objdoc, "DatosComprador", sComprador)
            'Otros Datos
            ReplaceBookmarkText(objdoc, "UnidadCatastral", EvaluaCelda("UC N° " + oGeneralBE.dtResult.Rows(0).Item("UnidadCatastral")))
            ReplaceBookmarkText(objdoc, "RegistroPredial", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("RegistroPredial")))
            ReplaceBookmarkText(objdoc, "Lote", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("LoteContrato")))
            ReplaceBookmarkText(objdoc, "Manzana", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ManzanaLote")))
            ReplaceBookmarkText(objdoc, "SuperficieLote", EvaluaCelda(Format(oGeneralBE.dtResult.Rows(0).Item("SuperficieLote"), "#,##0.00")))
            ReplaceBookmarkText(objdoc, "LinderoFrente", EvaluaCelda("por el frente, con " + oGeneralBE.dtResult.Rows(0).Item("LinderoFrente") + ", con " + Format(oGeneralBE.dtResult.Rows(0).Item("LongitudLinderoFrente"), "##0.00") + " ml."))
            ReplaceBookmarkText(objdoc, "LinderoDerecho", EvaluaCelda("por la derecha entrando, con " + oGeneralBE.dtResult.Rows(0).Item("LinderoDerecha") + ", con " + Format(oGeneralBE.dtResult.Rows(0).Item("LongitudLinderoDerecha"), "##0.00") + " ml."))
            ReplaceBookmarkText(objdoc, "LinderoIzquierdo", EvaluaCelda("por la izquierda entrando, con " + oGeneralBE.dtResult.Rows(0).Item("LinderoIzquierda") + ", con " + Format(oGeneralBE.dtResult.Rows(0).Item("LongitudLinderoIzquierda"), "##0.00") + " ml."))
            ReplaceBookmarkText(objdoc, "LinderoFondo", EvaluaCelda("por el fondo, con " + oGeneralBE.dtResult.Rows(0).Item("LinderoFondo") + ", con " + Format(oGeneralBE.dtResult.Rows(0).Item("LongitudLinderoFondo"), "##0.00") + " ml."))
            ReplaceBookmarkText(objdoc, "ImporteTotal", EvaluaCelda(sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ImporteTotal"), "###,##0.00")))
            ReplaceBookmarkText(objdoc, "ImporteTotalLetras", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ImporteTotalLetras")))
            ReplaceBookmarkText(objdoc, "nCuotas", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas").ToString))
            ReplaceBookmarkText(objdoc, "ImporteMora", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("ImporteMora")))
            ReplaceBookmarkText(objdoc, "TipoCambio", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("TipoCambio")))
            'Forma de Pago
            Dim sFormaDePago As String = ""
            Dim sDiaPago As String = oGeneralBE.dtResult.Rows(0).Item("DiaPago")
            Dim nCuotas As Integer = oGeneralBE.dtResult.Rows.Count - 1 'oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - IIf(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") = oGeneralBE.dtResult.Rows.Count, 0, 1)
            If oGeneralBE.dtResult.Rows(0).Item("PrimeraCuota") > 0 Then
                sFormaDePago = "de las cuales la primera cuota ascenderá a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("PrimeraCuota"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("PrimeraCuotaLetras") + "), y las siguientes " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - 1, "###") + " cuotas ascenderán a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") cada una"
            ElseIf oGeneralBE.dtResult.Rows(0).Item("ImporteTotal") / oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") = oGeneralBE.dtResult.Rows(0).Item("ImporteCuota") Then
                sFormaDePago = "las " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas"), "###") + " cuotas ascenderán a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") cada una"
            Else
                sFormaDePago = "de las cuales las primeras " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - 1, "###") + " cuotas ascenderán a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") cada una, y la última cuota ascenderá a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuota"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuotaLetras") + ")"
            End If
            sFormaDePago = sFormaDePago & ", todas pagaderos escalonadamente a los " + sDiaPago + " días de cada mes, según ANEXO Nº 01."
            ReplaceBookmarkText(objdoc, "FormaDePago", sFormaDePago) 'Forma de Pago Proyecto 1
            'Forma de Pago Proyectos 2 al 5
            If oGeneralBE.dtResult.Rows(0).Item("IdProyecto") > 1 Then
                sFormaDePago = ""
                If oGeneralBE.dtResult.Rows(0).Item("ImporteInicial") > 0 Then
                    sFormaDePago = "La cantidad de " & sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ImporteInicial"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("importeInicialLetras") + "), como cuota inicial, a la firma del presente contrato, que es entregado por EL(LA)(LOS) COMPRADOR(A)(ES) a EL VENDEDOR sin más constancia de la entrega y recepción que las firmas de los contratantes puestas en el presente contrato."
                    sFormaDePago = sFormaDePago & Chr(13)
                End If
                If oGeneralBE.dtResult.Rows(0).Item("ImporteInicial") = 0 Then
                    sFormaDePago = sFormaDePago & "La suma de " & sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ImporteSaldo"), "###,##0.00") + " serán canceladas en " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas"), "###") + " armadas mensuales, sujetas a caducidad de plazo "
                Else
                    sFormaDePago = sFormaDePago & "El saldo, que es la suma de " & sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ImporteSaldo"), "###,##0.00") + " serán canceladas en " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas"), "###") + " armadas mensuales, sujetas a caducidad de plazo " 'conforme a lo previsto en la cláusula vigésimo primera del presente, de las cuales las primeras " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - 1, "###") + " cuotas ascenderán a " + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") " + "cada una, y la última cuota ascenderá a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuota"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuotaLetras") + "), todas pagaderas escalonadamente a los " + sDiaPago + " días de cada mes, según ANEXO Nº 01."
                End If
                If oGeneralBE.dtResult.Rows(0).Item("IdProyecto") = 5 Then
                    sFormaDePago = sFormaDePago & "conforme a lo previsto en la cláusula vigésimo primera del presente"

                Else
                    sFormaDePago = sFormaDePago & "ante el incumplimiento de 03 cuotas consecutivas"
                End If
                If oGeneralBE.dtResult.Rows(0).Item("PrimeraCuota") > 0 Then
                    sFormaDePago = sFormaDePago & ", de las cuales la primera cuota ascenderá a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("PrimeraCuota"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("PrimeraCuotaLetras") + "), y las siguientes " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - 1, "###") + " cuotas ascenderán a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") cada una"
                Else
                    If oGeneralBE.dtResult.Rows(0).Item("ValorCuotas") = oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuota") Then
                        sFormaDePago = sFormaDePago & ", de las cuales las " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas"), "###") + " cuotas ascenderán a " + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") cada una"
                    Else
                        sFormaDePago = sFormaDePago & ", de las cuales las primeras " + Format(oGeneralBE.dtResult.Rows(0).Item("NumeroCuotas") - 1, "###") + " cuotas ascenderán a " + Format(oGeneralBE.dtResult.Rows(0).Item("ValorCuotas"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(0).Item("ValorCuotasLetras") + ") " + "cada una, y la última cuota ascenderá a " + sMoneda + Space(1) + Format(oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuota"), "###,##0.00") + " (" + oGeneralBE.dtResult.Rows(nCuotas).Item("ImporteCuotaLetras") + ")"
                    End If
                End If
                sFormaDePago = sFormaDePago & ", todas pagaderas escalonadamente a los " + sDiaPago + " días de cada mes, según ANEXO Nº 01."
                sFormaDePago = sFormaDePago & Chr(13) & "El  lugar de pago de todas las armadas será en el domicilio de EL VENDEDOR."
                ReplaceBookmarkText(objdoc, "FormaDePagoTextoCompleto", sFormaDePago) 'Forma de Pago Proyectos 2 al 5
            End If

            'Firmas
            ReplaceBookmarkText(objdoc, "LineaFirmaComprador1", EvaluaCelda("___________________________________________"))
            ReplaceBookmarkText(objdoc, "NombreComprador3", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SP") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SP")))
            ReplaceBookmarkText(objdoc, "DocumentoComprador3", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SP") + " N° " + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SP")))
            ReplaceBookmarkText(objdoc, "LineaFirmaComprador2", EvaluaCelda(IIf(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SS").ToString.Trim <> "", "___________________________________________", "")))
            ReplaceBookmarkText(objdoc, "NombreComprador4", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("Nombre_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoPaterno_SS") + Space(1) + oGeneralBE.dtResult.Rows(0).Item("ApellidoMaterno_SS")))
            Dim nDoc As String = IIf(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SS").ToString.Trim <> "", " N° ", "")
            ReplaceBookmarkText(objdoc, "DocumentoComprador4", EvaluaCelda(oGeneralBE.dtResult.Rows(0).Item("CodigoTipoDocumento_SS") + nDoc + oGeneralBE.dtResult.Rows(0).Item("NumeroDocumento_SS")))
            'Fecha Contrato
            Dim FechaContrato As Date = oGeneralBE.dtResult.Rows(0).Item("FechaEmision")
            ReplaceBookmarkText(objdoc, "FechaFirma", EvaluaCelda("el " + FechaContrato.Day.ToString + " de " + fnMes(FechaContrato.Month) + " del año " + FechaContrato.Year.ToString + "."))

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Function fnMes(ByVal Mes As Integer) As String
        Dim result As String = ""
        If Mes = 1 Then
            result = "Enero"
        ElseIf Mes = 2 Then
            result = "Febrero"
        ElseIf Mes = 3 Then
            result = "Marzo"
        ElseIf Mes = 4 Then
            result = "Abril"
        ElseIf Mes = 5 Then
            result = "Mayo"
        ElseIf Mes = 6 Then
            result = "Junio"
        ElseIf Mes = 7 Then
            result = "Julio"
        ElseIf Mes = 8 Then
            result = "Agosto"
        ElseIf Mes = 9 Then
            result = "Septiembre"
        ElseIf Mes = 10 Then
            result = "Octubre"
        ElseIf Mes = 11 Then
            result = "Noviembre"
        ElseIf Mes = 12 Then
            result = "Diciembre"
        End If
        Return result
    End Function

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim dgrItem As ContratoBE = CType(GridView1.GetRow(e.FocusedRowHandle), ContratoBE)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem.FechaCreacion
            ucpUsuario.FechaModificacion = dgrItem.FechaModificacion
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem.UsuarioCreacion).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem.UsuarioModificacion).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If

    End Sub

    Private Sub gcContratos_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gcContratos.DoubleClick
        bbiEditar.PerformClick()
    End Sub

    Private Sub bbiGenerarLetras_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiGenerarLetras.ItemClick
        Dim Message As String = ""
        Dim Caption As String = "Confirmación"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        If Not fnExisteLetras() Then
            Message = "No existen Letras asociadas al Contrato, desea crearlas?"
        Else
            If oGeneralBE.dtResult.Rows(0).Item("IdDocumentoContable") = Nothing Then
                Message = "Ya existen Letras asociadas al Contrato, desea actualizarlas?"
            Else
                Message = "Ya existen pagos asociados al Contrato."
                Caption = "Advertencia"
                Buttons = MessageBoxButtons.OK
            End If
        End If
        Dim Result As DialogResult
        Result = DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, Message, Caption, Buttons, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            oGeneralBE.SqlTxt = "EXEC upInsertarLetrasPorContrato " & oContratoBE.IdContrato.ToString & "," & IdUsuario
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            DevExpress.XtraEditors.XtraMessageBox.Show(Me.LookAndFeel, "Generación Satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function fnExisteLetras() As Boolean
        Dim bResult As Boolean = True
        If gcContratos.MainView.Name = "GridView1" Then
            oContratoBE = GridView1.GetFocusedRow
        Else
            oContratoBE = CardView1.GetFocusedRow
        End If
        oGeneralBE.SqlTxt = "SELECT TOP 1 ISNULL(IdDocumentoContable,0) IdDocumentoContable FROM Letra WHERE IdContrato = " & oContratoBE.IdContrato.ToString & " order by IdLetra"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        If oGeneralBE.dtResult.Rows.Count = 0 Then
            bResult = False
        End If
        Return bResult
    End Function

    Private Sub gcContratos_EmbeddedNavigator_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles gcContratos.EmbeddedNavigator.ButtonClick
        If e.Button.Hint = "Exportar a Excel" Then
            ExportarExcel(gcContratos)
        End If
    End Sub

    Private Sub frmContratos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        bbiActualizar.PerformClick()
    End Sub

    Private Sub bbiActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiActualizar.ItemClick
        PoblarGrillaContratos()
    End Sub
End Class