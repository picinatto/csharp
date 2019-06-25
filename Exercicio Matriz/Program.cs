using System;

namespace Exercicio_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] baseMatriz = Console.ReadLine().Split(' ');

            int n = int.Parse(baseMatriz[0]);
            int m = int.Parse(baseMatriz[1]);


            int[,] matriz = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                } 
            }

            int searchNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if(matriz[i,j] == searchNumber)
                    {
                        Console.WriteLine("Position " + i + "," + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
