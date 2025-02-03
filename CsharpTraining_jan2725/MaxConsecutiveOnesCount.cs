using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class MaxConsecutiveOnesCount
    {
        public int MaxConsecutiveElements(int[] arr,int target)
        {
            int maxCount = 0, currentCount = 0;
            foreach(int num in arr)
            {
                if(num==target)
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }
    }
}
