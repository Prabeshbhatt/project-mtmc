Imports System.Data.OleDb
Imports System.Runtime.Intrinsics.Arm

Public Class Courier
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO COURIER ([ID NUMBER] , [DATE], [NAME], [ADDRESS], [CONTACT NUMBER], [PERSON TO MEET NAME], [IN TIME], [OUT TIME], [TOTAL PERSON], [NO OF HOURS], [AVG TIME SPENT]) 
            VALUES (" & idno.Text & ", " & DateTimePicker1.Text & ", '" & nmme.Text & "'," & addd.Text & ",'" & cntt.Text & "','" & prsnn.Text & "','" & intme.Text & "','" & outtme.Text & "','" & tper.Text & "','" & nhrs.Text & "','" & avgg.Text & "')"
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data inserted successfully.")
        conn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Courior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\source\repos\project-mtmc\project-mtmc\courior.accdb;"

    End Sub
End Class