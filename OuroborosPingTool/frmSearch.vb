Imports System.ComponentModel

Public Class frmSearch
    Dim clt(255) As Label
    Dim abort As Boolean = False

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim idx As Integer = 1
        For i = 0 To tlp.RowCount - 3
            For j = 0 To tlp.ColumnCount - 3
                Dim lbl As New Label
                With lbl
                    .Tag = idx
                    .Text = idx.ToString
                    .BackColor = Color.Silver
                    .AutoSize = False
                    .Dock = DockStyle.Fill
                    .Margin = New Padding(1, 1, 1, 1)
                    .TextAlign = ContentAlignment.MiddleCenter
                End With
                AddHandler lbl.DoubleClick, AddressOf lbl_Click
                tlp.Controls.Add(lbl, j + 1, i + 1)
                clt(idx) = lbl
                idx += 1
                If idx > 255 Then Exit For
            Next
            If idx > 255 Then Exit For
        Next
    End Sub

    Private Sub lbl_Click(sender As Label, e As EventArgs)
        Dim i As Integer = Convert.ToInt32(sender.Tag)
        Dim p As New Net.NetworkInformation.Ping
        Try
            Dim pr As Net.NetworkInformation.PingReply = p.Send($"{tbAdr.Text}.{sender.Tag}", _timeout)
            If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                clt(i).BackColor = Color.Green
            Else
                clt(i).BackColor = Color.Red
            End If
        Catch ex As Exception
            clt(i).BackColor = Color.Red
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Button, e As EventArgs) Handles btnSearch.Click
        'sender.Enabled = False
        If sender.Text = "开始" Then
            sender.Text = "停止"
            tbAdr.Enabled = False
            For n = 1 To 255
                clt(n).BackColor = Color.Silver
            Next
            Dim adr As String = tbAdr.Text
            For i = Convert.ToInt32(tbFrom.Text) To Convert.ToInt32(tbTo.Text)
                If abort Then Exit For
                Dim p As New Net.NetworkInformation.Ping
                Try
                    Dim pr As Net.NetworkInformation.PingReply = p.Send($"{adr}.{i.ToString}", _timeout)
                    If pr.Status = Net.NetworkInformation.IPStatus.Success Then
                        clt(i).BackColor = Color.Green
                    Else
                        clt(i).BackColor = Color.Red
                    End If
                Catch ex As Exception

                Finally
                    Application.DoEvents()
                End Try
            Next
            abort = False
            sender.Text = "开始"
            tbAdr.Enabled = True
        Else
            abort = True
            sender.Text = "开始"
            tbAdr.Enabled = True
        End If
        'sender.Enabled = True
    End Sub

    Private Sub Search_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmMain.Show()
    End Sub

End Class