using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Edicao
{
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridView.QuerysInnerJoinDataSet1.VendasRow VendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

            cbxCarro.SelectedValue = VendasRow.Carro;
            tbxQuantidade.Text = VendasRow.Quantidade.ToString();
            tbxValor.Text = VendasRow.Valor.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)cbxCarro.SelectedValue;
            VendasRow.Quantidade = int.Parse(tbxQuantidade.Text);
            VendasRow.Valor = decimal.Parse(tbxValor.Text);

            this.Close();
        }
    }
}
