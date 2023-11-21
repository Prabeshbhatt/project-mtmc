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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        RegNo = New TextBox()
        pass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        RegisterLink = New LinkLabel()
        RstPW = New LinkLabel()
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
        Label1.Location = New Point(61, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 46)
        Label1.TabIndex = 3
        Label1.Text = "REG_NO"
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
        Button1.Location = New Point(214, 290)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RegisterLink
        ' 
        RegisterLink.AutoSize = True
        RegisterLink.Location = New Point(170, 356)
        RegisterLink.Name = "RegisterLink"
        RegisterLink.Size = New Size(196, 25)
        RegisterLink.TabIndex = 8
        RegisterLink.TabStop = True
        RegisterLink.Text = "Click To Create Account"
        ' 
        ' RstPW
        ' 
        RstPW.AutoSize = True
        RstPW.Location = New Point(165, 381)
        RstPW.Name = "RstPW"
        RstPW.Size = New Size(201, 25)
        RstPW.TabIndex = 9
        RstPW.TabStop = True
        RstPW.Text = "Forgot Password? Reset"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 450)
        Controls.Add(RstPW)
        Controls.Add(RegisterLink)
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
    Friend WithEvents RegisterLink As LinkLabel
    Friend WithEvents RstPW As LinkLabel
End Class
