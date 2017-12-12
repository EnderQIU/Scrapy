using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Scrapy.utils
{
    class HtmlParser
    {
        public static string[] Parse(string pagesource)
        {
            string[] job_info = new string[7];
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(pagesource.Replace("<!DOCTYPE html>", "<html>"));
            job_info[0] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/h2").InnerText;
            job_info[1] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/dl[1]").InnerText;
            job_info[2] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div/dl[2]").InnerText;
            job_info[3] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/p[3]").InnerText;
            job_info[4] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[3]/div[1]/div[1]/a/h3").InnerText;
            job_info[5] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[2]/p[1]").InnerText;
            job_info[6] = htmlDoc.DocumentNode.SelectSingleNode("//html[1]/body[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[2]/p[2]/a").InnerText;
            for(int i = 0; i < 7; i++)
            {
                if (job_info[i] == null)
                {
                    job_info[i] = "";
                }
            }
            return job_info;
        }
    }
}
