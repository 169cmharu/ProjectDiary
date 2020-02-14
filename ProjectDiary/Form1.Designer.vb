<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.createEntry = New System.Windows.Forms.Button()
        Me.viewEntries = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'createEntry
        '
        Me.createEntry.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.createEntry.FlatAppearance.BorderSize = 0
        Me.createEntry.Font = New System.Drawing.Font("KG HAPPY Solid", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createEntry.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.createEntry.Location = New System.Drawing.Point(242, 203)
        Me.createEntry.Name = "createEntry"
        Me.createEntry.Size = New System.Drawing.Size(150, 150)
        Me.createEntry.TabIndex = 0
        Me.createEntry.Text = "Create Entry"
        Me.createEntry.UseVisualStyleBackColor = False
        '
        'viewEntries
        '
        Me.viewEntries.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.viewEntries.Font = New System.Drawing.Font("KG HAPPY Solid", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewEntries.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.viewEntries.Location = New System.Drawing.Point(412, 203)
        Me.viewEntries.Name = "viewEntries"
        Me.viewEntries.Size = New System.Drawing.Size(150, 150)
        Me.viewEntries.TabIndex = 1
        Me.viewEntries.Text = "View Entries"
        Me.viewEntries.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("KG HAPPY Solid", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(115, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 70)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "How have you been?"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("KG HAPPY Solid", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_time.Location = New System.Drawing.Point(6, 63)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(766, 44)
        Me.lbl_time.TabIndex = 3
        Me.lbl_time.Text = "09:12 PM"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("KG HAPPY Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_date.Location = New System.Drawing.Point(14, 38)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(758, 31)
        Me.lbl_date.TabIndex = 4
        Me.lbl_date.Text = "Jan 31"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.viewEntries)
        Me.Controls.Add(Me.createEntry)
        Me.Name = "Form1"
        Me.Text = "My Day"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents createEntry As Button
    Friend WithEvents viewEntries As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
End Class
