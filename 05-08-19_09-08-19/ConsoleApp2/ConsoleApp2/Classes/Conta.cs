using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    public abstract class Conta
    {
        public abstract double Saldo { get; set; }
        public abstract void Sacar(double valor);
    }
}
