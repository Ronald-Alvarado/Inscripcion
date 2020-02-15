using Inscripcion.BLL;
using Inscripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Inscripcion.UI.InscripcionEstudiante
{
    /// <summary>
    /// Interaction logic for InscripcionEstudiante.xaml
    /// </summary>
    public partial class InscripcionEstudiante : Window
    {
        public InscripcionEstudiante()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;

            if(EstudianteId_Text.Text == String.Empty)
            {
                MessageBox.Show("Id Vacio");
                EstudianteId_Text.Focus();
                paso = false;
            }

            if (Nombre_Text.Text == String.Empty)
            {
                MessageBox.Show("Nombre Vacio");
                Nombre_Text.Focus();
                paso = false;
            }

            if (Apellido_Text.Text == String.Empty)
            {
                MessageBox.Show("Apellido Vacio");
                Apellido_Text.Focus();
                paso = false;
            }

            if (Telefono_Text.Text == String.Empty)
            {
                MessageBox.Show("Telefono Vacio");
                Telefono_Text.Focus();
                paso = false;
            }

            if (Cedula_Text.Text == String.Empty)
            {
                MessageBox.Show("Cedula Vacio");
                Cedula_Text.Focus();
                paso = false;
            }

            if (Direccion_Text.Text == String.Empty)
            {
                MessageBox.Show("Direccion Vacio");
                Direccion_Text.Focus();
                paso = false;
            }

            if (FechaBox.Text == String.Empty)
            {
                MessageBox.Show("Fecha Vacio");
                FechaBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void Limpiar()
        {
            EstudianteId_Text.Text = "0";
            Nombre_Text.Text = String.Empty;
            Apellido_Text.Text = String.Empty;
            Telefono_Text.Text = String.Empty;
            Cedula_Text.Text = String.Empty;
            Direccion_Text.Text = String.Empty;
            FechaBox.Text = String.Empty;
            Balance.Text = "0";
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes e = new Estudiantes();

            e.Nombre = Nombre_Text.Text;
            e.Apellido = Apellido_Text.Text;
            e.Telefono = Telefono_Text.Text;
            e.Cedula = Cedula_Text.Text;
            e.Direccion = Direccion_Text.Text;
            e.FechaNacimiento = FechaBox.DisplayDate;
            e.Balance = Convert.ToInt32(Balance.Text);

            return e;
        }
        private void LlenaCampo(Estudiantes e)
        {
            EstudianteId_Text.Text = Convert.ToString(e.PersonaId);
            Nombre_Text.Text = e.Nombre;
            Apellido_Text.Text = e.Apellido;
            Telefono_Text.Text = e.Telefono;
            Cedula_Text.Text = e.Cedula;
            Direccion_Text.Text = e.Direccion;
            FechaBox.SelectedDate = e.FechaNacimiento;
            Balance.Text = Convert.ToString(e.Balance);
        }
        private bool ExisteBase()
        {
            Estudiantes e = EstudianteBLL.Buscar((int)Convert.ToInt32(EstudianteId_Text.Text));

            return (e != null);
        }



        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            int id;
            int.TryParse(EstudianteId_Text.Text, out id);
            Estudiantes es = new Estudiantes();
            es = EstudianteBLL.Buscar(id);

            Limpiar();

            if(es != null)
            {
                LlenaCampo(es);
                MessageBox.Show("Encontrado");
            }
            else
            {
                MessageBox.Show("No Encontrado");
            }

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;
            Estudiantes es;

            if (!Validar())
            {
                return;
            }

            es = LlenaClase();

            if(EstudianteId_Text.Text == "0")
            {
                paso = EstudianteBLL.Guardar(es);
            }
            else
            {
                if (!ExisteBase())
                {
                    MessageBox.Show("No Existe");
                    return;
                }
                paso = EstudianteBLL.Modificar(es);
            }

            if (paso)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            Limpiar();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            int Id;
            int.TryParse(EstudianteId_Text.Text, out Id);

            Limpiar();

            if (EstudianteBLL.Eliminar(Id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
