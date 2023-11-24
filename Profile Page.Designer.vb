<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilePage
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
        Display = New Button()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Display)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 527)
        Panel1.TabIndex = 0
        ' 
        ' Display
        ' 
        Display.Location = New Point(395, 78)
        Display.Name = "Display"
        Display.Size = New Size(112, 34)
        Display.TabIndex = 18
        Display.Text = "Show Profile"
        Display.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(351, 136)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(286, 477)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 25)
        Label4.TabIndex = 16
        Label4.Text = "Rank"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(286, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 25)
        Label3.TabIndex = 15
        Label3.Text = "Age"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(286, 357)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 14
        Label2.Text = "Name"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(364, 471)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(181, 31)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(364, 412)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(181, 31)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(364, 351)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 31)
        TextBox2.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(254, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 10
        Label1.Text = "Registration No"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(395, 20)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 9
        ' 
        ' ProfilePage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 527)
        Controls.Add(Panel1)
        Name = "ProfilePage"
        Text = "ProfilePage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Display As Button
End Class
