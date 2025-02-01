using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    internal abstract class Animal
    {
        String Name;
        public void SetName(String Name)
        {
            this.Name = Name;
        }
        public String GetName()
        {
            return Name;
        }
        public abstract void Eat();
        
    }
}
