Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions


Public Class signup
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim CommandConfirmEmail As MySqlCommand
    Dim CommandConfirmLicense As MySqlCommand


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        login.Show()
        Me.Hide()

    End Sub

    Private Sub btnSignupSubmit_Click(sender As Object, e As EventArgs) Handles btnSignupSubmit.Click
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



            Query = "INSERT INTO `users`(`Name`, `Email`, `Password`, `PhoneNumber`, `National_ID`, `LicenseNumber`) VALUES ('" & txtSignupName.Text & "','" & txtSignupEmail.Text.ToLower & "','" & hashedPassword & "','" & txtSignupPhoneNumber.Text & "','" & txtSignupNationalID.Text & "','" & txtSignupLicenseNumber.Text & "')"
            QueryEmail = "SELECT * FROM users WHERE email='" & txtSignupEmail.Text & "'"
            QueryLicenseNumber = "SELECT * FROM users WHERE LicenseNumber='" & txtSignupLicenseNumber.Text & "'"
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

                If Len(txtSignupEmail.Text) = 0 And Len(txtSignupName.Text) = 0 And Len(txtSignupEmail.Text) = 0 And Len(txtSignupPhoneNumber.Text) = 0 And Len(txtSignupLicenseNumber.Text) = 0 And Len(txtSignupPassword.Text) = 0 And Len(txtSignupConfirmPassword.Text) = 0 Then
                    MessageBox.Show("This form cannot be empty")
                ElseIf Len(txtSignupName.Text) = 0 Then
                    MessageBox.Show("Please enter your name")
                ElseIf Len(txtSignupEmail.Text) = 0 Then
                    MessageBox.Show("Please enter your email address")
                ElseIf Not Regex.IsMatch(txtSignupEmail.Text) Then
                    MessageBox.Show("Please enter a valid email address")
                ElseIf Len(txtSignupPhoneNumber.Text) = 0 Then
                    MessageBox.Show("Please enter your phone number")
                ElseIf Not IsNumeric(txtSignupPhoneNumber.Text) Then
                    MessageBox.Show("Phone number cannot contain strings or symbols")
                ElseIf Len(txtSignupLicenseNumber.Text) = 0 Then
                    MessageBox.Show("Please enter your License Number")
                ElseIf Not IsNumeric(txtSignupNationalID.Text) Then
                    MessageBox.Show("National ID cannot contain strings or symbols")
                ElseIf Len(txtSignupNationalID.Text) = 0 Then
                    MessageBox.Show("Please enter your national ID")
                ElseIf Len(txtSignupPassword.Text) = 0 Or Len(txtSignupConfirmPassword.Text) = 0 Then
                    MessageBox.Show("Please Enter a password")
                ElseIf Not PasswordRegex.IsMatch(txtSignupPassword.Text) Then
                    MessageBox.Show("The password should have a minimum of eight characters, at least one uppercase letter, one lowercase letter, one number and one special character.")
                ElseIf Count = 0 Then
                    If txtSignupPassword.Text = txtSignupConfirmPassword.Text Then
                        If rdoSignupTerms.Checked Then
                            Command = New MySqlCommand(Query, MySqlConn)
                            Reader = Command.ExecuteReader
                            MessageBox.Show("Account Registration succesful, you will be redirected to the login page")
                            login.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Please agree to the terms and conditions")
                        End If
                    Else
                        MessageBox.Show("Passwords do not match")
                    End If
                Else
                    MessageBox.Show("Email Address already exists, please log in")
                    End If
                End If

            Reader.Close()
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class