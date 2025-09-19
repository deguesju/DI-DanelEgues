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

namespace Hirugarren_Ariketa
{
  
    public partial class MainWindow : Window
    {
        private int[] numbers = new int[4];
        private int currentIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            UpdateLabel();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int value))
            {
                numbers[currentIndex] = value;
                currentIndex++;

                if (currentIndex < 4)
                {
                    txtNumero.Clear();
                    UpdateLabel();
                }
                else
                {
                    double result = (numbers[0] + (numbers[0] * numbers[1]) + (numbers[1] * numbers[2]) + (numbers[2] * numbers[3])) / 4.0;
                    ResultadoWindow resultadoWindow = new ResultadoWindow(result, this);
                    resultadoWindow.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sartu zenbaki oso bat.");
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void ResetForm()
        {
            currentIndex = 0;
            txtNumero.Clear();
            UpdateLabel();
            this.Show();
        }

        private void UpdateLabel()
        {
            lblNumero.Content = $"Numero {currentIndex + 1}";
        }
    }
}