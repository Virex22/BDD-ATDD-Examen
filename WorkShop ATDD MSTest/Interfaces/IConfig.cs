using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.Settings;

namespace WorkShop_ATDD_MSTest.Interfaces
{
    public interface IConfig
    {
        
        string GetWebsite();
        string GetGoodCreditCard();
        string GetWrongCreditCard();
        string GetGoodExpirationDate();
        string GetWrongExpirationDate();
        string GetGoodCVC();
        string GetWrongCVC();
        BrowserType GetBrowser();
    }
}
