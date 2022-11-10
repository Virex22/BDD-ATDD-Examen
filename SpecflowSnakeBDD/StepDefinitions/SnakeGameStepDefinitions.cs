using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;

namespace SpecflowSnakeBDD.StepDefinitions
{
    [Binding]
    public class SnakeGameStepDefinitions
    {
        [Given(@"user is on home page")]
        public void GivenUserIsOnHomePage()
        {
            NavigationHelper.NavigateToHomePage();
        }
                            

        [When(@"user clicks on add button")]
        public void WhenUserClicksOnAddButton()
        {
            ButtonHelper.ClickButton(By.Id("submitPlayers"));
        }

        [Then(@"user is at game page ""([^""]*)""")]
        public void ThenUserIsAtGamePage(string url)
        {
            Assert.AreEqual(ObjectRepository.Driver.Url, url);
        }

        [When(@"user play and one player win")]
        public void WhenUserPlayAndOnePlayerWin()
        {
            string currentURL = ObjectRepository.Driver.Url;
            while (ObjectRepository.Driver.Url == currentURL)
            {
                ButtonHelper.ClickButton(By.CssSelector("#play-form > input:nth-child(3)"));
            }
        }

        [Then(@"user is at endgame page ""([^""]*)""")]
        public void ThenUserIsAtEndgamePage(string url)
        {
            Assert.AreEqual(ObjectRepository.Driver.Url, url);
        }
    }
}
