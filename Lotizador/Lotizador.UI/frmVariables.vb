Imports Lotizador.UI.LotizadorService
'Imports DevExpress.XtraEditors

Public Class frmVariables
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oVariableBE As VariableBE
    Dim oGeneralBE As New GeneralBE

    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        Dim dgrItem As DataRowView = GridView2.GetRow(e.FocusedRowHandle)
        If Not dgrItem Is Nothing Then
            ucpUsuario.FechaCreacion = dgrItem("FechaCreacion")
            ucpUsuario.FechaModificacion = dgrItem("FechaModificacion")
            ucpUsuario.UsuarioCreacion = General.ObtenerUsuario(dgrItem("UsuarioCreacion")).Cuenta
            ucpUsuario.UsuarioModificacion = General.ObtenerUsuario(dgrItem("UsuarioModificacion")).Cuenta
            ucpUsuario.pnlAuditoria.Refresh()
        End If
    End Sub

    Private Sub frmVariables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PoblarGrillaListaTablas()
    End Sub

    Public Sub PoblarGrillaListaTablas()
        Dim oGeneralBE As New GeneralBE
        oGeneralBE.SqlTxt = "EXEC VARIABLE_GET02 Null"
        oGeneralBE = oNarhemService.CommandText(oGeneralBE)
        Me.gcListaTablas.DataSource = oGeneralBE.dtResult
    End Sub

    Public Sub PoblarGrillaDetalleTabla()
        Dim oGeneralBE As New GeneralBE
        If GridView1.RowCount > 0 Then
            oGeneralBE.SqlTxt = "EXEC VARIABLE_GET02 '" & GridView1.GetFocusedValue & "'"
            oGeneralBE = oNarhemService.CommandText(oGeneralBE)
            Me.gcDetalleTabla.DataSource = oGeneralBE.dtResult
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        PoblarGrillaDetalleTabla()
    End Sub

End Class