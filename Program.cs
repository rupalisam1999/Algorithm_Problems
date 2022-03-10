using AlgorithmsProblem.Prime_No;
using System;

namespace AlgorithmsProblem
{

    class MySort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Problems!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Prime number in range");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                { 
                     case 1:
                    Console.WriteLine("The prime numbers are : ");
                    PrimeNo primeNum = new PrimeNo();
                    primeNum.FindPrime();
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }



        }
    }
}

