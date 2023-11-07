Public Class Form1

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lgn_Click(sender As Object, e As EventArgs) Handles Lgn.Click
        Dim SecondForm As New Form4
        SecondForm.Show()
    End Sub



    Private Sub INWARDToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles INWARDToolStripMenuItem.Click

        Dim SecondForm As New Inward

        SecondForm.Show()
    End Sub

    Private Sub RGPNRGPToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RGPNRGPToolStripMenuItem.Click
        Dim SecondForm As New Outward

        SecondForm.Show()
    End Sub
End Class
