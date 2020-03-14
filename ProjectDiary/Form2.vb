
Public Class Form2

    Private Sub CAPTURE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Me.TopMost = True

    End Sub

    Private Sub ButtonSAVE_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSAVE.Click
        ButtonSAVE.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.medium_buttonclicked
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
            MsgBox("Picture Saved!")
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class