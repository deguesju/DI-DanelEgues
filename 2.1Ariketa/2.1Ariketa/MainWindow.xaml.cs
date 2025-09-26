using System;
using System.Windows;

namespace _2._1Ariketa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejecutar_Click(object sender, RoutedEventArgs e)
        {
            while (true)
            {
                try
                {
                    txtAhora.Text = DateTime.Now.ToString();

                    txtHoy.Text = DateTime.Today.ToShortDateString();

                    txtHoraHoy.Text = DateTime.Now.ToShortTimeString();

                    string mesesInput = Microsoft.VisualBasic.Interaction.InputBox(
                        "Zenbat hilabete gehitu nahi dizkiozu hasierako datari?", "Suma de Fechas", "0");
                    if (!int.TryParse(mesesInput, out int meses))
                        throw new Exception();

                    DateTime sumaFecha = DateTime.Today.AddMonths(meses);
                    txtSumaFechas.Text = sumaFecha.ToShortDateString();

                    string inicioInput = Microsoft.VisualBasic.Interaction.InputBox(
                        "Sartu hasierako data (yyyy-MM-dd):", "Diferencia de Fechas", DateTime.Today.ToString("yyyy-MM-dd"));
                    if (!DateTime.TryParse(inicioInput, out DateTime inicio))
                        throw new Exception();

                    string finInput = Microsoft.VisualBasic.Interaction.InputBox(
                        "Sartu amaierako data (yyyy-MM-dd):", "Diferencia de Fechas", DateTime.Today.ToString("yyyy-MM-dd"));
                    if (!DateTime.TryParse(finInput, out DateTime fin))
                        throw new Exception();

                    int egunak = (fin - inicio).Days;
                    txtDiferenciaFechas.Text = egunak.ToString();

                    break; 
                }
                catch
                {
                    MessageBox.Show("Sartutako daturen bat ez da zuzena. Saiatu berriro.", "Errorea", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimpiarCampos();
                }
            }
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LimpiarCampos()
        {
            txtAhora.Text = "";
            txtHoy.Text = "";
            txtHoraHoy.Text = "";
            txtSumaFechas.Text = "";
            txtDiferenciaFechas.Text = "";
        }
    }
}