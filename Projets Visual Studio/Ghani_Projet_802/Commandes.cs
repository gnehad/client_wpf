//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ghani_Projet_802
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commandes
    {
        public int CommandeID { get; set; }
        public string ClientID { get; set; }
        public Nullable<int> EmployeID { get; set; }
        public Nullable<System.DateTime> DateCommande { get; set; }
        public Nullable<System.DateTime> DateRequise { get; set; }
        public Nullable<System.DateTime> DateEnvoi { get; set; }
        public string AdresseEnvoi { get; set; }
        public string VilleEnvoi { get; set; }
        public string CodePostalEnvoi { get; set; }
        public string PaysEnvoi { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Employes Employes { get; set; }
    }
}