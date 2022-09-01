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
using System.Windows.Shapes;

namespace Ghani_Projet_802
{
    /// <summary>
    /// Logique d'interaction pour Url.xaml
    /// </summary>
    public partial class Url : Window
    {
        public string url;
        public Url()
        {
            InitializeComponent();
        }

        private void copierURL(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtURL.Text))
                url = txtURL.Text;
            this.Close();
        }

        private void fermer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
