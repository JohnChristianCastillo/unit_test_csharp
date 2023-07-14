using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class SimpleFunction
    {
        public string ReturnsJohnIfTrue(bool b)
        {
            if(b) // we test this as maybe a dev changes this to !b
            {
                return "JOHN";
            }
            else 
            { 
                return "CASTLE";
            }
        }
    }
}
