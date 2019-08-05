using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lembrar que isso e apenas para a linha da nossa grid e noa a classe de uso normal 
            var livroSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
                MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmLivroAutor frm = new frmLivroAutor();
                        frm.LivrosRow = livroSelect;
                        frm.ShowDialog();
                    }
                    break;
            }

            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livros
                ,(int)comboBox1.SelectedValue);
        }
    }
}
