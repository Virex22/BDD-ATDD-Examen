﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;
using WorkShop_ATDD_MSTest.ComponentHelper;
using WorkShop_ATDD_MSTest.Configuration;
using WorkShop_ATDD_MSTest.Settings;

namespace SpecflowSnakeBDD.Hook
{
    [Binding]
    public class InitScenarioHook
    {
        [BeforeScenario]
        public static void InitScenario()
        {
            ObjectRepository.Config = new ConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = BaseClass.GetChromeWebDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = BaseClass.GetFirefoxWebDriver();
                    break;

                case BrowserType.InternetExplorer:
                    ObjectRepository.Driver = BaseClass.GetInternetExplorerWebDriver();
                    break;
            }

            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }

        [AfterScenario]
        public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}