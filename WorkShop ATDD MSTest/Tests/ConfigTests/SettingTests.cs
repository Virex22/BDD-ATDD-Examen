using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.Configuration;

namespace WorkShop_ATDD_MSTest.Tests.ConfigTests
{
    [TestClass]
    public class SettingTests
    {
        private GameSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(GameSettings)).Get<GameSettings>();
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = {settings.Website}");
        }
    }
}
      