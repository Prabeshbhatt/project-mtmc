Imports System.Configuration
Imports System.Data.OleDb
Public Class Register
    Dim connectionstring As String = ""


    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub RegNo_TextChanged(sender As Object, e As EventArgs) Handles RegNo.TextChanged

    End Sub

    Private Sub Vrfy_Click(sender As Object, e As EventArgs) Handles Vrfy.Click
        Dim AuthRegNo As String = RegNo.Text.Trim()
        Dim AuthName As String = FullName.Text.Trim()
        If AlreadyRegistered(AuthName, AuthRegNo) Then
            MessageBox.Show("User Already Registered")
        Else
            If Authenticateuser(AuthName, AuthRegNo) Then
                MessageBox.Show("Verification Successful. Proceed to Complete your Registration")
                Dim nextform As New ProfileCreation
                nextform.Show()
                Me.Hide()

            Else
                MessageBox.Show("Name or Reg ID not Recognized")
            End If
        End If

    End Sub






    Private Function Authenticateuser(AuthName As String, AuthRegNo As String) As Boolean
        Dim Result As Boolean = False
        Using connection As New OleDbConnection(connectionstring)
            connection.Open()
            Dim query As String = "SELECT * FROM DB WHERE EName = @FullName AND ERegNo = @RegNo"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@FullName", AuthName)
                command.Parameters.AddWithValue("@RegNo", AuthRegNo)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    Result = True
                End If
            End Using
        End Using
        Return Result
    End Function

    Private Function AlreadyRegistered(AuthName As String, AuthRegNo As String) As Boolean
        Dim Result As Boolean = False
        Using connection As New OleDbConnection(connectionstring)
            connection.Open()
            Dim query As String = "SELECT * FROM UserInfo WHERE LName = @FullName AND LRegNo = @RegNo"
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@FullName", AuthName)
                command.Parameters.AddWithValue("@RegNo", AuthRegNo)
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

    Private Sub Login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Login.LinkClicked
        Dim LoginPage As New Login
        LoginPage.Show()
        Me.Hide()



    End Sub
End Class

