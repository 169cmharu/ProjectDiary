<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camera
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Camera))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonCAMERA = New System.Windows.Forms.Button()
        Me.ButtonVIDEO = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonPHOTO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownFPS = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownBRT = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(26, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 400)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Minimize
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(725, 25)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 13
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Close
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(755, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 14
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(637, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 75)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Exit Camera"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ButtonCAMERA
        '
        Me.ButtonCAMERA.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCAMERA.BackgroundImage = CType(resources.GetObject("ButtonCAMERA.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCAMERA.FlatAppearance.BorderSize = 0
        Me.ButtonCAMERA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCAMERA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCAMERA.ForeColor = System.Drawing.Color.White
        Me.ButtonCAMERA.Location = New System.Drawing.Point(715, 120)
        Me.ButtonCAMERA.Name = "ButtonCAMERA"
        Me.ButtonCAMERA.Size = New System.Drawing.Size(75, 75)
        Me.ButtonCAMERA.TabIndex = 12
        Me.ButtonCAMERA.Text = "Camera"
        Me.ButtonCAMERA.UseVisualStyleBackColor = False
        '
        'ButtonVIDEO
        '
        Me.ButtonVIDEO.BackColor = System.Drawing.Color.Transparent
        Me.ButtonVIDEO.BackgroundImage = CType(resources.GetObject("ButtonVIDEO.BackgroundImage"), System.Drawing.Image)
        Me.ButtonVIDEO.FlatAppearance.BorderSize = 0
        Me.ButtonVIDEO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVIDEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVIDEO.ForeColor = System.Drawing.Color.White
        Me.ButtonVIDEO.Location = New System.Drawing.Point(715, 284)
        Me.ButtonVIDEO.Name = "ButtonVIDEO"
        Me.ButtonVIDEO.Size = New System.Drawing.Size(75, 75)
        Me.ButtonVIDEO.TabIndex = 15
        Me.ButtonVIDEO.Text = "Video"
        Me.ButtonVIDEO.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.playingbutton
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(636, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "STOP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonPHOTO
        '
        Me.ButtonPHOTO.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPHOTO.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.medium_button
        Me.ButtonPHOTO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPHOTO.FlatAppearance.BorderSize = 0
        Me.ButtonPHOTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonPHOTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ButtonPHOTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPHOTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPHOTO.ForeColor = System.Drawing.Color.White
        Me.ButtonPHOTO.Location = New System.Drawing.Point(676, 394)
        Me.ButtonPHOTO.Name = "ButtonPHOTO"
        Me.ButtonPHOTO.Size = New System.Drawing.Size(94, 27)
        Me.ButtonPHOTO.TabIndex = 18
        Me.ButtonPHOTO.Text = "Capture"
        Me.ButtonPHOTO.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(660, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "FPS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(660, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "BRT"
        '
        'NumericUpDownFPS
        '
        Me.NumericUpDownFPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.NumericUpDownFPS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDownFPS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NumericUpDownFPS.Location = New System.Drawing.Point(703, 214)
        Me.NumericUpDownFPS.Name = "NumericUpDownFPS"
        Me.NumericUpDownFPS.Size = New System.Drawing.Size(61, 16)
        Me.NumericUpDownFPS.TabIndex = 16
        Me.NumericUpDownFPS.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'NumericUpDownBRT
        '
        Me.NumericUpDownBRT.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.NumericUpDownBRT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDownBRT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NumericUpDownBRT.Location = New System.Drawing.Point(703, 240)
        Me.NumericUpDownBRT.Name = "NumericUpDownBRT"
        Me.NumericUpDownBRT.Size = New System.Drawing.Size(61, 16)
        Me.NumericUpDownBRT.TabIndex = 17
        Me.NumericUpDownBRT.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Camera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NumericUpDownBRT)
        Me.Controls.Add(Me.NumericUpDownFPS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonPHOTO)
        Me.Controls.Add(Me.ButtonVIDEO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCAMERA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Camera"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonCAMERA As Button
    Friend WithEvents ButtonVIDEO As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonPHOTO As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownFPS As NumericUpDown
    Friend WithEvents NumericUpDownBRT As NumericUpDown
End Class
