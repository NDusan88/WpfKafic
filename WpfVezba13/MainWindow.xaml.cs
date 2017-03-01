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

namespace WpfVezba13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sto1_MouseDown(object sender, MouseButtonEventArgs e)
        {            
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();           
        }

        private void Sto2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }

        private void Sto3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }

        private void Sto4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }

        private void Sto5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }

        private void Sto6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }

        private void Sto7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();

        }

        private void Sto8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CaffeMenu cm = new CaffeMenu();
            Close();
            cm.ShowDialog();
        }
    }
}
