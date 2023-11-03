Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Runtime.Intrinsics

Public Class Form3
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles desgnn.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dte.Clear()
        bll.Clear()
        dcc.Clear()
        out.Clear()
        frmm.Clear()
        mat.Clear()
        dptt.Clear()
        rmrk.Clear()
        desgnn.Clear()
        retrn.Clear()
        secnm.Clear()
        pkg.Clear()
        veh.Clear()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\Downloads\prabesh .net\no preview\project mtmc\sample.accdb;"
        Dim connection As New OleDbConnection(connectionString)

        ' Set the connection string before opening the connection
        connection.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Table2([OUTWARD_NO], [Date], [FROM],[MATERIAL_FOR_TO], [DEPT_PROCESS], [BILL_NO_DATE],[DC_NO_DATE], [No_Of_Packages_Unites], [Vehicle_No],[Returnable_or_Non_Returnable], [Name_Designation_Of_The_Person_Reciving_The_Metrials], [Security_Name],[Remarks]) 
                               VALUES (" & out.Text & ",'" & dte.Text & "', '" & frmm.Text & "','" & mat.Text & "','" & dptt.Text & "','" & bll.Text & "','" & dcc.Text & "','" & pkg.Text & "','" & veh.Text & "','" & retrn.Text & "','" & desgnn.Text & "','" & secnm.Text & "','" & rmrk.Text & "')"
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                If Not String.IsNullOrEmpty(dte.Text) Then
                    updateClauses.Add("[DATE] = '" & dte.Text & "'")
                End If


                If Not String.IsNullOrEmpty(frmm.Text) Then
                    updateClauses.Add("[FROM] = '" & frmm.Text & "'")
                End If

                If Not String.IsNullOrEmpty(mat.Text) Then
                    updateClauses.Add("[MATERIAL_FOR_TO] = '" & mat.Text & "'")
                End If

                If Not String.IsNullOrEmpty(dptt.Text) Then
                    updateClauses.Add("[DEPT_PROCESS] = '" & dptt.Text & "'")
                End If

                If Not String.IsNullOrEmpty(bll.Text) Then
                    updateClauses.Add("[BILL_NO_PROCESS] = " & bll.Text)
                End If

                If Not String.IsNullOrEmpty(dcc.Text) Then
                    updateClauses.Add("[DC_NO_DATE] = '" & dcc.Text & "'")
                End If


                If Not String.IsNullOrEmpty(pkg.Text) Then
                    updateClauses.Add("[No_Of_Packages_Unites] = '" & pkg.Text & "'")
                End If

                If Not String.IsNullOrEmpty(veh.Text) Then
                    updateClauses.Add("[Vehicle_No] = '" & veh.Text & "'")
                End If

                If Not String.IsNullOrEmpty(retrn.Text) Then
                    updateClauses.Add("[Returnable_or_Non_Returnable] = '" & retrn.Text & "'")
                End If

                If Not String.IsNullOrEmpty(dptt.Text) Then
                    updateClauses.Add("[Name_Designation_Of_The_Person_Reciving_The_Metrials] = '" & dptt.Text & "'")
                End If


                If Not String.IsNullOrEmpty(secnm.Text) Then
                    updateClauses.Add("[Security_Name] = '" & secnm.Text & "'")
                End If

                If Not String.IsNullOrEmpty(rmrk.Text) Then
                    updateClauses.Add("[Remarks] = '" & rmrk.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE Table2 SET " & updateClause & " WHERE [OUTWARD_NO] = " & out.Text & ""
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

    Private Sub out_TextChanged(sender As Object, e As EventArgs) Handles out.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Check if the record exists
                Dim checkSql As String = "SELECT COUNT(*) FROM Table2 WHERE [OUTWARD_NO] = @outwardNo"
                Using checkCmd As New OleDbCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@outwardNo", out.Text)
                    Dim rowCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    ' If the record exists, delete it; otherwise, show a message
                    If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    End If
                    If rowCount > 0 Then
                        Dim deleteSql As String = "DELETE FROM Table2 WHERE [OUTWARD_NO] = @outwardNo"
                        Using cmd As New OleDbCommand(deleteSql, conn)
                            cmd.Parameters.AddWithValue("@outwardNo", out.Text)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data deleted successfully.")
                        End Using
                    Else
                        MessageBox.Show("Record with OutWardNo " & out.Text & " does not exist.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class