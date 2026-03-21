Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private client As New HttpClient()

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim user = New With {
            .username = txtUsername.Text,
            .email = txtEmail.Text,
            .password = txtPassword.Text
        }

        Dim json = JsonConvert.SerializeObject(user)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = client.PostAsync("http://localhost:8080/users/register", content).Result

        If response.IsSuccessStatusCode Then
            MessageBox.Show("User registered successfully!")
        Else
            MessageBox.Show("Error: " & response.StatusCode.ToString())
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user = New With {
        .email = txtEmail.Text,
        .password = txtPassword.Text
    }

        Dim json = JsonConvert.SerializeObject(user)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Dim response = client.PostAsync("http://localhost:8080/users/login", content).Result

        If response.IsSuccessStatusCode Then
            ' Deserialize the returned user
            Dim loggedUser = JsonConvert.DeserializeObject(Of User)(response.Content.ReadAsStringAsync().Result)

            ' Open Dashboard with user info
            Dim dashboard As New DashboardForm(loggedUser.Id, loggedUser.Username)
            dashboard.Show()
            Me.Hide()
        ElseIf response.StatusCode = Net.HttpStatusCode.Unauthorized Then
            MessageBox.Show("Incorrect email or password.")
        Else
            MessageBox.Show("Login failed: " & response.StatusCode.ToString())
        End If
    End Sub
End Class