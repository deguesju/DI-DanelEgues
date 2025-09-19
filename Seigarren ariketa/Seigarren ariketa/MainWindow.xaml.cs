using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Seigarren_ariketa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBox[] boxes = { TextBox1, TextBox2, TextBox3 };
                var current = sender as TextBox;
                int idx = System.Array.IndexOf(boxes, current);
                int nextIdx = (idx + 1) % boxes.Length;

                string text = current.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    boxes[nextIdx].Text = text;
                    current.Clear();
                    boxes[nextIdx].Focus();
                }
                e.Handled = true;
            }
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox1.Focus();
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}