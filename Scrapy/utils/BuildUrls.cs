using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scrapy.utils
{
    class BuildUrls
    {
        public static List<String> Build(string[] addrs)
        {
            string host = "https://www.nowcoder.com/recommend-intern/list?";
            List<String> urls = new List<string>();
            List<string> jobids = new List<string>();
            List<string> companyids = new List<string>();
            foreach(string addr in addrs)
            {
                var request = (HttpWebRequest)WebRequest.Create(host+"page=1&"+"address="+addr);
                var response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string input = reader.ReadToEnd();
                string pattern = "\"totalPage\":\\d+,";  // 获取页数
                string matche = Regex.Match(input, pattern).Value;
                pattern = "\\d+";
                int pages = int.Parse(Regex.Match(matche, pattern).Value);
                for (int i = 1; i <= pages; i++)
                {
                    string url = host + "page=" + i.ToString() + "&address=" + addr;
                    request = (HttpWebRequest)WebRequest.Create(url);
                    response = (HttpWebResponse)request.GetResponse();
                    reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    input = reader.ReadToEnd();
                    pattern = @"\[(.*?)\]";
                    string matches = Regex.Match(input, pattern).Value;
                    JArray jArray = (JArray)JsonConvert.DeserializeObject(matches);
                    foreach (JObject jobj in jArray)
                    {
                        jobids.Add(jobj["id"].ToString());
                        companyids.Add(jobj["internCompanyId"].ToString());
                    }
                }
            }
            for (int i=0;i<jobids.ToArray().Length;i++)
            {
                urls.Add("https://www.nowcoder.com/recommend-intern/" + companyids.ElementAt(i) + "?jobId=" + jobids.ElementAt(i));
            }
            return urls;
        }
    }
}
