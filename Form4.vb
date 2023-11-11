Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Runtime.Intrinsics
Public Class Form4
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim user_id As String = usrid.Text
        Dim password As String = Psswrd.Text

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM LoginDB WHERE [Password]='" & Psswrd.Text & "'"
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@User_id", user_id)
                cmd.Parameters.AddWithValue("@Password", password)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("Login Successful!")
                    ' Add code to navigate to the next form or perform other actions upon successful login
                Else
                    MessageBox.Show("Invalid Username or Password")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Dim SecondForm As New Register
        SecondForm.Show()
    End Sub

    Private Sub RstPW_Click(sender As Object, e As EventArgs) Handles RstPW.Click

    End Sub

    Private Sub Psswrd_TextChanged(sender As Object, e As EventArgs) Handles Psswrd.TextChanged

    End Sub
End Class