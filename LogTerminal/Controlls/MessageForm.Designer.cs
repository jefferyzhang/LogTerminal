namespace LogTerminal
{
    partial class MessageForm
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
            this.consoleDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // consoleDisplay
            // 
            this.consoleDisplay.BackColor = System.Drawing.Color.Black;
            this.consoleDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleDisplay.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDisplay.ForeColor = System.Drawing.Color.Lime;
            this.consoleDisplay.Location = new System.Drawing.Point(0, 0);
            this.consoleDisplay.Name = "consoleDisplay";
            this.consoleDisplay.Size = new System.Drawing.Size(992, 810);
            this.consoleDisplay.TabIndex = 1;
            this.consoleDisplay.Text = "";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 810);
            this.Controls.Add(this.consoleDisplay);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox consoleDisplay;
    }
}