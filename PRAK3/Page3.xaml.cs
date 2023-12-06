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
            if (!double.TryParse(TextBox1.Text, out double a)) MessageBox.Show("Поле только для чисел!");
            if (!double.TryParse(TextBox2.Text, out double b)) MessageBox.Show("Поле только для чисел!");
            if (!double.TryParse(TextBox3.Text, out double c)) MessageBox.Show("Поле только для чисел!");
            if (!double.TryParse(TextBox4.Text, out double d)) MessageBox.Show("Поле только для чисел!");
            if (a == b && b == c && c == d)
            {
                TextBox5.Text += "Все числа равны";
            }
            else if (b == c && c == d)
            {
                TextBox5.Text += "1";
            }
            else if (a == c && a == d)
            {
                TextBox5.Text += "2";
            }
            else if (b == d && d == a)
            {
                TextBox5.Text += "3";
            }
            else 
            { 
                TextBox5.Text += "4"; 
            }
        }
    }
}
