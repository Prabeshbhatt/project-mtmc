Public Class FinalHomePage
    Private Sub AddUserControl(ByVal userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        Panel3.Controls.Clear()
        Panel3.Controls.Add(userControl)
        userControl.BringToFront()
    End Sub
    Private Sub OutwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutwardToolStripMenuItem.Click
        Dim uc As New UC_Outward()
        AddUserControl(uc)

    End Sub

    Private Sub MaterialMovementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialMovementToolStripMenuItem.Click

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim uc As New uc_lostandfound()
        AddUserControl(uc)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim uc As New Uc_courier()
        AddUserControl(uc)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim uc As New Uc_Visitors()
        AddUserControl(uc)
    End Sub

    Private Sub InwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InwardToolStripMenuItem.Click
        Dim uc As New Uc_Inward()
        AddUserControl(uc)
    End Sub

    Private Sub Button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim uc As New UC_ProfilePage()
        AddUserControl(uc)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class