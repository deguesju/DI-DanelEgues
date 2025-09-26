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

namespace _2._2_Ariketa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnAñadir.Click += BtnAñadir_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnBorrarLista.Click += BtnBorrarLista_Click;
            btnSalir.Click += (s, e) => Close();
            lstAmigos.MouseDoubleClick += LstAmigos_MouseDoubleClick;
        }

        private void BtnAñadir_Click(object sender, RoutedEventArgs e)
        {
            string nuevoAmigo = txtNuevo.Text.Trim();
            if (string.IsNullOrEmpty(nuevoAmigo))
            {
                MessageBox.Show("Introduce un nombre para añadir.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            lstAmigos.Items.Add(nuevoAmigo);
            txtNuevo.Clear();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lstAmigos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un amigo para eliminar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var seleccionados = lstAmigos.SelectedItems.Cast<object>().ToArray();
            foreach (var item in seleccionados)
            {
                lstAmigos.Items.Remove(item);
            }
            txtSeleccionado.Clear();
        }

        private void BtnBorrarLista_Click(object sender, RoutedEventArgs e)
        {
            lstAmigos.Items.Clear();
            txtSeleccionado.Clear();
        }

        private void LstAmigos_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (lstAmigos.SelectedItem != null)
            {
                txtSeleccionado.Text = lstAmigos.SelectedItem.ToString();
            }
        }
    }
}