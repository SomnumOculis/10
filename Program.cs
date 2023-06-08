using System;
using System.Linq;
namespace blokcxema.zadacha_10.sem2
{
    class Program
    {
           static Random rand = new Random();
           static int[] array = new int[20];
        static void Main()
        {
            int a, i;
            GenerateArray();
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0,3}", i);
            }
            Console.WriteLine();
            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(" Повторить ввод данных? ( 1-yes, 0-no ): ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1) { Main(); }
            return;
        }
        static void GenerateArray()
        {
             for  (int i = 0; i < array.Length; i++)
            {
   
                for ( i = 0; i < array.Length; i++)
                {
                    while (true)
                    {
                        array[i] = rand.Next(0, 20);
                        if (!array.Take(i).Contains(array[i])) break;
                    }
                }
            
            }
            
        }
    }
 }

