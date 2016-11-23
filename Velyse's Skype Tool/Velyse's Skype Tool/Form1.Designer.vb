<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LoyalButton1 = New Velyse_s_Skype_Tool.LoyalButton()
        Me.SuspendLayout()
        '
        'MetroProgressSpinner1
        '
        Me.MetroProgressSpinner1.Location = New System.Drawing.Point(23, 13)
        Me.MetroProgressSpinner1.Maximum = 100
        Me.MetroProgressSpinner1.Name = "MetroProgressSpinner1"
        Me.MetroProgressSpinner1.Size = New System.Drawing.Size(68, 44)
        Me.MetroProgressSpinner1.TabIndex = 0
        Me.MetroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroProgressSpinner1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(61, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(277, 25)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Successfully Connected To Skype!"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseStyleColors = True
        '
        'LoyalButton1
        '
        Me.LoyalButton1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LoyalButton1.Location = New System.Drawing.Point(72, 99)
        Me.LoyalButton1.Name = "LoyalButton1"
        Me.LoyalButton1.OutlineColor = System.Drawing.Color.DodgerBlue
        Me.LoyalButton1.Size = New System.Drawing.Size(215, 45)
        Me.LoyalButton1.TabIndex = 2
        Me.LoyalButton1.Text = "OK"
        Me.LoyalButton1.TextAlignment = Velyse_s_Skype_Tool.LoyalButton.Alignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(380, 155)
        Me.Controls.Add(Me.LoyalButton1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroProgressSpinner1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(380, 155)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(380, 155)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroProgressSpinner1 As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoyalButton1 As LoyalButton
End Class
