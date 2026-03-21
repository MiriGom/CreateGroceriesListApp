Imports System.Windows.Forms

Public Class DashboardForm
    Inherits Form

    Private lblWelcome As New Label()

    Private userId As String
    Private username As String

    Public Sub New(uId As String, uName As String)
        userId = uId
        username = uName

        Me.Text = "Dashboard"
        Me.Size = New Drawing.Size(400, 200)

        lblWelcome.AutoSize = True
        lblWelcome.Location = New Drawing.Point(50, 50)
        lblWelcome.Text = "Welcome " & username & "! Your ID is " & userId

        Me.Controls.Add(lblWelcome)
    End Sub

End Class