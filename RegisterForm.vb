Public Class RegisterForm
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        userTypeCmb.Text = "Customer"

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userTypeCmb.SelectedValueChanged
        If userTypeCmb.Text = "Customer" Then
            Me.licenseNumTxt.Hide()
            Me.licenseNumLbl.Hide()

        Else
            Me.licenseNumTxt.Show()
            Me.licenseNumLbl.Show()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles emailTxt.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles emailTxt.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged_2(sender As Object, e As EventArgs) Handles emailTxt.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub loginLkl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginLkl.LinkClicked
        Me.Hide()
        Dim loginForm As New LoginForm
        loginForm.Show()
    End Sub

    Private Sub licenseNumTxt_TextChanged(sender As Object, e As EventArgs) Handles licenseNumTxt.TextChanged

    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        Dim ComObject As Object
        Try
            ComObject = CreateObject("FindDriver.Register")
            If ComObject Is Nothing Then
                MessageBox.Show("Could not create the object", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim firstName As String = firstNameTxt.Text
            Dim lastName As String = lastNameTxt.Text
            Dim email As String = emailTxt.Text
            Dim phone As String = phoneTxt.Text
            Dim password As String = passwordTxt.Text
            Dim licenseNum As String = licenseNumTxt.Text

            If userTypeCmb.Text = "Customer" Then
                ComObject.RegisterCustomer(firstName, lastName, email, password, phone)
            Else
                ComObject.RegisterDriver(firstName, lastName, email, password, phone, licenseNum)
            End If
        Catch
            MsgBox("Error: " & Err.Description)
            Exit Sub
        End Try
    End Sub
End Class