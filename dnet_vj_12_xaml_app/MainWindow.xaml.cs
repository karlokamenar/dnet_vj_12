using dnet_vj_12_xaml_app.ServiceReference1;
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

namespace dnet_vj_12_xaml_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1Client klijent = new Service1Client();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string id = textBox.Text;
            Klub trazeni = klijent.DajKlub(id);
            string klub = trazeni.Id.ToString() + "\n" + trazeni.Naziv + "\n"
                + trazeni.Sport + "\n" + trazeni.Drzava + "\n" + trazeni.GodinaOsnivanja.ToString();
            MessageBox.Show(klub, "Klub", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}
