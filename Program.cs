using System;

namespace PGR521_FA2
{
    class Program
    {
        static void Main(string[] args)
        {
             //This Console App is to show name, icas and project
            
            Console.WriteLine("What is your Name?");
            string Name = Console.ReadLine();
            Console.WriteLine("What project are you working on?");
            string Task = Console.ReadLine();
            Console.WriteLine("What is your icas?");
            string Icas = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(Name + " " + Icas + " " + "is working on" + " " + Task);
        }
    }
}
