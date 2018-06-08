using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_DFDaCSharp
{
    class Program
    {
        /*6. Ejercicios de matrices: Cuadro mágico. 

         * Imprimir cómo se llena el cuadro y la suma de las filas, columnas y diagonales. 

         NOTA: Se puede utilizar cualquier función necesaria de C#.
        */
        static void Main(string[] args)
        {

            Console.Title = "CUADRO MÁGICO"; //lo que aparecerá en la barra superior de la ventana
            Console.SetWindowSize(75, 35); //establece columnas y filas

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            int dimension = 5, n = 1;
            int[,] matriz = new int[dimension, dimension];
            int i = 0;
            int j = dimension / 2;
            int k = 0, l = 0;
            int[] Filas = new int[dimension];
            int[] Columnas = new int[dimension];

            matriz[i, j] = n++;

            for (k = i, l = j; n <= dimension * dimension; n++)
            {
                i--;
                j++;

                if (i < 0)
                    i = dimension - 1;
                if (j >= dimension)
                    j = 0;

                if (matriz[i, j] == 0)
                {
                    matriz[i, j] = n;
                }
                else
                {
                    k++;
                    if (k >= dimension)
                        k = 0;
                    matriz[k, l] = n;
                    i = k;
                    j = l;
                    continue;
                }
                k = i;
                l = j;
            }
            Console.WriteLine("                                                                           ");
            for (i = 0; i < dimension; i++)
            {
                for (j = 0; j < dimension; j++)
                {
                    Console.Write("     {0}", matriz[i, j].ToString("###"));
                }
                Console.WriteLine(Environment.NewLine);
            }
            for (i = 0; i < dimension; i++)
            {
                for (j = 0; j < dimension; j++)
                {
                    Filas[i] += matriz[i, j];
                    Columnas[j] += matriz[i, j];
                }
            }
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            //Console.Clear();
            Console.WriteLine(" _________________________________________________________________________ ");
            Console.WriteLine("|                                                                         |");
            for (i = 0; i < dimension; i++)
            {
                Console.WriteLine("                   Suma de la fila [{0}] es: {1}                                  ", i, Filas[i]);                
                Console.WriteLine("                   Suma de la columna [{0}] es: {1}                               ", i, Columnas[i]);
                Console.WriteLine("                                                                                  ");
            }
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine("                                                                           ");
            Console.ReadKey();
        }
    }
}