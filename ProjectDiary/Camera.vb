Imports AForge.Video
Imports Accord.Video.FFMPEG
Imports AForge.Video.DirectShow
Imports DirectX.Capture
Imports System.IO

Public Class Camera

    Dim CAMERA As VideoCaptureDevice 'THE CAMERA WHAT WE ARE USING
    Dim BMP As Bitmap 'FOR IMAGE GENERATION
    Dim WRITER As New VideoFileWriter() 'SAVE THE IMAGES IN MEMORY
    Public cap As Capture
    Public f As Filters

    Private Sub Camera_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom ' IF WE FORGET TO ADJUST THE PICTUREBOX
        Button2.Hide()
        Button1.Hide()

    End Sub

    Private Sub ButtonCAMERA_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCAMERA.Click
        ButtonCAMERA.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.big_button_clicked
        Dim CAMERAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()

        If CAMERAS.ShowDialog() = DialogResult.OK Then
            CAMERA = CAMERAS.VideoDevice 'CAMERA CHOSEN
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURES) ' IT WILL EXECUTE EVERY TIME AN IMAGE IS GENERATED
            CAMERA.Start() 'START THE SUBMISSION OF IMAGES AT THE PICTUREBOX
            ButtonCAMERA.Text = "Capturing"
            Button2.Show()
            Button1.Hide()
            ButtonVIDEO.Hide()
        End If


    End Sub

    Private Sub ButtonVIDEO_Click(ByVal sender As System.Object, e As System.EventArgs) Handles ButtonVIDEO.Click
        ButtonVIDEO.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.big_button_clicked
        Button1.Show()
        Dim Filename As String = "c:\folder\MyFile" 'papalitan
        Dim i As Integer = 0
        Dim extension As String = ".mp4"
        Dim path As String = Filename & extension

        f = New Filters
        cap = New Capture(f.VideoInputDevices(0), f.AudioInputDevices(0))
        cap.PreviewWindow = PictureBox1

        If ButtonVIDEO.BackColor = Color.Black Then
            If File.Exists(path) Then
                Do
                    i = i + 1
                    path = Filename & i.ToString() & extension
                Loop While File.Exists(path)
            End If

            cap.Filename = path
            cap.Cue()
            cap.Start()
            'ButtonVIDEO.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.playingbutton
            ButtonPHOTO.Hide()

        End If
    End Sub

    Private Sub CAPTURES(sender As Object, eventArgs As NewFrameEventArgs)
        If ButtonVIDEO.BackColor = Color.Black Then 'IF YOU ARE NOT RECORDING...
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PUT THE DATA IN THE BITMAP
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'THE PRESENTS IN THE PICTURE BOX
        Else ' IF YOU ARE RECORDING...
            Try
                BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PUT THE DATA IN THE BITMAP
                PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'THE PRESENTS IN THE PICTURE BOX
                WRITER.WriteVideoFrame(BMP) 'KEEP THEM IN THE MEMORY
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ButtonPHOTO_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPHOTO.Click
        ButtonPHOTO.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.medium_buttonclicked
        Form2.PictureBox1.Image = PictureBox1.Image 'COPY THE IMAGE IN THE PICTURE BOX
        Form2.Show() 'SHOW THE CAPTURE FORM
    End Sub

    'Private Sub ButtonCLOSE_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCLOSE.Click
    '    Me.Close()
    'End Sub

    Private Sub camera_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CAMERA.Stop() 'CLOSE THE CAMERA
            WRITER.Close() 'STOP SAVING DATA
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ButtonVIDEO.BackColor = Color.Black
        ButtonVIDEO.Text = "VIDEO"
        Button1.Hide()
        cap.Stop()
        cap.Dispose()
        ButtonPHOTO.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.big_button_clicked
        CAMERA.Stop()
        ButtonCAMERA.Text = "CAMERA"
        Button2.Hide()
        ButtonVIDEO.Show()
    End Sub

    Private Sub NumericUpDownFPS_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownFPS.ValueChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class