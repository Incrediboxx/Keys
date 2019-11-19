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
            if (b != 0)
                this.denominator = b;
            else
            {
                this.denominator = 1;
                Console.WriteLine("В качестве знаменателя передан 0, автоматически заменено на 1");                
                Console.WriteLine("Итог: " + numerator + "/" + denominator);
            }
        }

        public Fraction(string a,string b)
        {
            int aa;
            if (!Int32.TryParse(b, out aa))
                Console.WriteLine("Неверно передан параметр: знаменатель");
            else 
                if (aa != 0)
                {                    
                    denominator = aa;
                }
                else
                {                    
                    this.denominator = 1;
                    Console.WriteLine("В качестве знаменателя передан 0, автоматически заменено на 1");
                    Console.WriteLine("Итог: " + numerator + "/" + denominator);
                }

            if (!Int32.TryParse(a, out numerator))
                Console.WriteLine("Неверно передан параметр: числитель");

           /* if (!Int32.TryParse(b, out denominator))
                Console.WriteLine("Неверно передан параметр: знаменатель");*/
        }
        
        public void Normalizer()
        {
            int max = Math.Min(Math.Abs(numerator), Math.Abs(denominator));

            for (int i = max; i > 0; i--)
            {
                if(numerator%i == 0 & denominator % i == 0 )
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
            else
                if (f1.denominator > f2.denominator)
                    if (f1.denominator % f2.denominator == 0)
                        return new Fraction(f1.numerator + f2.numerator * (f1.denominator / f2.denominator), f1.denominator);
                    else
                        return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
                else
                    if (f2.denominator % f1.denominator == 0)
                        return new Fraction(f1.numerator * (f2.denominator / f1.denominator) + f2.numerator, f2.denominator);
                    else
                        return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }

        public static Fraction operator - (Fraction f1, Fraction f2)
        {
            if (f1.denominator == f2.denominator)
                return new Fraction(f1.numerator - f2.numerator, f1.denominator);
            else
                if (f1.denominator > f2.denominator)
                if (f1.denominator % f2.denominator == 0)
                    return new Fraction(f1.numerator - f2.numerator * (f1.denominator / f2.denominator), f1.denominator);
                else
                    return new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
            else
                    if (f2.denominator % f1.denominator == 0)
                return new Fraction(f1.numerator * (f2.denominator / f1.denominator) - f2.numerator, f2.denominator);
            else
                return new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }

        public static Fraction operator * (Fraction f1,Fraction f2)
        {
            return new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
        }

        public void Print()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }
    }
}
