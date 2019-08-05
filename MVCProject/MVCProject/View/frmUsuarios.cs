using MVCProject.View.FormsAdicionar;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {

                    }break;

                case 1:
                    {

                    }break;
            }

            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario formAdd = new frmAdicionarUsuario();
            formAdd.ShowDialog();

            this.usuariosTableAdapter.Insert(
                formAdd.usuario.Nome,
                formAdd.usuario.Login,
                formAdd.usuario.Senha,
                formAdd.usuario.Email,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now);

            this.usuariosTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
