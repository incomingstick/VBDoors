<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatScreen
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
        Me.plusStrengthButton = New System.Windows.Forms.Button()
        Me.minusStrengthButton = New System.Windows.Forms.Button()
        Me.strengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.staminaTextBox = New System.Windows.Forms.TextBox()
        Me.minusStaminaButton = New System.Windows.Forms.Button()
        Me.plusStaminaButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dexterityTextBox = New System.Windows.Forms.TextBox()
        Me.minusDexterityButton = New System.Windows.Forms.Button()
        Me.plusDexterityButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pointsLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.levelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'plusStrengthButton
        '
        Me.plusStrengthButton.Location = New System.Drawing.Point(213, 41)
        Me.plusStrengthButton.Name = "plusStrengthButton"
        Me.plusStrengthButton.Size = New System.Drawing.Size(25, 23)
        Me.plusStrengthButton.TabIndex = 0
        Me.plusStrengthButton.Text = "+"
        Me.plusStrengthButton.UseVisualStyleBackColor = True
        '
        'minusStrengthButton
        '
        Me.minusStrengthButton.Enabled = False
        Me.minusStrengthButton.Location = New System.Drawing.Point(76, 39)
        Me.minusStrengthButton.Name = "minusStrengthButton"
        Me.minusStrengthButton.Size = New System.Drawing.Size(25, 23)
        Me.minusStrengthButton.TabIndex = 1
        Me.minusStrengthButton.Text = "-"
        Me.minusStrengthButton.UseVisualStyleBackColor = True
        '
        'strengthTextBox
        '
        Me.strengthTextBox.Enabled = False
        Me.strengthTextBox.Location = New System.Drawing.Point(107, 41)
        Me.strengthTextBox.Name = "strengthTextBox"
        Me.strengthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.strengthTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Strength"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Stamina"
        '
        'staminaTextBox
        '
        Me.staminaTextBox.Enabled = False
        Me.staminaTextBox.Location = New System.Drawing.Point(107, 67)
        Me.staminaTextBox.Name = "staminaTextBox"
        Me.staminaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.staminaTextBox.TabIndex = 6
        '
        'minusStaminaButton
        '
        Me.minusStaminaButton.Enabled = False
        Me.minusStaminaButton.Location = New System.Drawing.Point(76, 65)
        Me.minusStaminaButton.Name = "minusStaminaButton"
        Me.minusStaminaButton.Size = New System.Drawing.Size(25, 23)
        Me.minusStaminaButton.TabIndex = 5
        Me.minusStaminaButton.Text = "-"
        Me.minusStaminaButton.UseVisualStyleBackColor = True
        '
        'plusStaminaButton
        '
        Me.plusStaminaButton.Location = New System.Drawing.Point(213, 67)
        Me.plusStaminaButton.Name = "plusStaminaButton"
        Me.plusStaminaButton.Size = New System.Drawing.Size(25, 23)
        Me.plusStaminaButton.TabIndex = 4
        Me.plusStaminaButton.Text = "+"
        Me.plusStaminaButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dexterity"
        '
        'dexterityTextBox
        '
        Me.dexterityTextBox.Enabled = False
        Me.dexterityTextBox.Location = New System.Drawing.Point(107, 93)
        Me.dexterityTextBox.Name = "dexterityTextBox"
        Me.dexterityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.dexterityTextBox.TabIndex = 10
        '
        'minusDexterityButton
        '
        Me.minusDexterityButton.Enabled = False
        Me.minusDexterityButton.Location = New System.Drawing.Point(76, 91)
        Me.minusDexterityButton.Name = "minusDexterityButton"
        Me.minusDexterityButton.Size = New System.Drawing.Size(25, 23)
        Me.minusDexterityButton.TabIndex = 9
        Me.minusDexterityButton.Text = "-"
        Me.minusDexterityButton.UseVisualStyleBackColor = True
        '
        'plusDexterityButton
        '
        Me.plusDexterityButton.Location = New System.Drawing.Point(213, 93)
        Me.plusDexterityButton.Name = "plusDexterityButton"
        Me.plusDexterityButton.Size = New System.Drawing.Size(25, 23)
        Me.plusDexterityButton.TabIndex = 8
        Me.plusDexterityButton.Text = "+"
        Me.plusDexterityButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Points Available:"
        '
        'pointsLabel
        '
        Me.pointsLabel.AutoSize = True
        Me.pointsLabel.Location = New System.Drawing.Point(103, 151)
        Me.pointsLabel.Name = "pointsLabel"
        Me.pointsLabel.Size = New System.Drawing.Size(13, 13)
        Me.pointsLabel.TabIndex = 13
        Me.pointsLabel.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "You Leveled up!"
        '
        'levelButton
        '
        Me.levelButton.Location = New System.Drawing.Point(197, 138)
        Me.levelButton.Name = "levelButton"
        Me.levelButton.Size = New System.Drawing.Size(75, 23)
        Me.levelButton.TabIndex = 15
        Me.levelButton.Text = "&Level Up"
        Me.levelButton.UseVisualStyleBackColor = True
        '
        'StatScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 173)
        Me.Controls.Add(Me.levelButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pointsLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dexterityTextBox)
        Me.Controls.Add(Me.minusDexterityButton)
        Me.Controls.Add(Me.plusDexterityButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.staminaTextBox)
        Me.Controls.Add(Me.minusStaminaButton)
        Me.Controls.Add(Me.plusStaminaButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.strengthTextBox)
        Me.Controls.Add(Me.minusStrengthButton)
        Me.Controls.Add(Me.plusStrengthButton)
        Me.Name = "StatScreen"
        Me.Text = "Stat Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents plusStrengthButton As System.Windows.Forms.Button
    Friend WithEvents minusStrengthButton As System.Windows.Forms.Button
    Friend WithEvents strengthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents staminaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents minusStaminaButton As System.Windows.Forms.Button
    Friend WithEvents plusStaminaButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dexterityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents minusDexterityButton As System.Windows.Forms.Button
    Friend WithEvents plusDexterityButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pointsLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents levelButton As System.Windows.Forms.Button
End Class
