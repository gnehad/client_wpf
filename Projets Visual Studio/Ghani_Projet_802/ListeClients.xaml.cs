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
    /// Logique d'interaction pour ListeClients.xaml
    /// </summary>
    public partial class ListeClients : Window
    {
        public ListeClients(IEnumerable<Clients> listeClients)
        {
            InitializeComponent();
            ListViewClients.ItemsSource = listeClients;
        }
    }
}
