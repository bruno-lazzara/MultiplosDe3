using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioMultiplosDe3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = 1;
            while (numero <= 100)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }

            Console.WriteLine();
            // OU...

            for (int numero2 = 1; numero2 <= 100; numero2++)
            {
                if (numero2 % 3 == 0)
                    Console.WriteLine(numero2);
            }

            Console.ReadLine();
        }
    }
}
