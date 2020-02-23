using Sip2Service.Model;
using Sip2Service.SIP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sip2Service.Utils;

namespace Sip2Service
{
    public partial class MainForm : Form
    {
        private Sip2Helper helper;
        public static string sendMsg = string.Empty;
        //public string IP { set { txtIP.Text = value; }  }
        //public string Port { set { txtPort.Text = value; } }
        //public string AO { set { txtAO.Text = value; } }
        //public string AP { set { txtAP.Text = value; } }
        //public string Charset { set { txtCharset.Text = value; } }
        //public string Uid { set { txtUserName.Text = value; } }
        //public string Pwd { set { txtPwd.Text = value; } }
        //public string VP { set { cboxVP.Text = value; } }
        //public string LocationCode { set { txtLocationCode.Text = value; } }
        //public string ReaderCode { set { txtReaderCode.Text = value; } }
        //public string PIN { set { txtPIN.Text = value; } }
        //public string BookCode { set { txtBookCode.Text = value; } }

        public MainForm()
        {
            InitializeComponent();
        }

        public void SyncSip2Info(Sip2Model model)
        {
            txtIP.Text = model.IP;
            txtPort.Text = model.Port;
            txtAO.Text = model.AO;
            txtAP.Text = model.AP;
            txtCharset.Text = model.Charset;
            txtUserName.Text = model.Uid;
            txtPwd.Text = model.Pwd;
            cboxVP.Text = model.VP;
            txtLocationCode.Text = model.LocationCode;
            txtReaderCode.Text = model.ReaderCode;
            txtPIN.Text = model.PIN;
            txtBookCode.Text = model.BookCode;
        }

        /// <summary>
        /// 连接Sip2Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SipBtn_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text.Trim();
            string port = txtPort.Text.Trim();
            string charset = txtCharset.Text.Trim();
            string ao = txtAO.Text.Trim();
            string ap = txtAP.Text.Trim();
            string uid = txtUserName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string vp = cboxVP.Text.Trim();
            string locationCode = txtLocationCode.Text.Trim();

            if (string.IsNullOrEmpty(ip) || string.IsNullOrEmpty(port))
            {
                txtMessage.AppendText("请先填写完整IP和Port。\r\n");
                labConnect.Text = "Not Connected";
                return;
            }
            int portNum = 0;
            int.TryParse(port, out portNum);
            if (portNum == 0)
            {
                txtMessage.AppendText("Port格式不正确，必须为数字类型。\r\n");
                labConnect.Text = "Not Connected";
                return;
            }

            try
            {
                helper = new Sip2Helper(new Sip2Model() {
                    IP = ip,
                    Port = port,
                    AO = ao,
                    AP = ap,
                    Charset = charset,
                    Uid = uid,
                    Pwd = pwd,
                    VP = vp,
                    LocationCode = locationCode,
                });
                if (helper.IsConnected())
                {
                    txtMessage.AppendText("连接" + ip + ":" + port + "成功。\r\n");
                    labConnect.Text = "Connected to " + ip + ":" + port + " | AO = " + ao + "| AP = " +ap + "| VP = " + vp + "|";
                }
                else
                {
                    txtMessage.AppendText(helper.GetSendResult() + "\r\n");
                    labConnect.Text = "Not Connected";
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }           
        }

        /// <summary>
        /// 查询读者信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderInfo_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string readerCode = txtReaderCode.Text;
            string PIN = txtPIN.Text;
            try
            {
                if (helper == null)
                {
                    txtMessage.AppendText("请先连接Sip2服务器。\r\n");
                }
                else
                { 
                    result = helper.ReaderInformation(readerCode, PIN, null);
                    txtMsgTitle("查询读者信息");
                    txtMsgSend(MainForm.sendMsg);
                    txtMsgReceive(result);
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }
        }

        /// <summary>
        /// 查询图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBookInfo_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string bookCode = txtBookCode.Text;
            try
            {
                if (helper == null)
                {
                    txtMessage.AppendText("请先连接Sip2服务器。\r\n");
                }
                else
                {
                    result = helper.BookInfomation(bookCode);
                    txtMsgTitle("查询图书信息");
                    txtMsgSend(MainForm.sendMsg);
                    txtMsgReceive(result);
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }
        }

        /// <summary>
        /// 借书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBorrow_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string readerCode = txtReaderCode.Text;
            string bookCode = txtBookCode.Text;
            string PIN = txtPIN.Text;

            try
            {
                if (helper == null)
                {
                    txtMessage.AppendText("请先连接Sip2服务器。\r\n");
                }
                else
                {
                    result = helper.BookCheckOut(readerCode, PIN, bookCode);
                    txtMsgTitle("借书");
                    txtMsgSend(MainForm.sendMsg);
                    txtMsgReceive(result);
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }
        }

        /// <summary>
        /// 还书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string bookCode = txtBookCode.Text;
            try
            {
                if (helper == null)
                {
                    txtMessage.AppendText("请先连接Sip2服务器。\r\n");
                }
                else
                {
                    result = helper.BookCheckIn(bookCode);
                    txtMsgTitle("还书");
                    txtMsgSend(MainForm.sendMsg);
                    txtMsgReceive(result);
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }
        }

        /// <summary>
        /// 配置Sip2Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetSip2ServerMenu_Click(object sender, EventArgs e)
        {
            SetSip2Form sip2Form = new SetSip2Form();
            sip2Form.Id = 0;
            sip2Form.ShowDialog();
        }

        /// <summary>
        /// 选择Sip2服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseSip2ServerMenu_Click(object sender, EventArgs e)
        {
            GetSip2Form sip2Form = new GetSip2Form(this);
            sip2Form.ShowDialog();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        /// <summary>
        /// 为了是主界面能够移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        /// <summary>
        /// 清空日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMessage.ResetText();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("版本：1.1\r\n作者：wsx\r\n日期：2019.08", "关于Sip2Client");
        }

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            string bookCode = txtBookCode.Text;
            string locationCode = txtLocationCode.Text;
            string vp = cboxVP.Text;
            try
            {
                if (helper == null)
                {
                    txtMessage.AppendText("请先连接Sip2服务器。\r\n");
                }
                else
                {
                    string uid = txtUserName.Text;
                    string pwd = txtPwd.Text;
                    result = helper.Login2(uid, pwd, locationCode, vp);
                    txtMsgTitle("管理员登录");
                    txtMsgSend(MainForm.sendMsg);
                    txtMsgReceive(result);
                }
            }
            catch (Exception ex)
            {
                txtMessage.AppendText("程序出现异常：" + ex.ToString() + "\r\n");
            }
        }

        /// <summary>
        /// 发送主题封装
        /// </summary>
        /// <param name="msg"></param>
        private void txtMsgTitle(string msg)
        {
            txtMessage.AppendTextColorful("<-- " +msg+ " --> \r\n", Color.Black);
        }

        /// <summary>
        /// 发送信息封装
        /// </summary>
        /// <param name="msg"></param>
        private void txtMsgSend(string msg)
        {
            txtMessage.AppendTextColorful("-->" + msg.Trim().Replace("\r", "") + "\r\n", Color.Red);
        }

        /// <summary>
        /// 接收信息封装
        /// </summary>
        /// <param name="msg"></param>
        private void txtMsgReceive(string msg)
        {
            txtMessage.AppendTextColorful("<--" + msg.Trim().Replace("\r", "") + "\r\n", Color.Blue);
        }

        /// <summary>
        /// Ctrl + A 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMsg_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((RichTextBox)sender).SelectAll();
            }
        }
    }
}
