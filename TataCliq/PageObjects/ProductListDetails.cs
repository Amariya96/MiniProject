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
    internal class ProductListDetails
    {
        IWebDriver driver;
        public ProductListDetails(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       [FindsBy(How = How.XPath, Using = "//div[@id='ProductModule-MP000000001575063'][1]")]
       private IWebElement? SearchProdcutItem { get; set; }

        public ProductSizeAndAddToCart ClickProduct()
        {

            /*DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.Until(d => SearchProdcutItem?.Displayed);*/
            SearchProdcutItem?.Click();
            Thread.Sleep(3000);
            return new ProductSizeAndAddToCart(driver);
        }
    }
}
