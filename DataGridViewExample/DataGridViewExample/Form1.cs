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

namespace DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Aqui setamos os valores dentro do grid com uma query customizada
            this.carrosTableAdapter.CustomQuery(this.innerJoinDbDataSet.Carros);
        }
        /// <summary>
        /// Utilizar o metodo CellContentClick faz com que não precisamos utilizar a validação 
        /// dentro sobre o rowindex, pois ele pega somente o conteudo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Aqui pegamos o carro selecionado
            var carrSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                                      DataGridViewExample.InnerJoinDbDataSet.CarrosRow;

            //Usar o controlador para definir o fluxo da aplicação
            switch (e.ColumnIndex)
            {
                case 0: {
                        //TODO: implementar edição do registro
                        this.carrosTableAdapter.Update(carrSelect);
                    }
                    break;
                case 1: {
                        this.carrosTableAdapter.DeleteQuery(carrSelect.Id);
                        this.carrosTableAdapter.CustomQuery(this.innerJoinDbDataSet.Carros);
                    } break;
                default:
                    break;
            }
        }
    }
}
