using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_ATDD_MSTest.Configuration
{
    public class GameSettings
    {
        public string Browser { get; set; }
        public string Website { get; set; }
        public string GoodCreditCard { get; set; }
        public string WrongCreditCard { get; set; }
        public string GoodExpirationDate { get; set; }
        public string WrongExpirationDate { get; set; }
        public string GoodCVC { get; set; }
        public string WrongCVC { get; set; }
    }
}
