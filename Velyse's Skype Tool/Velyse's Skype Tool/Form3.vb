Public Class Form3
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        My.Computer.Audio.Play(System.Windows.Forms.Application.StartupPath() & "\Sounds\" + MetroComboBox1.Text, AudioPlayMode.BackgroundLoop)
        Me.Close()

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

        My.Computer.Audio.Stop()
        Me.Close()


    End Sub
End Class