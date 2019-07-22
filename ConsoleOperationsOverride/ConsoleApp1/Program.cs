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
            Teste T = new Teste(5,5);

            T += T;

            var resultado1 = T.A + T.B;

            T++;

            var resultado2 = T.A;
        }
    }

    public class Teste
    {
        public int A { get; set; } = 0;
        public int B { get; set; } = 0;

        public Teste()
        {

        }
        public Teste(int a,int b)
        {
            A = a;
            B = b;
        }
        public static Teste operator +(Teste op1, Teste op2)
        {
            Teste C = new Teste();
            C.A = op1.A * op2.B;
            return C;
        }

        public static Teste operator ++(Teste op1)
        {
            op1.A = op1.A * 2;
            return op1;
        }
    }



}
