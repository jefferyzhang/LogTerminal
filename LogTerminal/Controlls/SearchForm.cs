using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            btnSearch.DoubleClick += BtnSearch_DoubleClick;
            dtpTimeBegin.Value = DateTime.Now.AddHours(-1);
            dtpTimeEnd.Value = DateTime.Now.AddMinutes(15);
            cbApp.DataSource = ConfigurationManager.AppSettings["apps"].Split(',');
            _pager.PageSize = int.Parse(ConfigurationManager.AppSettings["page.size"]);
        }

        private IList<LogGroup> _logsInfos=new List<LogGroup>();
        private readonly Pager _pager = new Pager();
        private LogService _logService;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var logs = FilterLogs();

            DisplayLogs(logs);
        }

        private IList<LogGroup> FilterLogs()
        {
            var begin = dtpTimeBegin.Value;
            var end = dtpTimeEnd.Value;
            var logLevel = (string) logLevelOption.SelectedItem;
            var app = cbApp.Text.Trim();
            var keyword = tbKeyword.Text.Trim();

            return _logService.FilterLogs(_logsInfos, begin, end, logLevel, app, keyword);
        }

        private void BtnSearch_DoubleClick(object sender, EventArgs e)
        {
            LoadAllLogs();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var profile = (Profile)Tag;

            SetTitle(profile);

            _logService = new LogService(profile);

            LoadAllLogs();

            SetColumnWeight();
        }

        private void SetColumnWeight()
        {
            var columns = dgvDisplayZone.Columns;

            columns["Time"].FillWeight = 20;
            columns["App"].FillWeight = 20;
            columns["Level"].FillWeight = 10;
            columns["MessageWithStackTrace"].Visible = false;

            var btn = new DataGridViewButtonColumn
            {
                Name = "btnMore",
                HeaderText = "",
                DefaultCellStyle = {NullValue = "More"},
                FillWeight = 20
            };

            columns.Add(btn); 
        }

        private void SetTitle(Profile profile)
        {
            this.Text += " for " + profile.ToString();
        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            _pager.PrePage();
            Search();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _pager.NextPage();
            Search();
        }
        private void LoadAllLogs()
        {
            _logsInfos = _logService.GetAllLogs();
            _pager.Reset(_logsInfos.Count);

            Search();
        }
        private void DisplayLogs(IList<LogGroup> logs)
        {
            lbPageIndex.Text = _pager.PageIndex.ToString();
            dgvDisplayZone.DataSource = _pager.GetPagedItems(logs);
          
        }

        //显示包含堆栈信息的消息
        private void dgvDisplayZone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayZone.Columns[e.ColumnIndex].Name == "btnMore" && e.RowIndex >= 0)
            {
                if (dgvDisplayZone.CurrentRow != null)
                {
                    var messageWithStackTrace = Convert.ToString(dgvDisplayZone.CurrentRow.Cells[4].Value);

                    new MessageForm()
                        .WithContent(messageWithStackTrace)
                        .Show();
                }
            }
        }
    }
}
