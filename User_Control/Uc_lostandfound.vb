Imports System.Data.OleDb
Imports System.IO
Public Class Uc_lostandfound
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap
    Private Sub Uc_lostandfound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog.Title = "Open Picture"
        OpenFileDialog.FileName = ".png"
        OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        OpenFileDialog.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog.FileName)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Lostnfound ([Sl no],[Material Detail],[Location],[Person Found],[Date],[Quantity],[Handover],[Recieved],[Signature],[Picture]) 
VALUES (@SlNo, @MaterialDetail, @Location, @PersonFound, @Date, @Quantity, @Handover, @Received, @Signature, @Picture)"
            cmd.Parameters.Add("@SlNo", OleDbType.Integer).Value = Integer.Parse(TextBox1.Text)
            cmd.Parameters.Add("@MaterialDetail", OleDbType.VarChar).Value = TextBox2.Text
            cmd.Parameters.Add("@Location", OleDbType.VarChar).Value = TextBox3.Text
            cmd.Parameters.Add("@PersonFound", OleDbType.VarChar).Value = TextBox4.Text
            cmd.Parameters.Add("@Date", OleDbType.Date).Value = DateTimePicker1.Value ' Assuming Date is a Date/Time field
            cmd.Parameters.Add("@Quantity", OleDbType.Integer).Value = Integer.Parse(TextBox5.Text)
            cmd.Parameters.Add("@Handover", OleDbType.VarChar).Value = TextBox6.Text
            cmd.Parameters.Add("@Received", OleDbType.VarChar).Value = TextBox7.Text
            cmd.Parameters.Add("@Signature", OleDbType.VarChar).Value = TextBox8.Text
            Dim profilePictureData As Byte() = File.ReadAllBytes(OpenFileDialog.FileName)
            cmd.Parameters.Add("@Picture", OleDbType.VarBinary).Value = profilePictureData
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conn.Close()
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Function Datapresent(Slno As Integer) As Boolean
        Dim Result As Boolean = False
        conn.Open()
        Dim query As String = "SELECT * FROM Lostnfound WHERE [Sl no] = @Slno"
        Using command As New OleDbCommand(query, conn)
            command.Parameters.AddWithValue("@Slno", TextBox1.Text)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Result = True
            End If
        End Using
        conn.Close()
        Return Result
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Slno = TextBox1.Text
        If Datapresent(SlNo) Then
            Try
                If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    conn.Open()
                    cmd = conn.CreateCommand()
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "DELETE FROM Lostnfound WHERE [Sl no] = " & TextBox1.Text & ""
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Data deleted successfully.")
                Else
                    MessageBox.Show("Data Not Deleted")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Sl no Number Not Found!")
        End If
    End Sub
End Class