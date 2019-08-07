using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPFApp.Views
{
    /// <summary>
    /// Interaction logic for ucCalculadora.xaml
    /// </summary>
    public partial class ucCalculadora : UserControl
    {
        public ucCalculadora()
        {
            InitializeComponent();
        }

        private MediaPlayer mediaPlayer = new MediaPlayer();

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {

            decimal num1 = decimal.Parse(Operador1.Text);

            decimal num2 = decimal.Parse(Operador2.Text);

            decimal resultado = num1 + num2;

            mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\nani.mp3"));
            mediaPlayer.Play();

            Result.Text = resultado.ToString();
        }

        private void BrnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            decimal num1 = decimal.Parse(Operador1.Text);

            decimal num2 = decimal.Parse(Operador2.Text);

            decimal resultado = num1 - num2;

            mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\naruto.mp3"));
            mediaPlayer.Play();

            Result.Text = resultado.ToString();
        }

        private void BtnMultiplicaco_Click(object sender, RoutedEventArgs e)
        {
            decimal num1 = decimal.Parse(Operador1.Text);

            decimal num2 = decimal.Parse(Operador2.Text);

            decimal resultado = num1 * num2;

            mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\omae.mp3"));
            mediaPlayer.Play();

            Result.Text = resultado.ToString();
        }

        private void BtnDivisao_Click(object sender, RoutedEventArgs e)
        {
            decimal num1 = decimal.Parse(Operador1.Text);

            decimal num2 = decimal.Parse(Operador2.Text);

            decimal resultado = num1 / num2;

            mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\arigato_oitbsfi.mp3"));
            mediaPlayer.Play();

            Result.Text = resultado.ToString();
        }
    }
}
