using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Bostgarren_Ariketa
{
    public partial class MainWindow : Window
    {
        private double _fontSize = 24;
        private bool _isBold = false;
        private bool _isItalic = false;
        private bool _isUnderline = false;
        private bool _isStrikethrough = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnComicSans_Click(object sender, RoutedEventArgs e)
        {
            TestText.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void BtnCourier_Click(object sender, RoutedEventArgs e)
        {
            TestText.FontFamily = new FontFamily("Courier New");
        }

        private void BtnLodia_Click(object sender, RoutedEventArgs e)
        {
            _isBold = !_isBold;
            TestText.FontWeight = _isBold ? FontWeights.Bold : FontWeights.Normal;
        }

        private void BtnEtzana_Click(object sender, RoutedEventArgs e)
        {
            _isItalic = !_isItalic;
            TestText.FontStyle = _isItalic ? FontStyles.Italic : FontStyles.Normal;
        }

        private void BtnAzpimarra_Click(object sender, RoutedEventArgs e)
        {
            _isUnderline = !_isUnderline;
            if (_isUnderline)
                TestText.TextDecorations = TextDecorations.Underline;
            else
                TestText.TextDecorations = null;
        }

        private void BtnMarratua_Click(object sender, RoutedEventArgs e)
        {
            _isStrikethrough = !_isStrikethrough;
            if (_isStrikethrough)
                TestText.TextDecorations = TextDecorations.Strikethrough;
            else
                TestText.TextDecorations = null;
        }

        private void BtnHandiagoa_Click(object sender, RoutedEventArgs e)
        {
            _fontSize += 2;
            TestText.FontSize = _fontSize;
        }

        private void BtnTxikiagoa_Click(object sender, RoutedEventArgs e)
        {
            if (_fontSize > 8)
                _fontSize -= 2;
            TestText.FontSize = _fontSize;
        }

        private void BtnHautatu_Click(object sender, RoutedEventArgs e)
        {
            string texto = MainTextBox.Text;
            string seleccionado = MainTextBox.SelectedText;
            if (string.IsNullOrEmpty(seleccionado))
                seleccionado = texto;

            int numCaracteres = texto.Length;
            InfoTextBlock.Text = $"El texto tiene {numCaracteres} caracteres, y el texto seleccionado es: {seleccionado}";
        }
    }
}