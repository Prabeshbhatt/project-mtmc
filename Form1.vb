Public Class Form1
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
End Class