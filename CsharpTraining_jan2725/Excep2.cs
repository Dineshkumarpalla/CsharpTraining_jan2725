using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Excep2
    {
        public void Check(int n)
        {
            if (n < 0)
            {
                throw new DivideByZeroException("Negative nos are not Allowed...");
            }
            else if (n == 0)
            {
                throw new FormatException("Zero is Invalid value..");
            }
            else
            {
                Console.WriteLine("N value is: " + n);
            }
        }

        public static void runExcep2()
        {
            Excep2 e2 = new Excep2();
            try
            {
                e2.Check(-4);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
