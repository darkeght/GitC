
using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
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
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
            Session.Id = 9;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carrSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                DataGridViewExample.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex) {
                case 0: {
                        this.carrosTableAdapter.DeleteQuery(carrSelect.Id);
                    } break;
                case 1: {
                        frmEditarCarro editCar = new frmEditarCarro
                        {
                            CarrosRow = carrSelect
                        };

                        editCar.ShowDialog();

                        this.carrosTableAdapter.Update(editCar.CarrosRow);
                    } break;
            }

            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();
            frmUsuarios.ShowDialog();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            Form5 shw = new Form5();
            shw.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Abre o formulario de atualização 
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            //Insert na tabela do banco de dados de carros o novo registro
            if(!string.IsNullOrEmpty(formAdd.carrosRow?.Modelo))
            this.carrosTableAdapter.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza a tabela
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);
        }
    }
}
