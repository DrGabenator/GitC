using CadastrarAluno.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrarAluno
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome = tbxAluno.Text;
            novoAluno.Idade = int.Parse(tbxIdade.Text);

            this.Close();
        }
    }
}
