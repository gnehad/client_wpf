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
    
    public partial class Categories
    {
        public Categories()
        {
            this.Produits = new HashSet<Produits>();
        }
    
        public int CategorieID { get; set; }
        public string NomCategorie { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual ICollection<Produits> Produits { get; set; }
    }
}