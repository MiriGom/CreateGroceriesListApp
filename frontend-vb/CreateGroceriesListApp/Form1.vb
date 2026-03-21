Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Private client As HttpClient = New HttpClient()

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Prepare user object
        Dim user = New With {
            .username = txtUsername.Text,
            .email = txtEmail.Text,
            .password = txtPassword.Text
        }

        ' Convert to JSON
        Dim json = JsonConvert.SerializeObject(user)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        ' Send POST request to Spring Boot backend
        Dim response = client.PostAsync("http://localhost:8080/users/register", content).Result
        If response.IsSuccessStatusCode Then
            MessageBox.Show("User registered successfully!")
            ' Optionally clear text boxes
            txtUsername.Clear()
            txtEmail.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString())
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub
End Class