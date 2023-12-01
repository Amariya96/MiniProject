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
    internal class ProductSizeAndAddToCart
    {
        IWebDriver driver;

        public ProductSizeAndAddToCart(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='ADD TO BAG']")]
        public IWebElement? AddtoBag { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='DesktopHeader__cartCount']")]
        public IWebElement? ViewCart { get; set; }
        public ProductViewCart AddToBagClick()
        {
            
            AddtoBag?.Click();
            Thread.Sleep(3000);
            /*DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.PollingInterval = TimeSpan.FromMicroseconds(1000);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.Until(d => ViewCart.Displayed);*/
            ViewCart?.Click();
            Thread.Sleep(3000);
            return new ProductViewCart(driver);
        }
    }
}
