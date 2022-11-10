using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;

namespace WorkShop_ATDD_MSTest.Tests.PageNavigationTests
{
    [TestClass]
    public class PageNavigationTests
    {

        [TestMethod]
        public void OpenUrlFromDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void OpenUrlFromObjectRepository()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitle()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(ObjectRepository.Driver.Title);
        }

        [TestMethod]
        public void OpenPageFromObjectRepositoryAndGetTitleFromPageHelper()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine(PageHelper.GetPageTitle());
        }
    }
}
