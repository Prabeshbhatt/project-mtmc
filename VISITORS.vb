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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Courior_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\source\repos\project-mtmc\project-mtmc\VISITORS.accdb;"

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If IsNewUser() Then
            SaveNewUserDetails()
        Else
            SaveExistingUserDetails()
        End If
    End Sub

    Private Function IsNewUser() As Boolean
        ' Check if the user is new based on NID existence in the database
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                Dim checkSql = "SELECT COUNT(*) FROM VISITORS WHERE [NID] = @nid"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@nid", NID.Text)
                    Dim rowCount = Convert.ToInt32(checkCmd.ExecuteScalar)

                    Return rowCount = 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub SaveNewUserDetails()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Insert new record for a new user
                Dim insertSql = "INSERT INTO VISITORS (VISITORS ID, DATE, NAME, NATIONAL ID, ADDRESS, CONTACT NUMBER, SEX, PERSON TO MEENT, IN TIME, OUT TIME, TOTAL PERSON, NO OF HOURS, PURPOSE TO VISIT) " &
                            "VALUES (@idno, @DateTimePicker1, @nmme, @NID, @addd, @cntt, @sex, @prsnn, @intme, @outtme, @tper, @nhrs, @pov)"
                Using cmd As New OleDbCommand(insertSql, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@nmme", nmme.Text)
                    cmd.Parameters.AddWithValue("@nid", NID.Text)
                    ' Add other parameters as needed
                    ' ...
                    ' Determine which radio button is selected
                    If RadioButton1.Checked Then
                        cmd.Parameters.AddWithValue("@sex", "Male")
                    ElseIf RadioButton2.Checked Then
                        cmd.Parameters.AddWithValue("@sex", "Female")
                    Else
                        cmd.Parameters.AddWithValue("@sex", DBNull.Value)
                    End If
                    ' Execute the insert command
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New user details saved successfully.")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveExistingUserDetails()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Check if the user exists based on NID
                Dim checkSql = "SELECT COUNT(*) FROM VISITORS WHERE [NID] = @nid"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@nid", NID.Text)
                    Dim rowCount = Convert.ToInt32(checkCmd.ExecuteScalar)

                    If rowCount > 0 Then
                        ' User already exists, create a new record with updated details
                        Dim insertSql = "INSERT INTO VISITORS (VISITORS ID, DATE, NAME, NATIONAL ID, ADDRESS, CONTACT NUMBER, SEX, PERSON TO MEENT, IN TIME, OUT TIME, TOTAL PERSON, NO OF HOURS, PURPOSE TO VISIT) " &
                                    "VALUES (@idno, @DateTimePicker1, @nmme, @NID, @addd, @cntt, @sex, @prsnn, @intme, @outtme, @tper, @nhrs, @pov)"
                        Using insertCmd As New OleDbCommand(insertSql, conn)
                            insertCmd.Parameters.AddWithValue("@nmme", nmme.Text)
                            insertCmd.Parameters.AddWithValue("@nid", NID.Text)
                            ' Add other parameters as needed
                            ' ...   ' Determine which radio button is selected
                            If RadioButton1.Checked Then
                                insertCmd.Parameters.AddWithValue("@sex", "Male")
                            ElseIf RadioButton2.Checked Then
                                insertCmd.Parameters.AddWithValue("@sex", "Female")
                            Else
                                insertCmd.Parameters.AddWithValue("@sex", DBNull.Value)
                            End If

                            ' Execute the insert command
                            insertCmd.ExecuteNonQuery()

                            MessageBox.Show("New record created for existing user.")
                        End Using
                    Else
                        MessageBox.Show("User with NID " & NID.Text & " does not exist.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub Btndlte_Click_1(sender As Object, e As EventArgs) Handles Btndlte.Click
        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                ' Use parameterized queries to prevent SQL injection
                If DateTimePicker1.Value <> Nothing Then
                    ' Exclude the date column from the update if DateTimePicker1 has a value
                    updateClauses.Add("[DATE] = @Date")
                    cmd.Parameters.AddWithValue("@Date", DateTimePicker1.Value.Date)
                End If

                If Not String.IsNullOrEmpty(nmme.Text) Then
                    updateClauses.Add("[NAME] = '" & nmme.Text & "'")
                End If

                ' Add other columns to updateClauses as needed

                Dim updateClause = String.Join(", ", updateClauses)
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

    Private Sub Btnupd_Click_1(sender As Object, e As EventArgs) Handles Btnupd.Click
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Check if the record exists
                Dim checkSql = "SELECT COUNT(*) FROM VISITORS WHERE [ID NUMBER] = @idnum"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@idnum", idno.Text)
                    Dim rowCount = Convert.ToInt32(checkCmd.ExecuteScalar)

                    ' If the record exists, delete it; otherwise, show a message
                    If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    End If
                    If rowCount > 0 Then
                        Dim deleteSql = "DELETE FROM VISITORS WHERE [ID NUMBER] = @idnum"
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
End Class
