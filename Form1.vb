Public Class Form1
    Private Sub RGPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RGPToolStripMenuItem.Click

    End Sub


    Private Sub RGPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RGPToolStripMenuItem1.Click
        Dim SecondForm As New Outward

        SecondForm.Show()
    End Sub




    Private Sub Lgn_Click(sender As Object, e As EventArgs) Handles Lgn.Click
        Dim SecondForm As New Form4
        SecondForm.Show()
    End Sub

    Private Sub OutwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUTWARDToolStripMenuItem.Click

    End Sub

    Private Sub INWARDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INWARDToolStripMenuItem.Click
        Dim SecondForm As New Inward

        SecondForm.Show()
    End Sub

    Private Sub RGPNRGPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RGPNRGPToolStripMenuItem.Click
        Dim SecondForm As New Outward

        SecondForm.Show()
    End Sub
End Class
