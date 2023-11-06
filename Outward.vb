Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Outward
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap





    Private Sub Outward_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MTMC\New folder\project-mtmc\FinalDB.accdb;"
        Dim connection As New OleDbConnection(connectionString)

        ' Set the connection string before opening the connection
        connection.Open()

    End Sub




    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO OUTWARD_FORM ([ID] , [Name], [DOB], [Designation], [Workdays], [Dept]) VALUES (" & TextID.Text & ", '" & TextName.Text & "', '" & TextDOB.Text & "','" & TextDesign.Text & "'," & Textworkdays.Text & ",'" & TextDept.Text & "')"
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data inserted successfully.")
        Catch ex As Exception
            MessageBox.Show("Try Again")
            conn.Close()
        End Try

    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM Sample WHERE [ID] = " & TextID.Text & ""
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Data deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                conn.Close()

            End Try
        Else MessageBox.Show("Data Not Deleted")
        End If

    End Sub

    Private Sub Btnrst_Click(sender As Object, e As EventArgs) Handles Btnrst.Click

    End Sub

    Private Sub Btnupdt_Click(sender As Object, e As EventArgs) Handles Btnupdt.Click
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
