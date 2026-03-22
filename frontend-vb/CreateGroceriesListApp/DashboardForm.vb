Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class DashboardForm

    Private currentUserId As Integer
    Private username As String
    Private client As New HttpClient()

    ' Constructor
    Public Sub New(userId As Integer, userName As String)
        InitializeComponent() ' MUST call first

        currentUserId = userId
        userName = userName

        lblWelcome.Text = $"Welcome {userName}!"

        LoadProducts()
    End Sub

    ' Add Product Button
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
                LoadProducts()
            Else
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' Load products into ListBox
    Private Sub LoadProducts()
        Try
            Dim json = client.GetStringAsync($"http://localhost:8080/products/user/{currentUserId}").Result
            Dim products = JsonConvert.DeserializeObject(Of List(Of Product))(json)

            lstProducts.Items.Clear()
            For Each p In products
                lstProducts.Items.Add($"{p.name} - Qty: {p.quantity} - Price: ${p.price}")
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        End Try
    End Sub
    Private Async Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Try
            ' Build product list from ListBox items
            Dim products As New List(Of Product)
            For Each item As String In lstProducts.Items
                ' Assume item format: "Name - Qty: 2 - Price: 5.00"
                Dim parts() As String = item.Split("-"c)
                Dim name As String = parts(0).Trim()
                Dim qty As Integer = Integer.Parse(parts(1).Replace("Qty:", "").Trim())
                Dim price As Double = Double.Parse(parts(2).Replace("Price:", "").Trim())
                products.Add(New Product With {.name = name, .quantity = qty, .price = price})
            Next

            ' Serialize to JSON
            Dim json = JsonConvert.SerializeObject(products)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")

            ' Send to Spring Boot
            Dim response = Await client.PostAsync("http://localhost:8080/simulate/total", content)
            Dim result = Await response.Content.ReadAsStringAsync()

            MessageBox.Show("Total Cost: $" & result)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class

