Imports MaterialSkin
Public Class newdetails
    Private Sub newdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Dim newPassword As String = txtNewPassword.Text
        Dim username As String = txtNewUsername.Text
        If username = My.Settings.username Then

            My.Settings.password = newPassword
            MsgBox("Details successfully updated", MsgBoxStyle.Information)
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("User not registered on system please type in your current username or create new account", MsgBoxStyle.Information)
        End If





    End Sub
End Class