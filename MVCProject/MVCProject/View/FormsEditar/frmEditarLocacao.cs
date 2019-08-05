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
    public partial class frmEditarLocacao : Form
    {
        public frmEditarLocacao()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.LocacoesRow locacoesRow;

        private void FrmEditarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livros);

            comboBox1.SelectedValue = locacoesRow.Livro;
            comboBox2.SelectedValue = locacoesRow.Usuario;
            textBox1.Text = locacoesRow.Tipo.ToString();
            dateTimePicker1.Value = locacoesRow.Devolucao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacoesRow.Livro = (int)comboBox1.SelectedValue;
            locacoesRow.Usuario = (int)comboBox2.SelectedValue;
            locacoesRow.Tipo = int.Parse(textBox1.Text);
            locacoesRow.Devolucao = dateTimePicker1.Value;

            this.Close();
        }
    }
}
