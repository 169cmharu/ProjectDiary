Public Class Login
    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        With btnClose
            .BackgroundImage = My.Resources.Close
        End With
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        With btnClose
            .BackgroundImage = My.Resources.close_clicked1
        End With
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        With btnClose
            .BackgroundImage = My.Resources.close_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseHover(sender As Object, e As EventArgs) Handles btnMinimize.MouseHover
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        With btnMinimize
            .BackgroundImage = My.Resources.Minimize
        End With
    End Sub

    Private Sub btnMinimize_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseDown
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_clicked
        End With
    End Sub

    Private Sub btnMinimize_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMinimize.MouseUp
        With btnMinimize
            .BackgroundImage = My.Resources.minimize_hover
        End With
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseDown
        With btnLogin
            .BackgroundImage = My.Resources.long_button_clicked
        End With
    End Sub

    Private Sub btnLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseUp
        With btnLogin
            .BackgroundImage = My.Resources.long_button
        End With
    End Sub

    Private Sub tboxUsername_Enter(sender As Object, e As EventArgs) Handles tboxUsername.Enter
        If tboxUsername.Text = "Username" Then
            tboxUsername.Text = ""
        End If
    End Sub

    Private Sub tboxUsername_Leave(sender As Object, e As EventArgs) Handles tboxUsername.Leave
        If tboxUsername.Text = "" Then
            tboxUsername.Text = "Username"
        End If
    End Sub

    Private Sub tboxPassword_Enter(sender As Object, e As EventArgs) Handles tboxPassword.Enter
        If tboxPassword.Text = "Password" Then
            tboxPassword.Text = ""
            tboxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub tboxPassword_Leave(sender As Object, e As EventArgs) Handles tboxPassword.Leave
        If tboxPassword.Text = "" Then
            tboxPassword.Text = "Password"
            tboxPassword.PasswordChar = ""
        End If
    End Sub
End Class