Imports System.Data.OleDb
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class VISITORS
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\source\repos\project-mtmc\project-mtmc\VISITORS.accdb;"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO VISITORS ([ID NUMBER] , [DATE], [NAME], [ADDRESS], [CONTACT NUMBER], [PERSON TO MEET NAME], [IN TIME], [OUT TIME], [TOTAL PERSON], [NO OF HOURS], [AVG TIME SPENT]) 
            VALUES (" & idno.Text & ", '" & DateTimePicker1.Text & "', '" & nmme.Text & "','" & addd.Text & "'," & cntt.Text & ",'" & prsnn.Text & "','" & intme.Text & "','" & outtme.Text & "'," & tper.Text & "," & nhrs.Text & ",'" & avgg.Text & "')"
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data inserted successfully.")
        conn.Close()
        idno.Clear()
        nhrs.Clear()
        nmme.Clear()
        tper.Clear()
        addd.Clear()
        cntt.Clear()
        prsnn.Clear()
        tper.Clear()
        avgg.Clear()
        outtme.Clear()
        intme.Clear()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Courior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\source\repos\project-mtmc\project-mtmc\VISITORS.accdb;"

    End Sub

    Private Sub Btnupdt_Click(sender As Object, e As EventArgs) Handles Btndlte.Click
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Check if the record exists
                Dim checkSql As String = "SELECT COUNT(*) FROM VISITORS WHERE [ID NUMBER] = @idnum"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@idnum", idno.Text)
                    Dim rowCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    ' If the record exists, delete it; otherwise, show a message
                    If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    End If
                    If rowCount > 0 Then
                        Dim deleteSql As String = "DELETE FROM VISITORS WHERE [ID NUMBER] = @idnum"
                        Using cmd As New OleDbCommand(deleteSql, conn)
                            cmd.Parameters.AddWithValue("@idnum", idno.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data deleted successfully.")
                        End Using
                    Else
                        MessageBox.Show("Record with ID NUMBER  " & idno.Text & " does not exist.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles Btnupd.Click
        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                ' Use parameterized queries to prevent SQL injection
                If DateTimePicker1.Value <> Nothing Then
                    updateClauses.Add("[DATE] = @Date")
                    cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value.Date)
                End If

                If Not String.IsNullOrEmpty(nmme.Text) Then
                    updateClauses.Add("[NAME] = '" & nmme.Text & "'")
                End If

                If Not String.IsNullOrEmpty(addd.Text) Then
                    updateClauses.Add("[ADDRESS] = '" & addd.Text & "'")
                End If

                If Not String.IsNullOrEmpty(cntt.Text) Then
                    updateClauses.Add("[CONTACT NUMBER] = '" & cntt.Text & "'")
                End If

                If Not String.IsNullOrEmpty(prsnn.Text) Then
                    updateClauses.Add("[PERSON TO MEET] = '" & prsnn.Text & "'")
                End If

                If Not String.IsNullOrEmpty(intme.Text) Then
                    updateClauses.Add("[IN TIME] = '" & intme.Text & "'")
                End If

                If Not String.IsNullOrEmpty(outtme.Text) Then
                    updateClauses.Add("[OUT TIME] = '" & outtme.Text & "'")
                End If

                If Not String.IsNullOrEmpty(tper.Text) Then
                    updateClauses.Add("[TOTAL PERSON] = '" & tper.Text & "'")
                End If

                If Not String.IsNullOrEmpty(nhrs.Text) Then
                    updateClauses.Add("[NO OF HOURS] = '" & nhrs.Text & "'")
                End If

                If Not String.IsNullOrEmpty(avgg.Text) Then
                    updateClauses.Add("[AVG TIME SPENT] = '" & avgg.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE VISITORS SET " & updateClause & " WHERE [ID NUMBER] = " & idno.Text
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data updated successfully.")
                Else
                    MessageBox.Show("No fields provided for update.")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Data Update Rejected")
        End If
    End Sub
End Class
