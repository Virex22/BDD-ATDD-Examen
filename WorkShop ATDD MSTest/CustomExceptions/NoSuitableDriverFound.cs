using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop_ATDD_MSTest.CustomExceptions
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string message) : base(message) { }
    }
}
