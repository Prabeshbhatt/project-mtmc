Public Class Uc_home


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Scroll the content
        AutoScroll()
    End Sub

    Private Shadows Sub AutoScroll()
        ' Adjust the amount of scroll as needed
        ' For example, you can change the 'VerticalScroll.Value' increment
        ' based on the speed at which you want to scroll

        ' Scroll down by 1 pixel
        Me.VerticalScroll.Value += 1
        If Me.VerticalScroll.Value >= Me.VerticalScroll.Maximum - Me.ClientSize.Height Then


            ' Reset the scroll to the top when it reaches the bottom
            Me.VerticalScroll.Value = 0
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        Timer1.Start()
    End Sub
End Class
