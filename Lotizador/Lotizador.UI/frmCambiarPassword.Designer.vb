<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCambiarPassword))
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCopiaNuevoPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNuevoPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.grpLogin = New DevExpress.XtraEditors.GroupControl()
        Me.vpCambiarPassword = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.txtCopiaNuevoPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNuevoPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        CType(Me.vpCambiarPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.txtCopiaNuevoPassword)
        Me.panelControl1.Controls.Add(Me.LabelControl2)
        Me.panelControl1.Controls.Add(Me.txtNuevoPassword)
        Me.panelControl1.Controls.Add(Me.LabelControl1)
        Me.panelControl1.Controls.Add(Me.btnAceptar)
        Me.panelControl1.Controls.Add(Me.btnCancelar)
        Me.panelControl1.Controls.Add(Me.labelControl3)
        Me.panelControl1.Controls.Add(Me.txtPassword)
        Me.panelControl1.Controls.Add(Me.labelControl4)
        Me.panelControl1.Controls.Add(Me.txtUsuario)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelControl1.Location = New System.Drawing.Point(12, 30)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(334, 181)
        Me.panelControl1.TabIndex = 0
        '
        'txtCopiaNuevoPassword
        '
        Me.txtCopiaNuevoPassword.EditValue = ""
        Me.txtCopiaNuevoPassword.Location = New System.Drawing.Point(131, 89)
        Me.txtCopiaNuevoPassword.Name = "txtCopiaNuevoPassword"
        Me.txtCopiaNuevoPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCopiaNuevoPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtCopiaNuevoPassword.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Copiar Contraseña"
        '
        'txtNuevoPassword
        '
        Me.txtNuevoPassword.EditValue = ""
        Me.txtNuevoPassword.Location = New System.Drawing.Point(131, 63)
        Me.txtNuevoPassword.Name = "txtNuevoPassword"
        Me.txtNuevoPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevoPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtNuevoPassword.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Nueva Contraseña"
        '
        'btnAceptar
        '
        Me.btnAceptar.ImageOptions.Image = CType(resources.GetObject("btnAceptar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(68, 129)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(86, 33)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(172, 129)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 33)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(12, 14)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(91, 13)
        Me.labelControl3.TabIndex = 14
        Me.labelControl3.Text = "Nombre de Usuario"
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(131, 37)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(180, 20)
        Me.txtPassword.TabIndex = 1
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(13, 40)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(96, 13)
        Me.labelControl4.TabIndex = 15
        Me.labelControl4.Text = "Antigua Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(131, 11)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(180, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'grpLogin
        '
        Me.grpLogin.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpLogin.AppearanceCaption.Options.UseFont = True
        Me.grpLogin.Controls.Add(Me.panelControl1)
        Me.grpLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLogin.Location = New System.Drawing.Point(10, 10)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Padding = New System.Windows.Forms.Padding(10)
        Me.grpLogin.Size = New System.Drawing.Size(358, 223)
        Me.grpLogin.TabIndex = 0
        Me.grpLogin.Text = "Seguridad"
        '
        'vpCambiarPassword
        '
        Me.vpCambiarPassword.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'frmCambiarPassword
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(378, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCambiarPassword"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.txtCopiaNuevoPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNuevoPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Private WithEvents txtCopiaNuevoPassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtNuevoPassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents vpCambiarPassword As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
