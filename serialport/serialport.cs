using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Threading;
using System.Text.RegularExpressions;
using CCWin;

namespace serialport
{

    public partial class serialport : Skin_VS
    {
        //条目
        public static int sendIndex = 0;

        //重复周期发送次数
        private int SendNum = 0;
        private Thread trSend;

        float xvalues;
        float yvalues;

        public serialport()
        {
            InitializeComponent();

        }




        /// <summary>
        /// 写数据的委托
        /// </summary>
        /// <param name="strData">需要些到文本框中的字符串数据</param>
        public delegate void DeleUpdateTextBox(string strData);
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] comData = PublicClass.GetSerialPortRecvData(this.comport);
            //使用委托进行跨线程读取数据
            Invoke(
                new EventHandler(
                    delegate
                    {
                        string strReadData = string.Empty;


                        DeleUpdateTextBox deleUpdateTextBox = new DeleUpdateTextBox(UpdateTextBox);

                        if (chkRecvHex.Checked == false)
                        {
                            strReadData = Encoding.Default.GetString(comData);
                            txtReceived.Invoke(deleUpdateTextBox, strReadData);

                        }
                        else
                        {
                            for (int i = 0; i < comData.Length; i++)
                            {
                                byte temp = comData[i];
                                strReadData += temp.ToString("X2") + " ";
                            }
                            if (strReadData == "")
                            {
                                return;
                            }
                            txtReceived.Invoke(deleUpdateTextBox, strReadData);
                        }

                    }
               )
              );

        }


        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] comData = PublicClass.GetSerialPortRecvData(this.comport2);
            //使用委托进行跨线程读取数据
            Invoke(
                new EventHandler(
                    delegate
                    {
                        string strReadData = string.Empty;


                        DeleUpdateTextBox deleUpdateTextBox = new DeleUpdateTextBox(UpdateTextBox2);

                        if (chkRecvHex2.Checked == false)
                        {
                            strReadData = Encoding.Default.GetString(comData);
                            txtReceived.Invoke(deleUpdateTextBox, strReadData);

                        }
                        else
                        {
                            for (int i = 0; i < comData.Length; i++)
                            {
                                byte temp = comData[i];
                                strReadData += temp.ToString("X2") + " ";
                            }
                            if (strReadData == "")
                            {
                                return;
                            }
                            txtReceived2.Invoke(deleUpdateTextBox, strReadData);
                        }

                    }
               )
              );

        }

        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] comData = PublicClass.GetSerialPortRecvData(this.comport3);
            //使用委托进行跨线程读取数据
            Invoke(
                new EventHandler(
                    delegate
                    {
                        string strReadData = string.Empty;


                        DeleUpdateTextBox deleUpdateTextBox = new DeleUpdateTextBox(UpdateTextBox3);

                        if (chkRecvHex3.Checked == false)
                        {
                            strReadData = Encoding.Default.GetString(comData);
                            txtReceived.Invoke(deleUpdateTextBox, strReadData);

                        }
                        else
                        {
                            for (int i = 0; i < comData.Length; i++)
                            {
                                byte temp = comData[i];
                                strReadData += temp.ToString("X2") + " ";
                            }
                            if (strReadData == "")
                            {
                                return;
                            }
                            txtReceived3.Invoke(deleUpdateTextBox, strReadData);
                        }

                    }
               )
              );

        }
        private void serialport_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(MainForm_Resize); //添加窗体拉伸重绘事件
            xvalues = this.Width;//记录窗体初始大小
            yvalues = this.Height;
            SetTag(this);

            if (System.IO.Ports.SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("本地没有检测到COM口，请检查COM口！", "提示");
            }
            else
            {
                foreach (string com in System.IO.Ports.SerialPort.GetPortNames()) //自动获取串行口名称
                {
                    cmbPortName.Items.Add(com);
                    cmbPortName2.Items.Add(com);
                    cmbPortName3.Items.Add(com);
                }

                cmbPortName.SelectedIndex = 0;
                cmbPortName2.SelectedIndex = 0;
                cmbPortName3.SelectedIndex = 0;
            }
            cbo_timeSend.Enabled = false;
            cbo_IntoTheSystem.SelectedIndex = 0;
            skinTabControl1.SelectedIndex = 0;

            if (DataGridView1.Rows.Count < 100)
            {
                int length = 100 - DataGridView1.Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    DataGridView1.Rows.Add();
                    DataGridView1.Rows[i].Cells[3].Value = i + 1 + "无注释";
                    DataGridView1.Rows[i].Cells[4].Value = i + 1;
                    DataGridView1.Rows[i].Cells[5].Value = "1000";
                }

            }
        }

        private void MainForm_Resize(object sender, EventArgs e)//重绘事件
        {
            float newX = this.Width / xvalues;//获得比例
            float newY = this.Height / yvalues;
            SetControls(newX, newY, this);
        }
        private void SetControls(float newX, float newY, System.Windows.Forms.Control cons)//改变控件的大小
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newX;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newY;
                con.Height = (int)a;
                a = Convert.ToSingle(mytag[2]) * newX;
                con.Left = (int)a;
                a = Convert.ToSingle(mytag[3]) * newY;
                con.Top = (int)a;
                Single currentSize = Convert.ToSingle(mytag[4]) * newY;

                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    SetControls(newX, newY, con);
                }
            }
        }
        /// <summary>
        /// 遍历窗体中控件函数
        /// </summary>
        /// <param name="cons"></param>
        private void SetTag(System.Windows.Forms.Control cons)
        {
            foreach (System.Windows.Forms.Control con in cons.Controls)  //遍历窗体中的控件,记录控件初始大小
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    SetTag(con);
                }
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {

            try
            {
                if (comport.IsOpen)
                {
                    comport.Close();
                    rowIndex = -1;
                }
                else
                {
                    //Set the port's settings
                    comport.BaudRate = int.Parse(cmbBaudRate.Text);
                    comport.DataBits = int.Parse(cmbDataBits.Text);
                    comport.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
                    comport.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                    comport.PortName = cmbPortName.Text;

                    //Open the port
                    comport.Open();
                }
                cmbPortName.Enabled = cmbStopBits.Enabled = cmbBaudRate.Enabled = cmbParity.Enabled = cmbDataBits.Enabled = !comport.IsOpen;
                if (comport.IsOpen || comport2.IsOpen || comport3.IsOpen)
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = true;
                }
                else
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = false;
                }
                if (comport.IsOpen)
                {
                    btn_Open.Text = "&C关闭端口";
                    Lbl_Flag.Text = "开启";
                    Lbl_Flag.ForeColor = Color.Green;
                }
                else
                {
                    btn_Open.Text = "&O打开端口";
                    Lbl_Flag.Text = "关闭";
                    Lbl_Flag.ForeColor = Color.Red;
                }
                if (comport.IsOpen) txt_Send.Focus();
            }
            catch (Exception er)
            { MessageBox.Show("端口打开失败！" + er.Message, "提示"); }

        }




        /// <summary>
        /// 当前发送行
        /// </summary>
        int rowIndex = 0;
        /// <summary>
        /// 发送命令的时间
        /// </summary>
        public DateTime sendTime = DateTime.Now;


        /// <summary>
        /// 命令计时
        /// </summary>
        private void timerReceived_Tick(object sender, EventArgs e)
        {

            try
            {
                this.timerReceived.Enabled = false;
                TimeSpan timing = (DateTime.Now - this.sendTime);
                if (timing.TotalSeconds >= Convert.ToInt32(txt_TimeOutNum.Text))
                {
                    //该方法执行，说明命令超时
                    Log.Write(this.txtReceived, "命令超时...", LogType.Recv);
                    rowIndex = -1;

                }
            }
            finally
            {
                if (rowIndex >= 0)
                    this.timerReceived.Enabled = true;
            }
        }

        /// <summary>
        /// 命令计时
        /// </summary>
        private void timerSend_Tick(object sender, EventArgs e)
        {

            try
            {
                this.timerSend.Enabled = false;
                string strSend = txt_Send.Text;
                strSend = strSend.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");

                if (chkSendHex.Checked == true)
                {
                    byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                    if (rdo_comPort1.Checked)
                    {
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            Log.Write(this.txtReceived, strSend, LogType.Send);
                        }
                    }
                    else if (rdo_comPort2.Checked)
                    {
                        comport2.Write(data, 0, data.Length);
                        if (chkHidden2.Checked)
                        {
                            Log.Write(this.txtReceived2, strSend, LogType.Send);
                        }
                    }
                    else if (rdo_comPort3.Checked)
                    {
                        comport3.Write(data, 0, data.Length);
                        if (chkHidden3.Checked)
                        {
                            Log.Write(this.txtReceived3, strSend, LogType.Send);
                        }
                    }
                }
                else
                {
                    byte[] data = Encoding.Default.GetBytes(strSend);
                    if (rdo_comPort1.Checked)
                    {
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            Log.Write(this.txtReceived, strSend, LogType.Send);
                        }
                    }
                    else if (rdo_comPort2.Checked)
                    {
                        comport2.Write(data, 0, data.Length);
                        if (chkHidden2.Checked)
                        {
                            Log.Write(this.txtReceived2, strSend, LogType.Send);
                        }
                    }
                    else if (rdo_comPort3.Checked)
                    {
                        comport3.Write(data, 0, data.Length);
                        if (chkHidden3.Checked)
                        {
                            Log.Write(this.txtReceived3, strSend, LogType.Send);
                        }
                    }
                }
                lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                SendNum++;
            }
            finally
            {
                if (cbo_timeSend.Checked && SendNum != Convert.ToInt32(txt_SendNumber.Text))
                {
                    this.timerSend.Enabled = true;
                    timerSend.Interval = Convert.ToInt32(txt_timeSend.Text);
                }
                else if (SendNum == Convert.ToInt32(txt_SendNumber.Text))
                {
                    cbo_timeSend.Checked = false;
                }
            }
        }

        private void btn_F5_Click(object sender, EventArgs e)
        {
            if (System.IO.Ports.SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("本地没有检测到COM口，请检查COM口！", "提示");
            }
            else
            {
                cmbPortName.Items.Clear();
                foreach (string com in System.IO.Ports.SerialPort.GetPortNames()) //自动获取串行口名称
                {
                    cmbPortName.Items.Add(com);
                }
                cmbPortName.SelectedIndex = 0;
            }
        }

        private void btn_SpiltSendStr_Click(object sender, EventArgs e)
        {
            if (txt_Send.Text.ToString().IndexOf(" ") == -1)
            {
                string strSend = txt_Send.Text.Replace(" ", "");
                txt_Send.Text = Regex.Replace(strSend, @".{2}", "$0 ");
            }
            else
            {
                txt_Send.Text = txt_Send.Text.Replace(" ", ""); ;
            }
        }

        private void btn_addVerify_Click(object sender, EventArgs e)
        {
            string strSend = txt_Send.Text;
            strSend = strSend.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
            if (strSend.Length % 2 != 0)
            {
                MessageBox.Show("输入数据长度不正确,请重新输入！");
                txt_Send.Focus();
                return;
            }

            if (!(strSend.Length > 2)) return;
            if (strSend.Substring(strSend.Length - 2) == "16")
            {
                strSend = strSend.Substring(0, strSend.Length - 2);
            }
            byte[] data = TypeConvert.HexStringToByte(strSend);
            byte VerifySum1 = Verify.GetVerifyFramesSum(data);
            byte[] newData = new byte[data.Length + 1];
            Array.Copy(data, newData, data.Length);
            newData[newData.Length - 1] = VerifySum1;
            string NewString = TypeConvert.ByteToHexString(newData);
            strSend = NewString + "16";
            strSend = strSend.Replace(" ", "");
            txt_Send.Text = Regex.Replace(strSend, @".{2}", "$0 ");
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param>发送数据</param>
        private void btn_Send_Click(object sender, EventArgs e)
        {

            string strSend = txt_Send.Text;
            strSend = strSend.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
            if (strSend.Length % 2 != 0)
            {
                MessageBox.Show("输入数据长度不正确,请重新输入！");
                txt_Send.Focus();
                return;
            }


            if (rdo_comPort1.Checked)
            {
                if (chkSendHex.Checked == true)
                {
                    byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                    comport.Write(data, 0, data.Length);
                    if (chkHidden.Checked)
                    {
                        Log.Write(this.txtReceived, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                    }
                    lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                }
                else
                {
                    byte[] data = Encoding.Default.GetBytes(txt_Send.Text);
                    comport.Write(data, 0, data.Length);
                    if (chkHidden.Checked)
                    {
                        Log.Write(this.txtReceived, txt_Send.Text, LogType.Send);
                    }
                    lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                }
            }
            else if (rdo_comPort2.Checked)
            {
                if (chkSendHex.Checked == true)
                {
                    byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                    comport2.Write(data, 0, data.Length);

                    if (chkHidden2.Checked)
                    {
                        Log.Write(this.txtReceived2, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                    }

                    lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                }
                else
                {
                    byte[] data = Encoding.Default.GetBytes(txt_Send.Text);
                    comport2.Write(data, 0, data.Length);

                    if (chkHidden2.Checked)
                    {
                        Log.Write(this.txtReceived2, txt_Send.Text, LogType.Send);
                    }
                    lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                }
            }

            else if (rdo_comPort3.Checked)
            {
                if (chkSendHex.Checked == true)
                {
                    byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                    comport3.Write(data, 0, data.Length);

                    if (chkHidden3.Checked)
                    {
                        Log.Write(this.txtReceived3, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                    }

                    lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                }
                else
                {
                    byte[] data = Encoding.Default.GetBytes(txt_Send.Text);
                    comport3.Write(data, 0, data.Length);

                    if (chkHidden3.Checked)
                    {
                        Log.Write(this.txtReceived3, txt_Send.Text, LogType.Send);
                    }
                    lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                }
            }

        }

        private void VerifySum(string strData)
        {
            if (strData.Length > 4)
            {
                //验证校验和
                byte[] data = TypeConvert.HexStringToByte(strData.Substring(0, strData.Length - 4));
                byte VerifySum = Verify.GetVerifyFramesSum(data);
                string strnum = VerifySum.ToString("X2");
                if (strnum == strData.Substring(strData.Length - 4, 2) == false)
                {
                    Log.Write(this.txtReceived, "校验和验证失败！", LogType.Recv);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private string MeterAddr(string strData)
        {



            string MeterAddr = strData.Substring(2, 16);
            MeterAddr = MeterAddr
                + "\r\n表类型：" + MeterAddr.Substring(0, 2)
                + "\r\n水表厂家编码：" + MeterAddr.Substring(2, 2)
                + "\r\n模块厂家编码：" + MeterAddr.Substring(4, 2)
                + "\r\n采样类型：" + (MeterAddr.Substring(6, 1) == "2" ? "无磁采样" : "其他")
                + "\r\n生产年月：" + MeterAddr.Substring(7, 4)
                + "\r\n表编号：" + MeterAddr.Substring(11, 5);

            return MeterAddr;
        }

        /// <summary>
        /// 更新接收文本框的内容
        /// </summary>
        /// <param name="Data">接收到的数据</param>
        private void UpdateTextBox(string Data)
        {
            try
            {
                if (cbo_gjz.Checked)
                {
                    if (Data.IndexOf(txt_gjz.Text) == -1) return;
                }

                lbl_RevNum.Text = (Convert.ToInt32(lbl_RevNum.Text) + 1).ToString();

                if (chkRecvHex.Checked)
                {
                    Data = Data.Replace(" ", "");
                    string ReceivedData = Regex.Replace(Data, @".{2}", "$0 ");
                    Log.Write(this.txtReceived, ReceivedData, LogType.Recv);
                }
                else
                {
                    Log.Write(this.txtReceived, Data, LogType.Recv);
                }

                string strData = Data.Replace(" ", "");




                //时间应答帧
                if (strData.Length == 44)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "001F3435" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        string state = strData.Substring(26, 2);
                        string msg = "读取时间成功";
                        if (state == "48")
                        {
                            msg = "手动设置时间失败";
                        }
                        else if (state == "C8")
                        {
                            msg = "手动设置时间成功";
                        }
                        else if (state == "45")
                        {
                            msg = "NB网络校时失败";
                        }
                        else if (state == "C5")
                        {
                            msg = "NB网络校时成功";
                        }

                        Log.Write(this.txtReceived, "时间应答帧：\r\n表地址：" + MeterAddr(strData) + "" + msg + "\r\n时间:" + CommonlyHelper.ConvertDateTime(strData.Substring(28, 12)), LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }

                //数据应答帧 
                if (strData.Length == 46)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "810A901F" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        //表状态
                        string MeZT = strData.Substring(38, 2);
                        Int32 Switch = Convert.ToInt32(MeZT, 16);
                        MeZT = Convert.ToString(Switch, 2).PadLeft(8, '0');

                        string State = CommonlyHelper.StateToMsg(MeZT);

                        //电池电压
                        string MeDY = strData.Substring(40, 2);
                        double IntDY = Convert.ToDouble((Convert.ToInt32(MeDY, 16) + 200)) / 100;


                        //表底数整数位
                        string MeData = strData.Substring(28, 6);
                        //表底数小数位
                        string MeDatadou = strData.Substring(34, 3);
                        string MeDatas = null;
                        if (MeData.IndexOf("F") == -1)
                        {
                            MeDatas = (Convert.ToDouble(Convert.ToInt32(MeData) + "." + MeDatadou)).ToString();
                        }
                        else
                        {
                            MeDatas = MeData + "." + MeDatadou;
                        }

                        Log.Write(this.txtReceived, "数据应答帧：\r\n表地址：" + MeterAddr(strData) + "\r\n表数据：" + MeDatas
                            + "\r\n电池电压：" + IntDY + "V  "
                            + "\r\n表状态：" + State
                            , LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("接受帧错误" + ex.Message, "提示");
            }

        }



        /// <summary>
        /// 更新接收文本框的内容
        /// </summary>
        /// <param name="Data">接收到的数据</param>
        private void UpdateTextBox2(string Data)
        {
            try
            {
                if (cbo_gjz.Checked)
                {
                    if (Data.IndexOf(txt_gjz.Text) == -1) return;
                }

                lbl_RevNum2.Text = (Convert.ToInt32(lbl_RevNum2.Text) + 1).ToString();

                if (chkRecvHex2.Checked)
                {
                    Data = Data.Replace(" ", "");
                    string ReceivedData = Regex.Replace(Data, @".{2}", "$0 ");
                    Log.Write(this.txtReceived2, ReceivedData, LogType.Recv);
                }
                else
                {
                    Log.Write(this.txtReceived2, Data, LogType.Recv);
                }

                string strData = Data.Replace(" ", "");


                //时间应答帧
                if (strData.Length == 44)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "001F3435" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        string state = strData.Substring(26, 2);
                        string msg = "读取时间成功";
                        if (state == "48")
                        {
                            msg = "手动设置时间失败";
                        }
                        else if (state == "C8")
                        {
                            msg = "手动设置时间成功";
                        }
                        else if (state == "45")
                        {
                            msg = "NB网络校时失败";
                        }
                        else if (state == "C5")
                        {
                            msg = "NB网络校时成功";
                        }

                        Log.Write(this.txtReceived, "时间应答帧：\r\n表地址：" + MeterAddr(strData) + "" + msg + "\r\n时间:" + CommonlyHelper.ConvertDateTime(strData.Substring(28, 12)), LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }

                //数据应答帧 
                if (strData.Length == 46)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "810A901F" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        //表状态
                        string MeZT = strData.Substring(38, 2);
                        Int32 Switch = Convert.ToInt32(MeZT, 16);
                        MeZT = Convert.ToString(Switch, 2).PadLeft(8, '0');

                        string State = CommonlyHelper.StateToMsg(MeZT);

                        //电池电压
                        string MeDY = strData.Substring(40, 2);
                        double IntDY = Convert.ToDouble((Convert.ToInt32(MeDY, 16) + 200)) / 100;


                        //表底数整数位
                        string MeData = strData.Substring(28, 6);
                        //表底数小数位
                        string MeDatadou = strData.Substring(34, 3);
                        string MeDatas = null;
                        if (MeData.IndexOf("F") == -1)
                        {
                            MeDatas = (Convert.ToDouble(Convert.ToInt32(MeData) + "." + MeDatadou)).ToString();
                        }
                        else
                        {
                            MeDatas = MeData + "." + MeDatadou;
                        }

                        Log.Write(this.txtReceived, "数据应答帧：\r\n表地址：" + MeterAddr(strData) + "\r\n表数据：" + MeDatas
                            + "\r\n电池电压：" + IntDY + "V  "
                            + "\r\n表状态：" + State
                            , LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("接受帧错误" + ex.Message, "提示");
            }

        }




        /// <summary>
        /// 更新接收文本框的内容
        /// </summary>
        /// <param name="Data">接收到的数据</param>
        private void UpdateTextBox3(string Data)
        {
            try
            {
                if (cbo_gjz.Checked)
                {
                    if (Data.IndexOf(txt_gjz.Text) == -1) return;
                }

                lbl_RevNum3.Text = (Convert.ToInt32(lbl_RevNum3.Text) + 1).ToString();

                if (chkRecvHex3.Checked)
                {
                    Data = Data.Replace(" ", "");
                    string ReceivedData = Regex.Replace(Data, @".{2}", "$0 ");
                    Log.Write(this.txtReceived3, ReceivedData, LogType.Recv);
                }
                else
                {
                    Log.Write(this.txtReceived3, Data, LogType.Recv);
                }

                string strData = Data.Replace(" ", "");



                //时间应答帧
                if (strData.Length == 44)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "001F3435" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        string state = strData.Substring(26, 2);
                        string msg = "读取时间成功";
                        if (state == "48")
                        {
                            msg = "手动设置时间失败";
                        }
                        else if (state == "C8")
                        {
                            msg = "手动设置时间成功";
                        }
                        else if (state == "45")
                        {
                            msg = "NB网络校时失败";
                        }
                        else if (state == "C5")
                        {
                            msg = "NB网络校时成功";
                        }

                        Log.Write(this.txtReceived, "时间应答帧：\r\n表地址：" + MeterAddr(strData) + "" + msg + "\r\n时间:" + CommonlyHelper.ConvertDateTime(strData.Substring(28, 12)), LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }

                //数据应答帧 
                if (strData.Length == 46)
                {
                    if (strData.Substring(0, 2) == "68" && strData.Substring(18, 8) == "810A901F" && strData.Substring(strData.Length - 2, 2) == "16")
                    {
                        //表状态
                        string MeZT = strData.Substring(38, 2);
                        Int32 Switch = Convert.ToInt32(MeZT, 16);
                        MeZT = Convert.ToString(Switch, 2).PadLeft(8, '0');

                        string State = CommonlyHelper.StateToMsg(MeZT);

                        //电池电压
                        string MeDY = strData.Substring(40, 2);
                        double IntDY = Convert.ToDouble((Convert.ToInt32(MeDY, 16) + 200)) / 100;


                        //表底数整数位
                        string MeData = strData.Substring(28, 6);
                        //表底数小数位
                        string MeDatadou = strData.Substring(34, 3);
                        string MeDatas = null;
                        if (MeData.IndexOf("F") == -1)
                        {
                            MeDatas = (Convert.ToDouble(Convert.ToInt32(MeData) + "." + MeDatadou)).ToString();
                        }
                        else
                        {
                            MeDatas = MeData + "." + MeDatadou;
                        }

                        Log.Write(this.txtReceived, "数据应答帧：\r\n表地址：" + MeterAddr(strData) + "\r\n表数据：" + MeDatas
                            + "\r\n电池电压：" + IntDY + "V  "
                            + "\r\n表状态：" + State
                            , LogType.Recv);
                        timerReceived.Enabled = false;
                        return;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("接受帧错误" + ex.Message, "提示");
            }

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.Show();
        }


        private void cbo_timeSend_CheckedChanged(object sender, EventArgs e)
        {
            SendNum = 0;
            if (cbo_timeSend.Checked)
            {
                txt_timeSend.Enabled = false;
                txt_SendNumber.Enabled = false;
                this.timerSend.Enabled = true;
                btn_Open.Enabled = false;
            }
            else if (cbo_timeSend.Checked == false)
            {
                txt_timeSend.Enabled = true;
                txt_SendNumber.Enabled = true;
                this.timerSend.Enabled = false;
                btn_Open.Enabled = true;
            }
        }



        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btn_CustomData_Click(object sender, EventArgs e)
        {
            if (txt_MeterAddr.Text.Length < 10)
            {
                MessageBox.Show("请完善表地址！");
                txt_MeterAddr.Focus();
                return;
            }


            //获取表地址并填充厂商代码
            string MeterAddr = txt_MeterAddr.Text.ToString();
            MeterAddr = MeterAddr.Insert(2, txt_VendorCode.Text.ToString());

            //数据1
            string gdData = txt_gdData.Text.ToString();
            string Data1 = txt_Data1.Text.ToString();
            if (cbo_Hex1.Checked)
            {
                Data1 = Convert.ToString(Convert.ToInt32(Data1), 16);
            }
            Data1 = Data1.PadLeft(Convert.ToInt32(txt_leng1.Text), Convert.ToChar(txt_Pad1.Text));
            if (cbo_Res1.Checked)
            {
                Data1 = CommonlyHelper.Turn(Data1);
            }
            //数据2
            string Data2 = txt_Data2.Text.ToString();
            if (cbo_Hex2.Checked)
            {
                Data2 = Convert.ToString(Convert.ToInt32(Data2), 16);
            }
            Data2 = Data2.PadLeft(Convert.ToInt32(txt_leng2.Text), Convert.ToChar(txt_Pad2.Text));
            if (cbo_Res2.Checked)
            {
                Data2 = CommonlyHelper.Turn(Data2);
            }

            //数据3
            string Data3 = txt_Data3.Text.ToString();
            if (cbo_Hex3.Checked)
            {
                Data3 = Convert.ToString(Convert.ToInt32(Data3), 16);
            }
            Data3 = Data3.PadLeft(Convert.ToInt32(txt_leng3.Text), Convert.ToChar(txt_Pad3.Text));
            if (cbo_Res3.Checked)
            {
                Data3 = CommonlyHelper.Turn(Data3);
            }

            //组帧
            string str = "68" + MeterAddr + gdData + Data1 + Data2 + Data3;
            str = str.Replace(" ", "");

            if (str.Length % 2 != 0)
            {
                MessageBox.Show("输入数据长度不正确,请重新输入！");
                txt_Send.Focus();
                return;
            }

            //增加前导码和校验和以及结尾字符
            byte[] data = TypeConvert.HexStringToByte(str);
            byte VerifySum = Verify.GetVerifyFramesSum(data);
            byte[] newData = new byte[data.Length + 1];
            Array.Copy(data, newData, data.Length);
            newData[newData.Length - 1] = VerifySum;
            string NewString = TypeConvert.ByteToHexString(newData);
            str = NewString + "16";
            str = str.Replace(" ", "");
            str = txt_Code.Text.ToString() + str;
            string result = Regex.Replace(str, @".{2}", "$0 ");

            //增加到发送框
            txt_Send.Text = result;
            txt_Send.Focus();
            txt_Send.SelectAll();

        }




        private void Send(string DataStr, string SendName = "")
        {

            //获取表地址并填充厂商代码
            string MeterAddr = txt_MeterAddr.Text.ToString();
            if (MeterAddr.Length < 10)
            {
                MessageBox.Show("请完善表地址！");
                txt_MeterAddr.Focus();
                return;
            }

            MeterAddr = MeterAddr.Insert(2, txt_VendorCode.Text.ToString());

            //组帧
            string str = "68" + MeterAddr + DataStr;
            str = str.Replace(" ", "");


            //增加前导码和校验和以及结尾字符
            byte[] data = TypeConvert.HexStringToByte(str);
            byte VerifySum = Verify.GetVerifyFramesSum(data);
            byte[] newData = new byte[data.Length + 1];
            Array.Copy(data, newData, data.Length);
            newData[newData.Length - 1] = VerifySum;
            string NewString = TypeConvert.ByteToHexString(newData);
            str = NewString + "16";
            str = str.Replace(" ", "");
            str = txt_Code.Text.ToString() + str;


            //向串口发送数据
            byte[] DataString = TypeConvert.HexStringToByte(str);


            if (rdo_comPort1.Checked)
            {
                comport.Write(DataString, 0, DataString.Length);
                if (chkHidden.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived, result, LogType.Send);
                }

                lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();

                this.timerReceived.Enabled = true;


            }
            else if (rdo_comPort2.Checked)
            {
                comport2.Write(DataString, 0, DataString.Length);
                if (chkHidden2.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived2, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived2, result, LogType.Send);
                }

                lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();

                this.timerReceived2.Enabled = true;


            }
            else if (rdo_comPort3.Checked)
            {
                comport3.Write(DataString, 0, DataString.Length);
                if (chkHidden3.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived3, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived3, result, LogType.Send);
                }
                lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();

                this.timerReceived3.Enabled = true;



            }


            rowIndex = 0;

            this.sendTime = DateTime.Now;

            Thread.Sleep(600);
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            if (cbo_com1.Checked)
            {
                txtReceived.Text = "";
            }
            if (cbo_com2.Checked)
            {
                txtReceived2.Text = "";
            }
            if (cbo_com3.Checked)
            {
                txtReceived3.Text = "";
            }


        }

        private void txt_Send_TextChanged(object sender, EventArgs e)
        {
            lbl_DataCount.Text = txt_Send.Text.Length.ToString();
            txt_Focus.Text = this.txt_Send.SelectionStart.ToString();
        }

        private void txt_Send_Click(object sender, EventArgs e)
        {

            int start = txt_Send.SelectionStart;
            int end = txt_Send.SelectedText.Length;
            //txt_Send.Focus();
            txt_Send.Select(start, end);

            txt_Focus.Text = start.ToString();
            txt_SubLength.Text = end.ToString();
        }

        private void txt_Send_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Focus.Text = this.txt_Send.SelectionStart.ToString();
        }

        private void txt_Focus_TextChanged(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(string.IsNullOrWhiteSpace(txt_Focus.Text) ? "0" : txt_Focus.Text);
            int end = Convert.ToInt32(string.IsNullOrWhiteSpace(txt_SubLength.Text) ? "0" : txt_SubLength.Text);
            txt_Send.Focus();
            txt_Send.Select(start, end);
        }

        private void txt_SubLength_TextChanged(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(string.IsNullOrWhiteSpace(txt_Focus.Text) ? "0" : txt_Focus.Text);
            int end = Convert.ToInt32(string.IsNullOrWhiteSpace(txt_SubLength.Text) ? "0" : txt_SubLength.Text);
            txt_Send.Focus();
            txt_Send.Select(start, end);
        }

        private void lbl_SendNum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_SendNum.Text = "0";
        }

        private void lbl_RevNum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_RevNum.Text = "0";
        }

        private void btn_asyn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

        private void btn_dqData_Click(object sender, EventArgs e)
        {
            string Data = " 03 03 90 1F 00";
            string Name = "读取数据帧";
            Send(Data, Name);
        }

        private void btn_shData_Click(object sender, EventArgs e)
        {

            //获取表地址并填充厂商代码
            string OldMeterAddr = txt_OldMeterAddr.Text;
            if (OldMeterAddr.Length < 10)
            {
                MessageBox.Show("请完善表地址！");
                txt_OldMeterAddr.Focus();
                return;
            }
            OldMeterAddr.Insert(2, txt_VendorCode.Text.ToString());

            string NewMeterAddr = txt_MeterAddr.Text;
            if (NewMeterAddr.Length < 10)
            {
                MessageBox.Show("请完善新表地址！");
                txt_MeterAddr.Focus();
                return;
            }
            NewMeterAddr.Insert(2, txt_VendorCode.Text.ToString());


            string DataNum = txt_DataNum.Text.ToString();
            string DataNumData = "";
            if (DataNum.IndexOf('.') == -1)
            {
                DataNumData = DataNum.PadLeft(6, '0');
                DataNumData += "0000";
            }
            else
            {
                DataNumData = DataNum.Split('.')[0].PadLeft(6, '0');
                DataNumData += DataNum.Split('.')[1].PadRight(4, '0');
            }


            string No = "00000000000000000000";

            string str = "68" + OldMeterAddr + "531A0B7400" + NewMeterAddr + DataNumData + No;
            str = str.Replace(" ", "");

            //增加前导码和校验和以及结尾字符
            byte[] data = TypeConvert.HexStringToByte(str);
            byte VerifySum = Verify.GetVerifyFramesSum(data);
            byte[] newData = new byte[data.Length + 1];
            Array.Copy(data, newData, data.Length);
            newData[newData.Length - 1] = VerifySum;
            string NewString = TypeConvert.ByteToHexString(newData);
            str = NewString + "16";
            str = str.Replace(" ", "");
            str = txt_Code.Text.ToString() + str;

            string SendName = "设置数据帧";
            //向串口发送数据
            byte[] DataString = TypeConvert.HexStringToByte(str);
            if (rdo_comPort1.Checked)
            {
                comport.Write(DataString, 0, DataString.Length);
                if (chkHidden.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived, result, LogType.Send);
                }

                lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();

                this.timerReceived.Enabled = true;


            }
            else if (rdo_comPort2.Checked)
            {
                comport2.Write(DataString, 0, DataString.Length);
                if (chkHidden2.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived2, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived2, result, LogType.Send);
                }

                lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();

                this.timerReceived2.Enabled = true;


            }
            else if (rdo_comPort3.Checked)
            {
                comport3.Write(DataString, 0, DataString.Length);
                if (chkHidden3.Checked)
                {
                    string strSendName = "发送" + SendName + "成功！";
                    Log.Write(this.txtReceived3, strSendName, LogType.Send);

                    //格式化显示在接收文本框并记录日志
                    string result = Regex.Replace(str, @".{2}", "$0 ");
                    Log.Write(this.txtReceived3, result, LogType.Send);
                }
                lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();

                this.timerReceived3.Enabled = true;



            }

            rowIndex = 0;
            this.sendTime = DateTime.Now;

            Thread.Sleep(600);

        }

        private void btn_dqTime_Click(object sender, EventArgs e)
        {
            string Data = "36 35 2F 00";
            string Name = "读取时间帧";
            Send(Data, Name);
        }

        private void btn_szTime_Click(object sender, EventArgs e)
        {
            if (cbo_sync.Checked == true)
            {
                string Data = " 40 41 42 00";
                string Name = "读取时间帧";
                Send(Data, Name);
            }
            else
            {
                string strTime = dateTimePicker1.Text.ToString();

                string year = strTime.Substring(2, 2);
                string month = strTime.Substring(5, 2);
                string day = strTime.Substring(8, 2);
                string hour = strTime.Substring(11, 2);
                string min = strTime.Substring(14, 2);
                string s = strTime.Substring(17, 2);

                string Data = " 35 34 1F 00" + year + month + day + hour + min + s;
                string Name = "设置时间帧";
                Send(Data, Name);
            }
        }

        private void cbo_sync_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_sync.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void txt_timeSend_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_timeSend.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_timeSend.Text.Length; i++)
                {
                    if (txt_timeSend.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_timeSend.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_timeSend.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_timeSend.Text.Length - txt_timeSend.SelectionStart < 2)
                            {
                                if (txt_timeSend.SelectedText != txt_timeSend.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txt_SendNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_SendNumber.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_SendNumber.Text.Length; i++)
                {
                    if (txt_SendNumber.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_SendNumber.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_SendNumber.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_SendNumber.Text.Length - txt_SendNumber.SelectionStart < 2)
                            {
                                if (txt_SendNumber.SelectedText != txt_SendNumber.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txt_Focus_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_Focus.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_Focus.Text.Length; i++)
                {
                    if (txt_Focus.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_Focus.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_Focus.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_Focus.Text.Length - txt_Focus.SelectionStart < 2)
                            {
                                if (txt_Focus.SelectedText != txt_Focus.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_SubLength_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_SubLength.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_SubLength.Text.Length; i++)
                {
                    if (txt_SubLength.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_SubLength.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_SubLength.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_SubLength.Text.Length - txt_SubLength.SelectionStart < 2)
                            {
                                if (txt_SubLength.SelectedText != txt_SubLength.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_leng2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_leng2.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_leng2.Text.Length; i++)
                {
                    if (txt_leng2.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_leng2.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_leng2.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_leng2.Text.Length - txt_leng2.SelectionStart < 2)
                            {
                                if (txt_leng2.SelectedText != txt_leng2.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Pad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_Pad2.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_Pad2.Text.Length; i++)
                {
                    if (txt_Pad2.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_Pad2.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_Pad2.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_Pad2.Text.Length - txt_Pad2.SelectionStart < 2)
                            {
                                if (txt_Pad2.SelectedText != txt_Pad2.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_leng3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_leng3.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_leng3.Text.Length; i++)
                {
                    if (txt_leng3.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_leng3.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_leng3.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_leng3.Text.Length - txt_leng3.SelectionStart < 2)
                            {
                                if (txt_leng3.SelectedText != txt_leng3.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Pad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_Pad3.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_Pad3.Text.Length; i++)
                {
                    if (txt_Pad3.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_Pad3.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_Pad3.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_Pad3.Text.Length - txt_Pad3.SelectionStart < 2)
                            {
                                if (txt_Pad3.SelectedText != txt_Pad3.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_TimeOutNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_TimeOutNum.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_TimeOutNum.Text.Length; i++)
                {
                    if (txt_TimeOutNum.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_TimeOutNum.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_TimeOutNum.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_TimeOutNum.Text.Length - txt_TimeOutNum.SelectionStart < 2)
                            {
                                if (txt_TimeOutNum.SelectedText != txt_TimeOutNum.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_leng1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_leng1.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_leng1.Text.Length; i++)
                {
                    if (txt_leng1.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_leng1.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_leng1.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_leng1.Text.Length - txt_leng1.SelectionStart < 2)
                            {
                                if (txt_leng1.SelectedText != txt_leng1.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Pad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_Pad1.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_Pad1.Text.Length; i++)
                {
                    if (txt_Pad1.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_Pad1.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_Pad1.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_Pad1.Text.Length - txt_Pad1.SelectionStart < 2)
                            {
                                if (txt_Pad1.SelectedText != txt_Pad1.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_DataNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;       //让操作生效  
                int j = 0;
                int k = 0;
                bool flag = false;
                if (txt_DataNum.Text.Length == 0)
                {
                    if (e.KeyChar == '.')
                    {
                        e.Handled = true;             //让操作失效  
                    }
                }
                for (int i = 0; i < txt_DataNum.Text.Length; i++)
                {
                    if (txt_DataNum.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                    }
                    if (flag)
                    {
                        if (char.IsNumber(txt_DataNum.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            e.Handled = true;             //让操作失效  
                        }
                    }
                    if (k == 2)
                    {
                        if (char.IsNumber(txt_DataNum.Text[i]) && e.KeyChar != (char)Keys.Back)
                        {
                            if (txt_DataNum.Text.Length - txt_DataNum.SelectionStart < 2)
                            {
                                if (txt_DataNum.SelectedText != txt_DataNum.Text)
                                {
                                    e.Handled = true;             ////让操作失效  
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_extension_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count < 100)
            {
                int length = 100 - DataGridView1.Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    DataGridView1.Rows.Add();
                    DataGridView1.Rows[i].Cells[2].Value = i + 1 + "无注释";
                    DataGridView1.Rows[i].Cells[3].Value = "0";
                    DataGridView1.Rows[i].Cells[4].Value = "1000";
                }

            }

            string extension = btn_extension.Text;
            btn_extension.Text = extension == "扩展" ? "隐藏" : "扩展";
            gb_extension.Visible = extension == "扩展" ? true : false;
        }

        private void btn_RecAddHeight_Click(object sender, EventArgs e)
        {
            txtReceived.Visible = true;
            txtReceived2.Visible = true;
            txtReceived3.Visible = true;

            //if (btn_RecAddHeight.Text == "半展开")
            //{
            //    btn_RecAddHeight.Text = "全展开";
            //    skinGroupBox10.Location = new Point(7, 146);
            //    skinGroupBox10.Size = new Size(610, 649);
            //    txtReceived.Height = 603;
            //    txtReceived2.Height = 603;
            //    txtReceived3.Height = 603;

            //}
            if (btn_RecAddHeight.Text == "展开")
            {
                skinGroupBox1.Visible = false;
                skinGroupBox3.Visible = false;
                skinGroupBox11.Visible = false;
                //gb_extension.Visible = false;

                btn_RecAddHeight.Text = "收缩";
                skinGroupBox10.Location = new Point(7, 146);
                skinGroupBox10.Size = new Size(1213, 649);

                txtReceived.Height = 603;
                txtReceived.Width = 400;

                panel2.Location = new Point(407, 13);
                txtReceived2.Location = new Point(407, 40);
                txtReceived2.Height = 603;
                txtReceived2.Width = 400;

                panel3.Location = new Point(809, 13);
                txtReceived3.Location = new Point(809, 40);
                txtReceived3.Height = 603;
                txtReceived3.Width = 400;

                skinGroupBox11.Visible = false;
                skinGroupBox1.Visible = false;

            }
            else if (btn_RecAddHeight.Text == "收缩")
            {
                skinGroupBox1.Visible = true;
                skinGroupBox3.Visible = true;
                skinGroupBox11.Visible = true;
                //gb_extension.Visible = true;

                btn_RecAddHeight.Text = "展开";
                skinGroupBox10.Location = new Point(7, 268);
                skinGroupBox10.Size = new Size(610, 527);

                txtReceived.Height = 481;
                txtReceived.Width = 200;

                panel2.Location = new Point(205, 13);
                txtReceived2.Location = new Point(205, 40);
                txtReceived2.Height = 481;
                txtReceived2.Width = 200;

                panel3.Location = new Point(405, 13);
                txtReceived3.Location = new Point(405, 40);
                txtReceived3.Height = 481;
                txtReceived3.Width = 200;

                skinGroupBox11.Visible = true;
                skinGroupBox1.Visible = true;
            }


        }

        private void btn_Open2_Click(object sender, EventArgs e)
        {

            try
            {
                if (comport2.IsOpen)
                {
                    comport2.Close();
                    rowIndex = -1;
                }
                else
                {
                    //Set the port's settings
                    comport2.BaudRate = int.Parse(cmbBaudRate2.Text);
                    comport2.DataBits = int.Parse(cmbDataBits2.Text);
                    comport2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits2.Text);
                    comport2.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity2.Text);
                    comport2.PortName = cmbPortName2.Text;

                    //Open the port
                    comport2.Open();
                }

                cmbPortName2.Enabled = cmbStopBits2.Enabled = cmbBaudRate2.Enabled = cmbParity2.Enabled = cmbDataBits2.Enabled = !comport2.IsOpen;
                if (comport.IsOpen || comport2.IsOpen || comport3.IsOpen)
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = true;
                }
                else
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = false;
                }
                if (comport2.IsOpen)
                {
                    btn_Open2.Text = "&C关闭端口";
                    Lbl_Flag2.Text = "开启";
                    Lbl_Flag2.ForeColor = Color.Green;
                }
                else
                {
                    btn_Open2.Text = "&O打开端口";
                    Lbl_Flag2.Text = "关闭";
                    Lbl_Flag2.ForeColor = Color.Red;
                }
                if (comport2.IsOpen) txt_Send.Focus();
            }
            catch (Exception er)
            { MessageBox.Show("端口打开失败！" + er.Message, "提示"); }

        }

        private void btn_Open3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comport3.IsOpen)
                {
                    comport3.Close();
                    rowIndex = -1;
                }
                else
                {
                    //Set the port's settings
                    comport3.BaudRate = int.Parse(cmbBaudRate3.Text);
                    comport3.DataBits = int.Parse(cmbDataBits3.Text);
                    comport3.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits3.Text);
                    comport3.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity3.Text);
                    comport3.PortName = cmbPortName3.Text;

                    //Open the port
                    comport3.Open();
                }
                cmbPortName3.Enabled = cmbStopBits3.Enabled = cmbBaudRate3.Enabled = cmbParity3.Enabled = cmbDataBits3.Enabled = !comport3.IsOpen;
                if (comport.IsOpen || comport2.IsOpen || comport3.IsOpen)
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = true;
                }
                else
                {
                    cbo_timeSend.Enabled = btn_Send.Enabled = false;
                }

                if (comport3.IsOpen)
                {
                    btn_Open3.Text = "&C关闭端口";
                    Lbl_Flag3.Text = "开启";
                    Lbl_Flag3.ForeColor = Color.Green;
                }
                else
                {
                    btn_Open3.Text = "&O打开端口";
                    Lbl_Flag3.Text = "关闭";
                    Lbl_Flag3.ForeColor = Color.Red;
                }
                if (comport3.IsOpen) txt_Send.Focus();
            }
            catch (Exception er)
            { MessageBox.Show("端口打开失败！" + er.Message, "提示"); }
        }

        private void check_All_CheckedChanged(object sender, EventArgs e)
        {
            if (check_All.Checked)
            {
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    ((DataGridViewCheckBoxCell)DataGridView1.Rows[i].Cells["Column1"]).Value = true;
                }
            }
            else
            {
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    ((DataGridViewCheckBoxCell)DataGridView1.Rows[i].Cells["Column1"]).Value = false;
                }
            }
        }

        private void txtReceived_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtReceived.Width == 600)
            {
                txtReceived.Width = 200;
                txtReceived2.Visible = true;
                txtReceived3.Visible = true;
            }
            else if (txtReceived.Width == 200)
            {
                txtReceived.Width = 600;
                txtReceived2.Visible = false;
                txtReceived3.Visible = false;
            }
        }

        private void txtReceived2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtReceived2.Width == 600)
            {
                txtReceived2.Location = new Point(205, 40);
                txtReceived2.Width = 200;
                txtReceived.Visible = true;
                txtReceived3.Visible = true;
            }
            else if (txtReceived2.Width == 200)
            {
                txtReceived2.Location = new Point(5, 40);
                txtReceived2.Width = 600;
                txtReceived.Visible = false;
                txtReceived3.Visible = false;
            }
        }

        private void txtReceived3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtReceived3.Width == 600)
            {
                txtReceived3.Location = new Point(405, 40);
                txtReceived3.Width = 200;
                txtReceived.Visible = true;
                txtReceived2.Visible = true;
            }
            else if (txtReceived3.Width == 200)
            {
                txtReceived3.Location = new Point(5, 40);
                txtReceived3.Width = 600;
                txtReceived.Visible = false;
                txtReceived2.Visible = false;
            }
        }

        private void txtReceived_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //设置保存文件对话框的标题
                sfd.Title = "请选择要保存的文件路径";
                sfd.FileName = "串口一接收数据" + DateTime.Now.ToString("yyyy-MM-dd");
                //初始化保存目录，默认exe文件目录
                //sfd.InitialDirectory = Application.StartupPath;
                sfd.RestoreDirectory = true;

                //设置保存文件的类型
                sfd.Filter = "文本文件|*.txt|所有文件|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //获得保存文件的路径
                    string filePath = sfd.FileName;
                    //保存
                    using (FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        string txtData = txtReceived.Text.ToString().Replace("\n", "\r\n");
                        byte[] buffer = Encoding.Default.GetBytes(txtData);
                        fsWrite.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        private void txtReceived2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //设置保存文件对话框的标题
                sfd.Title = "请选择要保存的文件路径";
                sfd.FileName = "串口二接收数据" + DateTime.Now.ToString("yyyy-MM-dd");
                //初始化保存目录，默认exe文件目录
                //sfd.InitialDirectory = Application.StartupPath;
                sfd.RestoreDirectory = true;

                //设置保存文件的类型
                sfd.Filter = "文本文件|*.txt|所有文件|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //获得保存文件的路径
                    string filePath = sfd.FileName;
                    //保存
                    using (FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        string txtData = txtReceived2.Text.ToString().Replace("\n", "\r\n");
                        byte[] buffer = Encoding.Default.GetBytes(txtData);
                        fsWrite.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        private void txtReceived3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                //设置保存文件对话框的标题
                sfd.Title = "请选择要保存的文件路径";
                sfd.FileName = "串口三接收数据" + DateTime.Now.ToString("yyyy-MM-dd");
                //初始化保存目录，默认exe文件目录
                //sfd.InitialDirectory = Application.StartupPath;
                sfd.RestoreDirectory = true;

                //设置保存文件的类型
                sfd.Filter = "文本文件|*.txt|所有文件|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //获得保存文件的路径
                    string filePath = sfd.FileName;
                    //保存
                    using (FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        string txtData = txtReceived3.Text.ToString().Replace("\n", "\r\n");
                        byte[] buffer = Encoding.Default.GetBytes(txtData);
                        fsWrite.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count == 0)
            {
                return;
            }

            saveFileDialog.Title = "请选择要导出的位置";
            saveFileDialog.Filter = "Excel文件| *.xls";
            saveFileDialog.FileName = "自定义发送帧" + DateTime.Now.ToString("yyyy-MM-dd");
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (saveFileDialog.FileName != "")
                {
                    //创建Excel文件的对象
                    NPOI.HSSF.UserModel.HSSFWorkbook book = new NPOI.HSSF.UserModel.HSSFWorkbook();
                    //添加一个sheet
                    NPOI.SS.UserModel.ISheet sheet1 = book.CreateSheet("Sheet1");
                    //获取list数据
                    //List<TB_STUDENTINFOModel> listRainInfo = m_BLL.GetSchoolListAATQ(schoolname);

                    //  DataTable listRainInfo = mymssqlConnet.DAL_SelectDT_Par("EnrollmentGroup", mySqlParameters);
                    //给sheet1添加第一行的头部标题

                    NPOI.SS.UserModel.IRow row1 = sheet1.CreateRow(0);
                    row1.CreateCell(0).SetCellValue("HEX");
                    row1.CreateCell(1).SetCellValue("字符串[双击注释]");
                    row1.CreateCell(2).SetCellValue("点击发送");
                    //row1.CreateCell(3).SetCellValue("顺序");
                    row1.CreateCell(4).SetCellValue("延时ms");
                    for (int i = 0; i < DataGridView1.Rows.Count; i++)
                    {


                        object Column2 = DataGridView1.Rows[i].Cells["Column2"].Value;
                        if (Column2 == null)
                            continue;

                        NPOI.SS.UserModel.IRow rowtemp = sheet1.CreateRow(i + 1);
                        rowtemp.CreateCell(1).SetCellValue(Column2.ToString());

                        object Column1 = ((DataGridViewCheckBoxCell)DataGridView1.Rows[i].Cells["Column1"]).Value;
                        if (Column1 == null)
                            Column1 = false;

                        rowtemp.CreateCell(0).SetCellValue((bool)Column1 == false ? "0" : "1");

                        rowtemp.CreateCell(2).SetCellValue(DataGridView1.Rows[i].Cells["Column3"].Value.ToString());
                        //rowtemp.CreateCell(3).SetCellValue(DataGridView1.Rows[i].Cells["Column4"].Value.ToString());
                        rowtemp.CreateCell(4).SetCellValue(DataGridView1.Rows[i].Cells["Column5"].Value.ToString());

                    }
                    FileStream ms = File.OpenWrite(saveFileDialog.FileName.ToString());
                    try
                    {

                        book.Write(ms);
                        ms.Seek(0, SeekOrigin.Begin);
                        MessageBox.Show("导出成功");
                    }
                    catch
                    {
                        MessageBox.Show("导出失败!");
                    }
                    finally
                    {
                        if (ms != null)
                        {
                            ms.Close();
                        }

                    }
                }
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "表格文件 (*.xls)|*.xls";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = ExcelHelper.ImportExcelToDataTable(openFileDialog.FileName);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataGridView1.Rows[i].Cells["Column1"].Value = dt.Rows[i][0].ToString() == "1" ? true : false;
                    DataGridView1.Rows[i].Cells["Column2"].Value = dt.Rows[i][1].ToString();
                    DataGridView1.Rows[i].Cells["Column3"].Value = dt.Rows[i][2].ToString();
                    //DataGridView1.Rows[i].Cells["Column4"].Value = dt.Rows[i][3].ToString();
                    DataGridView1.Rows[i].Cells["Column5"].Value = dt.Rows[i][4].ToString();
                }
            }
        }

        private void lbl_SendNum2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_SendNum2.Text = "0";
        }

        private void lbl_RevNum2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_RevNum2.Text = "0";
        }

        private void lbl_SendNum3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_SendNum3.Text = "0";
        }

        private void lbl_RevNum3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_RevNum3.Text = "0";
        }

        private void btn_ForeachSend_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_ForeachSend.Checked)
            {
                trSend = new Thread(cycleSend);
                trSend.Start();
            }
            else
            {
                trSend.Abort();
            }
        }
        private void cycleSend()
        {
            DataTable grivDt = ExcelHelper.GetDgvToTable(DataGridView1);
            DataTable dt = new DataTable();

            grivDt.DefaultView.Sort = "Column4 ASC";
            dt = grivDt.DefaultView.ToTable();



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridView1.Rows[i].Cells["Column2"].Style.ForeColor = Color.Red;
                //延时下发
                int waitTime = Convert.ToInt32(dt.Rows[i][5]);
                Thread.Sleep(waitTime);

                string Column2 = dt.Rows[i][2].ToString();
                if (string.IsNullOrWhiteSpace(Column2))
                    continue;

                string strSend = Column2;
                strSend = strSend.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");

                if (strSend.Length % 2 != 0)
                {
                    DataGridView1.Rows[i].Cells["Column2"].Style.ForeColor = Color.Black;
                    DataGridView1.Rows[i].Cells["Column3"].Value = "输入数据长度不正确";
                    continue;
                }

                var dt0 = dt.Rows[i][1].ToString();
                if (string.IsNullOrWhiteSpace(dt0))
                    dt0 = "false";

                bool Column1 = Convert.ToBoolean(dt0);

                if (rdo_comPort1.Checked)
                {
                    if (Column1 == true)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                                {
                                    Log.Write(txtReceived, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                                }));

                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                            {

                                lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                            }));
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(Column2);
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                                {
                                    Log.Write(this.txtReceived, Column2, LogType.Send);
                                }));

                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                            {
                                lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                            }));
                    }
                }
                else if (rdo_comPort2.Checked)
                {
                    if (Column1 == true)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport2.Write(data, 0, data.Length);

                        if (chkHidden2.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                            {
                                Log.Write(this.txtReceived2, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                            }));
                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                        {
                            lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                        }));
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(Column2);
                        comport2.Write(data, 0, data.Length);

                        if (chkHidden2.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                            {
                                Log.Write(this.txtReceived2, Column2, LogType.Send);
                            }));
                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                        {
                            lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                        }));
                    }
                }

                else if (rdo_comPort3.Checked)
                {
                    if (Column1 == true)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport3.Write(data, 0, data.Length);

                        if (chkHidden3.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                                {
                                    Log.Write(this.txtReceived3, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                                }));
                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                            {
                                lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                            }));
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(Column2);
                        comport3.Write(data, 0, data.Length);

                        if (chkHidden3.Checked)
                        {
                            lock (this)
                                Invoke(new MethodInvoker(delegate ()
                                {
                                    Log.Write(this.txtReceived3, Column2, LogType.Send);
                                }));
                        }
                        lock (this)
                            Invoke(new MethodInvoker(delegate ()
                            {
                                lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                            }));
                    }
                }

                DataGridView1.Rows[i].Cells["Column2"].Style.ForeColor = Color.Black;
            }

            lock (this)
                Invoke(new MethodInvoker(delegate ()
                {
                    btn_ForeachSend.Checked = false;
                }));


        }


        private void timerReceived2_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timerReceived2.Enabled = false;
                TimeSpan timing = (DateTime.Now - this.sendTime);
                if (timing.TotalSeconds >= Convert.ToInt32(txt_TimeOutNum.Text))
                {
                    //该方法执行，说明命令超时
                    Log.Write(this.txtReceived2, "命令超时...", LogType.Recv);
                    rowIndex = -1;

                }
            }
            finally
            {
                if (rowIndex >= 0)
                    this.timerReceived2.Enabled = true;
            }
        }

        private void timerReceived3_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timerReceived3.Enabled = false;
                TimeSpan timing = (DateTime.Now - this.sendTime);
                if (timing.TotalSeconds >= Convert.ToInt32(txt_TimeOutNum.Text))
                {
                    //该方法执行，说明命令超时
                    Log.Write(this.txtReceived3, "命令超时...", LogType.Recv);
                    rowIndex = -1;

                }
            }
            finally
            {
                if (rowIndex >= 0)
                    this.timerReceived3.Enabled = true;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Columns[e.ColumnIndex].Name == "Column3")
            {
                object value = DataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
                if (value == null) value = "";

                string strSend = value.ToString();
                strSend = strSend.Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");
                if (strSend.Length % 2 != 0)
                {
                    MessageBox.Show("输入数据长度不正确,请重新输入！");
                    txt_Send.Focus();
                    return;
                }

                var dt0 = DataGridView1.Rows[e.RowIndex].Cells["Column1"].Value;
                if (dt0 == null)
                    dt0 = "false";

                bool Column1 = Convert.ToBoolean(dt0);


                if (rdo_comPort1.Checked)
                {
                    if (Column1)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            Log.Write(this.txtReceived, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                        }
                        lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(value.ToString());
                        comport.Write(data, 0, data.Length);
                        if (chkHidden.Checked)
                        {
                            Log.Write(this.txtReceived, value.ToString(), LogType.Send);
                        }
                        lbl_SendNum.Text = (Convert.ToInt32(lbl_SendNum.Text) + 1).ToString();
                    }
                }
                else if (rdo_comPort2.Checked)
                {
                    if (Column1)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport2.Write(data, 0, data.Length);

                        if (chkHidden2.Checked)
                        {
                            Log.Write(this.txtReceived2, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                        }

                        lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(value.ToString());
                        comport2.Write(data, 0, data.Length);

                        if (chkHidden2.Checked)
                        {
                            Log.Write(this.txtReceived2, value.ToString(), LogType.Send);
                        }
                        lbl_SendNum2.Text = (Convert.ToInt32(lbl_SendNum2.Text) + 1).ToString();
                    }
                }

                else if (rdo_comPort3.Checked)
                {
                    if (Column1)
                    {
                        byte[] data = TypeConvert.HexStringToByte(strSend.Replace(" ", ""));
                        comport3.Write(data, 0, data.Length);

                        if (chkHidden3.Checked)
                        {
                            Log.Write(this.txtReceived3, Regex.Replace(strSend, @".{2}", "$0 "), LogType.Send);
                        }

                        lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                    }
                    else
                    {
                        byte[] data = Encoding.Default.GetBytes(value.ToString());
                        comport3.Write(data, 0, data.Length);

                        if (chkHidden3.Checked)
                        {
                            Log.Write(this.txtReceived3, value.ToString(), LogType.Send);
                        }
                        lbl_SendNum3.Text = (Convert.ToInt32(lbl_SendNum3.Text) + 1).ToString();
                    }
                }
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {
                sendIndex = e.RowIndex + 1;

                updateName upName = new updateName();
                upName.StartPosition = FormStartPosition.CenterScreen;
                upName.ShowDialog();
                if (!string.IsNullOrWhiteSpace(upName.SetNmae))
                {
                    DataGridView1.Rows[e.RowIndex].Cells["Column3"].Value = upName.SetNmae;
                }
            }
        }

        private void skinCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBox1.Checked)
            {
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    ((DataGridViewCheckBoxCell)DataGridView1.Rows[i].Cells["Column6"]).Value = true;
                }
            }
            else
            {
                for (int i = 0; i < DataGridView1.Rows.Count; i++)
                {
                    ((DataGridViewCheckBoxCell)DataGridView1.Rows[i].Cells["Column6"]).Value = false;
                }
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                int selectedCellCount = DataGridView1.GetCellCount(DataGridViewElementStates.Selected);
                if (selectedCellCount > 0)
                {
                    if (DataGridView1.AreAllCellsSelected(true))
                    {
                        MessageBox.Show("All cells are selected", "Selected Cells");
                    }
                    else
                    {
                        for (int i = 0;
                            i < selectedCellCount; i++)
                        {
                            if (DataGridView1.SelectedCells[i].ColumnIndex == 1)
                            {
                                var hexValue = DataGridView1.Rows[DataGridView1.SelectedCells[i].RowIndex].Cells["Column1"].Value;
                                if (hexValue == null)
                                    hexValue = "false";

                                DataGridView1.Rows[DataGridView1.SelectedCells[i].RowIndex].Cells["Column1"].Value = Convert.ToBoolean(hexValue) ? false : true;
                            }
                            else if (DataGridView1.SelectedCells[i].ColumnIndex == 0)
                            {
                                var hexValue = DataGridView1.Rows[DataGridView1.SelectedCells[i].RowIndex].Cells["Column6"].Value;
                                if (hexValue == null)
                                    hexValue = "false";
                                DataGridView1.Rows[DataGridView1.SelectedCells[i].RowIndex].Cells["Column6"].Value = Convert.ToBoolean(hexValue) ? false : true;
                            }


                        }


                    }
                }


            }
        }

        private void btn_SendClear_Click(object sender, EventArgs e)
        {
            txt_Send.Text = "";
        }
    }
}
