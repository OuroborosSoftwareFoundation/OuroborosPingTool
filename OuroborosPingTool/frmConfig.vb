Imports System.Configuration
Imports System.Configuration.ConfigurationManager

Public Class frmConfig

    Dim cfg As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Dim hasChange As Boolean = False '配置是否有更改

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        numTimeOut.Value = _TimeOut
        chkAutoPoll.Checked = _AutoPoll
        numPollTime.Value = _PollTime
        tbFilePath.Text = _FilePath
        cbEncoding.Items.Add("UTF-8")
        cbEncoding.Items.Add("GB2312")
        cbEncoding.Text = _Encoding
    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Title = "打开文件"
            .Filter = "CSV文件(*.csv)|*.csv|所有文件(*.*)|*.*"
            .FilterIndex = 1
            .InitialDirectory = Application.StartupPath
        End With
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim fp As String = ofd.FileName
            If fp.Contains(Application.StartupPath) Then '文件位于程序所在文件夹，使用短路径
                fp = fp.Substring(Application.StartupPath.Length + 1)
            End If
            tbFilePath.Text = fp
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If String.IsNullOrEmpty(cbEncoding.Text) Then
            MsgShow.Warn("未选择文件编码")
            Exit Sub
        End If
        ConfigChange("Encoding", cbEncoding.Text) '文件编码
        ConfigChange("FilePath", tbFilePath.Text) '数据文件路径
        ConfigChange("TimeOut", numTimeOut.Value.ToString) 'Ping超时时间
        ConfigChange("AutoPoll", chkAutoPoll.Checked.ToString) '自动检测
        ConfigChange("PollTime", numPollTime.Value.ToString) '自动检测间隔
        If hasChange Then
            cfg.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
            _Encoding = AppSettings("Encoding").Trim.ToUpper
            _TimeOut = Math.Min(Convert.ToInt32(AppSettings("TimeOut")), 60000)
            _AutoPoll = Convert.ToBoolean(AppSettings("AutoPoll"))
            _PollTime = Math.Min(Convert.ToInt32(AppSettings("PollTime")), 86400)
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
        Me.Close()
    End Sub

    Private Sub ConfigChange(key As String, value As String)
        If value <> AppSettings(key) Then '设置项与配置文件不同的情况
            cfg.AppSettings.Settings.Remove(key)
            cfg.AppSettings.Settings.Add(key, value)
            hasChange = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class