using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git!");

            if (args[0] == "-help" )
            {
                Console.WriteLine("This is the first app that demonstrates my skills with git and github");
            }
            else
            {
                Console.WriteLine("Hello Git!");
            }
            int a = 2;
            int b = 3;
            Console.WriteLine("a két szám összege: ", a+b );
            Console.WriteLine("a két szám szorzata: ", a*b);
        }
    }
}
