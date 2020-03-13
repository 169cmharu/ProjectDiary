<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Forms Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The Windows Forms Designer needs the following procedure
    'It can be modified using the Windows Forms Designer.
    'Do Not modify it with the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonCAMERA = New System.Windows.Forms.Button()
        Me.ButtonPHOTO = New System.Windows.Forms.Button()
        Me.ButtonVIDEO = New System.Windows.Forms.Button()
        Me.ButtonCLOSE = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NumericUpDownFPS = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownBRT = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonCAMERA
        '
        Me.ButtonCAMERA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCAMERA.BackColor = System.Drawing.Color.Black
        Me.ButtonCAMERA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonCAMERA.Location = New System.Drawing.Point(668, 10)
        Me.ButtonCAMERA.Name = "ButtonCAMERA"
        Me.ButtonCAMERA.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCAMERA.TabIndex = 1
        Me.ButtonCAMERA.Text = "CAMERA"
        Me.ButtonCAMERA.UseVisualStyleBackColor = False
        '
        'ButtonPHOTO
        '
        Me.ButtonPHOTO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPHOTO.BackColor = System.Drawing.Color.Black
        Me.ButtonPHOTO.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonPHOTO.Location = New System.Drawing.Point(668, 395)
        Me.ButtonPHOTO.Name = "ButtonPHOTO"
        Me.ButtonPHOTO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonPHOTO.TabIndex = 2
        Me.ButtonPHOTO.Text = "CAPTURE"
        Me.ButtonPHOTO.UseVisualStyleBackColor = False
        '
        'ButtonVIDEO
        '
        Me.ButtonVIDEO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVIDEO.BackColor = System.Drawing.Color.Black
        Me.ButtonVIDEO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonVIDEO.Location = New System.Drawing.Point(668, 159)
        Me.ButtonVIDEO.Name = "ButtonVIDEO"
        Me.ButtonVIDEO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonVIDEO.TabIndex = 3
        Me.ButtonVIDEO.Text = "VIDEO"
        Me.ButtonVIDEO.UseVisualStyleBackColor = False
        '
        'ButtonCLOSE
        '
        Me.ButtonCLOSE.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCLOSE.BackColor = System.Drawing.Color.Black
        Me.ButtonCLOSE.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCLOSE.Location = New System.Drawing.Point(668, 450)
        Me.ButtonCLOSE.Name = "ButtonCLOSE"
        Me.ButtonCLOSE.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCLOSE.TabIndex = 4
        Me.ButtonCLOSE.Text = "CLOSE"
        Me.ButtonCLOSE.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        '
        'NumericUpDownFPS
        '
        Me.NumericUpDownFPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownFPS.BackColor = System.Drawing.Color.Black
        Me.NumericUpDownFPS.ForeColor = System.Drawing.Color.Yellow
        Me.NumericUpDownFPS.Location = New System.Drawing.Point(728, 87)
        Me.NumericUpDownFPS.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDownFPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownFPS.Name = "NumericUpDownFPS"
        Me.NumericUpDownFPS.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownFPS.TabIndex = 5
        Me.NumericUpDownFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownFPS.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(665, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "FPS"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(665, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "BRT"
        '
        'NumericUpDownBRT
        '
        Me.NumericUpDownBRT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDownBRT.BackColor = System.Drawing.Color.Black
        Me.NumericUpDownBRT.ForeColor = System.Drawing.Color.Yellow
        Me.NumericUpDownBRT.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDownBRT.Location = New System.Drawing.Point(728, 121)
        Me.NumericUpDownBRT.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDownBRT.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDownBRT.Name = "NumericUpDownBRT"
        Me.NumericUpDownBRT.Size = New System.Drawing.Size(80, 22)
        Me.NumericUpDownBRT.TabIndex = 7
        Me.NumericUpDownBRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownBRT.Value = New Decimal(New Integer() {300, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(668, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "STOP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(706, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "EXIT CAMERA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(820, 502)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDownBRT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownFPS)
        Me.Controls.Add(Me.ButtonCLOSE)
        Me.Controls.Add(Me.ButtonVIDEO)
        Me.Controls.Add(Me.ButtonPHOTO)
        Me.Controls.Add(Me.ButtonCAMERA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WEBCAM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownFPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonCAMERA As System.Windows.Forms.Button
    Friend WithEvents ButtonPHOTO As System.Windows.Forms.Button
    Friend WithEvents ButtonVIDEO As System.Windows.Forms.Button
    Friend WithEvents ButtonCLOSE As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents NumericUpDownFPS As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownBRT As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
