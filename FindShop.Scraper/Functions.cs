﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace FindShop.Scraper
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        //public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        //{
        //    log.WriteLine(message);
        //}

        public static void ScraperTimerJob([TimerTrigger("00:10:00", RunOnStartup = true)] TimerInfo timerInfo, TextWriter log)
        {
        }
    }
}
