using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar idade:");

            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem barba? Sim(1) | Não(0):");

            var barba = int.Parse(Console.ReadLine());

            if (idade >= 18 || barba == 1)
            {
                Console.WriteLine("Ambev aprova ");
            }
            else
            {
                Console.WriteLine("Vishhhhh");
            }

            Console.ReadKey();
        }
    }
}
