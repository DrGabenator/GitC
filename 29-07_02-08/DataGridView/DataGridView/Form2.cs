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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;

                case 1:
                    {
                        frmEdicaoMarcas editMarcas = new frmEdicaoMarcas();
                        editMarcas.marcasRow = marcasSelect;
                        editMarcas.ShowDialog();

                        this.marcasTableAdapter.Update(editMarcas.marcasRow);
                    }
                    break;
            }


            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarMarca formAdd = new frmAdicionarMarca();
            formAdd.ShowDialog();

            this.marcasTableAdapter.Insert(
               formAdd.marcasRow.Nome,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now);

            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }
    }
}