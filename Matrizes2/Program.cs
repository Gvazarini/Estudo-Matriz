using System;
using System.Collections.Generic;
using System.Globalization;
namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');    
            int M = int.Parse(line[0]);
            int N = int.Parse(line[1]);
            int [,] m = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < values.Length; j++)
                {
                    m [i, j] = int.Parse(values [j]);
                }
            }
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    if(m [i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left, " + m[i , j - 1]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right, " + m[ i, j+1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up, " + m[i - 1, j]);
                        }
                        if (i < N - 1)
                        {
                            Console.WriteLine("Down, " + m[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}


    
    
    