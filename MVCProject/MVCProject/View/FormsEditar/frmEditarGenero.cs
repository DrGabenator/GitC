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
    public partial class frmEditarGenero : Form
    {
        public frmEditarGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.GenerosRow generosRow;

        private void FrmEditarGenero_Load(object sender, EventArgs e)
        {
            textBox1.Text = generosRow.Tipo;
            textBox2.Text = generosRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generosRow.Tipo = textBox1.Text;
            generosRow.Descricao = textBox2.Text;

            this.Close();
        }
    }
}
