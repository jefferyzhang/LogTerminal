using System;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void consolefortest_Click(object sender, EventArgs e)
        {
            ShowConsoleForm(Profile.Test);
        }

        private void consoleForPre_Click(object sender, EventArgs e)
        {
            ShowConsoleForm(Profile.Pre);
        }

        private void ShowConsoleForm(Profile profile)
        {
            var consoleForm = new ConsoleForm
            {
                Tag = profile,
                MdiParent = this
            };

            consoleForm.Show();
        }

        private void testforSearch_Click(object sender, EventArgs e)
        {
            ShowSearchForm(Profile.Test);
        }

        private void preforSearch_Click(object sender, EventArgs e)
        {
            ShowSearchForm(Profile.Pre);
        }

        private void ShowSearchForm(Profile profile)
        {
            var searchForm = new SearchForm()
            {
                Tag = profile,
                MdiParent = this
            };

            searchForm.Show();
        }
    }
}
