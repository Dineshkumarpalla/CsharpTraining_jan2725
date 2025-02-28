using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class EmpExample
    {
        public void ShowEmploy()
        {
            List<Employ> employeeList = new List<Employ>();
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Dinesh";
            employ1.Basic = 350000;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Kumar";
            employ2.Basic = 450000;

            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.Name = "Srikanth";
            employ3.Basic = 250000;

            Employ employ4 = new Employ();
            employ4.Empno = 4;
            employ4.Name = "Narasimha";
            employ4.Basic = 650000;

            employeeList.Add(employ1);
            employeeList.Add(employ2);
            employeeList.Add(employ3);
            employeeList.Add(employ4);

            Console.WriteLine("Employ List  ");
            foreach(Employ employ in employeeList)
            {
                Console.WriteLine($"Employ NO: {employ.Empno} Employ Name:{employ.Name} Employ Salary: {employ.Basic}");

            }

        }
    }
}
