using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Day1
    {
        public static void Check(int n)
        {
            if(n>=0)
                Console.WriteLine("Positive Number..");
            else
                Console.WriteLine("Negative Number..");
        }
        public void posNeg()
        {
            int n;
            Console.WriteLine("Enter 1 no: ");
            n = Convert.ToInt32(Console.ReadLine());
            Day1.Check(n);
        }

        public static void Max3()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c= Convert.ToInt32(Console.ReadLine());
            find(a,b,c);
        }
        public static void find(int a,int b,int c)
        {
            int m = a;
            if (m < b)
                m = b;
            if (m < c)
                m = c;
            Console.WriteLine("Maximun value is: "+m);
        }

        public static void sumSub()
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers..");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Day1 d2 = new Day1();
            d2.sum(a,b);
            d2.sub(a,b);
        }

        public void sum(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is: "+c);
        }
        public void sub(int a,int b)
        {
            int c = a - b;
            Console.WriteLine("Sub is: "+c);
        }
    }
}
