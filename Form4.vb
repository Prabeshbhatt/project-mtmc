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
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;Persist Security Info=False;"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_id As String = usrid.Text
        Dim password As String = pass.Text

        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM Table3 WHERE User_id = @user_id AND Password = @Password"
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
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SecondForm As New Form5
        SecondForm.Show()
    End Sub
End Class