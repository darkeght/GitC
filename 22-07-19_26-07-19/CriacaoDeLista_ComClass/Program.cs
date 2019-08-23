using CriacaoDeLista_ComClass.BibliotecaList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_ComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var listView = new ListViewCustom();

            listView.MostrarLista();

            listView.LimparLista();

            listView.MudarTamanho(50);

            listView.CarregaLista();

            listView.MostrarLista();
        }
    }
}
