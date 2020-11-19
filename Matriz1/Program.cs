using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a ordem da matriz: "); // Definir a ordem da matriz
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++) // Colocar os valores dentro da matriz
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Valor [" + i + ", " + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int negative = 0;
            Console.Write("A diagonal principal é: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) // Imprime os valores da diagonal
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                    if (mat[i, j] < 0) // Imprime valores negativos
                    {
                        negative++;
                    }
                }
            }
            Console.Write("\nOs números Negativos são: " + negative);
            Console.ReadKey();
        }
    }
}
