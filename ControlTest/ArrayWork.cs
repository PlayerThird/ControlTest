using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlTest
{
    internal class ArrayWork
    {
        internal static string[] Filter(string[] arrOne)
        {
            string[] arrTwo = new string[arrOne.GetLength(0)];
            

            int j = 0;
            for (int i = 0; i < arrOne.GetLength(0); i++)
            {

                if (arrOne[i].Length < 4)
                {
                    foreach (var item in arrOne[i])
                    {
                        arrTwo[j] += Convert.ToString(item);
                    }
                    j++;
                }
                
            }
            return arrTwo;
        }
        //Печать массива типа string
        internal static void PrintMass(string text, string[] mass)
        {
            Console.Write(text + " ");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }
            Console.WriteLine();
        }
    }
}
