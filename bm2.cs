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
    public partial class bm2 : Form
    {
        public bm2()
        {
            InitializeComponent();
        }

        private void bm2_Load(object sender, EventArgs e)
        {
            Table();
        }
        //从数据库读取数据显示在表格控件中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中旧数据
            Dao dao = new Dao();
            string sql = $"select * from rent";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void Tablereader()
        {
            dataGridView1.Rows.Clear();//将控件中已经有的旧数据全部清空
            //string readerid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取读者id
            string sql = $"select * from rent where readerid='{textBox1.Text}'";
            Dao dao = new Dao();
            IDataReader dc = dao.read(sql);
            while (dc.Read())//当查询结果到达末尾后跳出while循环
            {
                //将读到的数据添加到dataGridView控件中
                //这里几个dc[]取决于你在页面的那里设置了几个属性
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tablereader();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //DataTable dt = (DataTable)dataGridView1.Rows[i].Cells[6].Value;
                DateTime t1 = DateTime.Now;
                DateTime dt1 = Convert.ToDateTime(t1.ToString());
                DateTime dt2 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString());
                if (DateTime.Compare(dt1, dt2) > 0)
                {
                    TimeSpan ts1 = new TimeSpan(dt1.Ticks);
                    TimeSpan ts2 = new TimeSpan(dt2.Ticks);
                    TimeSpan ts = ts1.Subtract(ts2).Duration();
                    dataGridView1.Rows[i].Cells[6].Value = 0.5 * ts.TotalDays;
                    string sql = $"update rent set fakuan='{dataGridView1.Rows[i].Cells[6].Value}'where readerid='{dataGridView1.Rows[i].Cells[0].Value.ToString()}'and bookname='{dataGridView1.Rows[i].Cells[2].Value.ToString()}'";
                    Dao dao = new Dao();
                    IDataReader dc = dao.read(sql);
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("更新成功！");
                    }
                }
                else
                {
                    dataGridView1.Rows[i].Cells[6].Value = 0;
                }
            }
        }
    }
}
