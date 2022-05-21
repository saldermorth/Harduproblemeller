using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemlösning
{
    internal class Svårare
    {
        /*
This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. Here, you must generate your own function to satisfy the relationship between the inputs and outputs.

Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

Examples
832 ➞ 594

51 ➞ 36

7977 ➞ 198

1 ➞ 0

665 ➞ 99

149 ➞ 0
*/
        public void dataSender()
        {
            int[] input = { 832, 51, 7977, 1, 665, 149 };

            int[] output = { 594, 36, 198, 0, 99, 0 };
            makeItSO(665);
        }

        public int makeItSO(int input)//klarar av 832, 1 och 149
        {
            string numberInString = Convert.ToString(input);

            if (numberInString.StartsWith("1"))
            {
                return 0;
            }
            char[] numberInChar = numberInString.ToCharArray();
            int num3 = Convert.ToInt32(numberInChar[numberInChar.Length - 1].ToString()); //2
            int num2 = Convert.ToInt32(numberInChar[numberInChar.Length - 2].ToString()); //3
            int num1 = Convert.ToInt32(numberInChar[numberInChar.Length - 3].ToString()); //8




            int lastNumber = num1 - (num3 + num3); // 3
            int secondToLastNumber = ((num2 - num3) + num1); //9 correct
            int thirdToLastNumber = num2 + num3;// 5 correct


            Console.WriteLine(thirdToLastNumber + "" + secondToLastNumber + "" + lastNumber);
            Console.ReadKey();


            return 0;
        }
    }
}
