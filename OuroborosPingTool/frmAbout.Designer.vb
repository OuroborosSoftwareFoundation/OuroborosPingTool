<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.tbLicense = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbLang = New System.Windows.Forms.ComboBox()
        Me.lblWebsite = New System.Windows.Forms.LinkLabel()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.SetColumnSpan(Me.btnOK, 2)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(281, 496)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 44)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "确定"
        '
        'tbLicense
        '
        Me.tbLicense.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel.SetColumnSpan(Me.tbLicense, 2)
        Me.tbLicense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLicense.Location = New System.Drawing.Point(8, 233)
        Me.tbLicense.Margin = New System.Windows.Forms.Padding(8, 3, 4, 3)
        Me.tbLicense.Multiline = True
        Me.tbLicense.Name = "tbLicense"
        Me.tbLicense.ReadOnly = True
        Me.tbLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLicense.Size = New System.Drawing.Size(650, 257)
        Me.tbLicense.TabIndex = 0
        Me.tbLicense.TabStop = False
        Me.tbLicense.Text = resources.GetString("tbLicense.Text")
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel.Controls.Add(Me.tbLicense, 0, 5)
        Me.TableLayoutPanel.Controls.Add(Me.btnOK, 0, 6)
        Me.TableLayoutPanel.Controls.Add(Me.lblProdName, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.lblVersion, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.lblCopyright, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.picLogo, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.PictureBox1, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.cbLang, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.lblWebsite, 0, 2)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 5)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 7
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(662, 543)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'lblProdName
        '
        Me.lblProdName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProdName.Font = New System.Drawing.Font("微软雅黑", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblProdName.Location = New System.Drawing.Point(3, 0)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(506, 80)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "OuroborosPingTool"
        Me.lblProdName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Location = New System.Drawing.Point(3, 80)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(506, 30)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyright.Location = New System.Drawing.Point(3, 140)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(506, 60)
        Me.lblCopyright.TabIndex = 3
        Me.lblCopyright.Text = "Copyright © 2020-2024 Ouroboros Software Foundation. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved."
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = Global.OuroborosPingTool.My.Resources.Resources.OSF_logo_256
        Me.picLogo.Location = New System.Drawing.Point(515, 3)
        Me.picLogo.Name = "picLogo"
        Me.TableLayoutPanel.SetRowSpan(Me.picLogo, 2)
        Me.picLogo.Size = New System.Drawing.Size(144, 104)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "软件许可证："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.OuroborosPingTool.My.Resources.Resources.gplv3_or_later
        Me.PictureBox1.Location = New System.Drawing.Point(515, 143)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'cbLang
        '
        Me.cbLang.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLang.FormattingEnabled = True
        Me.cbLang.Items.AddRange(New Object() {"English", "简体中文"})
        Me.cbLang.Location = New System.Drawing.Point(515, 203)
        Me.cbLang.Name = "cbLang"
        Me.cbLang.Size = New System.Drawing.Size(144, 23)
        Me.cbLang.TabIndex = 7
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.TableLayoutPanel.SetColumnSpan(Me.lblWebsite, 2)
        Me.lblWebsite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWebsite.Location = New System.Drawing.Point(3, 110)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(656, 30)
        Me.lblWebsite.TabIndex = 8
        Me.lblWebsite.TabStop = True
        Me.lblWebsite.Text = "https://github.com/OuroborosSoftwareFoundation/OuroborosPingTool"
        Me.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(682, 553)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "关于"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents tbLicense As TextBox
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents lblProdName As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbLang As ComboBox
    Friend WithEvents lblWebsite As LinkLabel
End Class
