<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.grpLogin = New DevExpress.XtraEditors.GroupControl()
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogin.SuspendLayout()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.btnAceptar)
        Me.panelControl1.Controls.Add(Me.btnCancelar)
        Me.panelControl1.Controls.Add(Me.labelControl3)
        Me.panelControl1.Controls.Add(Me.txtPassword)
        Me.panelControl1.Controls.Add(Me.labelControl4)
        Me.panelControl1.Controls.Add(Me.txtUsuario)
        Me.panelControl1.Location = New System.Drawing.Point(312, 44)
        Me.panelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(309, 257)
        Me.panelControl1.TabIndex = 10
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(20, 181)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(129, 49)
        Me.btnAceptar.TabIndex = 17
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(157, 181)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(129, 49)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "&Cancelar"
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(20, 20)
        Me.labelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(138, 19)
        Me.labelControl3.TabIndex = 14
        Me.labelControl3.Text = "Nombre de Usuario"
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(20, 129)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(270, 26)
        Me.txtPassword.TabIndex = 16
        '
        'labelControl4
        '
        Me.labelControl4.Location = New System.Drawing.Point(20, 101)
        Me.labelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.labelControl4.Name = "labelControl4"
        Me.labelControl4.Size = New System.Drawing.Size(79, 19)
        Me.labelControl4.TabIndex = 15
        Me.labelControl4.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.EditValue = ""
        Me.txtUsuario.Location = New System.Drawing.Point(20, 48)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(270, 26)
        Me.txtUsuario.TabIndex = 13
        '
        'grpLogin
        '
        Me.grpLogin.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grpLogin.AppearanceCaption.Options.UseFont = True
        Me.grpLogin.Controls.Add(Me.panelControl1)
        Me.grpLogin.Controls.Add(Me.pictureEdit1)
        Me.grpLogin.Location = New System.Drawing.Point(15, 18)
        Me.grpLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(656, 320)
        Me.grpLogin.TabIndex = 8
        Me.grpLogin.Text = "Seguridad"
        '
        'pictureEdit1
        '
        Me.pictureEdit1.EditValue = CType(resources.GetObject("pictureEdit1.EditValue"), Object)
        Me.pictureEdit1.Location = New System.Drawing.Point(16, 44)
        Me.pictureEdit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit1.Properties.Padding = New System.Windows.Forms.Padding(1)
        Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pictureEdit1.Size = New System.Drawing.Size(286, 257)
        Me.pictureEdit1.TabIndex = 9
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(686, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpLogin)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.panelControl1.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogin.ResumeLayout(False)
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents grpLogin As DevExpress.XtraEditors.GroupControl
    Private WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents labelControl4 As DevExpress.XtraEditors.LabelControl
    Private WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
End Class
