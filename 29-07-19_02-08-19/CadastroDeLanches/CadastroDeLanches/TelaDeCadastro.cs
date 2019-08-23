using CadastroDeLanches.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeLanches
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Lanche novoLanche = new Lanche();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoLanche.Nome = tbxNome.Text;
            novoLanche.Quantidade = (int)nrQuant.Value;
            novoLanche.Valor = double.Parse(tbxValor.Text);

            this.Close();
        }
    }
}
