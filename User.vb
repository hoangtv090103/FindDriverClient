Public Class User
    Public Property first_name As String
    Public Property last_name As String
    Public Property phone As String
    Public Property email As String

    Public Sub New(firstName, lastName, phone, email)
        Me.first_name = firstName
        Me.last_name = lastName
        Me.phone = phone
        Me.email = email
    End Sub
End Class
