using MVCProject.View.FormsAdicionar;
using MVCProject.View.FormsEditar;
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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }

        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacoes' table. You can move, or remove it, as needed.
            this.locacoesTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Locacoes);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacoesSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.LocacoesRow;

            switch (e.ColumnIndex)
            {
                case 1:
                    {
                        frmEditarLocacao editarLocacao = new frmEditarLocacao();
                        editarLocacao.locacoesRow = locacoesSelect;
                        editarLocacao.ShowDialog();

                        this.locacoesTableAdapter.Update(editarLocacao.locacoesRow);
                    }
                    break;

                case 2:
                    {
                        this.locacoesTableAdapter.DeleteQuery(locacoesSelect.Id);
                    }
                    break;
            }

            this.locacoesTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Locacoes);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao formAdd = new frmAdicionarLocacao();
            formAdd.ShowDialog();

            this.locacoesTableAdapter.Insert(
                formAdd.locacao.Livro,
                formAdd.locacao.Usuario,
                formAdd.locacao.Tipo,
                formAdd.locacao.Devolucao,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.locacoesTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Locacoes);
        }
    }
}
