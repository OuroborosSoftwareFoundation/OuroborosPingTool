'OuroborosPingTool

'   Copyright © 2020 Ouroboros Software Foundation. All rights reserved.
'   版权所有 © 2020 Ouroboros Software Foundation。保留所有权利。
'
'   本文件是OuroborosPingTool的一部分。

'   This program Is free software: you can redistribute it And/Or modify
'   it under the terms Of the GNU General Public License As published by
'   the Free Software Foundation, either version 3 Of the License, Or
'   (at your option) any later version.
'   本程序为自由软件， 在自由软件联盟发布的GNU通用公共许可协议的约束下，
'   你可以对其进行再发布及修改。协议版本为第三版或（随你）更新的版本。

'   This program Is distributed In the hope that it will be useful,
'   but WITHOUT ANY WARRANTY; without even the implied warranty Of
'   MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE. See the
'   GNU General Public License For more details.
'   我们希望发布的这款程序有用，但不保证，甚至不保证它有经济价值和适合特定用途。
'   详情参见GNU通用公共许可协议。

'   You should have received a copy Of the GNU General Public License
'   along with this program.
'   If Not, see <https://www.gnu.org/licenses/>.
'   你理当已收到一份GNU通用公共许可协议的副本。
'   如果没有，请查阅 <http://www.gnu.org/licenses/> 

Imports System.IO
Imports System.Text

Public Class frmMain

    Dim dtAdr As New DataTable
    Dim isBusy As Boolean = True
    Dim swLog As StreamWriter

    Private Sub DataTableInt()
        With dtAdr
            .Clear()
            .Columns.Add("Name", GetType(String))
            .Columns("Name").Caption = "名称"
            .Columns.Add("Adr", GetType(String))
            .Columns("Adr").Caption = "地址"
            .Columns.Add("Status", GetType(String))
            .Columns("Status").Caption = "状态"
            .Columns.Add("Delay", GetType(String))
            .Columns("Delay").Caption = "延迟"
            .Columns.Add("ErrTime", GetType(DateTime))
            .Columns("ErrTime").Caption = "故障时间"
        End With
        dgv.DataSource = dtAdr
        For Each col As DataGridViewColumn In dgv.Columns
            col.HeaderText = dtAdr.Columns(col.Name).Caption
        Next
        dgv.Columns("ErrTime").Width = 200
    End Sub

    ''' <summary>
    ''' 加载数据文件
    ''' </summary>
    ''' <param name="path">文件路径</param>
    Private Sub DGV_load(path As String)
        dtAdr.Clear()
        Dim sr As New StreamReader(path, Encoding.GetEncoding(_Encoding))
        sr.ReadLine()
        Do Until sr.EndOfStream
            Dim l As String = sr.ReadLine
            Dim dr() As String = l.Split(","c)
            dtAdr.Rows.Add(dr)
        Loop
        dgv.DataSource = dtAdr
        dgv.AutoResizeColumn(0)
        Dim logfp As String = path.Substring(0, path.LastIndexOf("."c) + 1) & "log"
        swLog = New StreamWriter(logfp, True, Encoding.GetEncoding(_Encoding))
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = $"Ouroboros Ping Tool (Ver.{Application.ProductVersion})"
        DataTableInt()
        If File.Exists(_FilePath) Then
            DGV_load(_FilePath)
        End If
        numPollTime.Value = _PollTime
        If _AutoPoll Then chkPoll.Checked = True
        isBusy = False
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        chkPoll.Checked = False
        isBusy = True
        Try
            swLog.Flush()
            swLog.Close()
            Dim ofd As New OpenFileDialog
            With ofd
                .Title = "打开文件"
                .Filter = "CSV文件(*.csv)|*.csv|所有文件(*.*)|*.*"
                .FilterIndex = 1
                .InitialDirectory = Application.StartupPath
            End With
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim fp As String = ofd.FileName
                DGV_load(fp)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            isBusy = False
        End Try
    End Sub


    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        btnOpen.Enabled = False
        isBusy = True
        Dim i As Integer = dgv.SelectedRows(0).Index
        Dim p As New Net.NetworkInformation.Ping
        Try
            Dim pr As Net.NetworkInformation.PingReply = p.Send(dtAdr(i)(1), _TimeOut)
            If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                dtAdr(i)(3) = $"{pr.RoundtripTime}ms"
                If IsDBNull(dtAdr(i)(2)) Then WriteLog(i, "连接成功")
                dtAdr(i)(2) = "正常"
                If Not IsDBNull(dtAdr(i)(4)) Then '上一次有故障
                    dtAdr(i)(4) = vbNullString
                    WriteLog(i, "恢复正常")
                End If
            Else
                dtAdr(i)(2) = "故障"
                dtAdr(i)(3) = pr.Status
                If IsDBNull(dtAdr(i)(4)) Then
                    dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                    WriteLog(i, "故障")
                End If
            End If
        Catch ex As Exception
            dtAdr(i)(2) = "未知故障"
            dtAdr(i)(3) = ex.Message
            If IsDBNull(dtAdr(i)(4)) Then
                dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
            End If
        Finally
            dgv.Refresh()
            isBusy = False
        End Try
        btnOpen.Enabled = True
    End Sub

    Private Sub btnCheck_Click(sender As Button, e As EventArgs) Handles btnCheck.Click
        sender.Enabled = False
        btnOpen.Enabled = False
        pbPoll.Value = 0
        isBusy = True
        Dim p As New Net.NetworkInformation.Ping
        For i = 0 To dtAdr.Rows.Count - 1
            Dim LogT As String = vbNullString
            Try
                Dim pr As Net.NetworkInformation.PingReply = p.Send(dtAdr(i)(1), _TimeOut)
                If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                    dtAdr(i)(3) = $"{pr.RoundtripTime}ms"
                    If IsDBNull(dtAdr(i)(2)) Then WriteLog(i, "连接成功")
                    dtAdr(i)(2) = "正常"
                    If Not IsDBNull(dtAdr(i)(4)) Then '上一次有故障
                        dtAdr(i)(4) = vbNullString
                        WriteLog(i, "恢复正常")
                    End If
                Else
                    dtAdr(i)(2) = "故障"
                    dtAdr(i)(3) = pr.Status
                    If IsDBNull(dtAdr(i)(4)) Then
                        dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                        WriteLog(i, "故障")
                    End If
                End If
                dgv.CurrentCell = dgv.Rows(i).Cells(0)
            Catch ex As Exception
                dtAdr(i)(2) = "未知故障"
                dtAdr(i)(3) = ex.Message
                If IsDBNull(dtAdr(i)(4)) Then
                    dtAdr(i)(4) = Format(Now(), "yyyy-MM-dd HH:mm:ss")
                End If
            Finally
                dgv.Refresh()
                isBusy = False
            End Try
        Next
        sender.Enabled = True
        btnOpen.Enabled = True
    End Sub

    Private Sub WriteLog(ByVal idx As Integer, ByVal msg As String)
        Dim log As String = vbNullString
        log = $"{Format(Now(), "yyyy-MM-dd HH:mm:ss")},{dtAdr(idx)(1)},{msg},{dtAdr(idx)(3)}"
        tbLog.AppendText(log & vbCrLf)
        swLog.WriteLine(log)
        swLog.Flush()
    End Sub

    Private Sub chkPoll_CheckedChanged(sender As CheckBox, e As EventArgs) Handles chkPoll.CheckedChanged
        If numPollTime.Value <= 0 Then Exit Sub
        numPollTime.Enabled = Not sender.Checked
        btnOpen.Enabled = Not sender.Checked
        tmPoll.Enabled = sender.Checked
        pbPoll.Maximum = numPollTime.Value
        pbPoll.Value = 0
    End Sub

    Private Sub tmPoll_Tick(sender As Object, e As EventArgs) Handles tmPoll.Tick
        If Not isBusy Then pbPoll.Value += 1
        If pbPoll.Value >= pbPoll.Maximum Then
            pbPoll.Value = 0
            If Not isBusy Then
                Call btnCheck_Click(btnCheck, Nothing)
            End If
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        If frmConfig.ShowDialog() = DialogResult.OK Then
            numPollTime.Value = _PollTime
            If _AutoPoll Then chkPoll.Checked = True
        End If
    End Sub

    Private Sub btnSch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

End Class