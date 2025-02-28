using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public class SwapProgram
    {
        public void Swap<T> (ref T a,ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
    }

}
