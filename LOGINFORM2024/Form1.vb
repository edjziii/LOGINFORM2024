Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    ' Test MySQL Connection (not necessary for login, but useful for debugging)
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    ' Log In Button Click Event
    Private Sub btn_LogIn_Click(sender As Object, e As EventArgs) Handles btn_LogIn.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=login"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM Account WHERE username = '" & TextBox_UN.Text & "' AND password = '" & TextBox_Pass.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login successful!")
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate!")
            Else
                MessageBox.Show("Username and password are incorrect!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
