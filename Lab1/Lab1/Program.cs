using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* System.Console.WriteLine("Heyyyy!");
            int n = 0;
            int m =int.Parse(Console.ReadLine());
            bool u = int.TryParse(Console.ReadLine(), out n);
            char f = Convert.ToChar('p');
            System.Console.WriteLine(m + " " + n + " " + f);*/
            while (true)
            {
                System.Console.WriteLine("Введите коэффициенты A, B, C: ");
                double A, B, C, D, x1, x2, res;
                bool A_bool, B_bool, C_bool;

                do
                {
                    A_bool = double.TryParse(System.Console.ReadLine(), out A);
                    B_bool = double.TryParse(System.Console.ReadLine(), out B);
                    C_bool = double.TryParse(System.Console.ReadLine(), out C);
                }
                while (A_bool == false | B_bool == false | C_bool == false | A == 0);


                // System.Console.WriteLine(A + " " + B + " " + C);
                D = B * B - 4 * A * C;
                if (D == 0)
                {
                    res = -B / 2 * A;
                    System.Console.WriteLine("Ответ: x = " + res);
                }
                else if (D > 0)
                {
                    double sqrtD = Math.Sqrt(D);
                    x1 = (-B + sqrtD) / (2 * A);
                    x2 = (-B - sqrtD) / (2 * A);
                    System.Console.WriteLine("Ответ: x1=" + x1 + " x2=" + x2);

                }
                else
                {
                    System.Console.WriteLine("D<0, корней нет");
                }

            }
           // System.Console.ReadKey();

        }
    }
}
