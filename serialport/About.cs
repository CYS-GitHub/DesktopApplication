using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace serialport
{
    public partial class About : Skin_VS
    {
        public About()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

            //使用说明
            AddMsg(@"                  1.支持三串口自由收发.
                  2.支持常用的进制或格式转换.
                  3.波特率支持自定义.
                  4.可以实现“帧头 + 数据 + 校验 + 帧尾”的组帧操作.
                  5.支持字符串和十六进制方式显示, 和加时间戳分数据包显示.
                  6.支持字符串和十进制方式发送, 支持预定义100组数据串发送.
                  7.支持接收数据直接保存到文件, 也可保存窗口数据和原始接收数据.
                  8.支持一键增加校验和加帧尾.
                  9.支持数据重复发送.

                  便捷功能说明：
                  1.区域：选择发送串口
                  双击清零发送次数和接收次数.
                  2.区域：接收区
                  双击可自由放大缩小点击的接收框.
                  组合键Ctrl+S可保存接收框内容到本地.
                  3.区域：扩展
                  选中需要选中的HEX列、发送列按回车键可自动选中或取消.");


        }


        private void AddMsg(string str)
        {
            richTextBox1.AppendText(str + "\r\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
