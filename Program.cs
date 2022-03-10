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
                Console.WriteLine("2.Bubble Sort");
                Console.WriteLine("3.Permutation Using Recursion");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                { 
                     case 1:
                    Console.WriteLine("The prime numbers are : ");
                    PrimeNo primeNum = new PrimeNo();
                    primeNum.FindPrime();
                    break;

                    case 2:
                        int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                        BubbleSort.BubbleSortInArray(arr1);
                        BubbleSort.PrintArray(arr1);
                        break;

                    case 3:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
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

