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
    /// Interaction logic for Ejercicio2_Cap10.xaml
    /// </summary>
    public partial class Ejercicio2_Cap10 : Window
    {
        public Ejercicio2_Cap10()
        {
            InitializeComponent();
        }
        class Estudiante
        {
            private int EstudianteID;
            private string Nombre;
            private int edad;
            private string direccion;
            private string curso;
            private string carrera_tecnica;
            private string correo;

            Estudiante(int EstudianteID, string Nombre, int edad, string direccion, string curso,string carrera_tecnica,string correo)
            {
                this.EstudianteID = EstudianteID;
                this.Nombre = Nombre;
                this.edad = edad;
                this.direccion = direccion;
                this.curso = curso;
                this.carrera_tecnica = carrera_tecnica;
                this.correo = correo;
            }
            public int getEstudianteID()
            {
                return EstudianteID;
            }
            public string getNombre()
            {
                return Nombre;
            }
            public int getEdad()
            {
                return edad;
            }
            public string getDireccion()
            {
                return direccion;
            }
            public string getCurso()
            {
                return curso;
            }
            public string getCarreraTecnica()
            {
                return carrera_tecnica;
            }
            public string getCorreo()
            {
                return correo;
            }
        }
    }
}
