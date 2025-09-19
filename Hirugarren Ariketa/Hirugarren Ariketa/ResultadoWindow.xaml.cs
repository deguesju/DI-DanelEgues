using System.Windows;

namespace Hirugarren_Ariketa
{
    public partial class ResultadoWindow : Window
    {
        private MainWindow mainWindow;

        public ResultadoWindow(double result, MainWindow mainWindow)
        {
            InitializeComponent();
            txtResultado.Text = result.ToString("F2");
            this.mainWindow = mainWindow;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mainWindow.ResetForm();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}