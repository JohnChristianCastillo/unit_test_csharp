using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class SimpleFunctionTest
    {
        // Naming Convention: ClassName_MethodName_ExpectedResult
        public static void SimpleFunction_ReturnsJohnIfTrue_ReturnJohn()
        {
            try
            {
                //Arrange: Go get your variables/classes/functions, whatever you need to run the function you're testing
                bool b = true;
                SimpleFunction simpleFunction = new SimpleFunction();

                //Act: Execute function
                string result = simpleFunction.ReturnsJohnIfTrue(b);

                //Assert: Whatever is returned is what you want
                if(result == "JOHN")
                {
                    Console.WriteLine("PASSED: SimpleFunction.ReturnsJohnIfTrue_ReturnsJohn");
                }
                else
                {
                    Console.WriteLine("FAILED: SimpleFunction.ReturnsJohnIfTrue_ReturnsJohn");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
