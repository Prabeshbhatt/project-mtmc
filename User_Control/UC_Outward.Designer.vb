﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        SuspendLayout()
        ' 
        ' GtePssType
        ' 
        GtePssType.Anchor = AnchorStyles.None
        GtePssType.FormattingEnabled = True
        GtePssType.Items.AddRange(New Object() {"NRGP", "RGP"})
        GtePssType.Location = New Point(472, 451)
        GtePssType.Name = "GtePssType"
        GtePssType.Size = New Size(372, 33)
        GtePssType.TabIndex = 64
        ' 
        ' RtrnDte
        ' 
        RtrnDte.Anchor = AnchorStyles.None
        RtrnDte.Location = New Point(472, 506)
        RtrnDte.Name = "RtrnDte"
        RtrnDte.Size = New Size(372, 31)
        RtrnDte.TabIndex = 63
        ' 
        ' Dte
        ' 
        Dte.Anchor = AnchorStyles.None
        Dte.Location = New Point(472, 330)
        Dte.Name = "Dte"
        Dte.Size = New Size(372, 31)
        Dte.TabIndex = 46
        ' 
        ' Fromtxt
        ' 
        Fromtxt.Anchor = AnchorStyles.None
        Fromtxt.Location = New Point(716, 389)
        Fromtxt.Name = "Fromtxt"
        Fromtxt.Size = New Size(207, 31)
        Fromtxt.TabIndex = 62
        ' 
        ' From
        ' 
        From.Anchor = AnchorStyles.None
        From.AutoSize = True
        From.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(613, 386)
        From.Name = "From"
        From.Size = New Size(73, 32)
        From.TabIndex = 61
        From.Text = "From"
        ' 
        ' BtnDlt
        ' 
        BtnDlt.Anchor = AnchorStyles.None
        BtnDlt.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDlt.Location = New Point(421, 572)
        BtnDlt.Name = "BtnDlt"
        BtnDlt.Size = New Size(112, 34)
        BtnDlt.TabIndex = 60
        BtnDlt.Text = "DELETE"
        BtnDlt.UseVisualStyleBackColor = True
        ' 
        ' Btnupdt
        ' 
        Btnupdt.Anchor = AnchorStyles.None
        Btnupdt.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btnupdt.Location = New Point(564, 573)
        Btnupdt.Name = "Btnupdt"
        Btnupdt.Size = New Size(112, 34)
        Btnupdt.TabIndex = 59
        Btnupdt.Text = "UPDATE"
        Btnupdt.UseVisualStyleBackColor = True
        ' 
        ' Btnsave
        ' 
        Btnsave.Anchor = AnchorStyles.None
        Btnsave.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsave.Location = New Point(707, 572)
        Btnsave.Name = "Btnsave"
        Btnsave.Size = New Size(112, 34)
        Btnsave.TabIndex = 58
        Btnsave.Text = "SAVE"
        Btnsave.UseVisualStyleBackColor = True
        ' 
        ' Totext
        ' 
        Totext.Anchor = AnchorStyles.None
        Totext.Location = New Point(352, 389)
        Totext.Name = "Totext"
        Totext.Size = New Size(207, 31)
        Totext.TabIndex = 57
        ' 
        ' Dpt
        ' 
        Dpt.Anchor = AnchorStyles.None
        Dpt.Location = New Point(472, 271)
        Dpt.Name = "Dpt"
        Dpt.Size = New Size(372, 31)
        Dpt.TabIndex = 56
        ' 
        ' Qty
        ' 
        Qty.Anchor = AnchorStyles.None
        Qty.Location = New Point(472, 218)
        Qty.Name = "Qty"
        Qty.Size = New Size(372, 31)
        Qty.TabIndex = 55
        ' 
        ' Mtrl
        ' 
        Mtrl.Anchor = AnchorStyles.None
        Mtrl.Location = New Point(472, 157)
        Mtrl.Multiline = True
        Mtrl.Name = "Mtrl"
        Mtrl.Size = New Size(372, 36)
        Mtrl.TabIndex = 54
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(274, 506)
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
        PType.Location = New Point(254, 448)
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
        tolbl.Location = New Point(248, 386)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(41, 32)
        tolbl.TabIndex = 51
        tolbl.Text = "To"
        ' 
        ' DteLbl
        ' 
        DteLbl.Anchor = AnchorStyles.None
        DteLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(274, 330)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(146, 35)
        DteLbl.TabIndex = 50
        DteLbl.Text = "Date"
        ' 
        ' Dept
        ' 
        Dept.Anchor = AnchorStyles.None
        Dept.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(274, 271)
        Dept.Name = "Dept"
        Dept.Size = New Size(146, 31)
        Dept.TabIndex = 49
        Dept.Text = "Dept" & vbCrLf
        ' 
        ' Qtty
        ' 
        Qtty.Anchor = AnchorStyles.None
        Qtty.AutoSize = True
        Qtty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Qtty.Location = New Point(274, 218)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(113, 32)
        Qtty.TabIndex = 48
        Qtty.Text = "Quantity"
        ' 
        ' Materl
        ' 
        Materl.Anchor = AnchorStyles.None
        Materl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(274, 162)
        Materl.Name = "Materl"
        Materl.Size = New Size(217, 31)
        Materl.TabIndex = 47
        Materl.Text = "Material"
        ' 
        ' GtPssNo
        ' 
        GtPssNo.Anchor = AnchorStyles.None
        GtPssNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GtPssNo.Location = New Point(224, 99)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(242, 37)
        GtPssNo.TabIndex = 45
        GtPssNo.Text = "Gate Pass No."
        ' 
        ' GtPss
        ' 
        GtPss.Anchor = AnchorStyles.None
        GtPss.Location = New Point(472, 88)
        GtPss.Multiline = True
        GtPss.Name = "GtPss"
        GtPss.Size = New Size(372, 37)
        GtPss.TabIndex = 65
        ' 
        ' UC_Outward
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
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
        Size = New Size(1164, 707)
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

End Class