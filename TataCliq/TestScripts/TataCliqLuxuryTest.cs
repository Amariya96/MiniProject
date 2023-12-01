using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.PageObjects;
using TataCliq.Utilities;

namespace TataCliq.TestScripts
{
    internal class TataCliqLuxuryTest : CoreCodes
    {

        [Test, Order(2)]
        public void SearchLuxuryProductTest()
        {
            LuxuryProducts lp = new(driver);
            
            lp.ClickProductItem();
            List<string> str = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(str[1]);
            lp.LuxuaryProduct();
            Console.WriteLine(str.Count);
            Thread.Sleep(3000);
            List<string> str1 = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(str1[2]);
            Thread.Sleep(3000);
            LuxuryProductAddToCart lpac = new(driver);                    
            lpac.LuxMoveToBag();
            Thread.Sleep(6000);
            /* List<string> str2 = driver.WindowHandles.ToList();
             driver.SwitchTo().Window(str2[3]);*/
            LuxViewCart lc = new(driver);
            lc.LuxMoveToBtn();
            Thread.Sleep(4000);

        }
    }
}
