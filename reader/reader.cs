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
    public partial class reader : Form
    {
        public reader()
        {
            InitializeComponent();
        }

        private void 已借图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader3 r3=new reader3();
            r3.ShowDialog();
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader2 r2 = new reader2();
            r2.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reader4 r4 = new reader4();
            r4.ShowDialog();
        }
    }
}
