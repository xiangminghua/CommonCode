using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Common.ScreenShot
{
    public class ScreenShot
    {
        /*
        1、nuget  包安装

        2、虚拟浏览器  chromedriver.exe  下载在根目录，版本要和本地的谷歌浏览器一致
        
        
         */

        public static void PageScreenshot(string url, string path)
        {
            ChromeDriver driver = null;
            try
            {


                ChromeOptions options = new ChromeOptions();
                options.AddArguments("headless", "disable-gpu");
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

                //var loginUrl = string.Format(_configurationRoot.GetSection("AppSettings:PublicComplaintUrl:VirtualLoginUrl").Value, token.AccessToken);
                //await httpClient.GetAsync(loginUrl);

                var loginUrl = string.Format("https://bingo-test.longhu.net/Account/Login?returnUrl=&token={0}", "TGT-163859-UpBQ3kKrk99ssWctFtbV-h9Foly3cZXkgvP81FN7227OVm9QWViMfvjwoz5AwXRYWAQ-longhu");
                driver.Navigate().GoToUrl(loginUrl);
                driver.Navigate().GoToUrl(url);
                Thread.Sleep(2000);
                string width = driver.ExecuteScript("return document.getElementById(\"app\").scrollWidth").ToString();
                //var div = driver.FindElementById("app");
                //var s=div.Size;
                string height = driver.ExecuteScript("return document.getElementById(\"app\").scrollHeight").ToString();
                driver.Manage().Window.Size = new System.Drawing.Size(int.Parse(width), int.Parse(height)); //=int.Parse( height);
                var screenshot = (driver as ITakesScreenshot).GetScreenshot();

                //存图片
                using (var imageFile = new FileStream($"{path}微信图片{DateTime.Now.ToString("yyyyMMddHHmmss")}.png", FileMode.Create))
                {
                    imageFile.Write(screenshot.AsByteArray, 0, screenshot.AsByteArray.Length);
                    imageFile.Flush();
                }

                // screenshot.SaveAsFile(path);
            }
            catch (Exception ex)
            {
                //logger.Error(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                if (driver != null)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
        }


    }
}
