<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numTimeOut = New System.Windows.Forms.NumericUpDown()
        Me.numPollTime = New System.Windows.Forms.NumericUpDown()
        Me.chkAutoPoll = New System.Windows.Forms.CheckBox()
        Me.cbEncoding = New System.Windows.Forms.ComboBox()
        Me.tlpFile = New System.Windows.Forms.TableLayoutPanel()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numTimeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPollTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpFile.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.numTimeOut, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.numPollTime, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAutoPoll, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbEncoding, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.tlpFile, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 10)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(281, 328)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ping超时（毫秒）"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "自动检测"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "自动检测间隔（秒）"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "默认数据文件"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 27)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "文件编码"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'numTimeOut
        '
        Me.numTimeOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.numTimeOut.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numTimeOut.Location = New System.Drawing.Point(10, 30)
        Me.numTimeOut.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.numTimeOut.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.numTimeOut.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numTimeOut.Name = "numTimeOut"
        Me.numTimeOut.Size = New System.Drawing.Size(120, 25)
        Me.numTimeOut.TabIndex = 1
        Me.numTimeOut.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'numPollTime
        '
        Me.numPollTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.numPollTime.Location = New System.Drawing.Point(10, 144)
        Me.numPollTime.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.numPollTime.Maximum = New Decimal(New Integer() {86400, 0, 0, 0})
        Me.numPollTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPollTime.Name = "numPollTime"
        Me.numPollTime.Size = New System.Drawing.Size(120, 25)
        Me.numPollTime.TabIndex = 1
        Me.numPollTime.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'chkAutoPoll
        '
        Me.chkAutoPoll.AutoSize = True
        Me.chkAutoPoll.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkAutoPoll.Location = New System.Drawing.Point(10, 87)
        Me.chkAutoPoll.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.chkAutoPoll.Name = "chkAutoPoll"
        Me.chkAutoPoll.Size = New System.Drawing.Size(119, 24)
        Me.chkAutoPoll.TabIndex = 2
        Me.chkAutoPoll.Text = "开启自动检测"
        Me.chkAutoPoll.UseVisualStyleBackColor = True
        '
        'cbEncoding
        '
        Me.cbEncoding.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEncoding.FormattingEnabled = True
        Me.cbEncoding.Location = New System.Drawing.Point(3, 258)
        Me.cbEncoding.Name = "cbEncoding"
        Me.cbEncoding.Size = New System.Drawing.Size(275, 23)
        Me.cbEncoding.TabIndex = 4
        '
        'tlpFile
        '
        Me.tlpFile.ColumnCount = 2
        Me.tlpFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFile.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpFile.Controls.Add(Me.btnFile, 1, 0)
        Me.tlpFile.Controls.Add(Me.tbFilePath, 0, 0)
        Me.tlpFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFile.Location = New System.Drawing.Point(0, 198)
        Me.tlpFile.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFile.Name = "tlpFile"
        Me.tlpFile.RowCount = 1
        Me.tlpFile.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFile.Size = New System.Drawing.Size(281, 30)
        Me.tlpFile.TabIndex = 6
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(234, 3)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(44, 23)
        Me.btnFile.TabIndex = 5
        Me.btnFile.Text = "..."
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'tbFilePath
        '
        Me.tbFilePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFilePath.BackColor = System.Drawing.SystemColors.Window
        Me.tbFilePath.Location = New System.Drawing.Point(3, 3)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(225, 25)
        Me.tbFilePath.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnOK, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 288)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(275, 37)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(31, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 31)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "确定"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(168, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmConfig
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(301, 343)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.Padding = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "设置"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numTimeOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPollTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpFile.ResumeLayout(False)
        Me.tlpFile.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents numTimeOut As NumericUpDown
    Friend WithEvents numPollTime As NumericUpDown
    Friend WithEvents chkAutoPoll As CheckBox
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents cbEncoding As ComboBox
    Friend WithEvents btnFile As Button
    Friend WithEvents tlpFile As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
End Class
