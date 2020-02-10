<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grinder
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grinder))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Config = New System.Windows.Forms.ToolStripMenuItem()
        Me.GitHub = New System.Windows.Forms.ToolStripMenuItem()
        Me.Donate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMDHelp = New System.Windows.Forms.Button()
        Me.CMDStart = New System.Windows.Forms.Button()
        Me.CMDMenu = New System.Windows.Forms.Button()
        Me.CMDRunClient = New System.Windows.Forms.Button()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(80, 8)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(87, 16)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Not Running"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Config, Me.GitHub, Me.Donate})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(181, 70)
        '
        'Config
        '
        Me.Config.Image = Global.Grinder.My.Resources.Resources.Configuration
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(180, 22)
        Me.Config.Text = "Open Configuration"
        '
        'GitHub
        '
        Me.GitHub.Image = Global.Grinder.My.Resources.Resources.GitHub1
        Me.GitHub.Name = "GitHub"
        Me.GitHub.Size = New System.Drawing.Size(180, 22)
        Me.GitHub.Text = "Open GitHub"
        '
        'Donate
        '
        Me.Donate.Image = Global.Grinder.My.Resources.Resources.Donation
        Me.Donate.Name = "Donate"
        Me.Donate.Size = New System.Drawing.Size(180, 22)
        Me.Donate.Text = "Donate for Grinder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Status:"
        '
        'CMDHelp
        '
        Me.CMDHelp.BackColor = System.Drawing.Color.White
        Me.CMDHelp.BackgroundImage = Global.Grinder.My.Resources.Resources.Help
        Me.CMDHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDHelp.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDHelp.ForeColor = System.Drawing.Color.Black
        Me.CMDHelp.Location = New System.Drawing.Point(117, 29)
        Me.CMDHelp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDHelp.Name = "CMDHelp"
        Me.CMDHelp.Size = New System.Drawing.Size(50, 50)
        Me.CMDHelp.TabIndex = 92
        Me.CMDHelp.UseVisualStyleBackColor = False
        '
        'CMDStart
        '
        Me.CMDStart.BackColor = System.Drawing.Color.White
        Me.CMDStart.BackgroundImage = Global.Grinder.My.Resources.Resources.Start
        Me.CMDStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDStart.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDStart.ForeColor = System.Drawing.Color.Black
        Me.CMDStart.Location = New System.Drawing.Point(9, 29)
        Me.CMDStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDStart.Name = "CMDStart"
        Me.CMDStart.Size = New System.Drawing.Size(50, 50)
        Me.CMDStart.TabIndex = 90
        Me.CMDStart.UseVisualStyleBackColor = False
        '
        'CMDMenu
        '
        Me.CMDMenu.BackColor = System.Drawing.Color.White
        Me.CMDMenu.BackgroundImage = Global.Grinder.My.Resources.Resources.Configuration
        Me.CMDMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDMenu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDMenu.ForeColor = System.Drawing.Color.Black
        Me.CMDMenu.Location = New System.Drawing.Point(62, 29)
        Me.CMDMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDMenu.Name = "CMDMenu"
        Me.CMDMenu.Size = New System.Drawing.Size(50, 50)
        Me.CMDMenu.TabIndex = 91
        Me.CMDMenu.UseVisualStyleBackColor = False
        '
        'CMDRunClient
        '
        Me.CMDRunClient.BackColor = System.Drawing.Color.White
        Me.CMDRunClient.BackgroundImage = Global.Grinder.My.Resources.Resources.Start
        Me.CMDRunClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDRunClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDRunClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDRunClient.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDRunClient.ForeColor = System.Drawing.Color.Black
        Me.CMDRunClient.Location = New System.Drawing.Point(173, 29)
        Me.CMDRunClient.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDRunClient.Name = "CMDRunClient"
        Me.CMDRunClient.Size = New System.Drawing.Size(50, 50)
        Me.CMDRunClient.TabIndex = 93
        Me.CMDRunClient.UseVisualStyleBackColor = False
        '
        'Grinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(231, 88)
        Me.ContextMenuStrip = Me.CMS
        Me.Controls.Add(Me.CMDRunClient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.CMDHelp)
        Me.Controls.Add(Me.CMDStart)
        Me.Controls.Add(Me.CMDMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Grinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grinder"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMDHelp As Button
    Friend WithEvents CMDStart As Button
    Friend WithEvents CMDMenu As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents CMS As ContextMenuStrip
    Friend WithEvents Config As ToolStripMenuItem
    Friend WithEvents GitHub As ToolStripMenuItem
    Friend WithEvents Donate As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CMDRunClient As Button
End Class
