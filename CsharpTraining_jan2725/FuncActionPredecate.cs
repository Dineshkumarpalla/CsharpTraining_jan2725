using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public delegate void NewDelegate(int number);
    public class FuncActionPredecate
    {
        public static void PrintNumber(int number)
        {
            Console.WriteLine($"The number is:{number}");
        }
        public static void InvokeDelegate(NewDelegate del, int number)
        {
            del(number);
        }

        public static int Square(int number)
        {
            return number * number;
        }
        public static int PerformOperation(Func<int, int> operation, int number)
        {
            return operation(number);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void PerformOperation(Action<string> operation,string message)
        {
            operation(message);
        }
        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool PerformOperation(Predicate<int>operation,int number)
        {
            return operation(number);
        }
    }
}
