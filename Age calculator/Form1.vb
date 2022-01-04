Public Class Form1
    Dim caldate, calmonth, calyear, caltdays, caltweeks As Integer
    Dim odate, omonth, oyear As Integer



    Dim ndate, nmonth, nyear As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Input your DoB and current date to calculate your age. Note that: when calculating age, +1 day (present day) added with day atomatiaclly cause it's a rule , Total no of eating = (total age - 2 years infancy)/3 times a day, Total hours of sleep= total days / 3 cause if we sleep 8 hours a day then its 24/8 =3 (one third of 24 hours day), Thanks")
    End Sub

    Private Sub LblResult_Click(sender As Object, e As EventArgs) Handles LblResult.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Lblminutes.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Md. Ferdous Parvez, ferdousparvez@yahoo.com, +8801843861974")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCal.Click

        Label10.Visible = True
        Label9.Visible = True


        odate = olddate.Text
        omonth = oldmonth.Text
        oyear = oldyear.Text
        ndate = newdate.Text
        nmonth = newmonth.Text
        nyear = newyear.Text


        'Calculate date

        If odate <= ndate Then
            caldate = ndate - odate
            caldate += 1
        Else
            nmonth -= 1
            ndate += 30
            caldate = ndate - odate
            caldate += 1
        End If

        'calculate month

        If omonth <= nmonth Then
            calmonth = nmonth - omonth
        Else
            nyear -= 1
            nmonth += 12
            calmonth = nmonth - omonth
        End If

        'calculate year

        If oyear > nyear Then
            LblResult.Visible = True
            LblResult.Text = "Please input current date to calculate"
        Else
            calyear = nyear - oyear
        End If

        LblResult.Visible = True
        LblResult.Text = " " & calyear.ToString & " years " & calmonth.ToString & " months " & caldate.ToString & " days old."

        'calculate total days 
        caltdays = ((calyear * 365) + (calmonth * 12) + caldate)
        Lbldays.Visible = True
        Lbldays.Text = "Total " & caltdays.ToString & " days till now"

        'calculate total weeks
        caltweeks = Int(caltdays.ToString) / 7
        LblWeeks.Visible = True
        LblWeeks.Text = "Total " & caltweeks & " weeks"

        'calculate total months
        Dim tmonth As Integer
        tmonth = (calyear * 12) + calmonth
        Lblmonth.Visible = True
        Lblmonth.Text = "There are " & tmonth & " months in your life"

        'calculate sleeptime
        Dim sleeptime As Integer
        sleeptime = Int(caltdays.ToString) / 3
        Lblsleep.Visible = True
        Lblsleep.Text = "You sleep almost " & sleeptime & " hours.!"

        'calculate meals
        Dim meals As Integer
        meals = Int(caltdays - 730) / 3
        Lblmeals.Visible = True
        Lblmeals.Text = "You eat " & meals & " times in total life"

        'calculate grownuptime
        Dim grownup As Integer
        grownup = calyear - 18
        Lblgrownup.Visible = True
        Lblgrownup.Text = "You passed your eighteen about " & grownup & " years ago!"

        'calculate hours
        Dim hours As Integer
        hours = Int(caltdays - 1) + Now.Hour
        LblHour.Visible = True
        LblHour.Text = " " & hours & " hours in the clock"

        'calculate minutes 
        Dim tminutes As Integer
        tminutes = hours + Now.Minute
        Lblminutes.Visible = True
        Lblminutes.Text = "" & tminutes & " minutes passed"

        'calculate secounds 
        Dim tsecond As Integer
        tsecond = tminutes + Now.Second
        Lblsecond.Visible = True
        Lblsecond.Text = "Around " & tsecond & " seconds flown away!"

        'calculate total moon seen in life
        Dim tmoon As Integer
        tmoon = Int(caltdays / 28)
        LblMoon.Visible = True
        LblMoon.Text = "You see " & tmoon & " new moons!"

        'Prevent false inputs 
        Select Case odate
            Case < 1
                olddate.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False

            Case > 31
                olddate.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
        End Select

        Select Case omonth
            Case < 1
                oldmonth.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
            Case > 12
                oldmonth.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
        End Select



        Select Case ndate
            Case < 1
                newdate.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
            Case > 31
                newdate.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
        End Select

        Select Case nmonth
            Case < 1
                newmonth.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
            Case > 12
                newmonth.BackColor = Color.Red
                Lbldays.Visible = False
                LblResult.Visible = False
                LblWeeks.Visible = False
                Lblgrownup.Visible = False
                Lblmeals.Visible = False
                Lblsleep.Visible = False
                Lblmonth.Visible = False
                LblHour.Visible = False
                Lblsecond.Visible = False
                Lblminutes.Visible = False
                LblMoon.Visible = False
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        newdate.Text = Today.Day
        newmonth.Text = Today.Month
        newyear.Text = Today.Year
        BtnCal.Focus()

    End Sub

    Private Sub olddate_Click(sender As Object, e As EventArgs) Handles olddate.Click
        olddate.BackColor = Color.White
    End Sub

    Private Sub oldmonth_Click(sender As Object, e As EventArgs) Handles oldmonth.Click
        oldmonth.BackColor = Color.White
    End Sub

    Private Sub newdate_Click(sender As Object, e As EventArgs) Handles newdate.Click
        newdate.BackColor = Color.White
    End Sub

    Private Sub newmonth_Click(sender As Object, e As EventArgs) Handles newmonth.Click
        newmonth.BackColor = Color.White
    End Sub

End Class
