using DataGridViewExample.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVendas frmVendas = new frmAdicionarVendas();
            frmVendas.ShowDialog();

            if(frmVendas.venda?.Carro > 0 
                && frmVendas.venda?.Valor > 0)
            this.vendasTableAdapter.Insert(
                frmVendas.venda.Carro,
                frmVendas.venda.Quantidade,
                frmVendas.venda.Valor,
                frmVendas.venda.Ativo,
                1,
                1,
                frmVendas.venda.DatInc,
                frmVendas.venda.DatAlt
                );
        }
    }
}
