<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Entry))
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.lblCreateEntry = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCaptureVid = New System.Windows.Forms.Button()
        Me.btnUploadVid = New System.Windows.Forms.Button()
        Me.btnUploadPic = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtEntry = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHamburger
        '
        Me.btnHamburger.BackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.BackgroundImage = CType(resources.GetObject("btnHamburger.BackgroundImage"), System.Drawing.Image)
        Me.btnHamburger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburger.Location = New System.Drawing.Point(25, 25)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(27, 16)
        Me.btnHamburger.TabIndex = 7
        Me.btnHamburger.UseVisualStyleBackColor = False
        '
        'lblCreateEntry
        '
        Me.lblCreateEntry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCreateEntry.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateEntry.Font = New System.Drawing.Font("KG HAPPY Solid", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblCreateEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCreateEntry.Location = New System.Drawing.Point(2, 47)
        Me.lblCreateEntry.Name = "lblCreateEntry"
        Me.lblCreateEntry.Size = New System.Drawing.Size(795, 70)
        Me.lblCreateEntry.TabIndex = 10
        Me.lblCreateEntry.Text = "Create Entry"
        Me.lblCreateEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 300)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.White
        Me.btnPost.BackgroundImage = CType(resources.GetObject("btnPost.BackgroundImage"), System.Drawing.Image)
        Me.btnPost.FlatAppearance.BorderSize = 0
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.Font = New System.Drawing.Font("KG HAPPY Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Location = New System.Drawing.Point(593, 138)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(75, 75)
        Me.btnPost.TabIndex = 12
        Me.btnPost.Text = "Post"
        Me.btnPost.UseVisualStyleBackColor = False
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(147, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(425, 200)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'btnCaptureVid
        '
        Me.btnCaptureVid.BackColor = System.Drawing.Color.White
        Me.btnCaptureVid.BackgroundImage = CType(resources.GetObject("btnCaptureVid.BackgroundImage"), System.Drawing.Image)
        Me.btnCaptureVid.FlatAppearance.BorderSize = 0
        Me.btnCaptureVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaptureVid.Location = New System.Drawing.Point(460, 356)
        Me.btnCaptureVid.Name = "btnCaptureVid"
        Me.btnCaptureVid.Size = New System.Drawing.Size(30, 30)
        Me.btnCaptureVid.TabIndex = 16
        Me.btnCaptureVid.UseVisualStyleBackColor = False
        '
        'btnUploadVid
        '
        Me.btnUploadVid.BackColor = System.Drawing.Color.White
        Me.btnUploadVid.BackgroundImage = CType(resources.GetObject("btnUploadVid.BackgroundImage"), System.Drawing.Image)
        Me.btnUploadVid.FlatAppearance.BorderSize = 0
        Me.btnUploadVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadVid.Location = New System.Drawing.Point(500, 356)
        Me.btnUploadVid.Name = "btnUploadVid"
        Me.btnUploadVid.Size = New System.Drawing.Size(30, 30)
        Me.btnUploadVid.TabIndex = 17
        Me.btnUploadVid.UseVisualStyleBackColor = False
        '
        'btnUploadPic
        '
        Me.btnUploadPic.BackColor = System.Drawing.Color.White
        Me.btnUploadPic.BackgroundImage = CType(resources.GetObject("btnUploadPic.BackgroundImage"), System.Drawing.Image)
        Me.btnUploadPic.FlatAppearance.BorderSize = 0
        Me.btnUploadPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPic.Location = New System.Drawing.Point(540, 356)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(30, 30)
        Me.btnUploadPic.TabIndex = 18
        Me.btnUploadPic.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(149, 359)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(22, 25)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'txtEntry
        '
        Me.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEntry.Font = New System.Drawing.Font("Roboto Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtEntry.Location = New System.Drawing.Point(160, 149)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.Size = New System.Drawing.Size(400, 180)
        Me.txtEntry.TabIndex = 20
        Me.txtEntry.Text = "How's your day so far?"
        '
        'Add_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnUploadPic)
        Me.Controls.Add(Me.btnUploadVid)
        Me.Controls.Add(Me.btnCaptureVid)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCreateEntry)
        Me.Controls.Add(Me.btnHamburger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Entry"
        Me.Text = "Add_Entry"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHamburger As Button
    Friend WithEvents lblCreateEntry As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPost As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCaptureVid As Button
    Friend WithEvents btnUploadVid As Button
    Friend WithEvents btnUploadPic As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtEntry As RichTextBox
End Class
