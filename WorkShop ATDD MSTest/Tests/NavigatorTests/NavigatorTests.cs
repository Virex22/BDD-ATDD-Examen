using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;
using WorkShop_ATDD_MSTest.Configuration;
using WorkShop_ATDD_MSTest.Interfaces;

namespace WorkShop_ATDD_MSTest.Tests.NavigatorTests
{
    [TestClass]
    public class NavigatorTests
    {
        //[TestInitialize]
        //public void SetUp()
        //{
        //    NavigationHelper.NavigateToHomePage();
        //}

        [TestMethod]
        public void OpenChromeAndGoToHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void OpenFirefoxAndGoToHomePage()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        [Ignore]
        public void OpenInternetExplorerAndGoToHomePage()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            driver.Close();
            driver.Quit();
        }
        [TestMethod]
        public void OpenConfigBrowserWithBaseClass()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            //ObjectRepository.Driver.Close();
            //ObjectRepository.Driver.Quit();
        }
    }
}
