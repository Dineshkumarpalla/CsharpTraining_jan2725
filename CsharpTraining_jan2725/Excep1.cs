using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Excep1
    {
        public void runExcep1()
        {
            int a, b, c;
            Console.WriteLine("ENter 2 Numbers: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division Value: " + c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero impossible.. " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Number is too big " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("String Cannot be Converted as Interger..."+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("After try catch block...");
            }
        }
    } 
}
