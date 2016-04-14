Imports System.ComponentModel

Public Class menuForm
    Private Sub menuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = Screen.PrimaryScreen.WorkingArea.Width
        Height = Screen.PrimaryScreen.WorkingArea.Height
        CenterToScreen()
        startGameButton.Location = New Point(Width / 2, Height / 2)
    End Sub

    Private Sub startGameButton_Click(sender As Object, e As EventArgs) Handles startGameButton.Click
        Hide()
        gameForm.Show()
    End Sub

    Private Sub menuForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
End Class
