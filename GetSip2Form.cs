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
    public partial class GetSip2Form : Form
    {
        MainForm mform;
        SetSip2Form setform;
        public GetSip2Form(MainForm mform)
        {
            this.mform = mform;
            InitializeComponent();
        }

        public GetSip2Form(SetSip2Form setform)
        {
            this.setform = setform;
            InitializeComponent();
        }

        private void GetSip2Form_Load(object sender, EventArgs e)
        {
            //获取基目录，它由程序集冲突解决程序用来探测程序集。
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + "Sip2Info.db";
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            //如果不存在数据库文件，则创建该数据库文件 
            if (!System.IO.File.Exists(dbPath))
            {
                SQLiteDBHelper.CreateDB(dbPath);
                // 创建表
                string sqlCreate = "CREATE TABLE Sip2Info(" +
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
                db.ExecuteNonQuery(sqlCreate, null);
            }
            // 查询数据
            string sql = "select id, name as 名称, ip, port, ao, ap, charset as 字符集, uid, pwd, vp, locationcode, readercode, pin, bookcode from Sip2Info";
            DataTable dt = db.ExecuteDataTable(sql, null);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dgvSip2Server.DataSource = ds.Tables[0];
        }

        public void Reload()
        {
            //获取基目录，它由程序集冲突解决程序用来探测程序集。
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + "Sip2Info.db";
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            // 查询数据
            string sql = "select id, name as 名称, ip, port, ao, ap, charset as 字符集, uid, pwd, vp, locationcode, readercode, pin, bookcode from Sip2Info";
            DataTable dt = db.ExecuteDataTable(sql, null);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            dgvSip2Server.DataSource = ds.Tables[0];
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (IdIsNull(ref id))
            {
                MessageBox.Show("请选择具体的行！", "警告");
                return;
            }

            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要删除该行数据吗?", "确定", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            { 
                string sql = "delete from Sip2Info where id = @id";
                // 获取基目录，它由程序集冲突解决程序用来探测程序集。
                string dbPath = AppDomain.CurrentDomain.BaseDirectory + "Sip2Info.db";
                SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
                SQLiteParameter[] ps = {
                  new SQLiteParameter(){
                      ParameterName = "id",
                      Value = id
                  }
            };
                db.ExecuteNonQuery(sql, ps);
                this.Reload();
            }
            else//如果点击“取消”按钮
            {

            }            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SetSip2Form sip2Form = new SetSip2Form(this);
            sip2Form.Id = 0;
            sip2Form.Show();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (IdIsNull())
            {
                MessageBox.Show("请选择具体的行！", "警告");
                return;
            }
            Sip2Model model = new Sip2Model()
            {
                IP = dgvSip2Server.CurrentRow.Cells["ip"].Value.ToString(),
                Port = dgvSip2Server.CurrentRow.Cells["port"].Value.ToString(),
                AO = dgvSip2Server.CurrentRow.Cells["ao"].Value.ToString(),
                AP = dgvSip2Server.CurrentRow.Cells["ap"].Value.ToString(),
                Charset = dgvSip2Server.CurrentRow.Cells["字符集"].Value.ToString(),
                Uid = dgvSip2Server.CurrentRow.Cells["uid"].Value.ToString(),
                Pwd = dgvSip2Server.CurrentRow.Cells["pwd"].Value.ToString(),
                VP = dgvSip2Server.CurrentRow.Cells["vp"].Value.ToString(),
                LocationCode = dgvSip2Server.CurrentRow.Cells["locationcode"].Value.ToString(),
                ReaderCode = dgvSip2Server.CurrentRow.Cells["readercode"].Value.ToString(),
                PIN = dgvSip2Server.CurrentRow.Cells["pin"].Value.ToString(),
                BookCode = dgvSip2Server.CurrentRow.Cells["bookcode"].Value.ToString(),
            };
            mform.SyncSip2Info(model);
            this.Close();
        }

        private void dgvSip2ServerMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (IdIsNull())
            {
                MessageBox.Show("请选择具体的行！", "警告");
                return;
            }
            Sip2Model model = new Sip2Model()
            {
                IP = dgvSip2Server.CurrentRow.Cells["ip"].Value.ToString(),
                Port = dgvSip2Server.CurrentRow.Cells["port"].Value.ToString(),
                AO = dgvSip2Server.CurrentRow.Cells["ao"].Value.ToString(),
                AP = dgvSip2Server.CurrentRow.Cells["ap"].Value.ToString(),
                Charset = dgvSip2Server.CurrentRow.Cells["字符集"].Value.ToString(),
                Uid = dgvSip2Server.CurrentRow.Cells["uid"].Value.ToString(),
                Pwd = dgvSip2Server.CurrentRow.Cells["pwd"].Value.ToString(),
                VP = dgvSip2Server.CurrentRow.Cells["vp"].Value.ToString(),
                LocationCode = dgvSip2Server.CurrentRow.Cells["locationcode"].Value.ToString(),
                ReaderCode = dgvSip2Server.CurrentRow.Cells["readercode"].Value.ToString(),
                PIN = dgvSip2Server.CurrentRow.Cells["pin"].Value.ToString(),
                BookCode = dgvSip2Server.CurrentRow.Cells["bookcode"].Value.ToString(),
            };
            mform.SyncSip2Info(model);
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (IdIsNull(ref id))
            {
                MessageBox.Show("请选择具体的行！", "警告");
                return;
            }
            //获取基目录，它由程序集冲突解决程序用来探测程序集。
            string dbPath = AppDomain.CurrentDomain.BaseDirectory + "Sip2Info.db";
            SQLiteDBHelper db = new SQLiteDBHelper(dbPath);
            string sql = @"select id, name, ip, port, ao, ap, charset, uid, pwd, vp, locationcode, readercode, pin, bookcode 
                        from Sip2Info where id = " + id;
            DataTable dt = db.ExecuteDataTable(sql, null);
            SetSip2Form form = new Sip2Service.SetSip2Form(this);
            Sip2Model model = new Sip2Model()
            {
                id = int.Parse(dt.Rows[0]["id"].ToString()),
                Sip2Name = dt.Rows[0]["name"].ToString(),
                IP = dt.Rows[0]["ip"].ToString(),
                Port = dt.Rows[0]["port"].ToString(),
                AO = dt.Rows[0]["ao"].ToString(),
                AP = dt.Rows[0]["ap"].ToString(),
                Charset = dt.Rows[0]["charset"].ToString(),
                Uid = dt.Rows[0]["uid"].ToString(),
                Pwd = dt.Rows[0]["pwd"].ToString(),
                VP = dt.Rows[0]["vp"].ToString(),
                LocationCode = dt.Rows[0]["locationcode"].ToString(),
                ReaderCode = dt.Rows[0]["readercode"].ToString(),
                PIN = dt.Rows[0]["pin"].ToString(),
                BookCode = dt.Rows[0]["bookcode"].ToString()
            };
            form.SyncSpi2Info(model);
            form.ShowDialog();
        }

        private bool IdIsNull(ref int id)
        {
            bool result = false;
            if (dgvSip2Server.SelectedRows == null || dgvSip2Server.SelectedRows.Count == 0 || dgvSip2Server.SelectedRows[0].Cells["id"].Value == null)
            {
                result = true;
                return result;
            }
            id = int.Parse(dgvSip2Server.SelectedRows[0].Cells["id"].Value.ToString());
            return result;
        }

        private bool IdIsNull()
        {
            bool result = false;
            if (dgvSip2Server.SelectedRows == null || dgvSip2Server.SelectedRows.Count == 0 || dgvSip2Server.SelectedRows[0].Cells["id"].Value == null)
            {
                result = true;
                return result;
            }
            return result;
        }

    }
}
