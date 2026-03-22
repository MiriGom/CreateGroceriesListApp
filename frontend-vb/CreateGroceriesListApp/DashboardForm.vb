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

        LoadProducts()
    End Sub


    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Try

            Dim product As New Product With {
                .name = txtName.Text,
                .quantity = CInt(txtQuantity.Text),
                .price = CDbl(txtPrice.Text)
            }


            lstProducts.Items.Add(product)


            txtName.Clear()
            txtQuantity.Clear()
            txtPrice.Clear()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Async Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Try
            Dim products As New List(Of Product)

            For Each item As Product In lstProducts.Items
                products.Add(item)
            Next


            Dim json = JsonConvert.SerializeObject(products)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")


            Dim response = Await client.PostAsync("http://localhost:8080/calculate/total", content)
            response.EnsureSuccessStatusCode()
            Dim result = Await response.Content.ReadAsStringAsync()

            MessageBox.Show("Total Cost: $" & result)

        Catch ex As Exception
            MessageBox.Show("Error calculating total: " & ex.Message)
        End Try
    End Sub

    ' Optional: load products from server
    Private Sub LoadProducts()
        Try
            Dim json = client.GetStringAsync($"http://localhost:8080/products/user/{currentUserId}").Result
            Dim products = JsonConvert.DeserializeObject(Of List(Of Product))(json)

            lstProducts.Items.Clear()
            For Each p In products
                lstProducts.Items.Add(p)
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub

End Class