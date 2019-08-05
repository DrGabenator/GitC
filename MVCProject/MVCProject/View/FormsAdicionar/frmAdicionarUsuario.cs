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
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        public Usuario usuario;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuario = new Usuario
            {
                Nome = textBox1.Text,
                Email = textBox2.Text,
                Login = textBox3.Text,
                Senha = textBox4.Text
            };

            this.Close();
        }
    }
}
