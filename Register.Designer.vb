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
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Login = New LinkLabel()
        FullName = New TextBox()
        Vrfy = New Button()
        RegNo = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Login)
        Panel1.Controls.Add(FullName)
        Panel1.Controls.Add(Vrfy)
        Panel1.Controls.Add(RegNo)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 466)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(103, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(303, 21)
        Label4.TabIndex = 19
        Label4.Text = "Verify to prove you are a MTMC Employee"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(119, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(276, 38)
        Label3.TabIndex = 1
        Label3.Text = "AUTHENTICATION"
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Location = New Point(103, 383)
        Login.Name = "Login"
        Login.Size = New Size(332, 25)
        Login.TabIndex = 18
        Login.TabStop = True
        Login.Text = "Already have Account? Proceed to Login"
        ' 
        ' FullName
        ' 
        FullName.Location = New Point(230, 162)
        FullName.Name = "FullName"
        FullName.Size = New Size(241, 31)
        FullName.TabIndex = 17
        ' 
        ' Vrfy
        ' 
        Vrfy.Location = New Point(217, 317)
        Vrfy.Name = "Vrfy"
        Vrfy.Size = New Size(112, 34)
        Vrfy.TabIndex = 16
        Vrfy.Text = "Verify"
        Vrfy.UseVisualStyleBackColor = True
        ' 
        ' RegNo
        ' 
        RegNo.Location = New Point(230, 236)
        RegNo.Name = "RegNo"
        RegNo.Size = New Size(241, 31)
        RegNo.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 25)
        Label2.TabIndex = 14
        Label2.Text = "Registration Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(135, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 13
        Label1.Text = "Name"
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(523, 487)
        Controls.Add(Panel1)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Login As LinkLabel
    Friend WithEvents FullName As TextBox
    Friend WithEvents Vrfy As Button
    Friend WithEvents RegNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
