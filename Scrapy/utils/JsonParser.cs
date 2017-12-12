using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapy.Models;
using Newtonsoft.Json;

namespace Scrapy.utils
{
    class JsonParser
    {
        public static int getJobId(string raw)
        {
            JsonJob jsonJob = JsonConvert.DeserializeObject<JsonJob>(raw);
            return jsonJob.id;
        }
    }
}
