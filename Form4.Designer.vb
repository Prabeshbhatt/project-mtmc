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
        RegNo = New TextBox()
        pass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
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
        ' RegNo
        ' 
        RegNo.Location = New Point(201, 160)
        RegNo.Multiline = True
        RegNo.Name = "RegNo"
        RegNo.Size = New Size(261, 46)
        RegNo.TabIndex = 1
        ' 
        ' pass
        ' 
        pass.Location = New Point(201, 228)
        pass.Multiline = True
        pass.Name = "pass"
        pass.Size = New Size(261, 46)
        pass.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(50, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 46)
        Label1.TabIndex = 3
        Label1.Text = "Register No"
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
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(350, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(222, 307)
        Button2.Name = "Button2"
        Button2.Size = New Size(122, 34)
        Button2.TabIndex = 6
        Button2.Text = "SIGN_UP"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(222, 359)
        Button3.Name = "Button3"
        Button3.Size = New Size(240, 34)
        Button3.TabIndex = 7
        Button3.Text = "RESET_PASSWORD"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pass)
        Controls.Add(RegNo)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RegNo As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
