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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow usuariosRow;

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            textBox1.Text = usuariosRow.Nome;
            textBox2.Text = usuariosRow.Email;
            textBox3.Text = usuariosRow.Login;
            textBox4.Text = usuariosRow.Senha;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuariosRow.Nome = textBox1.Text;
            usuariosRow.Email = textBox2.Text;
            usuariosRow.Login = textBox3.Text;
            usuariosRow.Senha = textBox4.Text;

            this.Close();
        }

    }
}
