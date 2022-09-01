using System;
using System.ComponentModel.DataAnnotations;
namespace Ghani_Projet_ASP.NET_802.modeles
{
    public class Employes
    {
        [Key]
        public int EmployeID { get; set; } // la clé primaire
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Titre { get; set; }

        // L’attribut [DataType] spécifie le type des données ( Date ). Avec cet attribut,
        // l’utilisateur n’est pas obligé d’entrer des informations d’heure dans le champ date.
        // Seule la date est affichée, pas les informations de temps.        
        [DataType(DataType.Date)]
        public DateTime DateDeNaissance { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateEmbauche { get; set; }
        public string Adresse { get; set; }
        public string Province { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
        public string Telephone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }

    }
}
