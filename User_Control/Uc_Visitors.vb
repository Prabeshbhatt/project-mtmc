﻿Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports System.Globalization

Public Class Uc_Visitors
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = ""

    Dim connection As New OleDbConnection(connectionString)
    Private Shared originalDateTimeValueStandard As DateTime
    Private Shared originalContactNumber As String



    Private Sub Uc_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub save_Click_1(sender As Object, e As EventArgs) Handles Save.Click
        Dim vid = If(Integer.TryParse(idno.Text, Nothing), Integer.Parse(idno.Text), 0)
        Dim dateTimeValueStandard = DateTimePicker1.Value
        Dim name = nmme.Text
        Dim nationalID = NID.Text
        Dim contactNumber = If(Integer.TryParse(cntt.Text, Nothing), Integer.Parse(cntt.Text), 0)
        Dim inTime = Date.Parse(intme.Text)
        Dim outTime = Date.Parse(outtme.Text)
        Dim totalPersons = If(Integer.TryParse(tper.Text, Nothing), Integer.Parse(tper.Text), 0)
        Dim noofhours = If(Integer.TryParse(nhrs.Text, Nothing), Integer.Parse(nhrs.Text), 0)
        Dim purposeOfVisit = pov.Text
        Dim personToMeet = prsnn.Text
        Dim address = addd.Text
        Dim sex = GetSelectedRadioButtonText()



        ' Validate and save data
        If ValidateData(name, nationalID) Then
            ' Check if an existing user with the same details exists
            If Not ExistingUserExists(nationalID, address, contactNumber, sex, name) Then
                ' Save new user
                SaveNewUser(vid, dateTimeValueStandard, name, nationalID, address, contactNumber, sex, personToMeet, inTime, outTime, totalPersons, noofhours, purposeOfVisit)
                MessageBox.Show("New user created successfully.")
            Else
                ' Duplicate existing user data and save as a new user
                Dim existingUserData = GetExistingUserData(nationalID, address, contactNumber, sex)

                If existingUserData.Rows.Count > 0 Then
                    ' Duplicate existing user data and save as a new user
                    Dim existingRow = existingUserData.Rows(0)
                    SaveNewUser(vid, dateTimeValueStandard, name, existingRow("NATIONAL ID").ToString, existingRow("ADDRESS").ToString, Convert.ToInt32(existingRow("CONTACT NUMBER")), existingRow("SEX").ToString, personToMeet, inTime, outTime, totalPersons, noofhours, purposeOfVisit)
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

    Private Function ExistingUserExists(nationalID As String, address As String, contactNumber As Integer, sex As String, name As String) As Boolean
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



    Private Function GetExistingUserData(nationalID As String, address As String, contactNumber As Integer, sex As String) As DataTable
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

    Private Sub SaveNewUser(vid As Integer, dateTimeValue As DateTime, name As String, nationalID As String, address As String, contactNumber As Integer, sex As String, personToMeet As String, inTime As DateTime, outTime As DateTime, totalPersons As Integer, noofhours As Integer, purposeOfVisit As String)
        Using conn As New OleDbConnection("")
            conn.Open()
            Dim query As String = "INSERT INTO VISITORS ([VISITORS ID], [DATE], [NAME], [NATIONAL ID], [ADDRESS], [CONTACT NUMBER], [SEX], [PERSON TO MEET], [IN TIME], [OUT TIME], [TOTAL PERSON], [NO OF HOURS], [PURPOSE TO VISIT]) VALUES (@VisitorID, @DateTimeValue ,@Name, @NationalID, @Address, @ContactNumber, @Sex, @PersonToMeet, @InTime, @OutTime, @TotalPersons, @NoOfHours, @PurposeOfVisit)"
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






    Private Sub Btnupd_Click_1(sender As Object, e As EventArgs) Handles Btnupd.Click
        Try
            ' Get the VISITORS ID from user input or another source during runtime
            Dim vid As Integer
            Dim input = InputBox("Enter VISITORS ID to update:")

            If Not String.IsNullOrEmpty(input) AndAlso Integer.TryParse(input, vid) Then
                ' Check if the user with the specified VISITORS ID exists
                If UserExists(vid) Then
                    ' Collect updated data from user input or other sources
                    Dim updatedName = InputBox("Enter updated name:")
                    Dim updatedNationalID = InputBox("Enter updated national ID:")
                    Dim updatedAddress = InputBox("Enter updated address:")
                    Dim updatedSex = InputBox("Enter updated sex:")
                    Dim updatedPersonToMeet = InputBox("Enter updated person to meet:")
                    Dim updatedPurposeOfVisit = InputBox("Enter updated purpose of visit:")
                    Dim updatedContactNumber = InputBox("Enter updated contact number (leave blank to keep it unchanged):")

                    ' Use the class-level variables to store and retrieve the original values
                    Dim updatedInTime = If(originalDateTimeValueStandard = Date.MinValue, DateTimePicker1.Value, originalDateTimeValueStandard)
                    Dim updatedOutTime = If(originalDateTimeValueStandard = Date.MinValue, DateTimePicker1.Value, originalDateTimeValueStandard)

                    ' Set updatedContactNumber to originalContactNumber if user doesn't want to change it
                    updatedContactNumber = If(String.IsNullOrEmpty(updatedContactNumber), originalContactNumber, updatedContactNumber)

                    Dim updatedTotalPersons As Integer
                    If Not Integer.TryParse(InputBox("Enter updated total persons (leave blank to keep it unchanged):"), updatedTotalPersons) Then
                        ' Set it to a specific default value or leave it unchanged
                        updatedTotalPersons = 0 ' Replace 0 with the value you want to set
                    End If
                    Dim updatedNoOfHours As Integer
                    If Not Integer.TryParse(InputBox("Enter updated no of hours (leave blank to keep it unchanged):"), updatedNoOfHours) Then
                        ' Set it to a specific default value or leave it unchanged
                        updatedNoOfHours = 0 ' Replace 0 with the value you want to set
                    End If

                    ' Call the UpdateUser function with the collected data
                    UpdateUser(vid, updatedName, updatedNationalID, updatedAddress, updatedSex, updatedPersonToMeet, updatedContactNumber, updatedInTime, updatedOutTime, updatedTotalPersons, updatedNoOfHours, updatedPurposeOfVisit)
                Else
                    ' User does not exist
                    MessageBox.Show($"User with VISITORS ID {vid} does not exist.")
                End If
            Else
                ' Invalid input for VISITORS ID
                MessageBox.Show("Invalid input for VISITORS ID.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during update operation: {ex.Message}")
        End Try
    End Sub
    Private Sub UpdateUser(vid As Integer, name As String, nationalID As String, address As String, sex As String, personToMeet As String, contactNumber As String, inTime As DateTime, outTime As DateTime, totalPersons As Integer, noofhours As Integer, purposeOfVisit As String)
        Try
            Dim connectionString As String = ""

            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE VISITORS SET [NAME] = @Name, [NATIONAL ID] = @NationalID, [ADDRESS] = @Address, [SEX] = @Sex, [PERSON TO MEET] = @PersonToMeet, [CONTACT NUMBER] = @ContactNumber, [IN TIME] = @InTime, [OUT TIME] = @OutTime, [TOTAL PERSON] = @TotalPersons, [NO OF HOURS] = @NoOfHours, [PURPOSE TO VISIT] = @PurposeOfVisit WHERE [VISITORS ID] = @VisitorID"

                Using command As New OleDbCommand(query, conn)

                    command.Parameters.AddWithValue("@Name", OleDbType.WChar).Value = name
                    command.Parameters.AddWithValue("@NationalID", OleDbType.WChar).Value = nationalID
                    command.Parameters.AddWithValue("@Address", OleDbType.WChar).Value = address
                    command.Parameters.AddWithValue("@Sex", OleDbType.WChar).Value = sex
                    command.Parameters.AddWithValue("@PersonToMeet", OleDbType.WChar).Value = personToMeet
                    command.Parameters.AddWithValue("@ContactNumber", OleDbType.WChar).Value = contactNumber
                    command.Parameters.AddWithValue("@InTime", OleDbType.DBTimeStamp).Value = If(inTime = DateTime.MinValue, DBNull.Value, CType(inTime, Object))
                    command.Parameters.AddWithValue("@OutTime", OleDbType.DBTimeStamp).Value = If(outTime = DateTime.MinValue, DBNull.Value, CType(outTime, Object))
                    command.Parameters.AddWithValue("@TotalPersons", OleDbType.Integer).Value = totalPersons
                    command.Parameters.AddWithValue("@NoOfHours", OleDbType.Integer).Value = noofhours
                    command.Parameters.AddWithValue("@PurposeOfVisit", OleDbType.WChar).Value = purposeOfVisit
                    command.Parameters.AddWithValue("@VisitorID", OleDbType.Integer).Value = vid


                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show($"User with VISITORS ID {vid} updated successfully.")
        Catch ex As Exception
            MessageBox.Show($"Error updating user: {ex.Message}")
        End Try
    End Sub








    Private Sub Btndlt_Click_1(sender As Object, e As EventArgs) Handles Btndlt.Click
        Try
            ' Get the VISITORS ID from user input or another source during runtime
            Dim vid As Integer
            Dim input = InputBox("Enter VISITORS ID to delete:")

            If Not String.IsNullOrEmpty(input) AndAlso Integer.TryParse(input, vid) Then
                ' Check if the user with the specified VISITORS ID exists
                If UserExists(vid) Then
                    ' User exists, proceed with deletion
                    DeleteUser(vid)
                Else
                    ' User does not exist
                    MessageBox.Show($"User with VISITORS ID {vid} does not exist.")
                End If
            Else
                ' Invalid input for VISITORS ID
                MessageBox.Show("Invalid input for VISITORS ID.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during delete operation: {ex.Message}")
        End Try
    End Sub

    Private Function UserExists(vid As Integer) As Boolean
        Try
            Using conn As New OleDbConnection("")
                conn.Open()

                ' Use a parameterized SELECT query to check if the user exists
                Dim query As String = "SELECT COUNT(*) FROM VISITORS WHERE [VISITORS ID] = @VisitorID"

                Using command As New OleDbCommand(query, conn)
                    ' Set parameter
                    command.Parameters.AddWithValue("@VisitorID", OleDbType.Integer).Value = vid

                    ' Execute the SELECT query
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' If count is greater than 0, user exists
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error checking user existence: {ex.Message}")
            Return False
        End Try
    End Function

    Private Sub DeleteUser(vid As Integer)
        Try
            ' Check if the user with the specified VISITORS ID exists
            If UserExists(vid) Then
                Using conn As New OleDbConnection("")
                    conn.Open()

                    ' Use a parameterized DELETE query
                    Dim query As String = "DELETE FROM VISITORS WHERE [VISITORS ID] = @VisitorID"

                    Using command As New OleDbCommand(query, conn)
                        ' Set parameter
                        command.Parameters.AddWithValue("@VisitorID", OleDbType.Integer).Value = vid

                        ' Execute the DELETE query
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show($"User with VISITORS ID {vid} deleted successfully.")
            Else
                MessageBox.Show($"User with VISITORS ID {vid} does not exist.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error deleting user: {ex.Message}")
        End Try
    End Sub
End Class



