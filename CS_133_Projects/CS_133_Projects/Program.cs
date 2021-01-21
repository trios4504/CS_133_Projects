using System;

namespace CS_133_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[10, 10];
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    myArray[x, y] = (x + 1) * (y + 1);
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(myArray[x, y] + " ");
                }

                Console.WriteLine("");
            }

        }
    }
}
