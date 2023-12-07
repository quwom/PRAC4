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

namespace PRAK4
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int n)) MessageBox.Show("Поле только для чисел");
            switch (n)
            {
                case 20: TextBox2.Text += "Двадцать лет"; break;
                case 21: TextBox2.Text += "Двадцать один год,"; break;
                case 22: TextBox2.Text += "Двадцать два года"; break;
                case 23: TextBox2.Text += "Двадцать три года"; break;
                case 24: TextBox2.Text += "Двадцать четыре года"; break;
                case 25: TextBox2.Text += "Двадцать пять лет"; break;
                case 26: TextBox2.Text += "Двадцать шесть лет"; break;
                case 27: TextBox2.Text += "Двадцать семь лет"; break;
                case 28: TextBox2.Text += "Двадцать восемь лет"; break;
                case 29: TextBox2.Text += "Двадцать девять лет"; break;
                case 30: TextBox2.Text += "Тридцать лет"; break;
                case 31: TextBox2.Text += "Тридцать один год"; break;
                default: TextBox2.Text += "Неправильный возраст";
                    return;
            }
        }
    }
}
