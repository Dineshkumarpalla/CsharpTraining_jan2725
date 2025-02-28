using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class Practice2
    {
        public void ShowNames()
        {
            List<string>  friends= new List<string>();
            friends.Add("Dinesh");
            friends.Add("Narasimha");
            friends.Add("Srinath");
            friends.Add("SreeKrishna");

            Console.WriteLine("Showing friends List");
            foreach (string fnd in friends)
            {
                Console.WriteLine(fnd);
            }
        }

    }
}
