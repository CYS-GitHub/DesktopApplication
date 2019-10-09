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
    public partial class ConvertStr : Skin_VS
    {
        public ConvertStr()
        {
            InitializeComponent();
        }

        private void btn_Conversion_Click(object sender, EventArgs e)
        {
          
            string inputData = txt_originalData.Text.ToString();
            string IntoData = "";

            //10进制转16进制
            //16进制转10进制
            //10进制转2进制
            //2进制转10进制
            //转ASCILL码

            switch (cbo_IntoTheSystem.Text)
            {
                case "10进制转16进制":
                    IntoData = CommonlyHelper.ConvertBase(inputData, 10, 16);
                    break;
                case "16进制转10进制":
                    IntoData = CommonlyHelper.ConvertBase(inputData, 16, 10);
                    break;
                case "10进制转2进制":
                    IntoData = CommonlyHelper.ConvertBase(inputData, 10, 2);
                    break;
                case "2进制转10进制":
                    IntoData = CommonlyHelper.ConvertBase(inputData, 2, 10);
                    break;
                case "ASCILL码转字符串":
                    IntoData = CommonlyHelper.AscillToString(inputData);
                    break;
                case "字符串转ASCILL码":
                    IntoData = CommonlyHelper.ConvertAscill(inputData);
                    break;


            }

            txt_resultsData.Text = IntoData;
        
    }
    }
}
