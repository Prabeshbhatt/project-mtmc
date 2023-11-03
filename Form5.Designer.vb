<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        Button3 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        pass = New TextBox()
        usrid = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(292, 313)
        Button3.Name = "Button3"
        Button3.Size = New Size(240, 34)
        Button3.TabIndex = 15
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(420, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 13
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(120, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 46)
        Label2.TabIndex = 12
        Label2.Text = "PASSWORD"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(131, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 46)
        Label1.TabIndex = 11
        Label1.Text = "USER_ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pass
        ' 
        pass.Location = New Point(271, 244)
        pass.Multiline = True
        pass.Name = "pass"
        pass.Size = New Size(261, 46)
        pass.TabIndex = 10
        ' 
        ' usrid
        ' 
        usrid.Location = New Point(271, 176)
        usrid.Multiline = True
        usrid.Name = "usrid"
        usrid.Size = New Size(261, 46)
        usrid.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(239, 43)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(320, 104)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 450)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pass)
        Controls.Add(usrid)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "SIGN_UP"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents usrid As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
