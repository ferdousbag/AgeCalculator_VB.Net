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
        Me.olddate = New System.Windows.Forms.TextBox()
        Me.oldmonth = New System.Windows.Forms.TextBox()
        Me.oldyear = New System.Windows.Forms.TextBox()
        Me.newdate = New System.Windows.Forms.TextBox()
        Me.newmonth = New System.Windows.Forms.TextBox()
        Me.newyear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.Lbldays = New System.Windows.Forms.Label()
        Me.LblWeeks = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lblmeals = New System.Windows.Forms.Label()
        Me.Lblsleep = New System.Windows.Forms.Label()
        Me.Lblgrownup = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LblHour = New System.Windows.Forms.Label()
        Me.Lblminutes = New System.Windows.Forms.Label()
        Me.Lblsecond = New System.Windows.Forms.Label()
        Me.Lblmonth = New System.Windows.Forms.Label()
        Me.LblMoon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'olddate
        '
        Me.olddate.BackColor = System.Drawing.Color.White
        Me.olddate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olddate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.olddate.Location = New System.Drawing.Point(131, 129)
        Me.olddate.MaxLength = 2
        Me.olddate.Name = "olddate"
        Me.olddate.ShortcutsEnabled = False
        Me.olddate.Size = New System.Drawing.Size(100, 31)
        Me.olddate.TabIndex = 0
        Me.olddate.Text = "1"
        Me.olddate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'oldmonth
        '
        Me.oldmonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldmonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.oldmonth.Location = New System.Drawing.Point(315, 129)
        Me.oldmonth.MaxLength = 2
        Me.oldmonth.Name = "oldmonth"
        Me.oldmonth.ShortcutsEnabled = False
        Me.oldmonth.Size = New System.Drawing.Size(100, 31)
        Me.oldmonth.TabIndex = 1
        Me.oldmonth.Text = "1"
        Me.oldmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'oldyear
        '
        Me.oldyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldyear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.oldyear.Location = New System.Drawing.Point(498, 129)
        Me.oldyear.MaxLength = 4
        Me.oldyear.Name = "oldyear"
        Me.oldyear.ShortcutsEnabled = False
        Me.oldyear.Size = New System.Drawing.Size(100, 31)
        Me.oldyear.TabIndex = 2
        Me.oldyear.Text = "1990"
        Me.oldyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newdate
        '
        Me.newdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.newdate.Location = New System.Drawing.Point(131, 237)
        Me.newdate.MaxLength = 2
        Me.newdate.Name = "newdate"
        Me.newdate.Size = New System.Drawing.Size(100, 31)
        Me.newdate.TabIndex = 3
        Me.newdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newmonth
        '
        Me.newmonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newmonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.newmonth.Location = New System.Drawing.Point(315, 234)
        Me.newmonth.MaxLength = 2
        Me.newmonth.Name = "newmonth"
        Me.newmonth.Size = New System.Drawing.Size(100, 31)
        Me.newmonth.TabIndex = 4
        Me.newmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'newyear
        '
        Me.newyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newyear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.newyear.Location = New System.Drawing.Point(498, 234)
        Me.newyear.MaxLength = 4
        Me.newyear.Name = "newyear"
        Me.newyear.Size = New System.Drawing.Size(100, 31)
        Me.newyear.TabIndex = 5
        Me.newyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Month"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Year"
        '
        'BtnCal
        '
        Me.BtnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(69, 312)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(498, 35)
        Me.BtnCal.TabIndex = 12
        Me.BtnCal.Text = "Calculate your age "
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(494, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Input your Date of birth/ (Calculation starting date):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(358, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Today's date/(Calculation end date):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-3, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "You are exactly: "
        Me.Label9.Visible = False
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LblResult.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResult.Location = New System.Drawing.Point(194, 375)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(269, 22)
        Me.LblResult.TabIndex = 16
        Me.LblResult.Text = "0 years 0 months 0 days old"
        Me.LblResult.Visible = False
        '
        'Lbldays
        '
        Me.Lbldays.AutoSize = True
        Me.Lbldays.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldays.ForeColor = System.Drawing.Color.DeepPink
        Me.Lbldays.Location = New System.Drawing.Point(195, 456)
        Me.Lbldays.Name = "Lbldays"
        Me.Lbldays.Size = New System.Drawing.Size(116, 22)
        Me.Lbldays.TabIndex = 17
        Me.Lbldays.Text = "Total 0 days "
        Me.Lbldays.Visible = False
        '
        'LblWeeks
        '
        Me.LblWeeks.AutoSize = True
        Me.LblWeeks.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWeeks.ForeColor = System.Drawing.Color.Maroon
        Me.LblWeeks.Location = New System.Drawing.Point(194, 427)
        Me.LblWeeks.Name = "LblWeeks"
        Me.LblWeeks.Size = New System.Drawing.Size(125, 22)
        Me.LblWeeks.TabIndex = 18
        Me.LblWeeks.Text = "Total 0 weeks"
        Me.LblWeeks.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(7, 587)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fan facts:"
        Me.Label10.Visible = False
        '
        'Lblmeals
        '
        Me.Lblmeals.AutoSize = True
        Me.Lblmeals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmeals.ForeColor = System.Drawing.Color.Maroon
        Me.Lblmeals.Location = New System.Drawing.Point(194, 589)
        Me.Lblmeals.Name = "Lblmeals"
        Me.Lblmeals.Size = New System.Drawing.Size(198, 22)
        Me.Lblmeals.TabIndex = 20
        Me.Lblmeals.Text = "You eat 0 times in total"
        Me.Lblmeals.Visible = False
        '
        'Lblsleep
        '
        Me.Lblsleep.AutoSize = True
        Me.Lblsleep.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsleep.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lblsleep.Location = New System.Drawing.Point(195, 611)
        Me.Lblsleep.Name = "Lblsleep"
        Me.Lblsleep.Size = New System.Drawing.Size(237, 22)
        Me.Lblsleep.TabIndex = 21
        Me.Lblsleep.Text = "You sleeps almost 0 hours "
        Me.Lblsleep.Visible = False
        '
        'Lblgrownup
        '
        Me.Lblgrownup.AutoSize = True
        Me.Lblgrownup.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblgrownup.ForeColor = System.Drawing.Color.Purple
        Me.Lblgrownup.Location = New System.Drawing.Point(194, 633)
        Me.Lblgrownup.Name = "Lblgrownup"
        Me.Lblgrownup.Size = New System.Drawing.Size(390, 22)
        Me.Lblgrownup.TabIndex = 22
        Me.Lblgrownup.Text = "You passed your eighteen about 0 years ago!"
        Me.Lblgrownup.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(2, 679)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(219, 679)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 35)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Help "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(452, 679)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 35)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'LblHour
        '
        Me.LblHour.AutoSize = True
        Me.LblHour.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHour.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblHour.Location = New System.Drawing.Point(194, 485)
        Me.LblHour.Name = "LblHour"
        Me.LblHour.Size = New System.Drawing.Size(118, 22)
        Me.LblHour.TabIndex = 26
        Me.LblHour.Text = "Total 0 hours"
        Me.LblHour.Visible = False
        '
        'Lblminutes
        '
        Me.Lblminutes.AutoSize = True
        Me.Lblminutes.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblminutes.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Lblminutes.Location = New System.Drawing.Point(196, 519)
        Me.Lblminutes.Name = "Lblminutes"
        Me.Lblminutes.Size = New System.Drawing.Size(137, 22)
        Me.Lblminutes.TabIndex = 27
        Me.Lblminutes.Text = "Total 0 minutes"
        Me.Lblminutes.Visible = False
        '
        'Lblsecond
        '
        Me.Lblsecond.AutoSize = True
        Me.Lblsecond.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsecond.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Lblsecond.Location = New System.Drawing.Point(196, 550)
        Me.Lblsecond.Name = "Lblsecond"
        Me.Lblsecond.Size = New System.Drawing.Size(144, 22)
        Me.Lblsecond.TabIndex = 28
        Me.Lblsecond.Text = "Total 0 seconds"
        Me.Lblsecond.Visible = False
        '
        'Lblmonth
        '
        Me.Lblmonth.AutoSize = True
        Me.Lblmonth.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmonth.ForeColor = System.Drawing.Color.LimeGreen
        Me.Lblmonth.Location = New System.Drawing.Point(194, 401)
        Me.Lblmonth.Name = "Lblmonth"
        Me.Lblmonth.Size = New System.Drawing.Size(133, 22)
        Me.Lblmonth.TabIndex = 29
        Me.Lblmonth.Text = "Total 0 months"
        Me.Lblmonth.Visible = False
        '
        'LblMoon
        '
        Me.LblMoon.AutoSize = True
        Me.LblMoon.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMoon.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblMoon.Location = New System.Drawing.Point(196, 655)
        Me.LblMoon.Name = "LblMoon"
        Me.LblMoon.Size = New System.Drawing.Size(202, 22)
        Me.LblMoon.TabIndex = 30
        Me.LblMoon.Text = "You see 0 new moons!"
        Me.LblMoon.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(610, 717)
        Me.Controls.Add(Me.LblMoon)
        Me.Controls.Add(Me.Lblmonth)
        Me.Controls.Add(Me.Lblsecond)
        Me.Controls.Add(Me.Lblminutes)
        Me.Controls.Add(Me.LblHour)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lblgrownup)
        Me.Controls.Add(Me.Lblsleep)
        Me.Controls.Add(Me.Lblmeals)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblWeeks)
        Me.Controls.Add(Me.Lbldays)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newyear)
        Me.Controls.Add(Me.newmonth)
        Me.Controls.Add(Me.newdate)
        Me.Controls.Add(Me.oldyear)
        Me.Controls.Add(Me.oldmonth)
        Me.Controls.Add(Me.olddate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Age calculator"
        Me.Text = "Age Calculator: Calculate your age"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents olddate As TextBox
    Public WithEvents oldmonth As TextBox
    Public WithEvents oldyear As TextBox
    Public WithEvents newdate As TextBox
    Public WithEvents newmonth As TextBox
    Public WithEvents newyear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCal As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents Lbldays As Label
    Friend WithEvents LblWeeks As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lblmeals As Label
    Friend WithEvents Lblsleep As Label
    Friend WithEvents Lblgrownup As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LblHour As Label
    Friend WithEvents Lblminutes As Label
    Friend WithEvents Lblsecond As Label
    Friend WithEvents Lblmonth As Label
    Friend WithEvents LblMoon As Label
End Class
