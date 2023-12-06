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
            if (!double.TryParse(TextBox1.Text, out double a)) MessageBox.Show("Поле только для чисел");
            if (!double.TryParse(TextBox2.Text, out double b)) MessageBox.Show("Поле только для чисел");
            if (a > b) 
            {
                TextBox3.Text += "2";
            }
            else if (b > a) 
            {
                TextBox3.Text += "1";
            }
            else 
            { 
                TextBox3.Text += "Числа равны";
            }
        }
    }
}
