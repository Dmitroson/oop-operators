using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionLibrary;

namespace ConsoleDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(10, 5);
            Fraction b = new Fraction(3, 5);
            Fraction c = new Fraction(4);
            Fraction d = new Fraction();
            Fraction f = new Fraction(1.778);

            Fraction result = 2 * ((-a) + b - c) / (a++) / 2 + f;
            Console.WriteLine(result);
            Console.WriteLine();

            Fraction aa = new Fraction(10, 5);
            if (aa == b)
            {
                Console.WriteLine("==\n");
            }
            
            if(aa != b)
            {
                Console.WriteLine("!=\n");
            }

            if (aa > b)
            {
                Console.WriteLine(">\n");
            }

            if (aa < b)
            {
                Console.WriteLine("<\n");
            }

            if (aa >= b)
            {
                Console.WriteLine(">=\n");
            }

            if (aa <= b)
            {
                Console.WriteLine("<=\n");
            }

            Console.ReadKey();
        }
    }
}
