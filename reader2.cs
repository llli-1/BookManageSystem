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
    public partial class reader2 : Form
    {
        public reader2()
        {
            InitializeComponent();
        }

        private void reader2_Load(object sender, EventArgs e)
        {
            Table();
        }
        //从数据库读取数据显示在表格控件中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中旧数据
            Dao dao = new Dao();
            string sql = "select * from book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//获取书号
            string bookname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取书名
            string kucun = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();//获取库存，即是否在馆
            string rentnum= dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            string sql1 = $"select * from rent where readerid='{logindata.UID}'and fakuan>0;";
            Dao dao1 = new Dao();
            IDataReader dc = dao1.read(sql1);
            if (dc.Read())
            {
                MessageBox.Show("未还清罚款！不可借书！");
            }
            else
            {
                if (kucun != "NULL")
                {
                    string sql = $"INSERT INTO rent VALUES('{logindata.UID}','{logindata.Uname}','{bookname}','{id}',CURRENT_DATE,DATE_ADD(CURRENT_DATE,INTERVAL '30' day),'0');UPDATE book SET kucun=kucun-1 WHERE bookid='{id}';UPDATE book SET rentnum=rentnum+1 WHERE bookid='{id}';";

                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 1)
                    {
                        //string now_time = DateTime.Now.ToString();//获取当前时间
                        string re_time = DateTime.Now.AddMonths(1).ToString();//在当前时间的基础上加一个月

                        MessageBox.Show($" {logindata.Uname}:\n已经成功借走 《{bookname}》\n你需要在日期{re_time}内归还!\n超时每日罚款0.5元（累积）");
                        // MessageBox.Show($"借出成功!");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("sql语句错误");
                    }
                }
            } 
        }
        //从数据库根据书号读取数据 显示在表格控件中
        public void TableID()
        {
            dataGridView1.Rows.Clear();//将控件中已经有的旧数据全部清空
            Dao dao = new Dao();
            string sql = $"SELECT * FROM book WHERE bookid='{textBox2.Text}';";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//当查询结果到达末尾后跳出while循环
            {
                //将读到的数据添加到dataGridView控件中
                //这里几个dc[]取决于你在页面的那里设置了几个属性
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        //根据书名查询-模糊查询
        public void TableName()
        {
            dataGridView1.Rows.Clear();//将控件中已经有的旧数据全部清空
            Dao dao = new Dao();
            string sql = $"SELECT * FROM book WHERE bookname LIKE '%{textBox1.Text}%';";//要执行的sql语句，建议从编译器上copy该语句再黏贴到此处
            IDataReader dc = dao.read(sql);
            while (dc.Read())//当查询结果到达末尾后跳出while循环
            {
                //将读到的数据添加到dataGridView控件中
                //这里几个dc[]取决于你在页面的那里设置了几个属性
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TableName();
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableID();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Table();
        }
    }
}
