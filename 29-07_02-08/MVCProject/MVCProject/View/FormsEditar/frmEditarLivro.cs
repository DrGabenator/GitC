using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsEditar
{
    public partial class frmEditarLivro : Form
    {
        public frmEditarLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LivrosRow livrosRow;

        private void FrmEditarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

            textBox1.Text = livrosRow.Registro.ToString();
            textBox2.Text = livrosRow.Titulo;
            comboBox1.SelectedValue = livrosRow.Genero;
            comboBox2.SelectedValue = livrosRow.Editora;
            textBox3.Text = livrosRow.Isbn;
            textBox4.Text = livrosRow.Sinopse;
            textBox5.Text = livrosRow.Observacoes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow.Registro = int.Parse(textBox1.Text);
            livrosRow.Titulo = textBox2.Text;
            livrosRow.Genero = (int)comboBox1.SelectedValue;
            livrosRow.Editora = (int)comboBox2.SelectedValue;
            livrosRow.Isbn = textBox3.Text;
            livrosRow.Sinopse = textBox4.Text;
            livrosRow.Observacoes = textBox5.Text;

            this.Close();
        }
    }
}
