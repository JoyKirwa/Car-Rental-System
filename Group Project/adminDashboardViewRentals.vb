Imports MySql.Data.MySqlClient
Public Class adminDashboardViewRentals
    Dim MySqlConn As New MySqlConnection
    Dim Command As MySqlCommand

    Private Sub picManageUsers_Click(sender As Object, e As EventArgs) Handles picManageUsers.Click
        adminDashboard.Show()
    End Sub

    Private Sub btnLoadTransactionHistory_Click(sender As Object, e As EventArgs) Handles btnLoadTransactionHistory.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim dSource As New BindingSource


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM rent_history"
            Command = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            dSource.DataSource = dbDataSet
            dgvUserList.DataSource = dSource
            SDA.Update(dbDataSet)



            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub picRent_Click(sender As Object, e As EventArgs) Handles picRent.Click
        adminDashboardRent.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub picManageCatalog_Click(sender As Object, e As EventArgs) Handles picManageCatalog.Click
        adminDashboardManageCatalog.Show()
    End Sub
End Class