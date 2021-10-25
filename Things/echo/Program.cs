/*
 Dyson Smith
 Oct 1 2021
 Echo Echo progect
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI!! I'm Echo wats your name?");
            String name = Console.ReadLine();// getting and storing their answer in a variable
            Console.WriteLine("Your looken nice today "+name);
            Console.ReadLine();
        }
    }
}
