Public Class MsgShow

    Public Shared Function Info(text As String, Optional caption As String = "提示") As DialogResult
        Return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Public Shared Function Warn(text As String, Optional caption As String = "警告") As DialogResult
        Return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Function

    Public Shared Function Err(text As String, Optional caption As String = "错误") As DialogResult
        Return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Function

End Class
