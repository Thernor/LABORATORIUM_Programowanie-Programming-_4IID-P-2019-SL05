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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double cyfra1;
        double cyfra2;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            cyfra1 = Convert.ToDouble(textBox1.Text);
            cyfra2 = Convert.ToDouble(textBox2.Text);
            lblwynik.Content = cyfra1 + cyfra2;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            cyfra1 = Convert.ToDouble(textBox1.Text);
            cyfra2 = Convert.ToDouble(textBox2.Text);
            lblwynik.Content = cyfra1 - cyfra2;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            cyfra1 = Convert.ToDouble(textBox1.Text);
            cyfra2 = Convert.ToDouble(textBox2.Text);
            lblwynik.Content = cyfra1 * cyfra2;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            cyfra1 = Convert.ToDouble(textBox1.Text);
            cyfra2 = Convert.ToDouble(textBox2.Text);
            if (cyfra2 == 0)
            {
                MessageBox.Show("Nie dziel przez 0", "UWAGA");
            }
            else
                lblwynik.Content = cyfra1 / cyfra2;
        }

    }
}
