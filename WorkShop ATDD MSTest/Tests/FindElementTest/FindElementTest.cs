using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;

namespace WorkShop_ATDD_MSTest.Tests.FindElementTest
{
    [TestClass]
    public class FindElementTests
    {
        [TestMethod]
        public void GetElementTests()
        {
            try
            {
                ObjectRepository.Driver.FindElement(By.LinkText("CONTACT"));
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementsTests()
        {
            try
            {
                ReadOnlyCollection<IWebElement> elements = ObjectRepository.Driver.FindElements(By.TagName("input"));
                Console.WriteLine(elements.Count);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void GetElementFromGenericHelper()
        {
            Assert.IsNotNull(GenericHelper.GetElement(By.LinkText("Contact")));
        }

        [TestMethod]
        public void IsElementPresentOnce()
        {
            Assert.IsTrue(ObjectRepository.Driver.FindElements(By.LinkText("Contact")).Count == 1);
        }

        [TestMethod]
        public void IsElementPresentOnceFromGenericHelper()
        {
            Assert.IsTrue(GenericHelper.IsElementPresentOnce(By.LinkText("Contact")));
        }
    }
}
