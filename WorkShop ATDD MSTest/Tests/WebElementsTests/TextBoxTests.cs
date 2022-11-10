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
    public class TextBoxTests
    {
        [TestInitialize]
        public void SetUp()
        {
            NavigationHelper.NavigateToHomePage();
            IWebElement element = GenericHelper.GetElement(By.Id("p1"));
            element.Clear();
        }

        [TestMethod]
        public void TextBoxTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Id("p1"));
            string lastText = element.GetAttribute("value");
            element.SendKeys("Hello World");
            Assert.AreNotEqual(lastText, element.GetAttribute("value"));
        }
    }
}
