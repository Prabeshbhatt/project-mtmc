Public Class Form1
    Private Sub RGPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RGPToolStripMenuItem.Click
        Dim SecondForm As New Outward

        SecondForm.Show()
    End Sub


    Private Sub RGPToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RGPToolStripMenuItem1.Click
        Dim SecondForm As New Form3

        SecondForm.Show()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Lgn_Click(sender As Object, e As EventArgs) Handles Lgn.Click
        Dim SecondForm As New Form4
        SecondForm.Show()
    End Sub

    Private Sub OutwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutwardToolStripMenuItem.Click

    End Sub
End Class
