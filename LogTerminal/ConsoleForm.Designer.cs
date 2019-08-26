namespace LogTerminal
{
    partial class ConsoleForm
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
            this.components = new System.ComponentModel.Container();
            this.consoleContainer = new System.Windows.Forms.SplitContainer();
            this.consoleDisplay = new System.Windows.Forms.RichTextBox();
            this.optionContainer = new System.Windows.Forms.GroupBox();
            this.logLevelOption = new System.Windows.Forms.ComboBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.displayLogTimer = new System.Windows.Forms.Timer(this.components);
            this.removeOldLogTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.consoleContainer)).BeginInit();
            this.consoleContainer.Panel1.SuspendLayout();
            this.consoleContainer.Panel2.SuspendLayout();
            this.consoleContainer.SuspendLayout();
            this.optionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleContainer
            // 
            this.consoleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleContainer.Location = new System.Drawing.Point(0, 0);
            this.consoleContainer.Name = "consoleContainer";
            // 
            // consoleContainer.Panel1
            // 
            this.consoleContainer.Panel1.Controls.Add(this.consoleDisplay);
            // 
            // consoleContainer.Panel2
            // 
            this.consoleContainer.Panel2.Controls.Add(this.optionContainer);
            this.consoleContainer.Size = new System.Drawing.Size(1184, 661);
            this.consoleContainer.SplitterDistance = 927;
            this.consoleContainer.TabIndex = 0;
            // 
            // consoleDisplay
            // 
            this.consoleDisplay.BackColor = System.Drawing.Color.Black;
            this.consoleDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleDisplay.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDisplay.ForeColor = System.Drawing.Color.Lime;
            this.consoleDisplay.Location = new System.Drawing.Point(0, 0);
            this.consoleDisplay.Name = "consoleDisplay";
            this.consoleDisplay.Size = new System.Drawing.Size(927, 661);
            this.consoleDisplay.TabIndex = 0;
            this.consoleDisplay.Text = "";
            // 
            // optionContainer
            // 
            this.optionContainer.Controls.Add(this.logLevelOption);
            this.optionContainer.Controls.Add(this.lbLevel);
            this.optionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionContainer.Location = new System.Drawing.Point(0, 0);
            this.optionContainer.Name = "optionContainer";
            this.optionContainer.Size = new System.Drawing.Size(253, 661);
            this.optionContainer.TabIndex = 0;
            this.optionContainer.TabStop = false;
            this.optionContainer.Text = "Options";
            // 
            // logLevelOption
            // 
            this.logLevelOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.logLevelOption.FormattingEnabled = true;
            this.logLevelOption.Items.AddRange(new object[] {
            "DEBUG",
            "INFO",
            "WARN",
            "ERROR"});
            this.logLevelOption.Location = new System.Drawing.Point(82, 36);
            this.logLevelOption.Name = "logLevelOption";
            this.logLevelOption.Size = new System.Drawing.Size(121, 20);
            this.logLevelOption.TabIndex = 1;
            this.logLevelOption.SelectedIndexChanged += new System.EventHandler(this.logLevelOption_SelectedIndexChanged);
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(26, 39);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(41, 12);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "Level:";
            // 
            // displayLogTimer
            // 
            this.displayLogTimer.Interval = 1000;
            this.displayLogTimer.Tick += new System.EventHandler(this.displayLogTimer_Tick);
            // 
            // removeOldLogTimer
            // 
            this.removeOldLogTimer.Interval = 600000;
            this.removeOldLogTimer.Tick += new System.EventHandler(this.removeOldLogTimer_Tick);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.consoleContainer);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "ConsoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Console";
            this.Load += new System.EventHandler(this.ConsoleForm_Load);
            this.consoleContainer.Panel1.ResumeLayout(false);
            this.consoleContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.consoleContainer)).EndInit();
            this.consoleContainer.ResumeLayout(false);
            this.optionContainer.ResumeLayout(false);
            this.optionContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer consoleContainer;
        private System.Windows.Forms.RichTextBox consoleDisplay;
        private System.Windows.Forms.GroupBox optionContainer;
        private System.Windows.Forms.ComboBox logLevelOption;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Timer displayLogTimer;
        private System.Windows.Forms.Timer removeOldLogTimer;
    }
}