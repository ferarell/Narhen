<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorCronograma
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
        Me.crvCronograma = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Cronograma1 = New Lotizador.UI.Cronograma()
        Me.SuspendLayout()
        '
        'crvCronograma
        '
        Me.crvCronograma.ActiveViewIndex = 0
        Me.crvCronograma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCronograma.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCronograma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvCronograma.Location = New System.Drawing.Point(0, 0)
        Me.crvCronograma.Name = "crvCronograma"
        Me.crvCronograma.ReportSource = Me.Cronograma1
        Me.crvCronograma.ReuseParameterValuesOnRefresh = True
        Me.crvCronograma.ShowGroupTreeButton = False
        Me.crvCronograma.Size = New System.Drawing.Size(666, 336)
        Me.crvCronograma.TabIndex = 1
        Me.crvCronograma.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmVisorCronograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 336)
        Me.Controls.Add(Me.crvCronograma)
        Me.Name = "frmVisorCronograma"
        Me.Text = "Cronograma"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvCronograma As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cronograma1 As Lotizador.UI.Cronograma
End Class
