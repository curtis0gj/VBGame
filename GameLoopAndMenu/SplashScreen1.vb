Imports System.ComponentModel

Public NotInheritable Class SplashScreen1
    Dim splashScreenDuration As Integer
    Dim splashScreenRunning As Boolean


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Width = Screen.PrimaryScreen.WorkingArea.Width / 2
        Height = Screen.PrimaryScreen.WorkingArea.Height / 2
        Label1.Location = New Point(Width / 2 - Label1.Width / 2.15, Height / 2)
        CenterToScreen()
        splashTimer.Interval = 100
        splashTimer.Start()
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        splashScreenRunning = True
        While splashScreenRunning
            fadeIn()
            fadeOut()
            splashScreenDuration += 1

            If splashScreenDuration > 5 Then
                splashTimer.Stop()
                splashScreenRunning = False
                Hide()
                Threading.Thread.Sleep(250)
                menuForm.Show()
            End If
        End While
    End Sub

    Sub fadeIn()
        Dim fade As Double
        For fade = 0.0 To 225 Step 5
            Label1.ForeColor = Color.FromArgb(225, 225, fade, fade)
            Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub

    Sub fadeOut()
        Dim fade As Double
        For fade = 225 To 0.0 Step -5
            Label1.ForeColor = Color.FromArgb(fade, fade, fade, fade)
            Refresh()
            Threading.Thread.Sleep(10)
        Next
    End Sub
    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SplashScreen1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        splashScreenRunning = False
        End
    End Sub
End Class
