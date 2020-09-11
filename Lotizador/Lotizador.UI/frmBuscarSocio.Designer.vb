<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarSocio
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarSocio))
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lueTipoDocumento = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkNombre = New DevExpress.XtraEditors.CheckEdit()
        Me.chkTipoDocumento = New DevExpress.XtraEditors.CheckEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.imBarraAcciones16x16 = New System.Windows.Forms.ImageList(Me.components)
        Me.gcSocios = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.grpLogin = New DevExpress.XtraEditors.GroupControl()
        Me.vpCambiarPassword = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        CType(Me.vpCambiarPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.lueTipoDocumento)
        Me.panelControl1.Controls.Add(Me.chkNombre)
        Me.panelControl1.Controls.Add(Me.chkTipoDocumento)
        Me.panelControl1.Controls.Add(Me.btnBuscar)
        Me.panelControl1.Controls.Add(Me.gcSocios)
        Me.panelControl1.Controls.Add(Me.btnAceptar)
        Me.panelControl1.Controls.Add(Me.btnCancelar)
        Me.panelControl1.Controls.Add(Me.labelControl3)
        Me.panelControl1.Controls.Add(Me.txtUsuario)
        Me.panelControl1.Location = New System.Drawing.Point(9, 28)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(408, 266)
        Me.panelControl1.TabIndex = 0
        '
        'lueTipoDocumento
        '
        Me.lueTipoDocumento.Location = New System.Drawing.Point(130, 55)
        Me.lueTipoDocumento.Name = "lueTipoDocumento"
        Me.lueTipoDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueTipoDocumento.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTipoDocumento", "Id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoTipoDocumento", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.lueTipoDocumento.Properties.NullText = "Seleccione"
        Me.lueTipoDocumento.Size = New System.Drawing.Size(146, 20)
        Me.lueTipoDocumento.TabIndex = 2
        '
        'chkNombre
        '
        Me.chkNombre.EditValue = True
        Me.chkNombre.Location = New System.Drawing.Point(294, 56)
        Me.chkNombre.Name = "chkNombre"
        Me.chkNombre.Properties.Caption = "Nombre"
        Me.chkNombre.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.chkNombre.Properties.RadioGroupIndex = 1
        Me.chkNombre.Size = New System.Drawing.Size(75, 19)
        Me.chkNombre.TabIndex = 3
        '
        'chkTipoDocumento
        '
        Me.chkTipoDocumento.Location = New System.Drawing.Point(27, 56)
        Me.chkTipoDocumento.Name = "chkTipoDocumento"
        Me.chkTipoDocumento.Properties.Caption = "Tipo Documento"
        Me.chkTipoDocumento.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.chkTipoDocumento.Properties.RadioGroupIndex = 1
        Me.chkTipoDocumento.Size = New System.Drawing.Size(106, 19)
        Me.chkTipoDocumento.TabIndex = 1
        Me.chkTipoDocumento.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageOptions.Image = CType(resources.GetObject("btnBuscar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageOptions.ImageIndex = 11
        Me.btnBuscar.ImageOptions.ImageList = Me.imBarraAcciones16x16
        Me.btnBuscar.Location = New System.Drawing.Point(296, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(67, 24)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "&Buscar"
        '
        'imBarraAcciones16x16
        '
        Me.imBarraAcciones16x16.ImageStream = CType(resources.GetObject("imBarraAcciones16x16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imBarraAcciones16x16.TransparentColor = System.Drawing.Color.Transparent
        Me.imBarraAcciones16x16.Images.SetKeyName(0, "ic_save.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(1, "ic_edit.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(2, "ic_new.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(3, "ic_copy.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(4, "ic_delete2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(5, "ic_print.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(6, "ic_search2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(7, "ic_search3.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(8, "ic_undo.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(9, "ic_close.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(10, "ic_save.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(11, "ic_search2.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(12, "ic_print.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(13, "ic_search3.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(14, "ic_mntTablas16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(15, "ic_first16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(16, "ic_previus16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(17, "ic_next16x16.png")
        Me.imBarraAcciones16x16.Images.SetKeyName(18, "ic_last16x16.png")
        '
        'gcSocios
        '
        Me.gcSocios.Location = New System.Drawing.Point(15, 92)
        Me.gcSocios.MainView = Me.GridView1
        Me.gcSocios.Name = "gcSocios"
        Me.gcSocios.Size = New System.Drawing.Size(388, 118)
        Me.gcSocios.TabIndex = 4
        Me.gcSocios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.gcSocios
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "IdSocio"
        Me.GridColumn1.FieldName = "IdSocio"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ApellidoPaterno"
        Me.GridColumn3.FieldName = "ApellidoPaterno"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 120
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ApellidoMaterno"
        Me.GridColumn4.FieldName = "ApellidoMaterno"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 120
        '
        'btnAceptar
        '
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.ImageOptions.Image = CType(resources.GetObject("btnAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(116, 220)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 33)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(213, 220)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 33)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(91, 20)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(25, 13)
        Me.labelControl3.TabIndex = 14
        Me.labelControl3.Text = "Socio"
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(130, 17)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(146, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'grpLogin
        '
        Me.grpLogin.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpLogin.AppearanceCaption.Options.UseFont = True
        Me.grpLogin.Controls.Add(Me.panelControl1)
        Me.grpLogin.Location = New System.Drawing.Point(10, 12)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(422, 303)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.Text = "Busqueda Socios"
        '
        'vpCambiarPassword
        '
        Me.vpCambiarPassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'frmBuscarSocio
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(444, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.lueTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTipoDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSocios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        CType(Me.vpCambiarPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents grpLogin As DevExpress.XtraEditors.GroupControl
    Private WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents vpCambiarPassword As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents gcSocios As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkNombre As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkTipoDocumento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lueTipoDocumento As DevExpress.XtraEditors.LookUpEdit
    Private WithEvents imBarraAcciones16x16 As System.Windows.Forms.ImageList
End Class
