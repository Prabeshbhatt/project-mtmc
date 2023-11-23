<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOMEPAGE_FOR_SECURITY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOMEPAGE_FOR_SECURITY))
        Panelmenu = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        imagehome = New PictureBox()
        patroll = New Button()
        lstfnd = New Button()
        cour = New Button()
        visit = New Button()
        matrl = New Button()
        Deploy = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Panelmenu.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(imagehome, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panelmenu
        ' 
        Panelmenu.AutoSize = True
        Panelmenu.BackColor = Color.FromArgb(CByte(51), CByte(51), CByte(76))
        Panelmenu.Controls.Add(Panel3)
        Panelmenu.Controls.Add(Panel2)
        Panelmenu.Controls.Add(Panel1)
        Panelmenu.Controls.Add(imagehome)
        Panelmenu.Controls.Add(patroll)
        Panelmenu.Controls.Add(lstfnd)
        Panelmenu.Controls.Add(cour)
        Panelmenu.Controls.Add(visit)
        Panelmenu.Controls.Add(matrl)
        Panelmenu.Controls.Add(Deploy)
        Panelmenu.Dock = DockStyle.Fill
        Panelmenu.Location = New Point(0, 0)
        Panelmenu.Name = "Panelmenu"
        Panelmenu.Size = New Size(1242, 638)
        Panelmenu.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.AutoSize = True
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Location = New Point(288, 63)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(954, 573)
        Panel3.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSize = True
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(287, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(955, 56)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.BackColor = Color.AliceBlue
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(895, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.Lime
        Panel1.Location = New Point(288, 55)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(0, 0)
        Panel1.TabIndex = 7
        ' 
        ' imagehome
        ' 
        imagehome.BorderStyle = BorderStyle.FixedSingle
        imagehome.Image = CType(resources.GetObject("imagehome.Image"), Image)
        imagehome.Location = New Point(0, 0)
        imagehome.Name = "imagehome"
        imagehome.Size = New Size(289, 172)
        imagehome.SizeMode = PictureBoxSizeMode.StretchImage
        imagehome.TabIndex = 2
        imagehome.TabStop = False
        ' 
        ' patroll
        ' 
        patroll.FlatAppearance.BorderSize = 0
        patroll.FlatStyle = FlatStyle.Flat
        patroll.ForeColor = Color.Gainsboro
        patroll.ImageAlign = ContentAlignment.MiddleLeft
        patroll.Location = New Point(6, 445)
        patroll.Name = "patroll"
        patroll.Padding = New Padding(12, 0, 0, 0)
        patroll.Size = New Size(214, 33)
        patroll.TabIndex = 6
        patroll.Text = "Patrolling Path"
        patroll.TextAlign = ContentAlignment.MiddleLeft
        patroll.TextImageRelation = TextImageRelation.ImageBeforeText
        patroll.UseVisualStyleBackColor = True
        ' 
        ' lstfnd
        ' 
        lstfnd.FlatAppearance.BorderSize = 0
        lstfnd.FlatStyle = FlatStyle.Flat
        lstfnd.ForeColor = Color.Gainsboro
        lstfnd.ImageAlign = ContentAlignment.MiddleLeft
        lstfnd.Location = New Point(6, 396)
        lstfnd.Name = "lstfnd"
        lstfnd.Padding = New Padding(12, 0, 0, 0)
        lstfnd.Size = New Size(214, 33)
        lstfnd.TabIndex = 5
        lstfnd.Text = "Lost&Found"
        lstfnd.TextAlign = ContentAlignment.MiddleLeft
        lstfnd.TextImageRelation = TextImageRelation.ImageBeforeText
        lstfnd.UseVisualStyleBackColor = True
        ' 
        ' cour
        ' 
        cour.FlatAppearance.BorderSize = 0
        cour.FlatStyle = FlatStyle.Flat
        cour.ForeColor = Color.Gainsboro
        cour.ImageAlign = ContentAlignment.MiddleLeft
        cour.Location = New Point(6, 345)
        cour.Name = "cour"
        cour.Padding = New Padding(12, 0, 0, 0)
        cour.Size = New Size(214, 33)
        cour.TabIndex = 4
        cour.Text = "Courier"
        cour.TextAlign = ContentAlignment.MiddleLeft
        cour.TextImageRelation = TextImageRelation.ImageBeforeText
        cour.UseVisualStyleBackColor = True
        ' 
        ' visit
        ' 
        visit.FlatAppearance.BorderSize = 0
        visit.FlatStyle = FlatStyle.Flat
        visit.ForeColor = Color.Gainsboro
        visit.ImageAlign = ContentAlignment.MiddleLeft
        visit.Location = New Point(6, 245)
        visit.Name = "visit"
        visit.Padding = New Padding(12, 0, 0, 0)
        visit.Size = New Size(276, 33)
        visit.TabIndex = 3
        visit.Text = "Visitor's/Contractor's/Employee"
        visit.TextAlign = ContentAlignment.MiddleLeft
        visit.TextImageRelation = TextImageRelation.ImageBeforeText
        visit.UseVisualStyleBackColor = True
        ' 
        ' matrl
        ' 
        matrl.FlatAppearance.BorderSize = 0
        matrl.FlatStyle = FlatStyle.Flat
        matrl.ForeColor = Color.Gainsboro
        matrl.ImageAlign = ContentAlignment.MiddleLeft
        matrl.Location = New Point(6, 294)
        matrl.Name = "matrl"
        matrl.Padding = New Padding(12, 0, 0, 0)
        matrl.Size = New Size(214, 33)
        matrl.TabIndex = 2
        matrl.Text = "Matrial Movement"
        matrl.TextAlign = ContentAlignment.MiddleLeft
        matrl.TextImageRelation = TextImageRelation.ImageBeforeText
        matrl.UseVisualStyleBackColor = True
        ' 
        ' Deploy
        ' 
        Deploy.FlatAppearance.BorderSize = 0
        Deploy.FlatStyle = FlatStyle.Flat
        Deploy.ForeColor = Color.Gainsboro
        Deploy.ImageAlign = ContentAlignment.MiddleLeft
        Deploy.Location = New Point(6, 188)
        Deploy.Name = "Deploy"
        Deploy.Padding = New Padding(12, 0, 0, 0)
        Deploy.Size = New Size(214, 33)
        Deploy.TabIndex = 1
        Deploy.Text = "Deployment"
        Deploy.TextAlign = ContentAlignment.MiddleLeft
        Deploy.TextImageRelation = TextImageRelation.ImageBeforeText
        Deploy.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' HOMEPAGE_FOR_SECURITY
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1242, 638)
        Controls.Add(Panelmenu)
        Name = "HOMEPAGE_FOR_SECURITY"
        Text = "HOMEPAGE_FOR_SECURITY"
        Panelmenu.ResumeLayout(False)
        Panelmenu.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(imagehome, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Deploy As Button
    Friend WithEvents patroll As Button
    Friend WithEvents lstfnd As Button
    Friend WithEvents cour As Button
    Friend WithEvents visit As Button
    Friend WithEvents matrl As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents imagehome As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
