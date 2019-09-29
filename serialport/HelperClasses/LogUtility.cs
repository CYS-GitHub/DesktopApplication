/*
 * 名    称：日志类
 * 功能说明：记录文本日志
 * 
 * 创建标识：师文佼 2012-09-27
 * 
 * 修改标识：师文佼 2012-11-09
 * 修改说明：运行和通信记录在一个日志文件中，内容中添加日志类型
 * 
 * 修改标识：师文佼 2013-04-01
 * 修改说明：增加参数，以控制日志文件名前是否有日志，因为对于日志量不大的应用程序不需要每天都创建一个日志
 * 
 * 修改标识：师文佼 2013-05-09
 * 修改说明：给日志加唯一标识Id
 * 
 * 修改标识：师文佼 2013-05-11
 * 修改说明：1、由于需要多个终端获得日志，使用队列及其不便，所以将LogList的类型由Queue<LogInfo>改为List<LogInfo>
 *           2、增加日志满时，移除一定数量日志的功能，默认移除50个
 *           3、修改WriteLog方法
 *                 
 * 修改标识：师文佼 2013-05-27
 * 修改说明：1、修改WriteLog方法，增加重载方法，标识是否写内存日志
 * 
 * 修改标识：师文佼 2013-06-21
 * 修改说明：1、修改WriteLog方法，增加重载方法
 *                 2、增加WriteError方法的重载方法
 *                 
 * 修改标识：师文佼 2013-06-25
 * 修改说明：内存日志达到日志数量后，移除的数量由50修改为ListLogCounts / 4，防止移除未获取的日志
 * 
 * 修改标示：师文佼 2013-10-21
 * 修改说明：日志Id不再使用时间的Ticks，使用自增长的Id
 * 
 * 修改标示：师文佼 2015-04-13
 * 修改说明：增加是否写内存属性，可以直接关闭写内存功能；并支持是否写文本日志功能
 * 
 * */


using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace serialport
{
    public static class LogUtility
    {
        #region 静态方法

        /// <summary>
        /// 运行日志
        /// </summary>
        public static List<LogInfo> LogList = new List<LogInfo>();

        /// <summary>
        /// 内存日志列表存放日志数量
        /// </summary>
        public static int ListLogCounts = 200;

        /// <summary>
        /// 内存日志达到日志数量后，移除的数量
        /// </summary>
        public static int RemoveLogCounts = ListLogCounts / 4;

        /// <summary>
        /// 日志路径
        /// </summary>
        public static string logPath = System.AppDomain.CurrentDomain.BaseDirectory + "Log\\";
        
        /// <summary>
        /// 最大文件字节数 单位：字节
        /// </summary>
        public static long MaxFileSize = 2 * 1024 * 1024;

        /// <summary>
        /// 锁
        /// </summary>
        public static object lockObj = new object();

        /// <summary>
        /// 运行日志文件名
        /// </summary>
        private static string RunLogFileName = "run.log";

        /// <summary>
        /// 错误日志文件名
        /// </summary>
        private static string ErrorLogFileName = "error.log";

        /// <summary>
        /// 检测日志文件名
        /// </summary>
        private static string CheckLogFileName = "check.log";

        /// <summary>
        /// 日志保存天数
        /// </summary>
        public static int FileSaveDays = 30;

        /// <summary>
        /// 是否写文本日志
        /// </summary>
        public static bool IfWriteTxt = true;

        /// <summary>
        /// 是否写内存日志
        /// </summary>
        public static bool IfWriteMem = true;

        /// <summary>
        /// 是否将日期写在文件名前，为和以前兼容，默认值为true，即默认添加日志做为文件名前缀
        /// </summary>
        public static bool DatePreFileName = true;

        /// <summary>
        /// 日志索引号
        /// </summary>
        private static long logId = 0;

        /// <summary>
        /// 清理过期的日志文件
        /// </summary>
        public static void ClearHisLog()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(logPath) == true)
                {
                    return;
                }
                string[] fileList = Directory.GetFiles(logPath);
                foreach (string logFile in fileList)
                {
                    //如果文件不是日志文件，则不处理，防止错误删除其他文件
                    if (logFile.EndsWith(".log") == false)
                    {
                        continue;
                    }
                    //如果文件创建时间距今超过日志保存天数，则删除文件
                    if (DateTime.Now.Subtract(File.GetCreationTime(logFile)).TotalDays > FileSaveDays)
                    {
                        File.Delete(logFile);
                    }

                }
            }
            catch (System.Exception ex)
            {
                WriteError(ex);
            }
        }

        /// <summary>
        /// 记录日志（日志一并写入内存）
        /// </summary>
        /// <param name="msg">信息</param>
        public static void WriteLog(string msg)
        {
            WriteLog(logType.Run, msg, true);
        }

        /// <summary>
        /// 记录日志（日志一并写入内存）
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="msg">信息</param>
        public static void WriteLog(string type, string msg)
        {
            WriteLog(type, msg, true);
        }

        /// <summary>
        /// 记录日志（日志一并写入内存）
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="msg">信息</param>
        public static void WriteLog(string type, string msg, string detialMsg)
        {
            //所有的运行日志都先写内存
            LogInfo logInfo = new LogInfo();
            logInfo.logType = type;
            logInfo.logMsg = msg;
            logInfo.SendData = detialMsg;
            AddMemLog(logInfo);

            //除了异常日志记录到异常文件中，其他的都记录在一个文件中
            string fileName = string.Empty;
            switch (type)
            {
                case logType.Error:
                    fileName = ErrorLogFileName;
                    break;
                case logType.Check:
                    fileName = CheckLogFileName;
                    break;
                default:
                    fileName = RunLogFileName;
                    break;
            }
            WriteLogByFileName(type, fileName, detialMsg);
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="type">类型</param>
        /// <param name="msg">信息</param>
        /// <param name="isWriteMem">是否写内存</param>
        public static void WriteLog(string type, string msg, bool isWriteMem)
        {
            if (isWriteMem)
            {
                //所有的运行日志都先写内存
                LogInfo logInfo = new LogInfo();
                logInfo.logType = type;
                logInfo.logMsg = msg;
                AddMemLog(logInfo);
            }

            //除了异常日志记录到异常文件中，其他的都记录在一个文件中
            string fileName = string.Empty;
            switch (type)
            {
                case logType.Error:
                    fileName = ErrorLogFileName;
                    break;
                case logType.Check:
                    fileName = CheckLogFileName;
                    break;
                default:
                    fileName = RunLogFileName;
                    break;
            }
            WriteLogByFileName(type, fileName, msg);
        }

        /// <summary>
        /// 记录日志（日志一并写入内存）
        /// </summary>
        /// <param name="logInfo"></param>
        public static void WriteLog(LogInfo logInfo)
        {
            WriteLog(logInfo, true);
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="logInfo">日志对象</param>
        /// <param name="isWriteMem">是否写内存</param>
        public static void WriteLog(LogInfo logInfo, bool isWriteMem)
        {
            if (isWriteMem)
            {
                //所有的运行日志都先写内存
                AddMemLog(logInfo);
            }

            //除了异常日志记录到异常文件中，其他的都记录在一个文件中
            string fileName = string.Empty;
            switch (logInfo.logType)
            {
                case logType.Error:
                    fileName = ErrorLogFileName;
                    break;
                case logType.Check:
                    fileName = CheckLogFileName;
                    break;
                default:
                    fileName = RunLogFileName;
                    break;
            }
            string strData = string.IsNullOrWhiteSpace(logInfo.SendData) ? logInfo.RecvData : logInfo.SendData;
            strData = string.IsNullOrWhiteSpace(strData) ? string.Empty : string.Format(" [{0}] ", strData.TrimEnd());

            WriteLogByFileName(logInfo.logDate, logInfo.logType, fileName, logInfo.logMsg + strData);
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="msg"></param>
        public static void WriteLogByFileName(string type, string fileName, string msg)
        {
            WriteLogByFileName(DateTime.Now, type, fileName, msg);
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="msg"></param>
        public static void WriteLogByFileName(DateTime dt, string type, string fileName, string msg)
        {
            if (IfWriteTxt == false)
                return;
            //添加排他锁，解决并发写入的问题
            Monitor.Enter(lockObj);
            try
            {
                //启用日期做为文件名前缀时才添加日志
                if (DatePreFileName)
                {
                    fileName = string.Format("{0}_{1}", DateTime.Now.ToString("yyyyMMdd"), fileName);
                }

                if (System.IO.Directory.Exists(logPath) == false)
                {
                    System.IO.Directory.CreateDirectory(logPath);
                }
                //如果日志文件大小超过了指定最大值，则转存为新的文件
                FileInfo fi = new FileInfo(logPath + "\\" + fileName);
                if (fi.Exists == true && fi.Length >= MaxFileSize)
                {
                    fi.MoveTo(logPath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_long_" + fileName);
                }
                string logContent = msg;
                logContent = string.Format("{0}     {1}     {2}", dt.ToString("yyyy-MM-dd HH:mm:ss fff"), type, msg);
                using (StreamWriter SW = File.AppendText(logPath + "\\" + fileName))
                {
                    SW.WriteLine(logContent);
                }
            }
            catch
            {
                return;
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
        }

        /// <summary>
        /// 记录内存日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMemLog(string msg)
        {
            LogInfo logInfo = new LogInfo();
            logInfo.logMsg = msg;
            AddMemLog(logInfo);
        }

        /// <summary>
        /// 记录内存日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMemLog(LogInfo logInfo)
        {
            AddMemLog(logInfo);
        }

        /// <summary>
        /// 记录内存日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMemLog(string type, string msg)
        {
            LogInfo logInfo = new LogInfo();
            logInfo.logMsg = msg;
            logInfo.logType = type;
            AddMemLog(logInfo);
        }

        /// <summary>
        /// 记录内存日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMemLog(string type, string msg, string sendData)
        {
            LogInfo logInfo = new LogInfo();
            logInfo.logMsg = msg;
            logInfo.logType = type;
            logInfo.SendData = sendData;
            AddMemLog(logInfo);
        }

        /// <summary>
        /// 记录内存日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteMemLog(string type, string msg, string sendData, string recvData)
        {
            LogInfo logInfo = new LogInfo();
            logInfo.logMsg = msg;
            logInfo.logType = type;
            logInfo.SendData = sendData;
            logInfo.RecvData = recvData;
            AddMemLog(logInfo);
        }

        /// <summary>
        /// 记录运行日志
        /// </summary>
        /// <param name="msg"></param>
        public static void WriteRun(string msg)
        {
            WriteLog(logType.Run, msg);
        }

        /// <summary>
        /// 记录异常消息内容到文件日志
        /// </summary>
        /// <param name="err">异常消息内容</param>
        public static void WriteError(System.Exception err)
        {
            WriteLog(logType.Error, err.ToString());
        }

        /// <summary>
        /// 记录异常消息内容到文件日志
        /// </summary>
        /// <param name="msg">错误信息，Mssage</param>
        /// <param name="err">异常消息内容，ToString</param>
        public static void WriteError(string msg, System.Exception err)
        {
            WriteLog(logType.Error, msg, err.ToString());
        }

        /// <summary>
        /// 记录异常消息内容到文件日志
        /// </summary>
        /// <param name="msg">错误信息，Mssage</param>
        /// <param name="detailMsg">详细消息内容</param>
        public static void WriteError(string msg, string detailMsg)
        {
            WriteLog(logType.Error, msg, detailMsg);
        }

        /// <summary>
        /// 写通讯日志
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void WriteComm(string msg)
        {
            WriteLog(logType.Com, msg);
        }

        #endregion 静态方法

        #region 私有方法

        /// <summary>
        /// 增加内存日志的私有方法
        /// </summary>
        /// <param name="logInfo">日志对象</param>
        private static void AddMemLog(LogInfo logInfo)
        {
            if (IfWriteMem == false)
                return;
            lock (lockObj)
            {
                logInfo.Id = logId++;
                LogList.Add(logInfo);
            }
            //如果内存日志数量超过限定数，则按移除数量移除较早的日志
            if (LogList.Count > ListLogCounts)
            {
                //移除日志数量大于日志总数量，全清
                if (RemoveLogCounts >= ListLogCounts)
                {
                    LogList.Clear();
                }
                else
                {
                    LogList.RemoveRange(0, RemoveLogCounts);
                }
            }
        }

        /// <summary>
        /// 增加内存日志的私有方法
        /// </summary>
        /// <param name="msg">信息</param>
        private static void AddMemLog(string msg)
        {
            LogInfo logInfo = new LogInfo();
            logInfo.logMsg = msg;
            AddMemLog(logInfo);
        }

        #endregion 私有方法
    }
}
