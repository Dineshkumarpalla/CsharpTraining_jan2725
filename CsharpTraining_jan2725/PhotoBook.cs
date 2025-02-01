using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public  class PhotoBook
    {
        protected int numPages;
        public int  GetNumberPages()
        {
            return numPages;
        }
        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int pages)
        {
            numPages = pages;
        }
    }
}
