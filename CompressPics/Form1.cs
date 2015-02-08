using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompressPics
{
    public partial class Form1 : Form
    {
        private System.Collections.Generic.List<ImageFormat> ImageFormats = new List<ImageFormat>();
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, Thinksea.eImageQuality>> 输出图片质量s = new List<KeyValuePair<string, Thinksea.eImageQuality>>();
        private ImageList LargeImageList = new ImageList();

        public Form1()
        {
            InitializeComponent();
        }

        #region Invoke
        /// <summary>
        /// 获取指定控件的属性值代理。
        /// </summary>
        /// <param name="ctl">控件。</param>
        /// <param name="propertyName">属性名称。</param>
        /// <returns>指定属性的值。</returns>
        public delegate object GetPropertyValueHandler(System.Windows.Forms.Control ctl, string propertyName);
        /// <summary>
        /// 获取指定控件的属性值。
        /// </summary>
        /// <param name="ctl">控件。</param>
        /// <param name="propertyName">属性名称。</param>
        /// <returns>指定属性的值。</returns>
        public object GetPropertyValue(System.Windows.Forms.Control ctl, string propertyName)
        {
            if (this.InvokeRequired)
            {
                return this.Invoke(new GetPropertyValueHandler(this.GetPropertyValue), ctl, propertyName);
            }
            else
            {
                return ctl.GetType().GetProperty(propertyName).GetValue(ctl, null);
            }
        }

        /// <summary>
        /// 为指定控件的属性赋值代理。
        /// </summary>
        /// <param name="ctl">控件。</param>
        /// <param name="propertyName">属性名称。</param>
        /// <param name="value">值。</param>
        /// <returns>指定属性的值。</returns>
        public delegate void SetPropertyHandler(System.ComponentModel.Component ctl, string propertyName, object value);
        /// <summary>
        /// 为指定控件的属性赋值。
        /// </summary>
        /// <param name="ctl">控件。</param>
        /// <param name="propertyName">属性名称。</param>
        /// <param name="value">新值。</param>
        /// <returns>指定属性的值。</returns>
        public void SetPropertyValue(System.ComponentModel.Component ctl, string propertyName, object value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetPropertyHandler(this.SetPropertyValue), ctl, propertyName, value);
            }
            else
            {
                ctl.GetType().GetProperty(propertyName).SetValue(ctl, value, null);
            }
        }

        private delegate void AddFileToImageListHandler(ImageList imageList, string file, System.Drawing.Image img);
        private void AddFileToImageList(ImageList imageList, string file, System.Drawing.Image img)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddFileToImageListHandler(this.AddFileToImageList), imageList, file, img);
            }
            else
            {
                imageList.Images.Add(file, img);
            }
        }

        public delegate void AddListViewItemHandler(ListView listView, ListViewItem item);
        /// <summary>
        /// 获取指定控件的属性值。
        /// </summary>
        /// <returns>需要处理的文件。</returns>
        public void AddListViewItem(ListView listView, ListViewItem item)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AddListViewItemHandler(this.AddListViewItem), listView, item);
            }
            else
            {
                listView.Items.Add(item);
            }
        }

        public delegate bool ContainsListViewItemHandler(ListView listView, string file);
        public bool ContainsListViewItem(ListView listView, string file)
        {
            if (this.InvokeRequired)
            {
                return (bool)this.Invoke(new ContainsListViewItemHandler(this.ContainsListViewItem), listView, file);
            }
            else
            {
                return listView.Items.ContainsKey(file);
            }
        }

        private delegate void BeginUpdateControlHandler(System.Windows.Forms.ListView ctl);
        private void BeginUpdateControl(System.Windows.Forms.ListView ctl)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new BeginUpdateControlHandler(this.BeginUpdateControl), ctl);
            }
            else
            {
                ctl.BeginUpdate();
            }
        }
        private void EndUpdateControl(System.Windows.Forms.ListView ctl)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new BeginUpdateControlHandler(this.EndUpdateControl), ctl);
            }
            else
            {
                ctl.EndUpdate();
            }
        }

        #endregion

        private delegate void WriteLogHandler(string msg);
        private void WriteLog(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new WriteLogHandler(this.WriteLog), msg);
            }
            else
            {
                this.richTextBox1.AppendText(string.Format(@"【{0}】{1}
", System.DateTime.Now.ToString("MM-dd HH:mm:ss"), msg));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LargeImageList.ImageSize = new System.Drawing.Size(80, 80);
            this.LargeImageList.ColorDepth = ColorDepth.Depth24Bit;

            this.listView待处理文件.ListViewItemSorter = new ListViewColumnSorter();
            this.listView待处理文件.LargeImageList = this.LargeImageList;

            {
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Jpeg, ".jpg", "JPEG 格式(*.jpg)"));
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Jpeg, ".jpeg", "JPEG 格式(*.jpeg)"));
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Png, ".png", "PNG 格式(*.png)"));
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Gif, ".gif", "GIF 格式(*.gif)"));
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Bmp, ".bmp", "BMP 格式(*.bmp)"));
                this.ImageFormats.Add(new ImageFormat(System.Drawing.Imaging.ImageFormat.Tiff, ".tif", "TIFF 格式(*.tif)"));
                //this.ImageFormats.Add(new 图片文件格式(System.Drawing.Imaging.ImageFormat.Icon, ".ico", "Windows 图标格式(*.ico)"));
                this.cmb存盘格式.DisplayMember = "Declaration";
                this.cmb存盘格式.ValueMember = "Format";
                this.cmb存盘格式.DataSource = this.ImageFormats;
            }

            {
                System.Text.StringBuilder ext = new StringBuilder();
                foreach (var tmp in this.ImageFormats)
                {
                    if (ext.Length > 0)
                    {
                        ext.Append(";");
                    }
                    ext.Append("*" + tmp.Extension);
                }
                if (ext.Length > 0)
                {
                    ext.Insert(0, "图片|");
                    ext.Append("|");
                }
                ext.Append("所有文件|*.*");
                //图片|*.png;*.bmp;*.jpg;*.gif|所有文件|*.*
                this.openFileDialog1.Filter = ext.ToString();
            }

            {
                this.输出图片质量s.Add(new KeyValuePair<string, Thinksea.eImageQuality>("高", Thinksea.eImageQuality.High));
                this.输出图片质量s.Add(new KeyValuePair<string, Thinksea.eImageQuality>("低", Thinksea.eImageQuality.Low));
                this.cmb输出图片质量.DisplayMember = "Key";
                this.cmb输出图片质量.ValueMember = "Value";
                this.cmb输出图片质量.DataSource = this.输出图片质量s;
                this.cmb输出图片质量.SelectedValue = Thinksea.eImageQuality.Low;
            }

            {
                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, eUnit>> formats = new List<KeyValuePair<string, eUnit>>();
                formats.Add(new KeyValuePair<string, eUnit>("像素", eUnit.px));
                //formats.Add(new KeyValuePair<string, e宽度单位>("%", e宽度单位.pre));
                this.cmb宽度单位.DisplayMember = "Key";
                this.cmb宽度单位.ValueMember = "Value";
                this.cmb宽度单位.DataSource = formats;
            }

            {
                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, eUnit>> formats = new List<KeyValuePair<string, eUnit>>();
                formats.Add(new KeyValuePair<string, eUnit>("像素", eUnit.px));
                //formats.Add(new KeyValuePair<string, e宽度单位>("%", e宽度单位.pre));
                this.cmb高度单位.DisplayMember = "Key";
                this.cmb高度单位.ValueMember = "Value";
                this.cmb高度单位.DataSource = formats;
            }

            this.cb最大宽度.Checked = true;
            this.cb最大高度.Checked = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.thread压缩 != null || this.thread添加文件 != null)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    if (MessageBox.Show(this, "有尚未完成的任务，是否中止任务？", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.请求中止全部任务 = true;
                    }
                }
                else
                {
                    this.请求中止全部任务 = true;
                    //e.Cancel = true;
                }
            }
        }

        private void cb转换为统一格式_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb存盘格式.Enabled = this.cb转换为统一格式.Checked;
        }

        private void cb最大宽度_CheckedChanged(object sender, EventArgs e)
        {
            this.nud最大宽度.Enabled = this.cb最大宽度.Checked;
            this.cmb宽度单位.Enabled = this.cb最大宽度.Checked;
            if (this.cb最大宽度.Checked || this.cb最大高度.Checked)
            {
                this.cb保持原图比例.Enabled = true;
                this.cb保持小图尺寸.Enabled = true;
            }
            else
            {
                this.cb保持原图比例.Enabled = false;
                this.cb保持小图尺寸.Enabled = false;
            }
            if (!this.cb最大宽度.Checked)
            {
                this.cb保持原图比例.Checked = true;
                this.cb保持小图尺寸.Checked = true;
            }
        }

        private void cb最大高度_CheckedChanged(object sender, EventArgs e)
        {
            this.nud最大高度.Enabled = this.cb最大高度.Checked;
            this.cmb高度单位.Enabled = this.cb最大高度.Checked;
            if (this.cb最大宽度.Checked || this.cb最大高度.Checked)
            {
                this.cb保持原图比例.Enabled = true;
                this.cb保持小图尺寸.Enabled = true;
            }
            else
            {
                this.cb保持原图比例.Enabled = false;
                this.cb保持小图尺寸.Enabled = false;
            }
            if (!this.cb最大高度.Checked)
            {
                this.cb保持原图比例.Checked = true;
                this.cb保持小图尺寸.Checked = true;
            }
        }

        private void listView待处理文件_DragDrop(object sender, DragEventArgs e)
        {
            System.String[] files = (System.String[])(e.Data.GetData("FileDrop"));
            System.Collections.Generic.List<string> f = new List<string>();
            foreach (string tmp in files)
            {
                if (System.IO.File.Exists(tmp))
                {
                    f.Add(tmp);
                }
                else if (System.IO.Directory.Exists(tmp))
                {
                    string[] f2 = System.IO.Directory.GetFiles(tmp, "*.*", System.IO.SearchOption.AllDirectories);
                    f.AddRange(f2);
                }
            }
            this.AddFiles(f.ToArray());
        }

        private void listView待处理文件_DragEnter(object sender, DragEventArgs e)
        {
            if (this.thread添加文件 != null || this.thread压缩 != null)
            {
                e.Effect = System.Windows.Forms.DragDropEffects.None;
                return;
            }
            if (e.Data.GetDataPresent("FileDrop"))
            {
                e.Effect = System.Windows.Forms.DragDropEffects.Copy;
            }
        }

        private void listView待处理文件_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView待处理文件.SelectedItems.Count > 0)
            {
                string file = (string)this.listView待处理文件.SelectedItems[0].Tag;
                this.pic预览.ImageLocation = file;
            }
            else
            {
                this.pic预览.ImageLocation = "";
            }
        }

        private void listView待处理文件_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewColumnSorter lvcs = (ListViewColumnSorter)this.listView待处理文件.ListViewItemSorter;
            if (e.Column == lvcs.SortColumn)
            {
                // 重新设置此列的排序方法.
                if (lvcs.Order == SortOrder.Ascending)
                {
                    lvcs.Order = SortOrder.Descending;
                }
                else
                {
                    lvcs.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // 设置排序列，默认为正向排序
                lvcs.SortColumn = e.Column;
                lvcs.DateType = (string)this.listView待处理文件.Columns[e.Column].Tag;
                lvcs.Order = SortOrder.Ascending;
            }
            // 用新的排序方法对ListView排序
            this.listView待处理文件.Sort();

        }

        private void listView待处理文件_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.thread添加文件 == null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    ListView.SelectedListViewItemCollection slvic = this.listView待处理文件.SelectedItems;
                    foreach (ListViewItem item in slvic)
                    {
                        string file = (string)item.Tag;
                        this.LargeImageList.Images.RemoveByKey(file);
                        this.listView待处理文件.Items.Remove(item);
                    }
                    foreach (ListViewItem item in this.listView待处理文件.Items)
                    {
                        string file = (string)item.Tag;
                        int index = this.LargeImageList.Images.IndexOfKey(file);
                        item.ImageIndex = index;
                    }
                    this.SetPropertyValue(this.toolStripButton开始, "Enabled", (this.listView待处理文件.Items.Count > 0));
                }
                else if (e.Control && e.KeyCode == Keys.A)
                {
                    foreach (ListViewItem item in this.listView待处理文件.Items)
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        private void btn缩略图_Click(object sender, EventArgs e)
        {
            this.listView待处理文件.View = View.LargeIcon;
        }

        private void btn列表_Click(object sender, EventArgs e)
        {
            this.listView待处理文件.View = View.Details;
        }

        private void cb保持原图比例_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cb保持原图比例.Checked)
            {
                this.cb最大宽度.Checked = true;
                this.cb最大高度.Checked = true;
            }
        }

        private void cb保持小图尺寸_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.cb保持小图尺寸.Checked)
            {
                this.cb最大宽度.Checked = true;
                this.cb最大高度.Checked = true;
            }
        }

        public delegate string[] GetFilesHandler();
        /// <summary>
        /// 获取指定控件的属性值。
        /// </summary>
        /// <returns>需要处理的文件。</returns>
        public string[] GetFiles()
        {
            if (this.InvokeRequired)
            {
                return (string[])this.Invoke(new GetFilesHandler(this.GetFiles));
            }
            else
            {
                System.Collections.Generic.List<string> files = new List<string>();
                foreach (ListViewItem item in this.listView待处理文件.Items)
                {
                    files.Add((string)item.Tag);
                }

                return files.ToArray();
            }
        }

        private System.Threading.Thread thread添加文件 = null;
        private void AddFiles(string[] files)
        {
            if (this.thread添加文件 != null)
            {
                throw new System.Exception("禁止同时执行多个添加文件任务。");
            }
            if (this.thread压缩 != null)
            {
                throw new System.Exception("禁止执行添加文件任务，因为正在执行图片压缩任务。");
            }
            this.请求中止全部任务 = false;
            this.toolStripButton添加文件.Enabled = false;
            this.toolStripButton添加文件夹.Enabled = false;
            this.toolStripButton开始.Enabled = false;
            this.timer1.Start();

            this.thread添加文件 = new System.Threading.Thread(this.AddFilesThread);
            this.thread添加文件.Start(files);
        }

        private string 正在处理的文件 = "";
        private void AddFilesThread(object arg)
        {
            try
            {
                string[] files = (string[])arg;
                this.BeginUpdateControl(this.listView待处理文件);
                this.SetPropertyValue(this.toolStripProgressBar1, "Maximum", files.Length);
                for (int i = 0; i < files.Length && this.请求中止全部任务 == false; i++)
                {
                    string file = files[i];
                    this.SetPropertyValue(this.toolStripProgressBar1, "Value", i);
                    this.正在处理的文件 = file;
                    if (this.ContainsListViewItem(this.listView待处理文件, file))
                    {
                        continue;
                    }
                    string ext = System.IO.Path.GetExtension(file);
                    foreach (var tmp in this.ImageFormats)
                    {
                        if (tmp.Extension == ext.ToLower())
                        {
                            if (!this.LargeImageList.Images.ContainsKey(file))
                            {
                                System.Drawing.Image img = Thinksea.Image.GetThumbnailImage(file, this.LargeImageList.ImageSize.Width, this.LargeImageList.ImageSize.Height, true, true, Thinksea.eImageQuality.Low, false, System.Drawing.Color.Transparent);
                                //System.Drawing.Image img = System.Drawing.Bitmap.FromFile(file);
                                this.AddFileToImageList(this.LargeImageList, file, img);
                            }

                            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file);
                            ListViewItem item = new ListViewItem();
                            item.Name = file;
                            item.Text = file;
                            item.SubItems.Add(fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                            item.SubItems.Add(string.Format("{0:N0} KB", System.Math.Ceiling(fileInfo.Length / 1024D)));
                            Size imgSize = Thinksea.Image.GetImageSize(file);
                            item.SubItems.Add(string.Format("{0} x {1}", imgSize.Width, imgSize.Height));
                            //item.ImageKey = file;
                            item.ImageIndex = this.LargeImageList.Images.IndexOfKey(file);
                            item.Tag = file;
                            this.AddListViewItem(this.listView待处理文件, item);
                            break;
                        }
                    }
                    this.SetPropertyValue(this.toolStripStatusLabel文件总数, "Text", string.Format((string)this.toolStripStatusLabel文件总数.Tag, this.listView待处理文件.Items.Count));
                }
                if (this.请求中止全部任务)
                {
                    //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", "用户中止任务。");
                    this.正在处理的文件 = "用户中止任务。";
                }
                else
                {
                    this.SetPropertyValue(this.toolStripProgressBar1, "Value", files.Length);
                    //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", "任务已完成。");
                    this.正在处理的文件 = "任务已完成。";
                }
            }
            finally
            {
                this.EndUpdateControl(this.listView待处理文件);
                this.SetPropertyValue(this.toolStripButton添加文件, "Enabled", true);
                this.SetPropertyValue(this.toolStripButton添加文件夹, "Enabled", true);
                this.SetPropertyValue(this.toolStripButton开始, "Enabled", (this.listView待处理文件.Items.Count > 0));
                //this.timer1.Stop();
                this.thread添加文件 = null;
            }
        }

        private void Run()
        {
            try
            {
                bool 保持原图比例 = (bool)this.GetPropertyValue(this.cb保持原图比例, "Checked");
                bool 保持小图尺寸 = (bool)this.GetPropertyValue(this.cb保持小图尺寸, "Checked");
                bool 转换为统一格式 = (bool)this.GetPropertyValue(this.cb转换为统一格式, "Checked");
                Thinksea.eImageQuality 图片质量 = (Thinksea.eImageQuality)this.GetPropertyValue(this.cmb输出图片质量, "SelectedValue");
                System.Drawing.Imaging.ImageFormat 统一文件格式 = (System.Drawing.Imaging.ImageFormat)this.GetPropertyValue(this.cmb存盘格式, "SelectedValue");
                int maxWidth = 0;
                if ((bool)this.GetPropertyValue(this.cb最大宽度, "Checked"))
                {
                    maxWidth = System.Convert.ToInt32(this.GetPropertyValue(this.nud最大宽度, "Value"));
                }
                int maxHeight = 0;
                if ((bool)this.GetPropertyValue(this.cb最大高度, "Checked"))
                {
                    maxHeight = System.Convert.ToInt32(this.GetPropertyValue(this.nud最大高度, "Value"));
                }

                string[] files = this.GetFiles();
                this.SetPropertyValue(this.toolStripProgressBar1, "Maximum", files.Length);

                for (int i = 0; i < files.Length && this.请求中止全部任务 == false; i++)
                {
                    string file = files[i];
                    this.SetPropertyValue(this.toolStripProgressBar1, "Value", i);
                    //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", file);
                    this.正在处理的文件 = file;
                    string outputFile = file;
                    System.IO.MemoryStream outputTempFileStream = new System.IO.MemoryStream();

                    System.Drawing.Imaging.ImageFormat imageFormat;
                    System.Drawing.Bitmap bmp = Thinksea.Image.GetThumbnailImage(file, maxWidth, maxHeight, 保持原图比例, 保持小图尺寸, 图片质量, false, System.Drawing.Color.Transparent);
                    try
                    {
                        imageFormat = bmp.RawFormat;
                        if (转换为统一格式)
                        {
                            imageFormat = 统一文件格式;
                        }
                        else
                        {
                            string ext = System.IO.Path.GetExtension(file);
                            foreach (var tmp in this.ImageFormats)
                            {
                                if (tmp.Extension == ext.ToLower())
                                {
                                    imageFormat = tmp.Format;
                                    break;
                                }
                            }
                        }

                        //bmp.Save(outputTempFile, imageFormat);
                        bmp.Save(outputTempFileStream, imageFormat);
                    }
                    finally
                    {
                        bmp.Dispose();
                    }

                    //                    {
                    //                        System.IO.FileInfo fiSource = new System.IO.FileInfo(file);
                    //                        System.IO.FileInfo fiTemp = new System.IO.FileInfo(outputTempFile);
                    //                        if (fiTemp.Length > fiSource.Length)
                    //                        {
                    //                            fiTemp.Delete();
                    //                            fiSource.CopyTo(outputTempFile);
                    //                            this.WriteLog(string.Format(@"文件压缩失败，由于压缩后比原始文件大，所以输出文件使用原始文件数据。
                    //    文件：{0}", file));
                    //                        }
                    //                    }

                    //                    if (System.IO.File.Exists(outputFile))
                    //                    {
                    //                        System.IO.File.Delete(outputFile);
                    //                    }
                    //                    System.IO.File.Move(outputTempFile, outputFile);
                    System.IO.FileInfo fiSource = new System.IO.FileInfo(file);
                    System.IO.FileInfo fiOutputFile = new System.IO.FileInfo(outputFile);
                    if (outputTempFileStream.Length < fiSource.Length) //如果可以压缩的更小则保留压缩后的文件。
                    {
                        string outputTempFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(outputFile), System.Guid.NewGuid().ToString("N"));
                        System.IO.File.WriteAllBytes(outputTempFile, outputTempFileStream.ToArray()); //输出到临时文件。
                        if (System.IO.File.Exists(outputFile)) //删除目标文件。
                        {
                            System.IO.File.Delete(outputFile);
                        }
                        //if (fiSource.FullName != fiOutputFile.FullName) //删除原始文件。
                        //{
                        //    fiSource.Delete();
                        //}
                        System.IO.File.Move(outputTempFile, outputFile); //将临时文件名更名为目标文件。
                    }
                    else
                    {
                        if (fiSource.FullName != fiOutputFile.FullName) //如果原始文件与目标文件名称不同则直接改名，否则保留原始文件即可。
                        {
                            //fiTemp.Delete();
                            //fiSource.CopyTo(outputTempFile);
                            System.IO.File.Move(file, outputFile); //将临时文件名更名为目标文件。
                        }
                        this.WriteLog(string.Format(@"文件压缩失败，由于压缩后比原始文件大，所以输出文件使用原始文件数据。
    文件：{0}", file));
                    }
                }
                if (this.请求中止全部任务)
                {
                    //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", "用户中止任务。");
                    this.正在处理的文件 = "用户中止任务。";
                }
                else
                {
                    this.SetPropertyValue(this.toolStripProgressBar1, "Value", files.Length);
                    //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", "任务已完成。");
                    this.正在处理的文件 = "任务已完成。";
                }
            }
            finally
            {
                this.SetPropertyValue(this.toolStripButton添加文件, "Enabled", true);
                this.SetPropertyValue(this.toolStripButton添加文件夹, "Enabled", true);
                //this.SetPropertyValue(this.toolStripButton开始, "Enabled", true);
                this.SetPropertyValue(this.toolStripButton开始, "Image", global::CompressPics.Properties.Resources.run);
                this.SetPropertyValue(this.toolStripButton开始, "Text", "开始");
                this.SetPropertyValue(this.panel2, "Enabled", true);
                //this.timer1.Stop();
                this.thread压缩 = null;
            }
        }

        private void toolStripButton添加文件_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.AddFiles(this.openFileDialog1.FileNames);
            }
        }

        private void toolStripButton添加文件夹_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string [] files = System.IO.Directory.GetFiles(this.folderBrowserDialog1.SelectedPath, "*.*", System.IO.SearchOption.AllDirectories);
                this.AddFiles(files);
            }
        }

        private System.Threading.Thread thread压缩 = null;
        private bool 请求中止全部任务 = false;
        private void toolStripButton开始_Click(object sender, EventArgs e)
        {
            if (this.thread添加文件 != null)
            {
                throw new System.Exception("禁止执行图片压缩任务，因为正在执行添加文件任务。");
            }

            if (this.listView待处理文件.Items.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(this, @"请确认在继续之前已经备份这些待压缩的文件！

点击“确定”按钮开始执行压缩任务；
点击“取消”按钮放弃操作。", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            if (this.thread压缩 == null)
            {
                this.请求中止全部任务 = false;
                this.toolStripButton添加文件.Enabled = false;
                this.toolStripButton添加文件夹.Enabled = false;
                //this.toolStripButton开始.Enabled = false;
                this.toolStripButton开始.Image = global::CompressPics.Properties.Resources.stop;
                this.toolStripButton开始.Text = "停止";
                this.panel2.Enabled = false;
                this.timer1.Start();

                this.thread压缩 = new System.Threading.Thread(this.Run);
                this.thread压缩.Start();
            }
            else
            {
                if (!this.请求中止全部任务)
                {
                    this.请求中止全部任务 = true;
                }
            }
        }

        private void toolStripButton关于_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog(this);
        }

        private void toolStripButton退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.SetPropertyValue(this.toolStripStatusLabel正在处理的文件, "Text", this.正在处理的文件);
            if (this.toolStripStatusLabel正在处理的文件.Text != this.正在处理的文件)
            {
                this.toolStripStatusLabel正在处理的文件.Text = this.正在处理的文件;
            }
        }

        private void btn清空日志_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void btn复制日志信息到剪切板_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
            this.richTextBox1.Copy();
        }

    }
}
