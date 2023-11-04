Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class Form5
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondForm As New Form4
        SecondForm.Show()
    End Sub
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;Persist Security Info=False;"
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim User_id As String = usrid.Text
        Dim password As String = pass.Text

        ' Hash the password before storing it in the database
        Dim hashedPassword As String = HashPassword(password)

        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO Table3 (User_id, Password) VALUES (@user_id, @Password)"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user_id", User_id)
                    cmd.Parameters.AddWithValue("@Password", hashedPassword) ' Store the hashed password in the database
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration successful! You can now login.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Function HashPassword(password As String) As String
        Throw New NotImplementedException()
    End Function

    Private Sub usrid_TextChanged(sender As Object, e As EventArgs) Handles usrid.TextChanged

    End Sub
End Class






