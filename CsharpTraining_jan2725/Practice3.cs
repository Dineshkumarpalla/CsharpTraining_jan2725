using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Practice3
    {
        public void showEmploy()
        {
            List<Employ> employs = new List<Employ>();
            Employ e1 = new Employ();
            e1.Empno = 1;
            e1.Name = "Dinesh";
            e1.Basic = 23500;

            Employ e2 = new Employ();
            e2.Empno = 2;
            e2.Name = "Karunakar";
            e2.Basic = 47500;

            Employ e3 = new Employ();
            e3.Empno = 3;
            e3.Name = "Obulesu";
            e3.Basic = 28600;

            employs.Add(e1);
            employs.Add(e2);
            employs.Add(e3);

            Console.WriteLine("Showing Employ list");
            foreach(Employ emp in employs)
            {
                Console.WriteLine($"Employ No: {emp.Empno}, Employ Name: {emp.Name}, Employ Basic: {emp.Basic}");
            }

        }
    }
}
