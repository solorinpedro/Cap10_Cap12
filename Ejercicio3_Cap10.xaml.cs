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
using System.Windows.Shapes;

namespace Cap10_Cap12
{
    /// <summary>
    /// Interaction logic for Ejercicio3_Cap10.xaml
    /// </summary>
    public partial class Ejercicio3_Cap10 : Window
    {
        public Ejercicio3_Cap10()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono(int.Parse(TextBoxLado.Text));
            TextBoxResultado.Text = poligono.CalcularPerimetro().ToString();
            if (TextBoxLado.Text == "")
            {
                MessageBox.Show("Le faltan campos por llenar :/");
            }
        }
        public class Poligono
        {
            public int lado;
            public int resultado;

           public Poligono(int lado)
           {
                this.lado = lado;
           }

            public int getLado()
            {
                return lado;
            }
            public int CalcularPerimetro()
            {
                resultado = lado * lado;
                return resultado;
            }        }
    }
}
