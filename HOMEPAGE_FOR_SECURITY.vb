
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

        newForm.TopLevel = False
        newForm.Size = Panel3.ClientSize


        Panel3.Controls.Clear()
        Panel3.Controls.Add(newForm)

        newForm.Show()
    End Sub
End Class

