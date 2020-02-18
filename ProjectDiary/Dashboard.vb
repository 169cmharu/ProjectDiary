Public Class Dashboard
    Dim WithEvents aTimer As New System.Windows.Forms.Timer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        lbl_date.Text = DateTime.Now.ToString("MMM dd, yyyy")
        lbl_time.Text = DateTime.Now.ToString("h:mm tt")

        'Change Background Image According to Current Time'
        Dim current As Date = Date.Now
        Dim morning As New Date(current.Year, current.Month, current.Day, 6, 0, 0)
        Dim afternoon As New Date(current.Year, current.Month, current.Day, 15, 0, 0)
        Dim evening As New Date(current.Year, current.Month, current.Day, 18, 0, 0, 0)
        If (current >= morning) And (current <= afternoon) Then
            Me.BackgroundImage = My.Resources.early_bg
        ElseIf (current > afternoon) And (current <= evening) Then
            Me.BackgroundImage = My.Resources.afternoon_bg
        ElseIf (current > evening) And (current < morning) Then
            Me.BackgroundImage = My.Resources.projectDiaryBG
        End If


    End Sub

    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles MyBase.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub

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
End Class
