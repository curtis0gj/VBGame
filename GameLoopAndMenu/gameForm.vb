Imports System.ComponentModel

Public Class gameForm
    Private Declare Function QueryPerformanceCounter Lib "kernel32" (ByRef lpPerformanceCount As Long) As Integer
    Private Declare Function QueryPerformanceFrequency Lib "kernel32" (ByRef lpFrequency As Long) As Integer

    Dim Milliseconds As Single
    Dim Get_Frames_Per_Second As Integer
    Dim Frame_Count As Integer
    Dim Current_Time As Long
    Public Running As Boolean
    Dim Ticks_Per_Second As Long
    Dim Start_Time As Long
    Shared Last_Time As Long
    Dim FPS As Single
    Dim Target_FPS As Long = 60
    Dim Get_Elapsed_Time As Single

    Public Sub gameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueryPerformanceFrequency(Ticks_Per_Second)

        QueryPerformanceCounter(Current_Time)
        Get_Elapsed_Time = CSng(Current_Time / Ticks_Per_Second)

        Milliseconds = Get_Elapsed_Time

        Width = Screen.PrimaryScreen.WorkingArea.Width
        Height = Screen.PrimaryScreen.WorkingArea.Height
        CenterToScreen()

        Show()
        Focus()

        Running = True

        Game_Loop()
    End Sub

    Private Sub Game_Loop()
        While Running = True
            'Game Code Here

            Do
                QueryPerformanceCounter(Current_Time)
                FPS = CSng(Ticks_Per_Second / (Current_Time - Last_Time))
            Loop While (FPS > Target_FPS)

            QueryPerformanceCounter(Last_Time)

            Frame_Count = Frame_Count + 1

            QueryPerformanceCounter(Current_Time)
            Get_Elapsed_Time = CSng(Current_Time / Ticks_Per_Second)
            If Get_Elapsed_Time - Milliseconds >= 1 Then
                Get_Frames_Per_Second = Frame_Count
                Frame_Count = 0
                Milliseconds = Convert.ToInt32(Get_Elapsed_Time)
            End If

            Text = "Frames Per Second: " & Convert.ToString(Get_Frames_Per_Second)

            Application.DoEvents()
        End While
    End Sub

    Private Sub gameForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Running = False
        End
    End Sub
End Class
