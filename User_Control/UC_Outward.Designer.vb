<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Outward
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        GtePssType = New ComboBox()
        RtrnDte = New DateTimePicker()
        Dte = New DateTimePicker()
        Fromtxt = New TextBox()
        From = New Label()
        Totext = New TextBox()
        Dpt = New TextBox()
        Qty = New TextBox()
        Mtrl = New TextBox()
        Label10 = New Label()
        PType = New Label()
        tolbl = New Label()
        DteLbl = New Label()
        Dept = New Label()
        Qtty = New Label()
        Materl = New Label()
        GtPssNo = New Label()
        GtPss = New TextBox()
        Sendr = New TextBox()
        Label1 = New Label()
        Purpose = New TextBox()
        Label2 = New Label()
        Vhcle = New TextBox()
        Label3 = New Label()
        Drivr = New TextBox()
        Label4 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' GtePssType
        ' 
        GtePssType.Anchor = AnchorStyles.None
        GtePssType.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GtePssType.FormattingEnabled = True
        GtePssType.Items.AddRange(New Object() {"NRGP", "RGP"})
        GtePssType.Location = New Point(132, 222)
        GtePssType.Name = "GtePssType"
        GtePssType.Size = New Size(310, 38)
        GtePssType.TabIndex = 64
        ' 
        ' RtrnDte
        ' 
        RtrnDte.Anchor = AnchorStyles.None
        RtrnDte.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RtrnDte.Location = New Point(600, 677)
        RtrnDte.Name = "RtrnDte"
        RtrnDte.Size = New Size(310, 37)
        RtrnDte.TabIndex = 63
        ' 
        ' Dte
        ' 
        Dte.Anchor = AnchorStyles.None
        Dte.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Dte.Location = New Point(600, 309)
        Dte.Name = "Dte"
        Dte.Size = New Size(310, 37)
        Dte.TabIndex = 46
        ' 
        ' Fromtxt
        ' 
        Fromtxt.Anchor = AnchorStyles.None
        Fromtxt.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Fromtxt.Location = New Point(600, 394)
        Fromtxt.Multiline = True
        Fromtxt.Name = "Fromtxt"
        Fromtxt.Size = New Size(310, 140)
        Fromtxt.TabIndex = 62
        ' 
        ' From
        ' 
        From.Anchor = AnchorStyles.None
        From.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(132, 359)
        From.Name = "From"
        From.Size = New Size(73, 32)
        From.TabIndex = 61
        From.Text = "From"
        ' 
        ' Totext
        ' 
        Totext.Anchor = AnchorStyles.None
        Totext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Totext.Location = New Point(132, 395)
        Totext.Multiline = True
        Totext.Name = "Totext"
        Totext.Size = New Size(310, 140)
        Totext.TabIndex = 57
        ' 
        ' Dpt
        ' 
        Dpt.Anchor = AnchorStyles.None
        Dpt.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Dpt.Location = New Point(132, 310)
        Dpt.Name = "Dpt"
        Dpt.Size = New Size(310, 37)
        Dpt.TabIndex = 56
        ' 
        ' Qty
        ' 
        Qty.Anchor = AnchorStyles.None
        Qty.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Qty.Location = New Point(772, 588)
        Qty.Multiline = True
        Qty.Name = "Qty"
        Qty.Size = New Size(138, 40)
        Qty.TabIndex = 55
        ' 
        ' Mtrl
        ' 
        Mtrl.Anchor = AnchorStyles.None
        Mtrl.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Mtrl.Location = New Point(132, 587)
        Mtrl.Multiline = True
        Mtrl.Name = "Mtrl"
        Mtrl.Size = New Size(582, 40)
        Mtrl.TabIndex = 54
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(600, 643)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 32)
        Label10.TabIndex = 53
        Label10.Text = "Return Date"
        ' 
        ' PType
        ' 
        PType.Anchor = AnchorStyles.None
        PType.AutoSize = True
        PType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PType.Location = New Point(132, 187)
        PType.Name = "PType"
        PType.Size = New Size(183, 32)
        PType.TabIndex = 52
        PType.Text = "Gate Pass Type"
        ' 
        ' tolbl
        ' 
        tolbl.Anchor = AnchorStyles.None
        tolbl.AutoSize = True
        tolbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tolbl.Location = New Point(600, 359)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(41, 32)
        tolbl.TabIndex = 51
        tolbl.Text = "To"
        ' 
        ' DteLbl
        ' 
        DteLbl.Anchor = AnchorStyles.None
        DteLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(600, 275)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(69, 35)
        DteLbl.TabIndex = 50
        DteLbl.Text = "Date"
        ' 
        ' Dept
        ' 
        Dept.Anchor = AnchorStyles.None
        Dept.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(132, 276)
        Dept.Name = "Dept"
        Dept.Size = New Size(70, 31)
        Dept.TabIndex = 49
        Dept.Text = "Dept" & vbCrLf
        ' 
        ' Qtty
        ' 
        Qtty.Anchor = AnchorStyles.None
        Qtty.AutoSize = True
        Qtty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Qtty.Location = New Point(772, 553)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(113, 32)
        Qtty.TabIndex = 48
        Qtty.Text = "Quantity"
        ' 
        ' Materl
        ' 
        Materl.Anchor = AnchorStyles.None
        Materl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(132, 553)
        Materl.Name = "Materl"
        Materl.Size = New Size(111, 31)
        Materl.TabIndex = 47
        Materl.Text = "Material"
        Materl.TextAlign = ContentAlignment.TopRight
        ' 
        ' GtPssNo
        ' 
        GtPssNo.Anchor = AnchorStyles.None
        GtPssNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GtPssNo.Location = New Point(600, 181)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(166, 37)
        GtPssNo.TabIndex = 45
        GtPssNo.Text = "Gate Pass No"
        ' 
        ' GtPss
        ' 
        GtPss.Anchor = AnchorStyles.None
        GtPss.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GtPss.Location = New Point(600, 222)
        GtPss.Multiline = True
        GtPss.Name = "GtPss"
        GtPss.Size = New Size(310, 40)
        GtPss.TabIndex = 65
        ' 
        ' Sendr
        ' 
        Sendr.Anchor = AnchorStyles.None
        Sendr.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Sendr.Location = New Point(132, 677)
        Sendr.Multiline = True
        Sendr.Name = "Sendr"
        Sendr.Size = New Size(310, 40)
        Sendr.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(132, 643)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 31)
        Label1.TabIndex = 66
        Label1.Text = "Sender"
        ' 
        ' Purpose
        ' 
        Purpose.Anchor = AnchorStyles.None
        Purpose.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Purpose.Location = New Point(132, 767)
        Purpose.Multiline = True
        Purpose.Name = "Purpose"
        Purpose.Size = New Size(778, 36)
        Purpose.TabIndex = 69
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(132, 733)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 31)
        Label2.TabIndex = 68
        Label2.Text = "Purpose"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Vhcle
        ' 
        Vhcle.Anchor = AnchorStyles.None
        Vhcle.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Vhcle.Location = New Point(132, 844)
        Vhcle.Multiline = True
        Vhcle.Name = "Vhcle"
        Vhcle.Size = New Size(310, 40)
        Vhcle.TabIndex = 71
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(132, 814)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 31)
        Label3.TabIndex = 70
        Label3.Text = "Vehicle No"
        ' 
        ' Drivr
        ' 
        Drivr.Anchor = AnchorStyles.None
        Drivr.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Drivr.Location = New Point(600, 847)
        Drivr.Multiline = True
        Drivr.Name = "Drivr"
        Drivr.Size = New Size(310, 40)
        Drivr.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(600, 814)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 31)
        Label4.TabIndex = 72
        Label4.Text = "Driver"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Anchor = AnchorStyles.None
        Guna2Button1.Animated = True
        Guna2Button1.AnimatedGIF = True
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.SlateBlue
        Guna2Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(203, 917)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.PressedColor = Color.WhiteSmoke
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(140, 60)
        Guna2Button1.TabIndex = 74
        Guna2Button1.Text = "Save"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Anchor = AnchorStyles.None
        Guna2Button2.Animated = True
        Guna2Button2.AnimatedGIF = True
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.SlateBlue
        Guna2Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(453, 917)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.PressedColor = Color.WhiteSmoke
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(140, 60)
        Guna2Button2.TabIndex = 75
        Guna2Button2.Text = "Update"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.Anchor = AnchorStyles.None
        Guna2Button3.Animated = True
        Guna2Button3.AnimatedGIF = True
        Guna2Button3.CustomizableEdges = CustomizableEdges5
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.SlateBlue
        Guna2Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.Location = New Point(697, 917)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.PressedColor = Color.WhiteSmoke
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button3.Size = New Size(140, 60)
        Guna2Button3.TabIndex = 76
        Guna2Button3.Text = "Delete"
        ' 
        ' UC_Outward
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2Button3)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2Button1)
        Controls.Add(Drivr)
        Controls.Add(Label4)
        Controls.Add(Vhcle)
        Controls.Add(Label3)
        Controls.Add(Purpose)
        Controls.Add(Label2)
        Controls.Add(Sendr)
        Controls.Add(Label1)
        Controls.Add(GtPss)
        Controls.Add(GtePssType)
        Controls.Add(RtrnDte)
        Controls.Add(Dte)
        Controls.Add(Fromtxt)
        Controls.Add(From)
        Controls.Add(Totext)
        Controls.Add(Dpt)
        Controls.Add(Qty)
        Controls.Add(Mtrl)
        Controls.Add(Label10)
        Controls.Add(PType)
        Controls.Add(tolbl)
        Controls.Add(DteLbl)
        Controls.Add(Dept)
        Controls.Add(Qtty)
        Controls.Add(Materl)
        Controls.Add(GtPssNo)
        Name = "UC_Outward"
        Size = New Size(1048, 980)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GtePssType As ComboBox
    Friend WithEvents RtrnDte As DateTimePicker
    Friend WithEvents Dte As DateTimePicker
    Friend WithEvents Fromtxt As TextBox
    Friend WithEvents From As Label
    Friend WithEvents Totext As TextBox
    Friend WithEvents Dpt As TextBox
    Friend WithEvents Qty As TextBox
    Friend WithEvents Mtrl As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PType As Label
    Friend WithEvents tolbl As Label
    Friend WithEvents DteLbl As Label
    Friend WithEvents Dept As Label
    Friend WithEvents Qtty As Label
    Friend WithEvents Materl As Label
    Friend WithEvents GtPssNo As Label
    Friend WithEvents GtPss As TextBox
    Friend WithEvents Sendr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Purpose As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Vhcle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Drivr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
