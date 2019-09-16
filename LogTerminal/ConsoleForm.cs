using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class ConsoleForm : Form
    {
        private LogService _logService;

        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
            var profile = (Profile)Tag;

            SetTitle(profile);

            _logService = new LogService(profile);
            _logService.RemoveOldLogs();

            DisplayLogs();

            displayLogTimer.Start();


            cbApp.DataSource = ConfigurationManager.AppSettings["apps"].Split(',');
        }

        private void SetTitle(Profile profile)
        {
            this.Text += " for " + profile.ToString();
        }

        private void displayLogTimer_Tick(object sender, EventArgs e)
        {
            if (_logService.HasNewLog(_lastLog) == false)
            {
                Debug.WriteLine("no new log...");
                return;
            }

            DisplayLogs();
        }

        private void logLevelOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayLogs();
        }

        private LogInfo _lastLog = LogInfo.Empty;

        /// <summary>
        /// 显示日志
        /// </summary>
        private void DisplayLogs()
        {
            var logLevel = (string)logLevelOption.SelectedItem;
            var app = (string) cbApp.SelectedItem;

            var recentlyLogs = _logService.GetRecentlyLogs(logLevel,app);
            _lastLog = recentlyLogs.GetLastLog();

            var content = recentlyLogs.GetMessageForDisplay();

            consoleDisplay.Text = content;
            consoleDisplay.SelectionStart = content.Length;
            consoleDisplay.ScrollToCaret();
        }

        private void removeOldLogTimer_Tick(object sender, EventArgs e)
        {
            _logService.RemoveOldLogs();
        }

        private void cbApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayLogs();
        }
    }
}
