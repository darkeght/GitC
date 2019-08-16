using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        public Carro carrosRow;

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro
            {
                Modelo = textBox1.Text,
                Ano = dateTimePicker1.Value,
                Marca = (int)comboBox1.SelectedValue
            };

            this.Close();
        }
    }
}
