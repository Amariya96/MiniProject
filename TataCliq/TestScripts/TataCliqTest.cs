using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.PageObjects;
using TataCliq.Utilities;

namespace TataCliq.TestScripts
{
    [TestFixture]
    internal class TataCliqTest : CoreCodes
    {
        [Test]
        public void SearchProductTest()
        {
            var homepage = new TataCliqHomePage(driver);
            var productList = homepage.TypeSearchInput();
            Thread.Sleep(3000);
            var productPage = productList.ClickProduct();
            List<string> str = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(str[1]);
            Thread.Sleep(3000);
            productPage.AddToBagClick();

            
        }
    }
}
