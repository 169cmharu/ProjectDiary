<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.createEntry = New System.Windows.Forms.Button()
        Me.viewEntries = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'createEntry
        '
        Me.createEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.createEntry.FlatAppearance.BorderSize = 0
        Me.createEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createEntry.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!, System.Drawing.FontStyle.Bold)
        Me.createEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.createEntry.Location = New System.Drawing.Point(256, 240)
        Me.createEntry.Name = "createEntry"
        Me.createEntry.Size = New System.Drawing.Size(125, 125)
        Me.createEntry.TabIndex = 0
        Me.createEntry.Text = "Create Entry"
        Me.createEntry.UseVisualStyleBackColor = False
        '
        'viewEntries
        '
        Me.viewEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.viewEntries.FlatAppearance.BorderSize = 0
        Me.viewEntries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewEntries.Font = New System.Drawing.Font("KG HAPPY Solid", 16.0!)
        Me.viewEntries.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.viewEntries.Location = New System.Drawing.Point(406, 240)
        Me.viewEntries.Name = "viewEntries"
        Me.viewEntries.Size = New System.Drawing.Size(125, 125)
        Me.viewEntries.TabIndex = 1
        Me.viewEntries.Text = "View Entries"
        Me.viewEntries.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("KG HAPPY Solid", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(20, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(752, 70)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How have you been?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("KG HAPPY Solid", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_time.Location = New System.Drawing.Point(6, 79)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(766, 44)
        Me.lbl_time.TabIndex = 3
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("KG HAPPY Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_date.Location = New System.Drawing.Point(6, 58)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(766, 31)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHamburger
        '
        Me.btnHamburger.BackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.BackgroundImage = CType(resources.GetObject("btnHamburger.BackgroundImage"), System.Drawing.Image)
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburger.Location = New System.Drawing.Point(25, 25)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(27, 16)
        Me.btnHamburger.TabIndex = 5
        Me.btnHamburger.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Close
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(740, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 6
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.Minimize
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(710, 23)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimize.TabIndex = 7
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProjectDiary.My.Resources.Resources.projectDiaryBG
        Me.ClientSize = New System.Drawing.Size(784, 436)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnHamburger)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewEntries)
        Me.Controls.Add(Me.createEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "My Day"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents createEntry As Button
    Friend WithEvents viewEntries As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents btnHamburger As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
End Class
