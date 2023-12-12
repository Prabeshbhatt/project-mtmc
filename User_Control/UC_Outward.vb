Imports System.Data.OleDb

Public Class UC_Outward
    Private cmd As New OleDbCommand
    Private dt As New DataTable
    Private da As New OleDbDataAdapter(cmd)
    Private bitmap As Bitmap
    ' Event declarations for buttons
    Public Event SaveButtonClick As EventHandler
    Public Event DeleteButtonClick As EventHandler
    Public Event UpdateButtonClick As EventHandler

    ' Common database connection
    Private conn As New OleDbConnection

    ' Constructor
    Public Sub New()
        ' Initialize the user control
        InitializeComponent()

        ' Additional initialization if needed
        conn.ConnectionString = ""
    End Sub

    ' Handle the Save button click
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
        RaiseEvent SaveButtonClick(Me, EventArgs.Empty)
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
    ' Handle the Delete button click
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


                End Try
            Else
                MessageBox.Show("Data Not Deleted")
            End If
        Else
            MessageBox.Show("Gata Pass Number Not Found!")
        End If
        RaiseEvent DeleteButtonClick(Me, EventArgs.Empty)

        ' Close the database connection
        conn.Close()
    End Sub

    ' Handle the Update button click
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
                End Try
            Else MessageBox.Show("Data Update Rejected")
            End If
        Else
            MessageBox.Show("Gata Pass Number Not Found!")
        End If
        RaiseEvent UpdateButtonClick(Me, EventArgs.Empty)

        ' Close the database connection
        conn.Close()
    End Sub

    Private Sub GtPssNo_Click(sender As Object, e As EventArgs) Handles GtPssNo.Click
        If GtePssType.SelectedItem = "NRGP" Then
            RtrnDte.Hide()
            Label10.Hide()
        ElseIf GtePssType.SelectedItem = "RGP" Then
            RtrnDte.Show()
            Label10.Show()
        End If
    End Sub

    Private Sub GtePssType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GtePssType.SelectedIndexChanged

    End Sub

    Private Sub UC_Outward_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
