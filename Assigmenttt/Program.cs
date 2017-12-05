using System;
using System.Collections.Generic;

namespace Assigmenttt
{
    class Program
    {
        static void Main()
        {
            Address addrs = new Address("Bulgaria", "Sevastaka", "Varna");
            List<int> scores = new List<int> { 6, 6, 6, 5, 4, 5, 6 };
            Student evgeni = new Student("Evgeni", "Nikolov", 21, "123231312", addrs, scores);
            Console.WriteLine(evgeni);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Only full name");
            Console.WriteLine(evgeni.FullName());
            Console.WriteLine("Only full address");
            Console.WriteLine(evgeni.FullAddress());
            Console.WriteLine("Average score");
            Console.WriteLine(evgeni.AverageScore());


            
        }
    }
}
