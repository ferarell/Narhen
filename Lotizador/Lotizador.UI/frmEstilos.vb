Imports DevExpress.LookAndFeel

Public Class frmEstilos

    Private Sub frmEstilos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each cnt In DevExpress.Skins.SkinManager.Default.Skins
            lbcEstilos.Items.Add(cnt.SkinName)
        Next
        lbcEstilos.SelectedValue = SkinName
    End Sub

    Private Sub lbcEstilos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbcEstilos.SelectedIndexChanged
        Dim skinName As String
        skinName = lbcEstilos.Text
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName)
        GuardarEstilo()
    End Sub
End Class