﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrapy.Models;

namespace Scrapy.utils
{
    class FileHandler
    {
        public Job[] getJobs()
        {
            Queue<String> queue = new Queue<String>();
            StreamReader sr = new StreamReader("data.txt", Encoding.UTF8);
            String line;
            String temp=null;
            bool mark = false;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("工作简介"))
                {
                    
                    if(line== "工作简介：")//排除一种让人头大的换行
                    {
                        line = line + sr.ReadLine();
                    }
                    queue.Enqueue(line);
                    do
                    {
                        temp = sr.ReadLine();
                    } while (!temp.Contains("工作网址"));
                    mark = true;
                }
                if (mark == false)
                {
                    queue.Enqueue(line);
                }
                else
                {
                    queue.Enqueue(temp);
                    mark = false;
                }
            }
            Job[] jobs = new Job[700];
            int i = 0;
            while(i<700)
            {
                String[] job = new String[7];
                for(int j=0;j<7;j++)
                {
                    job[j]= queue.Dequeue();
                }
                queue.Dequeue();
                jobs[i] = new Job(job);
                i++;
            }
            

            return jobs;

        }
    }
}
