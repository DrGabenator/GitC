﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios formUsuarios = new frmUsuarios();
            formUsuarios.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores formAutores = new frmAutores();
            formAutores.ShowDialog();
        }

        private void GeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros formGeneros = new frmGeneros();
            formGeneros.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros formLivros = new frmLivros();
            formLivros.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacoes formLocacoes = new frmLocacoes();
            formLocacoes.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras formEditoras = new frmEditoras();
            formEditoras.ShowDialog();
        }
    }
}
