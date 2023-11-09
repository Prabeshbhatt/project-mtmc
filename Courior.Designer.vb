<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courier
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
        outtme = New TextBox()
        From = New Label()
        BtnDlt = New Button()
        Btnupdt = New Button()
        Btnrst = New Button()
        Btnsave = New Button()
        nhrs = New TextBox()
        tper = New TextBox()
        intme = New TextBox()
        prsnn = New TextBox()
        cntt = New TextBox()
        addd = New TextBox()
        nmme = New TextBox()
        Panel2 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        avgg = New TextBox()
        Label1 = New Label()
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
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' outtme
        ' 
        outtme.Location = New Point(578, 244)
        outtme.Name = "outtme"
        outtme.Size = New Size(207, 31)
        outtme.TabIndex = 41
        ' 
        ' From
        ' 
        From.AutoSize = True
        From.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        From.Location = New Point(427, 243)
        From.Name = "From"
        From.Size = New Size(128, 32)
        From.TabIndex = 40
        From.Text = "OUT TIME"
        ' 
        ' BtnDlt
        ' 
        BtnDlt.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDlt.Location = New Point(204, 410)
        BtnDlt.Name = "BtnDlt"
        BtnDlt.Size = New Size(112, 34)
        BtnDlt.TabIndex = 39
        BtnDlt.Text = "DELETE"
        BtnDlt.UseVisualStyleBackColor = True
        ' 
        ' Btnupdt
        ' 
        Btnupdt.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btnupdt.Location = New Point(347, 411)
        Btnupdt.Name = "Btnupdt"
        Btnupdt.Size = New Size(112, 34)
        Btnupdt.TabIndex = 38
        Btnupdt.Text = "UPDATE"
        Btnupdt.UseVisualStyleBackColor = True
        ' 
        ' Btnrst
        ' 
        Btnrst.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnrst.Location = New Point(487, 411)
        Btnrst.Name = "Btnrst"
        Btnrst.Size = New Size(112, 34)
        Btnrst.TabIndex = 37
        Btnrst.Text = "RESET"
        Btnrst.UseVisualStyleBackColor = True
        ' 
        ' Btnsave
        ' 
        Btnsave.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Btnsave.Location = New Point(625, 411)
        Btnsave.Name = "Btnsave"
        Btnsave.Size = New Size(112, 34)
        Btnsave.TabIndex = 36
        Btnsave.Text = "SAVE"
        Btnsave.UseVisualStyleBackColor = True
        ' 
        ' nhrs
        ' 
        nhrs.Location = New Point(260, 318)
        nhrs.Name = "nhrs"
        nhrs.Size = New Size(372, 31)
        nhrs.TabIndex = 35
        ' 
        ' tper
        ' 
        tper.Location = New Point(260, 281)
        tper.Name = "tper"
        tper.Size = New Size(372, 31)
        tper.TabIndex = 34
        ' 
        ' intme
        ' 
        intme.Location = New Point(174, 243)
        intme.Name = "intme"
        intme.Size = New Size(207, 31)
        intme.TabIndex = 33
        ' 
        ' prsnn
        ' 
        prsnn.Location = New Point(384, 207)
        prsnn.Name = "prsnn"
        prsnn.Size = New Size(372, 31)
        prsnn.TabIndex = 32
        ' 
        ' cntt
        ' 
        cntt.Location = New Point(324, 170)
        cntt.Name = "cntt"
        cntt.Size = New Size(372, 31)
        cntt.TabIndex = 31
        ' 
        ' addd
        ' 
        addd.Location = New Point(260, 134)
        addd.Name = "addd"
        addd.Size = New Size(372, 31)
        addd.TabIndex = 30
        ' 
        ' nmme
        ' 
        nmme.Location = New Point(260, 99)
        nmme.Name = "nmme"
        nmme.Size = New Size(372, 31)
        nmme.TabIndex = 29
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(avgg)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(outtme)
        Panel2.Controls.Add(From)
        Panel2.Controls.Add(BtnDlt)
        Panel2.Controls.Add(Btnupdt)
        Panel2.Controls.Add(Btnrst)
        Panel2.Controls.Add(Btnsave)
        Panel2.Controls.Add(nhrs)
        Panel2.Controls.Add(tper)
        Panel2.Controls.Add(intme)
        Panel2.Controls.Add(prsnn)
        Panel2.Controls.Add(cntt)
        Panel2.Controls.Add(addd)
        Panel2.Controls.Add(nmme)
        Panel2.Controls.Add(idno)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(PType)
        Panel2.Controls.Add(tolbl)
        Panel2.Controls.Add(DteLbl)
        Panel2.Controls.Add(Dept)
        Panel2.Controls.Add(Qtty)
        Panel2.Controls.Add(Materl)
        Panel2.Controls.Add(GtPssNo)
        Panel2.Controls.Add(IDNUM)
        Panel2.Location = New Point(23, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(977, 489)
        Panel2.TabIndex = 20
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(260, 64)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(372, 31)
        DateTimePicker1.TabIndex = 44
        ' 
        ' avgg
        ' 
        avgg.Location = New Point(277, 359)
        avgg.Name = "avgg"
        avgg.Size = New Size(372, 31)
        avgg.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(62, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 32)
        Label1.TabIndex = 42
        Label1.Text = "AVG TIME SPENT"
        ' 
        ' idno
        ' 
        idno.Location = New Point(260, 29)
        idno.Name = "idno"
        idno.Size = New Size(372, 31)
        idno.TabIndex = 27
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(62, 315)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 32)
        Label10.TabIndex = 26
        Label10.Text = "NO OF HOUR'S"
        ' 
        ' PType
        ' 
        PType.AutoSize = True
        PType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        PType.Location = New Point(62, 281)
        PType.Name = "PType"
        PType.Size = New Size(186, 32)
        PType.TabIndex = 25
        PType.Text = "TOTAL PERSON"
        ' 
        ' tolbl
        ' 
        tolbl.AutoSize = True
        tolbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tolbl.Location = New Point(62, 243)
        tolbl.Name = "tolbl"
        tolbl.Size = New Size(106, 32)
        tolbl.TabIndex = 24
        tolbl.Text = "IN TIME"
        ' 
        ' DteLbl
        ' 
        DteLbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DteLbl.Location = New Point(62, 208)
        DteLbl.Name = "DteLbl"
        DteLbl.Size = New Size(302, 35)
        DteLbl.TabIndex = 23
        DteLbl.Text = "PERSON TO MEET NAME"
        ' 
        ' Dept
        ' 
        Dept.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Dept.Location = New Point(62, 171)
        Dept.Name = "Dept"
        Dept.Size = New Size(242, 31)
        Dept.TabIndex = 22
        Dept.Text = "CONTACT NUMBER"
        ' 
        ' Qtty
        ' 
        Qtty.AutoSize = True
        Qtty.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Qtty.Location = New Point(62, 136)
        Qtty.Name = "Qtty"
        Qtty.Size = New Size(122, 32)
        Qtty.TabIndex = 21
        Qtty.Text = "ADDRESS"
        ' 
        ' Materl
        ' 
        Materl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Materl.Location = New Point(62, 102)
        Materl.Name = "Materl"
        Materl.Size = New Size(217, 31)
        Materl.TabIndex = 20
        Materl.Text = "NAME"
        ' 
        ' GtPssNo
        ' 
        GtPssNo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GtPssNo.Location = New Point(62, 63)
        GtPssNo.Name = "GtPssNo"
        GtPssNo.Size = New Size(242, 37)
        GtPssNo.TabIndex = 19
        GtPssNo.Text = "DATE"
        ' 
        ' IDNUM
        ' 
        IDNUM.AccessibleRole = AccessibleRole.IpAddress
        IDNUM.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        IDNUM.Location = New Point(62, 29)
        IDNUM.Name = "IDNUM"
        IDNUM.Size = New Size(201, 31)
        IDNUM.TabIndex = 18
        IDNUM.Text = "ID NUMBER"
        ' 
        ' Courier
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1026, 533)
        Controls.Add(Panel2)
        Name = "Courier"
        Text = "Courier"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents outtme As TextBox
    Friend WithEvents From As Label
    Friend WithEvents BtnDlt As Button
    Friend WithEvents Btnupdt As Button
    Friend WithEvents Btnrst As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents nhrs As TextBox
    Friend WithEvents tper As TextBox
    Friend WithEvents intme As TextBox
    Friend WithEvents prsnn As TextBox
    Friend WithEvents cntt As TextBox
    Friend WithEvents addd As TextBox
    Friend WithEvents nmme As TextBox
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents avgg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
