using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Path
{
    public class ScreenShot
    {
        public static void PageScreenshot(string url, string path)
        {
            ChromeDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("headless", "disable-gpu");
                driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
                driver.Navigate().GoToUrl(url);
                string width = driver.ExecuteScript("return document.body.scrollWidth").ToString();
                string height = driver.ExecuteScript("return document.body.scrollHeight").ToString();
                driver.Manage().Window.Size = new System.Drawing.Size(int.Parse(width), int.Parse(height)); //=int.Parse( height);
                var screenshot = (driver as ITakesScreenshot).GetScreenshot();
                screenshot.SaveAsFile(path);
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
