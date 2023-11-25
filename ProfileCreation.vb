Imports System.Data.OleDb
Imports System.IO
Imports System.Configuration
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class ProfileCreation
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap


    Dim password As String = ""
    Private Sub CompleteRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ""
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = LName.Text
        Dim gndr As String = ComboGender.SelectedItem.ToString()
        Dim number As String = PhoneNo.Text
        Dim email As String = Eml.Text
        Dim regNo As String = LReg.Text
        Dim password As String = PW.Text
        Dim confirmPassword As String = Cnfrm.Text
        Dim age As Integer = If(Integer.TryParse(LAge.Text, Nothing), Integer.Parse(LAge.Text), 0)
        Dim height As Double = Hght.Text
        Dim weight As Double = Wght.Text
        Dim address As String = Adrss.Text
        Dim rank As String = LRank.SelectedItem.ToString()
        Dim recruitmentDate As Date = Recruit.Value


        ' Check if the password and confirm password match
        If password = confirmPassword Then
            Try
                conn.Open()
                cmd = conn.CreateCommand()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO UserInfo (LName, Gender, ContactNo, Email, LRegNo, [Password], Age, Height, Weight, Address, Rank, RecruitmentDate, Profile) 
                              VALUES (@Name, @Gender, @ContactNo, @Email, @RegNo, @Password, @Age, @Height, @Weight, @Address, @Rank, @RecruitmentDate, @Profile)"

                ' Explicitly add parameters with correct data types
                cmd.Parameters.Add("@Name", OleDbType.VarChar).Value = name
                cmd.Parameters.Add("Gender", OleDbType.VarChar).Value = gndr
                cmd.Parameters.Add("@ContactNo", OleDbType.VarChar).Value = number
                cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = email
                cmd.Parameters.Add("@RegNo", OleDbType.VarChar).Value = regNo
                cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = password
                cmd.Parameters.Add("@Age", OleDbType.Integer).Value = age
                cmd.Parameters.Add("@Height", OleDbType.Double).Value = height
                cmd.Parameters.Add("@Weight", OleDbType.Double).Value = weight
                cmd.Parameters.Add("@Address", OleDbType.VarChar).Value = address
                cmd.Parameters.Add("@Rank", OleDbType.VarChar).Value = rank
                cmd.Parameters.Add("@RecruitmentDate", OleDbType.Date).Value = recruitmentDate

                ' Read the image file into a byte array and set the parameter value
                Dim profilePictureData As Byte() = File.ReadAllBytes(OpenFileDialog.FileName)
                cmd.Parameters.Add("@Profile", OleDbType.VarBinary).Value = profilePictureData

                cmd.ExecuteNonQuery()
                MessageBox.Show("User registered successfully.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Passwords do not match.")
            PW.Clear()
            Cnfrm.Clear()
        End If
    End Sub


    Private Sub ProfilePic_Click(sender As Object, e As EventArgs) Handles ProfilePic.Click

    End Sub

    Private Sub LName_TextChanged(sender As Object, e As EventArgs) Handles LName.TextChanged

    End Sub

    Private Sub LReg_TextChanged(sender As Object, e As EventArgs) Handles LReg.TextChanged

    End Sub

    Private Sub PW_TextChanged(sender As Object, e As EventArgs) Handles PW.TextChanged

    End Sub

    Private Sub Cnfrm_TextChanged(sender As Object, e As EventArgs) Handles Cnfrm.TextChanged

    End Sub

    Private Sub Age_TextChanged(sender As Object, e As EventArgs) Handles LAge.TextChanged

    End Sub

    Private Sub Rank_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Recruit_ValueChanged(sender As Object, e As EventArgs) Handles Recruit.ValueChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' Open a file dialog to choose a profile picture
        OpenFileDialog.Title = "Open Picture"
        OpenFileDialog.FileName = ".png"
        OpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        OpenFileDialog.ShowDialog()
        ProfilePic.Image = Image.FromFile(OpenFileDialog.FileName)
    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub LRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LRank.SelectedIndexChanged

    End Sub

    Private Sub Hght_TextChanged(sender As Object, e As EventArgs) Handles Hght.TextChanged

    End Sub

    Private Sub Wght_TextChanged(sender As Object, e As EventArgs) Handles Wght.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ComboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGender.SelectedIndexChanged

    End Sub

    Private Sub PhoneNo_TextChanged(sender As Object, e As EventArgs) Handles PhoneNo.TextChanged

    End Sub

    Private Sub Eml_TextChanged(sender As Object, e As EventArgs) Handles Eml.TextChanged

    End Sub
End Class