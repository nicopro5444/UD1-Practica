using System.Windows;
using System.Windows.Media;

namespace Practica1
{
    public partial class Login : Window
    {
        // 1. Simulación de base de datos en memoria (Matriz string[,])
        private string[,] usuarios = new string[,]
        {
            { "nicolas", "1234" },
            { "admin", "admin" },
            { "profesor", "dam2026" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPassword.Password;

            // 2. Verificación de que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                txtMensaje.Foreground = Brushes.Red; // Texto en rojo
                txtMensaje.Text = "Por favor, rellena todos los campos.";
                return;
            }

            // 3. Validación de usuario y contraseña
            bool loginExitoso = false;

            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] == user && usuarios[i, 1] == pass)
                {
                    loginExitoso = true;
                    break;
                }
            }

            // 4. Navegación entre formularios
            if (loginExitoso)
            {
                txtMensaje.Foreground = Brushes.LightGreen; // Texto en verde
                txtMensaje.Text = "¡Login exitoso! Entrando...";

                // Redirigir a la Home (MainWindow)
                MainWindow ventanaPrincipal = new MainWindow(user); 
                ventanaPrincipal.Show();

                // Cerrar la ventana de Login
                this.Close();
            }
            else
            {
                txtMensaje.Foreground = Brushes.Red;
                txtMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar toda la aplicación
            Application.Current.Shutdown();
        }
    }
}