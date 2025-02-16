using System;
namespace ConsoleApp8

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var random = new Random();
            int randomNamber=random.Next(0,100);

         

            var liczba = 0;
            
            while (true)
            {  
                var namber = int.Parse(Console.ReadLine());
               
                liczba++;
                if (randomNamber > namber) 
                {
                    Console.WriteLine("Podaj większą liczbę");
                    continue;
                }
                
                if (randomNamber < namber)
                {
                    Console.WriteLine("Podaj mniejsząszą liczbę");
                    continue;
                }
                Console.WriteLine("super. wykonano:"+liczba+"prób");
                break;
            }
            
        }

    //    private static int GetNumber()
    //    {
    //        int number =int.Parse(Console.ReadLine());
    //        return number;

    //    }
    }
}
