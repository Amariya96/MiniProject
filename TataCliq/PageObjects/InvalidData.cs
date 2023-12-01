using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCliq.PageObjects
{
    internal class InvalidData
    {
        IWebDriver driver;
        public InvalidData(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//input[@id='search-text-input']")]
        private IWebElement? SearchButton { get; set; }
        public void InvalidDataCheck()
        {
            SearchButton?.Click();
            SearchButton?.SendKeys("76659");
            Thread.Sleep(2000);
            SearchButton?.SendKeys(Keys.Enter);
        }
    }
}
