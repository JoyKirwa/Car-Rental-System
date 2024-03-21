Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class adminDashboard
    Dim MySqlConn As New MySqlConnection
    Dim Command As MySqlCommand
    Dim CommandConfirmEmail As MySqlCommand
    Dim CommandConfirmLicense As MySqlCommand

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadUsersToComboBox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader
        Dim LicenseReader As MySqlDataReader


        Try
            MySqlConn.Open()

            Dim Query As String
            Dim QueryEmail As String
            Dim QueryLicenseNumber As String
            Dim Count As Integer
            Dim LicenseCount As Integer
            Count = 0
            LicenseCount = 0

            Dim hashedPassword As String = HashPassword(txtAddPassword.Text)

            Dim pattern As String = "^[A-Za-z0-9+_.-]+@(.+)$"
            Dim PasswordPattern As String = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
            Dim Regex As New Regex(pattern)
            Dim PasswordRegex As New Regex(PasswordPattern)



            Query = "INSERT INTO `users`(`Name`, `Email`, `Password`, `PhoneNumber`, `National_ID`, `LicenseNumber`) VALUES ('" & txtAddName.Text.ToUpper & "','" & txtAddEmail.Text.ToLower & "','" & hashedPassword & "','" & txtAddPhoneNumber.Text & "','" & txtAddNationalID.Text & "','" & txtAddLicenseNumber.Text & "')"
            QueryEmail = "SELECT * FROM users WHERE email='" & txtAddEmail.Text & "'"
            QueryLicenseNumber = "SELECT * FROM users WHERE LicenseNumber='" & txtAddLicenseNumber.Text & "'"
            CommandConfirmEmail = New MySqlCommand(QueryEmail, MySqlConn)
            CommandConfirmLicense = New MySqlCommand(QueryLicenseNumber, MySqlConn)



            Reader = CommandConfirmEmail.ExecuteReader
            While Reader.Read
                Count = Count + 1
            End While
            Reader.Close()

            LicenseReader = CommandConfirmLicense.ExecuteReader
            While LicenseReader.Read
                LicenseCount = LicenseCount + 1
            End While
            LicenseReader.Close()


            If True Then

                If Len(txtAddName.Text) = 0 And Len(txtAddEmail.Text) = 0 And Len(txtAddPhoneNumber.Text) = 0 And Len(txtAddLicenseNumber.Text) = 0 And Len(txtAddNationalID.Text) = 0 And Len(txtAddPassword.Text) = 0 Then
                    MessageBox.Show("Inputs cannot be empty")
                ElseIf Len(txtAddName.Text) = 0 Then
                    MessageBox.Show("Please enter the user's name")
                ElseIf Len(txtAddEmail.Text) = 0 Then
                    MessageBox.Show("Please enter the user's email address")
                ElseIf Not Regex.IsMatch(txtAddEmail.Text) Then
                    MessageBox.Show("Please enter a valid email address")
                ElseIf Len(txtAddPhoneNumber.Text) = 0 Then
                    MessageBox.Show("Please enter your phone number")
                ElseIf Not IsNumeric(txtAddPhoneNumber.Text) Then
                    MessageBox.Show("Phone number cannot contain strings or symbols")
                ElseIf Len(txtAddLicenseNumber.Text) = 0 Then
                    MessageBox.Show("Please enter your License Number")
                ElseIf Not IsNumeric(txtAddNationalID.Text) Then
                    MessageBox.Show("National ID cannot contain strings or symbols")
                ElseIf Len(txtAddNationalID.Text) = 0 Then
                    MessageBox.Show("Please enter the user's national ID")
                ElseIf Len(txtAddPassword.Text) = 0 Or Len(txtAddConfirmPassword.Text) = 0 Then
                    MessageBox.Show("Please enter the password")
                ElseIf Not PasswordRegex.IsMatch(txtAddPassword.Text) Then
                    MessageBox.Show("The password should have a minimum of eight characters, at least one uppercase letter, one lowercase letter, one number and one special character:")
                ElseIf Count = 0 Then
                    If txtAddPassword.Text = txtAddConfirmPassword.Text Then

                        Command = New MySqlCommand(Query, MySqlConn)
                        Reader = Command.ExecuteReader
                        MessageBox.Show("Succesfuly registered new user")
                        Reader.Close()

                        txtAddName.Text = ""
                        txtAddEmail.Text = ""
                        txtAddPhoneNumber.Text = ""
                        txtAddLicenseNumber.Text = ""
                        txtAddPassword.Text = ""
                        txtAddConfirmPassword.Text = ""
                        txtAddNationalID.Text = ""
                    Else
                        MessageBox.Show("Passwords do not match")
                    End If
                Else
                    MessageBox.Show("Email Address already exists, please log in")
                End If
            End If


            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        ' Reload Combobox
        LoadUsersToComboBox()

    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        Dim query As String
        Dim connection As MySqlConnection = Nothing
        Dim command As MySqlCommand = Nothing
        Dim fieldsToUpdate As New List(Of String)

        Try
            ' Establishing connection
            connection = New MySqlConnection("server=localhost;userid=root;password=;database=rentalproject")
            connection.Open()

            ' Checking for empty fields before building queries
            If Not String.IsNullOrEmpty(txtUpdateName.Text) Then
                fieldsToUpdate.Add("Name = @name")
            End If
            If Not String.IsNullOrEmpty(txtUpdatePassword.Text) Then
                ' Validate password strength
                If Not IsValidPassword(txtUpdatePassword.Text) Then
                    MessageBox.Show("The password should have a minimum of eight characters, at least one uppercase letter, one lowercase letter, one number and one special character.")
                    Return
                End If
                fieldsToUpdate.Add("Password = @password")
            End If
            If Not String.IsNullOrEmpty(txtUpdatePhoneNumber.Text) Then
                fieldsToUpdate.Add("PhoneNumber = @PhoneNumber")
            End If
            If Not String.IsNullOrEmpty(cmbRole.Text) Then
                fieldsToUpdate.Add("is_Admin = @IsAdmin")
            End If


            ' Building the query if fields need updating
            If fieldsToUpdate.Count > 0 Then
                query = "UPDATE users SET " & String.Join(", ", fieldsToUpdate) & " WHERE Email = @email"
                command = New MySqlCommand(query, connection)
                ' Add parameters for safety
                command.Parameters.AddWithValue("@name", txtUpdateName.Text)
                command.Parameters.AddWithValue("@password", HashPassword(txtUpdatePassword.Text))
                command.Parameters.AddWithValue("@PhoneNumber", txtUpdatePhoneNumber.Text)
                command.Parameters.AddWithValue("@IsAdmin", cmbRole.Text)

                command.Parameters.AddWithValue("@email", cmbSelectUserUpdate.Text)

                ' Execute the update
                command.ExecuteNonQuery()
                MessageBox.Show("User details updated successfully.")

            Else
                MessageBox.Show("No fields selected for update.")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        ' Clearing form fields
        txtUpdateName.Text = ""
        txtUpdatePassword.Text = ""
        txtUpdatePhoneNumber.Text = ""

        ' Clearing combo box fields
        cmbSelectUserUpdate.Text = ""
        cmbRole.Text = ""

        ' Reload Combobox
        LoadUsersToComboBox()
    End Sub

    ' Function to validate password strength.
    Private Function IsValidPassword(password As String) As Boolean
        Dim regex As Regex = New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")
        Return regex.IsMatch(password)
    End Function


    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim connection As MySqlConnection = Nothing
        Dim command As MySqlCommand = Nothing

        Try
            ' Establish connection using a using block
            connection = New MySqlConnection("server=localhost;userid=root;password=;database=rentalproject")
            connection.Open()

            ' Check if a user is selected before deletion
            If cmbSelectUserDelete.SelectedIndex < 0 Then
                MessageBox.Show("Please select a user to delete.")
                Return ' Exit if no user selected
            End If

            ' Build parameterized query for safety
            Dim query = "DELETE FROM users WHERE Email = @email"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@email", cmbSelectUserDelete.Text)

            ' Ensuring that the admin account doesn't get accidentally deleted before executing.
            If cmbSelectUserDelete.Text = "admin@gmail.com" Then
                MessageBox.Show("Cannot delete admin")
                Return ' Exit if admin account is selected.
            Else
                ' Executing the query
                command.ExecuteNonQuery()
            End If


            MessageBox.Show("User deleted successfully.")
            cmbSelectUserDelete.SelectedIndex = -1 ' Reset combobox selection


            Me.Refresh()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection?.Dispose()
        End Try

        ' Reload Combobox
        LoadUsersToComboBox()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub cmbSelectUserUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectUserUpdate.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM users WHERE email='" & cmbSelectUserUpdate.Text & "'"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                txtUpdateEmail.Text = Reader.GetString("Email")
                txtUpdateName.Text = Reader.GetString("Name")
                ' txtUpdatePassword.Text = Reader.GetString("Password")
                ' txtUpdatePhoneNumber.Text = Reader.GetInt32("PhoneNumber")
            End While

            Me.Refresh()
            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        cmbSelectUserDelete.SelectedIndex = -1 ' Reset combobox selection

    End Sub

    Private Sub btnLoadUsers_Click(sender As Object, e As EventArgs) Handles btnLoadUsers.Click

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim dSource As New BindingSource


        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM users"
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
    Private Sub LoadUsersToComboBox()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader

        Try
            ' Reseting combo box values
            cmbSelectUserDelete.Items.Clear()
            cmbSelectUserUpdate.Items.Clear()


            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM users"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                Dim EmailColumn = Reader.GetString("Email")

                cmbSelectUserDelete.Items.Add(EmailColumn)
                cmbSelectUserUpdate.Items.Add(EmailColumn)

            End While

            Reader.Close()
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For Each b As Byte In hashedBytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub picRent_Click(sender As Object, e As EventArgs) Handles picRent.Click
        adminDashboardRent.Show()
        Me.Hide()
    End Sub

    Private Sub picRentals_Click(sender As Object, e As EventArgs) Handles picRentals.Click
        adminDashboardViewRentals.ShowDialog()
    End Sub

    Private Sub picManageCatalog_Click(sender As Object, e As EventArgs) Handles picManageCatalog.Click
        adminDashboardManageCatalog.Show()
        Me.Hide()
    End Sub
End Class



