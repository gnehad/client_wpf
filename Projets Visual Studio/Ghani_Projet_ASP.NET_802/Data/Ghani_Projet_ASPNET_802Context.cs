using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghani_Projet_ASP.NET_802.modeles;

namespace Ghani_Projet_ASP.NET_802.Data
{
    public class Ghani_Projet_ASPNET_802Context : DbContext
    {
        public Ghani_Projet_ASPNET_802Context (DbContextOptions<Ghani_Projet_ASPNET_802Context> options)
            : base(options)
        {
        }

        public DbSet<Ghani_Projet_ASP.NET_802.modeles.Employes> Employes { get; set; }
    }
}
