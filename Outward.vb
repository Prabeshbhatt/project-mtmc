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
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\New folder\OutwardDB.accdb"

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click

        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO OUTWARD_FORM ([SL NO] , [GATE PASS NO], [MATERIAL], [QUANTITY], [DEPT], [DATE], [TO], [FROM], [GATE PASS TYPE], [RETURN DATE]) 
            VALUES (" & SlNoText.Text & ", " & GtPss.Text & ", '" & Mtrl.Text & "'," & Qty.Text & ",'" & Dpt.Text & "','" & Dte.Text & "','" & Totext.Text & "','" & Fromtxt.Text & "','" & GtPssType.Text & "','" & RtrnDte.Text & "')"
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data inserted successfully.")
        conn.Close()

    End Sub

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        If MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "DELETE FROM OUTWARD_FORM WHERE [GATE PASS NO] = " & GtPss.Text & ""
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
        SlNoText.Clear()
        GtPss.Clear()
        Mtrl.Clear()
        Qty.Clear()
        Dpt.Clear()
        Dte.Clear()
        Totext.Clear()
        Fromtxt.Clear()
        GtPssType.Clear()
        RtrnDte.Clear()
    End Sub

    Private Sub Btnupdt_Click(sender As Object, e As EventArgs) Handles Btnupdt.Click
        If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text

                Dim updateClauses As New List(Of String)

                If Not String.IsNullOrEmpty(SlNoText.Text) Then
                    updateClauses.Add("[SL NO] = " & SlNoText.Text & "")
                End If
                If Not String.IsNullOrEmpty(GtPss.Text) Then
                    updateClauses.Add("[GATE PASS NO] = " & GtPss.Text & "")
                End If

                If Not String.IsNullOrEmpty(Mtrl.Text) Then
                    updateClauses.Add("[MATERIAL] = '" & Mtrl.Text & "'")
                End If

                If Not String.IsNullOrEmpty(Qty.Text) Then
                    updateClauses.Add("[QUANTITY] = " & Qty.Text & "")
                End If

                If Not String.IsNullOrEmpty(Dpt.Text) Then
                    updateClauses.Add("[DEPT] = '" & Dpt.Text & "'")
                End If

                If Not String.IsNullOrEmpty(Dte.Text) Then
                    updateClauses.Add("[DATE] = '" & Dte.Text & "'")
                End If


                If Not String.IsNullOrEmpty(Totext.Text) Then
                    updateClauses.Add("[TO] = '" & Totext.Text & "'")
                End If

                If Not String.IsNullOrEmpty(Fromtxt.Text) Then
                    updateClauses.Add("[FROM] = '" & Fromtxt.Text & "'")
                End If

                If Not String.IsNullOrEmpty(GtPssType.Text) Then
                    updateClauses.Add("[GATE PASS TYPE] = '" & GtPssType.Text & "'")
                End If

                If Not String.IsNullOrEmpty(RtrnDte.Text) Then
                    updateClauses.Add("[RETURN DATE] = '" & RtrnDte.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE OUTWARD_FORM SET " & updateClause & " WHERE [GATE PASS NO] = " & GtPss.Text & ""
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

    Private Sub SlNoText_TextChanged(sender As Object, e As EventArgs) Handles SlNoText.TextChanged

    End Sub

    Private Sub GtPss_TextChanged(sender As Object, e As EventArgs) Handles GtPss.TextChanged

    End Sub

    Private Sub Mtrl_TextChanged(sender As Object, e As EventArgs) Handles Mtrl.TextChanged

    End Sub

    Private Sub Qty_TextChanged(sender As Object, e As EventArgs) Handles Qty.TextChanged

    End Sub

    Private Sub Dpt_TextChanged(sender As Object, e As EventArgs) Handles Dpt.TextChanged

    End Sub

    Private Sub Dte_TextChanged(sender As Object, e As EventArgs) Handles Dte.TextChanged

    End Sub

    Private Sub Totext_TextChanged(sender As Object, e As EventArgs) Handles Totext.TextChanged

    End Sub

    Private Sub Fromtxt_TextChanged(sender As Object, e As EventArgs) Handles Fromtxt.TextChanged

    End Sub

    Private Sub GtPssType_TextChanged(sender As Object, e As EventArgs) Handles GtPssType.TextChanged

    End Sub

    Private Sub RtrnDte_TextChanged(sender As Object, e As EventArgs) Handles RtrnDte.TextChanged

    End Sub
End Class
