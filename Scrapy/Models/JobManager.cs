using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapy.utils;

namespace Scrapy.Models
{
    class JobManager
    {
        private static List<Job> JobList = new List<Job>();

        public static void AddJob(string[] info)
        {
            if (info.Length != 7)
            {
                return;
            }
            JobList.Add(new Job(info));
            string values = "(";
            for (int i = 0; i < 6; i++)
            {
                values += ("\"" + info[i] + "\", ");
            }
            values += ("\"" + info[6] + "\")");
            DBConnector.Excute("insert into `" + Logger.GetMissionId().ToString() + "` (JobName,Responsibility,Requirements,WorkPlace,CompanyName,Introduction,Uri) values" + values);
        }
    }
}