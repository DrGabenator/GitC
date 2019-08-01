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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmUsuarios = new Form3();
            frmUsuarios.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frmVendas = new Form4();
            frmVendas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                    }
                    break;

                case 1:
                    {
                        frmEdicaoCarros editCarro = new frmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        this.carrosTableAdapter.Update(editCarro.CarrosRow);

                        /*
                        this.carrosTableAdapter.UpdateQuery1(
                            editCarro.CarrosRow.Modelo,
                            editCarro.CarrosRow.Ano.ToString(),
                            editCarro.CarrosRow.Marca,
                            editCarro.CarrosRow.UsuAlt,
                            DateTime.Now,
                            editCarro.CarrosRow.Id
                            );
                        */
                    }
                    break;
            }
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionar formAdd = new frmAdicionar();
            formAdd.ShowDialog();

            this.carrosTableAdapter.Insert(
               formAdd.carrosRow.Modelo,
               formAdd.carrosRow.Ano,
               formAdd.carrosRow.Marca,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now);

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }
    }
}
