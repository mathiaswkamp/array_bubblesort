using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            // opgave 1 a
            int[] arr = new int[100];
            // opgave 3 a
            Random randomNumber = new Random();
            int temp;
            // Opgave 2 a

            for (int i = 0; i < arr.Length; i++)
            {
                // opgave 4 a
                int nummer = randomNumber.Next(0, 1000); // tildeler variablen en random værdi mellem 0 - 1000
                                                         // opgave 5 a
                arr[i] = nummer; // tildeler pladserne i arrayet en værdi
            }
            // opgave 2 b
            for (int j = 0; j <= arr.Length; j++) // looper igennem
            {
                // opgave 3 b
                for (int k = 0; k < (arr.Length - 1); k++) // looper igennem
                {
                    if (arr[k] > arr[k + 1]) // hvis første plads i arrayet er større end næste plads
                    {
                        temp = arr[k + 1]; // læg værdien over i temp variablen
                        arr[k + 1] = arr[k]; // næste array plads
                        arr[k] = temp; // smid tallet over på array pladsen 


                    }

                }
            }

            // opgave C
            Array.Reverse(arr); // reverser række følgen
            Console.WriteLine("Sorteret:");
            //opgave 4 b
            foreach (int p in arr) // udskriver arrayet sorteret
                Console.Write(p + " ");
            Console.ReadKey();

        }
    
    }
}
