Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Runtime.Intrinsics
Public Class Login
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Reg_no As String = RegNo.Text
        Dim password As String = pass.Text

        Try

            conn.Open()
                Dim query As String = "SELECT * FROM UserInfo WHERE LRegNo=@RegNo AND Password = @Password"
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RegNo", Reg_no)
                    cmd.Parameters.AddWithValue("@Password", password)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Login Successful!")
                            Dim nextform As New HOMEPAGE_FOR_SECURITY
                            nextform.Show()
                            Me.Hide()
                            ' Add code to navigate to the next form or perform other actions upon successful login
                        Else
                            MessageBox.Show("Invalid Username or Password")
                        End If
                    End Using
                End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub RegisterLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLink.LinkClicked
        Dim registerform As New Register
        registerform.Show()
        Me.Hide()
    End Sub

    Private Sub RstPW_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RstPW.LinkClicked

    End Sub

    Private Sub RegNo_TextChanged(sender As Object, e As EventArgs) Handles RegNo.TextChanged

    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub
End Class