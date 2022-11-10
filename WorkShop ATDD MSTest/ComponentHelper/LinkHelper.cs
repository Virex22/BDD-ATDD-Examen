using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_ATDD_MSTest.ComponentHelper
{
    public class LinkHelper
    {
        public static void ClickLink(By locator)
        {
            IWebElement element = GenericHelper.GetElement(locator);
            element.Click();
        }
    }
}
