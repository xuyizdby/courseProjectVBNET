Public Class From1

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        If ListView1.Items(0).Selected = True Then
            TrackBar1.Maximum = 2
            TrackBar1.Visible = True
            If TrackBar1.Value = 1 Then
                Label24.Text = "中-高"
                Label25.Text = "-适用于大多数网站"
                Label26.Text = "-在下载潜在的不安全内容之前提示"
                Label27.Text = "-不下载未签名的ActiveX控件"
                Label28.Text = ""
            ElseIf TrackBar1.Value = 0 Then
                Label24.Text = "中"
                Label25.Text = "-下载潜在不安全内容前提示"
                Label26.Text = "-不下载未经签名的ActiveX控件"
                Label27.Text = ""
                Label28.Text = ""
            ElseIf TrackBar1.Value = 2 Then
                Label24.Text = "高"
                Label25.Text = "-适用于可能包含有害内容的网站"
                Label26.Text = "-最高的安全保护"
                Label27.Text = "-禁用的安全功能较少"
                Label28.Text = ""
            End If
        ElseIf ListView1.Items(1).Selected = True Then
            TrackBar1.Maximum = 4
            TrackBar1.Visible = False
            Label24.Text = "自定义"
            Label25.Text = "-要更改设置，请单击‘自定义级别'"
            Label26.Text = "要使用推荐的设置，请单击‘默认级别’"
            Label27.Text = ""
            Label28.Text = ""
        ElseIf ListView1.Items(2).Selected = True Then
            TrackBar1.Maximum = 4
            TrackBar1.Visible = True
            If TrackBar1.Value = 2 Then
                Label24.Text = "中"
                Label25.Text = "-下载潜在不安全内容提示"
                Label26.Text = "-不下载未签名的ActiveX控件"
                Label27.Text = ""
                Label28.Text = ""
            ElseIf TrackBar1.Value = 0 Then
                Label24.Text = "低"
                Label25.Text = "-提供最小的安全措施和警告提示"
                Label26.Text = "-下载大多数内容，且无提示运行"
                Label27.Text = "-可以运行所有的活动内容"
                Label28.Text = "-适用于绝对信任的站点"
            ElseIf TrackBar1.Value = 4 Then
                Label24.Text = "高"
                Label25.Text = "-适用于可能包含有害内容的网站"
                Label26.Text = "-最高的安全保护"
                Label27.Text = "-禁用的安全功能较少"
                Label28.Text = ""
            ElseIf TrackBar1.Value = 1 Then
                Label24.Text = "中低"
                Label25.Text = "-适用于本地网络（Internet)上的网站"
                Label26.Text = "-大多数内容运行时都没有提示"
                Label27.Text = "-不下载未签名的ActiveX控件"
                Label28.Text = "-除了没有提示外，其他与中等级别安全相同"
            ElseIf TrackBar1.Value = 3 Then
                Label24.Text = "中-高"
                Label25.Text = "-适用于大多数网站"
                Label26.Text = "-在下载潜在的不安全内容之前提示"
                Label27.Text = "-不下载未签名的ActiveX控件"
                Label28.Text = ""
            End If

        ElseIf ListView1.Items(3).Selected = True Then
            TrackBar1.Maximum = 4
            TrackBar1.Value = 4
            TrackBar1.Visible = True
            TrackBar1.Enabled = False
            Label24.Text = "高"
            Label25.Text = "-适用于可能包含有害内容的网站"
            Label26.Text = "-最高的安全保护"
            Label27.Text = "-禁用的安全功能较少"
            Label28.Text = ""
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.Items(0).Selected = True Then
            Button16.Enabled = False
            Button18.Enabled = False
            TrackBar1.Maximum = 2
            PictureBox2.Image = Global.WindowsApplication1.My.Resources.地球图标
            Label29.Text = "该区域的允许级别：中到高"
            TrackBar1.Enabled = False
            TrackBar1.Enabled = True
            TrackBar1.Visible = True
            Label22.Text = "Internet"
            Label23.Text = "该区域适用于Internet网站，但不适用于在受信任" & ChrW(13) & "和受限制区域中列出的网站。"
            TrackBar1.Value = 1
            Label24.Text = "中-高"
            Label25.Text = "-适用于大多数网站"
            Label26.Text = "-在下载潜在的不安全内容之前提示"
            Label27.Text = "-不下载未签名的ActiveX控件"
            Label28.Text = ""
        ElseIf ListView1.Items(1).Selected = True Then
            Button16.Enabled = True
            Button18.Enabled = True
            PictureBox2.Image = Global.WindowsApplication1.My.Resources.电脑
            Label29.Text = ""
            TrackBar1.Enabled = True
            Label22.Text = "本地Intranet"
            Label23.Text = "该区域适用于在你的Intranet上找到的所有网站。"
            TrackBar1.Visible = False
            Label24.Text = "自定义"
            Label25.Text = "-要更改设置，请单击‘自定义级别'"
            Label26.Text = "要使用推荐的设置，请单击‘默认级别’"
            Label27.Text = ""
            Label28.Text = ""
            TrackBar1.Maximum = 4
        ElseIf ListView1.Items(2).Selected = True Then
            Button16.Enabled = True
            Button18.Enabled = False
            PictureBox2.Image = Global.WindowsApplication1.My.Resources.对勾
            Label29.Text = "该区域的允许级别：全部"
            TrackBar1.Enabled = True
            TrackBar1.Visible = True
            Label22.Text = "受信任的站点"
            Label23.Text = "该区域包含你确信不会损害你的计算机或文件的网" & ChrW(13) & "站。"
            TrackBar1.Value = 2
            Label24.Text = "中"
            Label25.Text = "-下载潜在不安全内容提示"
            Label26.Text = "-不下载未签名的ActiveX控件"
            Label27.Text = ""
            Label28.Text = ""
            TrackBar1.Maximum = 4
        ElseIf ListView1.Items(3).Selected = True Then
            Button16.Enabled = True
            Button18.Enabled = False
            TrackBar1.Maximum = 4
            TrackBar1.Value = 4
            PictureBox2.Image = Global.WindowsApplication1.My.Resources.禁止
            Label29.Text = "该区域的允许级别：高"
            Label22.Text = "受限制的站点"
            Label23.Text = "该区域适用于可能会损害你的计算机或文件的网站。" & ChrW(13) & ChrW(13) & "该区域中无网络。"
            TrackBar1.Visible = True
            TrackBar1.Enabled = False
            Label24.Text = "高"
            Label25.Text = "-适用于可能包含有害内容的网站"
            Label26.Text = "-最高的安全保护"
            Label27.Text = "-禁用的安全功能较少"
            Label28.Text = ""
        End If
    End Sub

    Private Sub From1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For N As Integer = 0 To TreeView1.Nodes.Count - 1
            TreeView1.Nodes(N).ExpandAll()
        Next
        TextBox1.Text = "https://www.baidu.com/"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = "http://go.microsoft.com/fwlink/?LinkId=625115"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Form2.WebBrowser1.Document.Url.ToString
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = "about:NewsFeed"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form2.WebBrowser1.Url = New Uri(TextBox1.Text)
    End Sub
End Class
