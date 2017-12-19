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

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            string tablename = SaveSelector.SelectedItem.ToString();
            DBConnector.DropTable(tablename);
            SaveSelector.SelectedItem = "";
        }

    }
}
