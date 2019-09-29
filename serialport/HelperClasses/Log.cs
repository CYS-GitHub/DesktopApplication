/* ------------------------------------------
 * 
 * 名    称：Log.cs
 * 功能说明：
 * 
 * 创建标识：Dream.S 2015-01-20 21:31:24
 * 
 * 修改标识：
 * 修改说明：
 * 
 * ------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace serialport
{
    /// <summary>
    /// Log.cs
    /// </summary>
    public class Log
    {
        /// <summary>
        /// 些日志到文本框内
        /// </summary>
        /// <param name="txt"></param>
        /// <param name="str"></param>
        public static void Write(System.Windows.Forms.RichTextBox txt, string str, string logType)
        {
          
            LogUtility.WriteLog(DateTime.Now.ToString()+":"+logType, str);             
            string appendText = string.Format("{0}[{1}]{2}", DateTime.Now.ToString("HH:mm:ss"), logType, str);
            txt.AppendText(appendText);
            appendText = appendText.Replace("\r","");
            int index = txt.Text.LastIndexOf(appendText);
            if (index == -1)
            {
                index = 0;
            }
            txt.Select(index, appendText.Length);
            if (logType == LogType.Send)
            {
                txt.SelectionColor = System.Drawing.Color.Blue;
            }
            else
            {
                txt.SelectionColor = System.Drawing.Color.Red;
            }
            txt.SelectionLength = 0;
            txt.AppendText("\r\n");
            txt.SelectionStart = txt.Text.Length;
            txt.ScrollToCaret(); 
        }
    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public class LogType
    {
        /// <summary>
        /// 发送
        /// </summary>
        public const string Send = "发送";

        /// <summary>
        /// 接收
        /// </summary>
        public const string Recv = "接收";
    }
}
