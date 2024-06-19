<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tbLog = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPoll = New System.Windows.Forms.Panel()
        Me.numPollTime = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPoll = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPoll = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbPoll = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblSpace = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAbout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmPoll = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnOpen = New System.Windows.Forms.ToolStripButton()
        Me.btnConfig = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlPoll.SuspendLayout()
        CType(Me.numPollTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(4, 4)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 30
        Me.dgv.RowTemplate.Height = 23
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(844, 460)
        Me.dgv.TabIndex = 2
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.tlpMain.Controls.Add(Me.dgv, 0, 0)
        Me.tlpMain.Controls.Add(Me.tbLog, 1, 0)
        Me.tlpMain.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 27)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1312, 518)
        Me.tlpMain.TabIndex = 3
        '
        'tbLog
        '
        Me.tbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLog.Location = New System.Drawing.Point(856, 4)
        Me.tbLog.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLog.Multiline = True
        Me.tbLog.Name = "tbLog"
        Me.tbLog.ReadOnly = True
        Me.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbLog.Size = New System.Drawing.Size(452, 460)
        Me.tbLog.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlPoll, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCheck, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 471)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(846, 44)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'pnlPoll
        '
        Me.pnlPoll.Controls.Add(Me.numPollTime)
        Me.pnlPoll.Controls.Add(Me.Label1)
        Me.pnlPoll.Controls.Add(Me.chkPoll)
        Me.pnlPoll.Location = New System.Drawing.Point(3, 3)
        Me.pnlPoll.Name = "pnlPoll"
        Me.pnlPoll.Size = New System.Drawing.Size(328, 38)
        Me.pnlPoll.TabIndex = 8
        '
        'numPollTime
        '
        Me.numPollTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPollTime.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.numPollTime.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numPollTime.Location = New System.Drawing.Point(157, 1)
        Me.numPollTime.Margin = New System.Windows.Forms.Padding(4)
        Me.numPollTime.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.numPollTime.Name = "numPollTime"
        Me.numPollTime.Size = New System.Drawing.Size(103, 30)
        Me.numPollTime.TabIndex = 1
        Me.numPollTime.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(278, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "秒"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPoll
        '
        Me.chkPoll.AutoSize = True
        Me.chkPoll.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkPoll.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.chkPoll.Location = New System.Drawing.Point(0, 0)
        Me.chkPoll.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPoll.Name = "chkPoll"
        Me.chkPoll.Size = New System.Drawing.Size(149, 38)
        Me.chkPoll.TabIndex = 0
        Me.chkPoll.Text = "自动检测间隔："
        Me.chkPoll.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCheck.Location = New System.Drawing.Point(650, 4)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(192, 36)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "手动检测"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPoll, Me.pbPoll, Me.lblSpace, Me.btnAbout})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1312, 31)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPoll
        '
        Me.lblPoll.Name = "lblPoll"
        Me.lblPoll.Size = New System.Drawing.Size(114, 25)
        Me.lblPoll.Text = "自动检测计时："
        '
        'pbPoll
        '
        Me.pbPoll.Name = "pbPoll"
        Me.pbPoll.Size = New System.Drawing.Size(500, 23)
        Me.pbPoll.Step = 1
        Me.pbPoll.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'lblSpace
        '
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(492, 25)
        Me.lblSpace.Spring = True
        '
        'btnAbout
        '
        Me.btnAbout.IsLink = True
        Me.btnAbout.LinkColor = System.Drawing.Color.Blue
        Me.btnAbout.LinkVisited = True
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(184, 25)
        Me.btnAbout.Text = "关于OuroborosPingTool"
        Me.btnAbout.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'tmPoll
        '
        Me.tmPoll.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnOpen, Me.btnConfig, Me.ToolStripSeparator1, Me.btnSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 0, 1, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(1312, 27)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnOpen
        '
        Me.btnOpen.Image = Global.OuroborosPingTool.My.Resources.Resources.Primo_icon_folder_open
        Me.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnOpen.Size = New System.Drawing.Size(103, 24)
        Me.btnOpen.Text = "打开文件"
        '
        'btnConfig
        '
        Me.btnConfig.Image = Global.OuroborosPingTool.My.Resources.Resources.Primo_icon_tools
        Me.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConfig.Size = New System.Drawing.Size(73, 24)
        Me.btnConfig.Text = "设置"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.OuroborosPingTool.My.Resources.Resources.Primo_icon_search
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSearch.Size = New System.Drawing.Size(103, 24)
        Me.btnSearch.Text = "网段搜索"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 576)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouroboros Ping Tool"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlPoll.ResumeLayout(False)
        Me.pnlPoll.PerformLayout()
        CType(Me.numPollTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblSpace As ToolStripStatusLabel
    Friend WithEvents btnAbout As ToolStripStatusLabel
    Friend WithEvents pbPoll As ToolStripProgressBar
    Friend WithEvents tmPoll As Timer
    Friend WithEvents tbLog As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnOpen As ToolStripButton
    Friend WithEvents btnConfig As ToolStripButton
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents numPollTime As NumericUpDown
    Friend WithEvents chkPoll As CheckBox
    Friend WithEvents lblPoll As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlPoll As Panel
End Class
