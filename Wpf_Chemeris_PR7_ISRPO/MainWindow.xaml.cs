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

namespace Wpf_Chemeris_PR7_ISRPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int summ;
        private void M_g_Checked(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "1. Картошка по француски 400 рублей ";
            int cvn1;
            cvn1 = Convert.ToInt32(Itog_3.Text);
            summ = cvn1 + 400;
            Itog_3.Text = summ.ToString();
        }

        private void By(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "2. Террияки 160 рублей ";
            int cvn2;
            cvn2 = Convert.ToInt32(Itog_3.Text);
            summ = cvn2 + 160;
            Itog_3.Text = summ.ToString();
        }

        private void hai(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "3. Жаренная картошка 70 рублей ";
            int cvn3;
            cvn3 = Convert.ToInt32(Itog_3.Text);
            summ = cvn3 + 70;
            Itog_3.Text = summ.ToString();

        }
        private void MK(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "4. Брейнданс 20 000 000 рублей ";
            int cvn4;
            cvn4 = Convert.ToInt32(Itog_3.Text);
            summ = cvn4 + 20000000;
            Itog_3.Text = summ.ToString();

        }
        private void M_KM(object sender, RoutedEventArgs e)
        {
            Itog.Text = Itog.Text + "5. Рожки с подливкой 85 рублей ";
            int cvn5;
            cvn5 = Convert.ToInt32(Itog_3.Text);
            summ = cvn5 + 85;
            Itog_3.Text = summ.ToString();

        }
    }
}
