Imports System.Data.OleDb

Public Class UC_ProfilePage
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub UC_ProfilePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\MTMC PROJECT\DATABASES\Register Verification.accdb"
    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        Dim regNo As String = TextBox1.Text

        Try
            conn.Open()

            ' Execute a query to retrieve profile information based on registration number
            cmd.Connection = conn
            cmd.CommandText = "SELECT LName, Gender, ContactNo, Email, LRegNo, Age, Height, Weight, Address, Rank, RecruitmentDate, Profile FROM UserInfo WHERE LRegNo = @RegNo"
            cmd.Parameters.AddWithValue("@RegNo", regNo)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                ' Display profile information
                EName.Text = dr("LName").ToString()
                EGender.Text = dr("Gender").ToString()
                PhoneNo.Text = dr("ContactNo").ToString()
                Eml.Text = dr("Email").ToString()
                EReg.Text = dr("LRegNo").ToString()
                LAge.Text = dr("Age").ToString()
                Hght.Text = dr("Height").ToString()
                Wght.Text = dr("Weight").ToString()
                Adrss.Text = dr("Address").ToString()
                ERank.Text = dr("Rank").ToString()
                EDate.Text = dr("RecruitmentDate").ToString()
                ' Display profile picture
                Dim imageData As Byte() = DirectCast(dr("Profile"), Byte())
                Dim ms As New System.IO.MemoryStream(imageData)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                MessageBox.Show("Profile not found for the entered registration number.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim SecondForm As New Register
        SecondForm.Show()
        Me.Hide()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub EName_TextChanged(sender As Object, e As EventArgs) Handles EName.TextChanged

    End Sub

    Private Sub EGender_TextChanged(sender As Object, e As EventArgs) Handles EGender.TextChanged

    End Sub

    Private Sub PhoneNo_TextChanged(sender As Object, e As EventArgs) Handles PhoneNo.TextChanged

    End Sub

    Private Sub Eml_TextChanged(sender As Object, e As EventArgs) Handles Eml.TextChanged

    End Sub

    Private Sub LAge_TextChanged(sender As Object, e As EventArgs) Handles LAge.TextChanged

    End Sub

    Private Sub Hght_TextChanged(sender As Object, e As EventArgs) Handles Hght.TextChanged

    End Sub

    Private Sub Wght_TextChanged(sender As Object, e As EventArgs) Handles Wght.TextChanged

    End Sub

    Private Sub Adrss_TextChanged(sender As Object, e As EventArgs) Handles Adrss.TextChanged

    End Sub

    Private Sub EReg_TextChanged(sender As Object, e As EventArgs) Handles EReg.TextChanged

    End Sub

    Private Sub EDate_TextChanged(sender As Object, e As EventArgs) Handles EDate.TextChanged

    End Sub

    Private Sub ERank_TextChanged(sender As Object, e As EventArgs) Handles ERank.TextChanged

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
