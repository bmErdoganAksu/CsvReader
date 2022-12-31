using CSVProject.Core;
using CSVProject.Models;
using Microsoft.VisualBasic;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CSVProject;

public partial class Form1 : Form
{
    private List<IssueModel> _dataSet = new();
    private List<IssueModel> _tempDataSet = new();
    private List<CheckModel> _resultList = new();
    private Task[] _tasks;
    private int _threshold = 1;
    public Form1()
    {
        Control.CheckForIllegalCrossThreadCalls = false;
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //lstView.Items.AddRange(typeof(IssueModel).GetProperties()
        //    .Select(s => new ListViewItem{Text = s.Name }).ToArray());
        //cmbList.DataSource = new List<string> { "Product", "Issue", "Company", "ZipCode", "State", "ComplaintId" };
        //lstView.Items.AddRange(new ListViewItem[] {
        //    new ListViewItem("Product"),
        //    new ListViewItem("Issue"),
        //    new ListViewItem("Company"),
        //    new ListViewItem("ZipCode"),
        //    new ListViewItem("State"),
        //    new ListViewItem("ComplaintId")
        //});

    }


    private async Task processData()
    {
        lstLog.Items.Clear();
        _resultList.Clear();
        dgvResult.DataSource = null;
        addLog("------------------------- App Started ----------------------------------");
        var timer = new Stopwatch();
        timer.Start();
        var data = _dataSet.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index % _tasks.Count())
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

        for (int i = 0; i < _tasks.Count(); i++)
        {
            var index = i;
            _tasks[index] = new Task(async () =>
            {
                var st = new Stopwatch();
                st.Start();
                await benzerlikIssue(data.ToArray()[index].ToList());
                st.Stop();
                addLog(Task.CurrentId + " -> Elapsed Time : " + st.ElapsedMilliseconds);

            });
        }


        foreach (var task in _tasks)
        {
            task.Start();
            addLog("Data Assigned To:" + task.Id.ToString());
        }


        await Task.WhenAll(_tasks);
        //await Run(data);
        addLog("------------------------- App Stopped -------------------------------------------");
        timer.Stop();
        addLog("Elapsed Time - " + timer.ElapsedMilliseconds.ToString() + " - Result Count: " + _resultList.Count);
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        await processData();
        dgvResult.DataSource = _resultList.ToList();
    }

    private void dosyaAÁToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();
        openFileDialog.Filter = "CSV Files (*.csv) | *.csv";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _dataSet = readFromCsv(openFileDialog.FileName);
            dgvCSV.DataSource = _dataSet;
        }
       
    }

    // METHODS
    private List<IssueModel> readFromCsv(string path)
    {
        CSVReader reader = new();
        var result = reader.ReadFromCSV(path, ",");
        return result;
    }




    private Task<CheckModel> checkSimilarity(string firstString, string lastString)
    {
        CheckModel checkModel = new CheckModel();
        checkModel.FirstString = firstString;
        checkModel.LastString = lastString;
        // If Same
        if (firstString == lastString)
        {
            checkModel.Similarity = 100;
            return Task.FromResult(checkModel);// Task.FromResult(checkModel);
        }

        var firstStringWords = firstString.Split(' ').ToList();
        var lastStringWords = lastString.Split(' ').ToList();
        int payda = 0;
        int pay = 0;
        if (firstStringWords.Count() > lastStringWords.Count())
            payda = firstStringWords.Count();
        else
            payda = lastStringWords.Count();

        foreach (var word in firstStringWords)
        {
            if (lastStringWords.Contains(word)) pay += 1;
        }
        checkModel.Similarity = Convert.ToDouble((double)pay / (double)payda) * 100;
        return Task.FromResult(checkModel);

    }

    private Task benzerlik(List<IssueModel> firstData)
    {

        foreach (var item in firstData)
        {
            foreach (var subItem in _dataSet)
            {
                if (item == subItem) continue;

                Monitor.Enter(_resultList);
                //var data = Task.Run(() => checkSimilarity(item.Product, subItem.Product).GetAwaiter().GetResult());
                //_resultList.Add(data.Result);

                _resultList.Add(checkSimilarity(item.Product, subItem.Product).GetAwaiter().GetResult());
                Monitor.Exit(_resultList);
                //Task.Delay(200).GetAwaiter().GetResult();
            }
        }
        return Task.CompletedTask;
    }

    private Task benzerlikIssue(List<IssueModel> firstData)
    {

        foreach (var item in firstData)
        {
            foreach (var subItem in _dataSet)
            {
                if (item == subItem) continue;

                Monitor.Enter(_resultList);
                //var data = Task.Run(() => checkSimilarity(item.Product, subItem.Product).GetAwaiter().GetResult());
                //_resultList.Add(data.Result);

                _resultList.Add(checkSimilarity(item.Issue, subItem.Issue).GetAwaiter().GetResult());
                Monitor.Exit(_resultList);
                //Task.Delay(200).GetAwaiter().GetResult();
            }
        }
        return Task.CompletedTask;
    }

    private void btnThreshold_Click(object sender, EventArgs e)
    {
        _threshold = Convert.ToInt16(txtThreshold.Text);
        _resultList = _resultList.Where(s => s.Similarity > _threshold).ToList();
        dgvResult.DataSource = _resultList;
        //for (int i = 0; i < dgvResult.RowCount; i++)
        //{
        //    if (Convert.ToInt16(dgvResult.Rows[i].Cells["Similarity"].Value) >= threshold)
        //        MessageBox.Show(dgvResult.Rows[i].Cells["Similarity"].Value.ToString());
        //    dgvResult.DataSource = dgvResult.Rows[i];

        //}

    }


    private void addLog(string log)
    {
        lstLog.Items.Add(DateTime.Now.TimeOfDay + " - " + log.ToString());
        //lblStatus.Text = log;
        this.Text = log;
        int visibleItems = lstLog.ClientSize.Height / lstLog.ItemHeight;
        lstLog.TopIndex = Math.Max(lstLog.Items.Count - visibleItems + 1, 0);
    }

    private void setThreadCount_Click(object sender, EventArgs e)
    {
        var threadCount = Convert.ToInt16(txtThreadCount.Text);
        _tasks = new Task[threadCount];
        addLog("Thread Count Set To " + threadCount.ToString());
    }

    private async void btnIssueSimilarity_Click(object sender, EventArgs e)
    {
        await processData();
        dgvResult.DataSource = _resultList.Where(s => s.Similarity >= _threshold)
            .Select(s => new
            {
                FirstString = s.FirstString,
                LastString = s.LastString,
                Similarity = s.Similarity,
                ComplaintId = _dataSet.Where(d => d.Product == s.FirstString)
            }).ToList();
    }

    private async void btnCheckComplaint_Click(object sender, EventArgs e)
    {
        string complaintId = Interaction.InputBox("Enter Complaint Id", "Input", null, 20, 20);
        if (complaintId.Trim() == "") return;
        var data = _dataSet.Where(s => s.ComplaintId == complaintId).First();
        await benzerlikIssue(new List<IssueModel> { data });
        dgvResult.DataSource = _resultList.Where(r => r.Similarity > _threshold).ToList();
    }


    private void txtThreshold_TextChanged(object sender, EventArgs e)
    {
        if (txtThreshold.Text.Trim() != "")
            _threshold = Convert.ToInt16(txtThreshold.Text);
        else _threshold = 0;
    }

    private void lstView_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
        //var items = lstView.CheckedItems;
        //var d = _dataSet.Where(s => items.Contains(new ListViewItem { Text = s.GetType().GetProperty("Product").Name }));
        //_dataSet.Where(s => s.Product == "Product" && s.Issue == "Issue");
    }
}
