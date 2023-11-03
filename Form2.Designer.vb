<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TableLayoutPanel1 = New TableLayoutPanel()
        frm = New TextBox()
        matrl = New TextBox()
        dept = New TextBox()
        bill = New TextBox()
        dc = New TextBox()
        inwrd = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        dte = New TextBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        pack = New TextBox()
        ret = New TextBox()
        vech = New TextBox()
        desgn = New TextBox()
        remrks = New TextBox()
        sec = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        save = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.14563F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 54.85437F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 137F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 179F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 158F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 126F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 113F))
        TableLayoutPanel1.Controls.Add(frm, 2, 1)
        TableLayoutPanel1.Controls.Add(matrl, 3, 1)
        TableLayoutPanel1.Controls.Add(dept, 4, 1)
        TableLayoutPanel1.Controls.Add(bill, 5, 1)
        TableLayoutPanel1.Controls.Add(dc, 6, 1)
        TableLayoutPanel1.Controls.Add(inwrd, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 2, 0)
        TableLayoutPanel1.Controls.Add(Label4, 3, 0)
        TableLayoutPanel1.Controls.Add(Label5, 4, 0)
        TableLayoutPanel1.Controls.Add(Label6, 5, 0)
        TableLayoutPanel1.Controls.Add(Label7, 6, 0)
        TableLayoutPanel1.Controls.Add(dte, 0, 1)
        TableLayoutPanel1.Location = New Point(66, 61)
        TableLayoutPanel1.Margin = New Padding(4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1046, 150)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' frm
        ' 
        frm.BackColor = SystemColors.MenuBar
        frm.BorderStyle = BorderStyle.None
        frm.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        frm.Location = New Point(325, 79)
        frm.Multiline = True
        frm.Name = "frm"
        frm.Size = New Size(127, 65)
        frm.TabIndex = 17
        ' 
        ' matrl
        ' 
        matrl.BackColor = SystemColors.MenuBar
        matrl.BorderStyle = BorderStyle.None
        matrl.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        matrl.Location = New Point(464, 79)
        matrl.Multiline = True
        matrl.Name = "matrl"
        matrl.Size = New Size(173, 65)
        matrl.TabIndex = 16
        ' 
        ' dept
        ' 
        dept.BackColor = SystemColors.MenuBar
        dept.BorderStyle = BorderStyle.None
        dept.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dept.Location = New Point(645, 79)
        dept.Multiline = True
        dept.Name = "dept"
        dept.Size = New Size(152, 65)
        dept.TabIndex = 15
        ' 
        ' bill
        ' 
        bill.BackColor = SystemColors.MenuBar
        bill.BorderStyle = BorderStyle.None
        bill.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        bill.Location = New Point(805, 79)
        bill.Multiline = True
        bill.Name = "bill"
        bill.Size = New Size(120, 65)
        bill.TabIndex = 14
        ' 
        ' dc
        ' 
        dc.BackColor = SystemColors.MenuBar
        dc.BorderStyle = BorderStyle.None
        dc.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dc.Location = New Point(933, 79)
        dc.Multiline = True
        dc.Name = "dc"
        dc.Size = New Size(108, 65)
        dc.TabIndex = 13
        ' 
        ' inwrd
        ' 
        inwrd.BackColor = SystemColors.MenuBar
        inwrd.BorderStyle = BorderStyle.None
        inwrd.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        inwrd.Location = New Point(150, 79)
        inwrd.Multiline = True
        inwrd.Name = "inwrd"
        inwrd.Size = New Size(167, 66)
        inwrd.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(45, 28)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "DATE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseMnemonic = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(176, 28)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 1
        Label2.Text = "INWARD NO"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.UseMnemonic = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.Location = New Point(359, 28)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.Yes
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 2
        Label3.Text = "FROM"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        Label3.UseMnemonic = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(498, 18)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.Yes
        Label4.Size = New Size(105, 40)
        Label4.TabIndex = 3
        Label4.Text = "MATERIAL FOR/TO"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        Label4.UseMnemonic = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label5.Location = New Point(650, 28)
        Label5.Name = "Label5"
        Label5.RightToLeft = RightToLeft.Yes
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 4
        Label5.Text = "DEPT/PROCESS"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        Label5.UseMnemonic = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label6.Location = New Point(816, 18)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.Yes
        Label6.Size = New Size(98, 40)
        Label6.TabIndex = 5
        Label6.Text = "BILL NO&DATE"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        Label6.UseMnemonic = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label7.Location = New Point(938, 18)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.Yes
        Label7.Size = New Size(98, 40)
        Label7.TabIndex = 6
        Label7.Text = "DC NO&DATE"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        Label7.UseMnemonic = False
        ' 
        ' dte
        ' 
        dte.BackColor = SystemColors.Menu
        dte.BorderStyle = BorderStyle.None
        dte.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dte.Location = New Point(5, 79)
        dte.Multiline = True
        dte.Name = "dte"
        dte.Size = New Size(137, 66)
        dte.TabIndex = 7
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial
        TableLayoutPanel2.ColumnCount = 6
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.6123352F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 56.3876648F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 162F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 337F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 183F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 121F))
        TableLayoutPanel2.Controls.Add(pack, 0, 1)
        TableLayoutPanel2.Controls.Add(ret, 0, 1)
        TableLayoutPanel2.Controls.Add(vech, 0, 1)
        TableLayoutPanel2.Controls.Add(desgn, 0, 1)
        TableLayoutPanel2.Controls.Add(remrks, 0, 1)
        TableLayoutPanel2.Controls.Add(sec, 0, 1)
        TableLayoutPanel2.Controls.Add(Label8, 0, 0)
        TableLayoutPanel2.Controls.Add(Label9, 1, 0)
        TableLayoutPanel2.Controls.Add(Label10, 2, 0)
        TableLayoutPanel2.Controls.Add(Label11, 3, 0)
        TableLayoutPanel2.Controls.Add(Label12, 4, 0)
        TableLayoutPanel2.Controls.Add(Label13, 5, 0)
        TableLayoutPanel2.Location = New Point(66, 235)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(1046, 150)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' pack
        ' 
        pack.BackColor = SystemColors.MenuBar
        pack.BorderStyle = BorderStyle.None
        pack.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        pack.Location = New Point(6, 79)
        pack.Multiline = True
        pack.Name = "pack"
        pack.Size = New Size(88, 65)
        pack.TabIndex = 17
        ' 
        ' ret
        ' 
        ret.BackColor = SystemColors.MenuBar
        ret.BorderStyle = BorderStyle.None
        ret.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ret.Location = New Point(233, 79)
        ret.Multiline = True
        ret.Name = "ret"
        ret.Size = New Size(156, 65)
        ret.TabIndex = 16
        ' 
        ' vech
        ' 
        vech.BackColor = SystemColors.MenuBar
        vech.BorderStyle = BorderStyle.None
        vech.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        vech.Location = New Point(105, 79)
        vech.Multiline = True
        vech.Name = "vech"
        vech.Size = New Size(119, 65)
        vech.TabIndex = 15
        ' 
        ' desgn
        ' 
        desgn.BackColor = SystemColors.MenuBar
        desgn.BorderStyle = BorderStyle.None
        desgn.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        desgn.Location = New Point(398, 79)
        desgn.Multiline = True
        desgn.Name = "desgn"
        desgn.Size = New Size(331, 65)
        desgn.TabIndex = 14
        ' 
        ' remrks
        ' 
        remrks.BackColor = SystemColors.MenuBar
        remrks.BorderStyle = BorderStyle.None
        remrks.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        remrks.Location = New Point(924, 79)
        remrks.Multiline = True
        remrks.Name = "remrks"
        remrks.Size = New Size(116, 65)
        remrks.TabIndex = 13
        ' 
        ' sec
        ' 
        sec.BackColor = SystemColors.MenuBar
        sec.BorderStyle = BorderStyle.None
        sec.Font = New Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point)
        sec.Location = New Point(738, 79)
        sec.Multiline = True
        sec.Name = "sec"
        sec.Size = New Size(177, 65)
        sec.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label8.Location = New Point(8, 8)
        Label8.Name = "Label8"
        Label8.RightToLeft = RightToLeft.Yes
        Label8.Size = New Size(85, 60)
        Label8.TabIndex = 1
        Label8.Text = "No Of Packages/Unites"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        Label8.UseMnemonic = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.None
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label9.Location = New Point(118, 28)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.Yes
        Label9.Size = New Size(92, 20)
        Label9.TabIndex = 2
        Label9.Text = "Vehicle No"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        Label9.UseMnemonic = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label10.Location = New Point(242, 18)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.Yes
        Label10.Size = New Size(137, 40)
        Label10.TabIndex = 3
        Label10.Text = "Returnable or Non_Returnable"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        Label10.UseMnemonic = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.None
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label11.Location = New Point(429, 18)
        Label11.Name = "Label11"
        Label11.RightToLeft = RightToLeft.Yes
        Label11.Size = New Size(268, 40)
        Label11.TabIndex = 4
        Label11.Text = "Name Designation Of The Person Reciving The Metrials"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        Label11.UseMnemonic = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label12.Location = New Point(765, 28)
        Label12.Name = "Label12"
        Label12.RightToLeft = RightToLeft.Yes
        Label12.Size = New Size(122, 20)
        Label12.TabIndex = 5
        Label12.Text = "Security Name"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        Label12.UseMnemonic = False
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.Font = New Font("Times New Roman", 9F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label13.Location = New Point(943, 28)
        Label13.Name = "Label13"
        Label13.RightToLeft = RightToLeft.Yes
        Label13.Size = New Size(78, 20)
        Label13.TabIndex = 6
        Label13.Text = "Remarks"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        Label13.UseMnemonic = False
        ' 
        ' save
        ' 
        save.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        save.Location = New Point(1000, 408)
        save.Name = "save"
        save.Size = New Size(112, 34)
        save.TabIndex = 2
        save.Text = "SAVE"
        save.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(857, 408)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 3
        Button2.Text = "RESET"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(694, 407)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 9
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(557, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 10
        Button1.Text = "DELETE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1176, 480)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(save)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Name = "Form2"
        Text = "Inward(NRGP&RGP)"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dte As TextBox
    Friend WithEvents frm As TextBox
    Friend WithEvents matrl As TextBox
    Friend WithEvents dept As TextBox
    Friend WithEvents bill As TextBox
    Friend WithEvents dc As TextBox
    Friend WithEvents inwrd As TextBox
    Friend WithEvents pack As TextBox
    Friend WithEvents ret As TextBox
    Friend WithEvents vech As TextBox
    Friend WithEvents desgn As TextBox
    Friend WithEvents remrks As TextBox
    Friend WithEvents sec As TextBox
    Friend WithEvents save As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
