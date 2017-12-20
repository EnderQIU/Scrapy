using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrapy.Analyzer;

namespace Scrapy
{
    public partial class resultForm : Form
    {
        public resultForm()
        {
            InitializeComponent();
            List<string[]> top3 = JobAnalyzer.Top3(MyForm.getVector());
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 7; j++) {
                    ResultDataGridView.Rows[i].Cells[j].Value = top3.ElementAt(i).ElementAt(j);
                }
            }
            
        }

        private void ResultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
