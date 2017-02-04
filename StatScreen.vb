Public Class StatScreen
    'Store last value of stats
    Private lastStrength As Integer
    Private newStrength As Integer
    Private lastStamina As Integer
    Private newStamina As Integer
    Private lastDexterity As Integer
    Private newDexterity As Integer
    Private startingPoints As Integer = 0
    Private currentPoints As Integer = 0

    'Level button event handler
    Private Sub levelButton_Click(sender As Object, e As EventArgs) Handles levelButton.Click
        MainForm.p1.Strength = newStrength
        MainForm.p1.Stamina = newStamina
        MainForm.p1.Dexterity = newDexterity
        Me.Close()
    End Sub
    'Form load event handler
    Private Sub StatScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strengthTextBox.Text = MainForm.p1.Strength.ToString()
        lastStrength = MainForm.p1.Strength
        newStrength = lastStrength
        staminaTextBox.Text = MainForm.p1.Stamina.ToString()
        lastStamina = MainForm.p1.Stamina
        newStamina = lastStamina
        dexterityTextBox.Text = MainForm.p1.Dexterity.ToString()
        lastDexterity = MainForm.p1.Dexterity
        newDexterity = lastDexterity
        If MainForm.p1.Level = 1 Then
            startingPoints += 5
        ElseIf MainForm.p1.Level Mod 10 = 0 Then
            startingPoints += 5
        Else
            startingPoints = 3
        End If
        currentPoints = startingPoints
        pointsLabel.Text = currentPoints.ToString()
    End Sub
    'Plues strength event handler
    Private Sub plusStrengthButton_Click(sender As Object, e As EventArgs) Handles plusStrengthButton.Click
        If newStrength >= lastStrength Then
            newStrength += 1
            strengthTextBox.Text = newStrength.ToString()
            currentPoints -= 1
            pointsLabel.Text = currentPoints.ToString()
            If newStrength > lastStrength Then
                minusStrengthButton.Enabled = True
            End If
            If currentPoints = 0 Then
                plusStrengthButton.Enabled = False
                plusStaminaButton.Enabled = False
                plusDexterityButton.Enabled = False
            End If
        End If
    End Sub
    'Plus stamina event handler
    Private Sub plusStaminaButton_Click(sender As Object, e As EventArgs) Handles plusStaminaButton.Click
        If newStamina >= lastStamina Then
            newStamina += 1
            staminaTextBox.Text = newStamina.ToString()
            currentPoints -= 1
            pointsLabel.Text = currentPoints.ToString()
            If newStamina > lastStamina Then
                minusStaminaButton.Enabled = True
            End If
            If currentPoints = 0 Then
                plusStrengthButton.Enabled = False
                plusStaminaButton.Enabled = False
                plusDexterityButton.Enabled = False
            End If
        End If
    End Sub
    'Plus dexterity event handler
    Private Sub plusDexterityButton_Click(sender As Object, e As EventArgs) Handles plusDexterityButton.Click
        If newDexterity >= lastDexterity Then
            newDexterity += 1
            dexterityTextBox.Text = newDexterity.ToString()
            currentPoints -= 1
            pointsLabel.Text = currentPoints.ToString()
            If newDexterity > lastDexterity Then
                minusDexterityButton.Enabled = True
            End If
            If currentPoints = 0 Then
                plusStrengthButton.Enabled = False
                plusStaminaButton.Enabled = False
                plusDexterityButton.Enabled = False
            End If
        End If
    End Sub
    'Minus strength event handler
    Private Sub minusStrengthButton_Click(sender As Object, e As EventArgs) Handles minusStrengthButton.Click
        If newStrength > lastStrength Then
            newStrength -= 1
            strengthTextBox.Text = newStrength.ToString()
            currentPoints += 1
            pointsLabel.Text = currentPoints.ToString()
            If currentPoints > 0 Then
                plusStrengthButton.Enabled = True
                plusStaminaButton.Enabled = True
                plusDexterityButton.Enabled = True
            End If
            If currentPoints = startingPoints Then
                minusStrengthButton.Enabled = False
                minusStaminaButton.Enabled = False
                minusDexterityButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub minusStaminaButton_Click(sender As Object, e As EventArgs) Handles minusStaminaButton.Click
        If newStamina > lastStamina Then
            newStamina -= 1
            staminaTextBox.Text = newStamina.ToString()
            currentPoints += 1
            pointsLabel.Text = currentPoints.ToString()
            If currentPoints > 0 Then
                plusStrengthButton.Enabled = True
                plusStaminaButton.Enabled = True
                plusDexterityButton.Enabled = True
            End If
            If currentPoints = startingPoints Then
                minusStrengthButton.Enabled = False
                minusStaminaButton.Enabled = False
                minusDexterityButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub minusDexterityButton_Click(sender As Object, e As EventArgs) Handles minusDexterityButton.Click
        If newDexterity > lastDexterity Then
            newDexterity -= 1
            dexterityTextBox.Text = newDexterity.ToString()
            currentPoints += 1
            pointsLabel.Text = currentPoints.ToString()
            If currentPoints > 0 Then
                plusStrengthButton.Enabled = True
                plusStaminaButton.Enabled = True
                plusDexterityButton.Enabled = True
            End If
            If currentPoints = startingPoints Then
                minusStrengthButton.Enabled = False
                minusStaminaButton.Enabled = False
                minusDexterityButton.Enabled = False
            End If
        End If
    End Sub
End Class