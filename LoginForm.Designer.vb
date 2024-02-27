<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        LoginLbl = New Label()
        Label2 = New Label()
        phoneEmaillbl = New Label()
        phoneEmailTxt = New TextBox()
        passwordLbl = New Label()
        passwordTxt = New TextBox()
        loginBtn = New Button()
        signUpLkl = New LinkLabel()
        SuspendLayout()
        ' 
        ' LoginLbl
        ' 
        LoginLbl.AutoSize = True
        LoginLbl.Location = New Point(503, 119)
        LoginLbl.Margin = New Padding(4, 0, 4, 0)
        LoginLbl.Name = "LoginLbl"
        LoginLbl.Size = New Size(105, 41)
        LoginLbl.TabIndex = 0
        LoginLbl.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(745, 115)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 41)
        Label2.TabIndex = 1
        ' 
        ' phoneEmaillbl
        ' 
        phoneEmaillbl.AutoSize = True
        phoneEmaillbl.Location = New Point(259, 214)
        phoneEmaillbl.Margin = New Padding(4, 0, 4, 0)
        phoneEmaillbl.Name = "phoneEmaillbl"
        phoneEmaillbl.Size = New Size(185, 41)
        phoneEmaillbl.TabIndex = 2
        phoneEmaillbl.Text = "Phone/Email"
        ' 
        ' phoneEmailTxt
        ' 
        phoneEmailTxt.Location = New Point(503, 205)
        phoneEmailTxt.Margin = New Padding(4, 4, 4, 4)
        phoneEmailTxt.Name = "phoneEmailTxt"
        phoneEmailTxt.Size = New Size(260, 47)
        phoneEmailTxt.TabIndex = 3
        ' 
        ' passwordLbl
        ' 
        passwordLbl.AutoSize = True
        passwordLbl.Location = New Point(259, 322)
        passwordLbl.Margin = New Padding(4, 0, 4, 0)
        passwordLbl.Name = "passwordLbl"
        passwordLbl.Size = New Size(143, 41)
        passwordLbl.TabIndex = 4
        passwordLbl.Text = "Password"
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(503, 318)
        passwordTxt.Margin = New Padding(4, 4, 4, 4)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.Size = New Size(260, 47)
        passwordTxt.TabIndex = 5
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(477, 398)
        loginBtn.Margin = New Padding(4, 4, 4, 4)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(196, 59)
        loginBtn.TabIndex = 6
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' signUpLkl
        ' 
        signUpLkl.AutoSize = True
        signUpLkl.Location = New Point(466, 512)
        signUpLkl.Margin = New Padding(4, 0, 4, 0)
        signUpLkl.Name = "signUpLkl"
        signUpLkl.Size = New Size(123, 41)
        signUpLkl.TabIndex = 7
        signUpLkl.TabStop = True
        signUpLkl.Text = "Sign Up"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 618)
        Controls.Add(signUpLkl)
        Controls.Add(loginBtn)
        Controls.Add(passwordTxt)
        Controls.Add(passwordLbl)
        Controls.Add(phoneEmailTxt)
        Controls.Add(phoneEmaillbl)
        Controls.Add(Label2)
        Controls.Add(LoginLbl)
        Margin = New Padding(4, 4, 4, 4)
        Name = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents phoneEmaillbl As Label
    Friend WithEvents phoneEmailTxt As TextBox
    Friend WithEvents passwordLbl As Label
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents signUpLkl As LinkLabel
End Class
