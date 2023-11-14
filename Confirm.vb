Imports System.Data.OleDb
Imports System.Configuration
Public Class Confirm
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap


    Dim password As String = ""
    Private Sub Confirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""
    End Sub

    Private Sub Psswrd_TextChanged(sender As Object, e As EventArgs) Handles Psswrd.TextChanged

    End Sub

    Private Sub CnfrmPW_TextChanged(sender As Object, e As EventArgs) Handles CnfrmPW.TextChanged

    End Sub

    Private Sub Cnfrm_Click(sender As Object, e As EventArgs) Handles Cnfrm.Click
        Dim pw As String = Psswrd.Text.Trim()
        Dim repeatpw As String = CnfrmPW.Text.Trim()

        If pw = repeatpw Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                ' Use parameterized query to prevent SQL injection
                cmd.CommandText = "INSERT INTO LoginDB ([Password]) VALUES ('" & Psswrd.Text & "')"
                cmd.Parameters.AddWithValue("@Password", Psswrd.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Password Set Successfully")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Passwords do not match")
        End If
    End Sub
End Class