using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new GetFiles();

            var arquivos = teste.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < arquivos.Length; i++)
            {
                Console.WriteLine(arquivos[i]);
            }

            var arquivosImage = teste.RetornaArquivosImagesFiles();

            for (int i = 0; i < arquivosImage.Length; i++)
            {
                Console.WriteLine(arquivosImage[i]);
            }


            var arquivosDoGit = teste.RetornaArquivosGit();

            for (int i = 0; i < arquivosDoGit.Length; i++)
            {
                Console.WriteLine(arquivosDoGit[i]);
            }

            Console.ReadKey();
        }
    }
}
