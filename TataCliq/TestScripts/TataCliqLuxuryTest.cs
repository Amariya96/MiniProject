using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.PageObjects;
using TataCliq.Utilities;

namespace TataCliq.TestScripts
{
    internal class TataCliqLuxuryTest : CoreCodes
    {

        [Test, Order(2)]
        public void SearchLuxuryProductTest()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
                LuxuryProducts lp = new(driver);

                lp.ClickProductItem();
                List<string> str = driver.WindowHandles.ToList();
                driver.SwitchTo().Window(str[1]);
                lp.LuxuaryProduct();
                Console.WriteLine(str.Count);
                Thread.Sleep(3000);
                List<string> str1 = driver.WindowHandles.ToList();
                driver.SwitchTo().Window(str1[2]);
                Thread.Sleep(3000);
                LuxuryProductAddToCart lpac = new(driver);
                lpac.LuxMoveToBag();
                Thread.Sleep(6000);
                LuxViewCart lc = new(driver);
                lc.LuxMoveToBtn();
                Thread.Sleep(4000);
                TakeScreenShot();
                Assert.That(driver.Url, Does.Contain("luxury"));
                LogTestResult("Luxury Product Search Test", "Luxury Product Test Passed");
                test = extent.CreateTest("Luxury Product Search Test Passed");
                test.Pass("Luxury Product Search Test Passed");
            }
            catch (AssertionException ex)
            {
                TakeScreenShot();
                LogTestResult("Luxury Product Search Test", "Luxury Producut Search Test Failed", ex.Message);
                test.Fail("Luxury Product Search Test Failed");
            }

        }
    }
}
