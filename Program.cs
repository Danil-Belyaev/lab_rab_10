using System;
using System.IO;

namespace lab10
{

    class input
    {
        public static int[,] Input1()
        {
            StreamReader f = new StreamReader("matrix1.txt");
            string s = f.ReadToEnd();
            f.Close();
            string[] M = s.Split('\n');
            string[] N = M[0].Split(' ');
            int[,] a1 = new int[M.Length, N.Length];
            int t;

            for (int i = 0; i < M.Length; i++)
            {
                N = M[i].Split(' ');
                for (int j = 0; j < N.Length; j++)
                {
                    t = Convert.ToInt32(N[j]);
                    a1[i, j] = t;

                }
            }
            return a1;
        }

        public static int[,] Input2()
        {
            StreamReader file2 = new StreamReader("matrix2.txt");
            string s2 = file2.ReadToEnd();
            file2.Close();
            string[] M2 = s2.Split('\n');
            string[] N2 = M2[0].Split(' ');
            int[,] a2 = new int[M2.Length, N2.Length];
            int t2;

            for (int i = 0; i < M2.Length; i++)
            {
                N2 = M2[i].Split(' ');
                for (int j = 0; j < N2.Length; j++)
                {
                    t2 = Convert.ToInt32(N2[j]);
                    a2[i, j] = t2;

                }
            }
            return a2;
        }

    }

    class Matrix
    {

        public static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0} ", a[i, j]);
        }


        public static int[,] Summa(int[,] mas1, int[,] mas2)
        {
            int[,] resMatrix = new int[mas1.Length, mas2.Length];

            for (int i = 0; i < mas2.GetLength(0); i++)
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    resMatrix[i, j] = mas1[i, j] + mas2[i, j];
                    Console.WriteLine($"[{i}] [{j}] == " + resMatrix[i, j] + " ");
                }
            Console.WriteLine();
            return resMatrix;
        }

        public static int[,] Razn(int[,] mas1, int[,] mas2)
        {
            int[,] resMatrix = new int[mas1.Length, mas2.Length];

            for (int i = 0; i < mas2.GetLength(0); i++)
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    resMatrix[i, j] = mas1[i, j] - mas2[i, j];
                    Console.WriteLine($"[{i}] [{j}] == " + resMatrix[i, j] + " ");
                }
            Console.WriteLine();
            return resMatrix;
        }
    }

    class Program
    {
        static void Main()
        {

            try
            {
                int[,] myArray1 = input.Input1();
                Console.WriteLine("Исходный массив 1 :");
                Matrix.Print(myArray1);


                int[,] myArray2 = input.Input2();
                Console.WriteLine("Исходный массив 2 :");
                Matrix.Print(myArray2);

                Console.WriteLine("Сумма элементов матрицы : ");
                Matrix.Summa(myArray1, myArray2);

                Console.WriteLine("Разность элементов матрицы : ");
                Matrix.Razn(myArray1, myArray2);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}

