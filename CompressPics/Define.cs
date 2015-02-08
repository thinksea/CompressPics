using System;
using System.Collections.Generic;
using System.Text;

namespace CompressPics
{
    /// <summary>
    /// 图片文件格式。
    /// </summary>
    public class ImageFormat
    {
        public System.Drawing.Imaging.ImageFormat Format
        {
            get;
            set;
        }

        /// <summary>
        /// 文件格式扩展名。
        /// </summary>
        public string Extension
        {
            get;
            set;
        }

        public string Declaration
        {
            get;
            set;
        }

        public ImageFormat()
        {
        }

        public ImageFormat(System.Drawing.Imaging.ImageFormat Format, string Extension, string Declaration)
        {
            this.Format = Format;
            this.Extension = Extension;
            this.Declaration = Declaration;
        }

    }

    /// <summary>
    /// 图片尺寸单位枚举。
    /// </summary>
    public enum eUnit
    {
        /// <summary>
        /// 像素
        /// </summary>
        px,
        /// <summary>
        /// 百分比
        /// </summary>
        pre,
    }

    /// <summary>
    /// 实现 ListView 排序。
    /// </summary>
    public class ListViewColumnSorter : System.Collections.IComparer
    {
        /// <summary>
        /// 指定按照哪个列排序
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// 获取或设置按照哪一列排序
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }

        private string _DateType = "string";
        /// <summary>
        /// 排序列数据类型。
        /// </summary>
        public string DateType
        {
            get
            {
                return this._DateType;
            }
            set
            {
                this._DateType = value;
            }
        }

        /// <summary>
        /// 指定排序的方式
        /// </summary>
        private System.Windows.Forms.SortOrder OrderOfSort;
        /// <summary>
        /// 获取或设置排序方式
        /// </summary>
        public System.Windows.Forms.SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;// 默认按第一列排序            
            OrderOfSort = System.Windows.Forms.SortOrder.None;// 排序方式为不排序            
        }

        /// <summary>
        /// 重写IComparer接口
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        public int Compare(object x, object y)
        {
            int compareResult;
            System.Windows.Forms.ListViewItem listviewX, listviewY;
            // 将比较对象转换为ListViewItem对象
            listviewX = (System.Windows.Forms.ListViewItem)x;
            listviewY = (System.Windows.Forms.ListViewItem)y;
            // 比较
            switch (this.DateType)
            {
                case "datetime":
                    {
                        compareResult = System.DateTime.Compare(
                            System.DateTime.Parse(listviewX.SubItems[ColumnToSort].Text),
                            System.DateTime.Parse(listviewY.SubItems[ColumnToSort].Text)
                            );
                    }
                    break;
                case "filesize":
                    {
                        System.Collections.CaseInsensitiveComparer ObjectCompare = new System.Collections.CaseInsensitiveComparer();// 初始化CaseInsensitiveComparer类对象
                        compareResult = ObjectCompare.Compare(
                            int.Parse(listviewX.SubItems[ColumnToSort].Text.Replace(",", "").Replace("KB", "").TrimEnd()),
                            int.Parse(listviewY.SubItems[ColumnToSort].Text.Replace(",", "").Replace("KB", "").TrimEnd())
                            );
                    }
                    break;
                case "imagesize":
                    {
                        System.Collections.CaseInsensitiveComparer ObjectCompare = new System.Collections.CaseInsensitiveComparer();// 初始化CaseInsensitiveComparer类对象
                        compareResult = ObjectCompare.Compare(
                            int.Parse(listviewX.SubItems[ColumnToSort].Text.Split('x')[0].TrimEnd()),
                            int.Parse(listviewY.SubItems[ColumnToSort].Text.Split('x')[0].TrimEnd())
                            );
                    }
                    break;
                case "string":
                default:
                    {
                        System.Collections.CaseInsensitiveComparer ObjectCompare = new System.Collections.CaseInsensitiveComparer();// 初始化CaseInsensitiveComparer类对象
                        compareResult = ObjectCompare.Compare(
                            listviewX.SubItems[ColumnToSort].Text,
                            listviewY.SubItems[ColumnToSort].Text
                            );
                    }
                    break;
            }
            // 根据上面的比较结果返回正确的比较结果
            if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
            {   // 因为是正序排序，所以直接返回结果
                return compareResult;
            }
            else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
            {  // 如果是反序排序，所以要取负值再返回
                return (-compareResult);
            }
            else
            {
                // 如果相等返回0
                return 0;
            }
        }

    }

}
