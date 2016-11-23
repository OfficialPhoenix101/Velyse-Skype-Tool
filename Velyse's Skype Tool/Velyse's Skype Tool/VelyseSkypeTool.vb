Imports System.ComponentModel
Imports System.Net
Imports System.Text.RegularExpressions
Imports SKYPE4COMLib
'Imports System.Speech.Synthesis

Public Class VelysesSkypeTool
    Private setVolumeDelegate As Action(Of Single)
    Dim Skype As New SKYPE4COMLib.Skype
    Public WithEvents Skype1 As New SKYPE4COMLib.Skype
    Private Sub LoyalButton1_Click(sender As Object, e As EventArgs) Handles LoyalButton1.Click

        Try

            Skype.Attach()
            Form1.ShowDialog()
            Label2.Text = ("Connected!")
            Label1.Text = (Skype.CurrentUserProfile.FullName)

            For Each user As SKYPE4COMLib.User In Skype.Friends

                MetroComboBox2.Items.Add(user.Handle)
                MetroComboBox3.Items.Add(user.Handle)
                MetroComboBox4.Items.Add(user.Handle)
                MetroComboBox5.Items.Add(user.Handle)
                MetroComboBox6.Items.Add(user.Handle)
                MetroComboBox7.Items.Add(user.Handle)
                MetroComboBox8.Items.Add(user.Handle)
                ' XylosCombobox9.Items.Add(user.Handle)
                ' XylosCombobox10.Items.Add(user.Handle)



            Next
            '  ComboBox4.Sorted = True
            '   ComboBox3.Sorted = True
            '   ComboBoxName.Sorted = True
            MetroComboBox2.Sorted = True
            MetroComboBox3.Sorted = True
            MetroComboBox4.Sorted = True
            MetroComboBox5.Sorted = True
            MetroComboBox6.Sorted = True
            MetroComboBox7.Sorted = True
            MetroComboBox8.Sorted = True
            ' XylosCombobox9.Sorted = True
            ' XylosCombobox10.Sorted = True



        Catch ex As Exception

            Form2.ShowDialog()
            Label2.Text = ("Disconnected!")
            Label1.Text = ("Unknown")


        End Try

        Form3.ShowDialog()





    End Sub

    Private Sub LoyalButton2_Click(sender As Object, e As EventArgs) Handles LoyalButton2.Click

        If LoyalButton2.Text = "Set Mood" Then

            LoyalButton2.Text = "Reset Mood"

            Skype.CurrentUserProfile.MoodText = LoyalTextBox1.Text

        Else

            LoyalButton2.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""


        End If





    End Sub

    Private Sub LoyalButton6_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub LoyalButton3_Click(sender As Object, e As EventArgs) Handles LoyalButton3.Click

        Skype.CurrentUserProfile.MoodText = ""

    End Sub

    Private Sub LoyalButton4_Click(sender As Object, e As EventArgs) Handles LoyalButton4.Click
        If LoyalButton4.Text = "Set Name" Then

            LoyalButton4.Text = "Reset Name"
            Skype.CurrentUserProfile.FullName = LoyalTextBox3.Text

        Else
            LoyalButton4.Text = "Set Name"
            Skype.CurrentUserProfile.FullName = Label1.Text

        End If


    End Sub

    Private Sub LoyalButton5_Click(sender As Object, e As EventArgs) Handles LoyalButton5.Click


        If MetroComboBox1.SelectedItem = "Online" Then

            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline


        End If

        If MetroComboBox1.SelectedItem = "Away" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway

        End If
        If MetroComboBox1.SelectedItem = "Offline" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOffline
        End If

        If MetroComboBox1.SelectedItem = "Do Not Disturb" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb

        End If
        If MetroComboBox1.SelectedItem = "Invisible" Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        End If

    End Sub

    Private Sub LoyalButton10_Click(sender As Object, e As EventArgs) Handles LoyalButton10.Click

        Skype.ClearCallHistory()

    End Sub

    Private Sub LoyalButton9_Click(sender As Object, e As EventArgs) Handles LoyalButton9.Click

        Skype.ClearChatHistory()

    End Sub

    Private Sub LoyalButton8_Click(sender As Object, e As EventArgs) Handles LoyalButton8.Click

        Skype.ClearVoicemailHistory()


    End Sub

    Private Sub LoyalButton11_Click(sender As Object, e As EventArgs) Handles LoyalButton11.Click

        Skype.ResetCache()

    End Sub

    Private Sub LoyalButton7_Click(sender As Object, e As EventArgs) Handles LoyalButton7.Click


        LoyalTextBox2.Text = Skype.CurrentUserProfile.Country
        LoyalTextBox4.Text = Skype.CurrentUserProfile.City
        LoyalTextBox5.Text = Skype.CurrentUserProfile.IPCountry
        LoyalTextBox6.Text = Skype.CurrentUserProfile.PhoneHome
        LoyalTextBox7.Text = Skype.CurrentUserProfile.PhoneMobile
        LoyalTextBox8.Text = Skype.CurrentUserProfile.PhoneOffice
        LoyalTextBox9.Text = Skype.CurrentUserProfile.Homepage
        LoyalTextBox10.Text = Skype.CurrentUserProfile.Languages
        LoyalTextBox11.Text = Skype.CurrentUserProfile.About
        LoyalTextBox12.Text = Skype.CurrentUserProfile.MoodText
        LoyalTextBox13.Text = Skype.CurrentUserProfile.Sex
        LoyalTextBox14.Text = Skype.CurrentUserProfile.Timezone






    End Sub

    Private Sub LoyalButton12_Click(sender As Object, e As EventArgs) Handles LoyalButton12.Click

        Skype.CurrentUserProfile.Country = LoyalTextBox2.Text

    End Sub

    Private Sub LoyalButton13_Click(sender As Object, e As EventArgs) Handles LoyalButton13.Click

        Skype.CurrentUserProfile.City = LoyalTextBox4.Text

    End Sub

    Private Sub LoyalButton14_Click(sender As Object, e As EventArgs) Handles LoyalButton14.Click

        ' Skype.CurrentUserProfile.IPCountry = LoyalTextBox5.Text

    End Sub

    Private Sub LoyalButton15_Click(sender As Object, e As EventArgs) Handles LoyalButton15.Click

        Skype.CurrentUserProfile.PhoneHome = LoyalTextBox6.Text

    End Sub

    Private Sub LoyalButton16_Click(sender As Object, e As EventArgs) Handles LoyalButton16.Click

        Skype.CurrentUserProfile.PhoneMobile = LoyalTextBox7.Text

    End Sub

    Private Sub LoyalButton17_Click(sender As Object, e As EventArgs) Handles LoyalButton17.Click

        Skype.CurrentUserProfile.PhoneOffice = LoyalTextBox8.Text

    End Sub

    Private Sub LoyalButton18_Click(sender As Object, e As EventArgs) Handles LoyalButton18.Click

        Skype.CurrentUserProfile.Homepage = LoyalTextBox9.Text

    End Sub

    Private Sub LoyalButton19_Click(sender As Object, e As EventArgs) Handles LoyalButton19.Click

        Skype.CurrentUserProfile.Languages = LoyalTextBox10.Text

    End Sub

    Private Sub LoyalButton20_Click(sender As Object, e As EventArgs) Handles LoyalButton20.Click

        Skype.CurrentUserProfile.About = LoyalTextBox11.Text

    End Sub

    Private Sub LoyalButton21_Click(sender As Object, e As EventArgs) Handles LoyalButton21.Click

        Skype.CurrentUserProfile.MoodText = LoyalTextBox12.Text

    End Sub

    Private Sub LoyalButton22_Click(sender As Object, e As EventArgs) Handles LoyalButton22.Click

        Skype.CurrentUserProfile.Sex = LoyalTextBox13.Text

    End Sub

    Private Sub LoyalButton23_Click(sender As Object, e As EventArgs) Handles LoyalButton23.Click

        Skype.CurrentUserProfile.Timezone = LoyalTextBox14.Text

    End Sub

    Private Sub LoyalButton24_Click(sender As Object, e As EventArgs) Handles LoyalButton24.Click
        If LoyalButton24.Text = "Set Mood" Then


            LoyalButton24.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & LoyalTextBox15.Text & "</blink>"


        Else

            LoyalButton24.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""

        End If




    End Sub

    Private Sub LoyalButton25_Click(sender As Object, e As EventArgs) Handles LoyalButton25.Click

        If LoyalButton25.Text = "Set Mood" Then

            LoyalButton25.Text = "Reset Mood"

            Skype.CurrentUserProfile.FullName = "<blink>" & LoyalTextBox16.Text & "</blink>"

        Else

            LoyalButton25.Text = "Set Mood"
            Skype.CurrentUserProfile.FullName = Skype.CurrentUserProfile.FullName


        End If


    End Sub

    Private Sub LoyalButton26_Click(sender As Object, e As EventArgs) Handles LoyalButton26.Click

        If LoyalButton26.Text = "Set Mood" Then

            LoyalButton26.Text = "Reset Mood"

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & LoyalTextBox17.Text & "</ZapButton>"

        Else

            LoyalButton26.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton27_Click(sender As Object, e As EventArgs) Handles LoyalButton27.Click

        If LoyalButton27.Text = "Set Mood" Then

            LoyalButton27.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & LoyalTextBox18.Text & "<spinner>""</spinner>"

        Else

            LoyalButton27.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""

        End If





    End Sub

    Private Sub LoyalButton31_Click(sender As Object, e As EventArgs) Handles LoyalButton31.Click

        If LoyalButton31.Text = "Set Mood" Then

            LoyalButton31.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action="" Resume"" Template="" MediumBattonTextDark"">""" + "P" + "</ZapButton>"

        Else
            LoyalButton31.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""

        End If



    End Sub

    Private Sub LoyalButton33_Click(sender As Object, e As EventArgs) Handles LoyalButton33.Click

        Timer1.Start()

    End Sub

    Private Sub LoyalButton28_Click(sender As Object, e As EventArgs) Handles LoyalButton28.Click

        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusOnline = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        End If

        Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusAway = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        End If
        Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb
        If Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusDoNotDisturb = True Then
            Skype.CurrentUserStatus = SKYPE4COMLib.TUserStatus.cusInvisible
        End If

    End Sub

    Private Sub LoyalButton32_Click(sender As Object, e As EventArgs) Handles LoyalButton32.Click

        If LoyalButton32.Text = "Set Mood" Then

            LoyalButton32.Text = "Reset Mood"

            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & LoyalTextBox23.Text & "</blink>" & "<spinner>""</spinner>"

        Else

            LoyalButton32.Text = "Set Mood"
            Skype.CurrentUserProfile.MoodText = ""

        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Skype.CurrentUserProfile.MoodText = LoyalTextBox21.Text

    End Sub

    Private Sub LoyalButton30_Click(sender As Object, e As EventArgs) Handles LoyalButton30.Click

        If LoyalButton30.Text = "Set Mood" Then


            Timer2.Start()

            LoyalButton30.Text = "Reset Mood"

        Else

            LoyalButton30.Text = "Set Mood"
            Timer2.Stop()
            Skype.CurrentUserProfile.MoodText = ""


        End If



    End Sub

    Private Sub LoyalButton29_Click(sender As Object, e As EventArgs) Handles LoyalButton29.Click

        If LoyalButton29.Text = "Set Mood" Then

            LoyalButton29.Text = "Reset Mood"

            Timer3.Start()



        Else

            LoyalButton29.Text = "Set Mood"
            Timer3.Stop()
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Skype.CurrentUserProfile.RichMoodText = "<blink>" & LoyalTextBox20.Text & "</blink>"

    End Sub

    Private Sub LoyalButton34_Click(sender As Object, e As EventArgs) Handles LoyalButton34.Click

        If LoyalButton34.Text = "（ミ￣ー￣ミ）" Then

            LoyalButton34.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "（ミ￣ー￣ミ）"

        Else

            LoyalButton34.Text = "（ミ￣ー￣ミ）"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton35_Click(sender As Object, e As EventArgs) Handles LoyalButton35.Click
        If LoyalButton35.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" Then

            LoyalButton35.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
        Else
            LoyalButton35.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""
        End If


    End Sub

    Private Sub LoyalButton36_Click(sender As Object, e As EventArgs) Handles LoyalButton36.Click

        If LoyalButton36.Text = "┌( ಠ‿ ಠ)┘" Then

            LoyalButton36.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "┌( ಠ‿ ಠ)┘"
        Else
            LoyalButton36.Text = "┌( ಠ‿ ಠ)┘"
            Skype.CurrentUserProfile.MoodText = ""


        End If



    End Sub

    Private Sub LoyalButton37_Click(sender As Object, e As EventArgs) Handles LoyalButton37.Click

        If LoyalButton37.Text = "o(╥﹏╥)o" Then

            LoyalButton37.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "o(╥﹏╥)o"
        Else
            LoyalButton37.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton38_Click(sender As Object, e As EventArgs) Handles LoyalButton38.Click

        If LoyalButton38.Text = "╭∩╮（︶︿︶）╭∩╮" Then

            LoyalButton38.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "╭∩╮（︶︿︶）╭∩╮"
        Else
            LoyalButton38.Text = "╭∩╮（︶︿︶）╭∩╮"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton39_Click(sender As Object, e As EventArgs) Handles LoyalButton39.Click

        If LoyalButton39.Text = "╘[◉﹃◉]╕" Then

            LoyalButton39.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "╘[◉﹃◉]╕"
        Else
            LoyalButton39.Text = "╘[◉﹃◉]╕"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton40_Click(sender As Object, e As EventArgs) Handles LoyalButton40.Click

        If LoyalButton40.Text = "(ノÒ益Ó)ノ彡▔▔" Then

            LoyalButton40.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "(ノÒ益Ó)ノ彡▔▔"
        Else
            LoyalButton40.Text = "(ノÒ益Ó)ノ彡▔▔"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton41_Click(sender As Object, e As EventArgs) Handles LoyalButton41.Click
        If LoyalButton41.Text = "I'm a Hacker ಠ益ಠ" Then

            LoyalButton41.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "I'm a Hacker ಠ益ಠ"
        Else
            LoyalButton41.Text = "I'm a Hacker ಠ益ಠ"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton42_Click(sender As Object, e As EventArgs) Handles LoyalButton42.Click
        If LoyalButton42.Text = "o(╥﹏╥)o" Then

            LoyalButton42.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "o(╥﹏╥)o"
        Else
            LoyalButton42.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton43_Click(sender As Object, e As EventArgs) Handles LoyalButton43.Click

        If LoyalButton43.Text = "(✖╭╮✖)" Then

            LoyalButton43.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "(✖╭╮✖)"
        Else
            LoyalButton43.Text = "(✖╭╮✖)"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton44_Click(sender As Object, e As EventArgs) Handles LoyalButton44.Click

        If LoyalButton44.Text = "( ･_･)♡" Then

            LoyalButton44.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "( ･_･)♡"
        Else
            LoyalButton44.Text = "( ･_･)♡"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton45_Click(sender As Object, e As EventArgs) Handles LoyalButton45.Click

        If LoyalButton45.Text = "＼(^ ω ^＼)" Then

            LoyalButton45.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "＼(^ ω ^＼)"
        Else
            LoyalButton45.Text = "＼(^ ω ^＼)"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton46_Click(sender As Object, e As EventArgs) Handles LoyalButton46.Click

        If LoyalButton46.Text = "( ́ ◕◞ε◟◕`)" Then

            LoyalButton46.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "( ́ ◕◞ε◟◕`)"
        Else
            LoyalButton46.Text = "( ́ ◕◞ε◟◕`)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton47_Click(sender As Object, e As EventArgs) Handles LoyalButton47.Click

        If LoyalButton47.Text = "(=ﾟωﾟ)ﾉ" Then

            LoyalButton47.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "(=ﾟωﾟ)ﾉ"
        Else
            LoyalButton47.Text = "(=ﾟωﾟ)ﾉ"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton48_Click(sender As Object, e As EventArgs) Handles LoyalButton48.Click

        If LoyalButton48.Text = "（ミ￣ー￣ミ）" Then

            LoyalButton48.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "（ミ￣ー￣ミ）" & "</blink>"

        Else
            LoyalButton48.Text = "（ミ￣ー￣ミ）"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton49_Click(sender As Object, e As EventArgs) Handles LoyalButton49.Click

        If LoyalButton49.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" Then

            LoyalButton49.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & " ̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿ " & "</blink>"
        Else
            LoyalButton49.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton50_Click(sender As Object, e As EventArgs) Handles LoyalButton50.Click

        If LoyalButton50.Text = "┌( ಠ‿ ಠ)┘" Then

            LoyalButton50.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "┌( ಠ‿ ಠ)┘" & "</blink>"
        Else
            LoyalButton50.Text = "┌( ಠ‿ ಠ)┘"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton51_Click(sender As Object, e As EventArgs) Handles LoyalButton51.Click

        If LoyalButton51.Text = "o(╥﹏╥)o" Then

            LoyalButton51.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "o(╥﹏╥)o" & "</blink>"

        Else
            LoyalButton51.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton52_Click(sender As Object, e As EventArgs) Handles LoyalButton52.Click

        If LoyalButton52.Text = "╭∩╮（︶︿︶）╭∩╮" Then

            LoyalButton52.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "╭∩╮（︶︿︶）╭∩╮" & "</blink>"
        Else
            LoyalButton52.Text = "╭∩╮（︶︿︶）╭∩╮"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton53_Click(sender As Object, e As EventArgs) Handles LoyalButton53.Click

        If LoyalButton53.Text = "╘[◉﹃◉]╕" Then

            LoyalButton53.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "╘[◉﹃◉]╕" & "</blink>"
        Else
            LoyalButton53.Text = "╘[◉﹃◉]╕"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton54_Click(sender As Object, e As EventArgs) Handles LoyalButton54.Click

        If LoyalButton54.Text = "(ノÒ益Ó)ノ彡▔▔" Then

            LoyalButton54.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "(ノÒ益Ó)ノ彡▔▔" & "</blink>"
        Else
            LoyalButton54.Text = "(ノÒ益Ó)ノ彡▔▔"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub
    Private Sub LoyalButton55_Click(sender As Object, e As EventArgs) Handles LoyalButton55.Click



        If LoyalButton55.Text = "I'm a Hacker ಠ益ಠ" Then

            LoyalButton55.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "I'm a Hacker ಠ益ಠ" & "</blink>"
        Else
            LoyalButton55.Text = "I'm a Hacker ಠ益ಠ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton56_Click(sender As Object, e As EventArgs) Handles LoyalButton56.Click



        If LoyalButton56.Text = "o(╥﹏╥)o" Then

            LoyalButton56.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "o(╥﹏╥)o" & "</blink>"
        Else
            LoyalButton56.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton57_Click(sender As Object, e As EventArgs) Handles LoyalButton57.Click

        If LoyalButton57.Text = "(✖╭╮✖)" Then

            LoyalButton57.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "(✖╭╮✖)" & "</blink>"

        Else
            LoyalButton57.Text = "(✖╭╮✖)"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton58_Click(sender As Object, e As EventArgs) Handles LoyalButton58.Click

        If LoyalButton58.Text = "( ･_･)♡" Then

            LoyalButton58.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "( ･_･)♡" & "</blink>"

        Else
            LoyalButton58.Text = "( ･_･)♡"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton59_Click(sender As Object, e As EventArgs) Handles LoyalButton59.Click

        If LoyalButton59.Text = "＼(^ ω ^＼)" Then

            LoyalButton59.Text = "Reset Mood"

            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "＼(^ ω ^＼)" & "</blink>"


        Else
            LoyalButton59.Text = "＼(^ ω ^＼)"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton60_Click(sender As Object, e As EventArgs) Handles LoyalButton60.Click

        If LoyalButton60.Text = "( ́ ◕◞ε◟◕`)" Then

            LoyalButton60.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "( ́ ◕◞ε◟◕`)" & "</blink>"
        Else
            LoyalButton60.Text = "( ́ ◕◞ε◟◕`)"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton61_Click(sender As Object, e As EventArgs) Handles LoyalButton61.Click

        If LoyalButton61.Text = "(=ﾟωﾟ)ﾉ" Then

            LoyalButton61.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "(=ﾟωﾟ)ﾉ" & "</blink>"
        Else
            LoyalButton61.Text = "(=ﾟωﾟ)ﾉ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton62_Click(sender As Object, e As EventArgs) Handles LoyalButton62.Click


        If LoyalButton62.Text = "（ミ￣ー￣ミ）" Then

            LoyalButton62.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "（ミ￣ー￣ミ）" & "<spinner>""</spinner>"

        Else
            LoyalButton62.Text = "（ミ￣ー￣ミ）"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton63_Click(sender As Object, e As EventArgs) Handles LoyalButton63.Click


        If LoyalButton63.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" Then

            LoyalButton63.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & " ̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿ " & "<spinner>""</spinner>"

        Else
            LoyalButton63.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton64_Click(sender As Object, e As EventArgs) Handles LoyalButton64.Click


        If LoyalButton64.Text = "┌( ಠ‿ ಠ)┘" Then

            LoyalButton64.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "┌( ಠ‿ ಠ)┘" & "<spinner>""</spinner>"

        Else
            LoyalButton64.Text = "┌( ಠ‿ ಠ)┘"
            Skype.CurrentUserProfile.MoodText = ""


        End If


    End Sub

    Private Sub LoyalButton65_Click(sender As Object, e As EventArgs) Handles LoyalButton65.Click


        If LoyalButton65.Text = "o(╥﹏╥)o" Then

            LoyalButton65.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "o(╥﹏╥)o" & "<spinner>""</spinner>"

        Else
            LoyalButton65.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton66_Click(sender As Object, e As EventArgs) Handles LoyalButton66.Click


        If LoyalButton66.Text = "╭∩╮（︶︿︶）╭∩╮" Then

            LoyalButton66.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "╭∩╮（︶︿︶）╭∩╮" & "<spinner>""</spinner>"

        Else
            LoyalButton66.Text = "╭∩╮（︶︿︶）╭∩╮"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton67_Click(sender As Object, e As EventArgs) Handles LoyalButton67.Click


        If LoyalButton67.Text = "╘[◉﹃◉]╕" Then

            LoyalButton67.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "╘[◉﹃◉]╕" & "<spinner>""</spinner>"

        Else
            LoyalButton67.Text = "╘[◉﹃◉]╕"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton68_Click(sender As Object, e As EventArgs) Handles LoyalButton68.Click


        If LoyalButton68.Text = "(ノÒ益Ó)ノ彡▔▔" Then

            LoyalButton68.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "(ノÒ益Ó)ノ彡▔▔" & "<spinner>""</spinner>"

        Else
            LoyalButton68.Text = "(ノÒ益Ó)ノ彡▔▔"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton69_Click(sender As Object, e As EventArgs) Handles LoyalButton69.Click


        If LoyalButton69.Text = "I'm a Hacker ಠ益ಠ" Then

            LoyalButton69.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "I'm a Hacker ಠ益ಠ" & "<spinner>""</spinner>"

        Else
            LoyalButton69.Text = "I'm a Hacker ಠ益ಠ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton70_Click(sender As Object, e As EventArgs) Handles LoyalButton70.Click


        If LoyalButton70.Text = "o(╥﹏╥)o" Then

            LoyalButton70.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "o(╥﹏╥)o" & "<spinner>""</spinner>"

        Else
            LoyalButton70.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton71_Click(sender As Object, e As EventArgs) Handles LoyalButton71.Click


        If LoyalButton71.Text = "(✖╭╮✖)" Then

            LoyalButton71.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "(✖╭╮✖)" & "<spinner>""</spinner>"

        Else
            LoyalButton71.Text = "(✖╭╮✖)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton72_Click(sender As Object, e As EventArgs) Handles LoyalButton72.Click


        If LoyalButton72.Text = "( ･_･)♡" Then

            LoyalButton72.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "( ･_･)♡" & "<spinner>""</spinner>"

        Else
            LoyalButton72.Text = "( ･_･)♡"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton73_Click(sender As Object, e As EventArgs) Handles LoyalButton73.Click


        If LoyalButton73.Text = "＼(^ ω ^＼)" Then

            LoyalButton73.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "＼(^ ω ^＼)" & "<spinner>""</spinner>"

        Else
            LoyalButton73.Text = "＼(^ ω ^＼)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton74_Click(sender As Object, e As EventArgs) Handles LoyalButton74.Click


        If LoyalButton74.Text = "( ́ ◕◞ε◟◕`)" Then

            LoyalButton74.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "( ́ ◕◞ε◟◕`)" & "<spinner>""</spinner>"

        Else
            LoyalButton74.Text = "( ́ ◕◞ε◟◕`)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton75_Click(sender As Object, e As EventArgs) Handles LoyalButton75.Click


        If LoyalButton75.Text = "(=ﾟωﾟ)ﾉ" Then

            LoyalButton75.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "(=ﾟωﾟ)ﾉ" & "<spinner>""</spinner>"

        Else
            LoyalButton75.Text = "(=ﾟωﾟ)ﾉ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton89_Click(sender As Object, e As EventArgs) Handles LoyalButton89.Click


        If LoyalButton89.Text = "（ミ￣ー￣ミ）" Then

            LoyalButton89.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "（ミ￣ー￣ミ）" & "</ZapButton>"

        Else
            LoyalButton89.Text = "（ミ￣ー￣ミ）"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton88_Click(sender As Object, e As EventArgs) Handles LoyalButton88.Click

        If LoyalButton88.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" Then

            LoyalButton88.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "  ̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿  " & "</ZapButton>"

        Else
            LoyalButton88.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton87_Click(sender As Object, e As EventArgs) Handles LoyalButton87.Click

        If LoyalButton87.Text = "┌( ಠ‿ ಠ)┘" Then

            LoyalButton87.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "┌( ಠ‿ ಠ)┘" & "</ZapButton>"

        Else
            LoyalButton87.Text = "┌( ಠ‿ ಠ)┘"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton86_Click(sender As Object, e As EventArgs) Handles LoyalButton86.Click

        If LoyalButton86.Text = "o(╥﹏╥)o" Then

            LoyalButton86.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "o(╥﹏╥)o" & "</ZapButton>"

        Else
            LoyalButton86.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton85_Click(sender As Object, e As EventArgs) Handles LoyalButton85.Click

        If LoyalButton85.Text = "╭∩╮（︶︿︶）╭∩╮" Then

            LoyalButton85.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "╭∩╮（︶︿︶）╭∩╮" & "</ZapButton>"

        Else
            LoyalButton85.Text = "╭∩╮（︶︿︶）╭∩╮"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton84_Click(sender As Object, e As EventArgs) Handles LoyalButton84.Click

        If LoyalButton84.Text = "╘[◉﹃◉]╕" Then

            LoyalButton84.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "╘[◉﹃◉]╕" & "</ZapButton>"

        Else
            LoyalButton84.Text = "╘[◉﹃◉]╕"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton83_Click(sender As Object, e As EventArgs) Handles LoyalButton83.Click

        If LoyalButton83.Text = "(ノÒ益Ó)ノ彡▔▔" Then

            LoyalButton83.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(ノÒ益Ó)ノ彡▔▔" & "</ZapButton>"

        Else
            LoyalButton83.Text = "(ノÒ益Ó)ノ彡▔▔"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton82_Click(sender As Object, e As EventArgs) Handles LoyalButton82.Click

        If LoyalButton82.Text = "I'm a Hacker ಠ益ಠ" Then

            LoyalButton82.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "I'm a Hacker ಠ益ಠ" & "</ZapButton>"

        Else
            LoyalButton82.Text = "I'm a Hacker ಠ益ಠ"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton81_Click(sender As Object, e As EventArgs) Handles LoyalButton81.Click
        If LoyalButton81.Text = "o(╥﹏╥)o" Then

            LoyalButton81.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "o(╥﹏╥)o" & "</ZapButton>"

        Else
            LoyalButton81.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton80_Click(sender As Object, e As EventArgs) Handles LoyalButton80.Click

        If LoyalButton80.Text = "(✖╭╮✖)" Then

            LoyalButton80.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(✖╭╮✖)" & "</ZapButton>"

        Else
            LoyalButton80.Text = "(✖╭╮✖)"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton79_Click(sender As Object, e As EventArgs) Handles LoyalButton79.Click
        If LoyalButton79.Text = "( ･_･)♡" Then

            LoyalButton79.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "( ･_･)♡" & "</ZapButton>"

        Else
            LoyalButton79.Text = "( ･_･)♡"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton78_Click(sender As Object, e As EventArgs) Handles LoyalButton78.Click
        If LoyalButton78.Text = "＼(^ ω ^＼)" Then

            LoyalButton78.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "＼(^ ω ^＼)" & "</ZapButton>"

        Else
            LoyalButton78.Text = "＼(^ ω ^＼)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton77_Click(sender As Object, e As EventArgs) Handles LoyalButton77.Click
        If LoyalButton77.Text = "( ́ ◕◞ε◟◕`)" Then

            LoyalButton77.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "( ́ ◕◞ε◟◕`)" & "</ZapButton>"

        Else
            LoyalButton77.Text = "( ́ ◕◞ε◟◕`)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton76_Click(sender As Object, e As EventArgs) Handles LoyalButton76.Click
        If LoyalButton76.Text = "(=ﾟωﾟ)ﾉ" Then

            LoyalButton76.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(=ﾟωﾟ)ﾉ" & "</ZapButton>"

        Else
            LoyalButton76.Text = "(=ﾟωﾟ)ﾉ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton91_Click(sender As Object, e As EventArgs) Handles LoyalButton91.Click
        If LoyalButton91.Text = "（ミ￣ー￣ミ）" Then

            LoyalButton91.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "（ミ￣ー￣ミ）" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton91.Text = "（ミ￣ー￣ミ）"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton98_Click(sender As Object, e As EventArgs) Handles LoyalButton98.Click
        If LoyalButton98.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" Then

            LoyalButton98.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton98.Text = "̿̿(•̪ ●)=/̵͇̿̿/’̿̿ ̿ ̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton102_Click(sender As Object, e As EventArgs) Handles LoyalButton102.Click
        If LoyalButton102.Text = "┌( ಠ‿ ಠ)┘" Then

            LoyalButton102.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "┌( ಠ‿ ಠ)┘" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton102.Text = "┌( ಠ‿ ಠ)┘"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton101_Click(sender As Object, e As EventArgs) Handles LoyalButton101.Click
        If LoyalButton101.Text = "o(╥﹏╥)o" Then

            LoyalButton101.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "o(╥﹏╥)o" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton101.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton97_Click(sender As Object, e As EventArgs) Handles LoyalButton97.Click
        If LoyalButton97.Text = "╭∩╮（︶︿︶）╭∩╮" Then

            LoyalButton97.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "╭∩╮（︶︿︶）╭∩╮" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton97.Text = "╭∩╮（︶︿︶）╭∩╮"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton94_Click(sender As Object, e As EventArgs) Handles LoyalButton94.Click
        If LoyalButton94.Text = "╘[◉﹃◉]╕" Then

            LoyalButton94.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "╘[◉﹃◉]╕" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton94.Text = "╘[◉﹃◉]╕"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton92_Click(sender As Object, e As EventArgs) Handles LoyalButton92.Click

        If LoyalButton92.Text = "(ノÒ益Ó)ノ彡▔▔" Then

            LoyalButton92.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(ノÒ益Ó)ノ彡▔▔" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton92.Text = "(ノÒ益Ó)ノ彡▔▔"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton95_Click(sender As Object, e As EventArgs) Handles LoyalButton95.Click
        If LoyalButton95.Text = "I'm a Hacker ಠ益ಠ" Then

            LoyalButton95.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "I'm a Hacker ಠ益ಠ" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton95.Text = "I'm a Hacker ಠ益ಠ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton99_Click(sender As Object, e As EventArgs) Handles LoyalButton99.Click
        If LoyalButton99.Text = "o(╥﹏╥)o" Then

            LoyalButton99.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "o(╥﹏╥)o" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton99.Text = "o(╥﹏╥)o"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton103_Click(sender As Object, e As EventArgs) Handles LoyalButton103.Click
        If LoyalButton99.Text = "(✖╭╮✖)" Then

            LoyalButton99.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(✖╭╮✖)" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton99.Text = "(✖╭╮✖)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton100_Click(sender As Object, e As EventArgs) Handles LoyalButton100.Click
        If LoyalButton100.Text = "( ･_･)♡" Then

            LoyalButton100.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "( ･_･)♡" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton100.Text = "( ･_･)♡"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton96_Click(sender As Object, e As EventArgs) Handles LoyalButton96.Click
        If LoyalButton96.Text = "＼(^ ω ^＼)" Then

            LoyalButton96.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "＼(^ ω ^＼)" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton96.Text = "＼(^ ω ^＼)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton93_Click(sender As Object, e As EventArgs) Handles LoyalButton93.Click
        If LoyalButton93.Text = "( ́ ◕◞ε◟◕`)" Then

            LoyalButton93.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "( ́ ◕◞ε◟◕`)" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton93.Text = "( ́ ◕◞ε◟◕`)"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton90_Click(sender As Object, e As EventArgs) Handles LoyalButton90.Click
        If LoyalButton90.Text = "(=ﾟωﾟ)ﾉ" Then

            LoyalButton90.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(=ﾟωﾟ)ﾉ" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton90.Text = "(=ﾟωﾟ)ﾉ"
            Skype.CurrentUserProfile.MoodText = ""


        End If
    End Sub

    Private Sub LoyalButton104_Click(sender As Object, e As EventArgs) Handles LoyalButton104.Click
        'ᕙ(⇀‸↼‶)ᕗ
        If LoyalButton104.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            Skype.CurrentUserProfile.FullName = "ᕙ(⇀‸↼‶)ᕗ"
            LoyalButton104.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
            LoyalButton104.Text = "ᕙ(⇀‸↼‶)ᕗ"

        End If
    End Sub

    Private Sub LoyalButton105_Click(sender As Object, e As EventArgs) Handles LoyalButton105.Click
        'ლ,ᔑ•ﺪ͟͠•ᔐ.ლ
        If LoyalButton105.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then
            Skype.CurrentUserProfile.FullName = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            LoyalButton105.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
            LoyalButton105.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
        End If
    End Sub

    Private Sub LoyalButton106_Click(sender As Object, e As EventArgs) Handles LoyalButton106.Click
        '(~_^)
        If LoyalButton106.Text = "(~_^)" Then

            Skype.CurrentUserProfile.FullName = "(~_^)"
            LoyalButton106.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text

        End If
    End Sub

    Private Sub LoyalButton107_Click(sender As Object, e As EventArgs) Handles LoyalButton107.Click
        'ʕ•ᴥ•ʔ
        If LoyalButton107.Text = "ʕ•ᴥ•ʔ" Then

            Skype.CurrentUserProfile.FullName = "ʕ•ᴥ•ʔ"
            LoyalButton107.Text = "Reset Name"
        Else
            LoyalButton107.Text = "ʕ•ᴥ•ʔ"
            Skype.CurrentUserProfile.FullName = Label1.Text


        End If
    End Sub

    Private Sub LoyalButton108_Click(sender As Object, e As EventArgs) Handles LoyalButton108.Click
        If LoyalButton108.Text = "﴾͡๏̯͡๏﴿ O'RLY?" Then

            Skype.CurrentUserProfile.FullName = "﴾͡๏̯͡๏﴿ O'RLY?"
            LoyalButton108.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
            LoyalButton108.Text = "﴾͡๏̯͡๏﴿ O'RLY?"
        End If

    End Sub

    Private Sub LoyalButton109_Click(sender As Object, e As EventArgs) Handles LoyalButton109.Click
        '(ᵔᴥᵔ)
        If LoyalButton109.Text = "(ᵔᴥᵔ)" Then
            Skype.CurrentUserProfile.FullName = "(ᵔᴥᵔ)"
            LoyalButton109.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
            LoyalButton109.Text = "(ᵔᴥᵔ)"
        End If
    End Sub

    Private Sub LoyalButton110_Click(sender As Object, e As EventArgs) Handles LoyalButton110.Click
        '(づ｡◕‿‿◕｡)づ
        If LoyalButton110.Text = "(づ｡◕‿‿◕｡)づ" Then
            Skype.CurrentUserProfile.FullName = "(づ｡◕‿‿◕｡)づ"
            LoyalButton110.Text = "Reset Name"

        End If
    End Sub

    Private Sub LoyalButton111_Click(sender As Object, e As EventArgs) Handles LoyalButton111.Click
        '(▀̿Ĺ̯▀̿ ̿)
        If LoyalButton111.Text = "(▀̿Ĺ̯▀̿ ̿)" Then
            Skype.CurrentUserProfile.FullName = "(▀̿Ĺ̯▀̿ ̿)"
            LoyalButton111.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
            LoyalButton111.Text = "(▀̿Ĺ̯▀̿ ̿)"
        End If
    End Sub

    Private Sub LoyalButton112_Click(sender As Object, e As EventArgs) Handles LoyalButton112.Click
        ' ヾ(⌐■_■)ノ♪

        If LoyalButton112.Text = " ヾ(⌐■_■)ノ♪" Then
            Skype.CurrentUserProfile.FullName = "ヾ(⌐■_■)ノ♪"
            LoyalButton112.Text = "Reset Name"
        Else
            Skype.CurrentUserProfile.FullName = Label1.Text
        End If
    End Sub

    Private Sub LoyalButton113_Click(sender As Object, e As EventArgs) Handles LoyalButton113.Click
        ' ̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿

        Skype.CurrentUserProfile.FullName = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"




    End Sub

    Private Sub LoyalButton114_Click(sender As Object, e As EventArgs) Handles LoyalButton114.Click
        '̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿

        Skype.CurrentUserProfile.FullName = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"

    End Sub

    Private Sub LoyalButton115_Click(sender As Object, e As EventArgs) Handles LoyalButton115.Click
        ' ̿'̿'\̵͇̿̿\З=( ͠° ͟ʖ ͡°)=Ε/̵͇̿̿/'̿̿ ̿ ̿ ̿ ̿ ̿


        Skype.CurrentUserProfile.FullName = "̿'̿'\̵͇̿̿\З=( ͠° ͟ʖ ͡°)=Ε/̵͇̿̿/'̿̿ ̿ ̿ ̿ ̿ ̿"

    End Sub

    Private Sub LoyalButton116_Click(sender As Object, e As EventArgs) Handles LoyalButton116.Click
        ' ▄︻̷̿┻̿═━一

        Skype.CurrentUserProfile.FullName = "▄︻̷̿┻̿═━一"

    End Sub
    Private Sub LoyalButton117_Click(sender As Object, e As EventArgs) Handles LoyalButton117.Click
        '(ง ͠° ͟ل͜ ͡°)ง

        Skype.CurrentUserProfile.FullName = "(ง ͠° ͟ل͜ ͡°)ง"

    End Sub

    Private Sub LoyalButton118_Click(sender As Object, e As EventArgs) Handles LoyalButton118.Click
        '(;´༎ຶД༎ຶ`)

        Skype.CurrentUserProfile.FullName = "(;´༎ຶД༎ຶ`)"

    End Sub

    Private Sub LoyalButton119_Click(sender As Object, e As EventArgs) Handles LoyalButton119.Click
        '(☞ﾟ∀ﾟ)☞

        Skype.CurrentUserProfile.FullName = "(☞ﾟ∀ﾟ)☞"

    End Sub

    Private Sub LoyalButton120_Click(sender As Object, e As EventArgs) Handles LoyalButton120.Click
        '  ☜(ﾟヮﾟ☜)
        Skype.CurrentUserProfile.FullName = " ☜(ﾟヮﾟ☜)"

    End Sub

    Private Sub LoyalButton121_Click(sender As Object, e As EventArgs) Handles LoyalButton121.Click
        ' (☞ﾟヮﾟ)☞ ☜(ﾟヮﾟ☜)
        Skype.CurrentUserProfile.FullName = "(☞ﾟヮﾟ)☞ ☜(ﾟヮﾟ☜)"

    End Sub

    Private Sub LoyalButton122_Click(sender As Object, e As EventArgs) Handles LoyalButton122.Click
        ' (ง'̀-'́)ง
        Skype.CurrentUserProfile.FullName = "(ง'̀-'́)ง"

    End Sub

    Private Sub LoyalButton123_Click(sender As Object, e As EventArgs) Handles LoyalButton123.Click
        ' ~(˘▾˘~)
        Skype.CurrentUserProfile.FullName = "~(˘▾˘~)"

    End Sub

    Private Sub LoyalButton124_Click(sender As Object, e As EventArgs) Handles LoyalButton124.Click
        Skype.CurrentUserProfile.FullName = "(~˘▾˘)~"

    End Sub

    Private Sub LoyalButton125_Click(sender As Object, e As EventArgs) Handles LoyalButton125.Click
        '(~˘▾˘)~ ~(˘▾˘~)
        Skype.CurrentUserProfile.FullName = "(~˘▾˘)~ ~(˘▾˘~)"
    End Sub

    Private Sub LoyalButton126_Click(sender As Object, e As EventArgs) Handles LoyalButton126.Click
        'ب_ب
        Skype.CurrentUserProfile.FullName = "ب_ب"
    End Sub

    Private Sub LoyalButton127_Click(sender As Object, e As EventArgs) Handles LoyalButton127.Click
        Skype.CurrentUserProfile.FullName = "¬_¬"

    End Sub

    Private Sub LoyalButton128_Click(sender As Object, e As EventArgs) Handles LoyalButton128.Click
        '°Д°
        Skype.CurrentUserProfile.FullName = "°Д°"

    End Sub

    Private Sub LoyalButton129_Click(sender As Object, e As EventArgs) Handles LoyalButton129.Click
        'ಠoಠ
        Skype.CurrentUserProfile.FullName = "ಠoಠ"

    End Sub

    Private Sub LoyalButton130_Click(sender As Object, e As EventArgs) Handles LoyalButton130.Click
        'ಠ~ಠ
        Skype.CurrentUserProfile.FullName = "ಠ~ಠ"

    End Sub

    Private Sub LoyalButton131_Click(sender As Object, e As EventArgs) Handles LoyalButton131.Click
        Skype.CurrentUserProfile.FullName = "(>ლ)"
    End Sub

    Private Sub LoyalButton132_Click(sender As Object, e As EventArgs) Handles LoyalButton132.Click
        Skype.CurrentUserProfile.FullName = "(；一_一)"
    End Sub

    Private Sub LoyalButton133_Click(sender As Object, e As EventArgs) Handles LoyalButton133.Click
        Skype.CurrentUserProfile.FullName = "(¬_¬)"

    End Sub

    Private Sub LoyalButton134_Click(sender As Object, e As EventArgs) Handles LoyalButton134.Click
        Skype.CurrentUserProfile.FullName = "(─‿‿─)"

    End Sub

    Private Sub LoyalButton135_Click(sender As Object, e As EventArgs) Handles LoyalButton135.Click
        Skype.CurrentUserProfile.FullName = "( ⚆ _ ⚆ )"

    End Sub

    Private Sub LoyalButton136_Click(sender As Object, e As EventArgs) Handles LoyalButton136.Click
        Skype.CurrentUserProfile.About = "\ (•◡•) /"
    End Sub

    Private Sub LoyalButton137_Click(sender As Object, e As EventArgs) Handles LoyalButton137.Click
        Skype.CurrentUserProfile.FullName = "ᕦ(ò_óˇ)ᕤ"
    End Sub

    Private Sub LoyalButton138_Click(sender As Object, e As EventArgs) Handles LoyalButton138.Click
        Skype.CurrentUserProfile.FullName = "◔̯◔"

    End Sub

    Private Sub LoyalButton139_Click(sender As Object, e As EventArgs) Handles LoyalButton139.Click
        Skype.CurrentUserProfile.FullName = "｡゜(｀Д´)゜｡"

    End Sub

    Private Sub LoyalButton140_Click(sender As Object, e As EventArgs) Handles LoyalButton140.Click
        Skype.CurrentUserProfile.FullName = "ʘ‿ʘ"

    End Sub

    Private Sub LoyalButton141_Click(sender As Object, e As EventArgs) Handles LoyalButton141.Click
        Skype.CurrentUserProfile.FullName = "☜(⌒▽⌒)☞"

    End Sub

    Private Sub LoyalButton142_Click(sender As Object, e As EventArgs) Handles LoyalButton142.Click
        Skype.CurrentUserProfile.FullName = "☼.☼"

    End Sub

    Private Sub LoyalButton143_Click(sender As Object, e As EventArgs) Handles LoyalButton143.Click
        Skype.CurrentUserProfile.FullName = "(/) (°,,°) (/)"
    End Sub

    Private Sub LoyalButton144_Click(sender As Object, e As EventArgs) Handles LoyalButton144.Click
        Skype.CurrentUserProfile.FullName = "〆(・∀・＠)"

    End Sub

    Private Sub LoyalButton145_Click(sender As Object, e As EventArgs) Handles LoyalButton145.Click
        Skype.CurrentUserProfile.FullName = "(>人<)"
    End Sub

    Private Sub LoyalButton148_Click(sender As Object, e As EventArgs) Handles LoyalButton148.Click


        LoyalTextBox19.Text = Skype1.User(MetroComboBox2.Text).FullName.ToString()
        LoyalTextBox22.Text = Skype1.User(MetroComboBox2.Text).MoodText.ToString()
        LoyalTextBox24.Text = Skype1.User(MetroComboBox2.Text).OnlineStatus.ToString()
        LoyalTextBox25.Text = Skype1.User(MetroComboBox2.Text).Timezone.ToString()
        LoyalTextBox26.Text = Skype1.User(MetroComboBox2.Text).Sex.ToString()
        LoyalTextBox27.Text = Skype1.User(MetroComboBox2.Text).PhoneMobile.ToString()
        LoyalTextBox28.Text = Skype1.User(MetroComboBox2.Text).PhoneHome.ToString()
        LoyalTextBox29.Text = Skype1.User(MetroComboBox2.Text).PhoneOffice.ToString()
        LoyalTextBox30.Text = Skype1.User(MetroComboBox2.Text).Country.ToString()
        LoyalTextBox31.Text = Skype1.User(MetroComboBox2.Text).City.ToString()
        LoyalTextBox32.Text = Skype1.User(MetroComboBox2.Text).NumberOfAuthBuddies.ToString()
        LoyalTextBox33.Text = Skype1.User(MetroComboBox2.Text).Province.ToString()
        LoyalTextBox34.Text = Skype1.User(MetroComboBox2.Text).Language.ToString()
        LoyalTextBox35.Text = Skype1.User(MetroComboBox2.Text).ReceivedAuthRequest.ToString()
        LoyalTextBox36.Text = Skype1.User(MetroComboBox2.Text).BuddyStatus.ToString()
        LoyalTextBox37.Text = Skype1.User(MetroComboBox2.Text).CountryCode.ToString()
        LoyalTextBox38.Text = Skype1.User(MetroComboBox2.Text).Birthday.ToString()
        LoyalTextBox39.Text = Skype1.User(MetroComboBox2.Text).Homepage()
        LoyalTextBox40.Text = Skype1.User(MetroComboBox2.Text).IsBlocked()
        LoyalTextBox41.Text = Skype1.User(MetroComboBox2.Text).IsSkypeOutContact()
        LoyalTextBox42.Text = Skype1.User(MetroComboBox2.Text).Aliases()
        LoyalTextBox43.Text = Skype1.User(MetroComboBox2.Text).HasCallEquipment()
        LoyalTextBox44.Text = Skype1.User(MetroComboBox2.Text).IsVideoCapable()
        LoyalTextBox45.Text = Skype1.User(MetroComboBox2.Text).LastOnline()
        LoyalTextBox46.Text = Skype1.User(MetroComboBox2.Text).SpeedDial()
        LoyalTextBox47.Text = Skype1.User(MetroComboBox2.Text).GetHashCode()
        LoyalTextBox48.Text = Skype1.User(MetroComboBox2.Text).IsAuthorized()
        LoyalTextBox49.Text = Skype1.User(MetroComboBox2.Text).IsVideoCapable()



    End Sub

    Private Sub LoyalButton152_Click(sender As Object, e As EventArgs) Handles LoyalButton152.Click

        Timer4.Start()

    End Sub

    Private Sub LoyalButton153_Click(sender As Object, e As EventArgs) Handles LoyalButton153.Click

        Timer4.Stop()

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        Me.Skype.SendMessage(MetroComboBox4.Text, LoyalTextBox50.Text)

    End Sub

    Private Sub LoyalButton155_Click(sender As Object, e As EventArgs) Handles LoyalButton155.Click


        Timer5.Start()

    End Sub

    Private Sub LoyalButton154_Click(sender As Object, e As EventArgs) Handles LoyalButton154.Click

        Timer5.Stop()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        Me.Skype.SendMessage(MetroComboBox5.Text, "	(smoking) (drunk) (oliver) (malthe) (tauri) (santa) (holidayspirit) (festiveparty) (LFCclap) (LFCfacepalm) 	(LFClaugh) 	(LFCparty) 	(LFCworried) (ghost) (emo) (cool) (ttm)")

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick


        Dim emptymsg As SKYPE4COMLib.ChatMessage = Skype.SendMessage(MetroComboBox6.Text, ".")

        If emptymsg.Body = "." Then

        End If

        emptymsg.Body = ""

    End Sub

    Private Sub LoyalButton157_Click(sender As Object, e As EventArgs) Handles LoyalButton157.Click


        Timer6.Start()

    End Sub

    Private Sub LoyalButton156_Click(sender As Object, e As EventArgs) Handles LoyalButton156.Click


        Timer6.Stop()


    End Sub

    Private Sub LoyalButton159_Click(sender As Object, e As EventArgs) Handles LoyalButton159.Click

        Timer7.Start()

    End Sub

    Private Sub LoyalButton158_Click(sender As Object, e As EventArgs) Handles LoyalButton158.Click

        Timer7.Stop()

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        Me.Skype.SendMessage(MetroComboBox7.Text, "hi")
        Me.Skype.SendMessage(MetroComboBox7.Text, "bye")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hey hey")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I love you (drunk)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I hate you (Smoke)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "kek")
        Me.Skype.SendMessage(MetroComboBox7.Text, "to to to to to")
        Me.Skype.SendMessage(MetroComboBox7.Text, "aye aye")
        Me.Skype.SendMessage(MetroComboBox7.Text, "GG")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I know where you live >;)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "mega hega")
        Me.Skype.SendMessage(MetroComboBox7.Text, "umm.., hu hu hu")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I'm running out of ideas ;c")
        Me.Skype.SendMessage(MetroComboBox7.Text, "goodbey")
        Me.Skype.SendMessage(MetroComboBox7.Text, "Get a life")
        Me.Skype.SendMessage(MetroComboBox7.Text, "You have a life.. :|")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I have no words")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hows life!?, MINES DEAD :D")
        Me.Skype.SendMessage(MetroComboBox7.Text, "ello")
        Me.Skype.SendMessage(MetroComboBox7.Text, "bello")
        Me.Skype.SendMessage(MetroComboBox7.Text, "cool")
        Me.Skype.SendMessage(MetroComboBox7.Text, "not cool")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I am the one the only one that don't need a dick to get pussy-I MEAN DON'T NEED A GUN TO GET REPSECT ON THE STREET O-O")
        Me.Skype.SendMessage(MetroComboBox7.Text, "(smoke) (drunk)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "(smoke) (Smoke)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "kekkekekekkeek")
        Me.Skype.SendMessage(MetroComboBox7.Text, "to to to to to ta  ta ta ta ta ta")
        Me.Skype.SendMessage(MetroComboBox7.Text, "aye aye bo bo bo bo bo bo boob!")
        Me.Skype.SendMessage(MetroComboBox7.Text, "G FUCKING G")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I know where you live and I will poke you >:)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "Nigahiga")
        Me.Skype.SendMessage(MetroComboBox7.Text, "umm.., hu hu hu nu nu nu nu")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I'm running out of ideas, really help ME  ;c")
        Me.Skype.SendMessage(MetroComboBox7.Text, "goodbey, have a shit time :D")
        Me.Skype.SendMessage(MetroComboBox7.Text, "Get a life, oh wait you can't")
        Me.Skype.SendMessage(MetroComboBox7.Text, "You have a life.. :|, fuck this then")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I have no words, literally sucking ass right now :)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hows life!?, MINES DEAD LITERALLY :D")
        Me.Skype.SendMessage(MetroComboBox7.Text, "ello bello")
        Me.Skype.SendMessage(MetroComboBox7.Text, "bello ello")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hi byy")
        Me.Skype.SendMessage(MetroComboBox7.Text, "bye hi")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hey hey, bye bye")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I love you (drunk), NOT")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I hate you (Smoke) DO")
        Me.Skype.SendMessage(MetroComboBox7.Text, "kekekek")
        Me.Skype.SendMessage(MetroComboBox7.Text, "to to to to to ooh oh oh <3")
        Me.Skype.SendMessage(MetroComboBox7.Text, "<3333333333333333")
        Me.Skype.SendMessage(MetroComboBox7.Text, "G-G")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I know where you live, I will pee on you >;)")
        Me.Skype.SendMessage(MetroComboBox7.Text, "mega hega, ikikikikikikikikikiki")
        Me.Skype.SendMessage(MetroComboBox7.Text, "umm.., hu hu hu, oo o o o oo o oo oo  o o o")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I'm running out of ideas, help ;c")
        Me.Skype.SendMessage(MetroComboBox7.Text, "goodbey, goodhi")
        Me.Skype.SendMessage(MetroComboBox7.Text, "Get a life, or not")
        Me.Skype.SendMessage(MetroComboBox7.Text, "You have a life.., amazing :|")
        Me.Skype.SendMessage(MetroComboBox7.Text, "I have no words,  bbeaca8eas I cante spell")
        Me.Skype.SendMessage(MetroComboBox7.Text, "hows life!?, MINES DEAD, REALLY DEAD :D")
        Me.Skype.SendMessage(MetroComboBox7.Text, "ello, bello, fuckeyou")
        Me.Skype.SendMessage(MetroComboBox7.Text, "bello,ello,kello")

    End Sub

    Private Sub LoyalButton163_Click(sender As Object, e As EventArgs) Handles LoyalButton163.Click

        Timer8.Start()

    End Sub

    Private Sub LoyalButton162_Click(sender As Object, e As EventArgs) Handles LoyalButton162.Click
        Timer8.Stop()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        For Each Person As SKYPE4COMLib.User In Skype.Friends
            Dim Contact = Person.FullName
            For Each User As System.String In LoyalTextBox51.Text
                If Contact = User Then
                    Dim aSkype As SKYPE4COMLib.Skype
                    aSkype = New SKYPE4COMLib.Skype
                    Dim oChat As Chat
                    Dim oMembers As New SKYPE4COMLib.UserCollection
                    oMembers = CreateObject("Skype4COM.UserCollection")
                    oMembers.Add(Skype.User(Person.Handle))
                    oMembers.Add(Skype.User(Person.Handle))
                    oChat = Skype.CreateChatMultiple(oMembers)
                    oChat.Topic = "YourText"
                End If
            Next
        Next
    End Sub


    Private Sub LoyalButton164_Click(sender As Object, e As EventArgs) Handles LoyalButton164.Click

        Try
            Dim enumerator As IEnumerator = Me.Skype.Friends.GetEnumerator()
            While enumerator.MoveNext()
                Try
                    Dim user As User = CType(enumerator.Current, User)
                    Me.Skype.SendMessage(user.Handle, LoyalTextBox52.Text)
                Catch ex As Exception

                End Try
            End While
        Finally
            Dim enumerator As IEnumerator = Me.Skype.Friends.GetEnumerator()
            Try
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            Catch ex As Exception

            End Try
        End Try



    End Sub

    Private Sub LoyalButton166_Click(sender As Object, e As EventArgs) Handles LoyalButton166.Click

        If LoyalButton166.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            LoyalButton166.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "ᕙ(⇀‸↼‶)ᕗ"
        Else
            LoyalButton166.Text = "ᕙ(⇀‸↼‶)ᕗ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton167_Click(sender As Object, e As EventArgs) Handles LoyalButton167.Click


        If LoyalButton167.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton167.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
        Else
            LoyalButton167.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton168_Click(sender As Object, e As EventArgs) Handles LoyalButton168.Click

        If LoyalButton168.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" Then

            LoyalButton168.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"
        Else
            LoyalButton168.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton169_Click(sender As Object, e As EventArgs) Handles LoyalButton169.Click

        If LoyalButton169.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" Then

            LoyalButton169.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"

        Else
            LoyalButton169.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton173_Click(sender As Object, e As EventArgs) Handles LoyalButton173.Click

        If LoyalButton173.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            LoyalButton173.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "ᕙ(⇀‸↼‶)ᕗ" & "</blink>"
        Else
            LoyalButton173.Text = "ᕙ(⇀‸↼‶)ᕗ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton172_Click(sender As Object, e As EventArgs) Handles LoyalButton172.Click

        If LoyalButton172.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton172.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" & "</blink>"
        Else

            LoyalButton172.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = ""


        End If

    End Sub

    Private Sub LoyalButton171_Click(sender As Object, e As EventArgs) Handles LoyalButton171.Click

        If LoyalButton171.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" Then

            LoyalButton171.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & " ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" & "</blink>"
        Else
            LoyalButton171.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton170_Click(sender As Object, e As EventArgs) Handles LoyalButton170.Click

        If LoyalButton170.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" Then

            LoyalButton170.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" & "</blink>"
        Else
            LoyalButton170.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton177_Click(sender As Object, e As EventArgs) Handles LoyalButton177.Click

        If LoyalButton177.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            LoyalButton177.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "ᕙ(⇀‸↼‶)ᕗ" & "<spinner>""</spinner>"
        Else
            LoyalButton177.Text = "ᕙ(⇀‸↼‶)ᕗ"
            Skype.CurrentUserProfile.MoodText = "ᕙ(⇀‸↼‶)ᕗ"

        End If

    End Sub

    Private Sub LoyalButton176_Click(sender As Object, e As EventArgs) Handles LoyalButton176.Click

        If LoyalButton176.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton176.Text = "Reset Mood"
            Skype.CurrentUserProfile.MoodText = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" & "<spinner>""</spinner>"
        Else
            LoyalButton176.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"

        End If

    End Sub

    Private Sub LoyalButton175_Click(sender As Object, e As EventArgs) Handles LoyalButton175.Click

        If LoyalButton175.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" Then

            LoyalButton175.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" & "<spinner>""</spinner>"
        Else
            LoyalButton175.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton174_Click(sender As Object, e As EventArgs) Handles LoyalButton174.Click

        If LoyalButton174.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" Then

            LoyalButton174.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" & "<spinner>""</spinner>"
        Else
            LoyalButton174.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton181_Click(sender As Object, e As EventArgs) Handles LoyalButton181.Click

        If LoyalButton181.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            LoyalButton181.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ᕙ(⇀‸↼‶)ᕗ" & "</ZapButton>"
        Else
            LoyalButton181.Text = "ᕙ(⇀‸↼‶)ᕗ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

        ' Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ᕙ(⇀‸↼‶)ᕗ" & "</ZapButton>"
    End Sub

    Private Sub LoyalButton180_Click(sender As Object, e As EventArgs) Handles LoyalButton180.Click

        If LoyalButton180.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton180.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" & "</ZapButton>"

        Else
            LoyalButton180.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton179_Click(sender As Object, e As EventArgs) Handles LoyalButton179.Click
        '̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿
        If LoyalButton180.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton180.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" & "</ZapButton>"
        Else
            LoyalButton180.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton178_Click(sender As Object, e As EventArgs) Handles LoyalButton178.Click
        '̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿
        If LoyalButton179.Text = " ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" Then

            LoyalButton179.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & " ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" & "</ZapButton>"
        Else
            LoyalButton179.Text = " ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton185_Click(sender As Object, e As EventArgs) Handles LoyalButton185.Click
        'ᕙ(⇀‸↼‶)ᕗ
        If LoyalButton185.Text = "ᕙ(⇀‸↼‶)ᕗ" Then

            LoyalButton185.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "ᕙ(⇀‸↼‶)ᕗ" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton185.Text = "ᕙ(⇀‸↼‶)ᕗ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub
    Private Sub LoyalButton184_Click(sender As Object, e As EventArgs) Handles LoyalButton184.Click
        'ლ,ᔑ•ﺪ͟͠•ᔐ.ლ
        If LoyalButton184.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" Then

            LoyalButton184.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton184.Text = "ლ,ᔑ•ﺪ͟͠•ᔐ.ლ"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub
    Private Sub LoyalButton183_Click(sender As Object, e As EventArgs) Handles LoyalButton183.Click
        '̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿
        If LoyalButton183.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" Then

            LoyalButton183.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton183.Text = "̿̿ ̿̿ ̿̿ ̿'̿'\̵͇̿̿\З= ( ▀ ͜͞ʖ▀) =Ε/̵͇̿̿/’̿’̿ ̿ ̿̿ ̿̿ ̿̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub
    Private Sub LoyalButton182_Click(sender As Object, e As EventArgs) Handles LoyalButton182.Click
        '̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿
        If LoyalButton182.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" Then

            LoyalButton182.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton182.Text = "̿ ̿ ̿'̿'\̵͇̿̿\З=(•_•)=Ε/̵͇̿̿/'̿'̿ ̿"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton191_Click(sender As Object, e As EventArgs) Handles LoyalButton191.Click

        If LoyalButton191.Text = "(~˘▾˘)~" Then

            LoyalButton191.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(~˘▾˘)~" & "</ZapButton>"

        Else
            LoyalButton191.Text = "(~˘▾˘)~"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton198_Click(sender As Object, e As EventArgs) Handles LoyalButton198.Click
        If LoyalButton198.Text = "~(˘▾˘~)~" Then

            LoyalButton198.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "~(˘▾˘~)" & "</ZapButton>"

        Else
            LoyalButton198.Text = "~(˘▾˘~)"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton202_Click(sender As Object, e As EventArgs) Handles LoyalButton202.Click
        If LoyalButton202.Text = "(~˘▾˘)~ ~(˘▾˘~)" Then

            LoyalButton202.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(~˘▾˘)~ ~(˘▾˘~)" & "</ZapButton>"

        Else
            LoyalButton202.Text = "(~˘▾˘)~ ~(˘▾˘~)"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton201_Click(sender As Object, e As EventArgs) Handles LoyalButton201.Click
        If LoyalButton201.Text = "( ' ___ ' )" Then

            LoyalButton201.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "( ' ___ ' )" & "</ZapButton>"

        Else
            LoyalButton201.Text = "( ' ___ ' )"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton197_Click(sender As Object, e As EventArgs) Handles LoyalButton197.Click
        If LoyalButton197.Text = "('⌣෴⌣')" Then

            LoyalButton197.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "('⌣෴⌣')" & "</ZapButton>"

        Else
            LoyalButton197.Text = "('⌣෴⌣')"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton194_Click(sender As Object, e As EventArgs) Handles LoyalButton194.Click
        If LoyalButton194.Text = "ಠ~ಠ" Then

            LoyalButton194.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ಠ~ಠ" & "</ZapButton>"

        Else
            LoyalButton194.Text = "ಠ~ಠ"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton192_Click(sender As Object, e As EventArgs) Handles LoyalButton192.Click
        If LoyalButton192.Text = "ಠ‿↼" Then

            LoyalButton192.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "ಠ‿↼" & "</ZapButton>"

        Else
            LoyalButton192.Text = "ಠ‿↼"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton189_Click(sender As Object, e As EventArgs) Handles LoyalButton189.Click
        If LoyalButton189.Text = "☼.☼" Then

            LoyalButton189.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "☼.☼" & "</ZapButton>"

        Else
            LoyalButton189.Text = "☼.☼"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton188_Click(sender As Object, e As EventArgs) Handles LoyalButton188.Click
        If LoyalButton188.Text = "˙ ͜ʟ˙" Then

            LoyalButton188.Text = "Reset Mood"
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "˙ ͜ʟ˙" & "</ZapButton>"

        Else
            LoyalButton188.Text = "˙ ͜ʟ˙"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton190_Click(sender As Object, e As EventArgs) Handles LoyalButton190.Click
        If LoyalButton190.Text = "(~˘▾˘)~" Then

            LoyalButton190.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(~˘▾˘)~" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton190.Text = "(~˘▾˘)~"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton199_Click(sender As Object, e As EventArgs) Handles LoyalButton199.Click

        If LoyalButton199.Text = "~(˘▾˘~)" Then

            LoyalButton199.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "~(˘▾˘~)" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton199.Text = "~(˘▾˘~)"
            Skype.CurrentUserProfile.MoodText = ""

        End If
    End Sub

    Private Sub LoyalButton203_Click(sender As Object, e As EventArgs) Handles LoyalButton203.Click
        '(~˘▾˘)~ ~(˘▾˘~)

        If LoyalButton203.Text = "(~˘▾˘)~ ~(˘▾˘~)" Then

            LoyalButton203.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(~˘▾˘)~ ~(˘▾˘~)" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton203.Text = "(~˘▾˘)~ ~(˘▾˘~)"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton200_Click(sender As Object, e As EventArgs) Handles LoyalButton200.Click
        '( ' ___ ' )

        If LoyalButton200.Text = "( ' ___ ' )" Then

            LoyalButton200.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "( ' ___ ' )" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton200.Text = "( ' ___ ' )"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton196_Click(sender As Object, e As EventArgs) Handles LoyalButton196.Click
        '('⌣෴⌣')

        If LoyalButton196.Text = "('⌣෴⌣')" Then

            LoyalButton196.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "('⌣෴⌣')" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton196.Text = "('⌣෴⌣')"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton195_Click(sender As Object, e As EventArgs) Handles LoyalButton195.Click
        'ಠ~ಠ

        If LoyalButton195.Text = "ಠ~ಠ" Then

            LoyalButton195.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "ಠ~ಠ" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton195.Text = "ಠ~ಠ"
            Skype.CurrentUserProfile.MoodText = ""

        End If


    End Sub

    Private Sub LoyalButton193_Click(sender As Object, e As EventArgs) Handles LoyalButton193.Click
        'ಠ‿↼

        If LoyalButton193.Text = "ಠ‿↼" Then

            LoyalButton193.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "ಠ‿↼" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton193.Text = "ಠ‿↼"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub LoyalButton187_Click(sender As Object, e As EventArgs) Handles LoyalButton187.Click
        '☼.☼

        If LoyalButton187.Text = "☼.☼" Then

            LoyalButton187.Text = "Reset Mood"
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "☼.☼" & "</blink>" & "<spinner>""</spinner>"

        Else
            LoyalButton187.Text = "☼.☼"
            Skype.CurrentUserProfile.MoodText = ""

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        MessageBox.Show("We haven't Finished Velyse Encryption  Decryption Tool YET, we will hyperlink this when we have posted a thread of he release", "Velyse Skype Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' System.Diagnostics.Process.Start("http://velyse.net/index.php")

    End Sub

    Private Sub LoyalButton149_Click(sender As Object, e As EventArgs) Handles LoyalButton149.Click
        MessageBox.Show("We haven't finished adding a profile stealer yet, this will be added in the next update", "Velyse Skype Tool", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' PictureBox1.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData("https://api.skype.com/user/" + MetroComboBox3.SelectedItem + "/profile/avatar")))

    End Sub

    Private Sub LoyalButton205_Click(sender As Object, e As EventArgs) Handles LoyalButton205.Click

        Skype.CurrentUserProfile.FullName = "(ಥ﹏ಥ)"

    End Sub

    Private Sub LoyalButton204_Click(sender As Object, e As EventArgs) Handles LoyalButton204.Click

        Skype.CurrentUserProfile.FullName = "(͡ ͡° ͜ つ ͡͡°)"

    End Sub

    Private Sub LoyalButton207_Click(sender As Object, e As EventArgs) Handles LoyalButton207.Click

        Skype.CurrentUserProfile.FullName = "(¬‿¬)"

    End Sub

    Private Sub LoyalButton206_Click(sender As Object, e As EventArgs) Handles LoyalButton206.Click

        Skype.CurrentUserProfile.FullName = "♥‿♥"

    End Sub

    Private Sub LoyalButton209_Click(sender As Object, e As EventArgs) Handles LoyalButton209.Click

        Skype.CurrentUserProfile.FullName = "[̲̅$̲̅(̲̅5̲̅)̲̅$̲̅]"

    End Sub

    Private Sub LoyalButton208_Click(sender As Object, e As EventArgs) Handles LoyalButton208.Click
        Skype.CurrentUserProfile.FullName = "[̲̅$̲̅(̲̅ ͡° ͜ʖ ͡°̲̅)̲̅$̲̅]"
    End Sub

    Private Sub VelysesSkypeTool_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed

        System.Diagnostics.Process.Start("http://velyse.net/index.php")
        NotifyIcon1.ShowBalloonTip(3000, "Velyse Skype Tool", "We adivce you NOT to close or end the procces of Velyse's Skype Tool.", ToolTipIcon.Info)
        NotifyIcon1.ShowBalloonTip(3000, "Velyse Skype Tool", "Hey there thank you for using Velyse's Skype Tool!, also Velye's Skype Tool will still be running in the background checking for updates.", ToolTipIcon.Info)

    End Sub

    Private Sub LoyalButton160_Click(sender As Object, e As EventArgs) Handles LoyalButton160.Click


        Timer9.Start()
    End Sub

    Private Sub LoyalButton161_Click(sender As Object, e As EventArgs) Handles LoyalButton161.Click

        Timer9.Stop()

    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick

        Skype.PlaceCall(MetroComboBox8.Text)
        Timer4.Interval = 0.5
        Skype.ActiveCalls(1).Finish()

    End Sub

    Public Sub CheckForUpdates()

        '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("YOUR LINK HERE")
        '    Dim response As System.Net.HttpWebResponse = request.GetResponse()

        '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        '    Dim newestversion As String = sr.ReadToEnd()
        '    Dim currentversion As String = Application.ProductVersion

        '    If newestversion.Contains(currentversion) Then
        '        MsgBox("Your software is up to date.")

        '    Else

        '        MsgBox("There is a new update, it will begin to download.")
        '        System.Diagnostics.Process.Start("YOUR LINK HERE")

        '    End If
    End Sub

    Private Sub MetroRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroRadioButton1.CheckedChanged

Mute:   Skype.Mute = True
unMute: Skype.Mute = False

    End Sub

    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If MetroTextBox1.Text.ToLower().Contains(";cmds") Then
                MetroTextBox2.Text = "There is currently - commands" & vbNewLine & vbNewLine & "===NAME===" & vbNewLine & ";Set Name: -Sets Your Name:  ;Set Name: Phoenix 101" & vbNewLine & vbNewLine & "===MOOD===" & vbNewLine & ";Set Mood:  -Sets Your Current Mood: ;Set Mood: I am lord poop" & vbNewLine & ";Set Blinking Mood: -Makes your mood test: ;Set Blinking Mood: Blinking Poop!" & vbNewLine & ";Set Spinner Mood: -Theres Spinners in your mood!: ;Set Spinner Mood: The Spinning Poop!" & vbNewLine & ";Set Dark Mood: -Gives You A Dark Mood ;): ;Set Dark Mood: Dark poop" & vbNewLine & ";Set Spinner + Blink Mood: -Sets your mood to have the spinner plus the blink efffect: ;Set Spinner + Blink Mood: I am a blinking spinning poop! :D" & vbNewLine & ";Mood Reset -Resets your mood" & vbNewLine & vbNewLine & "==MESSAGING===" & vbNewLine & ";Send Mass Message:  -Send a message to everybody in your contact list: ;Send Mass Message: Hi" & vbNewLine & vbNewLine & "===MISC===" & vbNewLine & ";Reset -Resets This Box To How It Was At The Start" & vbNewLine & ";Close -Closes Velyse's Skype Tool" & vbNewLine & ";cls -clears everything in the box" & vbNewLine & vbNewLine & "NOTE: You can have the text in any way like ;set mood: or ;sEt MOod: than ;Set Mood:"
                MetroTextBox1.Text = ""
            End If
            If MetroTextBox1.Text.ToLower().Contains(";set name:") Then
                Dim strName As String = MetroTextBox1.Text.Replace(";set name:", "")
                strName = strName.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";Set Name: " & vbNewLine & strName
                Skype.CurrentUserProfile.FullName = strName
            End If
            If MetroTextBox1.Text.ToLower().Contains(";set mood:") Then
                Dim strMood As String = MetroTextBox1.Text.Replace(";Set Mood:", "")
                strMood = strMood.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";Set Mood: " & vbNewLine & strMood
                Skype.CurrentUserProfile.MoodText = strMood
            End If
            If MetroTextBox1.Text.ToLower().Contains(";send mass message:") Then
                Dim strMassMessage As String = MetroTextBox1.Text.Replace(";send mass message:", "")
                strMassMessage = strMassMessage.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";Send Mass Message:" & vbNewLine & strMassMessage
                Try
                    Dim enumerator As IEnumerator = Me.Skype.Friends.GetEnumerator()
                    While enumerator.MoveNext()
                        Try
                            Dim user As User = CType(enumerator.Current, User)
                            Me.Skype.SendMessage(user.Handle, strMassMessage)
                        Catch ex As Exception

                        End Try
                    End While
                Finally
                    Dim enumerator As IEnumerator = Me.Skype.Friends.GetEnumerator()
                    Try
                        If TypeOf enumerator Is IDisposable Then
                            TryCast(enumerator, IDisposable).Dispose()
                        End If
                    Catch ex As Exception

                    End Try
                End Try
            End If

            If MetroTextBox1.Text.ToLower().Contains(";set blinking mood:") Then
                Dim strBlinkingMood As String = MetroTextBox1.Text.Replace(";set blinking mood:", "")
                strBlinkingMood = strBlinkingMood.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";set blinking mood: " & vbNewLine & strBlinkingMood
                Skype.CurrentUserProfile.RichMoodText = "<blink>" & strBlinkingMood & "</blink>"
            End If
            If MetroTextBox1.Text.ToLower().Contains(";set spinner mood:") Then
                Dim strSpinnerMood As String = MetroTextBox1.Text.Replace(";set spinner mood:", "")
                strSpinnerMood = strSpinnerMood.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";set spinner mood: " & vbNewLine & strSpinnerMood
                Me.Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & strSpinnerMood & "<spinner>""</spinner>"
            End If
            If MetroTextBox1.Text.ToLower().Contains(";set dark mood:") Then
                Dim strDarkMood As String = MetroTextBox1.Text.Replace(";set spinner mood:", "")
                strDarkMood = strDarkMood.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";set dark mod: " & vbNewLine & strDarkMood
                Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & strDarkMood & "</ZapButton>"
            End If
            If MetroTextBox1.Text.ToLower().Contains(";set spinner + blink mood:") Then
                Dim strSpinnerBlink As String = MetroTextBox1.Text.Replace(";set spinner + blink mood:", "")
                strSpinnerBlink = strSpinnerBlink.TrimStart(" ")
                MetroTextBox1.Text = ""
                MetroComboBox2.Text = MetroComboBox2.Text & vbNewLine & ";set spinner + blink mood: " & vbNewLine & strSpinnerBlink
                Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & strSpinnerBlink & "</blink>" & "<spinner>""</spinner>"

            End If
            If MetroTextBox1.Text.ToLower().Contains(";Spamm Message User:") Then

            End If

            If MetroTextBox1.Text.ToLower().Contains(";reset") Then
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = "Type in ;cmds to see the commands"
            End If
            If MetroTextBox1.Text.ToLower().Contains(";close") Then
                Me.Close()
            End If
            If MetroTextBox1.Text.ToLower().Contains(";mood reset") Then
                MetroTextBox1.Text = ""
                Skype.CurrentUserProfile.MoodText = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & ";Mood Reset" & vbNewLine & "Mood has been reseted!"
            End If
            If MetroTextBox1.Text.ToLower().Contains(";cls") Then
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = ""
            End If
            If MetroTextBox1.Text.ToLower().Contains(";play music: 1") Then
                My.Computer.Audio.Play(System.Windows.Forms.Application.StartupPath() & "\Sounds\PHFat_-_Kill_the_Universe.wav", AudioPlayMode.BackgroundLoop)
                MetroTextBox1.Text = ""
                MetroTextBox2.Text = MetroTextBox2.Text & vbNewLine & "Playing:" & vbNewLine & "PHFat-Kill The Universe"

            End If
            MetroTextBox1.Text = ""
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        System.Diagnostics.Process.Start("http://velyse.net/member.php?action=profile&uid=7#comments/1")

    End Sub

    Private Sub LoyalButton147_Click(sender As Object, e As EventArgs)

        My.Computer.Audio.Play("https://www.youtube.com/watch?v=il2LPL3iEJ0", AudioPlayMode.Background)

    End Sub

    Private Sub LoyalButton147_Click_1(sender As Object, e As EventArgs)
        'C:\Users\Me\Desktop\New folder\PHFat_-_Kill_the_Universe.wav

    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs)

        My.Computer.Audio.Play("C:\Users\Me\Desktop\New folder\PHFat_-_Kill_the_Universe.wav")

    End Sub


    Private Sub LoyalButton210_Click(sender As Object, e As EventArgs) Handles LoyalButton210.Click

        Dim pic = New OpenFileDialog

        If pic.ShowDialog = DialogResult.OK Then

            PictureBox3.BackgroundImage = Image.FromFile(pic.FileName)

        End If

    End Sub

    Private Sub LoyalButton165_Click(sender As Object, e As EventArgs) Handles LoyalButton165.Click

        If PictureBox3.Image IsNot Nothing Then

            'Form3.Show()


        Else

            For Each user As SKYPE4COMLib.User In Skype.Friends
                Clipboard.SetImage(PictureBox3.Image)
                Skype.Client.OpenMessageDialog(user.Handle)
                Skype.Client.Focus()
                SendKeys.Send("^(V){ENTER}")


            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If PictureBox3.Image IsNot Nothing Then

            For Each user As SKYPE4COMLib.User In Skype.Friends

                Clipboard.SetImage(PictureBox3.Image)
                On Error Resume Next
                Skype.Client.OpenMessageDialog(user.Handle)
                Skype.Client.Focus()
                SendKeys.Send("^(V){ENTER}")


            Next
        Else


        End If
    End Sub

    Private Sub LoyalButton147_Click_2(sender As Object, e As EventArgs) Handles LoyalButton147.Click



        My.Computer.Audio.Play(System.Windows.Forms.Application.StartupPath() & "\Sounds\" + MetroComboBox9.Text, AudioPlayMode.BackgroundLoop)


    End Sub

    Private Sub LoyalButton211_Click(sender As Object, e As EventArgs) Handles LoyalButton211.Click

        My.Computer.Audio.Stop()

    End Sub

    Private Sub LoyalButton212_Click(sender As Object, e As EventArgs) Handles LoyalButton212.Click

        NotifyIcon1.ShowBalloonTip(3000, MetroTextBox3.Text, MetroTextBox4.Text, ToolTipIcon.Info)

    End Sub

    Private Sub LoyalButton6_Click_1(sender As Object, e As EventArgs) Handles LoyalButton6.Click

        MessageBox.Show(MetroTextBox6.Text, MetroTextBox5.Text)

    End Sub

    Private Sub LoyalButton213_Click(sender As Object, e As EventArgs) Handles LoyalButton213.Click


        If MetroComboBox10.Text = "Anonymous" Then

            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")

            SAPI.Speak(MetroTextBox7.Text)

        End If

        If MetroComboBox10.Text = "Male" Then



        End If
        If MetroComboBox10.Text = "Female" Then



        End If
    End Sub

    Private Sub LoyalButton214_Click(sender As Object, e As EventArgs) Handles LoyalButton214.Click

        Form4.MetroLabel1.Text = MetroTextBox9.Text
        Form4.Text = MetroTextBox8.Text
        Form4.Show()

    End Sub

    Private Sub LoyalButton218_Click(sender As Object, e As EventArgs) Handles LoyalButton218.Click

        Skype.CurrentUserProfile.FullName = "(✿◠‿◠)"

    End Sub

    Private Sub LoyalButton216_Click(sender As Object, e As EventArgs) Handles LoyalButton216.Click

        Skype.CurrentUserProfile.FullName = "≧◡≦"

    End Sub

    Private Sub LoyalButton226_Click(sender As Object, e As EventArgs) Handles LoyalButton226.Click

        Skype.CurrentUserProfile.FullName = "(▰˘◡˘▰)"

    End Sub

    Private Sub LoyalButton224_Click(sender As Object, e As EventArgs) Handles LoyalButton224.Click

        Skype.CurrentUserProfile.FullName = "(⌒o⌒)"

    End Sub

    Private Sub LoyalButton220_Click(sender As Object, e As EventArgs) Handles LoyalButton220.Click

        Skype.CurrentUserProfile.FullName = "(^ｰ^)"

    End Sub

    Private Sub LoyalButton222_Click(sender As Object, e As EventArgs) Handles LoyalButton222.Click

        Skype.CurrentUserProfile.FullName = "(. ﾟーﾟ)"

    End Sub

    Private Sub LoyalButton234_Click(sender As Object, e As EventArgs) Handles LoyalButton234.Click

        Skype.CurrentUserProfile.FullName = "●﹏●"

    End Sub

    Private Sub LoyalButton232_Click(sender As Object, e As EventArgs) Handles LoyalButton232.Click

        Skype.CurrentUserProfile.FullName = "٩(-̮̮̃•̃)"

    End Sub

    Private Sub LoyalButton217_Click(sender As Object, e As EventArgs) Handles LoyalButton217.Click

        Skype.CurrentUserProfile.FullName = "(◠﹏◠✿)"

    End Sub

    Private Sub LoyalButton215_Click(sender As Object, e As EventArgs) Handles LoyalButton215.Click

        Skype.CurrentUserProfile.FullName = "ヾ(＠⌒▽⌒＠)ﾉ"

    End Sub

    Private Sub LoyalButton225_Click(sender As Object, e As EventArgs) Handles LoyalButton225.Click

        Skype.CurrentUserProfile.FullName = "(¤﹏¤)"

    End Sub

    Private Sub LoyalButton230_Click(sender As Object, e As EventArgs) Handles LoyalButton230.Click

        Skype.CurrentUserProfile.FullName = "≖‿≖"

    End Sub

    Private Sub LoyalButton223_Click(sender As Object, e As EventArgs) Handles LoyalButton223.Click

        Skype.CurrentUserProfile.FullName = "ヅ"

    End Sub

    Private Sub LoyalButton221_Click(sender As Object, e As EventArgs) Handles LoyalButton221.Click

        Skype.CurrentUserProfile.FullName = "◃┆◉◡◉┆▷"

    End Sub

    Private Sub LoyalButton219_Click(sender As Object, e As EventArgs) Handles LoyalButton219.Click

        Skype.CurrentUserProfile.FullName = "ʘ‿ʘ"

    End Sub

    Private Sub LoyalButton233_Click(sender As Object, e As EventArgs) Handles LoyalButton233.Click

        Skype.CurrentUserProfile.FullName = "१✌˚◡˚✌५"

    End Sub

    Private Sub LoyalButton231_Click(sender As Object, e As EventArgs) Handles LoyalButton231.Click

        Skype.CurrentUserProfile.FullName = "✌.ʕʘ‿ʘʔ.✌"

    End Sub

    Private Sub LoyalButton229_Click(sender As Object, e As EventArgs) Handles LoyalButton229.Click

        Skype.CurrentUserProfile.FullName = "^ ^"

    End Sub

    Private Sub LoyalButton228_Click(sender As Object, e As EventArgs) Handles LoyalButton228.Click

        Skype.CurrentUserProfile.FullName = "< (^^,) >"

    End Sub

    Private Sub LoyalButton227_Click(sender As Object, e As EventArgs) Handles LoyalButton227.Click

        Skype.CurrentUserProfile.FullName = "•(⌚_⌚)•"

    End Sub

    Private Sub LoyalButton236_Click(sender As Object, e As EventArgs) Handles LoyalButton236.Click

        Skype.CurrentUserProfile.FullName = " ❀◕ ‿ ◕❀ "

    End Sub

    Private Sub LoyalButton235_Click(sender As Object, e As EventArgs) Handles LoyalButton235.Click

        Skype.CurrentUserProfile.FullName = "(°⌣°)"

    End Sub

    Private Sub LoyalButton238_Click(sender As Object, e As EventArgs) Handles LoyalButton238.Click

        Skype.CurrentUserProfile.FullName = "Ü"

    End Sub

    Private Sub LoyalButton237_Click(sender As Object, e As EventArgs) Handles LoyalButton237.Click

        Skype.CurrentUserProfile.FullName = ".=^.^="

    End Sub

    Private Sub LoyalButton242_Click(sender As Object, e As EventArgs) Handles LoyalButton242.Click

        Skype.CurrentUserProfile.FullName = " ☆(❁‿❁)☆ "

    End Sub

    Private Sub LoyalButton241_Click(sender As Object, e As EventArgs) Handles LoyalButton241.Click

        Skype.CurrentUserProfile.FullName = "!⑈ˆ~ˆ!⑈"

    End Sub

    Private Sub LoyalButton240_Click(sender As Object, e As EventArgs) Handles LoyalButton240.Click

        Skype.CurrentUserProfile.FullName = "(*^ -^*)"

    End Sub

    Private Sub LoyalButton239_Click(sender As Object, e As EventArgs) Handles LoyalButton239.Click

        Skype.CurrentUserProfile.FullName = "╰(◡‿◡✿╰) "

    End Sub

    Private Sub LoyalButton243_Click(sender As Object, e As EventArgs) Handles LoyalButton243.Click

        Skype.CurrentUserProfile.FullName = "●‿●"

    End Sub

    Private Sub LoyalButton249_Click(sender As Object, e As EventArgs) Handles LoyalButton249.Click

        If LoyalButton249.Text = "१✌˚◡˚✌५" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "१✌˚◡˚✌५" & "</ZapButton>"
            LoyalButton249.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton249.Text = "१✌˚◡˚✌५"

        End If
    End Sub

    Private Sub LoyalButton248_Click(sender As Object, e As EventArgs) Handles LoyalButton248.Click

        If LoyalButton248.Text = "✌.ʕʘ‿ʘʔ.✌" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "✌.ʕʘ‿ʘʔ.✌" & "</ZapButton>"
            LoyalButton248.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton248.Text = "✌.ʕʘ‿ʘʔ.✌"

        End If
    End Sub

    Private Sub LoyalButton247_Click(sender As Object, e As EventArgs) Handles LoyalButton247.Click

        If LoyalButton247.Text = "^ ^" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "^ ^" & "</ZapButton>"
            LoyalButton247.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton247.Text = ""

        End If
    End Sub

    Private Sub LoyalButton246_Click(sender As Object, e As EventArgs) Handles LoyalButton246.Click

        If LoyalButton246.Text = "(*^ -^*)" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "(*^ -^*)" & "</ZapButton>"
            LoyalButton246.Text = "Rest Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton246.Text = "(*^ -^*)"

        End If
    End Sub

    Private Sub LoyalButton245_Click(sender As Object, e As EventArgs) Handles LoyalButton245.Click
        If LoyalButton245.Text = "╰(◡‿◡✿╰) " Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "╰(◡‿◡✿╰)" & "</ZapButton>"
            LoyalButton245.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton245.Text = "╰(◡‿◡✿╰)"
        End If
    End Sub

    Private Sub LoyalButton244_Click(sender As Object, e As EventArgs) Handles LoyalButton244.Click

        If LoyalButton244.Text = "●‿●" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "●‿●" & "</ZapButton>"
            LoyalButton244.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton244.Text = "●‿●"

        End If
    End Sub

    Private Sub LoyalButton252_Click(sender As Object, e As EventArgs) Handles LoyalButton252.Click

        If LoyalButton252.Text = "< (^^,) >" Then

            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "< (^^,) >" & "</ZapButton>"
            LoyalButton252.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton252.Text = "< (^^,) >"

        End If
    End Sub

    Private Sub LoyalButton251_Click(sender As Object, e As EventArgs) Handles LoyalButton251.Click

        If LoyalButton251.Text = "•(⌚_⌚)•" Then
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & "•(⌚_⌚)•" & "</ZapButton>"
            LoyalButton251.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton251.Text = "•(⌚_⌚)•"
        End If

    End Sub

    Private Sub LoyalButton250_Click(sender As Object, e As EventArgs) Handles LoyalButton250.Click

        If LoyalButton250.Text = " ❀◕ ‿ ◕❀ " Then
            Me.Skype.CurrentUserProfile.RichMoodText = "<ZapButton Action=""Resume"" Template=""MediumButtonTextDark"">" & " ❀◕ ‿ ◕❀ " & "</ZapButton>"
            LoyalButton250.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton250.Text = " ❀◕ ‿ ◕❀ "
        End If

    End Sub

    Private Sub LoyalButton253_Click(sender As Object, e As EventArgs) Handles LoyalButton253.Click

        If LoyalButton253.Text = " ❀◕ ‿ ◕❀ " Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & " ❀◕ ‿ ◕❀ " & "</blink>" & "<spinner>""</spinner>"
            LoyalButton253.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton253.Text = " ❀◕ ‿ ◕❀ "
        End If
    End Sub

    Private Sub LoyalButton254_Click(sender As Object, e As EventArgs) Handles LoyalButton254.Click

        If LoyalButton254.Text = "●‿●" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "●‿●" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton254.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton254.Text = "●‿●"
        End If
    End Sub

    Private Sub LoyalButton255_Click(sender As Object, e As EventArgs) Handles LoyalButton255.Click

        If LoyalButton255.Text = "•(⌚_⌚)•" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "•(⌚_⌚)•" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton255.Text = "Reset Mood"
        Else

        End If

    End Sub

    Private Sub LoyalButton256_Click(sender As Object, e As EventArgs) Handles LoyalButton256.Click

        If LoyalButton256.Text = "< (^^,) >" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "< (^^,) >" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton256.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton256.Text = "< (^^,) >"
        End If
    End Sub

    Private Sub LoyalButton257_Click(sender As Object, e As EventArgs) Handles LoyalButton257.Click

        If LoyalButton257.Text = "╰(◡‿◡✿╰) " Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "╰(◡‿◡✿╰) " & "</blink>" & "<spinner>""</spinner>"
            LoyalButton257.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton257.Text = "╰(◡‿◡✿╰) "
        End If
    End Sub

    Private Sub LoyalButton258_Click(sender As Object, e As EventArgs) Handles LoyalButton258.Click

        If LoyalButton258.Text = "(*^ -^*)" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "(*^ -^*)" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton258.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = "(*^ -^*)"
            LoyalButton258.Text = "(*^ -^*)"
        End If
    End Sub

    Private Sub LoyalButton259_Click(sender As Object, e As EventArgs) Handles LoyalButton259.Click

        If LoyalButton259.Text = "^ ^" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "^ ^" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton259.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton259.Text = "^ ^"
        End If
    End Sub

    Private Sub LoyalButton260_Click(sender As Object, e As EventArgs) Handles LoyalButton260.Click

        If LoyalButton260.Text = "✌.ʕʘ‿ʘʔ.✌" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "✌.ʕʘ‿ʘʔ.✌" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton260.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton260.Text = "✌.ʕʘ‿ʘʔ.✌"
        End If
    End Sub

    Private Sub LoyalButton261_Click(sender As Object, e As EventArgs) Handles LoyalButton261.Click

        If LoyalButton261.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<spinner>""</spinner>" & "<blink>" & "१✌˚◡˚✌५" & "</blink>" & "<spinner>""</spinner>"
            LoyalButton261.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton261.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub Timer10_Tick_1(sender As Object, e As EventArgs) Handles Timer10.Tick
        Label22.Text = Skype.CurrentUserProfile.FullName
    End Sub

    Private Sub LoyalButton267_Click(sender As Object, e As EventArgs) Handles LoyalButton267.Click
        If LoyalButton267.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.MoodText = "१✌˚◡˚✌५"
            LoyalButton267.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton267.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton264_Click(sender As Object, e As EventArgs) Handles LoyalButton264.Click
        If LoyalButton264.Text = "(*^ -^*)" Then
            Skype.CurrentUserProfile.MoodText = "(*^ -^*)"
            LoyalButton264.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton264.Text = "(*^ -^*)"
        End If
    End Sub

    Private Sub LoyalButton266_Click(sender As Object, e As EventArgs) Handles LoyalButton266.Click
        If LoyalButton264.Text = "(*^ -^*)" Then
            Skype.CurrentUserProfile.MoodText = "(*^ -^*)"
            LoyalButton264.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton264.Text = "(*^ -^*)"
        End If
    End Sub

    Private Sub LoyalButton265_Click(sender As Object, e As EventArgs) Handles LoyalButton265.Click
        If LoyalButton265.Text = "^ ^" Then
            Skype.CurrentUserProfile.MoodText = "^ ^"
            LoyalButton265.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton265.Text = "^ ^"
        End If
    End Sub

    Private Sub LoyalButton262_Click(sender As Object, e As EventArgs) Handles LoyalButton262.Click
        If LoyalButton262.Text = "●‿●" Then
            Skype.CurrentUserProfile.MoodText = "●‿●"
            LoyalButton262.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton262.Text = "●‿●"
        End If
    End Sub

    Private Sub LoyalButton263_Click(sender As Object, e As EventArgs) Handles LoyalButton263.Click
        If LoyalButton263.Text = "╰(◡‿◡✿╰) " Then
            Skype.CurrentUserProfile.MoodText = "╰(◡‿◡✿╰) "
            LoyalButton263.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton263.Text = "╰(◡‿◡✿╰) "
        End If
    End Sub

    Private Sub LoyalButton270_Click(sender As Object, e As EventArgs) Handles LoyalButton270.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton275_Click(sender As Object, e As EventArgs) Handles LoyalButton275.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton276_Click(sender As Object, e As EventArgs) Handles LoyalButton276.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton277_Click(sender As Object, e As EventArgs) Handles LoyalButton277.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton278_Click(sender As Object, e As EventArgs) Handles LoyalButton278.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton279_Click(sender As Object, e As EventArgs) Handles LoyalButton279.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton268_Click(sender As Object, e As EventArgs) Handles LoyalButton268.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton269_Click(sender As Object, e As EventArgs) Handles LoyalButton269.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton274_Click(sender As Object, e As EventArgs) Handles LoyalButton274.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton271_Click(sender As Object, e As EventArgs) Handles LoyalButton271.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton272_Click(sender As Object, e As EventArgs) Handles LoyalButton272.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub

    Private Sub LoyalButton273_Click(sender As Object, e As EventArgs) Handles LoyalButton273.Click
        If LoyalButton270.Text = "१✌˚◡˚✌५" Then
            Skype.CurrentUserProfile.RichMoodText = "<blink>" & "१✌˚◡˚✌५" & "</blink>"
            LoyalButton270.Text = "Reset Mood"
        Else
            Skype.CurrentUserProfile.MoodText = ""
            LoyalButton270.Text = "१✌˚◡˚✌५"
        End If
    End Sub
End Class
