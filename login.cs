using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookmaster
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=""&& textBox2.Text != "")
            {
                Logincheck();
            }
            else
            {
                MessageBox.Show("输入信息（账号和密码都不能为空!");
            }
        }
        public void Logincheck()
        {
            //用户
            if (radioButton1.Checked == true)
            {
                Dao dao= new Dao();
                // string sql = "select * from reader where readerid ='" + textBox1.Text + "'and readerpsw='" + textBox2.Text + "'";
                string sql = $"select * from reader where readerid ='{textBox1.Text}' and readerpsw='{textBox2.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc=dao.read(sql);
                if(dc.Read())//读取一行数据，从第一行开始连的
                {
                    logindata.UID=dc["readerid"].ToString();
                    logindata.Uname = dc["readername"].ToString();

                    MessageBox.Show("登录成功");
                    reader r=new reader();//实例化窗体的对象
                    this.Hide();//把原来login的窗体隐藏了
                    r.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();
            }
            //图书管理员
             if(radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from bookmanager where bookmanagerid ='{textBox1.Text}' and bookmanagerpsw='{textBox2.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
                if (dc.Read())//读取一行数据，从第一行开始连的
                {
                    MessageBox.Show("登录成功");
                    bookmanager bm=new bookmanager();
                    this.Hide();
                    bm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
                dao.DaoClose();
            }
            //系统管理员
             if(radioButton2.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select * from sysmanager where sysid ='{textBox1.Text}' and syspsw='{textBox2.Text}'";
                //MessageBox.Show(sql);
                IDataReader dc = dao.read(sql);
                if (dc.Read())//读取一行数据，从第一行开始连的
                {
                    MessageBox.Show("登录成功");
                    sysmanager sm=new sysmanager();
                    this.Hide();
                    sm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败");
                    
                }
                dao.DaoClose();
            }
 
        }
    }
}
