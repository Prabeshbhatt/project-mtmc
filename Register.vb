Imports System.Configuration
Imports System.Data.OleDb
Public Class Register
    Dim connectionstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\New folder\Register Verification.accdb;"
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub RegNo_TextChanged(sender As Object, e As EventArgs) Handles RegNo.TextChanged

    End Sub

    Private Sub Vrfy_Click(sender As Object, e As EventArgs) Handles Vrfy.Click
        Dim ERegNo As String = RegNo.Text.Trim()
        Dim EName As String = FullName.Text.Trim()

        If Authenticateuser(ERegNo) Then
            MessageBox.Show("Verification Successful. Proceed to Set your Password")

            Dim secondform As New Confirm
            secondform.Show()
        Else
            MessageBox.Show("Reg ID not Recognized")
        End If
    End Sub

    Private Function Authenticateuser(ERegNo As String) As Boolean
        Dim Result As Boolean = False
        Using connection As New OleDbConnection(connectionstring)
            connection.Open()
            Dim query As String = "SELECT * FROM DB WHERE ERegNo =@RegNo"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@RegNo", ERegNo)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    Result = True
                End If
            End Using
        End Using
        Return Result
    End Function

    Private Sub FullName_TextChanged(sender As Object, e As EventArgs) Handles FullName.TextChanged

    End Sub

End Class

