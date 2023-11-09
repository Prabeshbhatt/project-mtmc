<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        DeploymentToolStripMenuItem = New ToolStripMenuItem()
        CourierToolStripMenuItem = New ToolStripMenuItem()
        MetrialMovementToolStripMenuItem = New ToolStripMenuItem()
        INWARDToolStripMenuItem = New ToolStripMenuItem()
        OUTWARDToolStripMenuItem = New ToolStripMenuItem()
        RGPNRGPToolStripMenuItem = New ToolStripMenuItem()
        IncidentReportToolStripMenuItem = New ToolStripMenuItem()
        LostFoundToolStripMenuItem = New ToolStripMenuItem()
        WorkPermitToolStripMenuItem = New ToolStripMenuItem()
        Lgn = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DeploymentToolStripMenuItem, CourierToolStripMenuItem, MetrialMovementToolStripMenuItem, IncidentReportToolStripMenuItem, LostFoundToolStripMenuItem, WorkPermitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1024, 32)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DeploymentToolStripMenuItem
        ' 
        DeploymentToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DeploymentToolStripMenuItem.ForeColor = SystemColors.ControlText
        DeploymentToolStripMenuItem.Name = "DeploymentToolStripMenuItem"
        DeploymentToolStripMenuItem.ShowShortcutKeys = False
        DeploymentToolStripMenuItem.Size = New Size(127, 28)
        DeploymentToolStripMenuItem.Text = "Deployment"
        ' 
        ' CourierToolStripMenuItem
        ' 
        CourierToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        CourierToolStripMenuItem.Name = "CourierToolStripMenuItem"
        CourierToolStripMenuItem.Size = New Size(91, 28)
        CourierToolStripMenuItem.Text = "Courier"
        ' 
        ' MetrialMovementToolStripMenuItem
        ' 
        MetrialMovementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {INWARDToolStripMenuItem, OUTWARDToolStripMenuItem})
        MetrialMovementToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        MetrialMovementToolStripMenuItem.Name = "MetrialMovementToolStripMenuItem"
        MetrialMovementToolStripMenuItem.Size = New Size(184, 28)
        MetrialMovementToolStripMenuItem.Text = "Metrial Movement"
        ' 
        ' INWARDToolStripMenuItem
        ' 
        INWARDToolStripMenuItem.Name = "INWARDToolStripMenuItem"
        INWARDToolStripMenuItem.Size = New Size(212, 34)
        INWARDToolStripMenuItem.Text = "INWARD"
        ' 
        ' OUTWARDToolStripMenuItem
        ' 
        OUTWARDToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RGPNRGPToolStripMenuItem})
        OUTWARDToolStripMenuItem.Name = "OUTWARDToolStripMenuItem"
        OUTWARDToolStripMenuItem.Size = New Size(212, 34)
        OUTWARDToolStripMenuItem.Text = "OUTWARD"
        ' 
        ' RGPNRGPToolStripMenuItem
        ' 
        RGPNRGPToolStripMenuItem.Name = "RGPNRGPToolStripMenuItem"
        RGPNRGPToolStripMenuItem.Size = New Size(217, 34)
        RGPNRGPToolStripMenuItem.Text = "RGP & NRGP"
        ' 
        ' IncidentReportToolStripMenuItem
        ' 
        IncidentReportToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        IncidentReportToolStripMenuItem.Name = "IncidentReportToolStripMenuItem"
        IncidentReportToolStripMenuItem.Size = New Size(298, 28)
        IncidentReportToolStripMenuItem.Text = "Visitor's/Contractor's/Employee"
        ' 
        ' LostFoundToolStripMenuItem
        ' 
        LostFoundToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        LostFoundToolStripMenuItem.Name = "LostFoundToolStripMenuItem"
        LostFoundToolStripMenuItem.Size = New Size(115, 28)
        LostFoundToolStripMenuItem.Text = "Lost&Found"
        ' 
        ' WorkPermitToolStripMenuItem
        ' 
        WorkPermitToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        WorkPermitToolStripMenuItem.Name = "WorkPermitToolStripMenuItem"
        WorkPermitToolStripMenuItem.Size = New Size(152, 28)
        WorkPermitToolStripMenuItem.Text = "Patrolling Path"
        ' 
        ' Lgn
        ' 
        Lgn.Location = New Point(12, 274)
        Lgn.Name = "Lgn"
        Lgn.Size = New Size(112, 34)
        Lgn.TabIndex = 1
        Lgn.Text = "login"
        Lgn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1024, 433)
        Controls.Add(Lgn)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "  "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DeploymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetrialMovementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LostFoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkPermitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lgn As Button
    Friend WithEvents INWARDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OUTWARDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RGPNRGPToolStripMenuItem As ToolStripMenuItem
End Class
