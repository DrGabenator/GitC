using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.FormsAdicionar
{
    public partial class frmAdicionarLivro : Form
    {
        public frmAdicionarLivro()
        {
            InitializeComponent();
        }

        public Livro livro;

        private void Button1_Click(object sender, EventArgs e)
        {
            livro = new Livro
            {
                Registro = int.Parse(textBox1.Text),
                Titulo = textBox2.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Isbn = textBox3.Text,
                Sinopse = textBox4.Text,
                Observacoes = textBox5.Text
            };

            this.Close();
        }

        private void FrmAdicionarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
