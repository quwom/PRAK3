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

namespace PRAK3
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
            int a = n / 100;
            int b = n % 10;
            int c = n % 100 /10;
            if (a == c && c  == b)
            {
                TextBox2.Text += ("Числа одинаковые");
            }
            else
            {
                TextBox2.Text += ("Числа различаются");
            }
        }
    }
}
