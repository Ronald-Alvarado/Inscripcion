using Inscripcion.UI.ConsultaEstudiante;
using Inscripcion.UI.InscripcionEstudiante;
using Inscripcion.UI.RegistrarPersona;
using Inscripcion.UI.Pago;
using Inscripcion.UI.ConsultaInscripcion;
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

namespace Inscripcion
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

        private void InscribirEstudianteButton_Click(object sender, RoutedEventArgs e)
        {
            InscripcionEstudiante ie = new InscripcionEstudiante();
            ie.ShowDialog();
        }

        private void ConsultarEstudianteButton_Click(object sender, RoutedEventArgs e)
        {
            ConsultaEstudiante ce = new ConsultaEstudiante();
            ce.ShowDialog();
        }

        private void RegistrarEstudianteButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrarPersona rp = new RegistrarPersona();
            rp.ShowDialog();
        }

        private void ConsultarBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            Pago p = new Pago();
            p.ShowDialog();
        }

        private void ConsultarInscripcionButton_Click(object sender, RoutedEventArgs e)
        {
            ConsultaInscripcion ci = new ConsultaInscripcion();
            ci.ShowDialog();
        }
    }
}
