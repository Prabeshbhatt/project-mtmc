Imports System.Configuration
Imports System.Data.OleDb

Public Class Lost_Found
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap


    Private Sub Lost_Found_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Table1 ([Sl no],[Material Detail],[Location],[Person Found],[Date],[Quantity],[Handover],[Recieved],[Signature]) VALUES (" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "'," & TextBox5.Text & ",'" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "' )"
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
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                If Not String.IsNullOrEmpty(TextBox1.Text) Then
                    updateClauses.Add("[Sl no] = " & TextBox1.Text & "")
                End If
                If Not String.IsNullOrEmpty(TextBox2.Text) Then
                    updateClauses.Add("[Material Detail] = '" & TextBox2.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox3.Text) Then
                    updateClauses.Add("[Location] = '" & TextBox3.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox4.Text) Then
                    updateClauses.Add("[Person Found] = '" & TextBox4.Text & "'")
                End If


                If Not String.IsNullOrEmpty(DateTimePicker1.Text) Then
                    updateClauses.Add("[Date] = " & DateTimePicker1.Text & "")
                End If

                If Not String.IsNullOrEmpty(TextBox5.Text) Then
                    updateClauses.Add("[Quantity] = " & TextBox5.Text & "")
                End If
                If Not String.IsNullOrEmpty(TextBox6.Text) Then
                    updateClauses.Add("[Handover] = '" & TextBox6.Text & "'")
                End If


                If Not String.IsNullOrEmpty(TextBox7.Text) Then
                    updateClauses.Add("[Recieved] = '" & TextBox7.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox8.Text) Then
                    updateClauses.Add("[Signature] = '" & TextBox8.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE OUTWARD_FORM SET " & updateClause & " WHERE [Product No] = " & TextBox7.Text & ""
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
        Else MessageBox.Show("Data Update Rejected")
        End If
    End Sub
End Class