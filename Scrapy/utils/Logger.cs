using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapy.utils
{
    class Logger
    {
        private static MainForm logger;
        public static void GetLogger(MainForm mainForm)
        {
            logger = mainForm;
        }
        public static void Log(string message)
        {
            logger.Log(message);
        }
        public static void SetProgressMax(int a)
        {
            logger.SetProgressBarMax(a);
        }
        public static void AddOne()
        {
            logger.AddOneToProgressBar();
        }
        public static void ClearProgressBar()
        {
            logger.ClearProgressBar();
        }
        public static void EnableAllButtons()
        {
            logger.EnableAllButtons();
        }
        public static int GetMissionId()
        {
            return logger.GetMissionId();
        }
    }
}
