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
    internal class LuxuryProducts
    {
        IWebDriver driver;
        public LuxuryProducts(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@class='DesktopHeader__luxeryTab']")]
        private IWebElement? Luxury { get; set; }

        
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/header[1]/div[1]/div[1]/div[1]/ul[1]/li[1]/nav[1]/div[1]/ul[1]/li[10]/a[1]")]
        private IWebElement? Brands { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Sunglasses']")]
         private IWebElement? Adidas { get; set; }


        [FindsBy(How = How.XPath, Using = "(//div[@class='product-listing-module__flip_card_inner'])[1]")]
        private IWebElement? Item { get; set; }

        public void ClickProductItem()
        {
            Luxury?.Click();
           
        }
        public LuxuryProductAddToCart LuxuaryProduct()
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.PollingInterval = TimeSpan.FromMicroseconds(1000);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.Until(d => Brands.Displayed);
            Brands?.Click();
            Thread.Sleep(4000);
            Adidas?.Click();
            Thread.Sleep(3000);
            Item?.Click();
            Thread.Sleep(3000);
            return new LuxuryProductAddToCart(driver);
        }
    }
    }

