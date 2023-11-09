Imports System.Configuration
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inward
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap




    Private Sub Inward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project Mtmc git\Inward_Formdb.accdb"

    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO INWARD_FORM ([SL NO], [PARTY NAME], [MATERIAL MOVEMENT],[QUANTITY],[CHALLAN NO],[DATE],[IN TIME],[REMARKS],[SIGNATURE]) VALUES (" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "'," & TextBox4.Text & "," & TextBox5.Text & ",'" & DateTimePicker1.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "' )"
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conn.Close()
        End Try

    End Sub
End Class
