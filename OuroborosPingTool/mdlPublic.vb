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

Imports System.Configuration
Imports System.Configuration.ConfigurationManager

Module mdlPublic
    Public _Encoding As String = "GB2312" '文件编码
    Public _FilePath As String = "address.csv" '数据文件
    Public _TimeOut As Integer = 200 'ping超时时间
    Public _AutoPoll As Boolean = False '是否自动检测
    Public _PollTime As Integer = 60 '自动检测时间

    ''' <summary>
    ''' 加载配置文件，自动修复错误
    ''' </summary>
    Public Function ConfigLoad() As Boolean
        Try
            Dim cfg As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim hasChange As Boolean = False
            If String.IsNullOrEmpty(AppSettings("Encoding")) Then
                cfg.AppSettings.Settings.Add("Encoding", "GB2312")
                hasChange = True
            End If
            If String.IsNullOrEmpty(AppSettings("FilePath")) Then
                cfg.AppSettings.Settings.Add("FilePath", "address.csv")
                hasChange = True
            End If
            If String.IsNullOrEmpty("TimeOut") Then
                cfg.AppSettings.Settings.Add("TimeOut", "200")
                hasChange = True
            ElseIf (Not IsNumeric(AppSettings("TimeOut"))) OrElse Convert.ToInt32(AppSettings("TimeOut")) < 0 Then
                cfg.AppSettings.Settings.Remove("TimeOut")
                cfg.AppSettings.Settings.Add("TimeOut", "200")
                hasChange = True
            End If
            If String.IsNullOrEmpty("AutoPoll") Then
                cfg.AppSettings.Settings.Add("AutoPoll", "False")
                hasChange = True
            ElseIf (Not {"False", "True"}.Contains(AppSettings("AutoPoll"))) Then
                cfg.AppSettings.Settings.Remove("AutoPoll")
                cfg.AppSettings.Settings.Add("AutoPoll", "False")
                hasChange = True
            End If
            If String.IsNullOrEmpty("PollTime") Then
                cfg.AppSettings.Settings.Add("PollTime", "60")
                hasChange = True
            ElseIf (Not IsNumeric(AppSettings("PollTime"))) OrElse Convert.ToInt32(AppSettings("PollTime")) < 0 Then
                cfg.AppSettings.Settings.Remove("PollTime")
                cfg.AppSettings.Settings.Add("PollTime", "60")
                hasChange = True
            End If
            If hasChange Then
                cfg.Save(ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection("appSettings")
            End If
            _Encoding = AppSettings("Encoding").Trim.ToUpper
            _TimeOut = Math.Min(Convert.ToInt32(AppSettings("TimeOut")), 60000)
            _AutoPoll = Convert.ToBoolean(AppSettings("AutoPoll"))
            _PollTime = Math.Min(Convert.ToInt32(AppSettings("PollTime")), 86400)
        Catch ex As Exception
            MsgShow.Err(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Sub GetEncodingNames()
        Console.WriteLine("Encode")
        For Each e In Text.Encoding.GetEncodings
            Debug.WriteLine(e.Name)
        Next
    End Sub

End Module
