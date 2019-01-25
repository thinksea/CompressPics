namespace CompressPics
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView待处理文件 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cb转换为统一格式 = new System.Windows.Forms.CheckBox();
            this.gp调整大小 = new System.Windows.Forms.GroupBox();
            this.nud最大高度 = new System.Windows.Forms.NumericUpDown();
            this.nud最大宽度 = new System.Windows.Forms.NumericUpDown();
            this.cmb高度单位 = new System.Windows.Forms.ComboBox();
            this.cmb宽度单位 = new System.Windows.Forms.ComboBox();
            this.cb保持小图尺寸 = new System.Windows.Forms.CheckBox();
            this.cb保持原图比例 = new System.Windows.Forms.CheckBox();
            this.cb最大高度 = new System.Windows.Forms.CheckBox();
            this.cb最大宽度 = new System.Windows.Forms.CheckBox();
            this.cmb存盘格式 = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton添加文件 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton添加文件夹 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton开始 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton关于 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton退出 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel文件总数 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel正在处理的文件 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn缩略图 = new System.Windows.Forms.Button();
            this.btn列表 = new System.Windows.Forms.Button();
            this.btn复制日志信息到剪切板 = new System.Windows.Forms.Button();
            this.btn清空日志 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pic预览 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb输出图片质量 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gp调整大小.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud最大高度)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud最大宽度)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic预览)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView待处理文件
            // 
            this.listView待处理文件.AllowDrop = true;
            this.listView待处理文件.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView待处理文件.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView待处理文件.FullRowSelect = true;
            this.listView待处理文件.Location = new System.Drawing.Point(3, 27);
            this.listView待处理文件.Name = "listView待处理文件";
            this.listView待处理文件.Size = new System.Drawing.Size(476, 264);
            this.listView待处理文件.TabIndex = 3;
            this.listView待处理文件.UseCompatibleStateImageBehavior = false;
            this.listView待处理文件.View = System.Windows.Forms.View.Details;
            this.listView待处理文件.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView待处理文件_ColumnClick);
            this.listView待处理文件.SelectedIndexChanged += new System.EventHandler(this.listView待处理文件_SelectedIndexChanged);
            this.listView待处理文件.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView待处理文件_DragDrop);
            this.listView待处理文件.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView待处理文件_DragEnter);
            this.listView待处理文件.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView待处理文件_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "string";
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "datetime";
            this.columnHeader2.Text = "修改时间";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "filesize";
            this.columnHeader3.Text = "大小";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "imagesize";
            this.columnHeader4.Text = "尺寸";
            this.columnHeader4.Width = 80;
            // 
            // cb转换为统一格式
            // 
            this.cb转换为统一格式.AutoSize = true;
            this.cb转换为统一格式.Location = new System.Drawing.Point(9, 5);
            this.cb转换为统一格式.Name = "cb转换为统一格式";
            this.cb转换为统一格式.Size = new System.Drawing.Size(108, 16);
            this.cb转换为统一格式.TabIndex = 0;
            this.cb转换为统一格式.Text = "转换为统一格式";
            this.cb转换为统一格式.UseVisualStyleBackColor = true;
            this.cb转换为统一格式.CheckedChanged += new System.EventHandler(this.cb转换为统一格式_CheckedChanged);
            // 
            // gp调整大小
            // 
            this.gp调整大小.Controls.Add(this.nud最大高度);
            this.gp调整大小.Controls.Add(this.nud最大宽度);
            this.gp调整大小.Controls.Add(this.cmb高度单位);
            this.gp调整大小.Controls.Add(this.cmb宽度单位);
            this.gp调整大小.Controls.Add(this.cb保持小图尺寸);
            this.gp调整大小.Controls.Add(this.cb保持原图比例);
            this.gp调整大小.Controls.Add(this.cb最大高度);
            this.gp调整大小.Controls.Add(this.cb最大宽度);
            this.gp调整大小.Dock = System.Windows.Forms.DockStyle.Top;
            this.gp调整大小.Location = new System.Drawing.Point(0, 62);
            this.gp调整大小.Name = "gp调整大小";
            this.gp调整大小.Size = new System.Drawing.Size(288, 98);
            this.gp调整大小.TabIndex = 3;
            this.gp调整大小.TabStop = false;
            this.gp调整大小.Text = "调整尺寸";
            // 
            // nud最大高度
            // 
            this.nud最大高度.Enabled = false;
            this.nud最大高度.Location = new System.Drawing.Point(84, 46);
            this.nud最大高度.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud最大高度.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud最大高度.Name = "nud最大高度";
            this.nud最大高度.Size = new System.Drawing.Size(86, 21);
            this.nud最大高度.TabIndex = 4;
            this.nud最大高度.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // nud最大宽度
            // 
            this.nud最大宽度.Enabled = false;
            this.nud最大宽度.Location = new System.Drawing.Point(84, 19);
            this.nud最大宽度.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud最大宽度.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud最大宽度.Name = "nud最大宽度";
            this.nud最大宽度.Size = new System.Drawing.Size(86, 21);
            this.nud最大宽度.TabIndex = 1;
            this.nud最大宽度.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // cmb高度单位
            // 
            this.cmb高度单位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb高度单位.Enabled = false;
            this.cmb高度单位.FormattingEnabled = true;
            this.cmb高度单位.Location = new System.Drawing.Point(176, 46);
            this.cmb高度单位.Name = "cmb高度单位";
            this.cmb高度单位.Size = new System.Drawing.Size(55, 20);
            this.cmb高度单位.TabIndex = 5;
            // 
            // cmb宽度单位
            // 
            this.cmb宽度单位.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb宽度单位.Enabled = false;
            this.cmb宽度单位.FormattingEnabled = true;
            this.cmb宽度单位.Location = new System.Drawing.Point(176, 19);
            this.cmb宽度单位.Name = "cmb宽度单位";
            this.cmb宽度单位.Size = new System.Drawing.Size(55, 20);
            this.cmb宽度单位.TabIndex = 2;
            // 
            // cb保持小图尺寸
            // 
            this.cb保持小图尺寸.AutoSize = true;
            this.cb保持小图尺寸.Checked = true;
            this.cb保持小图尺寸.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb保持小图尺寸.Enabled = false;
            this.cb保持小图尺寸.Location = new System.Drawing.Point(108, 73);
            this.cb保持小图尺寸.Name = "cb保持小图尺寸";
            this.cb保持小图尺寸.Size = new System.Drawing.Size(120, 16);
            this.cb保持小图尺寸.TabIndex = 7;
            this.cb保持小图尺寸.Text = "保持小图尺寸不变";
            this.toolTip1.SetToolTip(this.cb保持小图尺寸, "只缩小不放大。即：如果原图小于最大尺寸，则不进行缩放。");
            this.cb保持小图尺寸.UseVisualStyleBackColor = true;
            this.cb保持小图尺寸.CheckedChanged += new System.EventHandler(this.cb保持小图尺寸_CheckedChanged);
            // 
            // cb保持原图比例
            // 
            this.cb保持原图比例.AutoSize = true;
            this.cb保持原图比例.Checked = true;
            this.cb保持原图比例.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb保持原图比例.Enabled = false;
            this.cb保持原图比例.Location = new System.Drawing.Point(6, 73);
            this.cb保持原图比例.Name = "cb保持原图比例";
            this.cb保持原图比例.Size = new System.Drawing.Size(96, 16);
            this.cb保持原图比例.TabIndex = 6;
            this.cb保持原图比例.Text = "保持原图比例";
            this.cb保持原图比例.UseVisualStyleBackColor = true;
            this.cb保持原图比例.CheckedChanged += new System.EventHandler(this.cb保持原图比例_CheckedChanged);
            // 
            // cb最大高度
            // 
            this.cb最大高度.AutoSize = true;
            this.cb最大高度.Location = new System.Drawing.Point(6, 48);
            this.cb最大高度.Name = "cb最大高度";
            this.cb最大高度.Size = new System.Drawing.Size(72, 16);
            this.cb最大高度.TabIndex = 3;
            this.cb最大高度.Text = "最大高度";
            this.cb最大高度.UseVisualStyleBackColor = true;
            this.cb最大高度.CheckedChanged += new System.EventHandler(this.cb最大高度_CheckedChanged);
            // 
            // cb最大宽度
            // 
            this.cb最大宽度.AutoSize = true;
            this.cb最大宽度.Location = new System.Drawing.Point(6, 21);
            this.cb最大宽度.Name = "cb最大宽度";
            this.cb最大宽度.Size = new System.Drawing.Size(72, 16);
            this.cb最大宽度.TabIndex = 0;
            this.cb最大宽度.Text = "最大宽度";
            this.cb最大宽度.UseVisualStyleBackColor = true;
            this.cb最大宽度.CheckedChanged += new System.EventHandler(this.cb最大宽度_CheckedChanged);
            // 
            // cmb存盘格式
            // 
            this.cmb存盘格式.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb存盘格式.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb存盘格式.Enabled = false;
            this.cmb存盘格式.FormattingEnabled = true;
            this.cmb存盘格式.Location = new System.Drawing.Point(123, 3);
            this.cmb存盘格式.Name = "cmb存盘格式";
            this.cmb存盘格式.Size = new System.Drawing.Size(158, 20);
            this.cmb存盘格式.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton添加文件,
            this.toolStripButton添加文件夹,
            this.toolStripButton开始,
            this.toolStripButton关于,
            this.toolStripButton退出});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton添加文件
            // 
            this.toolStripButton添加文件.Image = global::CompressPics.Properties.Resources.image;
            this.toolStripButton添加文件.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton添加文件.Name = "toolStripButton添加文件";
            this.toolStripButton添加文件.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton添加文件.Text = "添加文件";
            this.toolStripButton添加文件.Click += new System.EventHandler(this.toolStripButton添加文件_Click);
            // 
            // toolStripButton添加文件夹
            // 
            this.toolStripButton添加文件夹.Image = global::CompressPics.Properties.Resources.folder;
            this.toolStripButton添加文件夹.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton添加文件夹.Name = "toolStripButton添加文件夹";
            this.toolStripButton添加文件夹.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton添加文件夹.Text = "添加文件夹";
            this.toolStripButton添加文件夹.Click += new System.EventHandler(this.toolStripButton添加文件夹_Click);
            // 
            // toolStripButton开始
            // 
            this.toolStripButton开始.Enabled = false;
            this.toolStripButton开始.Image = global::CompressPics.Properties.Resources.run;
            this.toolStripButton开始.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton开始.Name = "toolStripButton开始";
            this.toolStripButton开始.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton开始.Text = "开始";
            this.toolStripButton开始.Click += new System.EventHandler(this.toolStripButton开始_Click);
            // 
            // toolStripButton关于
            // 
            this.toolStripButton关于.Image = global::CompressPics.Properties.Resources.help;
            this.toolStripButton关于.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton关于.Name = "toolStripButton关于";
            this.toolStripButton关于.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton关于.Text = "关于";
            this.toolStripButton关于.Click += new System.EventHandler(this.toolStripButton关于_Click);
            // 
            // toolStripButton退出
            // 
            this.toolStripButton退出.Image = global::CompressPics.Properties.Resources.close;
            this.toolStripButton退出.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton退出.Name = "toolStripButton退出";
            this.toolStripButton退出.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton退出.Text = "退出";
            this.toolStripButton退出.Click += new System.EventHandler(this.toolStripButton退出_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel文件总数,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel正在处理的文件,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel文件总数
            // 
            this.toolStripStatusLabel文件总数.Name = "toolStripStatusLabel文件总数";
            this.toolStripStatusLabel文件总数.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel文件总数.Tag = "文件总数：{0}";
            this.toolStripStatusLabel文件总数.Text = "文件总数：0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "正在处理：";
            // 
            // toolStripStatusLabel正在处理的文件
            // 
            this.toolStripStatusLabel正在处理的文件.Name = "toolStripStatusLabel正在处理的文件";
            this.toolStripStatusLabel正在处理的文件.Size = new System.Drawing.Size(474, 17);
            this.toolStripStatusLabel正在处理的文件.Spring = true;
            this.toolStripStatusLabel正在处理的文件.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件列表：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pic预览);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(784, 421);
            this.splitContainer1.SplitterDistance = 482;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btn缩略图);
            this.splitContainer2.Panel1.Controls.Add(this.listView待处理文件);
            this.splitContainer2.Panel1.Controls.Add(this.btn列表);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn复制日志信息到剪切板);
            this.splitContainer2.Panel2.Controls.Add(this.btn清空日志);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(482, 421);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.TabIndex = 4;
            // 
            // btn缩略图
            // 
            this.btn缩略图.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn缩略图.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn缩略图.Image = global::CompressPics.Properties.Resources.largeicon;
            this.btn缩略图.Location = new System.Drawing.Point(438, 5);
            this.btn缩略图.Name = "btn缩略图";
            this.btn缩略图.Size = new System.Drawing.Size(21, 21);
            this.btn缩略图.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn缩略图, "缩略图");
            this.btn缩略图.UseVisualStyleBackColor = true;
            this.btn缩略图.Click += new System.EventHandler(this.btn缩略图_Click);
            // 
            // btn列表
            // 
            this.btn列表.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn列表.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn列表.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn列表.Image = global::CompressPics.Properties.Resources.details;
            this.btn列表.Location = new System.Drawing.Point(458, 5);
            this.btn列表.Name = "btn列表";
            this.btn列表.Size = new System.Drawing.Size(21, 21);
            this.btn列表.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn列表, "详细信息");
            this.btn列表.UseVisualStyleBackColor = false;
            this.btn列表.Click += new System.EventHandler(this.btn列表_Click);
            // 
            // btn复制日志信息到剪切板
            // 
            this.btn复制日志信息到剪切板.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn复制日志信息到剪切板.Image = global::CompressPics.Properties.Resources.copy;
            this.btn复制日志信息到剪切板.Location = new System.Drawing.Point(51, 2);
            this.btn复制日志信息到剪切板.Name = "btn复制日志信息到剪切板";
            this.btn复制日志信息到剪切板.Size = new System.Drawing.Size(21, 21);
            this.btn复制日志信息到剪切板.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn复制日志信息到剪切板, "复制日志信息到“剪贴板”");
            this.btn复制日志信息到剪切板.UseVisualStyleBackColor = true;
            this.btn复制日志信息到剪切板.Click += new System.EventHandler(this.btn复制日志信息到剪切板_Click);
            // 
            // btn清空日志
            // 
            this.btn清空日志.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn清空日志.Image = global::CompressPics.Properties.Resources.delete;
            this.btn清空日志.Location = new System.Drawing.Point(73, 2);
            this.btn清空日志.Name = "btn清空日志";
            this.btn清空日志.Size = new System.Drawing.Size(21, 21);
            this.btn清空日志.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn清空日志, "清除所有日志");
            this.btn清空日志.UseVisualStyleBackColor = true;
            this.btn清空日志.Click += new System.EventHandler(this.btn清空日志_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "日志：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(476, 94);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // pic预览
            // 
            this.pic预览.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic预览.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic预览.InitialImage = global::CompressPics.Properties.Resources.loading;
            this.pic预览.Location = new System.Drawing.Point(5, 5);
            this.pic预览.Name = "pic预览";
            this.pic预览.Size = new System.Drawing.Size(288, 249);
            this.pic预览.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic预览.TabIndex = 1;
            this.pic预览.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gp调整大小);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 254);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(288, 162);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmb输出图片质量);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cb转换为统一格式);
            this.panel3.Controls.Add(this.cmb存盘格式);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 57);
            this.panel3.TabIndex = 2;
            // 
            // cmb输出图片质量
            // 
            this.cmb输出图片质量.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb输出图片质量.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb输出图片质量.FormattingEnabled = true;
            this.cmb输出图片质量.Location = new System.Drawing.Point(123, 29);
            this.cmb输出图片质量.Name = "cmb输出图片质量";
            this.cmb输出图片质量.Size = new System.Drawing.Size(158, 20);
            this.cmb输出图片质量.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出图片质量";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 468);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 507);
            this.Name = "Form1";
            this.Text = "Thinksea Compress Pictures";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp调整大小.ResumeLayout(false);
            this.gp调整大小.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud最大高度)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud最大宽度)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic预览)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView待处理文件;
        private System.Windows.Forms.PictureBox pic预览;
        private System.Windows.Forms.CheckBox cb转换为统一格式;
        private System.Windows.Forms.GroupBox gp调整大小;
        private System.Windows.Forms.NumericUpDown nud最大高度;
        private System.Windows.Forms.NumericUpDown nud最大宽度;
        private System.Windows.Forms.CheckBox cb最大高度;
        private System.Windows.Forms.CheckBox cb最大宽度;
        private System.Windows.Forms.CheckBox cb保持原图比例;
        private System.Windows.Forms.ComboBox cmb存盘格式;
        private System.Windows.Forms.ComboBox cmb高度单位;
        private System.Windows.Forms.ComboBox cmb宽度单位;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel正在处理的文件;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripButton toolStripButton开始;
        private System.Windows.Forms.ToolStripButton toolStripButton关于;
        private System.Windows.Forms.ToolStripButton toolStripButton退出;
        private System.Windows.Forms.CheckBox cb保持小图尺寸;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn列表;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn缩略图;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel文件总数;
        private System.Windows.Forms.ToolStripButton toolStripButton添加文件;
        private System.Windows.Forms.ToolStripButton toolStripButton添加文件夹;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn清空日志;
        private System.Windows.Forms.Button btn复制日志信息到剪切板;
        private System.Windows.Forms.ComboBox cmb输出图片质量;
        private System.Windows.Forms.Label label2;
    }
}

