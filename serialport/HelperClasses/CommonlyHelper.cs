
using System;
using System.Collections.Generic;
using System.Text;

namespace serialport
{
    /// <summary>
    /// CommonlyHelpe.cs
    /// </summary>
    public class CommonlyHelper
    {
        /// <summary>
        /// 反转字节数据
        /// </summary>
        /// <param name="strData">反转字节数据</param>
        public static string Turn(string strData)
        {
            int length = strData.Length;
            string newStr = "";
            for (int i = length / 2; i != 0; i--)
            {
                newStr += strData.Substring((i - 1) * 2, 2);
            }


            return newStr;
        }

        /// <summary>
        /// 实现各进制数间的转换。ConvertBase("15",10,16)表示将十进制数15转换为16进制的数。
        /// </summary>
        /// <param name="value">要转换的值,即原值</param>
        /// <param name="from">原值的进制,只能是2,8,10,16四个值。</param>
        /// <param name="to">要转换到的目标进制，只能是2,8,10,16四个值。</param>
        public static string ConvertBase(string value, int from, int to)
        {
            try
            {
                int intValue = Convert.ToInt32(value, from);  //先转成10进制
                string result = Convert.ToString(intValue, to);  //再转成目标进制
                if (to == 2)
                {
                    int resultLength = result.Length;  //获取二进制的长度
                    switch (resultLength)
                    {
                        case 7:
                            result = "0" + result;
                            break;
                        case 6:
                            result = "00" + result;
                            break;
                        case 5:
                            result = "000" + result;
                            break;
                        case 4:
                            result = "0000" + result;
                            break;
                        case 3:
                            result = "00000" + result;
                            break;
                    }
                }
                return result;
            }
            catch
            {
                return "0";
            }
        }
        /// <summary>
        /// ASCILL转字符串
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string AscillToString(string data)
        {
            string MeterVersion = data;
            int i;
            byte[] bs;
            string sValue = "";
            for (i = 0; i < MeterVersion.Length;)
            {
                int VersionInt = Convert.ToInt32(MeterVersion.Substring(i, 2), 16);
                bs = System.BitConverter.GetBytes(VersionInt);
                string result = System.Text.Encoding.ASCII.GetString(bs).ToString();
                sValue = sValue + result.Substring(0, 1);
                i = i + 2;
            }
            return sValue;
        }

        /// <summary>
        /// 字符串转ASCILL
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ConvertAscill(string data)
        {
            Encoding encode = Encoding.UTF8;
            byte[] b = encode.GetBytes(data);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16);
            }
            return result;
        }


        public static string ConvertDateTime(string str)
        {
            if (str == "FFEEDDFFEEDD")
            {
                return "未打开";
            }
            else if (str.Length != 12)
            {
                return str;
            }
            else
            {
                string data = str.Substring(0, 2) + "年" +
                    str.Substring(2, 2) + "月" +
                    str.Substring(4, 2) + "日" +
                    str.Substring(6, 2) + "时" +
                    str.Substring(8, 2) + "分" +
                    str.Substring(10, 2) + "秒";

                return data;
            }
        }


        public static string ConvertHexDateTime(string str)
        {
            if (str == "FFEEDDFFEEDD")
            {
                return "未打开";
            }
            else if (str.Length != 12)
            {
                return str;
            }
            else
            {
                string data = Convert.ToInt32(str.Substring(0, 2), 16) + "年" +
                   Convert.ToInt32(str.Substring(2, 2), 16) + "月" +
                   Convert.ToInt32(str.Substring(4, 2), 16) + "日" +
                   Convert.ToInt32(str.Substring(6, 2), 16) + "时" +
                   Convert.ToInt32(str.Substring(8, 2), 16) + "分" +
                   Convert.ToInt32(str.Substring(10, 2), 16) + "秒";

                return data;
            }
        }
        public static string ConvertTime(string str)
        {
            if (str == "FFEEDD")
            {
                return "窗口未打开";
            }
            else if (str.Length != 6)
            {
                return str;
            }
            else
            {
                string data = str.Substring(0, 2) + "时" +
                    str.Substring(2, 2) + "分" +
                    str.Substring(4, 2) + "秒";

                return data;
            }
        }


        public static string StateToMsg(string str)
        {
            string State = "";

            if (str.Substring(0, 1) == "0")
            {
                State = "攻击状态：正常；";
            }
            if (str.Substring(0, 1) == "1")
            {
                State = "攻击状态：攻击；";
            }
            if (str.Substring(1, 1) == "0")
            {
                State += "电池状态：正常；";
            }
            if (str.Substring(1, 1) == "1")
            {
                State += "电池状态：电量低；";
            }
            if (str.Substring(2, 1) == "0")
            {
                State += "采样状态：采样正常；";
            }
            if (str.Substring(2, 1) == "1")
            {
                State += "采样状态：采样故障；";
            }
            if (str.Substring(4, 1) == "0")
            {
                State += "断电状态：正常；";
            }
            if (str.Substring(4, 1) == "1")
            {
                State += "断电状态：断电；";
            }
            if (str.Substring(5, 1) == "0")
            {
                State += "阀门故障：正常；";
            }
            if (str.Substring(5, 1) == "1")
            {
                State += "阀门故障：阀门故障；";
            }
            if (str.Substring(7, 1) == "0")
            {
                State += "阀门状态：开；";
            }
            if (str.Substring(7, 1) == "1")
            {
                State += "阀门状态：关；";
            }
            return State;
        }

    }
}
