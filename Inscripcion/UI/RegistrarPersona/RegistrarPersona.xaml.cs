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

namespace Inscripcion.UI.RegistrarPersona
{
    /// <summary>
    /// Interaction logic for RegistrarPersona.xaml
    /// </summary>
    public partial class RegistrarPersona : Window
    {
        public object InscripcionesBLL { get; private set; }

        public RegistrarPersona()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;

            if (InscripcionId_Text.Text == String.Empty)
            {
                MessageBox.Show("Id Vacio");
                InscripcionId_Text.Focus();
                paso = false;
            }

            if (Fecha_Text.Text == String.Empty)
            {
                MessageBox.Show("Fecha Vacio");
                Fecha_Text.Focus();
                paso = false;
            }

            if (PersonaId_Text.Text == String.Empty)
            {
                MessageBox.Show("PersonaId Vacio");
                PersonaId_Text.Focus();
                paso = false;
            }

            if (Monto_Text.Text == String.Empty)
            {
                MessageBox.Show("Monto Vacio");
                Monto_Text.Focus();
                paso = false;
            }

            if (Balance_Text.Text == String.Empty)
            {
                MessageBox.Show("Balance Vacio");
                Balance_Text.Focus();
                paso = false;
            }

            return paso;
        }
        private void Limpiar()
        {
            InscripcionId_Text.Text = "0";
            Fecha_Text.Text = String.Empty;
            PersonaId_Text.Text = String.Empty;
            Monto_Text.Text = String.Empty;
            Balance_Text.Text = String.Empty;
        }
        private Inscripciones LlenaClase()
        {
            Inscripciones i = new Inscripciones();

            i.InscripcionId = Convert.ToInt32(InscripcionId_Text.Text);
            i.Fecha = Fecha_Text.DisplayDate;
            i.PersonaId = Convert.ToInt32(PersonaId_Text.Text);
            i.Monto = Convert.ToInt32(Monto_Text.Text);
            i.Balance = 1000;
           
            return i;
        }
        private void LlenaCampo(Inscripciones i)
        {
            InscripcionId_Text.Text = Convert.ToString(i.InscripcionId);
            Fecha_Text.SelectedDate = i.Fecha;
            PersonaId_Text.Text = Convert.ToString(i.PersonaId);
            Monto_Text.Text = Convert.ToString(i.Monto);
            Balance_Text.Text = Convert.ToString(i.Balance);
        }
        private bool ExisteBase()
        {
            Inscripciones i = InscripcionBLL.Buscar((int)Convert.ToInt32(InscripcionId_Text.Text));

            return (i != null);
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            int id;
            int.TryParse(InscripcionId_Text.Text, out id);
            Inscripciones i = new Inscripciones();
            i = InscripcionBLL.Buscar(id);

            Limpiar();

            if (i != null)
            {
                LlenaCampo(i);
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
            Inscripciones i;

            if (!Validar())
            {
                return;
            }

            i = LlenaClase();

            if(InscripcionId_Text.Text == "0")
            {
                paso = InscripcionBLL.Guardar(i);
            }
            else
            {
                if (!ExisteBase())
                {
                    MessageBox.Show("No Existe");
                    return;
                }
                paso = InscripcionBLL.Modificar(i);
            }

            if (paso)
            {
                MessageBox.Show("Guardado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            int Id;
            int.TryParse(InscripcionId_Text.Text, out Id);

            if (InscripcionBLL.Eliminar(Id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BuscarPersonaButton_Click(object sender, RoutedEventArgs e)
        {
            int id;
            int.TryParse(PersonaId_Text.Text, out id);
            Estudiantes es = new Estudiantes();
            es = EstudianteBLL.Buscar(id);
            
            if (es != null)
            {
                MessageBox.Show("Encontrado");
            }
            else
            {
                MessageBox.Show("No Encontrado");
            }
        }
    }
}
