Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.SqlTypes






Public Class Outward
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Desktop\FinalDB.accdb;"
    Dim connection As New OleDbConnection(connectionString)



    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dte.Clear()
        inwrd.Clear()
        frm.Clear()
        matrl.Clear()
        Dept.Clear()
        bill.Clear()
        dc.Clear()
        desgn.Clear()
        vech.Clear()
        ret.Clear()
        sec.Clear()
        pack.Clear()
        remrks.Clear()


    End Sub

    Private Sub Form2_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Desktop\FinalDB.accdb;"
        Dim connection As New OleDbConnection(connectionString)

        ' Set the connection string before opening the connection
        connection.Open()

    End Sub

    Private Sub btnCreateDatabase_Click(sender As Object, e As System.EventArgs)
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Table1([INWARD_NO], [Date], [FROM],[MATERIAL_FOR_TO], [DEPT_PROCESS], [BILL_NO_DATE],[DC_NO_DATE], [No_Of_Packages_Unites], [Vehicle_No],[Returnable_or_Non_Returnable], [Name_Designation_Of_The_Person_Reciving_The_Metrials], [Security_Name],[Remarks]) 
                               VALUES (" & inwrd.Text & ",'" & Dte.Text & "', '" & frm.Text & "','" & matrl.Text & "','" & Dept.Text & "','" & bill.Text & "','" & dc.Text & "','" & pack.Text & "','" & vech.Text & "','" & ret.Text & "','" & desgn.Text & "','" & sec.Text & "','" & remrks.Text & "')"
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conn.Close()
        End Try




    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles inwrd.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                If Not String.IsNullOrEmpty(Dte.Text) Then
                    updateClauses.Add("[DATE] = '" & Dte.Text & "'")
                End If


                If Not String.IsNullOrEmpty(frm.Text) Then
                    updateClauses.Add("[FROM] = '" & frm.Text & "'")
                End If

                If Not String.IsNullOrEmpty(matrl.Text) Then
                    updateClauses.Add("[MATERIAL_FOR_TO] = '" & matrl.Text & "'")
                End If

                If Not String.IsNullOrEmpty(Dept.Text) Then
                    updateClauses.Add("[DEPT_PROCESS] = '" & Dept.Text & "'")
                End If

                If Not String.IsNullOrEmpty(bill.Text) Then
                    updateClauses.Add("[BILL_NO_PROCESS] = " & bill.Text)
                End If

                If Not String.IsNullOrEmpty(dc.Text) Then
                    updateClauses.Add("[DC_NO_DATE] = '" & dc.Text & "'")
                End If


                If Not String.IsNullOrEmpty(pack.Text) Then
                    updateClauses.Add("[No_Of_Packages_Unites] = '" & pack.Text & "'")
                End If

                If Not String.IsNullOrEmpty(vech.Text) Then
                    updateClauses.Add("[Vehicle_No] = '" & vech.Text & "'")
                End If

                If Not String.IsNullOrEmpty(ret.Text) Then
                    updateClauses.Add("[Returnable_or_Non_Returnable] = '" & ret.Text & "'")
                End If

                If Not String.IsNullOrEmpty(Dept.Text) Then
                    updateClauses.Add("[Name_Designation_Of_The_Person_Reciving_The_Metrials] = '" & Dept.Text & "'")
                End If


                If Not String.IsNullOrEmpty(sec.Text) Then
                    updateClauses.Add("[Security_Name] = '" & sec.Text & "'")
                End If

                If Not String.IsNullOrEmpty(remrks.Text) Then
                    updateClauses.Add("[Remarks] = '" & remrks.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE Table1 SET " & updateClause & " WHERE [INWARD_NO] = " & inwrd.Text & ""
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Check if the record exists
                Dim checkSql As String = "SELECT COUNT(*) FROM Table1 WHERE [INWARD_NO] = @InwardNo"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@InwardNo", inwrd.Text)
                    Dim rowCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    ' If the record exists, delete it; otherwise, show a message
                    If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    End If
                    If rowCount > 0 Then
                        Dim deleteSql As String = "DELETE FROM Table1 WHERE [INWARD_NO] = @InwardNo"
                        Using cmd As New OleDbCommand(deleteSql, conn)
                            cmd.Parameters.AddWithValue("@InwardNo", inwrd.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data deleted successfully.")
                        End Using
                    Else
                        MessageBox.Show("Record with INWARD_NO " & inwrd.Text & " does not exist.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles From.Click

    End Sub
End Class