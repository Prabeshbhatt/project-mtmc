﻿Imports System.Configuration
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Inward
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap




    Private Sub Inward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""

    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO Table1 ([Sl no],[Party Name],[Material],[Quantity],[Challan_No],[Date],[In Time],[Remark],[Signature]) VALUES (" & TextBox1.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "'," & TextBox4.Text & "," & TextBox5.Text & ",'" & DateTimePicker1.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "' )"
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
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()

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
                    updateClauses.Add("[Party Name] = '" & TextBox2.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox3.Text) Then
                    updateClauses.Add("[Material] = '" & TextBox3.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox4.Text) Then
                    updateClauses.Add("[Quantity] = " & TextBox4.Text & "")
                End If
                If Not String.IsNullOrEmpty(TextBox5.Text) Then
                    updateClauses.Add("[Challan_No] = " & TextBox5.Text & "")
                End If


                If Not String.IsNullOrEmpty(DateTimePicker1.Text) Then
                    updateClauses.Add("[Date] = '" & DateTimePicker1.Text & "'")
                End If


                If Not String.IsNullOrEmpty(TextBox7.Text) Then
                    updateClauses.Add("[In Time] = '" & TextBox7.Text & "'")
                End If


                If Not String.IsNullOrEmpty(TextBox8.Text) Then
                    updateClauses.Add("[Remark] = '" & TextBox8.Text & "'")
                End If

                If Not String.IsNullOrEmpty(TextBox9.Text) Then
                    updateClauses.Add("[Signature] = '" & TextBox9.Text & "'")
                End If

                Dim updateClause As String = String.Join(", ", updateClauses)
                If updateClause <> "" Then
                    cmd.CommandText = "UPDATE Table1 SET " & updateClause & " WHERE [Challan_No] = " & TextBox5.Text & ""
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
