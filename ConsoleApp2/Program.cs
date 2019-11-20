using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //_________________ПЕРВОЕ ЗАДАНИЕ________________________________
            Fraction f1 = new Fraction("0","0");
            Fraction f2 = new Fraction("18", "9");
            Fraction f3 = f1 - f2;
            f3.Print();
            f3.Normalizer();
            f3.Print();
            //_______________________________________________________________


            //______________________Второе задание___________________________
            string readPath = @"C:\Users\nbykov\source\repos\Keys\ConsoleApp2\input.txt";
            string writePath = @"C:\Users\nbykov\source\repos\Keys\ConsoleApp2\output.txt";
            string inputStr ;

            using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
            {
                inputStr = sr.ReadLine();
            }
            

                       
            int n = Int32.Parse(inputStr.Split()[0]);
            int m = Int32.Parse(inputStr.Split()[1]);

            //Console.WriteLine(binominal(m-1,n-1));

            using (StreamWriter sr = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sr.WriteLine(binominal(m-1,n-1).ToString());
            }

            Console.ReadKey();
        }


        public static int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public static int binominal(int n,int m)
        {
            return factorial(n) / factorial(m) / factorial(n - m);
        }
    }

}
