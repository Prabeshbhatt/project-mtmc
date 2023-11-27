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
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\MTMC PROJECT\OutwardDB.accdb"
    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Dim GatePassNo As Integer = GtPss.Text
        Dim material As String = Mtrl.Text
        Dim quantity As Integer = Qty.Text
        Dim department As String = Dpt.Text
        Dim Odate As String = Dte.Value
        Dim Oto As String = Totext.Text
        Dim Ofrom As String = Fromtxt.Text
        Dim GatePassType As String = GtePssType.SelectedItem
        Dim ReturnDate As String = RtrnDte.Value
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO OUTWARD_FORM ([GATE PASS NO], [MATERIAL], [QUANTITY], [DEPT], [DATE], [TO], [FROM], [GATE PASS TYPE], [RETURN DATE]) 
            VALUES (@GatePassNo,@Material,@Qty,@Dept,@Date,@To,@From,@GatePassType,@ReturnDate)"
        cmd.Parameters.AddWithValue("@GatePassNo", OleDbType.Integer).Value = GatePassNo
        cmd.Parameters.AddWithValue("@Material", OleDbType.VarChar).Value = material
        cmd.Parameters.AddWithValue("@Qty", OleDbType.Integer).Value = quantity
        cmd.Parameters.AddWithValue("@Dept", OleDbType.VarChar).Value = department
        cmd.Parameters.AddWithValue("@Date", OleDbType.Date).Value = Odate
        cmd.Parameters.AddWithValue("@To", OleDbType.VarChar).Value = Oto
        cmd.Parameters.AddWithValue("@From", OleDbType.VarChar).Value = Ofrom
        cmd.Parameters.AddWithValue("@GatePassType", OleDbType.VarChar).Value = GatePassType
        If GtePssType.SelectedItem = "NRGP" Then
            cmd.Parameters.AddWithValue("@ReturnDate", DBNull.Value)
        ElseIf GtePssType.SelectedItem = "RGP" Then
            cmd.Parameters.AddWithValue("@ReturnDate", OleDbType.Date).Value = ReturnDate
        End If
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Data inserted successfully.")
        GtPss.Clear()
        Mtrl.Clear()
        Qty.Clear()
        Dpt.Clear()
        Dte.Value = DateTime.Now()
        Totext.Clear()
        Fromtxt.Clear()
        GtePssType.Text = ""
        RtrnDte.Value = DateTime.Now()

    End Sub

    Private Function Datapresent(GatePassNo As Integer) As Boolean
        Dim Result As Boolean = False
        conn.Open()
            Dim query As String = "SELECT * FROM OUTWARD_FORM WHERE [GATE PASS NO] = @GatePassNo"
        Using command As New OleDbCommand(query, conn)
            command.Parameters.AddWithValue("@GatePassNo", GatePassNo)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Result = True
            End If
        End Using
        Return Result
    End Function

    Private Sub BtnDlt_Click(sender As Object, e As EventArgs) Handles BtnDlt.Click
        Dim GatePassNo As Integer = GtPss.Text
        If Datapresent(GatePassNo) Then
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
            Else
                MessageBox.Show("Data Not Deleted")
            End If
        Else
            MessageBox.Show("Gata Pass Number Not Found!")
        End If


    End Sub

    Private Sub Btnupdt_Click(sender As Object, e As EventArgs) Handles Btnupdt.Click
        Dim GatePassNo As Integer = GtPss.Text
        If Datapresent(GatePassNo) Then
            If MessageBox.Show("Are you sure you want to Update this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    conn.Open()
                    cmd = conn.CreateCommand()
                    cmd.CommandType = CommandType.Text

                    Dim updateClauses As New List(Of String)

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

                    If Not String.IsNullOrEmpty(Dte.Value) Then
                        updateClauses.Add("[DATE] = '" & Dte.Value & "'")
                    End If


                    If Not String.IsNullOrEmpty(Totext.Text) Then
                        updateClauses.Add("[TO] = '" & Totext.Text & "'")
                    End If

                    If Not String.IsNullOrEmpty(Fromtxt.Text) Then
                        updateClauses.Add("[FROM] = '" & Fromtxt.Text & "'")
                    End If

                    If Not String.IsNullOrEmpty(GtePssType.SelectedItem) Then
                        updateClauses.Add("[GATE PASS TYPE] = '" & GtePssType.SelectedItem & "'")
                    End If

                    If Not String.IsNullOrEmpty(RtrnDte.Value) Then
                        updateClauses.Add("[RETURN DATE] = '" & RtrnDte.Value & "'")
                    End If

                    Dim updateClause As String = String.Join(", ", updateClauses)
                    If updateClause <> "" Then
                        cmd.CommandText = "UPDATE OUTWARD_FORM SET " & updateClause & " WHERE [GATE PASS NO] = " & GtPss.Text & ""
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Data updated successfully.")
                        GtPss.Clear()
                        Mtrl.Clear()
                        Qty.Clear()
                        Dpt.Clear()
                        Dte.Value = DateTime.Now()
                        Totext.Clear()
                        Fromtxt.Clear()
                        GtePssType.Text = ""
                        RtrnDte.Value = DateTime.Now()
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
        Else
            MessageBox.Show("Gata Pass Number Not Found!")
        End If

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub GtPss_TextChanged(sender As Object, e As EventArgs) Handles GtPss.TextChanged

    End Sub

    Private Sub Mtrl_TextChanged(sender As Object, e As EventArgs) Handles Mtrl.TextChanged

    End Sub

    Private Sub Qty_TextChanged(sender As Object, e As EventArgs) Handles Qty.TextChanged

    End Sub

    Private Sub Dpt_TextChanged(sender As Object, e As EventArgs) Handles Dpt.TextChanged

    End Sub

    Private Sub Totext_TextChanged(sender As Object, e As EventArgs) Handles Totext.TextChanged

    End Sub

    Private Sub Fromtxt_TextChanged(sender As Object, e As EventArgs) Handles Fromtxt.TextChanged

    End Sub

    Private Sub Dte_ValueChanged(sender As Object, e As EventArgs) Handles Dte.ValueChanged

    End Sub

    Private Sub RtrnDte_ValueChanged(sender As Object, e As EventArgs) Handles RtrnDte.ValueChanged

    End Sub

    Private Sub GtePssType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GtePssType.SelectedIndexChanged
        If GtePssType.SelectedItem = "NRGP" Then
            RtrnDte.Hide()
            Label10.Hide()
        ElseIf GtePssType.SelectedItem = "RGP" Then
            RtrnDte.Show()
            Label10.Show()
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
