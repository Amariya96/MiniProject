using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.Utilities;

namespace TataCliq.PageObjects
{
    internal class Offers
    {
        IWebDriver driver;
        public Offers(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//img[@class='ImageFlexible__loaded ImageFlexible__actual'][1]")]
        private IWebElement? OffersPointer { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='BrandFilterTabDesktop__brandsList']//div[@class='CheckBox__selected CheckBox__base']")]
        private IWebElement? FilterButton { get; set; }
        
        public void Filter()
        {
            // CoreCodes.ScrollIntoView(driver, driver.FindElement(By.XPath("//img[@class='ImageFlexible__loaded ImageFlexible__actual'][1]")));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", OffersPointer);
           // Thread.Sleep(2000);
           // OffersPointer?.Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", FilterButton);
         //   FilterButton?.Click();
        }
    }
}
