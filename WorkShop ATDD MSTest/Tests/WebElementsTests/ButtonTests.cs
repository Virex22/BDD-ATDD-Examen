using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;

namespace WorkShop_ATDD_MSTest.Tests.WebElementsTests
{
    [TestClass]
    public class ButtonTests
    {
            

        [TestMethod]
        public void ClickOnButtonFromHelperTest()
        {
            ButtonHelper.ClickButton(By.Id("submitPlayers"));
        }
    }
}
