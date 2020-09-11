<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuentaOld
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
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lueCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.lueLote = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.sbVerReporte = New DevExpress.XtraEditors.SimpleButton()
        Me.crvEstadoCuenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.EstadoCuentaContrato1 = New Lotizador.UI.EstadoCuentaContrato()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.crvEstadoCuenta)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(938, 397)
        Me.SplitContainerControl1.SplitterPosition = 43
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'lueCliente
        '
        Me.lueCliente.Location = New System.Drawing.Point(66, 11)
        Me.lueCliente.Name = "lueCliente"
        Me.lueCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Cliente"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdSocio", "IdSocio", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueCliente.Properties.NullText = "Seleccione"
        Me.lueCliente.Size = New System.Drawing.Size(336, 20)
        Me.lueCliente.TabIndex = 4
        '
        'lueLote
        '
        Me.lueLote.Location = New System.Drawing.Point(455, 11)
        Me.lueLote.Name = "lueLote"
        Me.lueLote.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLote.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ManzanaLote", "Lote"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdContrato", "IdContrato", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lueLote.Properties.NullText = "Seleccione"
        Me.lueLote.Size = New System.Drawing.Size(73, 20)
        Me.lueLote.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(428, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Lote"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(27, 14)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(33, 13)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Cliente"
        '
        'sbVerReporte
        '
        Me.sbVerReporte.Location = New System.Drawing.Point(2, 2)
        Me.sbVerReporte.Margin = New System.Windows.Forms.Padding(3, 3, 100, 3)
        Me.sbVerReporte.Name = "sbVerReporte"
        Me.sbVerReporte.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.sbVerReporte.Size = New System.Drawing.Size(105, 23)
        Me.sbVerReporte.TabIndex = 2
        Me.sbVerReporte.Text = "Ver Reporte"
        '
        'crvEstadoCuenta
        '
        Me.crvEstadoCuenta.ActiveViewIndex = -1
        Me.crvEstadoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvEstadoCuenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvEstadoCuenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvEstadoCuenta.Location = New System.Drawing.Point(0, 0)
        Me.crvEstadoCuenta.Name = "crvEstadoCuenta"
        Me.crvEstadoCuenta.ShowGroupTreeButton = False
        Me.crvEstadoCuenta.Size = New System.Drawing.Size(934, 345)
        Me.crvEstadoCuenta.TabIndex = 0
        Me.crvEstadoCuenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.sbVerReporte)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(825, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(109, 43)
        Me.PanelControl1.TabIndex = 6
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl2.Controls.Add(Me.lueCliente)
        Me.PanelControl2.Controls.Add(Me.lblCliente)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.lueLote)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(825, 43)
        Me.PanelControl2.TabIndex = 7
        '
        'frmEstadoCuentaOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 397)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "frmEstadoCuentaOld"
        Me.Text = "Estado de Cuenta"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.lueCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents sbVerReporte As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents crvEstadoCuenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueLote As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents EstadoCuentaContrato1 As Lotizador.UI.EstadoCuentaContrato
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
