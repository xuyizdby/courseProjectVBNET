<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class From1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(From1))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Internet", "地球图标.jpg")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("本地Intranet", "电脑.jpg")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("受信任的站点", "对勾.jpg")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("受限制的站点", "禁止.jpg")
        Dim TreeNode217 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用HTTP1.1")
        Dim TreeNode218 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用HTTP2")
        Dim TreeNode219 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("通过代理连接使用HTTP1.1")
        Dim TreeNode220 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HTTP设置", New System.Windows.Forms.TreeNode() {TreeNode217, TreeNode218, TreeNode219})
        Dim TreeNode221 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("不将加密的页存盘")
        Dim TreeNode222 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("对证书地址不匹配发出警告*")
        Dim TreeNode223 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("关闭浏览器时清空""Internet临时文件""文件夹")
        Dim TreeNode224 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("检查发行商的证书是否已吊销")
        Dim TreeNode225 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("检查服务器证书是否已吊销")
        Dim TreeNode226 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("检查所下载程序的签名")
        Dim TreeNode227 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("将提交的POST重定向到不允许发送的区域时发出警告")
        Dim TreeNode228 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用DOM存储")
        Dim TreeNode229 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用SmartScreen筛选器")
        Dim TreeNode230 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用本机XMLHTTP支持")
        Dim TreeNode231 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用集成Windows验证*")
        Dim TreeNode232 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用增强保护模式*")
        Dim TreeNode233 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用SSL3.0")
        Dim TreeNode234 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用TLS1.0")
        Dim TreeNode235 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用TLS1.2")
        Dim TreeNode236 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("向你在Internrt Explorer中访问的站点发送""请勿跟踪""请求*")
        Dim TreeNode237 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("允许活动内容在""我的电脑""的文件中运行*")
        Dim TreeNode238 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("允许来自CD的活动内容在""我的电脑""中运行*")
        Dim TreeNode239 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("允许运行或安装软件，即使签名无效")
        Dim TreeNode240 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在安全和非安全模式之前切换时发出警告")
        Dim TreeNode241 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("阻止混合了其他内容的不安全图像")
        Dim TreeNode242 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("安全", New System.Windows.Forms.TreeNode() {TreeNode221, TreeNode222, TreeNode223, TreeNode224, TreeNode225, TreeNode226, TreeNode227, TreeNode228, TreeNode229, TreeNode230, TreeNode231, TreeNode232, TreeNode233, TreeNode234, TreeNode235, TreeNode236, TreeNode237, TreeNode238, TreeNode239, TreeNode240, TreeNode241})
        Dim TreeNode243 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用自动图像大小调整")
        Dim TreeNode244 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("显示图片")
        Dim TreeNode245 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("显示图像下载占位符")
        Dim TreeNode246 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在HTML5媒体元素中启用备用的编码解码器*")
        Dim TreeNode247 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在网页中播放动画*")
        Dim TreeNode248 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在网页中播放声音")
        Dim TreeNode249 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("多媒体", New System.Windows.Forms.TreeNode() {TreeNode243, TreeNode244, TreeNode245, TreeNode246, TreeNode247, TreeNode248})
        Dim TreeNode250 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("播放系统声音")
        Dim TreeNode251 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("对新窗口和标签页启用插入光标浏览")
        Dim TreeNode252 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("对于新窗口和标签页，将文本大小重置为中等")
        Dim TreeNode253 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("对于新的窗口和标签页，重置缩放级别")
        Dim TreeNode254 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("始终扩展图像的说明文本")
        Dim TreeNode255 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("随焦点（或选择）的更改移动系统插入标记")
        Dim TreeNode256 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("辅助功能", New System.Windows.Forms.TreeNode() {TreeNode250, TreeNode251, TreeNode252, TreeNode253, TreeNode254, TreeNode255})
        Dim TreeNode257 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("发送Intranet URL 的IDN 服务器名称")
        Dim TreeNode258 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("发送Intranet URL 的UTF-8查询字符串")
        Dim TreeNode259 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("发送非Intranet URL 的IDN 服务器名称")
        Dim TreeNode260 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("发送Intranet URL 的UTF-8查询字符串")
        Dim TreeNode261 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("始终显示编码地址")
        Dim TreeNode262 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("显示编码地址通知栏")
        Dim TreeNode263 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("以UTF-8形式发送URL路径")
        Dim TreeNode264 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("国际*", New System.Windows.Forms.TreeNode() {TreeNode257, TreeNode258, TreeNode259, TreeNode260, TreeNode261, TreeNode262, TreeNode263})
        Dim TreeNode265 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用软件呈现而不使用GPU呈现")
        Dim TreeNode266 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("加速的图形", New System.Windows.Forms.TreeNode() {TreeNode265})
        Dim TreeNode267 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Always record developer console messages")
        Dim TreeNode268 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("关闭""历史记录""和""收藏夹""中未使用的文件夹")
        Dim TreeNode269 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("禁用脚本调式（Internet Explorer)")
        Dim TreeNode270 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用FTP文件夹视图（在Internet Explorer之外)")
        Dim TreeNode271 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用第三方浏览器扩展*")
        Dim TreeNode272 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用建议的网站")
        Dim TreeNode273 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("启用自动崩溃恢复*")
        Dim TreeNode274 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("如果Intetnet Explorer 不是默认的Web浏览器则告诉我")
        Dim TreeNode275 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用Ctrl+Tab切换标签页时，使用最新顺序")
        Dim TreeNode276 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用被动FTP（用于防火墙和DSL调制解调器的兼容）")
        Dim TreeNode277 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("使用平滑滚动")
        Dim TreeNode278 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("通过页面预测启用快速翻页")
        Dim TreeNode279 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("为链接加下划线")
        Dim TreeNode280 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("为网页上的按钮和控件启用视觉样式")
        Dim TreeNode281 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("下载完成后发出通知")
        Dim TreeNode282 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("显示每个脚本错误的通知")
        Dim TreeNode283 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("显示友好HTTP错误的通知")
        Dim TreeNode284 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在Internet Explorer 地址栏和""打开""对话框中使用直接插入自动完成功能")
        Dim TreeNode285 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在后台加载站点和内容以优化性能")
        Dim TreeNode286 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("在文件资源管理器和""运行""对话框中使用直接插入自动完成功能")
        Dim TreeNode287 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("转到地址栏中的单字条目对应的Intranet站点")
        Dim TreeNode288 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("浏览", New System.Windows.Forms.TreeNode() {TreeNode267, TreeNode268, TreeNode269, TreeNode270, TreeNode271, TreeNode272, TreeNode273, TreeNode274, TreeNode275, TreeNode276, TreeNode277, TreeNode278, TreeNode279, TreeNode280, TreeNode281, TreeNode282, TreeNode283, TreeNode284, TreeNode285, TreeNode286, TreeNode287})
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button19 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(652, 777)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox)
        Me.TabPage1.Controls.Add(Me.Button10)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(644, 748)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "常规"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(96, 575)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(482, 10)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(145, 418)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(435, 10)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(98, 215)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(482, 10)
        Me.GroupBox4.TabIndex = 77
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(98, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 10)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'GroupBox
        '
        Me.GroupBox.Location = New System.Drawing.Point(98, 20)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(482, 10)
        Me.GroupBox.TabIndex = 75
        Me.GroupBox.TabStop = False
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(421, 615)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(107, 29)
        Me.Button10.TabIndex = 74
        Me.Button10.Text = "辅助功能(&E)"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(310, 615)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 29)
        Me.Button9.TabIndex = 73
        Me.Button9.Text = "字体(&L)"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(198, 615)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(94, 29)
        Me.Button8.TabIndex = 72
        Me.Button8.Text = "语言(&L)"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(79, 615)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 29)
        Me.Button7.TabIndex = 71
        Me.Button7.Text = "颜色(&O)"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 570)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "外观"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(38, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 55)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(417, 530)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 25)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = "设置(&S)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(288, 530)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 25)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "删除(&D)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(87, 489)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(233, 19)
        Me.CheckBox1.TabIndex = 65
        Me.CheckBox1.Text = "退出时删除浏览历史纪录。(&W)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(413, 14)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "删除临时文件、历史纪录、Cookie、保存的密码和网页表单信息。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "浏览历史记录"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(429, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 26)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "标签页(&T)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 14)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "更改网页在标签页中的显示方式"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "标签页"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(96, 286)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(142, 19)
        Me.RadioButton2.TabIndex = 57
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "从主页开始。(&H)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(96, 250)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(247, 19)
        Me.RadioButton1.TabIndex = 56
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "从上次会话中的标签页开始。(&B)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "启动"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(378, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 29)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "使用新标签页(&U)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(250, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 29)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "使用默认值(&F)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(114, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 29)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "使用当前页(&C)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 86)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(386, 65)
        Me.TextBox1.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 14)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "若要创建多个主标签页，请在每行输入一个地址。(&R)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "主页"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.Button19)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Button16)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(644, 748)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "安全"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.地球图标
        Me.PictureBox2.Location = New System.Drawing.Point(34, 210)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(70, 92)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(499, 103)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "地球图标.jpg")
        Me.ImageList1.Images.SetKeyName(1, "电脑.jpg")
        Me.ImageList1.Images.SetKeyName(2, "对勾.jpg")
        Me.ImageList1.Images.SetKeyName(3, "禁止.jpg")
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(296, 642)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(261, 44)
        Me.Button19.TabIndex = 7
        Me.Button19.Text = "将所有区域重置为默认级别（&R）"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TrackBar1)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 292)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "该区域的安全级别（&L）"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(84, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(187, 15)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "该区域的允许级别：中到高"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(208, 159)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(0, 15)
        Me.Label28.TabIndex = 10
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(208, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(206, 15)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "-不下载未签名的ActiveX控件"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(208, 105)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(240, 15)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "-在下载潜在的不安全内容之前提示"
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(36, 33)
        Me.TrackBar1.Maximum = 2
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(56, 173)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(208, 80)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(135, 15)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "-适用于大多数网站"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.Location = New System.Drawing.Point(149, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(46, 19)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "中-高"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(20, 242)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(224, 34)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "启动保护模式（要求重新启动" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Internet Explorer)(&P)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(461, 242)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(127, 38)
        Me.Button18.TabIndex = 1
        Me.Button18.Text = "默认级别（&D）"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(289, 242)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(145, 38)
        Me.Button17.TabIndex = 0
        Me.Button17.Text = "自定义级别（&C）"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 21)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(588, 268)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 42
        Me.LineShape1.X2 = 43
        Me.LineShape1.Y1 = 27
        Me.LineShape1.Y2 = 28
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(495, 210)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(122, 32)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = "站点（&S）"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.Location = New System.Drawing.Point(131, 236)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(337, 40)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "该区域适用于Internet网站，但不适用于在受信任" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "和受限制区域中列出的网站。"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.Location = New System.Drawing.Point(141, 217)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 19)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Internet"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(31, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(262, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "选择一个区域已查看或更改安全设置。"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(644, 748)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "隐私"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(644, 748)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "内容"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(644, 748)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "连接"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(644, 748)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "程序"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox7)
        Me.TabPage7.Controls.Add(Me.GroupBox2)
        Me.TabPage7.Controls.Add(Me.TreeView1)
        Me.TabPage7.Controls.Add(Me.Button15)
        Me.TabPage7.Controls.Add(Me.Label19)
        Me.TabPage7.Controls.Add(Me.Label18)
        Me.TabPage7.Controls.Add(Me.Label16)
        Me.TabPage7.Controls.Add(Me.Button14)
        Me.TabPage7.Controls.Add(Me.Label15)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(644, 748)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "高级"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(239, 520)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(337, 13)
        Me.GroupBox7.TabIndex = 63
        Me.GroupBox7.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(78, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(534, 10)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(38, 83)
        Me.TreeView1.Name = "TreeView1"
        TreeNode217.Checked = True
        TreeNode217.Name = "节点1"
        TreeNode217.Text = "使用HTTP1.1"
        TreeNode218.Checked = True
        TreeNode218.Name = "节点4"
        TreeNode218.Text = "使用HTTP2"
        TreeNode219.Name = "节点5"
        TreeNode219.Text = "通过代理连接使用HTTP1.1"
        TreeNode220.Name = "节点0"
        TreeNode220.Text = "HTTP设置"
        TreeNode221.Name = "节点6"
        TreeNode221.Text = "不将加密的页存盘"
        TreeNode222.Checked = True
        TreeNode222.Name = "节点7"
        TreeNode222.Text = "对证书地址不匹配发出警告*"
        TreeNode223.Name = "节点8"
        TreeNode223.Text = "关闭浏览器时清空""Internet临时文件""文件夹"
        TreeNode224.Checked = True
        TreeNode224.Name = "节点9"
        TreeNode224.Text = "检查发行商的证书是否已吊销"
        TreeNode225.Checked = True
        TreeNode225.Name = "节点10"
        TreeNode225.Text = "检查服务器证书是否已吊销"
        TreeNode226.Checked = True
        TreeNode226.Name = "节点11"
        TreeNode226.Text = "检查所下载程序的签名"
        TreeNode227.Checked = True
        TreeNode227.Name = "节点12"
        TreeNode227.Text = "将提交的POST重定向到不允许发送的区域时发出警告"
        TreeNode228.Checked = True
        TreeNode228.Name = "节点13"
        TreeNode228.Text = "启用DOM存储"
        TreeNode229.Checked = True
        TreeNode229.Name = "节点14"
        TreeNode229.Text = "启用SmartScreen筛选器"
        TreeNode230.Checked = True
        TreeNode230.Name = "节点15"
        TreeNode230.Text = "启用本机XMLHTTP支持"
        TreeNode231.Checked = True
        TreeNode231.Name = "节点16"
        TreeNode231.Text = "启用集成Windows验证*"
        TreeNode232.Checked = True
        TreeNode232.Name = "节点17"
        TreeNode232.Text = "启用增强保护模式*"
        TreeNode233.Checked = True
        TreeNode233.Name = "节点18"
        TreeNode233.Text = "使用SSL3.0"
        TreeNode234.Checked = True
        TreeNode234.Name = "节点19"
        TreeNode234.Text = "使用TLS1.0"
        TreeNode235.Checked = True
        TreeNode235.Name = "节点20"
        TreeNode235.Text = "使用TLS1.2"
        TreeNode236.Name = "节点21"
        TreeNode236.Text = "向你在Internrt Explorer中访问的站点发送""请勿跟踪""请求*"
        TreeNode237.Name = "节点22"
        TreeNode237.Text = "允许活动内容在""我的电脑""的文件中运行*"
        TreeNode238.Name = "节点23"
        TreeNode238.Text = "允许来自CD的活动内容在""我的电脑""中运行*"
        TreeNode239.Name = "节点24"
        TreeNode239.Text = "允许运行或安装软件，即使签名无效"
        TreeNode240.Name = "节点25"
        TreeNode240.Text = "在安全和非安全模式之前切换时发出警告"
        TreeNode241.Name = "节点26"
        TreeNode241.Text = "阻止混合了其他内容的不安全图像"
        TreeNode242.Name = "节点2"
        TreeNode242.Text = "安全"
        TreeNode243.Checked = True
        TreeNode243.Name = "节点29"
        TreeNode243.Text = "启用自动图像大小调整"
        TreeNode244.Checked = True
        TreeNode244.Name = "节点30"
        TreeNode244.Text = "显示图片"
        TreeNode245.Name = "节点31"
        TreeNode245.Text = "显示图像下载占位符"
        TreeNode246.Checked = True
        TreeNode246.Name = "节点32"
        TreeNode246.Text = "在HTML5媒体元素中启用备用的编码解码器*"
        TreeNode247.Checked = True
        TreeNode247.Name = "节点33"
        TreeNode247.Text = "在网页中播放动画*"
        TreeNode248.Checked = True
        TreeNode248.Name = "节点34"
        TreeNode248.Text = "在网页中播放声音"
        TreeNode249.Name = "节点3"
        TreeNode249.Text = "多媒体"
        TreeNode250.Name = "节点36"
        TreeNode250.Text = "播放系统声音"
        TreeNode251.Name = "节点37"
        TreeNode251.Text = "对新窗口和标签页启用插入光标浏览"
        TreeNode252.Name = "节点38"
        TreeNode252.Text = "对于新窗口和标签页，将文本大小重置为中等"
        TreeNode253.Name = "节点39"
        TreeNode253.Text = "对于新的窗口和标签页，重置缩放级别"
        TreeNode254.Name = "节点40"
        TreeNode254.Text = "始终扩展图像的说明文本"
        TreeNode255.Name = "节点41"
        TreeNode255.Text = "随焦点（或选择）的更改移动系统插入标记"
        TreeNode256.Name = "节点35"
        TreeNode256.Text = "辅助功能"
        TreeNode257.Name = "节点43"
        TreeNode257.Text = "发送Intranet URL 的IDN 服务器名称"
        TreeNode258.Name = "节点44"
        TreeNode258.Text = "发送Intranet URL 的UTF-8查询字符串"
        TreeNode259.Checked = True
        TreeNode259.Name = "节点45"
        TreeNode259.Text = "发送非Intranet URL 的IDN 服务器名称"
        TreeNode260.Name = "节点46"
        TreeNode260.Text = "发送Intranet URL 的UTF-8查询字符串"
        TreeNode261.Name = "节点47"
        TreeNode261.Text = "始终显示编码地址"
        TreeNode262.Checked = True
        TreeNode262.Name = "节点48"
        TreeNode262.Text = "显示编码地址通知栏"
        TreeNode263.Name = "节点49"
        TreeNode263.Text = "以UTF-8形式发送URL路径"
        TreeNode264.Name = "节点42"
        TreeNode264.Text = "国际*"
        TreeNode265.Name = ""
        TreeNode265.Text = "使用软件呈现而不使用GPU呈现"
        TreeNode266.Name = "节点50"
        TreeNode266.Text = "加速的图形"
        TreeNode267.Name = "节点53"
        TreeNode267.Text = "Always record developer console messages"
        TreeNode268.Name = "节点54"
        TreeNode268.Text = "关闭""历史记录""和""收藏夹""中未使用的文件夹"
        TreeNode269.Checked = True
        TreeNode269.Name = "节点55"
        TreeNode269.Text = "禁用脚本调式（Internet Explorer)"
        TreeNode270.Checked = True
        TreeNode270.Name = "节点56"
        TreeNode270.Text = "启用FTP文件夹视图（在Internet Explorer之外)"
        TreeNode271.Checked = True
        TreeNode271.Name = "节点57"
        TreeNode271.Text = "启用第三方浏览器扩展*"
        TreeNode272.Name = "节点58"
        TreeNode272.Text = "启用建议的网站"
        TreeNode273.Checked = True
        TreeNode273.Name = "节点59"
        TreeNode273.Text = "启用自动崩溃恢复*"
        TreeNode274.Checked = True
        TreeNode274.Name = "节点60"
        TreeNode274.Text = "如果Intetnet Explorer 不是默认的Web浏览器则告诉我"
        TreeNode275.Name = "节点61"
        TreeNode275.Text = "使用Ctrl+Tab切换标签页时，使用最新顺序"
        TreeNode276.Checked = True
        TreeNode276.Name = "节点62"
        TreeNode276.Text = "使用被动FTP（用于防火墙和DSL调制解调器的兼容）"
        TreeNode277.Checked = True
        TreeNode277.Name = "节点63"
        TreeNode277.Text = "使用平滑滚动"
        TreeNode278.Checked = True
        TreeNode278.Name = "节点64"
        TreeNode278.Text = "通过页面预测启用快速翻页"
        TreeNode279.Name = "节点2"
        TreeNode279.Text = "为链接加下划线"
        TreeNode280.Checked = True
        TreeNode280.Name = "节点3"
        TreeNode280.Text = "为网页上的按钮和控件启用视觉样式"
        TreeNode281.Checked = True
        TreeNode281.Name = "节点4"
        TreeNode281.Text = "下载完成后发出通知"
        TreeNode282.Name = "节点5"
        TreeNode282.Text = "显示每个脚本错误的通知"
        TreeNode283.Checked = True
        TreeNode283.Name = "节点6"
        TreeNode283.Text = "显示友好HTTP错误的通知"
        TreeNode284.Checked = True
        TreeNode284.Name = "节点7"
        TreeNode284.Text = "在Internet Explorer 地址栏和""打开""对话框中使用直接插入自动完成功能"
        TreeNode285.Checked = True
        TreeNode285.Name = ""
        TreeNode285.Text = "在后台加载站点和内容以优化性能"
        TreeNode286.Name = "节点9"
        TreeNode286.Text = "在文件资源管理器和""运行""对话框中使用直接插入自动完成功能"
        TreeNode287.Name = "节点10"
        TreeNode287.Text = "转到地址栏中的单字条目对应的Intranet站点"
        TreeNode288.Name = "节点52"
        TreeNode288.Text = "浏览"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode220, TreeNode242, TreeNode249, TreeNode256, TreeNode264, TreeNode266, TreeNode288})
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowPlusMinus = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(531, 332)
        Me.TreeView1.TabIndex = 61
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(441, 559)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(128, 42)
        Me.Button15.TabIndex = 59
        Me.Button15.Text = "重置（&S）"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(57, 609)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(382, 15)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "只有在浏览器处于无法使用的状态时，才应使用此设置。"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 569)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(316, 15)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "将Internet Explorer 设置重置为默认设置。"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 520)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(211, 15)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "重置Internet Explorer 设置"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(347, 468)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(205, 32)
        Me.Button14.TabIndex = 54
        Me.Button14.Text = "还原高级设置（&R）"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 431)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(210, 15)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "*在重新启动你的计算机后生效"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 15)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "设置"
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(447, 798)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(110, 39)
        Me.Button13.TabIndex = 7
        Me.Button13.Text = "应用（&A）"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(331, 798)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(110, 39)
        Me.Button12.TabIndex = 6
        Me.Button12.Text = "取消"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(215, 798)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 39)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "确定"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'From1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 872)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TabControl1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "From1"
        Me.Text = "Internet 属性"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox

End Class
