using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCliq.PageObjects
{
    internal class LuxViewCart
    {
        IWebDriver driver;
        public LuxViewCart(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Buy Now']")]
        public IWebElement? BuyNowBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Mobile number']")]
        public IWebElement? LuxMobileNo { get; set; }

        public void LuxMoveToBtn()
        {
            BuyNowBtn?.Click();
            Thread.Sleep(3000);
            LuxMobileNo?.Click();
        }
    }
}
