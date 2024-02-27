Imports Newtonsoft.Json

Public Class LoginForm

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signUpLkl.LinkClicked
        Me.Hide()
        Dim registerForm As New RegisterForm
        registerForm.Show()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim ComObject As Object
        Try
            ComObject = CreateObject("FindDriver.Authentication")
            Dim phoneEmail = phoneEmailTxt.Text
            Dim password = passwordTxt.Text
            Dim res As String = ComObject.Login(phoneEmail, password)

            If res <> "" Then
                Dim user As User = JsonConvert.DeserializeObject(Of User)(res)
                MsgBox("Welcome " & user.first_name & " " & user.last_name)
                Me.Hide()
                Dim VehicleTypeForm As New VehicleTypeForm
                VehicleTypeForm.Show()
            Else
                MsgBox("Invalid phone/email or password")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class