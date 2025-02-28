using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class ListExample
    {
        public void ShowNames()
        {
            List<string> names = new List<string>();
            names.Add("Diensh");
            names.Add("Nanda");
            names.Add("Nagaraju");
            names.Add("Hymavathi");

            foreach(string Names in names)
            {
                Console.Write(Names+" ");
            }

        }
    }
}
