using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.ScreenShot;
using System.IO;

namespace Common.CoreTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //НиЭМ
            //string path1 = "https://www.cnblogs.com/SFHa/p/8867478.html";
            string path2 = "https://bingo-test.longhu.net/assets/index.html#/groupActionApp/groupActionLock?id=5e1a645c-5cee-4b55-9668-5362500d37eb&status=5&role=%E6%88%91%E7%9A%84";
            string path3 = "https://bingo-test.longhu.net/assets/index.html#/indexrisk";
            Common.ScreenShot.ScreenShot.PageScreenshot(path2, @"G:\ScreenShot\");


            //  FileInfo myfile = new FileInfo(@"G:\ScreenShot\33.txt");


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
