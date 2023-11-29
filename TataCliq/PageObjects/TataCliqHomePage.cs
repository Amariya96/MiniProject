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

       
        [FindsBy(How = How.Id, Using = "search-text-input")]
        public IWebElement? SearchProductBox { get; set; }

        public ProductListDetails TypeSearchInput()
        {
            if (SearchProductBox == null)
            {
                throw new NoSuchElementException(nameof(SearchProductBox));
            }
            SearchProductBox?.Clear();
            SearchProductBox?.SendKeys("Watches");
            Thread.Sleep(3000);
            SearchProductBox?.SendKeys(Keys.Enter);
            return new ProductListDetails(driver);
        }
    }
}
