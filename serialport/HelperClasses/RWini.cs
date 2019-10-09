using System.Runtime.InteropServices;
using System.Text;

namespace serialport
{
    /// <summary>
    /// 读写INI文件
    /// </summary>
    public class RWini
    {
        /// <summary>
        /// INI文件路径，全路径包含文件名
        /// </summary>
        public string path = string.Empty;

        public RWini(string iniPath)
        {
            path = iniPath;
        }

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }

        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void WriteValue(string Section, string Key, int Value)
        {
            WritePrivateProfileString(Section, Key, Value.ToString(), path);
        }
        
        /// <summary>
        /// 读取INI文件指定
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string ReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, path);

            return temp.ToString();
        }

        #region API函数声明

        ////声明读写INI文件的API函数 
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        
        #endregion  API函数声明
    }
}
