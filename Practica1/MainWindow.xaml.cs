using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string usuarioLogueado)
        {
            InitializeComponent();
            txtNombreUsuario.Text = usuarioLogueado; // Actualiza el texto de la cabecera
        }
        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            // Abre de nuevo la ventana de Login
            Login ventanaLogin = new Login();
            ventanaLogin.Show();

            // Cierra la ventana principal (tienda)
            this.Close();
        }
    }
}