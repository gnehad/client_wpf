using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ghani_Projet_ASP.NET_802.Data;
using Ghani_Projet_ASP.NET_802.modeles;

namespace Ghani_Projet_ASP.NET_802.Pages.employes
{
    public class IndexModel : PageModel
    {
        private readonly Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context _context;

        public IndexModel(Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context context)
        {
            _context = context;
        }

        public IList<Employes> Employes { get;set; }

        public async Task OnGetAsync()
        {
            Employes = await _context.Employes.ToListAsync();
        }
    }
}
