Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class adminDashboardManageCatalog
    Dim MySqlConn As New MySqlConnection
    Dim Command As MySqlCommand
    Dim CommandConfirmEmail As MySqlCommand
    Dim CommandConfirmLicense As MySqlCommand

    Private Sub adminDashboardManageCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCarsToComboBox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()

            Dim Query As String
            Dim Count As Integer
            Count = 0

            Query = "INSERT INTO `cars`(`carName`, `Year`, `Capacity`, `Transmission`, `TopSpeed`, `ImageUrl`,`Description`,`Category`,`mileage`,`rate`) VALUES ('" & txtAddCarName.Text & "','" & CInt(txtAddYear.Text) & "','" & CInt(txtAddCapacity.Text) & "','" & txtAddTransmission.Text & "','" & txtAddTopSpeed.Text & "','" & txtAddImageUrl.Text & "','" & txtAddDescription.Text & "','" & txtAddCategory.Text & "','" & CInt(txtAddMileage.Text) & "','" & CInt(txtAddRate.Text) & "')"

            Command = New MySqlCommand(Query, MySqlConn)
                Reader = Command.ExecuteReader
            MessageBox.Show("Succesfuly added new car to catalog")
            Reader.Close()

            ' Clearing text fields
            txtAddCarName.Text = ""
            txtAddYear.Text = ""
            txtAddCapacity.Text = ""
            txtAddTransmission.Text = ""
            txtAddImageUrl.Text = ""
            txtAddDescription.Text = ""
            txtAddTopSpeed.Text = ""
            txtAddCategory.Text = ""
            txtAddRate.Text = ""
            txtAddMileage.Text = ""


            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        ' Reload Combobox
        LoadCarsToComboBox()

    End Sub

    Private Sub btnUpdateCars_Click(sender As Object, e As EventArgs) Handles btnUpdateCars.Click
        Dim query As String
        Dim connection As MySqlConnection
        Dim command As MySqlCommand
        Dim fieldsToUpdate As New List(Of String)

        Try
            ' Establishing connection
            connection = New MySqlConnection("server=localhost;userid=root;password=;database=rentalproject")
            connection.Open()

            ' Checking for empty fields before building queries
            If Not String.IsNullOrEmpty(txtUpdateCarName.Text) Then
                fieldsToUpdate.Add("carName = @carName")
            End If
            If Not String.IsNullOrEmpty(txtUpdateYear.Text) Then
                fieldsToUpdate.Add("Year = @Year")
            End If
            If Not String.IsNullOrEmpty(txtUpdateCapacity.Text) Then
                fieldsToUpdate.Add("Capacity = @Capacity")
            End If
            If Not String.IsNullOrEmpty(txtUpdateTransmission.Text) Then
                fieldsToUpdate.Add("Transmission = @Transmission")
            End If
            If Not String.IsNullOrEmpty(txtUpdateTopSpeed.Text) Then
                fieldsToUpdate.Add("TopSpeed = @TopSpeed")
            End If
            If Not String.IsNullOrEmpty(txtUpdateImageUrl.Text) Then
                fieldsToUpdate.Add("ImageUrl = @ImageUrl")
            End If
            If Not String.IsNullOrEmpty(txtUpdateDescription.Text) Then
                fieldsToUpdate.Add("Description = @Description")
            End If
            If Not String.IsNullOrEmpty(txtUpdateCategory.Text) Then
                fieldsToUpdate.Add("Category = @Category")
            End If
            If Not String.IsNullOrEmpty(txtUpdateMileage.Text) Then
                fieldsToUpdate.Add("Mileage = @Mileage")
            End If
            If Not String.IsNullOrEmpty(txtUpdateRate.Text) Then
                fieldsToUpdate.Add("rate = @rate")
            End If



            ' Building the query if fields need updating
            If fieldsToUpdate.Count > 0 Then
                query = "UPDATE cars SET " & String.Join(", ", fieldsToUpdate) & " WHERE carName = @carName"
                command = New MySqlCommand(query, connection)


                ' Add parameters for safety
                command.Parameters.AddWithValue("@carName", cmbSelectCarUpdate.Text)
                command.Parameters.AddWithValue("@Year", txtUpdateYear.Text)
                command.Parameters.AddWithValue("@Capacity", txtUpdateCapacity.Text)
                command.Parameters.AddWithValue("@Transmission", txtUpdateTransmission.Text)
                command.Parameters.AddWithValue("@TopSpeed", txtUpdateTopSpeed.Text)
                command.Parameters.AddWithValue("@ImageUrl", txtUpdateImageUrl.Text)
                command.Parameters.AddWithValue("@Description", txtUpdateDescription.Text)
                command.Parameters.AddWithValue("@Category", txtUpdateCategory.Text)
                command.Parameters.AddWithValue("@mileage", txtUpdateMileage.Text)
                command.Parameters.AddWithValue("@rate", txtUpdateRate.Text)

                ' Execute the update
                command.ExecuteNonQuery()

                MessageBox.Show("Car details updated successfully.")
                connection.Close()
            Else
                MessageBox.Show("No fields selected for update.")
            End If

            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        ' Clearing form fields
        txtUpdateCarName.Text = ""
        txtUpdateYear.Text = ""
        txtUpdateCapacity.Text = ""
        txtUpdateTransmission.Text = ""
        txtUpdateImageUrl.Text = ""
        txtUpdateDescription.Text = ""
        txtUpdateTopSpeed.Text = ""
        txtUpdateCategory.Text = ""
        txtUpdateRate.Text = ""
        txtAddMileage.Text = ""

        ' Clearing combo box fields
        cmbSelectCarUpdate.Text = ""
        cmbSelectCarDelete.Text = ""

        ' Reload Combobox
        LoadCarsToComboBox()

    End Sub


    Private Sub btnDeleteCar_Click(sender As Object, e As EventArgs) Handles btnDeleteCar.Click
        Dim connection As MySqlConnection = Nothing
        Dim command As MySqlCommand = Nothing

        Try
            ' Establish connection using a using block
            connection = New MySqlConnection("server=localhost;userid=root;password=;database=rentalproject")
            connection.Open()

            ' Check if a user is selected before deletion
            If cmbSelectCarDelete.SelectedIndex < 0 Then
                MessageBox.Show("Please select a car to delete.")
                Return ' Exit if no user selected
            End If

            ' Build parameterized query for safety
            Dim query = "DELETE FROM cars WHERE carName = @carName"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@carName", cmbSelectCarDelete.Text)


            ' Executing the query
            command.ExecuteNonQuery()



            MessageBox.Show("Car entry deleted successfully.")
            cmbSelectCarDelete.SelectedIndex = -1 ' Reset combobox selection


            Me.Refresh()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection?.Dispose()
        End Try

        ' Reload Combobox
        LoadCarsToComboBox()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub cmbSelectCarUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCarUpdate.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars WHERE carName='" & cmbSelectCarUpdate.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                txtUpdateMileage.Text = Reader.GetInt32("Mileage")

            End While

            Me.Refresh()
            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        cmbSelectCarDelete.SelectedIndex = -1 ' Reset combobox selection

    End Sub

    Private Sub btnLoadCars_Click(sender As Object, e As EventArgs) Handles btnLoadCars.Click

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
    Private Sub LoadCarsToComboBox()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            ' Reseting combo box values
            cmbSelectCarDelete.Items.Clear()
            cmbSelectCarUpdate.Items.Clear()


            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM cars"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                Dim nameColumn = Reader.GetString("carName")

                cmbSelectCarDelete.Items.Add(nameColumn)
                cmbSelectCarUpdate.Items.Add(nameColumn)

            End While

            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub picRent_Click(sender As Object, e As EventArgs) Handles picRent.Click
        adminDashboardRent.Show()
        Me.Hide()
    End Sub

    Private Sub picRentals_Click(sender As Object, e As EventArgs) Handles picRentals.Click
        adminDashboardViewRentals.ShowDialog()
    End Sub

    Private Sub picManageUsers_Click(sender As Object, e As EventArgs) Handles picManageUsers.Click
        adminDashboard.Show()
        Me.Hide()
    End Sub


End Class



