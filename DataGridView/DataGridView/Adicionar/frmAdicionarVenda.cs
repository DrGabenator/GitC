using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicionar
{
    public partial class frmAdicionarVenda : Form
    {
        public frmAdicionarVenda()
        {
            InitializeComponent();
        }

        public Venda vendasRow;

        private void FrmAdicionarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            vendasRow = new Venda
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = int.Parse(textBox1.Text),
                Valor = decimal.Parse(textBox2.Text)
            };

            this.Close();
        }
    }
}
