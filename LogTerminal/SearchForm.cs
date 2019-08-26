using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogTerminal
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            btnSearch.DoubleClick += BtnSearch_DoubleClick;
            dtpTimeBegin.Value = DateTime.Now.Subtract(TimeSpan.FromMinutes(15));
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
            var app = tbApp.Text.Trim();
            var keyword = tbKeyword.Text.Trim();

            return _logsInfos
                .Where(x => begin <= x.Time && x.Time <= end)
                .WhereIf(logLevel.IsNotNullOrWhiteSpace(), x => x.Level == logLevel)
                // ReSharper disable once AssignNullToNotNullAttribute
                .WhereIf(app.IsNotNullOrWhiteSpace(), x => x.App.Contains(app))
                // ReSharper disable once AssignNullToNotNullAttribute
                .WhereIf(keyword.IsNotNullOrWhiteSpace(), x => x.Message.Contains(keyword))
                .ToList();
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
            columns["Message"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
            dgvDisplayZone.DataSource = _pager.GetPagingItems(logs);
        }
    }

    public static class EnumerableExt
    {
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> source,bool condition,Predicate<T> predicate )
        {
            return condition ? source.Where(x => predicate(x)) : source;
        }
    }

    public static class StringExt
    {
        public static bool IsNotNullOrWhiteSpace(this string source)
        {
            return string.IsNullOrWhiteSpace(source)==false;
        }
        
    }
}
