using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Profiler;
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
    public class LinkTests
    {
        [TestInitialize]
        public void SetUp()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void ClickLinkTest()
        {
            string url = ObjectRepository.Driver.Url;
            ObjectRepository.Driver.FindElement(By.LinkText("Contact")).Click();
            Assert.AreNotEqual(url, ObjectRepository.Driver.Url);
        }

        [TestMethod]
        public void ClickLinkFromHelperTest()
        {
            string url = ObjectRepository.Driver.Url;
            LinkHelper.ClickLink(By.LinkText("Contact"));
            Assert.AreNotEqual(url, ObjectRepository.Driver.Url);
        }
    }
}
