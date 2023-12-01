using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
       [FindsBy(How = How.XPath, Using = "//div[@class='Grid__element'][1]")]
       private IWebElement? SearchProdcutItem { get; set; }

        [FindsBy(How =How.Id,Using = "wzrk-confirm")]
        IWebElement ButtonClose { get; set; }

        public ProductSizeAndAddToCart ClickProduct()
        {
            ButtonClose.Click();
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.PollingInterval = TimeSpan.FromMilliseconds(100);
            wait.Timeout = TimeSpan.FromSeconds(40);
            wait.Until(d => SearchProdcutItem.Displayed);
            Actions actions = new Actions(driver);
            actions.MoveToElement(SearchProdcutItem).Build().Perform();
            Thread.Sleep(3000);
            SearchProdcutItem?.Click();
            Thread.Sleep(3000);
            return new ProductSizeAndAddToCart(driver);
        }
    }
}
