<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorLetras
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
        Me.crvLetras = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Letras1 = New Lotizador.UI.Letras()
        Me.SuspendLayout()
        '
        'crvLetras
        '
        Me.crvLetras.ActiveViewIndex = -1
        Me.crvLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvLetras.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvLetras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvLetras.Location = New System.Drawing.Point(0, 0)
        Me.crvLetras.Name = "crvLetras"
        Me.crvLetras.ReuseParameterValuesOnRefresh = True
        Me.crvLetras.ShowGroupTreeButton = False
        Me.crvLetras.Size = New System.Drawing.Size(836, 288)
        Me.crvLetras.TabIndex = 0
        Me.crvLetras.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmVisorLetras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 288)
        Me.Controls.Add(Me.crvLetras)
        Me.Name = "frmVisorLetras"
        Me.Text = "          "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvLetras As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Letras1 As Lotizador.UI.Letras
End Class
