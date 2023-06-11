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
    public partial class sm11 : Form
    {
        public sm11()
        {
            InitializeComponent();
            Table();
        }
             private void sm11_Load(object sender, EventArgs e)
            {
               
            }
            public void Table()
            {
                dataGridView1.Rows.Clear();//清空控件中旧数据
                Dao dao = new Dao();
                string sql = "select * from readerset";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {

                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
                }
                dc.Close();
                dao.DaoClose();
            }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                int ablenum = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                int ableday = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                string firstpsw = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string sql = $"insert into book values('{textBox1.Text}', '{textBox2.Text}', " +
                    $"'{textBox3.Text}', '{firstpsw}',{ablenum},{ableday},'0')";
                Dao dao = new Dao();
                int n = dao.Execute(sql);//执行这条sql语句
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
               
             
            }
            else
            {
                MessageBox.Show("输入不能为空！");
            }
        }

       
    }
}
