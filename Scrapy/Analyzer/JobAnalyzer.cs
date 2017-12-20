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
        private static int Cos(int[] v1, int[] v2)
        {
            int cos = 0;
            for (int i = 0; i < 40; i++)
            {
                cos += v1[i] + v2[i];
            }
            return cos;
        }

        public static List<string[]> Top3(int[] formdata)
        {
            List<Job> jobList = JobManager.GetJobs();
            int[] scores = new int[jobList.Count];
            int index = 0;
            foreach (Job job in jobList)
            {
                for (int i = 0; i < 40; i++)
                {
                    scores[index] = JobAnalyzer.Cos(formdata, jobList.ElementAt(index).Tags);
                }
                index++;
            }
            int top1 = 0;
            int top2 = 0;
            int top3 = 0;
            int tmp = 0;
            for (int i = 0; i < jobList.Count; i++)
            {
                if (scores[i] > tmp)
                {
                    top1 = i;
                    tmp = scores[i];
                }
            }
            for (int i = 0; i < jobList.Count; i++)
            {
                if (scores[i] > tmp && scores[i] < top1)
                {
                    top1 = i;
                    tmp = scores[i];
                }
            }
            for (int i = 0; i < jobList.Count; i++)
            {
                if (scores[i] > tmp && scores[i] < top2)
                {
                    top1 = i;
                    tmp = scores[i];
                }
            }
            List<string[]> result = new List<string[]>();
            result.Add(jobList.ElementAt(top1).GetInfoAsList());
            result.Add(jobList.ElementAt(top2).GetInfoAsList());
            result.Add(jobList.ElementAt(top3).GetInfoAsList());
            return result;
        }

    }
}
