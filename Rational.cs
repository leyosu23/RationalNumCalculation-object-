using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Name: Abdul Moeed Saqib
// Student ID: 301004138
// Name: Yoonseop Lee
// Student ID: 301037418
namespace Assignment1
{
    class Rational
    {
        // constructor
        public Rational(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void IncreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator + Denominator * other.Numerator;
            Denominator *= other.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator - Denominator * other.Numerator;
            Denominator *= other.Denominator;
        }

        // property
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";

        }
    }
}
