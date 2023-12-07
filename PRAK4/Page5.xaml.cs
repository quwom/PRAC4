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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double p)) MessageBox.Show("Поле только для чисел");
            double dist = 10;
            double allDist = dist;
            int Dni = 1;

            while (allDist <= 200)
            {
                dist *= (1 + p / 100);
                allDist += dist;
                Dni++;
            }
            TextBox3.Text += allDist;
            TextBox2.Text += Dni;
        }
    }
}
