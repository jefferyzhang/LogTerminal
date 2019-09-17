using System;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }

        public MessageForm WithContent(string content)
        {
            consoleDisplay.Text = content;
            return this;
        }
    }
}
