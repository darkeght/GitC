using CriacaoDeLista_ComClass.BibliotecaList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoNossaBibliotecaDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var listView = new ListViewCustom();

            listView.MostrarLista();

            listView.LimparLista();

            listView.CarregaLista();

            listView.MostrarLista();

        }
    }
}
