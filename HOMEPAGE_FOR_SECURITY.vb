
Public Class HOMEPAGE_FOR_SECURITY

    Private currentchildform As Form
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

    ' Handle the Resize event of the form
End Class

