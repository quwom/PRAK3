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
            if (!int.TryParse(TextBox1.Text, out int x)) MessageBox.Show("Поле только для числе");
            double Y = 0;
            if (x > (-Math.PI) / 2 && x < Math.PI / 2)
            {
                Y = Math.Sqrt(Math.Abs(Math.Sin(x) + Math.Pow(Math.Tan(x), 2) / 3.5 * Math.Cos(x)));
            }
            else if (x > Math.PI / 2 && x < Math.PI)
            {
                Y = Math.Cos(x / 3) / Math.Sin(x) + Math.Pow(Math.Tan(x), 2);
            }
            TextBox2.Text += Y;
        }
    }
}
