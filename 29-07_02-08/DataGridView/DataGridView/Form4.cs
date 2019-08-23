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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;

                case 1:
                    {
                        frmEdicaoVendas editVendas = new frmEdicaoVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(editVendas.VendasRow);
                    }
                    break;
            }
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarVenda frmAdicionar = new frmAdicionarVenda();
            frmAdicionar.ShowDialog();

            if(frmAdicionar.vendasRow?.Carro > 0 && frmAdicionar.vendasRow?.Valor > 0)
            this.vendasTableAdapter.Insert(
               frmAdicionar.vendasRow.Carro,
               frmAdicionar.vendasRow.Quantidade,
               frmAdicionar.vendasRow.Valor,
               true,
               1,
               1,
               DateTime.Now,
               DateTime.Now);

            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }
    }
}