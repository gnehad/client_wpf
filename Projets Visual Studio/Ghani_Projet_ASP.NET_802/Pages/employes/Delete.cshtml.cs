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
    public class DeleteModel : PageModel
    {
        private readonly Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context _context;

        public DeleteModel(Ghani_Projet_ASP.NET_802.Data.Ghani_Projet_ASPNET_802Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Employes Employes { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employes = await _context.Employes.FirstOrDefaultAsync(m => m.EmployeID == id);

            if (Employes == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employes = await _context.Employes.FindAsync(id);

            if (Employes != null)
            {
                _context.Employes.Remove(Employes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
