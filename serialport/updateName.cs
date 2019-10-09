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
    public partial class updateName : Skin_VS
    {
        public string SetNmae = "";
        public updateName()
        {
            InitializeComponent();
            lbl_txt.Text = "请输入条目" + serialport.sendIndex.ToString() + "的注释:";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            SetNmae = txt_Name.Text.ToString();
            this.Close();
        }

        private void btn_Can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateName_Load(object sender, EventArgs e)
        {

        }
    }
}
