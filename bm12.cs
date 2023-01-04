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
    public partial class bm12 : Form
    {
        string ID = "";
        public bm12()
        {
            InitializeComponent();
        }
        public bm12(string recordid,string bookname,string author,string chubanshe,string bookid,string classid )
        {
            InitializeComponent();
            ID=textBox1.Text = recordid;
            textBox2.Text = bookname;
            textBox3.Text = author;
            textBox4.Text = chubanshe;
            textBox5.Text = bookid;
            textBox7.Text = classid;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE book SET bookname='{textBox2.Text}',author='{textBox3.Text}',chubanshe='{textBox4.Text}',bookid='{textBox5.Text}',classid='{textBox7.Text}' WHERE recordid='{ID}';";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Alter successfully");
                this.Close();
            }
        }
    }
}
