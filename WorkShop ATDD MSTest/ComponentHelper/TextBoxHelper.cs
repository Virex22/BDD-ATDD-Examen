using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_ATDD_MSTest.ComponentHelper
{
    public class TextBoxHelper
    {
        public static void TypeInTextBox(By locator, string value)
        {
            var element = GenericHelper.GetElement(locator);
            element.SendKeys(value);
        }

        public static void ClearTextBox(By locator)
        {
            var element = GenericHelper.GetElement(locator);
            element.Clear();
        }
    }
}
