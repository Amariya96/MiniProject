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
            CoreCodes.ScrollIntoView(driver,driver.FindElement(By.XPath("//button[@class='pdp-module__btn pdp-module__active']//span")));
          
            Thread.Sleep(8000);
            MovetoBag?.Click();   
            return new LuxViewCart(driver);
        }
     
    }
}
