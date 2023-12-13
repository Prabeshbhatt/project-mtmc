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
        GtePssType = New ComboBox()
        RtrnDte = New DateTimePicker()
        Dte = New DateTimePicker()
        Fromtxt = New TextBox()
        From = New Label()
        BtnDlt = New Button()
        Btnupdt = New Button()
        Btnsave = New Button()
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
        SuspendLayout()
        ' 
        ' GtePssType
        ' 
        GtePssType.Anchor = AnchorStyles.None
        GtePssType.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GtePssType.FormattingEnabled = True
        GtePssType.Items.AddRange(New Object() {"NRGP", "RGP"})
        GtePssType.Location = New Point(125, 77)
        GtePssType.Name = "GtePssType"
        GtePssType.Size = New Size(310, 38)
        GtePssType.TabIndex = 64
        ' 
        ' RtrnDte
        ' 
        RtrnDte.Anchor = AnchorStyles.None
        RtrnDte.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        RtrnDte.Location = New Point(593, 532)
        RtrnDte.Name = "RtrnDte"
        RtrnDte.Size = New Size(310, 37)
        RtrnDte.TabIndex = 63
        ' 
        ' Dte
        ' 
        Dte.Anchor = AnchorStyles.None
        Dte.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Dte.Location = New Point(593, 164)
        Dte.Name = "Dte"
        Dte.Size = New Size(310, 37)
        Dte.TabIndex = 46
        ' 
        ' Fromtxt
        ' 
        Fromtxt.Anchor = AnchorStyles.None
        Fromtxt.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Fromtxt.Location = New Point(593, 249)
        Fromtxt.Multiline = True
        Fromtxt.Name = "Fromtxt"
        Fromtxt.Size = New Size(310, 140)
        Fromtxt.TabIndex = 62
        ' 
        ' From
        ' 
        From.Anchor = AnchorStyles.None
        From.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(125, 214)
        From.Name = "From"
        From.Size = New Size(73, 32)
        From.TabIndex = 61
        From.Text = "From"
        ' 
        ' BtnDlt
        ' 
        BtnDlt.Anchor = AnchorStyles.None
        BtnDlt.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDlt.Location = New Point(604, 762)
        BtnDlt.Name = "BtnDlt"
        BtnDlt.Size = New Size(140, 60)
        BtnDlt.TabIndex = 60
        BtnDlt.Text = "DELETE"
        BtnDlt.UseVisualStyleBackColor = True
        ' 
        ' Btnupdt
        ' 
        Btnupdt.Anchor = AnchorStyles.None
        Btnupdt.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Btnupdt.Location = New Point(424, 762)
        Btnupdt.Name = "Btnupdt"
        Btnupdt.Size = New Size(140, 60)
        Btnupdt.TabIndex = 59
        Btnupdt.Text = "UPDATE"
        Btnupdt.UseVisualStyleBackColor = True
        ' 
        ' Btnsave
        ' 
        Btnsave.Anchor = AnchorStyles.None
        Btnsave.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsave.Location = New Point(240, 762)
        Btnsave.Name = "Btnsave"
        Btnsave.Size = New Size(140, 60)
        Btnsave.TabIndex = 58
        Btnsave.Text = "SAVE"
        Btnsave.UseVisualStyleBackColor = True
        ' 
        ' Totext
        ' 
        Totext.Anchor = AnchorStyles.None
        Totext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Totext.Location = New Point(125, 250)
        Totext.Multiline = True
        Totext.Name = "Totext"
        Totext.Size = New Size(310, 140)
        Totext.TabIndex = 57
        ' 
        ' Dpt
        ' 
        Dpt.Anchor = AnchorStyles.None
        Dpt.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Dpt.Location = New Point(125, 165)
        Dpt.Name = "Dpt"
        Dpt.Size = New Size(310, 37)
        Dpt.TabIndex = 56
        ' 
        ' Qty
        ' 
        Qty.Anchor = AnchorStyles.None
        Qty.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Qty.Location = New Point(765, 443)
        Qty.Multiline = True
        Qty.Name = "Qty"
        Qty.Size = New Size(138, 40)
        Qty.TabIndex = 55
        ' 
        ' Mtrl
        ' 
        Mtrl.Anchor = AnchorStyles.None
        Mtrl.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Mtrl.Location = New Point(125, 442)
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
        Label10.Location = New Point(593, 498)
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
        PType.Location = New Point(125, 42)
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
        tolbl.Location = New Point(593, 214)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(41, 32)
        tolbl.TabIndex = 51
        tolbl.Text = "To"
        ' 
        ' DteLbl
        ' 
        DteLbl.Anchor = AnchorStyles.None
        DteLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(593, 130)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(69, 35)
        DteLbl.TabIndex = 50
        DteLbl.Text = "Date"
        ' 
        ' Dept
        ' 
        Dept.Anchor = AnchorStyles.None
        Dept.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(125, 131)
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
        Qtty.Location = New Point(765, 408)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(113, 32)
        Qtty.TabIndex = 48
        Qtty.Text = "Quantity"
        ' 
        ' Materl
        ' 
        Materl.Anchor = AnchorStyles.None
        Materl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(125, 408)
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
        GtPssNo.Location = New Point(593, 36)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(166, 37)
        GtPssNo.TabIndex = 45
        GtPssNo.Text = "Gate Pass No"
        ' 
        ' GtPss
        ' 
        GtPss.Anchor = AnchorStyles.None
        GtPss.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        GtPss.Location = New Point(593, 77)
        GtPss.Multiline = True
        GtPss.Name = "GtPss"
        GtPss.Size = New Size(310, 40)
        GtPss.TabIndex = 65
        ' 
        ' Sendr
        ' 
        Sendr.Anchor = AnchorStyles.None
        Sendr.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Sendr.Location = New Point(125, 532)
        Sendr.Multiline = True
        Sendr.Name = "Sendr"
        Sendr.Size = New Size(310, 40)
        Sendr.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(125, 498)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 31)
        Label1.TabIndex = 66
        Label1.Text = "Sender"
        ' 
        ' Purpose
        ' 
        Purpose.Anchor = AnchorStyles.None
        Purpose.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Purpose.Location = New Point(125, 622)
        Purpose.Multiline = True
        Purpose.Name = "Purpose"
        Purpose.Size = New Size(778, 36)
        Purpose.TabIndex = 69
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(125, 588)
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
        Vhcle.Location = New Point(125, 699)
        Vhcle.Multiline = True
        Vhcle.Name = "Vhcle"
        Vhcle.Size = New Size(310, 40)
        Vhcle.TabIndex = 71
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(125, 669)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 31)
        Label3.TabIndex = 70
        Label3.Text = "Vehicle No"
        ' 
        ' Drivr
        ' 
        Drivr.Anchor = AnchorStyles.None
        Drivr.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Drivr.Location = New Point(593, 702)
        Drivr.Multiline = True
        Drivr.Name = "Drivr"
        Drivr.Size = New Size(310, 40)
        Drivr.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(593, 669)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 31)
        Label4.TabIndex = 72
        Label4.Text = "Driver"
        ' 
        ' UC_Outward
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
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
        Controls.Add(BtnDlt)
        Controls.Add(Btnupdt)
        Controls.Add(Btnsave)
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
        Size = New Size(1048, 848)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GtePssType As ComboBox
    Friend WithEvents RtrnDte As DateTimePicker
    Friend WithEvents Dte As DateTimePicker
    Friend WithEvents Fromtxt As TextBox
    Friend WithEvents From As Label
    Friend WithEvents BtnDlt As Button
    Friend WithEvents Btnupdt As Button
    Friend WithEvents Btnsave As Button
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

End Class
