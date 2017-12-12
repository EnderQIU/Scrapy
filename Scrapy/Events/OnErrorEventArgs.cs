using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapy.Events
{
    public class OnErrorEventArgs
    {
        public string Url { get; set; }

        public Exception Exception { get; set; }

        public OnErrorEventArgs(string url, Exception exception)
        {
            this.Url = url;
            this.Exception = exception;
        }
    }
}
