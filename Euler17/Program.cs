using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberToTextConversion;

namespace Euler17
{
    class Program
    {
        static void Main(string[] args)
        {
            int letterCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                letterCount += NumberTranslator.GetTranslation(i).Replace(" ", "").Length;
            }
            Console.Write(letterCount);
            Console.ReadKey();

        }
    }
}
