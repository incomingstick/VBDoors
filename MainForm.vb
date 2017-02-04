'Final Project
'The goal is to pick the correct door
'and progress through the dungeon
'You as the player will have a series of
'stats that effect your power in game 
'against random enemies
'Nick Gaulked
'4/10/14
Public Class MainForm
    Public p1 As Player
    'Exit Button event handler
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    'Exit menu event hanlder calls exit button event
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitButton_Click(sender, e)
    End Sub
    'About menu event handler
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        p1 = New Player()
        p1.Inititalize()
    End Sub
End Class
