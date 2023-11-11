<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Psswrd = New TextBox()
        Cnfrm = New Button()
        CnfrmPW = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Psswrd
        ' 
        Psswrd.Location = New Point(236, 94)
        Psswrd.Name = "Psswrd"
        Psswrd.PasswordChar = "*"c
        Psswrd.Size = New Size(327, 31)
        Psswrd.TabIndex = 0
        Psswrd.TextAlign = HorizontalAlignment.Center
        ' 
        ' Cnfrm
        ' 
        Cnfrm.Location = New Point(330, 200)
        Cnfrm.Name = "Cnfrm"
        Cnfrm.Size = New Size(112, 34)
        Cnfrm.TabIndex = 1
        Cnfrm.Text = "Confirm"
        Cnfrm.UseVisualStyleBackColor = True
        ' 
        ' CnfrmPW
        ' 
        CnfrmPW.Location = New Point(236, 147)
        CnfrmPW.Name = "CnfrmPW"
        CnfrmPW.PasswordChar = "*"c
        CnfrmPW.Size = New Size(327, 31)
        CnfrmPW.TabIndex = 2
        CnfrmPW.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 25)
        Label1.TabIndex = 3
        Label1.Text = "Set Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 25)
        Label2.TabIndex = 4
        Label2.Text = "Repeat Password"
        ' 
        ' Confirm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CnfrmPW)
        Controls.Add(Cnfrm)
        Controls.Add(Psswrd)
        Name = "Confirm"
        Text = "Confirm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Psswrd As TextBox
    Friend WithEvents Cnfrm As Button
    Friend WithEvents CnfrmPW As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
