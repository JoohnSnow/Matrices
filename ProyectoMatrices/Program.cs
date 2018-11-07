using System;

namespace ProyectoMatrices
{
    class Program
    {
        private static double[,] M = new double[4, 4];
        static void Main(string[] args)
        {
            //Menu();
            Console.SetWindowSize(170, 43);
            Margen(167,42);
            //Margen(50, 10);
            IngValores(10, 10, 4, 4);

            //DibMatriz(2, 2, 20, 4);

            /*IngValores(3, 3, 4, 3);
            IngValores(4, 4, 4, 10);
            IngValores(8 ,8 , 35, 10);
            
            /*char r = '\u221A';
            char z = '\u02AE';
            Console.WriteLine(z);*/
        }
        static void Menu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(23, 5);
                Console.Write("1.- Operaciones con matrices.");
                Console.SetCursorPosition(23, 6);
                Console.Write("2.- Sistema de ecuaciones lineales.");
                Console.SetCursorPosition(23, 7);
                Console.Write("3.- Matriz traspuesta.");
                Console.SetCursorPosition(23, 8);
                Console.Write("4.- Matriz Inversa.");
                Console.SetCursorPosition(23, 9);
                Console.Write("5.- Salir.");
                Console.SetCursorPosition(26, 4);
                Console.Write("Elija una opción: ");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                           
                        }
                        break;
                    case 2:
                        {
                            
                        }
                        break;
                    case 3:
                        Console.SetCursorPosition(0, 28);
                        break;
                    default:
                        {
                            Console.SetCursorPosition(26, 10);
                            Console.Write("No existe opción.");
                            Console.ReadKey();
                            Menu();
                        }

                        break;
                }
            } while (op != 3);
        }
        static void Margen(int m, int n)
        {
            int i,x=0,y=0;
            Console.SetCursorPosition(x,y);
            Console.Write('╔');
            Console.SetCursorPosition(x+2, y+1);
            Console.Write('╔');
            Console.SetCursorPosition(x, y+n);
            Console.Write('╚');
            Console.SetCursorPosition(x+2, y+n-1);
            Console.Write('╚');
            Console.SetCursorPosition(x+m, y);
            Console.Write('╗');
            Console.SetCursorPosition(x+m-2, y+1);
            Console.Write('╗');
            Console.SetCursorPosition(x+m, y+n);
            Console.Write('╝');
            Console.SetCursorPosition(x+m-2, y+n-1);
            Console.Write('╝');

            for (i = 1; i < m; i++)
            {
                Console.SetCursorPosition(i, y);
                Console.Write('═');
                Console.SetCursorPosition(i, y+n);
                Console.Write('═');
            }
            for (i = 3; i < m-2; i++)
            {
                Console.SetCursorPosition(i, y+1);
                Console.Write('═');
                Console.SetCursorPosition(i, y+n-1);
                Console.Write('═');
            }
            for (i = 1; i < n; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('║');
                Console.SetCursorPosition(x+m, i);
                Console.Write('║');
            }
            for (i = 2; i < n-1; i++)
            {
                Console.SetCursorPosition(x+2, i);
                Console.Write('║');
                Console.SetCursorPosition(x+m-2, i);
                Console.Write('║');
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        static void CasillaMatriz(int m,int n,int x, int y)
        {
            int a=7, b=2, i;
            a = a * m;
            b = b * n;
            Console.SetCursorPosition(x, y);
            Console.Write('╔');
            Console.SetCursorPosition(x, y+b);
            Console.Write('╚');
            Console.SetCursorPosition(x+a, y);
            Console.Write('╗');
            Console.SetCursorPosition(x+a, y+b);
            Console.Write('╝');
            for (i = y+1; i < y+b; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write('║');
                Console.SetCursorPosition(x+a, i);
                Console.Write('║');
            }
            Console.SetCursorPosition(0,29);
            //Console.Write();
        }
        static void AFraccion(double num)
        {
            double a=1, b=1, r=1;
            string n = "";
            if (num < 0)
            {
                num = -1 * num;
                while (!(r == num))
                {
                    r = a / b;
                    if (r < num) a++;
                    else
                    {
                        if (r > num)
                        {
                            a--;
                            b++;
                        }
                    }
                }
                num = num * -1;
                a = a * -1;
            }
            else
            { 
                while (!(r == num))
                {
                    r = a / b;
                    if (r < num) a++;
                    else
                    {
                        if (r > num)
                        {
                            a--;
                            b++;
                        }
                    }
                }
            }
            n = $"{a}/{b}";
            if (b > 1)
            {
                if (n.Length <= 6)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(Math.Truncate(num * 100) / 100);
                }

            }
            else Console.WriteLine(num);
        }
        static void IngValores(int m,int n,int x,int y)
        {
            int i,j=0,a=1,b=1;
            double[,] A = new double[m,n];
            CasillaMatriz(m, n, x, y);
            for (j=0;j<n;j++)
            {
                for (i=0;i<m;i++)
                {
                    Console.SetCursorPosition(x+a, y+b);
                    A[i, j] = double.Parse(Console.ReadLine());
                    M[i, j] = A[i, j];
                    a += 7;
                }
                a = 1;
                b += 2;
            }
            
        }
        static void DibMatriz(int m, int n, int x, int y)
        {
            int i, j = 0, a = 1, b = 1;
            CasillaMatriz(m, n, x, y);

            for (j = 0; j < n; j++)
            {
                for (i = 0; i < m; i++)
                {
                    Console.SetCursorPosition(x + a, y + b);
                    Console.Write(M[i, j]);
                    a += 7;
                }
                a = 1;
                b += 2;
            }
            Console.SetCursorPosition(3, 30);
        }
    }
}
