Imports Newtonsoft.Json

Public Class VehicleTypeForm
    Private Sub VehicleTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ComObject As Object = CreateObject("FindDriver.VehicleTypes")
            Dim res = ComObject.GetVehicleTypes()
            Dim vehicleTypes As List(Of VehicleType) = JsonConvert.DeserializeObject(Of List(Of VehicleType))(res)
            For Each vehicleType As VehicleType In vehicleTypes
                ' Add button for each vehicle type
                Dim btn As New Button
                btn.Text = vehicleType.type
                btn.Tag = vehicleType.id
                btn.Size = New Size(200, 50)
                btn.Location = New Point(100, 100 + 60 * vehicleTypes.IndexOf(vehicleType))
                btn.BackColor = Color.FromArgb(0, 192, 192)
                btn.ForeColor = Color.White
                AddHandler btn.Click, AddressOf Me.VehicleTypeBtn_Click
                Me.Controls.Add(btn)
            Next
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub VehicleTypeBtn_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub
End Class