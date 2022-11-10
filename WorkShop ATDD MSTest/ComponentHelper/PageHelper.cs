using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_ATDD_MSTest.BaseClasses;

namespace WorkShop_ATDD_MSTest.ComponentHelper
{
    public class PageHelper
    {
        public static string GetPageTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        public static string GetPageUrl()
        {
            return ObjectRepository.Driver.Url;
        }
    }
}
