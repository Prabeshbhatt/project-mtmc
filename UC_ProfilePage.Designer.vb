<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ProfilePage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        LinkLabel1 = New LinkLabel()
        Label14 = New Label()
        Label13 = New Label()
        ERank = New TextBox()
        EDate = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label12 = New Label()
        EReg = New TextBox()
        EGender = New TextBox()
        Label6 = New Label()
        Eml = New TextBox()
        Label5 = New Label()
        PhoneNo = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Wght = New TextBox()
        Label9 = New Label()
        Hght = New TextBox()
        Label10 = New Label()
        Adrss = New TextBox()
        Label11 = New Label()
        LAge = New TextBox()
        Display = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        EName = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Guna2Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2Panel1.BackColor = Color.Lavender
        Guna2Panel1.BorderColor = SystemColors.Control
        Guna2Panel1.Controls.Add(LinkLabel1)
        Guna2Panel1.Controls.Add(Label14)
        Guna2Panel1.Controls.Add(Label13)
        Guna2Panel1.Controls.Add(ERank)
        Guna2Panel1.Controls.Add(EDate)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(Label4)
        Guna2Panel1.Controls.Add(Label12)
        Guna2Panel1.Controls.Add(EReg)
        Guna2Panel1.Controls.Add(EGender)
        Guna2Panel1.Controls.Add(Label6)
        Guna2Panel1.Controls.Add(Eml)
        Guna2Panel1.Controls.Add(Label5)
        Guna2Panel1.Controls.Add(PhoneNo)
        Guna2Panel1.Controls.Add(Label7)
        Guna2Panel1.Controls.Add(Label8)
        Guna2Panel1.Controls.Add(Wght)
        Guna2Panel1.Controls.Add(Label9)
        Guna2Panel1.Controls.Add(Hght)
        Guna2Panel1.Controls.Add(Label10)
        Guna2Panel1.Controls.Add(Adrss)
        Guna2Panel1.Controls.Add(Label11)
        Guna2Panel1.Controls.Add(LAge)
        Guna2Panel1.Controls.Add(Display)
        Guna2Panel1.Controls.Add(PictureBox1)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(EName)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(TextBox1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Panel1.Location = New Point(58, 22)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(1259, 814)
        Guna2Panel1.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.None
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(740, 33)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(502, 32)
        LinkLabel1.TabIndex = 95
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Account Not Found? Click Here to Register"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.Font = New Font("Bernard MT Condensed", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label14.Location = New Point(267, 421)
        Label14.Name = "Label14"
        Label14.Size = New Size(259, 31)
        Label14.TabIndex = 94
        Label14.Text = "Employee Information"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.Font = New Font("Bernard MT Condensed", 14F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label13.Location = New Point(786, 132)
        Label13.Name = "Label13"
        Label13.Size = New Size(297, 63)
        Label13.TabIndex = 93
        Label13.Text = "Personal Information"
        ' 
        ' ERank
        ' 
        ERank.Anchor = AnchorStyles.None
        ERank.BackColor = Color.Lavender
        ERank.BorderStyle = BorderStyle.None
        ERank.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        ERank.Location = New Point(267, 631)
        ERank.Multiline = True
        ERank.Name = "ERank"
        ERank.ReadOnly = True
        ERank.Size = New Size(350, 40)
        ERank.TabIndex = 92
        ' 
        ' EDate
        ' 
        EDate.Anchor = AnchorStyles.None
        EDate.BackColor = Color.Lavender
        EDate.BorderStyle = BorderStyle.None
        EDate.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        EDate.Location = New Point(267, 557)
        EDate.Multiline = True
        EDate.Name = "EDate"
        EDate.ReadOnly = True
        EDate.Size = New Size(350, 40)
        EDate.TabIndex = 91
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(47, 567)
        Label3.Name = "Label3"
        Label3.Size = New Size(214, 32)
        Label3.TabIndex = 90
        Label3.Text = "Recruitment Date"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(190, 639)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 32)
        Label4.TabIndex = 89
        Label4.Text = "Rank"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(67, 489)
        Label12.Name = "Label12"
        Label12.Size = New Size(194, 32)
        Label12.TabIndex = 88
        Label12.Text = "Registration No"
        ' 
        ' EReg
        ' 
        EReg.Anchor = AnchorStyles.None
        EReg.BackColor = Color.Lavender
        EReg.BorderStyle = BorderStyle.None
        EReg.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        EReg.Location = New Point(267, 481)
        EReg.Multiline = True
        EReg.Name = "EReg"
        EReg.ReadOnly = True
        EReg.Size = New Size(350, 40)
        EReg.TabIndex = 87
        ' 
        ' EGender
        ' 
        EGender.Anchor = AnchorStyles.None
        EGender.BackColor = Color.Lavender
        EGender.BorderStyle = BorderStyle.None
        EGender.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EGender.Location = New Point(786, 265)
        EGender.Multiline = True
        EGender.Name = "EGender"
        EGender.ReadOnly = True
        EGender.Size = New Size(350, 40)
        EGender.TabIndex = 86
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(704, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 32)
        Label6.TabIndex = 85
        Label6.Text = "Email"
        ' 
        ' Eml
        ' 
        Eml.Anchor = AnchorStyles.None
        Eml.BackColor = Color.Lavender
        Eml.BorderStyle = BorderStyle.None
        Eml.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Eml.Location = New Point(786, 409)
        Eml.Multiline = True
        Eml.Name = "Eml"
        Eml.ReadOnly = True
        Eml.Size = New Size(350, 40)
        Eml.TabIndex = 84
        Eml.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(637, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 32)
        Label5.TabIndex = 83
        Label5.Text = "Contact No"
        ' 
        ' PhoneNo
        ' 
        PhoneNo.Anchor = AnchorStyles.None
        PhoneNo.BackColor = Color.Lavender
        PhoneNo.BorderStyle = BorderStyle.None
        PhoneNo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneNo.Location = New Point(786, 338)
        PhoneNo.Multiline = True
        PhoneNo.Name = "PhoneNo"
        PhoneNo.ReadOnly = True
        PhoneNo.Size = New Size(350, 40)
        PhoneNo.TabIndex = 82
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(683, 273)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 32)
        Label7.TabIndex = 81
        Label7.Text = "Gender"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(935, 565)
        Label8.Name = "Label8"
        Label8.Size = New Size(95, 32)
        Label8.TabIndex = 80
        Label8.Text = "Weight"
        ' 
        ' Wght
        ' 
        Wght.Anchor = AnchorStyles.None
        Wght.BackColor = Color.Lavender
        Wght.BorderStyle = BorderStyle.None
        Wght.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Wght.Location = New Point(1036, 557)
        Wght.Multiline = True
        Wght.Name = "Wght"
        Wght.ReadOnly = True
        Wght.Size = New Size(100, 40)
        Wght.TabIndex = 79
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(690, 565)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 32)
        Label9.TabIndex = 78
        Label9.Text = "Height"
        ' 
        ' Hght
        ' 
        Hght.Anchor = AnchorStyles.None
        Hght.BackColor = Color.Lavender
        Hght.BorderStyle = BorderStyle.None
        Hght.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Hght.Location = New Point(786, 557)
        Hght.Multiline = True
        Hght.Name = "Hght"
        Hght.ReadOnly = True
        Hght.Size = New Size(100, 40)
        Hght.TabIndex = 77
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(674, 639)
        Label10.Name = "Label10"
        Label10.Size = New Size(106, 32)
        Label10.TabIndex = 76
        Label10.Text = "Address"
        ' 
        ' Adrss
        ' 
        Adrss.Anchor = AnchorStyles.None
        Adrss.BackColor = Color.Lavender
        Adrss.BorderStyle = BorderStyle.None
        Adrss.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Adrss.Location = New Point(786, 631)
        Adrss.Multiline = True
        Adrss.Name = "Adrss"
        Adrss.ReadOnly = True
        Adrss.Size = New Size(348, 94)
        Adrss.TabIndex = 75
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(721, 489)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 32)
        Label11.TabIndex = 74
        Label11.Text = "Age"
        ' 
        ' LAge
        ' 
        LAge.Anchor = AnchorStyles.None
        LAge.BackColor = Color.Lavender
        LAge.BorderStyle = BorderStyle.None
        LAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LAge.Location = New Point(786, 481)
        LAge.Multiline = True
        LAge.Name = "LAge"
        LAge.ReadOnly = True
        LAge.Size = New Size(350, 40)
        LAge.TabIndex = 73
        ' 
        ' Display
        ' 
        Display.Anchor = AnchorStyles.None
        Display.Location = New Point(481, 24)
        Display.Name = "Display"
        Display.Size = New Size(114, 41)
        Display.TabIndex = 72
        Display.Text = "Show Profile"
        Display.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.LightCyan
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(212, 132)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(284, 251)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 71
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(699, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 70
        Label2.Text = "Name"
        ' 
        ' EName
        ' 
        EName.Anchor = AnchorStyles.None
        EName.BackColor = Color.Lavender
        EName.BorderStyle = BorderStyle.None
        EName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EName.Location = New Point(786, 198)
        EName.Multiline = True
        EName.Name = "EName"
        EName.ReadOnly = True
        EName.Size = New Size(350, 40)
        EName.TabIndex = 69
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 32)
        Label1.TabIndex = 68
        Label1.Text = "Registration No"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Location = New Point(228, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(229, 39)
        TextBox1.TabIndex = 67
        ' 
        ' UC_ProfilePage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        Controls.Add(Guna2Panel1)
        Name = "UC_ProfilePage"
        Size = New Size(1374, 864)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ERank As TextBox
    Friend WithEvents EDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EReg As TextBox
    Friend WithEvents EGender As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Eml As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Wght As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Hght As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Adrss As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LAge As TextBox
    Friend WithEvents Display As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
