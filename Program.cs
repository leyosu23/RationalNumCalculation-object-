using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Name: Yoonseop Lee
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2, num2 = 3, num3 = 7;

            Rational r1 = new Rational(num1, num2);
            Rational r2 = new Rational(num2, num1);
            Rational r3 = new Rational(num1, num3);
            Rational r4 = new Rational(num2, num3);
            //others
            Rational r5 = new Rational(num1, num1);
            Rational r6 = new Rational(num2, num2);
            Rational r7 = new Rational(num3, num3);
            Rational r8 = new Rational(num3, num1);

            Console.Write($"{r1} + {r5} is ");
            r1.IncreaseBy(r5);
            Console.WriteLine(r1);

            Console.Write($"{r2} + {r6} is ");
            r2.IncreaseBy(r6);
            Console.WriteLine(r2);


            Console.Write($"{r3} - {r7} is ");
            r3.DecreaseBy(r7);
            Console.WriteLine(r3);

            Console.Write($"{r4} - {r8} is ");
            r4.DecreaseBy(r8);
            Console.WriteLine(r8);



        }
    }
}
