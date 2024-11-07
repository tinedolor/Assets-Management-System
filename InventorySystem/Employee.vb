Public Class Employee
    Public name As String
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class