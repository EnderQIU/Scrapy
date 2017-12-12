using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapy.Events
{
    /// <summary>
    /// 爬虫启动事件
    /// </summary>
    public class OnStartEventArgs
    {
        public string Url { get; set; }// 爬虫URL地址

        public OnStartEventArgs(string url)
        {
            this.Url = url ;
        }
    }
}
