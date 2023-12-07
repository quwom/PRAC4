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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int A)) MessageBox.Show("Поле только для чисел");
            if (!int.TryParse(TextBox2.Text, out int B)) MessageBox.Show("Поле только для чисел");

            int C = 0;

            while (A >= B)
            {
                A -= B;
                C++;
            }
            TextBox3.Text += ("Количество отрезков B на отрезке А: " +$"{C}\n") ;

        }
    }
}
