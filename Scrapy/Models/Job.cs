using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapy.Analyzer;

namespace Scrapy.Models
{
    class Job
    {
        public Job(string[] info)
        {
            this.JobName = info[0];
            this.Responsibility = info[1];
            this.Requirements = info[2];
            this.WorkPlace = info[3];
            this.CompanyName = info[4];
            this.Introduction = info[5];
            this.Uri = info[6];
            this.Tags = new int[Presets.keywords.Length];
        }

        public int[] Tags { get; set; }   // 岗位标签

        public int getTagsValue(int index)
        {
            return this.Tags[index];
        }

        public string JobName { get; set; }  // 岗位名称

        public string Responsibility { get; set; }  // 岗位职责

        public string Requirements { get; set; }  // 岗位要求

        public string WorkPlace { get; set; }  // 工作地

        public string CompanyName { get; set; }  // 公司名称

        public string Introduction { get; set; }  // 公司简介

        public string Uri { get; set; }  // 公司网址

        public string GetInfo()
        {
            return this.JobName + this.JobName + this.Responsibility + this.Requirements
                + this.WorkPlace + this.CompanyName + this.Introduction;
        }
    }
}
