/* ------------------------------------------
 * 
 * 名    称：TypeConvert.cs
 * 功能说明：
 * 
 * 创建标识：Dream.S 2015-01-20 21:25:40
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
    /// TypeConvert.cs
    /// </summary>
    public class TypeConvert
    {
        /// <summary>
        /// byte数组转换为16进制字符串
        /// </summary>
        /// <param name="userData">Byte类型素组</param>
        /// <returns></returns>
        public static string ByteToHexString(byte[] userData)
        {
            string strHexString = string.Empty;
            for (int i = 0; i < userData.Length; i++)
            {

                string a = Convert.ToString(userData[i], 16).PadLeft(2, '0') + " ";
                strHexString += a.ToString();

            }
            return strHexString.ToUpper();
        }

        /// <summary>
        /// 16进制转换成byte数组
        /// </summary>
        /// <param name="hexString">16进制字符串</param>
        /// <returns>Byte类型素组</returns>
        public static byte[] HexStringToByte(string hexString)
        {
            #region
            
            int len = hexString.Length;
            if (len % 2 != 0)
                return null;
            byte[] bufD = new byte[len / 2];
            byte[] tmpBuf = System.Text.Encoding.UTF8.GetBytes(hexString);
            int i = 0, j = 0;
            for (i = 0; i < len; i++)
            {
                if (tmpBuf[i] >= 0x30 && tmpBuf[i] <= 0x39)
                    tmpBuf[i] -= 0x30;
                else if (tmpBuf[i] >= 0x41 && tmpBuf[i] <= 0x46)
                    tmpBuf[i] -= 0x37;
                else if (tmpBuf[i] >= 0x61 && tmpBuf[i] <= 0x66)
                    tmpBuf[i] -= 0x57;
                else
                    tmpBuf[i] = 0xF;
            }
            for (i = 0, j = 0; i < len; i += 2, j++)
            {
                bufD[j] = (byte)((tmpBuf[i] << 4) | tmpBuf[i + 1]);
            }
            
            return bufD;
            #endregion
        }
    }
}
