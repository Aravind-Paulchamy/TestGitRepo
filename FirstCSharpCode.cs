using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace First_c_sharp_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; 
 
           
            Console.WriteLine("Please Enter Your Name");
 
           
            name = Console.ReadLine();
 
            
            Console.WriteLine("Welcome {0}", name);
 
           
            Console.ReadLine();
        }
    }
}