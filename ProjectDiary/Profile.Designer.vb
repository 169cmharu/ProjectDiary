<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblBdayHolder = New System.Windows.Forms.Label()
        Me.lblAgeHolder = New System.Windows.Forms.Label()
        Me.lblBTypeHolder = New System.Windows.Forms.Label()
        Me.lblAccountCreateHolder = New System.Windows.Forms.Label()
        Me.lblEntryCountHolder = New System.Windows.Forms.Label()
        Me.lblMemoryCountHolder = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnMinimize.TabIndex = 9
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
        Me.btnClose.TabIndex = 10
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblProfile
        '
        Me.lblProfile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProfile.BackColor = System.Drawing.Color.Transparent
        Me.lblProfile.Font = New System.Drawing.Font("KG HAPPY Solid", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.lblProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProfile.Location = New System.Drawing.Point(3, 47)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(795, 70)
        Me.lblProfile.TabIndex = 11
        Me.lblProfile.Text = "Profile"
        Me.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(575, 300)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.Font = New System.Drawing.Font("KG HAPPY Solid", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(113, 204)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(575, 30)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Harold Abejaron"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(113, 230)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(575, 23)
        Me.lblUsername.TabIndex = 14
        Me.lblUsername.Text = "169cmharu"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("KG HAPPY Solid", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(113, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Personal Info"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("KG HAPPY Solid", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(400, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Account Info"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(169, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Birthday:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(169, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(169, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Blood Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(431, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Account Created:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(431, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Entry Count:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(431, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Memory Count:"
        '
        'lblBdayHolder
        '
        Me.lblBdayHolder.AutoSize = True
        Me.lblBdayHolder.BackColor = System.Drawing.Color.White
        Me.lblBdayHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblBdayHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblBdayHolder.Location = New System.Drawing.Point(253, 295)
        Me.lblBdayHolder.Name = "lblBdayHolder"
        Me.lblBdayHolder.Size = New System.Drawing.Size(80, 18)
        Me.lblBdayHolder.TabIndex = 23
        Me.lblBdayHolder.Text = "Oct 21, 1998"
        '
        'lblAgeHolder
        '
        Me.lblAgeHolder.AutoSize = True
        Me.lblAgeHolder.BackColor = System.Drawing.Color.White
        Me.lblAgeHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblAgeHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblAgeHolder.Location = New System.Drawing.Point(253, 315)
        Me.lblAgeHolder.Name = "lblAgeHolder"
        Me.lblAgeHolder.Size = New System.Drawing.Size(22, 18)
        Me.lblAgeHolder.TabIndex = 24
        Me.lblAgeHolder.Text = "21"
        '
        'lblBTypeHolder
        '
        Me.lblBTypeHolder.AutoSize = True
        Me.lblBTypeHolder.BackColor = System.Drawing.Color.White
        Me.lblBTypeHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblBTypeHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblBTypeHolder.Location = New System.Drawing.Point(253, 335)
        Me.lblBTypeHolder.Name = "lblBTypeHolder"
        Me.lblBTypeHolder.Size = New System.Drawing.Size(17, 18)
        Me.lblBTypeHolder.TabIndex = 25
        Me.lblBTypeHolder.Text = "O"
        '
        'lblAccountCreateHolder
        '
        Me.lblAccountCreateHolder.AutoSize = True
        Me.lblAccountCreateHolder.BackColor = System.Drawing.Color.White
        Me.lblAccountCreateHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblAccountCreateHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblAccountCreateHolder.Location = New System.Drawing.Point(544, 295)
        Me.lblAccountCreateHolder.Name = "lblAccountCreateHolder"
        Me.lblAccountCreateHolder.Size = New System.Drawing.Size(81, 18)
        Me.lblAccountCreateHolder.TabIndex = 26
        Me.lblAccountCreateHolder.Text = "Mar 10, 2020"
        '
        'lblEntryCountHolder
        '
        Me.lblEntryCountHolder.AutoSize = True
        Me.lblEntryCountHolder.BackColor = System.Drawing.Color.White
        Me.lblEntryCountHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblEntryCountHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblEntryCountHolder.Location = New System.Drawing.Point(544, 315)
        Me.lblEntryCountHolder.Name = "lblEntryCountHolder"
        Me.lblEntryCountHolder.Size = New System.Drawing.Size(15, 18)
        Me.lblEntryCountHolder.TabIndex = 27
        Me.lblEntryCountHolder.Text = "0"
        '
        'lblMemoryCountHolder
        '
        Me.lblMemoryCountHolder.AutoSize = True
        Me.lblMemoryCountHolder.BackColor = System.Drawing.Color.White
        Me.lblMemoryCountHolder.Font = New System.Drawing.Font("Roboto", 9.75!)
        Me.lblMemoryCountHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblMemoryCountHolder.Location = New System.Drawing.Point(544, 335)
        Me.lblMemoryCountHolder.Name = "lblMemoryCountHolder"
        Me.lblMemoryCountHolder.Size = New System.Drawing.Size(15, 18)
        Me.lblMemoryCountHolder.TabIndex = 28
        Me.lblMemoryCountHolder.Text = "0"
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMemoryCountHolder)
        Me.Controls.Add(Me.lblEntryCountHolder)
        Me.Controls.Add(Me.lblAccountCreateHolder)
        Me.Controls.Add(Me.lblBTypeHolder)
        Me.Controls.Add(Me.lblAgeHolder)
        Me.Controls.Add(Me.lblBdayHolder)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnHamburger)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHamburger As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblProfile As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblBdayHolder As Label
    Friend WithEvents lblAgeHolder As Label
    Friend WithEvents lblBTypeHolder As Label
    Friend WithEvents lblAccountCreateHolder As Label
    Friend WithEvents lblEntryCountHolder As Label
    Friend WithEvents lblMemoryCountHolder As Label
End Class
