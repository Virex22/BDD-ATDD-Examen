using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.CustomExceptions;
using WorkShop_ATDD_MSTest.Interfaces;
using WorkShop_ATDD_MSTest.Settings;

namespace WorkShop_ATDD_MSTest.Configuration
{
    public class ConfigReader  : IConfig
    {
        private GameSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        public BrowserType GetBrowser()
        {
            string browser = settings.Browser;

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (ArgumentException)
            {
                throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetGoodCreditCard()
        {
            return settings.GoodCreditCard;
        }

        public string GetGoodCVC()
        {
            return settings.WrongCreditCard;
        }

        public string GetGoodExpirationDate()
        {
            return settings.GoodExpirationDate;
        }

        public string GetWebsite()
        {
            return settings.Website;
        }

        public string GetWrongCreditCard()
        {
            return settings.WrongCreditCard;
        }

        public string GetWrongCVC()
        {
            return settings.WrongCVC;
        }

        public string GetWrongExpirationDate()
        {
            return settings.WrongExpirationDate;
        }
    }
}
