
Imports System.Windows.Forms

Public Class HOMEPAGE_FOR_SECURITY

    Private currentOption As Integer = 1

    Private Sub HOMEPAGE_FOR_SECURITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Visit_Click(sender As Object, e As EventArgs) Handles Visit.Click
        Dim newForm As New VISITORS With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub Panelmenu_Paint(sender As Object, e As PaintEventArgs) Handles Panelmenu.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint



    End Sub

    Private Sub InwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InwardToolStripMenuItem.Click
        Dim newForm As New Inward With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub OutwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutwardToolStripMenuItem.Click
 Dim newForm As New Outward With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }

        Panel3.Controls.Clear()
        Panel3.Controls.Add(outwardform)

        outwardform.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Login()
        newForm.Show()
        Me.Hide()
    End Sub

    Private Sub Cour_Click(sender As Object, e As EventArgs) Handles Cour.Click
        Dim newForm As New Courier With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub Lstfnd_Click(sender As Object, e As EventArgs) Handles Lstfnd.Click
        Dim newForm As New Lost_Found With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim profileform As New ProfilePage With {
            .TopLevel = False,
            .Size = Panel3.ClientSize
        }


        Panel3.Controls.Clear()
        Panel3.Controls.Add(profileform)
        profileform.Show()
    End Sub
End Class

