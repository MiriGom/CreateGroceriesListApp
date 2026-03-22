<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAddProduct = New Button()
        lblWelcome = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        lstProducts = New ListBox()
        btnCalculateTotal = New Button()
        SuspendLayout()
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(79, 208)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(94, 29)
        btnAddProduct.TabIndex = 0
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(368, 47)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(71, 20)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Welcome"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 2
        Label1.Text = "Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 3
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(50, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 4
        Label3.Text = "Price"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(125, 47)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 5
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(125, 80)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(125, 27)
        txtQuantity.TabIndex = 6
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(125, 113)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 27)
        txtPrice.TabIndex = 7
        ' 
        ' lstProducts
        ' 
        lstProducts.FormattingEnabled = True
        lstProducts.Location = New Point(538, 47)
        lstProducts.Name = "lstProducts"
        lstProducts.Size = New Size(212, 344)
        lstProducts.TabIndex = 8
        ' 
        ' btnCalculateTotal
        ' 
        btnCalculateTotal.Location = New Point(495, 409)
        btnCalculateTotal.Name = "btnCalculateTotal"
        btnCalculateTotal.Size = New Size(94, 29)
        btnCalculateTotal.TabIndex = 9
        btnCalculateTotal.Text = "Calculate Total"
        btnCalculateTotal.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculateTotal)
        Controls.Add(lstProducts)
        Controls.Add(txtPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblWelcome)
        Controls.Add(btnAddProduct)
        Name = "DashboardForm"
        Text = "DashboardForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents btnCalculateTotal As Button
End Class
