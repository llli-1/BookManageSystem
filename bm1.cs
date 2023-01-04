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
    public partial class bm1 : Form
    {
        public bm1()
        {
            InitializeComponent();
            Table();
           
        }
        private void bm1_Load(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bm11 b = new bm11();
            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try//防止索引超出范围，这里就用try...catch
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取记录号/选中行数的第0行的 第0个单元格 它的值转换成字符串
                label2.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//显示正在选中的书号+书名
                DialogResult dr = MessageBox.Show("确定删除？", "消息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"DELETE FROM book WHERE recordid= '{id}';";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("请先在表格选中要删除的图书记录", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //从数据库读取数据显示在表格控件中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中旧数据
            Dao dao= new Dao();
            string sql= "select * from book";
            IDataReader dc =dao.read(sql);
            while (dc.Read())
            {

                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string recordid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string bookname= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string chubanshe= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string bookid= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string classid= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                bm12 b11 = new bm12(recordid,bookname,author,chubanshe,bookid,classid);
                b11.ShowDialog();
                Table();//刷新数据
            }
            catch
            {
                MessageBox.Show("Error");
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
        private void 根据书名查询(object sender, EventArgs e)
        {
            textBox1.Text = "";
            TableName();
        }

        //根据书号查询
        private void button6_Click(object sender, EventArgs e)
        {
            TableID();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Table();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
