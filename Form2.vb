Public Class Form2
    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = ChrW(13) Then
            WebBrowser1.Navigate(ComboBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Form3.Show()
        Form3.Timer1.Enabled = True
    End Sub

    Private Sub Internet选项OToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Internet选项OToolStripMenuItem.Click
        From1.Show()
        From1.TextBox1.Text = "https://www.baidu.com/"
    End Sub

    Private Sub 添加到收藏夹AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加到收藏夹AToolStripMenuItem.Click
        收藏夹AToolStripMenuItem.DropDownItems.Add(WebBrowser1.Url.ToString)

    End Sub

    Private Sub 添加到收藏夹栏BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加到收藏夹栏BToolStripMenuItem.Click
        收藏夹栏ToolStripMenuItem.DropDownItems.Add(WebBrowser1.Url.ToString)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoHome()
    End Sub
End Class