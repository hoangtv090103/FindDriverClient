<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        userTypeCmb = New ComboBox()
        userTypeLbl = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        licenseNumLbl = New Label()
        lastNameTxt = New TextBox()
        phoneTxt = New TextBox()
        emailTxt = New TextBox()
        passwordTxt = New TextBox()
        licenseNumTxt = New TextBox()
        firstNameTxt = New TextBox()
        signUpBtn = New Button()
        loginLkl = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(445, 33)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 41)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(231, 183)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 41)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' userTypeCmb
        ' 
        userTypeCmb.FormattingEnabled = True
        userTypeCmb.Items.AddRange(New Object() {"Driver", "Customer"})
        userTypeCmb.Location = New Point(412, 105)
        userTypeCmb.Margin = New Padding(4)
        userTypeCmb.Name = "userTypeCmb"
        userTypeCmb.Size = New Size(391, 49)
        userTypeCmb.TabIndex = 2
        ' 
        ' userTypeLbl
        ' 
        userTypeLbl.AutoSize = True
        userTypeLbl.Location = New Point(235, 105)
        userTypeLbl.Margin = New Padding(4, 0, 4, 0)
        userTypeLbl.Name = "userTypeLbl"
        userTypeLbl.Size = New Size(149, 41)
        userTypeLbl.TabIndex = 3
        userTypeLbl.Text = "User Type"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(32, 32)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(231, 261)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 41)
        Label3.TabIndex = 5
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(235, 340)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 41)
        Label4.TabIndex = 5
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(235, 409)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 41)
        Label5.TabIndex = 6
        Label5.Text = "Phone"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(235, 480)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(143, 41)
        Label6.TabIndex = 7
        Label6.Text = "Password"
        ' 
        ' licenseNumLbl
        ' 
        licenseNumLbl.AllowDrop = True
        licenseNumLbl.AutoSize = True
        licenseNumLbl.Location = New Point(235, 552)
        licenseNumLbl.Margin = New Padding(4, 0, 4, 0)
        licenseNumLbl.Name = "licenseNumLbl"
        licenseNumLbl.Size = New Size(232, 41)
        licenseNumLbl.TabIndex = 8
        licenseNumLbl.Text = "License Number"
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.Location = New Point(412, 258)
        lastNameTxt.Margin = New Padding(4)
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(391, 47)
        lastNameTxt.TabIndex = 3
        ' 
        ' phoneTxt
        ' 
        phoneTxt.Location = New Point(412, 405)
        phoneTxt.Margin = New Padding(4)
        phoneTxt.Name = "phoneTxt"
        phoneTxt.Size = New Size(391, 47)
        phoneTxt.TabIndex = 5
        ' 
        ' emailTxt
        ' 
        emailTxt.Location = New Point(412, 336)
        emailTxt.Margin = New Padding(4)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(391, 47)
        emailTxt.TabIndex = 4
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Location = New Point(412, 477)
        passwordTxt.Margin = New Padding(4)
        passwordTxt.Name = "passwordTxt"
        passwordTxt.Size = New Size(391, 47)
        passwordTxt.TabIndex = 6
        ' 
        ' licenseNumTxt
        ' 
        licenseNumTxt.Location = New Point(488, 543)
        licenseNumTxt.Margin = New Padding(4)
        licenseNumTxt.Name = "licenseNumTxt"
        licenseNumTxt.Size = New Size(315, 47)
        licenseNumTxt.TabIndex = 7
        ' 
        ' firstNameTxt
        ' 
        firstNameTxt.Location = New Point(412, 179)
        firstNameTxt.Margin = New Padding(4)
        firstNameTxt.Name = "firstNameTxt"
        firstNameTxt.Size = New Size(391, 47)
        firstNameTxt.TabIndex = 2
        ' 
        ' signUpBtn
        ' 
        signUpBtn.Location = New Point(412, 634)
        signUpBtn.Margin = New Padding(4)
        signUpBtn.Name = "signUpBtn"
        signUpBtn.Size = New Size(196, 59)
        signUpBtn.TabIndex = 8
        signUpBtn.Text = "Sign Up"
        signUpBtn.UseVisualStyleBackColor = True
        ' 
        ' loginLkl
        ' 
        loginLkl.AutoSize = True
        loginLkl.Location = New Point(328, 748)
        loginLkl.Margin = New Padding(4, 0, 4, 0)
        loginLkl.Name = "loginLkl"
        loginLkl.Size = New Size(354, 41)
        loginLkl.TabIndex = 9
        loginLkl.TabStop = True
        loginLkl.Text = "Already have an account?"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1046, 858)
        Controls.Add(loginLkl)
        Controls.Add(signUpBtn)
        Controls.Add(firstNameTxt)
        Controls.Add(licenseNumTxt)
        Controls.Add(passwordTxt)
        Controls.Add(emailTxt)
        Controls.Add(phoneTxt)
        Controls.Add(lastNameTxt)
        Controls.Add(licenseNumLbl)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(userTypeLbl)
        Controls.Add(userTypeCmb)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "RegisterForm"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userTypeCmb As ComboBox
    Friend WithEvents userTypeLbl As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents licenseNumLbl As Label
    Friend WithEvents lastNameTxt As TextBox
    Friend WithEvents phoneTxt As TextBox
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents licenseNumTxt As TextBox
    Friend WithEvents firstNameTxt As TextBox
    Friend WithEvents signUpBtn As Button
    Friend WithEvents loginLkl As LinkLabel
End Class
