using OpenQA.Selenium;
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


        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'buttonAddToBag')])[1]")]
        public IWebElement? AddtoBag { get; set; }


        
        public void AddToBagClick()
        {
           // Thread.Sleep(3000); 
            AddtoBag?.Click();
        }
    }
}
