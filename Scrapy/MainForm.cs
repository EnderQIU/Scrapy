using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrapy.utils;
using System.Diagnostics;

namespace Scrapy
{
    public partial class MainForm : Form
    {
        private int mission_id;
        private void GenerateMissionId()
        {
            Random rd = new Random();
            mission_id = rd.Next();
        }
        public int GetMissionId()
        {
            return mission_id;
        }
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Logger.GetLogger(this);
        }

        public void Log(String log)
        {
            ConsoleTextBox.AppendText(log + "\r\n");
            ConsoleTextBox.SelectionStart = ConsoleTextBox.Text.Length;
            ConsoleTextBox.ScrollToCaret();
        }
        public void SetProgressBarMax(int a)
        {
            MainProgressBar.Maximum = a;
        }
        public void AddOneToProgressBar()
        {
            MainProgressBar.Value += 1;
        }
        public void ClearProgressBar()
        {
            MainProgressBar.Value = 0;
        }
        public void DisableAllButtons()
        {
            StartButton.Enabled = false;
            SearchButton.Enabled = false;
            ClearButton.Enabled = false;
            DeleteButton.Enabled = false;
            LoadButton.Enabled = false;
        }
        public void EnableAllButtons()
        {
            StartButton.Enabled = true;
            SearchButton.Enabled = true;
            ClearButton.Enabled = true;
            DeleteButton.Enabled = true;
            LoadButton.Enabled = true;
        }
        // 开始爬取
        private void StartSpyder(object sender, EventArgs e)
        {
            GenerateMissionId();
            Log("本任务的Id是" + mission_id.ToString());
            DBConnector.Excute("create table `" + mission_id.ToString() + "` (JobName longtext,Responsibility longtext,Requirements longtext,WorkPlace longtext,CompanyName longtext,Introduction longtext,Uri longtext)");
            DisableAllButtons();
            int threadNum = int.Parse(TreadNum.SelectedItem.ToString());  // 获取线程数量
            Log("设置的线程数为：" + threadNum.ToString());
            ScrapyManager scrapyManager = new ScrapyManager(threadNum);
            scrapyManager.Start();
            ClearProgressBar();
        }

        private void DropDownOpened(object sender, EventArgs e)
        {
            List<string> TableNames = new List<string>();
            TableNames = DBConnector.ShowTables();
            SaveSelector.Items.Clear();
            string[] list = TableNames.ToArray<string>();
            for (int i = 0; i < list.Length; i++)
            {
                SaveSelector.Items.Add(list[i]);
            }
        }

        private void LoadButtonClicked(object sender, EventArgs e)
        {
            string tablename = SaveSelector.SelectedItem.ToString();
            List<string[]> data = DBConnector.SelectAllFromTable(tablename);
            int rows = data.Count;
            int cols = 7;
            // 清空原有数据
            DataTable dt = (DataTable)ResultDataGridView.DataSource;
            if (dt!=null)
            {
                dt.Rows.Clear();
                ResultDataGridView.DataSource = dt;
            }
            // 写入新数据
            for (int i = 0; i < rows; i++)
            {
                int index = ResultDataGridView.Rows.Add();
                for(int j = 0; j < cols; j++)
                {
                    ResultDataGridView.Rows[i].Cells[j].Value = data.ElementAt(i)[j];
                }
            }
        }

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            string tablename = SaveSelector.SelectedItem.ToString();
            DBConnector.DropTable(tablename);
            SaveSelector.SelectedItem = "";
        }

        private void SearchButtonClicked(object sender, EventArgs e)
        {
            string filter = SearchFilter.Text;
            string keyword = SearchText.Text;
            string tablename = SaveSelector.SelectedItem.ToString();
            List<string[]> data = DBConnector.Select(tablename, filter, keyword);
            int rows = data.Count;
            int cols = 7;
            // 清空原有数据
            DataTable dt = (DataTable)ResultDataGridView.DataSource;
            if (dt != null)
            {
                dt.Rows.Clear();
                ResultDataGridView.DataSource = dt;
            }
            // 写入新数据
            for (int i = 0; i < rows; i++)
            {
                int index = ResultDataGridView.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    ResultDataGridView.Rows[i].Cells[j].Value = data.ElementAt(i)[j];
                }
            }
        }
    }
}
