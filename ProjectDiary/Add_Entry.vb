Public Class Add_Entry
    Private Sub Add_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCaptureVid_Click(sender As Object, e As EventArgs) Handles btnCaptureVid.Click
        Camera.Show()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class