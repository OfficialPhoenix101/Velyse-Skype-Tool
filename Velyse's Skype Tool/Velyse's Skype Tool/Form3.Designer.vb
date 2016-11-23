<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton1.Location = New System.Drawing.Point(35, 128)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(202, 39)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "Yes"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(138, 33)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(220, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Do you want music to play?"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(4, 9)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(91, 49)
        Me.MetroProgressSpinner1.TabIndex = 2
        Me.MetroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroProgressSpinner1.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton2.Location = New System.Drawing.Point(254, 128)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(202, 39)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroButton2.TabIndex = 3
        Me.MetroButton2.Text = "No"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MetroComboBox1.ForeColor = System.Drawing.Color.White
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"PHFat_-_Kill_the_Universe.wav", "Minecraft_Hacker_-Lyrics-.wav", "Snoop_dogg_Smoke_weed_everyday_HD_dubstep_remix_[A.wav", "Desiigner_-_Panda_Joyner_Lucas_Remix_No_Copyright_.wav", "linkin_park_bleed_it_out_lyrics.wav", "Trap_-_Marshmello_-_Alone_Monstercat_Release_.wav", "Andi_Ramos_-_Where_You_Wanna_Go.wav", "Omeguh_-_Lit_Like_Shit.wav", "_Trap_AMF_-_Buy_A_Ticket_Take_The_Ride_mp4.wav"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(35, 78)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(421, 29)
        Me.MetroComboBox1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroComboBox1.TabIndex = 4
        Me.MetroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroComboBox1.UseCustomForeColor = True
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.UseStyleColors = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 175)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroButton1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(495, 175)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(495, 175)
        Me.Movable = False
        Me.Name = "Form3"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Text = "Form3"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
End Class
