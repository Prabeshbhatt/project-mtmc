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
        Login = New LinkLabel()
        FullName = New TextBox()
        Vrfy = New Button()
        RegNo = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Location = New Point(267, 323)
        Login.Name = "Login"
        Login.Size = New Size(332, 25)
        Login.TabIndex = 12
        Login.TabStop = True
        Login.Text = "Already have Account? Proceed to Login"
        ' 
        ' FullName
        ' 
        FullName.Location = New Point(386, 102)
        FullName.Name = "FullName"
        FullName.Size = New Size(241, 31)
        FullName.TabIndex = 11
        ' 
        ' Vrfy
        ' 
        Vrfy.Location = New Point(373, 257)
        Vrfy.Name = "Vrfy"
        Vrfy.Size = New Size(112, 34)
        Vrfy.TabIndex = 10
        Vrfy.Text = "Verify"
        Vrfy.UseVisualStyleBackColor = True
        ' 
        ' RegNo
        ' 
        RegNo.Location = New Point(386, 176)
        RegNo.Name = "RegNo"
        RegNo.Size = New Size(241, 31)
        RegNo.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 25)
        Label2.TabIndex = 8
        Label2.Text = "Registration Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(291, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 7
        Label1.Text = "Name"
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

    Friend WithEvents Login As LinkLabel
    Friend WithEvents FullName As TextBox
    Friend WithEvents Vrfy As Button
    Friend WithEvents RegNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
