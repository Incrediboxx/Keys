using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FractionTest<someType>
    {
        private long numerator; //числитель
        private long denominator; //знаменатель        

        public FractionTest(someType a, someType b)
        {
            long aa;
            double dd;
                                             
            if (double.TryParse(a.ToString(), out dd))
                numerator = (long)dd; //Можно заменить на Convert но будет добавляться 1 если остаток больше 0.5
            else
            {
                Console.WriteLine("Неверно передан параметр: числитель");
                return;
            }           

            if (double.TryParse(b.ToString(), out dd))
            {
                aa = (long)dd;
                if (aa != 0) //Можно заменить на Convert но будет добавляться 1 если остаток больше 0.5
                    denominator = aa;
                else
                {
                    this.denominator = 1;
                    Console.WriteLine("В качестве знаменателя передан 0, автоматически заменено на 1");
                    Console.WriteLine("Итог: " + numerator + "/" + denominator);
                }
            }
            else
            {
                Console.WriteLine("Неверно передан параметр: знаменатель");
                return;
            }            
        }       

        public void Normalizer()
        {
            long max = Math.Min(Math.Abs(numerator), Math.Abs(denominator));

            for (long i = max; i > 0; i--)
            {
                if (numerator % i == 0 & denominator % i == 0)
                {
                    numerator = numerator / i;
                    denominator = denominator / i;
                    break;
                }

            }
        }
         

        public void Print()
        {
            Console.WriteLine(numerator + "/" + denominator);
        }
    }
}
