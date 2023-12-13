<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalHomePage
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinalHomePage))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Panel1 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        MenuStrip1 = New MenuStrip()
        MaterialMovementToolStripMenuItem = New ToolStripMenuItem()
        InwardToolStripMenuItem = New ToolStripMenuItem()
        OutwardToolStripMenuItem = New ToolStripMenuItem()
        Panel3 = New Panel()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1096, 93)
        Panel1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(995, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(87, 78)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.White
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(924, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(49, 46)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Font = New Font("Elephant", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(285, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(589, 78)
        Label1.TabIndex = 4
        Label1.Text = "Manipal-Tata Medical College"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(227, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Indigo
        Panel2.Controls.Add(Guna2Button4)
        Panel2.Controls.Add(Guna2Button1)
        Panel2.Controls.Add(Guna2Button3)
        Panel2.Controls.Add(Guna2Button2)
        Panel2.Controls.Add(MenuStrip1)
        Panel2.Location = New Point(0, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1095, 73)
        Panel2.TabIndex = 4
        ' 
        ' Guna2Button4
        ' 
        Guna2Button4.Anchor = AnchorStyles.Top
        Guna2Button4.Animated = True
        Guna2Button4.AnimatedGIF = True
        Guna2Button4.BorderColor = Color.SlateBlue
        Guna2Button4.CheckedState.CustomBorderColor = Color.Red
        Guna2Button4.CustomBorderThickness = New Padding(0, 0, 0, 2)
        Guna2Button4.CustomizableEdges = CustomizableEdges1
        Guna2Button4.DisabledState.BorderColor = Color.DarkGray
        Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button4.FillColor = Color.Transparent
        Guna2Button4.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button4.ForeColor = Color.White
        Guna2Button4.HoverState.CustomBorderColor = Color.Red
        Guna2Button4.Location = New Point(619, 2)
        Guna2Button4.Name = "Guna2Button4"
        Guna2Button4.PressedColor = Color.WhiteSmoke
        Guna2Button4.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button4.Size = New Size(209, 68)
        Guna2Button4.TabIndex = 3
        Guna2Button4.Text = "Lost and Found"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Anchor = AnchorStyles.Top
        Guna2Button1.Animated = True
        Guna2Button1.AnimatedGIF = True
        Guna2Button1.BackColor = Color.Transparent
        Guna2Button1.BorderColor = Color.Transparent
        Guna2Button1.CheckedState.CustomBorderColor = Color.Red
        Guna2Button1.CustomBorderThickness = New Padding(0, 0, 0, 2)
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.HoverState.CustomBorderColor = Color.Red
        Guna2Button1.Location = New Point(3, 2)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.PressedColor = Color.GhostWhite
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(209, 68)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Deployment"
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.Anchor = AnchorStyles.Top
        Guna2Button3.Animated = True
        Guna2Button3.AnimatedGIF = True
        Guna2Button3.BorderColor = Color.SlateBlue
        Guna2Button3.CheckedState.CustomBorderColor = Color.Red
        Guna2Button3.CustomBorderThickness = New Padding(0, 0, 0, 2)
        Guna2Button3.CustomizableEdges = CustomizableEdges5
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.Transparent
        Guna2Button3.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.HoverState.CustomBorderColor = Color.Red
        Guna2Button3.Location = New Point(414, 3)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.PressedColor = Color.WhiteSmoke
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button3.Size = New Size(209, 68)
        Guna2Button3.TabIndex = 2
        Guna2Button3.Text = "Courier"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Anchor = AnchorStyles.Top
        Guna2Button2.Animated = True
        Guna2Button2.AnimatedGIF = True
        Guna2Button2.CheckedState.CustomBorderColor = Color.Red
        Guna2Button2.CustomBorderThickness = New Padding(0, 0, 0, 2)
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.HoverState.CustomBorderColor = Color.Red
        Guna2Button2.Location = New Point(215, 3)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.PressedColor = Color.GhostWhite
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(209, 68)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "Visitors"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Anchor = AnchorStyles.Top
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MaterialMovementToolStripMenuItem})
        MenuStrip1.Location = New Point(857, 19)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(224, 31)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MaterialMovementToolStripMenuItem
        ' 
        MaterialMovementToolStripMenuItem.BackColor = Color.Indigo
        MaterialMovementToolStripMenuItem.BackgroundImageLayout = ImageLayout.None
        MaterialMovementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InwardToolStripMenuItem, OutwardToolStripMenuItem})
        MaterialMovementToolStripMenuItem.Font = New Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point)
        MaterialMovementToolStripMenuItem.ForeColor = Color.White
        MaterialMovementToolStripMenuItem.Name = "MaterialMovementToolStripMenuItem"
        MaterialMovementToolStripMenuItem.Size = New Size(216, 27)
        MaterialMovementToolStripMenuItem.Text = "Material Movement"
        ' 
        ' InwardToolStripMenuItem
        ' 
        InwardToolStripMenuItem.BackColor = Color.Indigo
        InwardToolStripMenuItem.ForeColor = Color.White
        InwardToolStripMenuItem.Name = "InwardToolStripMenuItem"
        InwardToolStripMenuItem.Size = New Size(193, 34)
        InwardToolStripMenuItem.Text = "Inward"
        ' 
        ' OutwardToolStripMenuItem
        ' 
        OutwardToolStripMenuItem.BackColor = Color.Indigo
        OutwardToolStripMenuItem.ForeColor = Color.White
        OutwardToolStripMenuItem.Name = "OutwardToolStripMenuItem"
        OutwardToolStripMenuItem.Size = New Size(193, 34)
        OutwardToolStripMenuItem.Text = "Outward"
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Button3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1096, 610)
        Panel3.TabIndex = 5
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 0
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FinalHomePage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1096, 610)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "FinalHomePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FinalHomePage"
        TransparencyKey = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MaterialMovementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
End Class
