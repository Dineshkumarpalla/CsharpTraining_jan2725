using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public delegate void MyDelegate3(string str);
    public  class DelegateExample
    {
        public  void Greeting(string name)
        {
            Console.WriteLine("Good Morning: "+name);
        }
        public  void Course(string arg)
        {
            Console.WriteLine("My Course is: "+arg);
        }
        public static void EndDate(string end)
        {
            Console.WriteLine("My exam date is: "+end);
        }

        

    }
}
