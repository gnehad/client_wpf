using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ghani_Projet_ASP.NET_802.Data;
using Ghani_Projet_ASP.NET_802.modeles;

namespace Ghani_Projet_ASP.NET_802.Pages.employes
{
    public class CreateModel : PageModel
    {
        private readonly Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context _context;

        public CreateModel(Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employes Employes { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employes.Add(Employes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
