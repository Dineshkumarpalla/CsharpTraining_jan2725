using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class ExceptionProg
    {
        public class OverWeightException : Exception
        {
            public OverWeightException(String message) : base(message) { }
        }
        public void weightException()
        {
            //user defined Exeption
            try
            {
                int weight = 82;
                if (weight > 75)
                {
                    throw new OverWeightException("your weight is heighter you need to loose weight");
                }
                Console.WriteLine($"your weight is:{weight}");
            }
            catch (OverWeightException ex)
            {
                Console.WriteLine($"OverWeightException is catch in main:{ex.Message}");
            }
            finally
            {
                Console.WriteLine("after try catch block..");
            }
            Console.WriteLine("Program Continue..");

        }


        public void TheowException()
        {

            // Exception using throw keyword

            

            try
            {
                ThrowException();

            }
            catch (Exception e)
            {
                Console.WriteLine($"caught an exception:{e.Message}");
            }
            finally
            {
                Console.WriteLine("ater try catch block is complete..");
            }
            Console.WriteLine("program continues..");

             void ThrowException()
            {
                try
                {
                    throw new Exception("an error occured in try block");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"caught an exeption in ThrowException:{ex.Message}");
                    throw;
                }
                finally
                {
                    Console.WriteLine("Excecution of ThrowException is completed");
                }
            }   
        }

        public void MultiCatch()
        {
            // Exception with Multiple catch block

            
            try
            {
                int num = 5;
                int deno = 2; // deno=0
                int res = num / deno;  // it will throw DevideByZeroException
                Console.WriteLine(res);

                String str = "dinu";
                //int a = int.Parse(str); // it will throw FormatException

                int[] id = { 14, 03, 23 };
                Console.WriteLine(id[4]); // it will throw IndexOutRangeException
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine($"Exception Message:{e1.Message}");
            }
            catch (IndexOutOfRangeException e2)
            {
                Console.WriteLine($"acessing array index is greater then array size:{e2.Message}");
            }
            catch (FormatException e3 )
            {
                Console.WriteLine($"assigning difffent type of data:{e3.Message} ");
            }
            catch(Exception e)
            {
                Console.WriteLine($"any other type exceptions:{e.Message}");
            }
            finally
            {
                Console.WriteLine("after try and catch will execute.");
            }
            Console.WriteLine($"program:{1},executed:{2}");
        }

        /*
int[] id = { 14, 03, 23 };

for (int i = 0; i < id.Length; i++)
{
    Console.WriteLine(id[i]);
}
Console.WriteLine(id[4]);
*/

    }
}
