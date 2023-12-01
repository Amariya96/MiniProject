using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TataCliq.PageObjects;
using TataCliq.Utilities;

namespace TataCliq.TestScripts
{
    internal class HomeScreenTest : CoreCodes
    {
        [Test, Order(3), Category("Smoke Test")]
        public void Screentest() {
        HomeScreen hs = new(driver);
        Thread.Sleep(2000);
        hs.Screens();          
        }

        [Test, Order(4), Category("Smoke Test")]
        public void SignInTest()
        {
            Login l =new(driver);
            Thread.Sleep(2000);
            l.SignIn();
            Thread.Sleep(2000);
        }

        [Test, Order(5), Category("Smoke Test")]
        public void InvalidDataTest()
        {
            InvalidData id = new(driver);
            Thread.Sleep(2000);
            id.InvalidDataCheck();
            Thread.Sleep(2000);
        }
    }
}
