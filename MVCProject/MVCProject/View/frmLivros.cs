﻿using MVCProject.View.FormsAdicionar;
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
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livrosSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {

                    }
                    break;

                case 1:
                    {

                    }
                    break;
            }

            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Livros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLivro formAdd = new frmAdicionarLivro();
            formAdd.ShowDialog();

            this.livrosTableAdapter.Insert(
                formAdd.livro.Registro,
                formAdd.livro.Titulo,
                formAdd.livro.Isbn,
                formAdd.livro.Genero,
                formAdd.livro.Editora,
                formAdd.livro.Sinopse,
                formAdd.livro.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
        }
    }
}
