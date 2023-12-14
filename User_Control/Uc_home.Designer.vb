<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_home
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Uc_home))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Guna2ContainerControl1 = New Guna.UI2.WinForms.Guna2ContainerControl()
        Label1 = New Label()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        Timer1 = New Timer(components)
        Guna2CustomGradientPanel1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2CustomGradientPanel1
        ' 
        Guna2CustomGradientPanel1.Anchor = AnchorStyles.None
        Guna2CustomGradientPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Guna2CustomGradientPanel1.BackgroundImage = CType(resources.GetObject("Guna2CustomGradientPanel1.BackgroundImage"), Image)
        Guna2CustomGradientPanel1.BackgroundImageLayout = ImageLayout.Zoom
        Guna2CustomGradientPanel1.Controls.Add(Guna2ContainerControl1)
        Guna2CustomGradientPanel1.Controls.Add(Label1)
        Guna2CustomGradientPanel1.CustomizableEdges = CustomizableEdges3
        Guna2CustomGradientPanel1.Location = New Point(65, 29)
        Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CustomGradientPanel1.Size = New Size(1208, 1458)
        Guna2CustomGradientPanel1.TabIndex = 0
        ' 
        ' Guna2ContainerControl1
        ' 
        Guna2ContainerControl1.BackColor = Color.LightSlateGray
        Guna2ContainerControl1.CustomizableEdges = CustomizableEdges1
        Guna2ContainerControl1.Location = New Point(598, 912)
        Guna2ContainerControl1.Name = "Guna2ContainerControl1"
        Guna2ContainerControl1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ContainerControl1.Size = New Size(300, 484)
        Guna2ContainerControl1.TabIndex = 1
        Guna2ContainerControl1.Text = "Guna2ContainerControl1"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 546)
        Label1.Name = "Label1"
        Label1.Size = New Size(1178, 401)
        Label1.TabIndex = 0
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Anchor = AnchorStyles.None
        Guna2GradientPanel1.BackColor = Color.White
        Guna2GradientPanel1.BackgroundImage = CType(resources.GetObject("Guna2GradientPanel1.BackgroundImage"), Image)
        Guna2GradientPanel1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.Location = New Point(65, 29)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.Size = New Size(1208, 527)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(3, 472)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 55)
        Label2.TabIndex = 0
        Label2.Text = "MTMC Jamsedhpur"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Uc_home
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        Controls.Add(Guna2GradientPanel1)
        Controls.Add(Guna2CustomGradientPanel1)
        Name = "Uc_home"
        Size = New Size(1319, 977)
        Guna2CustomGradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ContainerControl1 As Guna.UI2.WinForms.Guna2ContainerControl
End Class
