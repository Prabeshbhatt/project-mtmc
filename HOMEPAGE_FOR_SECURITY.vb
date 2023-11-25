
Imports System.Windows.Forms

Public Class HOMEPAGE_FOR_SECURITY

    Private currentOption As Integer = 1

    Private Sub HOMEPAGE_FOR_SECURITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub visit_Click(sender As Object, e As EventArgs) Handles visit.Click
        Dim newForm As New VISITORS()

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub Panelmenu_Paint(sender As Object, e As PaintEventArgs) Handles Panelmenu.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint



    End Sub

    Private Sub InwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InwardToolStripMenuItem.Click
        Dim newForm As New Inward()

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub OutwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutwardToolStripMenuItem.Click
        Dim newForm As New Outward()

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Login()


        newForm.Show()
    End Sub

    Private Sub cour_Click(sender As Object, e As EventArgs) Handles cour.Click
        Dim newForm As New Courier()

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub lstfnd_Click(sender As Object, e As EventArgs) Handles lstfnd.Click
        Dim newForm As New Lost_Found()

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim profileform As New ProfilePage
        profileform.TopLevel = False
        profileform.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(profileform)
        profileform.Show()
    End Sub
End Class

