using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TataCliq.PageObjects
{
    internal class TataCliqHomePage
    {
        IWebDriver driver;
        public TataCliqHomePage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.XPath, Using = "//input[@id='search-text-input']")]
        public IWebElement? SearchProductBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='DesktopHeader__luxeryTab']")]
        public IWebElement? LuxeryProduct {  get; set; }
        public ProductListDetails TypeSearchInput(string product)
        {
            if (SearchProductBox == null)
            {
                throw new NoSuchElementException(nameof(SearchProductBox));
            }
            SearchProductBox?.Clear();
            SearchProductBox?.SendKeys(product);
            SearchProductBox?.SendKeys(Keys.Enter);
            return new ProductListDetails(driver);
        }
        public LuxuryProducts Selection()
        {
            Thread.Sleep(3000);
            LuxeryProduct?.Click();
            return new LuxuryProducts(driver);
        }
    }
}
