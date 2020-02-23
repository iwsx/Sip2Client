using Sip2Service.Model;
using Sip2Service.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sip2Service
{
    public partial class SetSip2Form : Form
    {
        private GetSip2Form getForm;
        private static int id;

        public int Id { set { id = value; } }

        public SetSip2Form()
        {
            InitializeComponent();
        }

        public SetSip2Form(GetSip2Form getForm)
        {
            this.getForm = getForm;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //获取基目录，它由程序集冲突解决程序用来探测程序集。
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + "Sip2Info.db";
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);            
            //如果不存在数据库文件，则创建该数据库文件 
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteDBHelper.CreateDB(dbPath);
                // 创建表
                string sql = "CREATE TABLE Sip2Info(" +
                        "id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE" +
                        ",name varchar(500)" +
                        ",ip varchar(500)" +
                        ",port varchar(500)" +
                        ",ao varchar(500)" +
                        ",ap varchar(500)" +
                        ",charset varchar(500)" +
                        ",uid varchar(500)" +
                        ",pwd varchar(500)" +
                        ",VP varchar(500)" +
                        ",locationcode varchar(500)" +
                        ",readercode varchar(500)" +
                        ",PIN varchar(500)" +
                        ",bookcode varchar(500)" +
                        ")";
                    db.ExecuteNonQuery(sql, null);
                }
                // 添加数据
                string name = txtName.Text;
                string ip = txtIP.Text;
                string port = txtPort.Text;            
                string ao = txtAO.Text;
                string ap = txtAP.Text;
                string charset = txtCharset.Text;
                string uid = txtUserName.Text;
                string pwd = txtPwd.Text;
                string vp = cboxVP.Text;
                string locationcode = txtLocationCode.Text;
                string readercode = txtReaderCode.Text;
                string pin = txtPIN.Text;
                string bookcode = txtBookCode.Text;
                SQLiteParameter[] ps = {
                    new SQLiteParameter(){
                        ParameterName = "id",
                        Value = id
                    },
                    new SQLiteParameter(){
                        ParameterName = "name",
                        Value = name
                    },
                    new SQLiteParameter(){
                        ParameterName = "ip",
                        Value = ip
                    },
                    new SQLiteParameter(){
                        ParameterName = "port",
                        Value = port
                    },
                    new SQLiteParameter(){
                        ParameterName = "ao",
                        Value = ao
                    },
                    new SQLiteParameter(){
                        ParameterName = "ap",
                        Value = ap
                    },
                    new SQLiteParameter(){
                        ParameterName = "charset",
                        Value = charset
                    },
                        new SQLiteParameter(){
                        ParameterName = "uid",
                        Value = uid
                    },
                    new SQLiteParameter(){
                        ParameterName = "pwd",
                        Value = pwd
                    },
                    new SQLiteParameter(){
                        ParameterName = "vp",
                        Value = vp
                    },
                    new SQLiteParameter(){
                        ParameterName = "locationcode",
                        Value = locationcode
                    },
                    new SQLiteParameter(){
                        ParameterName = "readercode",
                        Value = readercode
                    },
                    new SQLiteParameter(){
                        ParameterName = "pin",
                        Value = pin
                    },
                    new SQLiteParameter(){
                        ParameterName = "bookcode",
                        Value = bookcode
                    },
                };

              if (id == 0)
             {
                  string addSql = "Insert into Sip2Info(name, ip, port, ao, ap, charset, uid, pwd, vp, locationcode, readercode, pin, bookcode) values(@name, @ip, @port, @ao, @ap, @charset, @uid, @pwd, @vp, @locationcode, @readercode, @pin, @bookcode)"; 
                db.ExecuteNonQuery(addSql, ps);
            }
            else
            {
                string updateSql = "update Sip2Info set name = @name, ip = @ip, port = @port, ao = @ao, ap = @ap, charset = @charset, uid = @uid , pwd = @pwd, vp = @vp, locationcode = @locationcode, readercode = @readercode, pin = @pin, bookcode = @bookcode where id = @id";
                db.ExecuteNonQuery(updateSql, ps);
            }
            
            // 关闭窗口
            this.Close();
            if(getForm != null)
                getForm.Reload();   
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = "sip2Info";
            txtIP.Text = "";
            txtPort.Text = "";
            txtAO.Text = "";
            txtAP.Text = "";
            txtCharset.Text = "";
            txtUserName.Text = "";
            txtPwd.Text = "";
            cboxVP.Text = "";
            txtLocationCode.Text = "";
            txtReaderCode.Text = "";
            txtPIN.Text = "";
            txtBP.Text = "1";
            txtBQ.Text = "5";
            txtBookCode.Text = "";
        }

        public void SyncSpi2Info(Sip2Model model)
        {
            id = model.id;
            txtName.Text = model.Sip2Name;
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
    }
}
