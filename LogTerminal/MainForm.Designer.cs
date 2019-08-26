namespace LogTerminal
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consoleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consolefortest = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleForPre = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testforSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.preforSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consoleMenu,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuContainer";
            // 
            // consoleMenu
            // 
            this.consoleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consolefortest,
            this.consoleForPre});
            this.consoleMenu.Name = "consoleMenu";
            this.consoleMenu.Size = new System.Drawing.Size(67, 21);
            this.consoleMenu.Text = "Console";
            // 
            // consolefortest
            // 
            this.consolefortest.Name = "consolefortest";
            this.consolefortest.Size = new System.Drawing.Size(100, 22);
            this.consolefortest.Text = "Test";
            this.consolefortest.Click += new System.EventHandler(this.consolefortest_Click);
            // 
            // consoleForPre
            // 
            this.consoleForPre.Name = "consoleForPre";
            this.consoleForPre.Size = new System.Drawing.Size(100, 22);
            this.consoleForPre.Text = "Pre";
            this.consoleForPre.Click += new System.EventHandler(this.consoleForPre_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testforSearch,
            this.preforSearch});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.searchToolStripMenuItem.Text = "SearchPanel";
            // 
            // testforSearch
            // 
            this.testforSearch.Name = "testforSearch";
            this.testforSearch.Size = new System.Drawing.Size(100, 22);
            this.testforSearch.Text = "Test";
            this.testforSearch.Click += new System.EventHandler(this.testforSearch_Click);
            // 
            // preforSearch
            // 
            this.preforSearch.Name = "preforSearch";
            this.preforSearch.Size = new System.Drawing.Size(100, 22);
            this.preforSearch.Text = "Pre";
            this.preforSearch.Click += new System.EventHandler(this.preforSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LogTerminal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consoleMenu;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consolefortest;
        private System.Windows.Forms.ToolStripMenuItem consoleForPre;
        private System.Windows.Forms.ToolStripMenuItem testforSearch;
        private System.Windows.Forms.ToolStripMenuItem preforSearch;
    }
}

