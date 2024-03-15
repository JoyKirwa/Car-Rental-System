Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class login
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim IsAdminCommand As MySqlCommand

    Private Sub btnSigninSubmit_Click(sender As Object, e As EventArgs) Handles btnSigninSubmit.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=;database=rentalproject"
        Dim Reader As MySqlDataReader
        Dim IsAdmin As MySqlDataReader
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM users WHERE email='" & txtSigninEmail.Text.ToLower & "'AND password='" & txtSigninPassword.Text & "' "
            Dim IsAdminQuery = "SELECT * FROM users WHERE email='" & txtSigninEmail.Text.ToLower & "' AND is_Admin='1'"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader
            IsAdminCommand = New MySqlCommand(IsAdminQuery, MySqlConn)

            Dim Count As Integer
            Count = 0
            Dim CountAdmin As Integer = 0
            Dim Pattern As String = "^[A-Za-z0-9+_.-]+@(.+)$"
            Dim Regex As New Regex(Pattern)

            While Reader.Read
                Count = Count + 1
            End While
            Reader.Close()


            If Len(txtSigninEmail.Text) = 0 And Len(txtSigninPassword.Text) = 0 Then
                MessageBox.Show("Please fill in the form and log in again!")
            ElseIf Len(txtSigninEmail.Text) = 0 Then
                MessageBox.Show("Please enter your email address")
            ElseIf Not Regex.IsMatch(txtSigninEmail.Text) Then
                MessageBox.Show("Please enter a valid email address.")
            ElseIf Len(txtSigninPassword.Text) = 0 Then
                MessageBox.Show("Please enter your password")
            Else
                If Count = 1 Then
                    IsAdmin = IsAdminCommand.ExecuteReader
                    While IsAdmin.Read
                        CountAdmin = CountAdmin + 1
                    End While
                    IsAdmin.Close()

                    If CountAdmin = 1 Then
                        adminDashboard.Show()
                    Else
                        dashboard.Show()
                    End If

                    Me.Hide()
                ElseIf Count > 1 Then
                    MessageBox.Show("Duplicate email and password entries")
                Else
                    MessageBox.Show("Connection failed")
                End If
            End If

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        signup.Show()
        Me.Hide()
    End Sub
End Class