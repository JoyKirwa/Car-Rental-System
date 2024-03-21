Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient
Public Class dashboard
    Dim MySqlConn As New MySqlConnection
    Dim Command As MySqlCommand
    Dim CommandConfirmEmail As MySqlCommand

    Private Sub btnLoadCars_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim dSource As New BindingSource


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars"
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

    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        Dim fromDateTime As DateTime = dtRentFrom.Value
        Dim toDateTime As DateTime = dtReturnOn.Value
        Dim userID_Reader As MySqlDataReader
        Dim carID_Reader As MySqlDataReader
        Dim emailReader As MySqlDataReader

        Try
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
            MySqlConn.Open()

            Dim userIDVal As Integer
            Dim carIDVal As Integer
            Dim EmailQueryString As String = "SELECT * FROM users WHERE email='" & txtRentEmailAdress.Text & "'"
            Dim count As Integer = 0

            ' Bindng the query to the database
            CommandConfirmEmail = New MySqlCommand(EmailQueryString, MySqlConn)


            ' Checking whether user exists in the database using MySqlDataReader.
            emailReader = CommandConfirmEmail.ExecuteReader
            While emailReader.Read

                ' Incrementing the value of count by one if account corresponding to given email is found.
                count = count + 1
            End While
            emailReader.Close()

            Dim userID_Query = "SELECT * FROM users WHERE Email='" & txtRentEmailAdress.Text.ToLower & "'"
            Dim carID_Query = "SELECT carID FROM cars WHERE carName='" & cmbSelectCar.Text & "'"
            Dim userID_Command As New MySqlCommand(userID_Query, MySqlConn)
            Dim carID_Command As New MySqlCommand(carID_Query, MySqlConn)


            userID_Reader = userID_Command.ExecuteReader
            While userID_Reader.Read
                userIDVal = userID_Reader.GetInt32("ID")
            End While
            userID_Reader.Close()

            carID_Reader = carID_Command.ExecuteReader
            While carID_Reader.Read
                carIDVal = carID_Reader.GetInt32("carID")
            End While
            carID_Reader.Close()


            Dim Query As String = "INSERT INTO rent_history (`userID`, `carID`,`rentStart`, `rentEnd`, `rentDuration`,`TotalPrice`) VALUES (@userID,@carID,@from,@to,@rentDuration,@totalprice)"
            Dim Command As New MySqlCommand(Query, MySqlConn)

            If count > 0 Then
                ' Add parameters to the query to prevent SQL injection
                Command.Parameters.AddWithValue("@userID", userIDVal)
                Command.Parameters.AddWithValue("@carID", carIDVal)
                Command.Parameters.AddWithValue("@from", fromDateTime)
                Command.Parameters.AddWithValue("@to", toDateTime)
                Command.Parameters.AddWithValue("@rentDuration", Convert.ToInt32(txtRentDuration.Value))
                Command.Parameters.AddWithValue("@totalPrice", txtRentTotalCost.Text)

                Dim rowsAffected As Integer = Command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Rent information submitted successfully")
                Else
                    MessageBox.Show("Renting failed")
                End If
            Else
                MessageBox.Show("There is no account corresponding to that email!")
            End If




            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub
    Private Sub LoadUsersToComboBox()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            ' Reseting combo box values
            cmbSelectCar.Items.Clear()



            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                Dim carNameColumn = Reader.GetString("carName")

                cmbSelectCar.Items.Add(carNameColumn)


            End While

            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub adminDashboardRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUsersToComboBox()

    End Sub

    Private Sub cmbSelectCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCar.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars WHERE carName='" & cmbSelectCar.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                txtRentalRate.Text = Reader.GetInt32("rate")

            End While

            Me.Refresh()
            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        ' cmbSelectCar.SelectedIndex = -1 ' Reset combobox selection
        txtRentTotalCost.Clear()
    End Sub

    Private Sub txtRentDuration_ValueChanged(sender As Object, e As EventArgs) Handles txtRentDuration.ValueChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars WHERE carName='" & cmbSelectCar.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)

            ' Executing the reader
            Reader = Command.ExecuteReader

            ' Multiplying the rate to the duration to get the total cost
            While Reader.Read
                txtRentTotalCost.Text = Reader.GetInt32("rate") * Convert.ToInt32(txtRentDuration.Value)

            End While

            Me.Refresh()

            ' Never forget to close the reader once you're done with it.
            Reader.Close()

            ' Closing the connection to the database.
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub

    Private Sub btnRentSignOut_Click(sender As Object, e As EventArgs) Handles btnRentSignOut.Click
        login.Show()
        Me.Hide()
    End Sub
End Class