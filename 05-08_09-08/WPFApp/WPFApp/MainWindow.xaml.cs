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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private MediaPlayer mediaPlayer = new MediaPlayer();

        private void UcLoginForm_loginCorrect(object sender, EventArgs e)
        {
            ucTaskForm.Visibility = Visibility.Visible;
            ucCalculatorForm.Visibility = Visibility.Visible;
            mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\acertou.mp3"));
            mediaPlayer.Play();
            /*mediaPlayer.Open(new Uri(@"C:\Users\hbsis\Downloads\vitas.mp3"));
            mediaPlayer.Position = TimeSpan.Zero;
            mediaPlayer.Play();*/
            MessageBox.Show("ACERTOU, OTÁRIO!");

        }
    }
}
