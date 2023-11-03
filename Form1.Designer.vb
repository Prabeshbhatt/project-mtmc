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
        GatePassToolStripMenuItem = New ToolStripMenuItem()
        InwardToolStripMenuItem = New ToolStripMenuItem()
        RGPToolStripMenuItem = New ToolStripMenuItem()
        OutwardToolStripMenuItem = New ToolStripMenuItem()
        RGPToolStripMenuItem1 = New ToolStripMenuItem()
        IncidentReportToolStripMenuItem = New ToolStripMenuItem()
        LostFoundToolStripMenuItem = New ToolStripMenuItem()
        WorkPermitToolStripMenuItem = New ToolStripMenuItem()
        lgn = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DeploymentToolStripMenuItem, CourierToolStripMenuItem, MetrialMovementToolStripMenuItem, IncidentReportToolStripMenuItem, LostFoundToolStripMenuItem, WorkPermitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1024, 31)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DeploymentToolStripMenuItem
        ' 
        DeploymentToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        DeploymentToolStripMenuItem.ForeColor = SystemColors.ControlText
        DeploymentToolStripMenuItem.Name = "DeploymentToolStripMenuItem"
        DeploymentToolStripMenuItem.ShowShortcutKeys = False
        DeploymentToolStripMenuItem.Size = New Size(127, 27)
        DeploymentToolStripMenuItem.Text = "Deployment"
        ' 
        ' CourierToolStripMenuItem
        ' 
        CourierToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        CourierToolStripMenuItem.Name = "CourierToolStripMenuItem"
        CourierToolStripMenuItem.Size = New Size(91, 27)
        CourierToolStripMenuItem.Text = "Courier"
        ' 
        ' MetrialMovementToolStripMenuItem
        ' 
        MetrialMovementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GatePassToolStripMenuItem})
        MetrialMovementToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        MetrialMovementToolStripMenuItem.Name = "MetrialMovementToolStripMenuItem"
        MetrialMovementToolStripMenuItem.Size = New Size(184, 27)
        MetrialMovementToolStripMenuItem.Text = "Metrial Movement"
        ' 
        ' GatePassToolStripMenuItem
        ' 
        GatePassToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InwardToolStripMenuItem, OutwardToolStripMenuItem})
        GatePassToolStripMenuItem.Name = "GatePassToolStripMenuItem"
        GatePassToolStripMenuItem.Size = New Size(270, 34)
        GatePassToolStripMenuItem.Text = "Gate Pass"
        ' 
        ' InwardToolStripMenuItem
        ' 
        InwardToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RGPToolStripMenuItem})
        InwardToolStripMenuItem.Name = "InwardToolStripMenuItem"
        InwardToolStripMenuItem.Size = New Size(185, 34)
        InwardToolStripMenuItem.Text = "Inward"
        ' 
        ' RGPToolStripMenuItem
        ' 
        RGPToolStripMenuItem.Name = "RGPToolStripMenuItem"
        RGPToolStripMenuItem.Size = New Size(214, 34)
        RGPToolStripMenuItem.Text = "RGP/NRGP"
        ' 
        ' OutwardToolStripMenuItem
        ' 
        OutwardToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RGPToolStripMenuItem1})
        OutwardToolStripMenuItem.Name = "OutwardToolStripMenuItem"
        OutwardToolStripMenuItem.Size = New Size(185, 34)
        OutwardToolStripMenuItem.Text = "Outward"
        ' 
        ' RGPToolStripMenuItem1
        ' 
        RGPToolStripMenuItem1.Name = "RGPToolStripMenuItem1"
        RGPToolStripMenuItem1.Size = New Size(214, 34)
        RGPToolStripMenuItem1.Text = "RGP/NRGP"
        ' 
        ' IncidentReportToolStripMenuItem
        ' 
        IncidentReportToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        IncidentReportToolStripMenuItem.Name = "IncidentReportToolStripMenuItem"
        IncidentReportToolStripMenuItem.Size = New Size(298, 27)
        IncidentReportToolStripMenuItem.Text = "Visitor's/Contractor's/Employee"
        ' 
        ' LostFoundToolStripMenuItem
        ' 
        LostFoundToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        LostFoundToolStripMenuItem.Name = "LostFoundToolStripMenuItem"
        LostFoundToolStripMenuItem.Size = New Size(115, 27)
        LostFoundToolStripMenuItem.Text = "Lost&Found"
        ' 
        ' WorkPermitToolStripMenuItem
        ' 
        WorkPermitToolStripMenuItem.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point)
        WorkPermitToolStripMenuItem.Name = "WorkPermitToolStripMenuItem"
        WorkPermitToolStripMenuItem.Size = New Size(152, 27)
        WorkPermitToolStripMenuItem.Text = "Patrolling Path"
        ' 
        ' lgn
        ' 
        lgn.Location = New Point(12, 274)
        lgn.Name = "lgn"
        lgn.Size = New Size(112, 34)
        lgn.TabIndex = 1
        lgn.Text = "login"
        lgn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1024, 433)
        Controls.Add(lgn)
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
    Friend WithEvents GatePassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutwardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LostFoundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WorkPermitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RGPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RGPToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lgn As Button
End Class
