/* ------------------------------------------
 * 
 * 名    称：Verify.cs
 * 功能说明：
 * 
 * 创建标识：Dream.S 2015-01-18 19:45:05
 * 
 * 修改标识：
 * 修改说明：
 * 
 * ------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace serialport
{
    /// <summary>
    /// Verify.cs
    /// </summary>
    public class Verify
    {
        /// <summary>
        /// 验证校验字节
        /// </summary>
        /// <param name="userData">用户数据</param>
        /// <param name="fmSum">校验和</param>
        /// <returns></returns>
        public static bool VerifyFramesSum(byte[] userData, byte framesSum)
        {
            //计算校验字节
            byte bSum = GetVerifyFramesSum(userData);
            //比较校验字节
            if (bSum.CompareTo(framesSum) == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 计算桢校验和字节，返回一个校验字节
        /// 通用远传集中器协议 用户数据区所有字节的八位位组算术和，不考虑溢出位。用户数据区包括控制域、地址域、链路用户数据（应用层）三部分。
        /// </summary>
        /// <param name="userData">校验数据</param>
        /// <returns></returns>
        public static byte GetVerifyFramesSum(byte[] userData)
        {


            int iNum = 0;
            foreach (byte b in userData)
            {
                iNum = iNum + Convert.ToInt32(b);
            }
            int rem = 0;
            System.Math.DivRem(iNum, 256, out rem);
            return Convert.ToByte(rem);
        }

    
        /// <summary>
        /// 验证校验字节
        /// 所有数据的累加和取反+1
        /// </summary>
        /// <param name="userData">用户数据</param>
        /// <param name="fmSum">校验和</param>
        /// <returns></returns>
        public static bool VerifyFramesSumXOR(byte[] userData, byte framesSum)
        {
            //计算校验字节
            byte bSum = GetVerifyFramesSum(userData);
            //比较校验字节
            if (bSum.CompareTo(framesSum) == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 计算桢校验和字节，返回一个校验字节
        /// 所有数据的累加和取反+1
        /// </summary>
        /// <param name="userData">校验数据</param>
        /// <returns></returns>
        public static byte GetVerifyFramesSumXOR(byte[] userData)
        {
            int iNum = 0;
            foreach (byte b in userData)
            {
                iNum = iNum + b;
            }
            int sum = iNum % 256;
            sum = (sum ^ 0xFF) + 1;
            return Convert.ToByte(sum % 256);
        }
    }
}
