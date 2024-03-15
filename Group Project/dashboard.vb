Imports MySql.Data.MySqlClient

Public Class dashboard
    Dim MySqlConn As MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
    End Sub
End Class