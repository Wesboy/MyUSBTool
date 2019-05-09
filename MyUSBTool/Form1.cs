using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCAN
{
    public partial class Form1 : Form
    {
        private SerialPort ComDevice = new SerialPort();
        public byte iLed = 0x0;             //0x1 red 0x02 blue 0x04 Green
        public byte iPwm = 0x0;             //0x0 - 0xff
        public byte iCount = 0x0;              //timer count

        public Form1()
        {
           
            InitializeComponent();
            this.init();
        }

        public void checkLed()
        {
            byte[] rgbled = new byte[5];

            if (ComDevice.IsOpen)
            {
                iLed = 0x0;
                if (chkRed.Checked)
                    iLed = 0x01;

                if (chkBlue.Checked)
                    iLed = (byte)(0x2+iLed);

                if (chkGreen.Checked)
                    iLed = (byte)(0x4+iLed);

                
                rgbled[0] = 0xaa;
                rgbled[1] = iLed;
                rgbled[2] = (byte)trbRed.Value;
                rgbled[3] = (byte)trbBlue.Value;
                rgbled[4] = (byte)trbGreen.Value;

                SendData(rgbled);
            }

 
        }

        public void init()
        {
            MyComPort.Items.AddRange(SerialPort.GetPortNames());
            if (BaudrateBox.Items.Count > 0)
            {
                BaudrateBox.SelectedIndex = 0;
            }
            BaudrateBox.SelectedIndex = 11;
            comDataBit.SelectedIndex = 0;
            comParity.SelectedIndex = 0;
            comStopBit.SelectedIndex = 0;

            checkLed();

            ComDevice.DataReceived += new SerialDataReceivedEventHandler(Com_DataReceived);//绑定事件
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenDev_btn_Click(object sender, EventArgs e)
        {
            if (BaudrateBox.Items.Count <= 0)
            {

            }

            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = MyComPort.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(BaudrateBox.SelectedItem.ToString());
                ComDevice.Parity = (Parity)Convert.ToInt32(comParity.SelectedIndex.ToString());
                ComDevice.DataBits = Convert.ToInt32(comDataBit.SelectedItem.ToString());
                ComDevice.StopBits = (StopBits)Convert.ToInt32(comStopBit.SelectedItem.ToString());

                try
                {
                    ComDevice.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                OpenDev_btn.Text = "关闭设备";

            }
            else
            {
                try {
                    ComDevice.Close();
                    btnComSnd.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                OpenDev_btn.Text = "打开设备";
            }

            MyComPort.Enabled = !ComDevice.IsOpen;
            BaudrateBox.Enabled = !ComDevice.IsOpen;
            comParity.Enabled = !ComDevice.IsOpen;
            comDataBit.Enabled = !ComDevice.IsOpen;
            comStopBit.Enabled = !ComDevice.IsOpen;
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            this.AddData(ReDatas);//输出数据
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="data">字节数组</param>
        public void AddData(byte[] data)
        {
#if false 
            if (rbtnHex.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                AddContent(sb.ToString().ToUpper());
            }
            else if (rbtnASCII.Checked)
            {
                AddContent(new ASCIIEncoding().GetString(data));
            }
            else if (rbtnUTF8.Checked)
            {
                AddContent(new UTF8Encoding().GetString(data));
            }
            else if (rbtnUnicode.Checked)
            {
                AddContent(new UnicodeEncoding().GetString(data));
            }
            else
            { }


            lblRevCount.Invoke(new MethodInvoker(delegate
            {
                lblRevCount.Text = (int.Parse(lblRevCount.Text) + data.Length).ToString();
            }));
#else
            AddContent(new ASCIIEncoding().GetString(data));
#endif
        }


        /// <summary>
        /// 输入到显示区域
        /// </summary>
        /// <param name="content"></param>
        private void AddContent(string content)
        {
            this.BeginInvoke(new MethodInvoker(delegate
            {
                if (chkautoline.Checked && TextShow.Text.Length > 0)
                {
                    TextShow.AppendText("\r\n");
                }
                TextShow.AppendText(content);
            }));
        }
        public bool SendData(byte[] data)
        {
            if (ComDevice.IsOpen)
            {
                try
                {
                    ComDevice.Write(data, 0, data.Length);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private void btnComSnd_Click(object sender, EventArgs e)
        {
            byte[] sendData = null;

            sendData = Encoding.ASCII.GetBytes(SendInfo.Text.Trim());

            if (this.SendData(sendData))//发送数据成功计数
            {
                
            }
            else
            {

            }
        }

        private void btnComClear_Click(object sender, EventArgs e)
        {
            TextShow.Clear();
        }

        private void SendInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkRed_CheckedChanged(object sender, EventArgs e)
        {
            checkLed();
        }

        private void chkBlue_CheckedChanged(object sender, EventArgs e)
        {
            checkLed();
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            checkLed();
        }

        private void hSbRedBar_CursorChanged(object sender, EventArgs e)
        {
            checkLed();
        }

        private void trbRed_CursorChanged(object sender, EventArgs e)
        {
            checkLed();
        }

        private void trbRed_LocationChanged(object sender, EventArgs e)
        {
            checkLed();
        }
    }
}
