using System;
using System.Collections.Generic;
namespace MasteryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor Doctor = new Doctor("Don", "0001", "Gastroenterology");
            Nurse Nurse = new Nurse("Kathy", "0002", 1);
            Receptionist Receptionist = new Receptionist("Yolanda", "0003", false);
            Janitor Janitor = new Janitor("Dingus", "0004", false);

            Console.WriteLine("Hello!  What would you like to do?");

        }
    }
}
