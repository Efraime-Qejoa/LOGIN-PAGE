Imports MaterialSkin
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager = MaterialSkin.MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.TextShade., Accent.Orange700, MaterialSkin.TextShade.BLACK)
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        If txtUsername.Text = My.Settings.username And txtPassword.Text = My.Settings.password Then
            MsgBox("Welcome back", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("User not registered, kindly register", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        My.Settings.username = txtUsername.Text
        My.Settings.password = txtPassword.Text

        If cbRememberMe.Checked = False Then
            MsgBox("Please check the box", MsgBoxStyle.Information)
        Else
            My.Settings.Save()

            MsgBox("User is successfully registered, kindly proceed to logging in", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim newdetails As newdetails = New newdetails()
        newdetails.ShowDialog()
    End Sub
End Class
