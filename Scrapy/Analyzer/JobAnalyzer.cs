using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Scrapy.Models;

namespace Scrapy.Analyzer
{
    class JobAnalyzer
    {
        private static void Analyze(Job job)
        {
            string info = job.GetInfo();
            for(int i = 0; i < Presets.keywords.Length; i++)
            {
                string str2 = info.ToLower();
                string str1 = Presets.keywords[i];
                Regex RegexWords = new Regex(str2);
                int WordCount = RegexWords.Matches(str1).Count;
                job.Tags[i] = WordCount;
            }
        }
        public void AnalyzeJobs()
        {
            List<Job> jobList = JobManager.GetJobs();
            foreach(Job job in jobList)
            {
                Analyze(job);
            }
        }
    }
}
