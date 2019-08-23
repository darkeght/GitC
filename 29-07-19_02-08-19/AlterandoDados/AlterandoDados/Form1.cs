using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlterandoDados
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

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var collEdit = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                var datCollSelect = collEdit.OwningColumn.DataPropertyName;

                switch (datCollSelect)
                {
                    case "DatInc": {
                            if(DateTime.Parse(collEdit.Value.ToString()) <= DateTime.Now)
                            {
                                this.carrosBindingSource.EndEdit();
                                this.carrosTableAdapter.Update(this.querysInnerJoinDataSet.Carros);
                            }
                        } break;
                }
            }
        }
    }
}
