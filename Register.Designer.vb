<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label1 = New Label()
        RegNo = New TextBox()
        Label2 = New Label()
        Vrfy = New Button()
        FullName = New TextBox()
        Login = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(264, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' RegNo
        ' 
        RegNo.Location = New Point(359, 171)
        RegNo.Name = "RegNo"
        RegNo.Size = New Size(241, 31)
        RegNo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 25)
        Label2.TabIndex = 2
        Label2.Text = "Registration Number"
        ' 
        ' Vrfy
        ' 
        Vrfy.Location = New Point(346, 252)
        Vrfy.Name = "Vrfy"
        Vrfy.Size = New Size(112, 34)
        Vrfy.TabIndex = 4
        Vrfy.Text = "Verify"
        Vrfy.UseVisualStyleBackColor = True
        ' 
        ' FullName
        ' 
        FullName.Location = New Point(359, 97)
        FullName.Name = "FullName"
        FullName.Size = New Size(241, 31)
        FullName.TabIndex = 5
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Location = New Point(240, 318)
        Login.Name = "Login"
        Login.Size = New Size(332, 25)
        Login.TabIndex = 6
        Login.TabStop = True
        Login.Text = "Already have Account? Proceed to Login"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Login)
        Controls.Add(FullName)
        Controls.Add(Vrfy)
        Controls.Add(RegNo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Register"
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RegNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Vrfy As Button
    Friend WithEvents FullName As TextBox
    Friend WithEvents Login As LinkLabel
End Class
