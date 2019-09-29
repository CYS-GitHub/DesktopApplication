/* ------------------------------------------
 * 
 * 名    称：PublicClass.cs
 * 功能说明：
 * 
 * 创建标识：Dream.S 2015-01-20 20:11:13
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
    /// PublicClass.cs
    /// </summary>
    public class PublicClass
    {
        /// <summary>
        /// 串口延时时间
        /// </summary>
        private static int delayTime = 100;
        /// <summary>
        /// 获得串口的数据
        /// </summary>
        /// <returns></returns>
        public static byte[] GetSerialPortRecvData(System.IO.Ports.SerialPort serialPort)
        {
            byte[] outData = new byte[0];
            try
            {
                int iCanReadBytes = 0;
                int newICanReadBytes = 0;
                do
                {
                    iCanReadBytes = serialPort.BytesToRead;
                    //稍等一下，等串口上的数据传输完
                    System.Threading.Thread.Sleep(delayTime);
                    newICanReadBytes = serialPort.BytesToRead;
                } while (iCanReadBytes != newICanReadBytes);//判断是否接收完毕
                if (iCanReadBytes <= 0)
                {
                    return outData;
                }
                //接收报文
                outData = new byte[iCanReadBytes];
                serialPort.Read(outData, 0, outData.Length);
                return outData;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
