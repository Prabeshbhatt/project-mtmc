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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Reg_No As String = RegNo.Text
        Dim password As String = pass.Text

        Try
            conn.Open()
            Dim query As String = "SELECT * FROM LoginDB WHERE Password = @Password"
            Using cmd As New OleDbCommand(query, conn)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SecondForm As New Register
        SecondForm.Show()
    End Sub

    Private Sub RegNo_TextChanged(sender As Object, e As EventArgs) Handles RegNo.TextChanged

    End Sub
End Class