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
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacao;

        private void Button1_Click(object sender, EventArgs e)
        {
            locacao = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = int.Parse(textBox1.Text),
                Devolucao = dateTimePicker1.Value

            };
        }
    }
}
