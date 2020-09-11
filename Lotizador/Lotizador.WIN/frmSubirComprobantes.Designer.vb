<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubirComprobantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSeleccionarCarpeta = New System.Windows.Forms.Button()
        Me.lblCarpeta = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSubirArchivos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSeleccionarCarpeta
        '
        Me.btnSeleccionarCarpeta.Location = New System.Drawing.Point(12, 12)
        Me.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta"
        Me.btnSeleccionarCarpeta.Size = New System.Drawing.Size(150, 30)
        Me.btnSeleccionarCarpeta.TabIndex = 0
        Me.btnSeleccionarCarpeta.Text = "Seleccionar Directorio "
        Me.btnSeleccionarCarpeta.UseVisualStyleBackColor = True
        '
        'lblCarpeta
        '
        Me.lblCarpeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCarpeta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCarpeta.Location = New System.Drawing.Point(169, 16)
        Me.lblCarpeta.Name = "lblCarpeta"
        Me.lblCarpeta.Size = New System.Drawing.Size(483, 23)
        Me.lblCarpeta.TabIndex = 1
        Me.lblCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSubirArchivos
        '
        Me.btnSubirArchivos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSubirArchivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubirArchivos.Location = New System.Drawing.Point(502, 56)
        Me.btnSubirArchivos.Name = "btnSubirArchivos"
        Me.btnSubirArchivos.Size = New System.Drawing.Size(150, 30)
        Me.btnSubirArchivos.TabIndex = 2
        Me.btnSubirArchivos.Text = "SUBIR ARCHIVOS"
        Me.btnSubirArchivos.UseVisualStyleBackColor = False
        '
        'frmSubirComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 109)
        Me.Controls.Add(Me.btnSubirArchivos)
        Me.Controls.Add(Me.lblCarpeta)
        Me.Controls.Add(Me.btnSeleccionarCarpeta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSubirComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir Comprobantes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSeleccionarCarpeta As System.Windows.Forms.Button
    Friend WithEvents lblCarpeta As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSubirArchivos As System.Windows.Forms.Button
End Class
