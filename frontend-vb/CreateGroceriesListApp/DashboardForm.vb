Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class DashboardForm

    Private currentUserId As Integer
    Private username As String
    Private client As New HttpClient()

    ' Constructor
    Public Sub New(userId As Integer, userName As String)
        InitializeComponent()
        currentUserId = userId
        userName = userName
        lblWelcome.Text = $"Welcome {userName}!"
    End Sub


    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try
            Dim product = New With {
                .userId = currentUserId,
                .name = txtName.Text,
                .quantity = CInt(txtQuantity.Text),
                .price = CDbl(txtPrice.Text)
            }

            Dim json = JsonConvert.SerializeObject(product)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")

            Dim response = client.PostAsync("http://localhost:8080/products/add", content).Result

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Product added!")
                txtName.Clear()
                txtQuantity.Clear()
                txtPrice.Clear()
            Else
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub
End Class