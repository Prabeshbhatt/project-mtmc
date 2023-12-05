Imports System.Data.OleDb
Imports System.Data.SqlClient
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
        Dim vid As Integer = Convert.ToInt32(idno.Text)
        Dim dateTimeValue As DateTime = DateTimePicker1.Value
        Dim name As String = nmme.Text
        Dim nationalID As String = NID.Text
        Dim address As String = addd.Text
        Dim contactNumber As String = cntt.Text
        Dim sex As String = GetSelectedRadioButtonText()
        Dim personToMeet As String = prsnn.Text
        Dim inTime As DateTime = DateTime.Now
        Dim outTime As DateTime = DateTime.Now.AddHours(1) ' You can modify this as needed
        Dim porposeToVisit As String = pov.Text
        Dim totalPersons As Integer
        If Integer.TryParse(tper.Text, totalPersons) Then
            If ExistingUserExists(nationalID, address, contactNumber, sex) Then
                ' Existing user found, save new data
                SaveNewUser(vid, dateTimeValue, name, nationalID, address, contactNumber, sex, personToMeet, inTime, outTime, totalPersons, porposeToVisit)
                MessageBox.Show("New user data saved successfully.")
            Else
                ' No existing user found, show a message or handle as needed
                MessageBox.Show("User not found or authentication failed.")
            End If
        Else
            MessageBox.Show("Please enter a valid number for Total Persons.")
        End If
    End Sub

    Private Function ExistingUserExists(nationalID As String, address As String, contactNumber As String, sex As String) As Boolean
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT NationalID FROM VISITORS WHERE NationalID = @NationalID AND Address = @Address AND ContactNumber = @ContactNumber AND Sex = @Sex"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@NationalID", nationalID)
                command.Parameters.AddWithValue("@Address", address)
                command.Parameters.AddWithValue("@ContactNumber", contactNumber)
                command.Parameters.AddWithValue("@Sex", sex)
                Return command.ExecuteScalar() IsNot Nothing
            End Using
        End Using
    End Function

    Private Sub SaveNewUser(vid As Integer, dateTimeValue As DateTime, name As String, nationalID As String, address As String, contactNumber As String, sex As String, personToMeet As String, inTime As DateTime, outTime As DateTime, totalPersons As Integer, purposeOfVisit As String)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO VISITORS (VisitorID, DateTimeValue, Name, NationalID, Address, ContactNumber, Sex, PersonToMeet, InTime, OutTime, TotalPersons, PurposeOfVisit) VALUES (@VisitorID, @DateTimeValue, @Name, @NationalID, @Address, @ContactNumber, @Sex, @PersonToMeet, @InTime, @OutTime, @TotalPersons, @PurposeOfVisit)"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@VisitorID", vid)
                command.Parameters.AddWithValue("@DateTimeValue", dateTimeValue)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@NationalID", nationalID)
                command.Parameters.AddWithValue("@Address", address)
                command.Parameters.AddWithValue("@ContactNumber", contactNumber)
                command.Parameters.AddWithValue("@Sex", sex)
                command.Parameters.AddWithValue("@PersonToMeet", personToMeet)
                command.Parameters.AddWithValue("@InTime", inTime)
                command.Parameters.AddWithValue("@OutTime", outTime)
                command.Parameters.AddWithValue("@TotalPersons", totalPersons)
                command.Parameters.AddWithValue("@PurposeOfVisit", purposeOfVisit)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function GetSelectedRadioButtonText() As String
        If RadioButton1.Checked Then
            Return "Male"
        ElseIf RadioButton2.Checked Then
            Return "Female"
        Else
            Return String.Empty
        End If
    End Function












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
