<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        usrid = New TextBox()
        Psswrd = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Login = New Button()
        SignUp = New Button()
        RstPW = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(103, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(320, 104)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' usrid
        ' 
        usrid.Location = New Point(201, 160)
        usrid.Multiline = True
        usrid.Name = "usrid"
        usrid.Size = New Size(261, 46)
        usrid.TabIndex = 1
        ' 
        ' Psswrd
        ' 
        Psswrd.Location = New Point(201, 228)
        Psswrd.Multiline = True
        Psswrd.Name = "Psswrd"
        Psswrd.Size = New Size(261, 46)
        Psswrd.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(61, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 46)
        Label1.TabIndex = 3
        Label1.Text = "USER_ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(50, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 46)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login
        ' 
        Login.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Login.Location = New Point(350, 307)
        Login.Name = "Login"
        Login.Size = New Size(112, 34)
        Login.TabIndex = 5
        Login.Text = "LOGIN"
        Login.UseVisualStyleBackColor = True
        ' 
        ' SignUp
        ' 
        SignUp.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        SignUp.Location = New Point(222, 307)
        SignUp.Name = "SignUp"
        SignUp.Size = New Size(122, 34)
        SignUp.TabIndex = 6
        SignUp.Text = "SIGN_UP"
        SignUp.UseVisualStyleBackColor = True
        ' 
        ' RstPW
        ' 
        RstPW.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        RstPW.Location = New Point(222, 359)
        RstPW.Name = "RstPW"
        RstPW.Size = New Size(240, 34)
        RstPW.TabIndex = 7
        RstPW.Text = "RESET_PASSWORD"
        RstPW.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 450)
        Controls.Add(RstPW)
        Controls.Add(SignUp)
        Controls.Add(Login)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Psswrd)
        Controls.Add(usrid)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usrid As TextBox
    Friend WithEvents Psswrd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Login As Button
    Friend WithEvents SignUp As Button
    Friend WithEvents RstPW As Button
End Class
