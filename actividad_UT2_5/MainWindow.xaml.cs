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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace actividad_UT2_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }
        

        private void writeTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text = writeTextBox.Text;
        }
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontWeight = FontWeights.Bold;
        }
        
        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Foreground = Brushes.Blue;
        }
        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Foreground = Brushes.Red;
        }
        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Foreground = Brushes.Green;
        }
    }
}
