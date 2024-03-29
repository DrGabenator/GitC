﻿using DataGridView.Adicionar;
using DataGridView.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuariosSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuariosSelect.Id);
                    }
                    break;

                case 1:
                    {
                        frmEdicaoUsuarios editUsuarios = new frmEdicaoUsuarios();
                        editUsuarios.UsuariosRow = usuariosSelect;
                        editUsuarios.ShowDialog();

                        this.usuariosTableAdapter.Update(editUsuarios.UsuariosRow);
                    }
                    break;
            }
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario frmAdd = new frmAdicionarUsuario();
            frmAdd.ShowDialog();

            this.usuariosTableAdapter.Insert(
               frmAdd.usuariosRow.Usuario,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now);

            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
