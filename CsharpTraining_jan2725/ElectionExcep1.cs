using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class ElectionExcep1
    {
        public void Check(int age)
        {
            if(age<18)
            {
                throw new VotingException("You are not Eligible for voting..");
            }
            Console.WriteLine("You can Vote...");
        }

        public void runExcep()
        {
            int age;
            Console.WriteLine("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            ElectionExcep1 ee1 = new ElectionExcep1();
            try
            {
                ee1.Check(age);
            }
            catch(VotingException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
