using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemlösning
{
    internal class Mellan
    {
        //Given an array of integers and a value, determine if there are any two integers in the array whose sum is equal to the given value.

        public void CheckArray()
        {

            int theOne = 36;
            int[] matrix = { 12, 432552, 122, 31, 23, 123, 124, 4, 2, 2, 34, 234 };


            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if ((matrix[i] + matrix[j]) == theOne)
                    {
                        Console.WriteLine($"Number {theOne} is the same as {matrix[i]} + {matrix[j]} combined  ");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
