Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Uc_Visitors
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = ""

    Dim connection As New OleDbConnection(connectionString)
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim vid As Integer = If(Integer.TryParse(idno.Text, Nothing), Integer.Parse(idno.Text), 0)
        Dim dateTimeValueStandard As DateTime = DateTimePicker1.Value
        Dim name As String = nmme.Text
        Dim nationalID As String = NID.Text
        Dim contactNumber As Integer = If(Integer.TryParse(cntt.Text, Nothing), Integer.Parse(cntt.Text), 0)
        Dim inTime As DateTime = DateTime.Parse(intme.Text)
        Dim outTime As DateTime = DateTime.Parse(outtme.Text)
        Dim totalPersons As Integer = If(Integer.TryParse(tper.Text, Nothing), Integer.Parse(tper.Text), 0)
        Dim noofhours As Integer = If(Integer.TryParse(nhrs.Text, Nothing), Integer.Parse(nhrs.Text), 0)
        Dim purposeOfVisit As String = pov.Text
        Dim personToMeet As String = prsnn.Text
        Dim address As String = addd.Text
        Dim sex As String = GetSelectedRadioButtonText()

        ' Validate and save data
        If ValidateData(name, nationalID) Then
            ' Check if an existing user with the same details exists
            If Not ExistingUserExists(nationalID, address, contactNumber, sex, name) Then
                ' Save new user
                SaveNewUser(vid, dateTimeValueStandard, name, nationalID, address, contactNumber, sex, personToMeet, inTime, outTime, totalPersons, noofhours, purposeOfVisit)
                MessageBox.Show("New user created successfully.")
            Else
                ' Duplicate existing user data and save as a new user
                Dim existingUserData As DataTable = GetExistingUserData(nationalID, address, contactNumber, sex)

                If existingUserData.Rows.Count > 0 Then
                    ' Duplicate existing user data and save as a new user
                    Dim existingRow As DataRow = existingUserData.Rows(0)
                    SaveNewUser(vid, dateTimeValueStandard, name, existingRow("NATIONAL ID").ToString(), existingRow("ADDRESS").ToString(), Convert.ToInt32(existingRow("CONTACT NUMBER")), existingRow("SEX").ToString(), personToMeet, inTime, outTime, totalPersons, noofhours, purposeOfVisit)
                    MessageBox.Show("Existing user data saved as a new user successfully.")
                End If
            End If
        End If
    End Sub

    Private Function ValidateData(name As String, nationalID As String) As Boolean
        ' Perform any additional validation logic here
        ' Return True if data is valid, otherwise return False
        ' You may check if required fields are not empty, format of data is correct, etc.
        ' For example:
        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Please enter a name.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(nationalID) Then
            MessageBox.Show("Please enter a national ID.")
            Return False
        End If

        ' Add more validation as needed

        Return True
    End Function

    Private Function ExistingUserExists(nationalID As String, address As String, contactNumber As String, sex As String, name As String) As Boolean
        Try
            Using conn As New OleDbConnection("")
                conn.Open()

                ' Query to check if a user with the same National ID exists
                Dim query As String = "SELECT * FROM VISITORS WHERE [NATIONAL ID] = @NationalID"

                Using command As New OleDbCommand(query, conn)
                    ' Set parameters
                    command.Parameters.AddWithValue("@NationalID", nationalID)
                    ' Execute the query
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        ' If there's a matching user, check other criteria
                        If reader.Read() Then
                            Dim existingContactNumber As String = reader("CONTACT NUMBER").ToString()
                            Dim existingSex As String = reader("SEX").ToString()
                            Dim existingAddress As String = reader("ADDRESS").ToString()
                            Dim existingName As String = reader("NAME").ToString()

                            ' Check if any other criteria don't match
                            If existingContactNumber = contactNumber AndAlso existingSex = sex AndAlso existingAddress = address AndAlso existingName = name Then
                                MessageBox.Show("A Existing user found.")
                                Return True
                            ElseIf existingContactNumber <> contactNumber OrElse existingSex <> sex OrElse existingAddress <> address OrElse existingName <> name Then
                                MessageBox.Show("Provided details do not match with National ID. Please check Name, Contact number, Address, Sex.")
                                Return True
                            End If
                        End If
                    End Using
                End Using
            End Using

            ' If no matching user found, return false
            Return False
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error, show a message)
            MessageBox.Show("Error checking existing user: " & ex.Message)
            Return False ' Return false in case of an error
        End Try
    End Function



    Private Function GetExistingUserData(nationalID As String, address As String, contactNumber As String, sex As String) As DataTable
        Dim dataTable As New DataTable()
        Using conn As New OleDbConnection("")
            conn.Open()
            Dim query As String = "SELECT * FROM VISITORS WHERE [NATIONAL ID] = @NationalID AND [ADDRESS] = @Address AND [CONTACT NUMBER] = @ContactNumber AND [SEX] = @Sex"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@NationalID", OleDbType.WChar).Value = nationalID
                command.Parameters.AddWithValue("@Address", OleDbType.WChar).Value = address
                command.Parameters.AddWithValue("@ContactNumber", OleDbType.Integer).Value = contactNumber
                command.Parameters.AddWithValue("@Sex", OleDbType.WChar).Value = sex
                Using adapter As New OleDbDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using
        Return dataTable
    End Function

    Private Sub SaveNewUser(vid As Integer, dateTimeValue As DateTime, name As String, nationalID As String, address As String, contactNumber As String, sex As String, personToMeet As String, inTime As DateTime, outTime As DateTime, totalPersons As Integer, noofhours As Integer, purposeOfVisit As String)
        Using conn As New OleDbConnection("")
            conn.Open()
            Dim query As String = "INSERT INTO VISITORS ([VISITORS ID], [DATE], [NAME], [NATIONAL ID], [ADDRESS], [CONTACT NUMBER], [SEX], [PERSON TO MEET], [IN TIME], [OUT TIME], [TOTAL PERSON], [NO OF HOURS], [PURPOSE TO VISIT]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("@VisitorID", OleDbType.Integer).Value = vid
                command.Parameters.AddWithValue("@DateTimeValue", OleDbType.Date).Value = dateTimeValue
                command.Parameters.AddWithValue("@Name", OleDbType.WChar).Value = name
                command.Parameters.AddWithValue("@NationalID", OleDbType.WChar).Value = nationalID
                command.Parameters.AddWithValue("@Address", OleDbType.WChar).Value = address
                command.Parameters.AddWithValue("@ContactNumber", OleDbType.Integer).Value = contactNumber
                command.Parameters.AddWithValue("@Sex", OleDbType.WChar).Value = sex
                command.Parameters.AddWithValue("@PersonToMeet", OleDbType.WChar).Value = personToMeet
                command.Parameters.AddWithValue("@InTime", OleDbType.Date).Value = inTime
                command.Parameters.AddWithValue("@OutTime", OleDbType.Date).Value = outTime
                command.Parameters.AddWithValue("@TotalPersons", OleDbType.Integer).Value = totalPersons
                command.Parameters.AddWithValue("@NoOfHours", OleDbType.Integer).Value = noofhours
                command.Parameters.AddWithValue("@PurposeOfVisit", OleDbType.WChar).Value = purposeOfVisit
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



    Private Sub Btndt_Click(sender As Object, e As EventArgs) Handles Btndt.Click
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

    Private Sub Btnupd_Click(sender As Object, e As EventArgs) Handles Btnupd.Click
        ' Extract data from form controls
        Dim vid As Integer = If(Integer.TryParse(idno.Text, Nothing), Integer.Parse(idno.Text), 0)
        Dim dateTimeValue As DateTime = DateTimePicker1.Value
        Dim name As String = nmme.Text
        Dim nationalID As String = NID.Text
        Dim contactNumber As Integer = If(Integer.TryParse(cntt.Text, Nothing), Integer.Parse(cntt.Text), 0)
        Dim inTime As DateTime = DateTime.Parse(intme.Text)
        Dim outTime As DateTime = DateTime.Parse(outtme.Text)
        Dim totalPersons As Integer = If(Integer.TryParse(tper.Text, Nothing), Integer.Parse(tper.Text), 0)
        Dim noofhours As Integer = If(Integer.TryParse(nhrs.Text, Nothing), Integer.Parse(nhrs.Text), 0)
        Dim purposeOfVisit As String = pov.Text
        Dim personToMeet As String = prsnn.Text
        Dim address As String = addd.Text
        Dim sex As String = GetSelectedRadioButtonText()

        ' Validate and update data
        If ValidateData(name, nationalID) Then
            ' Check if an existing user with the same details exists
            If ExistingUserExists(nationalID, address, contactNumber, sex, name) Then
                ' Update user
                UpdateUser(vid, dateTimeValue, name, nationalID, address, contactNumber, sex, personToMeet, inTime, outTime, totalPersons, noofhours, purposeOfVisit)
                MessageBox.Show("User data updated successfully.")
            Else
                ' No matching user found
                MessageBox.Show("User with the provided details not found.")
            End If
        End If
    End Sub

    Private Sub UpdateUser(vid As Integer, dateTimeValue As DateTime, name As String, nationalID As String, address As String, contactNumber As Integer, sex As String, personToMeet As String, inTime As DateTime, outTime As DateTime, totalPersons As Integer, noofhours As Integer, purposeOfVisit As String)
        Try
            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\source\repos\project-mtmc\project-mtmc\DATABASES\VISITORS.accdb")
                conn.Open()

                ' Query to update user data
                Dim query As String = "UPDATE VISITORS SET [DATE] = ?, [NAME] = ?, [ADDRESS] = ?, [CONTACT NUMBER] = ?, [SEX] = ?, [PERSON TO MEET] = ?, [IN TIME] = ?, [OUT TIME] = ?, [TOTAL PERSON] = ?, [NO OF HOURS] = ?, [PURPOSE TO VISIT] = ? WHERE [VISITORS ID] = ?"

                Using command As New OleDbCommand(query, conn)
                    ' Set parameters
                    command.Parameters.AddWithValue("@DateTimeValue", OleDbType.Date).Value = dateTimeValue
                    command.Parameters.AddWithValue("@Name", OleDbType.WChar).Value = name
                    command.Parameters.AddWithValue("@Address", OleDbType.WChar).Value = address
                    command.Parameters.AddWithValue("@ContactNumber", OleDbType.Integer).Value = contactNumber
                    command.Parameters.AddWithValue("@Sex", OleDbType.WChar).Value = sex
                    command.Parameters.AddWithValue("@PersonToMeet", OleDbType.WChar).Value = personToMeet
                    command.Parameters.AddWithValue("@InTime", OleDbType.Date).Value = inTime
                    command.Parameters.AddWithValue("@OutTime", OleDbType.Date).Value = outTime
                    command.Parameters.AddWithValue("@TotalPersons", OleDbType.Integer).Value = totalPersons
                    command.Parameters.AddWithValue("@NoOfHours", OleDbType.Integer).Value = noofhours
                    command.Parameters.AddWithValue("@PurposeOfVisit", OleDbType.WChar).Value = purposeOfVisit
                    command.Parameters.AddWithValue("@VisitorID", OleDbType.Integer).Value = vid ' Use this parameter for the WHERE clause

                    ' Execute the update query
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions (e.g., log the error, show a message)
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub
End Class
