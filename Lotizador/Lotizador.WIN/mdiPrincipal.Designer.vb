<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentosElectrónicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoletaFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarBFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnularBFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NCreditoNDebitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarCDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubirComprobantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.DocumentosElectrónicosToolStripMenuItem, Me.SubirComprobantesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1056, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.SeriesToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'SeriesToolStripMenuItem
        '
        Me.SeriesToolStripMenuItem.Name = "SeriesToolStripMenuItem"
        Me.SeriesToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SeriesToolStripMenuItem.Text = "Series"
        '
        'DocumentosElectrónicosToolStripMenuItem
        '
        Me.DocumentosElectrónicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoletaFacturaToolStripMenuItem, Me.NCreditoNDebitoToolStripMenuItem})
        Me.DocumentosElectrónicosToolStripMenuItem.Name = "DocumentosElectrónicosToolStripMenuItem"
        Me.DocumentosElectrónicosToolStripMenuItem.Size = New System.Drawing.Size(154, 20)
        Me.DocumentosElectrónicosToolStripMenuItem.Text = "Documentos Electrónicos"
        '
        'BoletaFacturaToolStripMenuItem
        '
        Me.BoletaFacturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarBFToolStripMenuItem, Me.AnularBFToolStripMenuItem})
        Me.BoletaFacturaToolStripMenuItem.Name = "BoletaFacturaToolStripMenuItem"
        Me.BoletaFacturaToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BoletaFacturaToolStripMenuItem.Text = "Boleta / Factura"
        '
        'GenerarBFToolStripMenuItem
        '
        Me.GenerarBFToolStripMenuItem.Name = "GenerarBFToolStripMenuItem"
        Me.GenerarBFToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.GenerarBFToolStripMenuItem.Text = "Generar"
        '
        'AnularBFToolStripMenuItem
        '
        Me.AnularBFToolStripMenuItem.Name = "AnularBFToolStripMenuItem"
        Me.AnularBFToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AnularBFToolStripMenuItem.Text = "Anular"
        '
        'NCreditoNDebitoToolStripMenuItem
        '
        Me.NCreditoNDebitoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarCDToolStripMenuItem1})
        Me.NCreditoNDebitoToolStripMenuItem.Name = "NCreditoNDebitoToolStripMenuItem"
        Me.NCreditoNDebitoToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.NCreditoNDebitoToolStripMenuItem.Text = "N. Credito / N. Debito"
        '
        'GenerarCDToolStripMenuItem1
        '
        Me.GenerarCDToolStripMenuItem1.Name = "GenerarCDToolStripMenuItem1"
        Me.GenerarCDToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.GenerarCDToolStripMenuItem1.Text = "Generar"
        '
        'SubirComprobantesToolStripMenuItem
        '
        Me.SubirComprobantesToolStripMenuItem.Name = "SubirComprobantesToolStripMenuItem"
        Me.SubirComprobantesToolStripMenuItem.Size = New System.Drawing.Size(128, 20)
        Me.SubirComprobantesToolStripMenuItem.Text = "Subir Comprobantes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 589)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mdiPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Venta de Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentosElectrónicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoletaFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarBFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnularBFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NCreditoNDebitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarCDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubirComprobantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
