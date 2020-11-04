using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Recursion(Özyineleme) ile Faktöriyel hesabı
            Console.WriteLine("Kaç faktöriyel alınsın?");
            int a = Convert.ToInt32(Console.ReadLine());
            int fakt(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else return n * fakt(n - 1);
            }
            Console.WriteLine("Faktöriyelin sonucu= " + fakt(a));

            //// Recursion(Özyineleme) ile Fibonacci hesabı
            Console.WriteLine("Kaç adet fibonacci sayısını ekrana yazdırılsın?");
            int b = Convert.ToInt32(Console.ReadLine());

            int fibo(int m)
            {
                if (m == 1 || m == 0)
                {
                    return m;
                }

                else
                {
                    return m = fibo(m - 1) + fibo(m - 2);

                }

            }
            Console.WriteLine(fibo(b));

            //// Collatz hesabı

            Console.WriteLine("Collatz Sayısını giriniz.");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(coll(c));
            int coll(int n)
            {
                if (n == 1)
                {
                    return 0;
                }
                else
                {


                    if (n % 2 == 0)
                    {
                        return 1 + coll(n / 2);
                    }
                    else
                    {
                        return 1 + coll(3 * n + 1);
                    }




                }




            }
            Console.ReadKey();
        }
    }
}
