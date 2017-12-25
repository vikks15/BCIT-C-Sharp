using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {

        delegate double PlusOrMinus(double a, int b);

        static void PlusOrMinusMethod(string str, double a, int b, PlusOrMinus ProsCons)
        {
            double result = ProsCons(a, b);
            Console.WriteLine(str + result);
        }

       
        static double Plus (double a, int b) //correspond to delegate
        {
            return a + b;
        }

        static double Minus(double a, int b) //correspond to delegate
        {
            return a - b;
        }

        static void PlusOrMinusMethod2(string str, double a, int b, Func <double, int, double> ProsCons) //generalized delegate Func - announce in method
        {
            double result = ProsCons(a, b);
            Console.WriteLine(str + result);
        }

        static void Main(string[] args)
        {
            double a = 3.14;
            int b = 5;
            PlusOrMinusMethod("Plus: ", a, b, Plus);
            PlusOrMinusMethod("Minus: ", a, b, Minus);

            //---------------------lambda expressions-------------------------------------------
            PlusOrMinusMethod("Plus with long lambda expression: ", a, b, (double c, int d)=>
            {
            double res = c + d;
            return res;
            });

            PlusOrMinusMethod("Minus with short lambda expression: ", a, b, (c, d) => c-d);
            //----------------------------------------------------------------------------------

            PlusOrMinusMethod2("Plus. Delegate Func<> (Method Plus): ", a, b, Plus);
            PlusOrMinusMethod2("Minus. Delegate Func<> (lambda expression): ", a, b, (c, d) => c - d);
            Console.ReadKey();
        }
 
    }
}
