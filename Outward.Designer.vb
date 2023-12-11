<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Outward
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel2 = New Panel()
        GunaGtPss = New Guna.UI2.WinForms.Guna2TextBox()
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
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(GunaGtPss)
        Panel2.Controls.Add(GtePssType)
        Panel2.Controls.Add(RtrnDte)
        Panel2.Controls.Add(Dte)
        Panel2.Controls.Add(Fromtxt)
        Panel2.Controls.Add(From)
        Panel2.Controls.Add(BtnDlt)
        Panel2.Controls.Add(Btnupdt)
        Panel2.Controls.Add(Btnsave)
        Panel2.Controls.Add(Totext)
        Panel2.Controls.Add(Dpt)
        Panel2.Controls.Add(Qty)
        Panel2.Controls.Add(Mtrl)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(PType)
        Panel2.Controls.Add(tolbl)
        Panel2.Controls.Add(DteLbl)
        Panel2.Controls.Add(Dept)
        Panel2.Controls.Add(Qtty)
        Panel2.Controls.Add(Materl)
        Panel2.Controls.Add(GtPssNo)
        Panel2.Location = New Point(50, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(954, 573)
        Panel2.TabIndex = 19
        ' 
        ' GunaGtPss
        ' 
        GunaGtPss.CustomizableEdges = CustomizableEdges3
        GunaGtPss.DefaultText = ""
        GunaGtPss.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        GunaGtPss.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        GunaGtPss.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GunaGtPss.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        GunaGtPss.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GunaGtPss.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        GunaGtPss.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        GunaGtPss.Location = New Point(342, 84)
        GunaGtPss.Name = "GunaGtPss"
        GunaGtPss.PasswordChar = ChrW(0)
        GunaGtPss.PlaceholderText = ""
        GunaGtPss.SelectedText = ""
        GunaGtPss.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        GunaGtPss.Size = New Size(372, 39)
        GunaGtPss.TabIndex = 44
        ' 
        ' GtePssType
        ' 
        GtePssType.FormattingEnabled = True
        GtePssType.Items.AddRange(New Object() {"NRGP", "RGP"})
        GtePssType.Location = New Point(342, 311)
        GtePssType.Name = "GtePssType"
        GtePssType.Size = New Size(372, 33)
        GtePssType.TabIndex = 43
        ' 
        ' RtrnDte
        ' 
        RtrnDte.Location = New Point(342, 348)
        RtrnDte.Name = "RtrnDte"
        RtrnDte.Size = New Size(372, 31)
        RtrnDte.TabIndex = 42
        ' 
        ' Dte
        ' 
        Dte.Location = New Point(342, 238)
        Dte.Name = "Dte"
        Dte.Size = New Size(372, 31)
        Dte.TabIndex = 20
        ' 
        ' Fromtxt
        ' 
        Fromtxt.Anchor = AnchorStyles.None
        Fromtxt.Location = New Point(612, 276)
        Fromtxt.Name = "Fromtxt"
        Fromtxt.Size = New Size(207, 31)
        Fromtxt.TabIndex = 41
        ' 
        ' From
        ' 
        From.Anchor = AnchorStyles.None
        From.AutoSize = True
        From.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(509, 273)
        From.Name = "From"
        From.Size = New Size(73, 32)
        From.TabIndex = 40
        From.Text = "From"
        ' 
        ' BtnDlt
        ' 
        BtnDlt.Anchor = AnchorStyles.None
        BtnDlt.Font = New Font("Times New Roman", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDlt.Location = New Point(286, 440)
        BtnDlt.Name = "BtnDlt"
        BtnDlt.Size = New Size(112, 34)
        BtnDlt.TabIndex = 39
        BtnDlt.Text = "DELETE"
        BtnDlt.UseVisualStyleBackColor = True
        ' 
        ' Btnupdt
        ' 
        Btnupdt.Anchor = AnchorStyles.None
        Btnupdt.Font = New Font("Times New Roman", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btnupdt.Location = New Point(429, 441)
        Btnupdt.Name = "Btnupdt"
        Btnupdt.Size = New Size(112, 34)
        Btnupdt.TabIndex = 38
        Btnupdt.Text = "UPDATE"
        Btnupdt.UseVisualStyleBackColor = True
        ' 
        ' Btnsave
        ' 
        Btnsave.Anchor = AnchorStyles.None
        Btnsave.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsave.Location = New Point(572, 440)
        Btnsave.Name = "Btnsave"
        Btnsave.Size = New Size(112, 34)
        Btnsave.TabIndex = 36
        Btnsave.Text = "SAVE"
        Btnsave.UseVisualStyleBackColor = True
        ' 
        ' Totext
        ' 
        Totext.Anchor = AnchorStyles.None
        Totext.Location = New Point(248, 276)
        Totext.Name = "Totext"
        Totext.Size = New Size(207, 31)
        Totext.TabIndex = 33
        ' 
        ' Dpt
        ' 
        Dpt.Anchor = AnchorStyles.None
        Dpt.Location = New Point(342, 201)
        Dpt.Name = "Dpt"
        Dpt.Size = New Size(372, 31)
        Dpt.TabIndex = 31
        ' 
        ' Qty
        ' 
        Qty.Anchor = AnchorStyles.None
        Qty.Location = New Point(342, 164)
        Qty.Name = "Qty"
        Qty.Size = New Size(372, 31)
        Qty.TabIndex = 30
        ' 
        ' Mtrl
        ' 
        Mtrl.Anchor = AnchorStyles.None
        Mtrl.Location = New Point(342, 129)
        Mtrl.Name = "Mtrl"
        Mtrl.Size = New Size(372, 31)
        Mtrl.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(144, 345)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 32)
        Label10.TabIndex = 26
        Label10.Text = "Return Date"
        ' 
        ' PType
        ' 
        PType.Anchor = AnchorStyles.None
        PType.AutoSize = True
        PType.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        PType.Location = New Point(144, 311)
        PType.Name = "PType"
        PType.Size = New Size(183, 32)
        PType.TabIndex = 25
        PType.Text = "Gate Pass Type"
        ' 
        ' tolbl
        ' 
        tolbl.Anchor = AnchorStyles.None
        tolbl.AutoSize = True
        tolbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        tolbl.Location = New Point(144, 273)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(41, 32)
        tolbl.TabIndex = 24
        tolbl.Text = "To"
        ' 
        ' DteLbl
        ' 
        DteLbl.Anchor = AnchorStyles.None
        DteLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(144, 238)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(146, 35)
        DteLbl.TabIndex = 23
        DteLbl.Text = "Date"
        ' 
        ' Dept
        ' 
        Dept.Anchor = AnchorStyles.None
        Dept.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(144, 201)
        Dept.Name = "Dept"
        Dept.Size = New Size(146, 31)
        Dept.TabIndex = 22
        Dept.Text = "Dept" & vbCrLf
        ' 
        ' Qtty
        ' 
        Qtty.Anchor = AnchorStyles.None
        Qtty.AutoSize = True
        Qtty.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Qtty.Location = New Point(144, 166)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(113, 32)
        Qtty.TabIndex = 21
        Qtty.Text = "Quantity"
        ' 
        ' Materl
        ' 
        Materl.Anchor = AnchorStyles.None
        Materl.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(144, 132)
        Materl.Name = "Materl"
        Materl.Size = New Size(217, 31)
        Materl.TabIndex = 20
        Materl.Text = "Material"
        ' 
        ' GtPssNo
        ' 
        GtPssNo.Anchor = AnchorStyles.None
        GtPssNo.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GtPssNo.Location = New Point(144, 93)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(242, 37)
        GtPssNo.TabIndex = 19
        GtPssNo.Text = "Gate Pass No."
        ' 
        ' Outward
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(1059, 684)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Outward"
        Text = "Outward"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents Fromtxt As TextBox
    Friend WithEvents From As Label
    Friend WithEvents RtrnDte As DateTimePicker
    Friend WithEvents Dte As DateTimePicker
    Friend WithEvents GtePssType As ComboBox
    Friend WithEvents GunaGtPss As Guna.UI2.WinForms.Guna2TextBox
End Class
