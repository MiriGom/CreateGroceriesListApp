<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnRegister = New Button()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        lblUsername = New Label()
        lblEmail = New Label()
        lblPassword = New Label()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(622, 279)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 0
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(99, 71)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(125, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(99, 122)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(125, 27)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(99, 180)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 3
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(18, 74)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(18, 122)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(18, 187)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(70, 20)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblPassword)
        Controls.Add(lblEmail)
        Controls.Add(lblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(btnRegister)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label

End Class
