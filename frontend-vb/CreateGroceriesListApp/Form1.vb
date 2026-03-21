Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1

    Private client As HttpClient = New HttpClient()

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim user = New With {
        .username = txtUsername.Text,
        .email = txtEmail.Text,
        .password = txtPassword.Text
    }

        Dim json = JsonConvert.SerializeObject(user)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try
            Dim response = client.PostAsync("http://localhost:8080/users/register", content).Result

            If response.IsSuccessStatusCode Then


                Dim responseBody = response.Content.ReadAsStringAsync().Result


                Dim savedUser = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(responseBody)

                Dim userId = savedUser("id").ToString()
                Dim username = savedUser("username").ToString()


                Dim dashboard As New DashboardForm(userId, username)
                dashboard.Show()

                Me.Hide()

            Else
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class