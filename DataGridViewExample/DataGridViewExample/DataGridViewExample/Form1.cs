using DataGridViewExample.Edicao;
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
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carrSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                DataGridViewExample.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex) {
                case 0: { /*TODO: Deletar*/ }break;
                case 1: {
                        frmEditarCarro editCar = new frmEditarCarro();
                        editCar.CarrosRow = carrSelect;
                        editCar.ShowDialog();


                    } break;
            }


            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }
    }
}
