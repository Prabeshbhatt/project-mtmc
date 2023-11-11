Imports System.Configuration
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Courier
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap

    Private Sub Courier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project Mtmc git\Courier_db.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Table1 ([Sl_no],[To],[From],[Date],[Time],[Recieved],[Product No],[Department],[Signature],[Remark]) VALUES (" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "'," & TextBox7.Text & ",'" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
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
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
    End Sub
End Class