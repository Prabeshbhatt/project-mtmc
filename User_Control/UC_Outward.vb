Imports System.Data.OleDb
Imports System.DirectoryServices.ActiveDirectory
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Configuration
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

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
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\MTMC PROJECT\DATABASES\OutwardDB.accdb"
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
        Dim osender As String = Sendr.Text
        Dim prpose As String = Purpose.Text
        Dim vehicle As String = Vhcle.Text
        Dim driver As String = Drivr.Text
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        If GtePssType.SelectedItem.ToString() = "NRGP" Then
            cmd.CommandText = "INSERT INTO NRGP_Outward ([GATE PASS TYPE], [GATE PASS NO], [DATE], [DEPT], [FROM],  [TO], [MATERIAL], [QUANTITY],  [SENDER'S NAME], [PURPOSE], [VEHICLE NUMBER], [DRIVER'S NAME]) 
            VALUES (@GatePassType,@GatePassNo,@Date,@Dept,@From,@To,@Material,@Qty,@Sender,@Purpose,@Vehicle,@Driver)"
            cmd.Parameters.AddWithValue("@GatePassType", OleDbType.VarChar).Value = GatePassType
            cmd.Parameters.AddWithValue("@GatePassNo", OleDbType.Integer).Value = GatePassNo
            cmd.Parameters.AddWithValue("@Date", OleDbType.Date).Value = Odate
            cmd.Parameters.AddWithValue("@Dept", OleDbType.VarChar).Value = department
            cmd.Parameters.AddWithValue("@From", OleDbType.VarChar).Value = Ofrom
            cmd.Parameters.AddWithValue("@To", OleDbType.VarChar).Value = Oto
            cmd.Parameters.AddWithValue("@Material", OleDbType.VarChar).Value = material
            cmd.Parameters.AddWithValue("@Qty", OleDbType.Integer).Value = quantity
            cmd.Parameters.AddWithValue("@Sender", OleDbType.VarChar).Value = osender
            cmd.Parameters.AddWithValue("@Purpose", OleDbType.VarChar).Value = prpose
            cmd.Parameters.AddWithValue("@Vehicle", OleDbType.VarChar).Value = vehicle
            cmd.Parameters.AddWithValue("@Driver", OleDbType.VarChar).Value = driver
            cmd.ExecuteNonQuery()
            conn.Close()
        ElseIf GtePssType.SelectedItem.ToString() = "RGP" Then
            cmd.CommandText = "INSERT INTO OUTWARD_FORM ([GATE PASS TYPE], [GATE PASS NO], [DATE], [DEPT], [FROM],  [TO], [MATERIAL], [QUANTITY],  [SENDER'S NAME], [RETURN DATE], [PURPOSE], [VEHICLE], [DRIVER'S NAME]) 
            VALUES (@GatePassType,@GatePassNo,@Date,@Dept,@From,@To,@Material,@Qty,@Sender,@ReturnDate,@Purpose,@Vehicle,@Driver)"
            cmd.Parameters.AddWithValue("@GatePassType", OleDbType.VarChar).Value = GatePassType
            cmd.Parameters.AddWithValue("@GatePassNo", OleDbType.Integer).Value = GatePassNo
            cmd.Parameters.AddWithValue("@Date", OleDbType.Date).Value = Odate
            cmd.Parameters.AddWithValue("@Dept", OleDbType.VarChar).Value = department
            cmd.Parameters.AddWithValue("@From", OleDbType.VarChar).Value = Ofrom
            cmd.Parameters.AddWithValue("@To", OleDbType.VarChar).Value = Oto
            cmd.Parameters.AddWithValue("@Material", OleDbType.VarChar).Value = material
            cmd.Parameters.AddWithValue("@Qty", OleDbType.Integer).Value = quantity
            cmd.Parameters.AddWithValue("@Sender", OleDbType.VarChar).Value = osender
            cmd.Parameters.AddWithValue("@ReturnDate", OleDbType.Date).Value = ReturnDate
            cmd.Parameters.AddWithValue("@Purpose", OleDbType.VarChar).Value = prpose
            cmd.Parameters.AddWithValue("@Vehicle", OleDbType.VarChar).Value = vehicle
            cmd.Parameters.AddWithValue("@Driver", OleDbType.VarChar).Value = driver
            cmd.ExecuteNonQuery()
            conn.Close()
        End If
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

    Private Sub GtePssType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GtePssType.SelectedIndexChanged
        If GtePssType.SelectedItem.ToString() = "NRGP" Then
            RtrnDte.Hide()
            Label10.Hide()
        ElseIf GtePssType.SelectedItem.ToString() = "RGP" Then
            RtrnDte.Show()
            Label10.Show()
        End If
    End Sub

    Private Sub Fromtxt_TextChanged(sender As Object, e As EventArgs) Handles Fromtxt.TextChanged

    End Sub

    Private Sub DteLbl_Click(sender As Object, e As EventArgs) Handles DteLbl.Click

    End Sub

    Private Sub From_Click(sender As Object, e As EventArgs) Handles From.Click

    End Sub

    Private Sub GtPss_TextChanged(sender As Object, e As EventArgs) Handles GtPss.TextChanged

    End Sub

    Private Sub Dpt_TextChanged(sender As Object, e As EventArgs) Handles Dpt.TextChanged

    End Sub

    Private Sub Dte_ValueChanged(sender As Object, e As EventArgs) Handles Dte.ValueChanged

    End Sub

    Private Sub Totext_TextChanged(sender As Object, e As EventArgs) Handles Totext.TextChanged

    End Sub

    Private Sub Mtrl_TextChanged(sender As Object, e As EventArgs) Handles Mtrl.TextChanged

    End Sub

    Private Sub Qtty_Click(sender As Object, e As EventArgs) Handles Qtty.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Purpose_TextChanged(sender As Object, e As EventArgs) Handles Purpose.TextChanged

    End Sub

    Private Sub Vhcle_TextChanged(sender As Object, e As EventArgs) Handles Vhcle.TextChanged

    End Sub

    Private Sub Drivr_TextChanged(sender As Object, e As EventArgs) Handles Drivr.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Sendr_TextChanged(sender As Object, e As EventArgs) Handles Sendr.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub UC_Outward_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
