<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleTypeForm
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
        vehicleTypeLbl = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' vehicleTypeLbl
        ' 
        vehicleTypeLbl.AutoSize = True
        vehicleTypeLbl.Location = New Point(447, 96)
        vehicleTypeLbl.Margin = New Padding(4, 0, 4, 0)
        vehicleTypeLbl.Name = "vehicleTypeLbl"
        vehicleTypeLbl.Size = New Size(196, 41)
        vehicleTypeLbl.TabIndex = 0
        vehicleTypeLbl.Text = "Vehicle Types"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(513, 137)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 41)
        Label2.TabIndex = 1
        ' 
        ' VehicleTypeForm
        ' 
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1046, 577)
        Controls.Add(Label2)
        Controls.Add(vehicleTypeLbl)
        Margin = New Padding(4, 4, 4, 4)
        Name = "VehicleTypeForm"
        Text = "VehicleTypeForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents vehicleTypeLbl As Label
    Friend WithEvents Label2 As Label
End Class
