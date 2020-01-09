<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
        Me.GBAttackKeys = New System.Windows.Forms.GroupBox()
        Me.CLBAttack = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CLBBuff = New System.Windows.Forms.CheckedListBox()
        Me.TBAttackTime = New System.Windows.Forms.TextBox()
        Me.TBBuffTime = New System.Windows.Forms.TextBox()
        Me.LBLAttackTime = New System.Windows.Forms.Label()
        Me.LBLBuffTime = New System.Windows.Forms.Label()
        Me.LBLBuffbar = New System.Windows.Forms.Label()
        Me.LBLAttackbar = New System.Windows.Forms.Label()
        Me.CBBuffBar = New System.Windows.Forms.ComboBox()
        Me.CBAttackBar = New System.Windows.Forms.ComboBox()
        Me.LBLEnableRebuff = New System.Windows.Forms.Label()
        Me.CBBuff = New System.Windows.Forms.ComboBox()
        Me.CMDLoad = New System.Windows.Forms.Button()
        Me.CMDSave = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.LBLAttackLoops = New System.Windows.Forms.Label()
        Me.TBAttackLoops = New System.Windows.Forms.TextBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.GBAttackKeys.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBAttackKeys
        '
        Me.GBAttackKeys.Controls.Add(Me.CLBAttack)
        Me.GBAttackKeys.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBAttackKeys.Location = New System.Drawing.Point(0, 0)
        Me.GBAttackKeys.Name = "GBAttackKeys"
        Me.GBAttackKeys.Size = New System.Drawing.Size(271, 193)
        Me.GBAttackKeys.TabIndex = 0
        Me.GBAttackKeys.TabStop = False
        Me.GBAttackKeys.Text = "Attack Keys"
        '
        'CLBAttack
        '
        Me.CLBAttack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLBAttack.FormattingEnabled = True
        Me.CLBAttack.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CLBAttack.Location = New System.Drawing.Point(3, 16)
        Me.CLBAttack.Name = "CLBAttack"
        Me.CLBAttack.Size = New System.Drawing.Size(265, 174)
        Me.CLBAttack.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CLBBuff)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(271, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 193)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buff Keys"
        '
        'CLBBuff
        '
        Me.CLBBuff.Dock = System.Windows.Forms.DockStyle.Right
        Me.CLBBuff.FormattingEnabled = True
        Me.CLBBuff.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CLBBuff.Location = New System.Drawing.Point(3, 16)
        Me.CLBBuff.Name = "CLBBuff"
        Me.CLBBuff.Size = New System.Drawing.Size(265, 174)
        Me.CLBBuff.TabIndex = 1
        '
        'TBAttackTime
        '
        Me.TBAttackTime.Location = New System.Drawing.Point(188, 102)
        Me.TBAttackTime.Name = "TBAttackTime"
        Me.TBAttackTime.Size = New System.Drawing.Size(83, 20)
        Me.TBAttackTime.TabIndex = 2
        '
        'TBBuffTime
        '
        Me.TBBuffTime.Enabled = False
        Me.TBBuffTime.Location = New System.Drawing.Point(408, 102)
        Me.TBBuffTime.Name = "TBBuffTime"
        Me.TBBuffTime.Size = New System.Drawing.Size(87, 20)
        Me.TBBuffTime.TabIndex = 3
        '
        'LBLAttackTime
        '
        Me.LBLAttackTime.AutoSize = True
        Me.LBLAttackTime.Location = New System.Drawing.Point(45, 105)
        Me.LBLAttackTime.Name = "LBLAttackTime"
        Me.LBLAttackTime.Size = New System.Drawing.Size(137, 13)
        Me.LBLAttackTime.TabIndex = 4
        Me.LBLAttackTime.Text = "Time between attacks (ms):"
        '
        'LBLBuffTime
        '
        Me.LBLBuffTime.AutoSize = True
        Me.LBLBuffTime.Location = New System.Drawing.Point(277, 105)
        Me.LBLBuffTime.Name = "LBLBuffTime"
        Me.LBLBuffTime.Size = New System.Drawing.Size(125, 13)
        Me.LBLBuffTime.TabIndex = 5
        Me.LBLBuffTime.Text = "Time between buffs (ms):"
        '
        'LBLBuffbar
        '
        Me.LBLBuffbar.AutoSize = True
        Me.LBLBuffbar.Location = New System.Drawing.Point(358, 78)
        Me.LBLBuffbar.Name = "LBLBuffbar"
        Me.LBLBuffbar.Size = New System.Drawing.Size(44, 13)
        Me.LBLBuffbar.TabIndex = 6
        Me.LBLBuffbar.Text = "Buffbar:"
        '
        'LBLAttackbar
        '
        Me.LBLAttackbar.AutoSize = True
        Me.LBLAttackbar.Location = New System.Drawing.Point(126, 78)
        Me.LBLAttackbar.Name = "LBLAttackbar"
        Me.LBLAttackbar.Size = New System.Drawing.Size(56, 13)
        Me.LBLAttackbar.TabIndex = 7
        Me.LBLAttackbar.Text = "Attackbar:"
        '
        'CBBuffBar
        '
        Me.CBBuffBar.Enabled = False
        Me.CBBuffBar.FormattingEnabled = True
        Me.CBBuffBar.Items.AddRange(New Object() {"F1", "F2", "F3", "F4"})
        Me.CBBuffBar.Location = New System.Drawing.Point(408, 75)
        Me.CBBuffBar.Name = "CBBuffBar"
        Me.CBBuffBar.Size = New System.Drawing.Size(87, 21)
        Me.CBBuffBar.TabIndex = 8
        '
        'CBAttackBar
        '
        Me.CBAttackBar.Enabled = False
        Me.CBAttackBar.FormattingEnabled = True
        Me.CBAttackBar.Items.AddRange(New Object() {"F1", "F2", "F3", "F4"})
        Me.CBAttackBar.Location = New System.Drawing.Point(188, 75)
        Me.CBAttackBar.Name = "CBAttackBar"
        Me.CBAttackBar.Size = New System.Drawing.Size(83, 21)
        Me.CBAttackBar.TabIndex = 9
        '
        'LBLEnableRebuff
        '
        Me.LBLEnableRebuff.AutoSize = True
        Me.LBLEnableRebuff.Location = New System.Drawing.Point(324, 52)
        Me.LBLEnableRebuff.Name = "LBLEnableRebuff"
        Me.LBLEnableRebuff.Size = New System.Drawing.Size(78, 13)
        Me.LBLEnableRebuff.TabIndex = 10
        Me.LBLEnableRebuff.Text = "Enable Rebuff:"
        '
        'CBBuff
        '
        Me.CBBuff.FormattingEnabled = True
        Me.CBBuff.Items.AddRange(New Object() {"Yes", "No"})
        Me.CBBuff.Location = New System.Drawing.Point(408, 48)
        Me.CBBuff.Name = "CBBuff"
        Me.CBBuff.Size = New System.Drawing.Size(87, 21)
        Me.CBBuff.TabIndex = 11
        '
        'CMDLoad
        '
        Me.CMDLoad.BackColor = System.Drawing.Color.White
        Me.CMDLoad.BackgroundImage = Global.Grinder.My.Resources.Resources.Load_Config
        Me.CMDLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDLoad.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDLoad.ForeColor = System.Drawing.Color.Black
        Me.CMDLoad.Location = New System.Drawing.Point(408, 13)
        Me.CMDLoad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDLoad.Name = "CMDLoad"
        Me.CMDLoad.Size = New System.Drawing.Size(25, 25)
        Me.CMDLoad.TabIndex = 27
        Me.CMDLoad.UseVisualStyleBackColor = False
        '
        'CMDSave
        '
        Me.CMDSave.BackColor = System.Drawing.Color.White
        Me.CMDSave.BackgroundImage = Global.Grinder.My.Resources.Resources.Save_Config
        Me.CMDSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CMDSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSave.ForeColor = System.Drawing.Color.Black
        Me.CMDSave.Location = New System.Drawing.Point(439, 13)
        Me.CMDSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CMDSave.Name = "CMDSave"
        Me.CMDSave.Size = New System.Drawing.Size(25, 25)
        Me.CMDSave.TabIndex = 26
        Me.CMDSave.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.White
        Me.cmdExit.BackgroundImage = Global.Grinder.My.Resources.Resources.Exit_Config
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Location = New System.Drawing.Point(470, 13)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(25, 25)
        Me.cmdExit.TabIndex = 25
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'LBLAttackLoops
        '
        Me.LBLAttackLoops.AutoSize = True
        Me.LBLAttackLoops.Location = New System.Drawing.Point(113, 52)
        Me.LBLAttackLoops.Name = "LBLAttackLoops"
        Me.LBLAttackLoops.Size = New System.Drawing.Size(69, 13)
        Me.LBLAttackLoops.TabIndex = 28
        Me.LBLAttackLoops.Text = "Attack loops:"
        '
        'TBAttackLoops
        '
        Me.TBAttackLoops.Location = New System.Drawing.Point(188, 49)
        Me.TBAttackLoops.Name = "TBAttackLoops"
        Me.TBAttackLoops.Size = New System.Drawing.Size(83, 20)
        Me.TBAttackLoops.TabIndex = 29
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.GroupBox2)
        Me.Panel.Controls.Add(Me.GBAttackKeys)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel.Location = New System.Drawing.Point(0, 128)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(503, 193)
        Me.Panel.TabIndex = 30
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 321)
        Me.Controls.Add(Me.CMDLoad)
        Me.Controls.Add(Me.CMDSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.TBAttackLoops)
        Me.Controls.Add(Me.LBLAttackLoops)
        Me.Controls.Add(Me.CBBuff)
        Me.Controls.Add(Me.CBBuffBar)
        Me.Controls.Add(Me.LBLEnableRebuff)
        Me.Controls.Add(Me.CBAttackBar)
        Me.Controls.Add(Me.LBLAttackbar)
        Me.Controls.Add(Me.LBLBuffbar)
        Me.Controls.Add(Me.LBLBuffTime)
        Me.Controls.Add(Me.LBLAttackTime)
        Me.Controls.Add(Me.TBBuffTime)
        Me.Controls.Add(Me.TBAttackTime)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Config"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grinder Configuration"
        Me.GBAttackKeys.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBAttackKeys As GroupBox
    Friend WithEvents CLBAttack As CheckedListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CLBBuff As CheckedListBox
    Friend WithEvents TBAttackTime As TextBox
    Friend WithEvents TBBuffTime As TextBox
    Friend WithEvents LBLAttackTime As Label
    Friend WithEvents LBLBuffTime As Label
    Friend WithEvents LBLBuffbar As Label
    Friend WithEvents LBLAttackbar As Label
    Friend WithEvents CBBuffBar As ComboBox
    Friend WithEvents CBAttackBar As ComboBox
    Friend WithEvents LBLEnableRebuff As Label
    Friend WithEvents CBBuff As ComboBox
    Friend WithEvents CMDLoad As Button
    Friend WithEvents CMDSave As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents LBLAttackLoops As Label
    Friend WithEvents TBAttackLoops As TextBox
    Friend WithEvents Panel As Panel
End Class
