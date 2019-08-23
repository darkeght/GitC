using ClassesEscola.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();

            cad.inserir();
            Console.Clear();
            cad.listar();

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Informe registro que deseja excluir");
            int.TryParse(Console.ReadLine(), out int reg);

            cad.alterar(reg);
            cad.listar();

            Console.ReadKey();

        }
    }
}
