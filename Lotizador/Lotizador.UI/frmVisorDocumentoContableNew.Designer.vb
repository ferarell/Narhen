<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorDocumentoContableNew
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
        Me.crvDocumentoContable = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DocumentoContable1 = New Lotizador.UI.DocumentoContable()
        Me.SuspendLayout()
        '
        'crvDocumentoContable
        '
        Me.crvDocumentoContable.ActiveViewIndex = 0
        Me.crvDocumentoContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvDocumentoContable.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvDocumentoContable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvDocumentoContable.Location = New System.Drawing.Point(0, 0)
        Me.crvDocumentoContable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crvDocumentoContable.Name = "crvDocumentoContable"
        Me.crvDocumentoContable.ReportSource = Me.DocumentoContable1
        Me.crvDocumentoContable.ReuseParameterValuesOnRefresh = True
        Me.crvDocumentoContable.ShowGroupTreeButton = False
        Me.crvDocumentoContable.Size = New System.Drawing.Size(1028, 506)
        Me.crvDocumentoContable.TabIndex = 1
        Me.crvDocumentoContable.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmVisorDocumentoContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 506)
        Me.Controls.Add(Me.crvDocumentoContable)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVisorDocumentoContable"
        Me.Text = "Documento Contable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvDocumentoContable As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DocumentoContable1 As Lotizador.UI.DocumentoContable
End Class
