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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int n)) MessageBox.Show("Поле только для чисел");
            if (!int.TryParse(TextBox2.Text, out int b)) MessageBox.Show("Поле только для чисел");
            double a = 0, c = 0, h = 0, S = 0;
            switch(n)
            {
                case 1:
                    a = b;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = c * h / 2; break;
                case 2:
                    a = c / Math.Sqrt(2);
                    c = b;
                    h = c / 2;
                    S = c * h / 2; break;
                case 3:
                    a = c/2;
                    c = a * Math.Sqrt(2);
                    h = b;
                    S = c * h / 2; break;
                case 4:
                    a = c * h/2;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    S = b; break;
                default: TextBox3.Text += "Неправильное значение";
                    return;
            }
            TextBox3.Text += ("Катет a:" + $"{a}\n");
            TextBox3.Text += ("Гипотенуза c:" + $"{c}\n");
            TextBox3.Text += ("Высота h:"  +$"{h}\n");
            TextBox3.Text += ("Площадь S:" + $"{b}\n");  
        }
    }
}
