using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harduproblemeller._25_Maj2022.Gustav
{
    internal class gustavoisgod
    {

        // Rotera matrixen 90 grader medurs
        public void The()
        {
            int[,] matrix =
           {{1,2,3,4,5},
            {6,7,8,9,1},
            {2,3,4,5,6},
            {7,8,9,1,2},
            {3,4,5,6,7}};

            // position 0,0 x + 5
            // position 0,1 x + 4 , y + 1
            // position 0,2 x + 3 , y + 2
            // position 0,3 x + 2 , y + 3
            // position 0,4 x + 1 , y + 4
            // position 0,5 x + 0 , y + 5

            int[,] newMatrix =
            {{1,2,3,4,5},
            {6,7,8,9,1},
            {2,3,4,5,6},
            {7,8,9,1,2},
            {3,4,5,6,7}};


            for (int i = 0; i < 5; i++)
            {
                // Kola över vart vi vill ha x och y initieringarna
                //går utum bounds i array
                int x = 4;
                int y = 0;

                for (int j = 0; j < 5; j++)
                {
                    newMatrix[i + x, j - y] = matrix[i, j];
                    Console.WriteLine(matrix[i, j]);
                    Console.WriteLine(newMatrix[i + x, j - y]);
                    y++;
                    x--;
                }


            }



            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    Console.Write(newMatrix[i, j] + ",");

                }
                Console.Write("\n");

            }



        }

    }
}
