using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction("1","2");
            Fraction f2 = new Fraction("2", "16");
            Fraction f3 = f1 + f2;
            f3.Print();
            f3.Normalizer();
            f3.Print();


            Console.ReadKey();
        }
    }
}
