using System;
using System.Collections.Generic;

namespace ConsoleLottery
{

    class Program
    {
        
        private static bool IsDup(string tmp, List<string> arr)
        {
            foreach (var item in arr)
            {
                if (item == tmp)
                {
                    return true;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
                 
            //User Input
            List<string> lista1 = new List<string>();
            for (int i = 1; i <= 7; i++)
            {
                try
                {
                    Console.Write("Enter string for raffle {0}: ", i);
                    string x = Console.ReadLine();

                    if (IsDup(x, lista1))
                    {
                        Console.WriteLine("The input string already exist");
                        i--;
                    }
                    else
                    {
                        lista1.Add(x);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The input string already exist");
                    Console.WriteLine("Error: {0}", ex.Message);
                    i--;
                }
            }

            for(int j = lista1.Count; j > 0 ; j--)
            {
                Random rnd = new Random();
                string value = lista1[rnd.Next(0, j)];
                Console.WriteLine("Pick Random string: {0}", value);

                lista1.Remove(value);
            }
            

            //Console.WriteLine("\nChoosen Numbers are: ");
            //foreach (int item in lista1)
            //{
            //    Console.WriteLine(item);
            //}

            ////Random Number Generator
            //Console.WriteLine("Random Numbers are: ");
            //InitArray();
            Console.ReadLine();
        }
    }
}
