using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Fraction
    {
        private int numerator; //числитель
        private int denominator; //знаменатель
        

        public Fraction(int a, int b)
        {
            this.numerator = a;
            this.denominator = b;
        }

        public Fraction(string a,string b)
        {
            if (!Int32.TryParse(a, out numerator))
                Console.WriteLine("Неверно передан параметр: числитель");

            if (!Int32.TryParse(b, out denominator))
                Console.WriteLine("Неверно передан параметр: знаменатель");
        }
        
        public void Normalizer()
        {
            int max = Math.Min(numerator, denominator);

            for (int i = max; i > 0; i--)
            {
                if(numerator%i == 0 || denominator % i == 0 )
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                    break;
                }

            }
        }

        public static Fraction operator + (Fraction f1,Fraction f2)
        {
            if (f1.denominator == f2.denominator)
                return new Fraction(f1.numerator + f2.numerator, f1.denominator);
        }

        public void Print()
        {
            Console.WriteLine(numerator + "/" + denominator);           

        }
    }
}
