﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    // single cast delegate
    // public delegate void DelegateExample();

    // multicast delegate
    public delegate void delmethod(int x,int y);

    public class DelegateDemo
    {
        //to test single delegate 
            //public static void edu()
            //{
            //    Console.WriteLine("B.Tech{CSE}");
            //}
            //public static void stay()
            //{
            //    Console.WriteLine("Banglore");
            //}
            //public void course()
            //{
            //    Console.WriteLine("Java Full Stack");
            //}

        // to test multi delegate
            public static void add(int x,int y)
            {
                Console.WriteLine("Addition");
                Console.WriteLine(x+y);
            }
            public void sub(int x,int y)
            {
                Console.WriteLine("Subtraction");
                Console.WriteLine(x - y);
            }
    }
}
