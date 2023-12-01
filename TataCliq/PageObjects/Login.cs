using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataCliq.PageObjects
{
    internal class Login
    {
        IWebDriver driver;
        public Login(IWebDriver? driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[@data-test='button']")]
        private IWebElement? SignInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='mobileNumber']")]
        private IWebElement? SignInMobileNo { get; set; }
        
        public void SignIn()
        {
            Thread.Sleep(3000);
            IWebElement brand = driver.FindElement(By.XPath("//body/div[@id='root']/div[@class='App__base']/div[@class='DesktopHeader__base']/div[@class='DesktopHeader__headerHolder']/div[@class='DesktopHeader__headerFunctionality']/div[@class='DesktopHeader__upperHeader']/div[@class='DesktopHeader__loginAndTrackTab']/div[@class='DesktopHeader__signInAndLogout']/div[2]"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(brand).Build().Perform();
            Thread.Sleep(2000);
            SignInBtn?.Click();
            Thread.Sleep(2000);
            SignInMobileNo?.SendKeys("6798653421");
            SignInMobileNo?.SendKeys(Keys.Enter);
        }
    }
}
