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
    public partial class bookmanager : Form
    {
        public bookmanager()
        {
            InitializeComponent();
        }

        private void 查询图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm1 bm1obj=new bm1();
            bm1obj.ShowDialog();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm1 bm1obj = new bm1();
            bm1obj.ShowDialog();
        }

        private void 读者借阅信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm2 bm2obj = new bm2();
            bm2obj.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bm3 bm3obj = new bm3();
            bm3obj.ShowDialog();
        }
    }
}
