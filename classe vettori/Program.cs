using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore(6, 3);
            Vettore v2 = new Vettore(4, 6);
            double n = 3;

            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1 * n);
            Console.WriteLine(n * v1);
            Console.WriteLine(v1 + v2);
            Console.WriteLine(+v1);
            Console.WriteLine(v1 - v2);
            Console.WriteLine(-v1);
            Console.WriteLine(v1 / n);
            Console.WriteLine(v1.Modulo());
            if(v1==v2==true)
            {
                Console.WriteLine("sono uguali i due vettori");
            }
            if (v1 != v2 == true)
            {
                Console.WriteLine("sono diversi i due vettori");
            }
            Console.ReadLine();

        }
    }
}
