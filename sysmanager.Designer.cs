namespace bookmaster
{
    partial class sysmanager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理读者信息页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理图书管理员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理图书分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理读者信息页面ToolStripMenuItem,
            this.管理图书管理员信息ToolStripMenuItem,
            this.管理图书分类ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理读者信息页面ToolStripMenuItem
            // 
            this.管理读者信息页面ToolStripMenuItem.Name = "管理读者信息页面ToolStripMenuItem";
            this.管理读者信息页面ToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.管理读者信息页面ToolStripMenuItem.Text = "管理读者信息页面";
            // 
            // 管理图书管理员信息ToolStripMenuItem
            // 
            this.管理图书管理员信息ToolStripMenuItem.Name = "管理图书管理员信息ToolStripMenuItem";
            this.管理图书管理员信息ToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.管理图书管理员信息ToolStripMenuItem.Text = "管理图书管理员信息";
            // 
            // 管理图书分类ToolStripMenuItem
            // 
            this.管理图书分类ToolStripMenuItem.Name = "管理图书分类ToolStripMenuItem";
            this.管理图书分类ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.管理图书分类ToolStripMenuItem.Text = "管理图书分类";
            // 
            // sysmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 505);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sysmanager";
            this.Text = "系统管理者页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理读者信息页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理图书管理员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理图书分类ToolStripMenuItem;
    }
}