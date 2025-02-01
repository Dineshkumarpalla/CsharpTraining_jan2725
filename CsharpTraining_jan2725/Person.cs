using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class Person
    {
        // 1st way

        //public String Name { get; set; }
        //public override String ToString()
        //{
        //    return "Hello! My name is "+Name;
        //}

        // 2nd way

        String Name;
        public Person(String name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

        ~Person()
        {
            Name = String.Empty;
        }


    }
}
