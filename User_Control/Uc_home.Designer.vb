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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Uc_home))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        Timer1 = New Timer(components)
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        Guna2GradientPanel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2GradientPanel1.BackColor = Color.White
        Guna2GradientPanel1.BackgroundImage = CType(resources.GetObject("Guna2GradientPanel1.BackgroundImage"), Image)
        Guna2GradientPanel1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Location = New Point(65, 29)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(1208, 527)
        Guna2GradientPanel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
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
        ' Guna2Panel1
        ' 
        Guna2Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Location = New Point(65, 576)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(1208, 352)
        Guna2Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.Location = New Point(19, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(1169, 324)
        Label1.TabIndex = 0
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Uc_home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateBlue
        Controls.Add(Guna2Panel1)
        Controls.Add(Guna2GradientPanel1)
        Name = "Uc_home"
        Size = New Size(1319, 977)
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
End Class
