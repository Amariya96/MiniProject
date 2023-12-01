using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCliq.PageObjects
{
    internal class ProductViewCart
    {
        IWebDriver driver;
        public ProductViewCart(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        

        [FindsBy(How = How.XPath, Using = "//div[@class='DesktopCheckout__button']//div[@class='Button__base']")]
        public IWebElement? CheckOut { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@class='mobile-number-login__form_control']")]
        public IWebElement? MobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "continueBtn")]
        public IWebElement? ContinueBtn { get; set; }

        public void BuyNowProduct(string mbno)
        {
            
            
            CheckOut?.Click();
            Thread.Sleep(2000);
            MobileNo?.SendKeys(mbno);
            Thread.Sleep(2000);
            ContinueBtn?.Click();
        }

    }
}
