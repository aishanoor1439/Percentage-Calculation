using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your roll no:");
            int roll_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the marks of COMPUTER FUNDAMENTALS out of 100:");
            double cf = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the marks of COMPUTER PROGRAMMING out of 100:");
            double cp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the marks of APPLIED PHYSICS out of 100:");
            double ap = Convert.ToDouble(Console.ReadLine());
            double total_marks = Convert.ToDouble(cf+cp+ap);
            double percentage = Convert.ToDouble((total_marks/300)*100);
            Console.WriteLine("Dear " + name + "! You have scored " + percentage + "% " + "with " + total_marks + " marks.");
        }
    }
}
