Imports System.Data.OleDb
Imports System.Windows.Forms.Form

Public Class ProfilePage
    Inherits System.Windows.Forms.Form
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub ProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""
    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Dim regNo As String = TextBox1.Text

        Try
            conn.Open()

            ' Execute a query to retrieve profile information based on registration number
            cmd.Connection = conn
            cmd.CommandText = "SELECT LName, Age, Rank, Profile FROM LoginDB WHERE LRegNo = @RegNo"
            cmd.Parameters.AddWithValue("@RegNo", regNo)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Display profile information
                TextBox2.Text = dr("LName").ToString()
                TextBox3.Text = dr("Age").ToString()
                TextBox4.Text = dr("Rank").ToString()

                ' Display profile picture
                Dim imageData As Byte() = DirectCast(dr("Profile"), Byte())
                Dim ms As New System.IO.MemoryStream(imageData)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                MessageBox.Show("Profile not found for the entered registration number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class