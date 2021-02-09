using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Masukan angka:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            try
            {
                Console.WriteLine("Bilangan Ganjil");
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Bilangan Genap");
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Bilangan Prima");
               
                for (int i = 1; i <= x; i++)
                {
                    int bilPrima = 0;
                    int sisa = 0;

                    for (int j = 1; j <= i; j++)
                    {
                        sisa = i % j;
                        if (sisa == 0)
                        {
                            bilPrima += 1;
                        }
                        else
                        {
                            bilPrima = bilPrima;
                        }
                    }
                    if (bilPrima > 2)
                    {
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                int n0 = 0;
                int n1 = 1;
                int n2 = 0;

                Console.WriteLine("Bilangan Fibonnaci");
                Console.Write(n2 + " ");
                while ((n0+n1) < 21)
                {
                    n2 = n0 + n1;
                    n0 = n1;
                    n1 = n2;
                    Console.Write(n2 + " ");
                }

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("No.5");
                for (int i = 1; i <= x; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0 )
                    {
                        Console.Write("Metrodata ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Metro ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Data ");
                    } else
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
