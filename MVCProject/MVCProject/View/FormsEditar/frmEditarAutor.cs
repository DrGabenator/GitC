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
    public partial class frmEditarAutor : Form
    {
        public frmEditarAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow autoresRow;

        private void FrmEditarAutor_Load(object sender, EventArgs e)
        {
            textBox1.Text = autoresRow.Nome;
            textBox2.Text = autoresRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            autoresRow.Nome = textBox1.Text;
            autoresRow.Descricao = textBox2.Text;

            this.Close();
        }
    }
}
