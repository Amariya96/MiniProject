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
    internal class HomeScreenTest : CoreCodes
    {
        [Test, Order(3), Category("Smoke Test")]
        public void Screentest() 
        {
            if (!driver.Url.Equals("https://www.tatacliq.com/"))
            {
                driver.Navigate().GoToUrl("https://www.tatacliq.com/");

            }
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
                HomeScreen hs = new(driver);
                Thread.Sleep(2000);
                hs.Screens();
                TakeScreenShot();
                Assert.That(driver.Url, Does.Contain("tatacliq"));
                LogTestResult("Screen Test", "Screen Test Passed");
                test = extent.CreateTest("Screen Test Passed");
                test.Pass("Screen Test Passed");
            }
            catch (AssertionException ex)
            {
                TakeScreenShot();
                LogTestResult("Screen Test", "Screen Test Failed", ex.Message);
                test.Fail("Screen Test Failed");
            }
        }

       

        [Test, Order(4), Category("Smoke Test")]
        public void InvalidDataTest()
        {
            if (!driver.Url.Equals("https://www.tatacliq.com/"))
            {
                driver.Navigate().GoToUrl("https://www.tatacliq.com/");

            }
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try {
                InvalidData id = new(driver);
                Thread.Sleep(2000);
                id.InvalidDataCheck();
                Thread.Sleep(2000);
                TakeScreenShot();
                Assert.That(driver.Url, Does.Contain("search"));
                LogTestResult("InvalidData Test", "InvalidData Test Passed");
                test = extent.CreateTest("InvalidData Test Passed");
                test.Pass("InvalidData Test Passed");
            }
            catch (AssertionException ex)
            {
                TakeScreenShot();
                LogTestResult("InvalidData Test", "InvalidData Test Failed", ex.Message);
                test.Fail("InvalidData Test Failed");
            }
        }

        [Test, Order(5), Category("Smoke Test")]
        public void FilterTest()
        {
            if (!driver.Url.Equals("https://www.tatacliq.com/"))
            {
                driver.Navigate().GoToUrl("https://www.tatacliq.com/");

            }
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
                Offers o = new(driver);
                Thread.Sleep(2000);
                o.Filter();
                TakeScreenShot();
                Assert.That(driver.Url, Does.Contain("tatacliq"));
                LogTestResult("Filter Test", "Filter Test Passed");
                test = extent.CreateTest("Filter Test Passed");
                test.Pass("Filter Test Passed");
            }
            catch (AssertionException ex)
            {
                TakeScreenShot();
                LogTestResult("Filter Test", "Filter Test Failed", ex.Message);
                test.Fail("Filter Test Failed");
            }
        }

        [Test, Order(6), Category("Smoke Test")]
        public void SignInTest()
        {
            if (!driver.Url.Equals("https://www.tatacliq.com/"))
            {
                driver.Navigate().GoToUrl("https://www.tatacliq.com/");

            }
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
                Login l = new(driver);
                Thread.Sleep(2000);
                l.SignIn();
                Thread.Sleep(5000);
                TakeScreenShot();
                Assert.That(driver.Url, Does.Contain("tatacliq"));               
                LogTestResult("SignIn Test", "SignIn Test Passed");
               test = extent.CreateTest("SignIn Test Passed");
               test.Pass("SignIn Test Passed");
        }
            catch (AssertionException ex)
            {
                TakeScreenShot();
                LogTestResult("SignIn Test", "SignIn Test Failed", ex.Message);
                test.Fail("SignIn Test Failed");
            }
}
       
    }
}
