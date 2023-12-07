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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TextBox1.Text, out int n)) MessageBox.Show("Поле только для чисел");
            switch (n)
            {
                case 1: TextBox2.Text += "Плохo"; break;
                case 2: TextBox2.Text += "Неудовлетворительно,"; break;
                case 3: TextBox2.Text += "Удовлетворительно"; break;
                case 4: TextBox2.Text += "Хорошо"; break;
                case 5: TextBox2.Text += "Отлично"; break;
                default: TextBox2.Text += "Неправильная оценка";
                    return;
            }
        }
    }
}
