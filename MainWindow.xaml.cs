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

namespace Cap10_Cap12
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

        private void Ejercicio1Cap10_Click(object sender, RoutedEventArgs e)
        {
            Ejercico1_Cap10 ejercicio = new Ejercico1_Cap10();
            ejercicio.Show();
        }

        private void Ejercicio2Cap10_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2_Cap10 ejercicio = new Ejercicio2_Cap10();
            ejercicio.Show();
        }

        private void Ejercicio3Cap10_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3_Cap10 ejercicio = new Ejercicio3_Cap10();
            ejercicio.Show();
        }
    }
}
