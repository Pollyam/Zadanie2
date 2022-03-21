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

namespace Zadan2.Page
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(textbox1.Text);
            double b = double.Parse(textbox2.Text);
            double c = double.Parse(textbox3.Text);
            double d = b * b - (4 * a * c);
            double x1 = (b * (-1) - Math.Sqrt(d)) / (2 * a);
            double x2 = (b * (-1) - Math.Sqrt(d)) / (2 * a);

        }

    }
}
