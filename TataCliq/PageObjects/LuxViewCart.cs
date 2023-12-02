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
        

        [FindsBy(How = How.XPath, Using = "//span[@class='icons1 headRgtBagIcon']")]
        public IWebElement? ViewCartBtn { get; set; }

       

        public void LuxMoveToBtn()
        {
            ViewCartBtn?.Click();
            Thread.Sleep(3000);
        }
    }
}
