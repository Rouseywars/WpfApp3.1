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

namespace WpfApp3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static double Fac(int n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(count1.Text);
            double S = 0;
            for (int k = 1; k < n; k++)
            {
                S += (Math.Pow(-1, k) * (Math.Pow(k, 3) - 27)) / (3 * Fac(k + 2));
            }
            result.Text += $"S = {S}" + Environment.NewLine;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text = "";
        }
    }
}
