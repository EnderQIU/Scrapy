using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapy.utils;
using System.Diagnostics;

namespace Scrapy
{
    class ScrapyManager
    {
        private int threadNum;

        public ScrapyManager(int threadNum)
        {
            this.threadNum = threadNum;
        }

        public void Start()
        {
            var watch = new Stopwatch();
            watch.Start();
            // 获取所有job id
            var addresses = new string[13] { "北京", "上海", "杭州", "成都", "深圳", "西安", "苏州", "广州", "南京", "青岛", "大连", "武汉", "百度" };
            List<String> urls = BuildUrls.Build(addresses);
            var scrapyThread = new ScrapyThreadImpl();
            scrapyThread.OnStart += (s, e) =>
            {
                Logger.Log("开始抓取：" + e.Url.ToString());
            };
            scrapyThread.OnError += (s, e) =>
            {
                Logger.Log("抓取错误：" + e.Url.ToString() + "，异常消息：" + e.Exception.Message);
                Logger.AddOne();
            };
            scrapyThread.OnCompleted += (s, e) =>
            {
                Logger.Log("爬虫抓取任务完成！"+"\r\n"+"耗时：" + e.Milliseconds + "毫秒"+"\r\n"+ "线程：" + e.ThreadId+"\r\n"+ "地址：" + e.Url.ToString());
                Logger.AddOne();
            };
            int url_num = urls.ToArray().Length;
            Logger.Log("开始爬取，共获取到"+url_num.ToString()+"个目标");
            Logger.SetProgressMax(url_num);
            Parallel.For(0, threadNum, (i) =>  // 开始并行任务
            {
                int len = url_num / threadNum;
                for (int m = i*len; m < (i+1)*len; m++)
                {
                    scrapyThread.Start(urls.ElementAt(m));
                }
            });
            watch.Stop();
            var ms = watch.ElapsedMilliseconds;
            Logger.Log("爬取URL完成，用时" + ms.ToString() + "毫秒");
            Logger.EnableAllButtons();
        }
    }
}
