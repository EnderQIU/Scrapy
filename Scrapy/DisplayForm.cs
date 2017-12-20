using Scrapy.Models;
using Scrapy.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Scrapy
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            JobNum();
            LanguageRatio();
        }

        private void JobNum()
        {
            //string[] companies = { "百度", "阿里", "腾讯", "华为", "滴滴","三星","小米","爱奇艺","新浪"};
            //int[] num = { 23, 45, 61, 78, 45, 21, 44, 65, 57 };

            FileHandler fileHandler = new FileHandler();
            List<Job> jobs = new List<Job>(fileHandler.getJobs());
            List<string> companies = new List<string>();
            foreach(Job e in jobs)
            {
                companies.Add(e.CompanyName);
            }
            Dictionary<string,int> jcb = new Dictionary<string,int>();
            foreach(string e in companies)
            {
                if (!jcb.ContainsKey(e))
                {
                    jcb.Add(e, 1);
                }
                else
                {
                    jcb[e] += 1;
                }
            }

            /*HashSet<string>companies=new HashSet<>(jobs.company);
            *HashMap<string,int> map=new HashMap<>;
            * if(!map.containkey())
            * {
            * map.put("",1);
            * else
            * {
            *  map.get().setValue();
           */

            chart1.Series[0].Points.DataBindXY(jcb.Keys, jcb.Values);
            //chart1.Series[0].Points.DataBindXY(companies, num);

        }

        private void LanguageRatio()
        {
            //string[] languages = { "C", "C++", "C#", "Java", "Python" };
            //int[] num = { 23, 54, 12, 46, 34 };
            string[] languages = { "python", "java", "shell", "html", "css", "javascript", "php", "c", "c++", "go", "ruby", "swift" };
            int[] num = new int[languages.Length];
            for (int i=0;i<languages.Length;i++)
            {
              // num[i] = JobManager.GetJobs().ElementAt(i).
            }
            chart2.Series[0].Points.DataBindXY(languages, num);
        }

       
    }
}
