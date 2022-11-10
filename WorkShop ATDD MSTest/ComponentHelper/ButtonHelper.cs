using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_ATDD_MSTest.ComponentHelper
{
    public class ButtonHelper
    {
        public static void ClickButton(By locator)
        {
            GenericHelper.GetElement(locator).Click();
        }
    }
}
