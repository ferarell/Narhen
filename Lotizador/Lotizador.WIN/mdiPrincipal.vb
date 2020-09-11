Public Class mdiPrincipal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Dim result As DialogResult = MessageBox.Show("¿Seguro de salir de la aplicación?", "Sistema", MessageBoxButtons.YesNo)
        'If result = DialogResult.Yes Then
        '    'Application.Exit()
        '    Me.Close()
        'End If
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim myForm As New frmEmpresa
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub

    Private Sub mdiPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Dim result As DialogResult = MessageBox.Show("¿Seguro de salir de la aplicación?", "Sistema", MessageBoxButtons.YesNo)
        'If result = Windows.Forms.DialogResult.No Then
        '    e.Cancel = True
        'Else
        '    frmLogin.Close()
        'End If
    End Sub

    Private Sub GenerarBFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarBFToolStripMenuItem.Click
        Dim myForm As New frmLetras
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub

    Private Sub GenerarCDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GenerarCDToolStripMenuItem1.Click
        Dim myForm As New frmComprobanteBuscar("NotaGenerar")
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub

    Private Sub AnularBFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnularBFToolStripMenuItem.Click
        Dim myForm As New frmComprobanteBuscar("ComprobanteAnular")
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub

    Private Sub SeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeriesToolStripMenuItem.Click
        Dim myForm As New frmSerie
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub

    Private Sub SubirComprobantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubirComprobantesToolStripMenuItem.Click
        Dim myForm As New frmSubirComprobantes
        'myForm.MdiParent = Me
        myForm.Show()
    End Sub
End Class