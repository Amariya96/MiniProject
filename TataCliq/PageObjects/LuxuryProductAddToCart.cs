using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.Utilities;

namespace TataCliq.PageObjects
{
    internal class LuxuryProductAddToCart
    {
        IWebDriver driver;

        public LuxuryProductAddToCart(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[8]/div[1]/div[2]/button[1]")]
        public IWebElement? MovetoBag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='icons1 headRgtBagIcon']")]
        public IWebElement? MovetoBagBtn { get; set; }

        
       
        public LuxViewCart LuxMoveToBag()
        {
            Thread.Sleep(2000);
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.PollingInterval = TimeSpan.FromMicroseconds(1000);
            wait.Timeout = TimeSpan.FromSeconds(10);
            // CoreCodes.ScrollIntoView(driver,driver.FindElement(By.XPath("//button[@class='pdp-module__btn pdp-module__active']//span")));
            IWebElement Element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[text()='Style Note & Features']")));
            driver.ExecuteJavaScript("arguments[0].scrollIntoView();", Element);
            Thread.Sleep(10000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()",MovetoBag);
            return new LuxViewCart(driver);
        }
     
    }
}
