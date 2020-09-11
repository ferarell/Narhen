Imports Lotizador.UI.LotizadorService
Imports DevExpress.XtraEditors.DXErrorProvider
Public Class frmBuscarSocio
    Dim oNarhemService As NarhenClient = New NarhenClient()
    Dim oView As New Object

    Private _oSocioBE As SocioBE
    Public Property oSocioBE() As SocioBE
        Get
            Return _oSocioBE
        End Get
        Set(ByVal value As SocioBE)
            _oSocioBE = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        PoblarGrillaSocios()
        If GridView1.RowCount > 0 Then
            btnAceptar.Enabled = True
            GridView1.Focus()
            Me.AcceptButton = btnAceptar
        End If
    End Sub

    Public Sub PoblarGrillaSocios()
        Dim oSocioBE As SocioBE = New SocioBE()

        If chkTipoDocumento.Checked Then
            If lueTipoDocumento.ItemIndex <> -1 Then
                oSocioBE.IdTipoDocumento = Me.lueTipoDocumento.Properties.GetDataSourceValue("IdTipoDocumento", lueTipoDocumento.ItemIndex).ToString()
            End If
            oSocioBE.NumeroDocumento = Me.txtUsuario.Text.Trim()
        End If

        If chkNombre.Checked Then
            oSocioBE.Nombre = Me.txtUsuario.Text.Trim()
        End If

        Dim listSocios As List(Of SocioBE) = New List(Of SocioBE)(oNarhemService.ObtenerSocioPorCriterio(oSocioBE))
        Me.gcSocios.DataSource = listSocios
        oView = gcSocios.MainView.SourceRow
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If GridView1.GetFocusedValue <> Nothing Then
            oSocioBE = GridView1.GetFocusedRow()
        End If
    End Sub

    Private Sub PoblarTipoDocumento()
        Dim oTipoDocumentoBE As TipoDocumentoBE = New TipoDocumentoBE()
        oTipoDocumentoBE.Valorado = "N"
        Dim listTiposDocumento As List(Of TipoDocumentoBE) = New List(Of TipoDocumentoBE)(oNarhemService.ObtenerTipoDocumentoPorCriterio(oTipoDocumentoBE))
        Me.lueTipoDocumento.Properties.DataSource = listTiposDocumento
        Me.lueTipoDocumento.Properties.DisplayMember = "CodigoTipoDocumento"
        Me.lueTipoDocumento.Properties.ValueMember = "IdTipoDocumento"
    End Sub
    Private Sub frmBuscarSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnBuscar
        btnAceptar.Enabled = False
        PoblarTipoDocumento()
    End Sub
  
    Private Sub gcSocios_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gcSocios.DoubleClick
        If btnAceptar.Enabled Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Me.AcceptButton = btnBuscar
    End Sub

    Private Sub gcSocios_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles gcSocios.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lueTipoDocumento_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles lueTipoDocumento.KeyPress
        chkTipoDocumento.Checked = True
    End Sub
End Class