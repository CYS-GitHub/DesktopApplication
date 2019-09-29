/*
 * 名称：日志信息
 * 功能说明：定义日志信息的字段
 * 
 * 创建标示：
 * 
 * 修改标示：师文佼 2013-05-09
 * 修改说明：给日志加唯一标识Id
 * 
 * 修改标示：师文佼 2013-07-11
 * 修改说明：增加日志类型
 * 
 * 修改标示：师文佼 2013-10-21
 * 修改说明：日志Id不再使用时间的Ticks
 * 
 * 修改标示：师文佼 2015-04-19
 * 修改说明：增加Clone方法
 * 
 */
using System;

namespace serialport
{
    /// <summary>
    /// 日志信息
    /// </summary>
    public class LogInfo
    {
        private long _id = 0;
        /// <summary>
        /// 日志唯一标识
        /// </summary>
        public long Id
        {
            get
            {
                return _id;
                //return this.logDate.Ticks;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// 日志发生的时间 年月日时分秒
        /// </summary>
        public DateTime logDate = DateTime.Now;

        /// <summary>
        /// 日志标题
        /// </summary>
        public string logType = "信息";

        /// <summary>
        /// 日志内容
        /// </summary>
        public string logMsg = string.Empty;

        /// <summary>
        /// 发送数据
        /// </summary>
        public string SendData = string.Empty;

        /// <summary>
        /// 接收数据
        /// </summary>
        public string RecvData = string.Empty;

        /// <summary>
        /// 克隆日志对象
        /// </summary>
        /// <returns>返回新的日志对象</returns>
        public LogInfo Clone()
        {
            LogInfo log = new LogInfo();
            log.Id = this._id;
            log.logDate = this.logDate;
            log.logMsg = this.logMsg;
            log.logType = this.logType;
            log.RecvData = this.RecvData;
            log.SendData = this.SendData;
            return log;
        }
    }

    /// <summary>
    /// 日志类型
    /// </summary>
    public class logType
    {
        /// <summary>
        /// 运行
        /// </summary>
        public const string Run = "运行";

        /// <summary>
        /// 信息
        /// </summary>
        public const string Info = "信息";

        /// <summary>
        /// 内存
        /// </summary>
        public const string Mem = "运行";

        /// <summary>
        /// 错误（记录日志时放入XXX_error.log）
        /// </summary>
        public const string Error = "错误";

        /// <summary>
        /// 通信
        /// </summary>
        public const string Com = "通信";

        /// <summary>
        /// 任务
        /// </summary>
        public const string Task = "任务";

        /// <summary>
        /// 发送
        /// </summary>
        public const string Send = "发送";

        /// <summary>
        /// 接收
        /// </summary>
        public const string Recv = "接收";

        /// <summary>
        /// 失败
        /// </summary>
        public const string Fail = "失败";

        /// <summary>
        /// 操作
        /// </summary>
        public const string Oper = "操作";

        /// <summary>
        /// 检测（记录日志时放入XXX_check.log）
        /// </summary>
        public const string Check = "检测";
    }
}
