﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.startGameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startGameButton
        '
        Me.startGameButton.Location = New System.Drawing.Point(12, 12)
        Me.startGameButton.Name = "startGameButton"
        Me.startGameButton.Size = New System.Drawing.Size(120, 25)
        Me.startGameButton.TabIndex = 0
        Me.startGameButton.Text = "START GAME"
        Me.startGameButton.UseVisualStyleBackColor = True
        '
        'menuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game.My.Resources.Resources.spacebackground1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.startGameButton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "menuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents startGameButton As Button
End Class
