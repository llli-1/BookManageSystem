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
    public partial class bm11 : Form
    {
        public bm11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!=""&& textBox3.Text!=""&& textBox4.Text != ""&&textBox5.Text != ""&&textBox6.Text != "")
            {

                Dao dao = new Dao();
                //GlobalData.SQL_Str sql1 = "select classi from readerset where bookidhead='{textBox6.Text}'";
                //string classi=dao.read(sql1);
                string classi;
                string sql = $"insert into book values(NULL, '{textBox2.Text}', " +
                    $"'{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}','{textBox7.Text}','0')";
                int n = dao.Execute(sql);//执行这条sql语句
                if (n > 0)
                {

                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            else
            {
                MessageBox.Show("输入不能为空！");
            }
        }
    }
}
