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
    public partial class reader3 : Form
    {
        public reader3()
        {
            InitializeComponent();
        }
        
        //从数据库读取数据显示在表格控件中
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空控件中旧数据
            Dao dao = new Dao();
            string sql = $"select * from rent where readerid='{logindata.UID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString(), dc[5].ToString(), dc[6].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void reader3_Load(object sender, EventArgs e)
        {
            Table();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string bookid = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//获取书号
            float fakuan=float.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            Dao dao = new Dao();
            //string rentnum = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//获取书号                                                                                  
            if (fakuan > 0)
            {
                string sql = $"DELETE FROM rent WHERE bookid= '{bookid}';UPDATE book SET kucun=kucun+1 WHERE bookid='{bookid}';UPDATE book SET rentnum=rentnum-1 WHERE bookid='{bookid}';";//用图书ID 更新borrow、book.status表
                DialogResult dr = MessageBox.Show("请交罚款！", "交钱弹窗", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (dr == DialogResult.Yes)
                {
                    if (dao.Execute(sql) > 1)
                    {
                        MessageBox.Show("还书成功！");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("还书失败");
                    }
                } 
                else
                {
                    MessageBox.Show("还书失败");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table();
        }
    }
}
