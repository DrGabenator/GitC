using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificadorDeInformacoes.Views
{
    /// <summary>
    /// Interaction logic for ucVerif.xaml
    /// </summary>
    public partial class ucVerif : UserControl
    {
        public ucVerif()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbxNome.Text;
            var tel = tbxTelefone.Text;
            var email = tbxEmail.Text;

            var regExTel = @"^\++[0-9]{1,2}\ (\([0-9]{2}\))\s(\d{5}-\d{4})$";
            var regExEmail = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                            + "@"
                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"; ;

            var resultTel = Regex.IsMatch(tel, regExTel, RegexOptions.None);

            if (resultTel)
            {
                MessageBox.Show("O formato do telefone está certo.");
            }
            else
            {
                MessageBox.Show("O formato do telefone está errado.");
            }

            var resultEmail = Regex.IsMatch(email, regExEmail, RegexOptions.None);

            if (resultEmail)
            {
                MessageBox.Show("O formato do email está certo.");
            }
            else
            {
                MessageBox.Show("O formato do email está errado.");
            }

            /*Regex Rgx = new Regex(@"^\+\d{2}(\d{2}\)\d{5}-\d{4}$"); //formato (XX)XXXXX-XXXX

            if (!Rgx.IsMatch(tel))
                return false;
            else
                return true;*/
        }
    }
}
