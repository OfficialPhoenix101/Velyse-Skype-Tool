<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MetroProgressSpinner1 = New MetroFramework.Controls.MetroProgressSpinner()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.LoyalButton1 = New Velyse_s_Skype_Tool.LoyalButton()
        Me.SuspendLayout()
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(12, 13)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(89, 43)
        Me.MetroProgressSpinner1.TabIndex = 0
        Me.MetroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroProgressSpinner1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(82, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(245, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Couldn't Connect To Skype!"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(54, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(313, 25)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Please Make Sure Skype Is Running"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 110)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(590, 25)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Also Please Check If Velyse's Skype Tool Is Allowed Access To Skype."
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseStyleColors = True
        '
        'LoyalButton1
        '
        Me.LoyalButton1.Location = New System.Drawing.Point(172, 158)
        Me.LoyalButton1.Name = "LoyalButton1"
        Me.LoyalButton1.OutlineColor = System.Drawing.Color.DodgerBlue
        Me.LoyalButton1.Size = New System.Drawing.Size(228, 50)
        Me.LoyalButton1.TabIndex = 4
        Me.LoyalButton1.Text = "OK"
        Me.LoyalButton1.TextAlignment = Velyse_s_Skype_Tool.LoyalButton.Alignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 231)
        Me.Controls.Add(Me.LoyalButton1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(605, 231)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(605, 231)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form2"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoyalButton1 As LoyalButton
End Class
