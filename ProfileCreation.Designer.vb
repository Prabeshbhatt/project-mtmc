<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileCreation
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
        Panel2 = New Panel()
        Label3 = New Label()
        Wght = New TextBox()
        Label2 = New Label()
        Hght = New TextBox()
        Label1 = New Label()
        Adrss = New TextBox()
        LRank = New ComboBox()
        Title = New Label()
        LinkLabel2 = New LinkLabel()
        ProfilePic = New PictureBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Recruit = New DateTimePicker()
        LName = New TextBox()
        LReg = New TextBox()
        LAge = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Cnfrm = New TextBox()
        Button1 = New Button()
        PW = New TextBox()
        OpenFileDialog = New OpenFileDialog()
        Label4 = New Label()
        Label5 = New Label()
        PhoneNo = New TextBox()
        Label6 = New Label()
        Eml = New TextBox()
        ComboGender = New ComboBox()
        Panel2.SuspendLayout()
        CType(ProfilePic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ComboGender)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Eml)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(PhoneNo)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Wght)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Hght)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Adrss)
        Panel2.Controls.Add(LRank)
        Panel2.Controls.Add(Title)
        Panel2.Controls.Add(LinkLabel2)
        Panel2.Controls.Add(ProfilePic)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Recruit)
        Panel2.Controls.Add(LName)
        Panel2.Controls.Add(LReg)
        Panel2.Controls.Add(LAge)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(Cnfrm)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(PW)
        Panel2.Location = New Point(25, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(954, 573)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(284, 366)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 25)
        Label3.TabIndex = 30
        Label3.Text = "Weight"
        ' 
        ' Wght
        ' 
        Wght.Anchor = AnchorStyles.None
        Wght.Location = New Point(358, 360)
        Wght.Name = "Wght"
        Wght.Size = New Size(98, 31)
        Wght.TabIndex = 29
        Wght.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Location = New Point(60, 366)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 25)
        Label2.TabIndex = 28
        Label2.Text = "Height"
        ' 
        ' Hght
        ' 
        Hght.Anchor = AnchorStyles.None
        Hght.Location = New Point(131, 360)
        Hght.Name = "Hght"
        Hght.Size = New Size(98, 31)
        Hght.TabIndex = 27
        Hght.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Location = New Point(23, 415)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 25)
        Label1.TabIndex = 26
        Label1.Text = "Address"
        ' 
        ' Adrss
        ' 
        Adrss.Anchor = AnchorStyles.None
        Adrss.Location = New Point(108, 409)
        Adrss.Multiline = True
        Adrss.Name = "Adrss"
        Adrss.Size = New Size(348, 68)
        Adrss.TabIndex = 25
        Adrss.Text = "Place, District, State"
        ' 
        ' LRank
        ' 
        LRank.Anchor = AnchorStyles.None
        LRank.FormattingEnabled = True
        LRank.Items.AddRange(New Object() {"ASO", "LSG", "SG", "SS"})
        LRank.Location = New Point(629, 444)
        LRank.Name = "LRank"
        LRank.Size = New Size(293, 33)
        LRank.TabIndex = 24
        ' 
        ' Title
        ' 
        Title.Anchor = AnchorStyles.None
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Title.Location = New Point(361, 27)
        Title.Name = "Title"
        Title.Size = New Size(257, 38)
        Title.TabIndex = 23
        Title.Text = "Create Your Page"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.Anchor = AnchorStyles.None
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(699, 197)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(223, 25)
        LinkLabel2.TabIndex = 22
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Upload Your Profile Picture"
        ' 
        ' ProfilePic
        ' 
        ProfilePic.Anchor = AnchorStyles.None
        ProfilePic.BorderStyle = BorderStyle.Fixed3D
        ProfilePic.Location = New Point(733, 28)
        ProfilePic.Name = "ProfilePic"
        ProfilePic.Size = New Size(158, 167)
        ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage
        ProfilePic.TabIndex = 21
        ProfilePic.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Location = New Point(479, 398)
        Label8.Name = "Label8"
        Label8.Size = New Size(148, 25)
        Label8.TabIndex = 20
        Label8.Text = "Recruitment Date"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Location = New Point(570, 452)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 25)
        Label9.TabIndex = 18
        Label9.Text = "Rank"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Location = New Point(81, 317)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 25)
        Label10.TabIndex = 17
        Label10.Text = "Age"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Location = New Point(486, 246)
        Label11.Name = "Label11"
        Label11.Size = New Size(135, 25)
        Label11.TabIndex = 16
        Label11.Text = "Registration No"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Location = New Point(66, 117)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 25)
        Label12.TabIndex = 15
        Label12.Text = "Name"
        ' 
        ' Recruit
        ' 
        Recruit.Anchor = AnchorStyles.None
        Recruit.Location = New Point(629, 393)
        Recruit.Name = "Recruit"
        Recruit.Size = New Size(293, 31)
        Recruit.TabIndex = 14
        ' 
        ' LName
        ' 
        LName.Anchor = AnchorStyles.None
        LName.Location = New Point(131, 111)
        LName.Name = "LName"
        LName.Size = New Size(325, 31)
        LName.TabIndex = 13
        LName.TextAlign = HorizontalAlignment.Center
        ' 
        ' LReg
        ' 
        LReg.Anchor = AnchorStyles.None
        LReg.Location = New Point(629, 243)
        LReg.Name = "LReg"
        LReg.Size = New Size(293, 31)
        LReg.TabIndex = 12
        LReg.TextAlign = HorizontalAlignment.Center
        ' 
        ' LAge
        ' 
        LAge.Anchor = AnchorStyles.None
        LAge.Location = New Point(131, 311)
        LAge.Name = "LAge"
        LAge.Size = New Size(325, 31)
        LAge.TabIndex = 11
        LAge.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Location = New Point(475, 350)
        Label13.Name = "Label13"
        Label13.Size = New Size(146, 25)
        Label13.TabIndex = 9
        Label13.Text = "Repeat Password"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.None
        Label14.AutoSize = True
        Label14.Location = New Point(504, 299)
        Label14.Name = "Label14"
        Label14.Size = New Size(117, 25)
        Label14.TabIndex = 8
        Label14.Text = "Set Password"
        ' 
        ' Cnfrm
        ' 
        Cnfrm.Anchor = AnchorStyles.None
        Cnfrm.Location = New Point(629, 344)
        Cnfrm.Name = "Cnfrm"
        Cnfrm.PasswordChar = "*"c
        Cnfrm.Size = New Size(293, 31)
        Cnfrm.TabIndex = 7
        Cnfrm.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.Font = New Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(436, 508)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 46)
        Button1.TabIndex = 6
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PW
        ' 
        PW.Anchor = AnchorStyles.None
        PW.Location = New Point(629, 293)
        PW.Name = "PW"
        PW.PasswordChar = "*"c
        PW.Size = New Size(293, 31)
        PW.TabIndex = 5
        PW.TextAlign = HorizontalAlignment.Center
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Location = New Point(56, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 32
        Label4.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Location = New Point(23, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 34
        Label5.Text = "Contact No"
        ' 
        ' PhoneNo
        ' 
        PhoneNo.Anchor = AnchorStyles.None
        PhoneNo.Location = New Point(131, 213)
        PhoneNo.Name = "PhoneNo"
        PhoneNo.Size = New Size(325, 31)
        PhoneNo.TabIndex = 33
        PhoneNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Location = New Point(66, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 25)
        Label6.TabIndex = 36
        Label6.Text = "Email"
        ' 
        ' Eml
        ' 
        Eml.Anchor = AnchorStyles.None
        Eml.Location = New Point(131, 261)
        Eml.Name = "Eml"
        Eml.Size = New Size(325, 31)
        Eml.TabIndex = 35
        Eml.TextAlign = HorizontalAlignment.Center
        ' 
        ' ComboGender
        ' 
        ComboGender.Anchor = AnchorStyles.None
        ComboGender.FormattingEnabled = True
        ComboGender.Items.AddRange(New Object() {"Male", "Female", "Too Haram To Say"})
        ComboGender.Location = New Point(131, 162)
        ComboGender.Name = "ComboGender"
        ComboGender.Size = New Size(325, 33)
        ComboGender.TabIndex = 37
        ' 
        ' ProfileCreation
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1005, 667)
        Controls.Add(Panel2)
        Name = "ProfileCreation"
        Text = "ProfileCreation"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ProfilePic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents ProfilePic As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Recruit As DateTimePicker
    Friend WithEvents LName As TextBox
    Friend WithEvents LReg As TextBox
    Friend WithEvents LAge As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Cnfrm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PW As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Title As Label
    Friend WithEvents LRank As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Adrss As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Wght As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Hght As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Eml As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboGender As ComboBox
End Class
