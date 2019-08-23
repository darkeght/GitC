using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Como_UtilizarOref
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastro = "informações do usuario";

            //AtualizaCadastro(ref cadastro);

            cadastro = AtualizaCadastroSemRef(cadastro);

            ImprimeCadastro(cadastro);

            ImprimeCadastro(cadastro);

            Console.ReadKey();
        }

        public static string AtualizaCadastroSemRef(string cadastro)
        {
            cadastro = "Cadastro atualizado com sucesso!";

            return cadastro;
        }

        public static void AtualizaCadastro(ref string cadastro)
        {
            cadastro = "Cadastro atualizado com sucesso!";
        }

        public static void ImprimeCadastro(string cadastro)
        {
            cadastro = "teste";

            Console.WriteLine(cadastro);

            cadastro = "teste referencia";
        }
    }
}
