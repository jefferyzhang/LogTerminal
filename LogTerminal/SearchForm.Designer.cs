namespace LogTerminal
{
    partial class SearchForm
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
            this.mainSplitor = new System.Windows.Forms.SplitContainer();
            this.topSplitor = new System.Windows.Forms.SplitContainer();
            this.searchOptionSplitor = new System.Windows.Forms.SplitContainer();
            this.gbSearchOptions = new System.Windows.Forms.GroupBox();
            this.tlpSearchOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lbTimeRange = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.logLevelOption = new System.Windows.Forms.ComboBox();
            this.lbApp = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.dtpTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.btnSearch = new LogTerminal.DoubleClickButton();
            this.contentSplitor = new System.Windows.Forms.SplitContainer();
            this.dgvDisplayZone = new System.Windows.Forms.DataGridView();
            this.rightSplitor = new System.Windows.Forms.SplitContainer();
            this.gbTotalCount = new System.Windows.Forms.GroupBox();
            this.lbPageIndex = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitor)).BeginInit();
            this.mainSplitor.Panel1.SuspendLayout();
            this.mainSplitor.Panel2.SuspendLayout();
            this.mainSplitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSplitor)).BeginInit();
            this.topSplitor.Panel1.SuspendLayout();
            this.topSplitor.Panel2.SuspendLayout();
            this.topSplitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchOptionSplitor)).BeginInit();
            this.searchOptionSplitor.Panel1.SuspendLayout();
            this.searchOptionSplitor.SuspendLayout();
            this.gbSearchOptions.SuspendLayout();
            this.tlpSearchOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitor)).BeginInit();
            this.contentSplitor.Panel1.SuspendLayout();
            this.contentSplitor.Panel2.SuspendLayout();
            this.contentSplitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitor)).BeginInit();
            this.rightSplitor.Panel1.SuspendLayout();
            this.rightSplitor.Panel2.SuspendLayout();
            this.rightSplitor.SuspendLayout();
            this.gbTotalCount.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitor
            // 
            this.mainSplitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitor.IsSplitterFixed = true;
            this.mainSplitor.Location = new System.Drawing.Point(0, 0);
            this.mainSplitor.Name = "mainSplitor";
            this.mainSplitor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitor.Panel1
            // 
            this.mainSplitor.Panel1.Controls.Add(this.topSplitor);
            // 
            // mainSplitor.Panel2
            // 
            this.mainSplitor.Panel2.Controls.Add(this.contentSplitor);
            this.mainSplitor.Size = new System.Drawing.Size(1184, 661);
            this.mainSplitor.SplitterDistance = 148;
            this.mainSplitor.TabIndex = 0;
            // 
            // topSplitor
            // 
            this.topSplitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSplitor.Location = new System.Drawing.Point(0, 0);
            this.topSplitor.Name = "topSplitor";
            // 
            // topSplitor.Panel1
            // 
            this.topSplitor.Panel1.Controls.Add(this.searchOptionSplitor);
            // 
            // topSplitor.Panel2
            // 
            this.topSplitor.Panel2.Controls.Add(this.btnSearch);
            this.topSplitor.Size = new System.Drawing.Size(1184, 148);
            this.topSplitor.SplitterDistance = 972;
            this.topSplitor.TabIndex = 0;
            // 
            // searchOptionSplitor
            // 
            this.searchOptionSplitor.IsSplitterFixed = true;
            this.searchOptionSplitor.Location = new System.Drawing.Point(0, 0);
            this.searchOptionSplitor.Name = "searchOptionSplitor";
            this.searchOptionSplitor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // searchOptionSplitor.Panel1
            // 
            this.searchOptionSplitor.Panel1.Controls.Add(this.gbSearchOptions);
            this.searchOptionSplitor.Size = new System.Drawing.Size(885, 145);
            this.searchOptionSplitor.SplitterDistance = 114;
            this.searchOptionSplitor.TabIndex = 0;
            // 
            // gbSearchOptions
            // 
            this.gbSearchOptions.Controls.Add(this.tlpSearchOptions);
            this.gbSearchOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchOptions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchOptions.Location = new System.Drawing.Point(0, 0);
            this.gbSearchOptions.Name = "gbSearchOptions";
            this.gbSearchOptions.Size = new System.Drawing.Size(885, 114);
            this.gbSearchOptions.TabIndex = 0;
            this.gbSearchOptions.TabStop = false;
            this.gbSearchOptions.Text = "Search Options";
            // 
            // tlpSearchOptions
            // 
            this.tlpSearchOptions.ColumnCount = 5;
            this.tlpSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.8827F));
            this.tlpSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.1173F));
            this.tlpSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tlpSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tlpSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tlpSearchOptions.Controls.Add(this.lbTimeRange, 2, 0);
            this.tlpSearchOptions.Controls.Add(this.lbLevel, 0, 0);
            this.tlpSearchOptions.Controls.Add(this.logLevelOption, 1, 0);
            this.tlpSearchOptions.Controls.Add(this.lbApp, 0, 1);
            this.tlpSearchOptions.Controls.Add(this.lbTo, 2, 1);
            this.tlpSearchOptions.Controls.Add(this.lbMessage, 0, 2);
            this.tlpSearchOptions.Controls.Add(this.tbKeyword, 1, 2);
            this.tlpSearchOptions.Controls.Add(this.dtpTimeBegin, 3, 0);
            this.tlpSearchOptions.Controls.Add(this.dtpTimeEnd, 3, 1);
            this.tlpSearchOptions.Controls.Add(this.tbApp, 1, 1);
            this.tlpSearchOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchOptions.Location = new System.Drawing.Point(3, 18);
            this.tlpSearchOptions.Name = "tlpSearchOptions";
            this.tlpSearchOptions.RowCount = 3;
            this.tlpSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSearchOptions.Size = new System.Drawing.Size(879, 93);
            this.tlpSearchOptions.TabIndex = 0;
            // 
            // lbTimeRange
            // 
            this.lbTimeRange.AutoSize = true;
            this.lbTimeRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTimeRange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRange.Location = new System.Drawing.Point(301, 0);
            this.lbTimeRange.Name = "lbTimeRange";
            this.lbTimeRange.Size = new System.Drawing.Size(136, 30);
            this.lbTimeRange.TabIndex = 6;
            this.lbTimeRange.Text = "From:";
            this.lbTimeRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLevel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.Location = new System.Drawing.Point(3, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(113, 30);
            this.lbLevel.TabIndex = 2;
            this.lbLevel.Text = "Level:";
            this.lbLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logLevelOption
            // 
            this.logLevelOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logLevelOption.DropDownHeight = 150;
            this.logLevelOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logLevelOption.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logLevelOption.FormattingEnabled = true;
            this.logLevelOption.IntegralHeight = false;
            this.logLevelOption.Items.AddRange(new object[] {
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR"});
            this.logLevelOption.Location = new System.Drawing.Point(122, 3);
            this.logLevelOption.Name = "logLevelOption";
            this.logLevelOption.Size = new System.Drawing.Size(173, 24);
            this.logLevelOption.TabIndex = 3;
            // 
            // lbApp
            // 
            this.lbApp.AutoSize = true;
            this.lbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApp.Location = new System.Drawing.Point(3, 30);
            this.lbApp.Name = "lbApp";
            this.lbApp.Size = new System.Drawing.Size(113, 30);
            this.lbApp.TabIndex = 4;
            this.lbApp.Text = "App:";
            this.lbApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(301, 30);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(136, 30);
            this.lbTo.TabIndex = 7;
            this.lbTo.Text = "To:";
            this.lbTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(3, 60);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(113, 33);
            this.lbMessage.TabIndex = 13;
            this.lbMessage.Text = "Message:";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbKeyword
            // 
            this.tlpSearchOptions.SetColumnSpan(this.tbKeyword, 2);
            this.tbKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKeyword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyword.Location = new System.Drawing.Point(122, 63);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(315, 26);
            this.tbKeyword.TabIndex = 11;
            // 
            // dtpTimeBegin
            // 
            this.dtpTimeBegin.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTimeBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeBegin.Location = new System.Drawing.Point(443, 3);
            this.dtpTimeBegin.Name = "dtpTimeBegin";
            this.dtpTimeBegin.Size = new System.Drawing.Size(206, 22);
            this.dtpTimeBegin.TabIndex = 10;
            // 
            // dtpTimeEnd
            // 
            this.dtpTimeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeEnd.CalendarFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeEnd.Location = new System.Drawing.Point(443, 33);
            this.dtpTimeEnd.Name = "dtpTimeEnd";
            this.dtpTimeEnd.Size = new System.Drawing.Size(206, 22);
            this.dtpTimeEnd.TabIndex = 9;
            // 
            // tbApp
            // 
            this.tbApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApp.Location = new System.Drawing.Point(122, 33);
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(173, 26);
            this.tbApp.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(208, 148);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // contentSplitor
            // 
            this.contentSplitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitor.Location = new System.Drawing.Point(0, 0);
            this.contentSplitor.Name = "contentSplitor";
            // 
            // contentSplitor.Panel1
            // 
            this.contentSplitor.Panel1.Controls.Add(this.dgvDisplayZone);
            // 
            // contentSplitor.Panel2
            // 
            this.contentSplitor.Panel2.Controls.Add(this.rightSplitor);
            this.contentSplitor.Size = new System.Drawing.Size(1184, 509);
            this.contentSplitor.SplitterDistance = 1050;
            this.contentSplitor.TabIndex = 0;
            // 
            // dgvDisplayZone
            // 
            this.dgvDisplayZone.AllowUserToAddRows = false;
            this.dgvDisplayZone.AllowUserToDeleteRows = false;
            this.dgvDisplayZone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplayZone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvDisplayZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisplayZone.Location = new System.Drawing.Point(0, 0);
            this.dgvDisplayZone.Name = "dgvDisplayZone";
            this.dgvDisplayZone.RowTemplate.Height = 23;
            this.dgvDisplayZone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisplayZone.Size = new System.Drawing.Size(1050, 509);
            this.dgvDisplayZone.TabIndex = 0;
            // 
            // rightSplitor
            // 
            this.rightSplitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSplitor.Location = new System.Drawing.Point(0, 0);
            this.rightSplitor.Name = "rightSplitor";
            this.rightSplitor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightSplitor.Panel1
            // 
            this.rightSplitor.Panel1.Controls.Add(this.gbTotalCount);
            // 
            // rightSplitor.Panel2
            // 
            this.rightSplitor.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.rightSplitor.Size = new System.Drawing.Size(130, 509);
            this.rightSplitor.SplitterDistance = 88;
            this.rightSplitor.TabIndex = 0;
            // 
            // gbTotalCount
            // 
            this.gbTotalCount.Controls.Add(this.lbPageIndex);
            this.gbTotalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalCount.Location = new System.Drawing.Point(0, 0);
            this.gbTotalCount.Name = "gbTotalCount";
            this.gbTotalCount.Size = new System.Drawing.Size(130, 88);
            this.gbTotalCount.TabIndex = 0;
            this.gbTotalCount.TabStop = false;
            this.gbTotalCount.Text = "Page Index";
            // 
            // lbPageIndex
            // 
            this.lbPageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPageIndex.AutoSize = true;
            this.lbPageIndex.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageIndex.Location = new System.Drawing.Point(29, 32);
            this.lbPageIndex.Name = "lbPageIndex";
            this.lbPageIndex.Size = new System.Drawing.Size(25, 28);
            this.lbPageIndex.TabIndex = 0;
            this.lbPageIndex.Text = "1";
            this.lbPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrePage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNextPage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPrePage
            // 
            this.btnPrePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrePage.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrePage.Location = new System.Drawing.Point(3, 3);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(124, 202);
            this.btnPrePage.TabIndex = 0;
            this.btnPrePage.Text = "<<<";
            this.btnPrePage.UseVisualStyleBackColor = true;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextPage.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(3, 211);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(124, 203);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = ">>>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainSplitor);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "SearchForm";
            this.Text = "SearchPanel";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.mainSplitor.Panel1.ResumeLayout(false);
            this.mainSplitor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitor)).EndInit();
            this.mainSplitor.ResumeLayout(false);
            this.topSplitor.Panel1.ResumeLayout(false);
            this.topSplitor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topSplitor)).EndInit();
            this.topSplitor.ResumeLayout(false);
            this.searchOptionSplitor.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchOptionSplitor)).EndInit();
            this.searchOptionSplitor.ResumeLayout(false);
            this.gbSearchOptions.ResumeLayout(false);
            this.tlpSearchOptions.ResumeLayout(false);
            this.tlpSearchOptions.PerformLayout();
            this.contentSplitor.Panel1.ResumeLayout(false);
            this.contentSplitor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitor)).EndInit();
            this.contentSplitor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayZone)).EndInit();
            this.rightSplitor.Panel1.ResumeLayout(false);
            this.rightSplitor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightSplitor)).EndInit();
            this.rightSplitor.ResumeLayout(false);
            this.gbTotalCount.ResumeLayout(false);
            this.gbTotalCount.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitor;
        private System.Windows.Forms.GroupBox gbSearchOptions;
        private System.Windows.Forms.DataGridView dgvDisplayZone;
        private System.Windows.Forms.SplitContainer topSplitor;
        private DoubleClickButton btnSearch;
        private System.Windows.Forms.SplitContainer contentSplitor;
        private System.Windows.Forms.SplitContainer rightSplitor;
        private System.Windows.Forms.GroupBox gbTotalCount;
        private System.Windows.Forms.Label lbPageIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ComboBox logLevelOption;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.TableLayoutPanel tlpSearchOptions;
        private System.Windows.Forms.Label lbTimeRange;
        private System.Windows.Forms.DateTimePicker dtpTimeEnd;
        private System.Windows.Forms.DateTimePicker dtpTimeBegin;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label lbApp;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbApp;
        private System.Windows.Forms.SplitContainer searchOptionSplitor;
    }
}