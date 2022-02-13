using System;

namespace Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it? ");
            string day = Console.ReadLine();
            string howToSpendTime;

            //if (day.ToLower().Equals("statuday") || day.ToLower().Equals("sunday"))
            //{
            //    howToSpendTime = "Relax";
            //}
            //else 
            //{
            //    howToSpendTime = "Wok";
            //}

            howToSpendTime = day.ToLower().Equals("saturday") || day.ToLower().Equals("sunday") ? "Relax" : "Work";

            Console.WriteLine($"{howToSpendTime} on {day}");
        }
    }
}
