using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.PageObjects;
using TataCliq.Utilities;

namespace TataCliq.TestScripts
{
    [TestFixture]
    internal class TataCliqTest : CoreCodes
    {
        [Test,Order(1)]
        public void SearchProductTest()
        {
            var homepage = new TataCliqHomePage(driver);
            
            string? currDir = Directory.GetParent(@"../../../")?.FullName;
            string? excelFilePath = currDir + "/TestData/InputData.xlsx";
            string? sheetName = "TataCliq";

            List<SearchData> excelDataList = ExcelUtils.ReadExcelData(excelFilePath, sheetName);

            foreach (var excelData in excelDataList)
            {

                string? productItem = excelData?.Products;
                string? mobileNo = excelData?.MobileNum;
                Thread.Sleep(3000);
                
                var productList = homepage.TypeSearchInput(productItem);
                var productPage = productList.ClickProduct();
                List<string> str = driver.WindowHandles.ToList();
                driver.SwitchTo().Window(str[1]);
                Thread.Sleep(3000);
                var checkout =    productPage.AddToBagClick();
                Thread.Sleep(3000);
                checkout.BuyNowProduct(mobileNo);

               
            }
        }
    }
}
