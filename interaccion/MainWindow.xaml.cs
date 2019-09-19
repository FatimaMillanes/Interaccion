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

namespace interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            btnMiBoton.Click += BtnMiBoton_Click;
        }

        private void BtnMiBoton_Click(object sender, RoutedEventArgs e)
        {
            lblFatimaMillanes.Text = "Fatima Millanes";
            lblFatimaMillanes.FontSize = 29;
            lblFatimaMillanes.Foreground = Brushes.Blue;
           
        }

        private void BtnMiSegundoBoton_Click(object sender, RoutedEventArgs e)
        {
            lblFatimaMillanes.Text = "Segundo boton";
            lblFatimaMillanes.FontSize = 20;
            lblFatimaMillanes.Foreground = Brushes.BlueViolet;
        }

        private void BtnMiTercerBoton_Click(object sender, RoutedEventArgs e)
        {
            lblFatimaMillanes.Text = "Tercer boton";
            lblFatimaMillanes.FontSize = 30;
            lblFatimaMillanes.Foreground = Brushes.OrangeRed;
        }
    }
}
