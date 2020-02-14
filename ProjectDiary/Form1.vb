Public Class Form1
    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        lbl_date.Text = DateTime.Now.ToString("MMM dd, yyyy")
        lbl_time.Text = DateTime.Now.ToString("h:mm tt")
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub
End Class
