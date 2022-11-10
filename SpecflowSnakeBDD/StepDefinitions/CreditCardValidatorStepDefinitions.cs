using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;
using static System.Net.Mime.MediaTypeNames;

namespace SpecflowSnakeBDD.StepDefinitions
{
    [Binding]
    public class CreditCardValidatorStepDefinitions
    {
        [Given(@"user fills the three inputs")]
        public void GivenUserFillsTheThreeInputs()
        {
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), ObjectRepository.Config.GetGoodCreditCard());
            TextBoxHelper.TypeInTextBox(By.Id("expirationDate"), ObjectRepository.Config.GetGoodExpirationDate());
            TextBoxHelper.TypeInTextBox(By.Id("cvc"), ObjectRepository.Config.GetGoodCVC());
        }

        [Given(@"credit card number is sixteen digits long")]
        public void GivenCreditCardNumberIsSixteenDigitsLong()
        {
            Console.WriteLine(GenericHelper.GetElement(By.Id("creditCardNumber")).GetAttribute("value"));
            Assert.IsTrue(GenericHelper.GetElement(By.Id("creditCardNumber")).GetAttribute("value").Length.Equals(16));
        }

        [Given(@"expiration date is at format MM/YYYY")]
        public void GivenExpirationDateIsAtFormatMMYYYY()
        {
            string value = GenericHelper.GetElement(By.Id("expirationDate")).GetAttribute("value");
            Assert.IsTrue(value.Contains("/"));
            Assert.IsTrue(value.Split('/')[0].Length.Equals(2));
            Assert.IsTrue(value.Split('/')[1].Length.Equals(4));
        }

        [Given(@"cvc is three digits long")]
        public void GivenCvcIsThreeDigitsLong()
        {
            GenericHelper.GetElement(By.Id("cvc")).Text.Length.Equals(3);
        }

        [When(@"submit button is pressed")]
        public void WhenSubmitButtonIsPressed()
        {
            ButtonHelper.ClickButton(By.Id("submitCard"));
        }

        [Then(@"user is on page paymentConfirmed")]
        public void ThenUserIsOnPagePaymentConfirmed()
        {

            Assert.AreEqual(ObjectRepository.Driver.Url, "http://localhost/paymentConfirmed.html");
        }

        [Given(@"credit card number is not sixteen digits long")]
        public void GivenCreditCardNumberIsNotSixteenDigitsLong()
        {
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), ObjectRepository.Config.GetWrongCreditCard());
        }

        [Then(@"user is on homePage")]
        public void ThenUserIsOnHomePage()
        {
            Assert.AreEqual(ObjectRepository.Driver.Url, ObjectRepository.Config.GetWebsite());
        }

        [Given(@"expiration date is not at format MM/YYYY")]
        public void GivenExpirationDateIsNotAtFormatMMYYYY()
        {
            TextBoxHelper.TypeInTextBox(By.Id("expirationDate"), ObjectRepository.Config.GetWrongExpirationDate());
        }

        [Given(@"cvc is not three digits long")]
        public void GivenCvcIsNotThreeDigitsLong()
        {
            TextBoxHelper.TypeInTextBox(By.Id("cvc"), ObjectRepository.Config.GetWrongCVC());
        }
    }
}
