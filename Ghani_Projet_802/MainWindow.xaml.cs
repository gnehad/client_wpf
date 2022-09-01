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
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Ghani_Projet_802
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Url bdlUrl;
        private ObservableCollection<Employes> listeEmployes;
        private ObservableCollection<Commandes> commandesEmployes;
        private ObservableCollection<Clients> listeClients;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void initialiser(object sender, RoutedEventArgs e)
        {
            using (var contexte = new BD_Projet_802Entities())
            {
                listeEmployes = new ObservableCollection<Employes>(contexte.Employes.ToList());
                ListViewEmployes.ItemsSource = listeEmployes;

                cbxProduits.ItemsSource = new ObservableCollection<Produits>(contexte.Produits.ToList());
                cbxCategorie.ItemsSource = new ObservableCollection<Categories>(contexte.Categories.ToList());
            }

        }

        private void afficherCommandes(object sender, MouseButtonEventArgs e)
        {
            /*Afficher les commandes associées à un employés dans ListViewCommandes
             * Récupérer l'ID de l'employé sélectionné et faire une recherche des produits associé
             */
            using (var contexte = new BD_Projet_802Entities())
            {
                Employes employeSelectionne = (Employes)ListViewEmployes.SelectedItem;
                //On affiche l'employé sélectionné 
                afficherSelection(employeSelectionne);

                //On récupère les commandes qui lui sont associées (Table Commandes)
                var CommandesEmployeSelectionne = from commande in contexte.Commandes.ToList()
                                                  where commande.EmployeID == employeSelectionne.EmployeID
                                                  select commande;
                commandesEmployes = new ObservableCollection<Commandes>(CommandesEmployeSelectionne);
                ListViewCommandes.ItemsSource = commandesEmployes;
            }
        }

        private void afficherClients(object sender, MouseButtonEventArgs e)
        {
            using (var contexte = new BD_Projet_802Entities())
            {
                Commandes commandeSelectionne = (Commandes)ListViewCommandes.SelectedItem;
                var clientsCommande = contexte.Clients.Where(client => commandeSelectionne.ClientID == client.ClientID).ToList();
                listeClients = new ObservableCollection<Clients>(clientsCommande);
                ListeClients fenetrelisteClients = new ListeClients(listeClients);
                fenetrelisteClients.ShowDialog();
            }

        }
        private void btnEffacerClick(object sender, RoutedEventArgs e)
        {
            effacerLesChamps();
        }

        private void effacerLesChamps()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtDateNaissance.Text = "";
            txtAdresse.Text = "";
            txtTitre.Text = "";
            txtDateEmbauche.Text = "";
            txtProvince.Text = "";
            txtTelephone.Text = "";
            txtPays.Text = "";
            txtCodePostal.Text = "";
            txtExtension.Text = "";
            cbxProduits.Text = "";
            cbxCategorie.Text = "";
            txtNotes.Text = "";
        }
        private void btnSauvegarderClick(object sender, RoutedEventArgs e)
        {
            Employes nouvelEmploye = new Employes();
            nouvelEmploye.Nom = txtNom.Text;
            nouvelEmploye.Prenom = txtPrenom.Text;
            nouvelEmploye.DateDeNaissance = txtDateNaissance.SelectedDate;
            nouvelEmploye.Adresse = txtAdresse.Text;
            nouvelEmploye.Titre = txtTitre.Text;
            nouvelEmploye.DateEmbauche = txtDateEmbauche.SelectedDate;
            nouvelEmploye.Province = txtProvince.Text;
            nouvelEmploye.Telephone = txtTelephone.Text;
            nouvelEmploye.Pays = txtPays.Text;
            nouvelEmploye.CodePostal = txtCodePostal.Text;
            nouvelEmploye.Extension = txtExtension.Text;
            nouvelEmploye.Notes = txtNotes.Text;
            try
            {
                using (var contexte = new BD_Projet_802Entities())
                {
                    contexte.Employes.Add(nouvelEmploye);
                    contexte.SaveChanges();
                    updateListeViewEmployes(contexte.Employes.ToList());
                }
                effacerLesChamps();
            }catch(Exception ex)
            {
                MessageBox.Show("Impossible d'ajouter le nouvel employé", "Erreur",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void btnModifierClick(object sender, RoutedEventArgs e)
        {
            var employeSelectionne = (Employes)ListViewEmployes.SelectedItem;
            if (employeSelectionne != null)
            {

                using (var contexte = new BD_Projet_802Entities())
                {
                    var employe = contexte.Employes.FirstOrDefault(emp => emp.EmployeID == employeSelectionne.EmployeID);
                    if (employe != null)
                    {
                        employe.Nom = txtNom.Text;
                        employe.Prenom = txtPrenom.Text;
                        employe.DateDeNaissance = txtDateNaissance.SelectedDate;
                        employe.Adresse = txtAdresse.Text;
                        employe.Titre = txtTitre.Text;
                        employe.DateEmbauche = txtDateEmbauche.SelectedDate;
                        employe.Province = txtProvince.Text;
                        employe.Telephone = txtTelephone.Text;
                        employe.Pays = txtPays.Text;
                        employe.CodePostal = txtCodePostal.Text;
                        employe.Extension = txtExtension.Text;
                        employe.Notes = txtNotes.Text;
                        contexte.SaveChanges();
                        effacerLesChamps();
                        updateListeViewEmployes(contexte.Employes.ToList());
                        MessageBox.Show("Employé modifié avec succès", "Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        MessageBox.Show("Impossible de modfier la sélection", "Erreur",
                    MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner l'employer à modifier", "Erreur",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSupprimerClick(object sender, RoutedEventArgs e)
        {
            //On efface un employe sélectionné dans la liste des employés
            var employesSelectionne = (Employes)ListViewEmployes.SelectedItem;
            if (employesSelectionne != null)
            {
                MessageBoxResult reponse = MessageBox.Show("Êtes-vous sûr de bien vouloir supprimer la sélection?", "Confirmation",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (reponse == MessageBoxResult.Yes)
                {
                    using (var contexte = new BD_Projet_802Entities())
                    {
                        var employeASupprimer = contexte.Employes.FirstOrDefault<Employes>(
                            emp => emp.EmployeID == employesSelectionne.EmployeID);
                        if (employeASupprimer != null)
                        {
                            /* On recherche les éventuelles commandes de l'employé à supprimer. Celles-ci doivent
                             * être supprimées avant de supprimer l'employé les ayant traitées (intégrité référentielle)
                            */
                            var commandesEmploye = contexte.Commandes.Where(commande => commande.EmployeID == employeASupprimer.EmployeID);
                            foreach (var commande in commandesEmploye)
                            {
                                contexte.Commandes.Remove(commande);
                            }
                            contexte.Employes.Remove(employeASupprimer);
                            contexte.SaveChanges();
                            effacerLesChamps();
                            updateListeViewEmployes(contexte.Employes.ToList());
                            MessageBox.Show("Employé supprimé avec succès", "Information",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("Impossible de supprimer l'employé sélectionné", "Erreur",
                                MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                    }
                }

            }
            else
                MessageBox.Show("Vous devez d'abord sélectionner l'employé à supprimer", "Erreur",
                    MessageBoxButton.OK, MessageBoxImage.Error);



        }

        private void updateListeViewEmployes(List<Employes> ListeEmployes)
        {
            ListViewEmployes.ItemsSource = ListeEmployes;
        }

        private void btnQuitterClick(object sender, RoutedEventArgs e)
        {
            confirmerFermeture();
        }

        private void confirmerFermeture()
        {
            MessageBoxResult reponse = MessageBox.Show("Vous êtes sûr de vouloir quitter l'application?", "Confirmation",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (reponse == MessageBoxResult.Yes)
                Environment.Exit(0);
        }

        private void WindowClosingClick(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult reponse = MessageBox.Show("Vous êtes sûr de vouloir quitter l'application?", "Confirmation",
    MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (reponse == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void afficherSelection(Employes employe)
        {
            txtNom.Text = employe.Nom;
            txtPrenom.Text = employe.Prenom;
            txtDateNaissance.Text = employe.DateDeNaissance.ToString();
            txtAdresse.Text = employe.Adresse;
            txtTitre.Text = employe.Titre;
            txtDateEmbauche.Text = employe.DateEmbauche.ToString();
            txtProvince.Text = employe.Province;
            txtTelephone.Text = employe.Telephone;
            txtPays.Text = employe.Pays;
            txtCodePostal.Text = employe.CodePostal;
            txtExtension.Text = employe.Extension;
            txtNotes.Text = employe.Notes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //L'idée c'est de lancer Chrome avec l'URL du site en paramètre
            //string url = "https://localhost:44395//employes";
            bdlUrl = new Url();
            bdlUrl.ShowDialog();
            string url = bdlUrl.url;
            if(url == null) { 
                MessageBox.Show("Aucune URL n'a été spécifiée", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
            else
            {
                try
                {
                    Process.Start(url);
                }catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de la tentative de lancement du navigateur", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }

        }
    }
}
