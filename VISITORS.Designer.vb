<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VISITORS
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
        DateTimePicker1 = New DateTimePicker()
        avgg = New TextBox()
        Label1 = New Label()
        outtme = New TextBox()
        From = New Label()
        Btnupd = New Button()
        Btndlte = New Button()
        Btnsave = New Button()
        nhrs = New TextBox()
        tper = New TextBox()
        intme = New TextBox()
        prsnn = New TextBox()
        cntt = New TextBox()
        addd = New TextBox()
        nmme = New TextBox()
        idno = New TextBox()
        Label10 = New Label()
        PType = New Label()
        tolbl = New Label()
        DteLbl = New Label()
        Dept = New Label()
        Qtty = New Label()
        Materl = New Label()
        GtPssNo = New Label()
        IDNUM = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(avgg)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(outtme)
        Panel1.Controls.Add(From)
        Panel1.Controls.Add(Btnupd)
        Panel1.Controls.Add(Btndlte)
        Panel1.Controls.Add(Btnsave)
        Panel1.Controls.Add(nhrs)
        Panel1.Controls.Add(tper)
        Panel1.Controls.Add(intme)
        Panel1.Controls.Add(prsnn)
        Panel1.Controls.Add(cntt)
        Panel1.Controls.Add(addd)
        Panel1.Controls.Add(nmme)
        Panel1.Controls.Add(idno)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(PType)
        Panel1.Controls.Add(tolbl)
        Panel1.Controls.Add(DteLbl)
        Panel1.Controls.Add(Dept)
        Panel1.Controls.Add(Qtty)
        Panel1.Controls.Add(Materl)
        Panel1.Controls.Add(GtPssNo)
        Panel1.Controls.Add(IDNUM)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1323, 634)
        Panel1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DateTimePicker1.Location = New Point(332, 76)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(372, 31)
        DateTimePicker1.TabIndex = 69
        ' 
        ' avgg
        ' 
        avgg.Location = New Point(355, 503)
        avgg.Name = "avgg"
        avgg.Size = New Size(372, 31)
        avgg.TabIndex = 68
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(140, 500)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 32)
        Label1.TabIndex = 67
        Label1.Text = "AVG TIME SPENT"
        ' 
        ' outtme
        ' 
        outtme.Location = New Point(781, 335)
        outtme.Name = "outtme"
        outtme.Size = New Size(207, 31)
        outtme.TabIndex = 66
        ' 
        ' From
        ' 
        From.AutoSize = True
        From.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(630, 334)
        From.Name = "From"
        From.Size = New Size(128, 32)
        From.TabIndex = 65
        From.Text = "OUT TIME"
        ' 
        ' Btnupd
        ' 
        Btnupd.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btnupd.Location = New Point(561, 571)
        Btnupd.Name = "Btnupd"
        Btnupd.Size = New Size(112, 34)
        Btnupd.TabIndex = 64
        Btnupd.Text = "DELETE"
        Btnupd.UseVisualStyleBackColor = True
        ' 
        ' Btndlte
        ' 
        Btndlte.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btndlte.Location = New Point(704, 572)
        Btndlte.Name = "Btndlte"
        Btndlte.Size = New Size(112, 34)
        Btndlte.TabIndex = 63
        Btndlte.Text = "UPDATE"
        Btndlte.UseVisualStyleBackColor = True
        ' 
        ' Btnsave
        ' 
        Btnsave.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsave.Location = New Point(847, 572)
        Btnsave.Name = "Btnsave"
        Btnsave.Size = New Size(112, 34)
        Btnsave.TabIndex = 62
        Btnsave.Text = "SAVE"
        Btnsave.UseVisualStyleBackColor = True
        ' 
        ' nhrs
        ' 
        nhrs.Location = New Point(338, 452)
        nhrs.Name = "nhrs"
        nhrs.Size = New Size(372, 31)
        nhrs.TabIndex = 61
        ' 
        ' tper
        ' 
        tper.Location = New Point(336, 390)
        tper.Name = "tper"
        tper.Size = New Size(372, 31)
        tper.TabIndex = 60
        ' 
        ' intme
        ' 
        intme.Location = New Point(250, 335)
        intme.Name = "intme"
        intme.Size = New Size(207, 31)
        intme.TabIndex = 59
        ' 
        ' prsnn
        ' 
        prsnn.Location = New Point(460, 276)
        prsnn.Name = "prsnn"
        prsnn.Size = New Size(372, 31)
        prsnn.TabIndex = 58
        ' 
        ' cntt
        ' 
        cntt.Location = New Point(460, 219)
        cntt.Name = "cntt"
        cntt.Size = New Size(372, 31)
        cntt.TabIndex = 57
        ' 
        ' addd
        ' 
        addd.Location = New Point(338, 170)
        addd.Name = "addd"
        addd.Size = New Size(372, 31)
        addd.TabIndex = 56
        ' 
        ' nmme
        ' 
        nmme.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        nmme.Location = New Point(338, 125)
        nmme.Name = "nmme"
        nmme.Size = New Size(372, 31)
        nmme.TabIndex = 55
        ' 
        ' idno
        ' 
        idno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        idno.Location = New Point(332, 24)
        idno.Name = "idno"
        idno.Size = New Size(178, 31)
        idno.TabIndex = 54
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(140, 449)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 32)
        Label10.TabIndex = 53
        Label10.Text = "NO OF HOUR'S"
        ' 
        ' PType
        ' 
        PType.AutoSize = True
        PType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PType.Location = New Point(138, 390)
        PType.Name = "PType"
        PType.Size = New Size(186, 32)
        PType.TabIndex = 52
        PType.Text = "TOTAL PERSON"
        ' 
        ' tolbl
        ' 
        tolbl.AutoSize = True
        tolbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tolbl.Location = New Point(138, 335)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(106, 32)
        tolbl.TabIndex = 51
        tolbl.Text = "IN TIME"
        ' 
        ' DteLbl
        ' 
        DteLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(138, 273)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(302, 35)
        DteLbl.TabIndex = 50
        DteLbl.Text = "PERSON TO MEET NAME"
        ' 
        ' Dept
        ' 
        Dept.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(138, 219)
        Dept.Name = "Dept"
        Dept.Size = New Size(242, 31)
        Dept.TabIndex = 49
        Dept.Text = "CONTACT NUMBER"
        ' 
        ' Qtty
        ' 
        Qtty.AutoSize = True
        Qtty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Qtty.Location = New Point(138, 169)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(122, 32)
        Qtty.TabIndex = 48
        Qtty.Text = "ADDRESS"
        ' 
        ' Materl
        ' 
        Materl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Materl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(140, 125)
        Materl.Name = "Materl"
        Materl.Size = New Size(120, 31)
        Materl.TabIndex = 47
        Materl.Text = "NAME"
        ' 
        ' GtPssNo
        ' 
        GtPssNo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GtPssNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GtPssNo.Location = New Point(140, 76)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(186, 37)
        GtPssNo.TabIndex = 46
        GtPssNo.Text = "DATE"
        ' 
        ' IDNUM
        ' 
        IDNUM.AccessibleRole = AccessibleRole.IpAddress
        IDNUM.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        IDNUM.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        IDNUM.Location = New Point(140, 24)
        IDNUM.Name = "IDNUM"
        IDNUM.Size = New Size(168, 31)
        IDNUM.TabIndex = 45
        IDNUM.Text = "ID NUMBER"
        ' 
        ' VISITORS
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1323, 634)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "VISITORS"
        Text = "VISITORS"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents avgg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents outtme As TextBox
    Friend WithEvents From As Label
    Friend WithEvents Btnupd As Button
    Friend WithEvents Btndlte As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents nhrs As TextBox
    Friend WithEvents tper As TextBox
    Friend WithEvents intme As TextBox
    Friend WithEvents prsnn As TextBox
    Friend WithEvents cntt As TextBox
    Friend WithEvents addd As TextBox
    Friend WithEvents nmme As TextBox
    Friend WithEvents idno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PType As Label
    Friend WithEvents tolbl As Label
    Friend WithEvents DteLbl As Label
    Friend WithEvents Dept As Label
    Friend WithEvents Qtty As Label
    Friend WithEvents Materl As Label
    Friend WithEvents GtPssNo As Label
    Friend WithEvents IDNUM As Label
End Class
